/// File: Program.cs 
/// Purpose: Defines the program entry point. This class will also define the command line interface of the application in future release. 
/// Version: 1.0(beta)
/// Date: 25, 7, 2019. 

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
using System.Windows.Forms;

namespace PNG2ICO
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMain());
        }
    }
}
