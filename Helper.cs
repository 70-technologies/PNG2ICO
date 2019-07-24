/// File: PNG2ICO.cs
/// Purpose: Defines the PNG to ICON converter and its functions
/// Version: 1.0 (beta)
/// Date: March, 6, 2019. 

/* 
Copyright (c) 2019, All rights are reserved by AB, 70 Technlogies
https://www.tech70.cf

This program is licensed under the Apache License, Version 2.0 (the "License");
you may not download, install or use this program except in compliance with the License.
You may obtain a copy of the License at

    http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
*/


using System;
using System.Drawing;
using System.IO;

namespace PNG2ICO
{
    /// <summary>
    /// Contains static methods used to convert and resize images. 
    /// </summary>
    public static class Png2Ico
    {
        /// <summary>
        /// Scales the input image by specified size. 
        /// </summary>
        /// <param name="PNG">The PNG image object</param>
        /// <param name="targetSize">The size to scale by</param>
        /// <returns></returns>
        public static Image Resize(this Image PNG, Size targetSize, bool keepAspectRatio = false)
        {
            //Check if input image's size is less than output size, if it is: return the image in full size.
            int newHeight = 0, newWidth = 0;

            if (PNG.Size.Height < targetSize.Height)
                newHeight = PNG.Size.Height;
            else
                newHeight = targetSize.Height;
            if (PNG.Size.Width < targetSize.Width)
                newWidth = PNG.Width;
            else
                newWidth = targetSize.Width;
            var newBitMap = new System.Drawing.Bitmap(PNG, new Size(newWidth, newHeight));
            return newBitMap;
        }

        /// <summary>
        /// Converts a PNG image into an ICON in specified sizes. 
        /// </summary>
        /// <param name="pngFile">The PNG image stream</param>
        /// <param name="outputIcon">The ICON output stream</param>
        /// <param name="outputSizes">Specify different icon sizes to include in output file. All the sizes must be different. </param>
        public static void Convert(Stream inputStream, Stream outputStream, Size[] outputSizes, bool keepAspectRatio = false)
        {
            //Create the binary writer object used to write the data to the output stream. 
            var writer = new System.IO.BinaryWriter(outputStream);
            try
            {
                //Check the input stream 
                if (inputStream == null || inputStream.CanRead == false)
                    throw new System.IO.IOException("Invalid Input File (the input stream is un-readable)");

                /// HEADERS
                /// BYTE ORDER: LITTLE-ENDIAN
                /// -------------------------------------------
                /// --OFFSET---SIZE---DESCRIPTION--------------
                /// |   0   |   2   | Reserved. Must be 0. 
                /// |   2   |   2   | Image type. 1 for icon (.ico), 2 for cursor. Other values are invalid
                /// |   4   |   2   | Specifies number of images in the file.
                /// |       |   6   | Total size of file header 
                /// -------------------------------------------
                /// -------ICONDIRENTRY-STRUCTURE--------------
                /// -------------------------------------------
                /// --OFFSET---SIZE---DESCRIPTION--------------
                /// |   0   |   1   | Image width in pixels. 0-255. 0 = 256. 
                /// |   1   |   1   | Image height in pixels. 0-255. 0 = 256. 
                /// |   2   |   1   | Number of colors in palette. 0 if no color pallete is used. 
                /// |   3   |   1   | Reserved. Should be 0. 
                /// |   4   |   2   | Color Planes: Should be 0 or 1. 
                /// |   6   |   2   | Specifies bits per pixel. 
                /// |   8   |   4   | Size of image data in bytes
                /// |   12  |   4   | Offset of the actual image data in the file.
                /// |       |   16  | Total size of one imagedirentry.
                /// -------------------------------------------
                ///////////////
                /// ALGORITHM
                /// 1.  Write the main file headers (i.e. Type of the image, and number of images it contains)
                /// 2.  Calculate the size of headers of all the icon variants (sizes) using method: 
                ///     totalHeadersSize = mainHeaderSize + (numberOfVariants * size of one imagedirentry)
                /// 3.  Create empty image array for variants. Read images in all the streams scaled with different size.
                /// 4.  Iterate all the image streams and write imagedirentry for each
                ///     4. a. The imagedirentry's offset will be totalHeadersSize + headers already processed. 
                /// 5.  Iterate all the image streams again and write the image data for each. 

                SetStatus("Writing headers...");
                //Offset: 0. Data: Must be zero (reserved). Size: 2 bytes.
                writer.Write((short)0);
                //Offset: 2.  Data: Image type (1 for icon). Size: 2 bytes. 
                writer.Write((short)1);
                //Offset: 4.  Data: Number of images in the file. Size: 2 bytes. 
                writer.Write((short)outputSizes.Length);
                SetStatus("Loading image...");
                /// ICONDIRENTRY  
                long headerSize = 6 + (outputSizes.Length * 16);
                //Read all the different image size variants in memory.
                MemoryStream[] imgStreams = new MemoryStream[outputSizes.Length];
                for (int i = 0; i < imgStreams.Length; i++)
                {
                    var inputImage = (Bitmap)Image.FromStream(inputStream).Resize(outputSizes[i], keepAspectRatio);
                    imgStreams[i] = new MemoryStream();
                    inputImage.Save(imgStreams[i], System.Drawing.Imaging.ImageFormat.Png);
                }
                //Iterate all the size variables and write icon dir entry for each. Having offset values of headerSize + imgStreams[i].Length + lengthOfProcessedImages
                long totalProcessed = 0;
                for (int i = 0; i < imgStreams.Length; i++)
                {
                    SetStatus($"Writing entries {i + 1} of {imgStreams.Length}...");
                    int offset = (int)(headerSize + totalProcessed);
                    var size = outputSizes[i];
                    //Write icondirentry headers
                    //Offset: 0. Data: Image width in pixels. Size: 1 byte. Min: 1. Max: 255. 0=256
                    writer.Write((byte)size.Width);
                    //Offset: 1. Data: Image height in pixels. Size: 1 byte. Min: 1. Max: 255. 0=256
                    writer.Write((byte)size.Height);
                    //Offset: 2. Data: No. of Color Palettes. Size: 1 byte. 0 = None.
                    writer.Write((byte)0);
                    //Offset: 3. Data: Reserverd (must be zero). Size: 1 byte. 
                    writer.Write((byte)0);
                    //Offset: 4. Data: Color Planes. Size: 2 bytes. Should be 0 or 1. 
                    writer.Write((short)0);
                    //Offset: 6. Data: Bits per pixel. Size: 2 bytes. using 32 bits per pixel.
                    writer.Write((short)32);
                    //Offset: 8. Data: Size of PNG image data. Size: 4 bytes. 
                    writer.Write((int)imgStreams[i].Length);
                    //Offset: 12. Data: PNG image data offset in the file. Size: 4 bytes.
                    writer.Write(offset);
                    //Flush the binary writer. 
                    writer.Flush();
                    //Increment the counter so that next header can write correct image data offset. 
                    totalProcessed += imgStreams[i].Length;
                }
                //Iterate through all imgStreams and write them to the final stream.
                for (int i = 0; i < imgStreams.Length; i++)
                {
                    SetStatus($"Writing image data {i + 1} of {imgStreams.Length}...");
                    writer.Write(imgStreams[i].ToArray());
                    writer.Flush();
                }
                //Close the streams.
                writer.Close(); writer = null;
            }
            catch (Exception ex)
            {
                writer.Close(); writer = null;
                SetStatus("ERROR. " + ex.Message);
                throw ex;
            }
        }
        /// <summary>
        /// Converts the PNG image into an ICON image with various sizes. 
        /// </summary>
        /// <param name="inputFile">The PNG image file. </param>
        /// <param name="outputFile">The ICON output file. </param>
        /// <param name="outputSizes">Specify different icon sizes to include in output file. All the sizes must be different. </param>
        public static void Convert(string inputFile, string outputFile, Size[] outputSizes, bool newFileForEachSize, bool keepAspectRatio = false)
        {
            var fsIn = new FileStream(inputFile, FileMode.Open, FileAccess.Read);

            //If newFileForEachSize is declared, use loop through  outputSizes instead of passing whole array.
            if (newFileForEachSize)
            {
                for (int i = 0; i < outputSizes.Length; i++)
                {
                    var fsOut = new FileStream(outputFile.ToLower().Replace(".ico", "_" + outputSizes[i].Width + ".ico"), FileMode.Create, FileAccess.ReadWrite);
                    Convert(fsIn, fsOut, new Size[] { outputSizes[i] }, keepAspectRatio);
                    fsOut.Close();
                    SetStatus("Saved " + i + 1 + " of " + outputSizes.Length);
                }
                SetStatus("Saved in " + Path.GetDirectoryName(outputFile));
            }
            else
            {
                var fsOut = new FileStream(outputFile, FileMode.Create, FileAccess.ReadWrite);
                Convert(fsIn, fsOut, outputSizes, keepAspectRatio);
                fsOut.Close();
                SetStatus("Saved as " + outputFile);
            }
            fsIn.Close();
        }
        private static void SetStatus(string str) => frmMain.INSTANCE.SetStatus(str);
    }
}
