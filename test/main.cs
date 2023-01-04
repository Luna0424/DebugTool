using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Threading;

namespace myform
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SfcC = false;
            bool DismC = false;
            bool CopyC = false;

            Form myform = new Form()
            {
                Height = 500,
                Width = 400,
            };

            var dir = Directory.GetCurrentDirectory();
            FileInfo f = new FileInfo(dir);    
            string drive = Path.GetPathRoot(f.FullName);
            //Console.WriteLine(drive);


            //WINGET
            bool chrome_ins = false;
            bool firefox_ins = false;
            bool opera_ins = false;
            bool steam_ins = false;
            bool discord_ins = false;
            bool update_ins = false;


            Label WinGet_L = new Label(){
                Height = 25,
                Width = 500,
                Text = "Chose What you want to install",
                Location = new Point(120, 10),
                Visible = false
            };
            //Web Browsers
            Button chrome = new Button(){
                Height = 25,
                Width = 120,
                Text = "Google Chrome",
                Location = new Point(20, 40),
                Visible = false
            };
            chrome.Click += (o ,s) => {
                if(chrome_ins == false){
                    chrome_ins = true;
                    chrome.Text = "Google Chrome ✓";
                }else if(chrome_ins == true){
                    chrome_ins = false;
                    chrome.Text = "Google Chrome";
                }
            };

            Button firefox = new Button(){
                Height = 25,
                Width = 120,
                Text = "Firefox",
                Location = new Point(20, 70),
                Visible = false
            };
            firefox.Click += (o ,s) => {
                if(firefox_ins == false){
                    firefox_ins = true;
                    firefox.Text = "Firefox ✓";
                }else if(firefox_ins == true){
                    firefox_ins = false;
                    firefox.Text = "Firefox";
                }
            };

            Button opera = new Button(){
                Height = 25,
                Width = 120,
                Text = "Opera",
                Location = new Point(20, 100),
                Visible = false
            };
            opera.Click += (o ,s) => {
                if(opera_ins == false){
                    opera_ins = true;
                    opera.Text = "Opera ✓";
                }else if(opera_ins == true){
                    opera_ins = false;
                    opera.Text = "Opera";
                }
            };
            //Software
            Button steam = new Button(){
                Height = 25,
                Width = 120,
                Text = "Steam",
                Location = new Point(20, 150),
                Visible = false
            };
            steam.Click += (o ,s) => {
                if(steam_ins == false){
                    steam_ins = true;
                    steam.Text = "Steam ✓";
                }else if(steam_ins == true){
                    steam_ins = false;
                    steam.Text = "Steam";
                }
            };
            Button discord = new Button(){
                Height = 25,
                Width = 120,
                Text = "Discord",
                Location = new Point(20, 180),
                Visible = false
            };
            discord.Click += (o ,s) => {
                if(discord_ins == false){
                    discord_ins = true;
                    discord.Text = "Discord ✓";
                }else if(discord_ins == true){
                    discord_ins = false;
                    discord.Text = "Discord";
                }
            };

            //Command
            Button update = new Button(){
                Height = 25,
                Width = 120,
                Text = "Update /all",
                Location = new Point(20, 230),
                Visible = false
            };
            update.Click += (o ,s) => {
                if(update_ins == false){
                    update_ins = true;
                    update.Text = "Update /all ✓";
                }else if(update_ins == true){
                    update_ins = false;
                    update.Text = "Update /all";
                }
            };
            Button WinGet_Back = new Button(){
                Height = 50,
                Width = 100,
                Text = "Confirm",
                Visible = false,
                Location = new System.Drawing.Point(10, 300)
            };
            







            //DEBUG
            Button SFC = new Button(){
                Height = 100,
                Width = 100,
                Text = "SFC",
                Location = new System.Drawing.Point(10, 10)
            };
            SFC.Click += (o, s) =>{
                if(SfcC == false){
                    SfcC = true;
                    SFC.Text = "SFC ✓";
                }else if(SfcC == true){
                    SfcC = false;
                    SFC.Text = "SFC";
                }
            };

            Button DISM = new Button(){
                Height = 100,
                Width = 100,
                Text = "DISM",
                Location = new System.Drawing.Point(120, 10)
            };
            DISM.Click += (o ,s) =>{
                if(DismC == false){
                    DismC = true;
                    DISM.Text = "DISM ✓";
                }else if(DismC == true){
                    DismC = false;
                    DISM.Text = "DISM";
                }
            };

            Button Copy = new Button(){
                Height = 100,
                Width = 100,
                Text = "Copy",
                Location = new System.Drawing.Point(10, 120)
            };
            Copy.Click += (o, s) =>{
                if(CopyC == false){
                    CopyC = true;
                    Copy.Text = "Copy ✓";
                }else if(CopyC == true){
                    CopyC = false;
                    Copy.Text = "Copy";
                }
            };


            //run button
            Button RUN = new Button(){
                Height = 50,
                Width = 100,
                Text = "RUN",
                Location = new System.Drawing.Point(10, 300)
            };
            RUN.Click += (o ,s) =>{
                //Reset Log
                System.Diagnostics.Process.Start("CMD.exe", "/C clear > log.txt");
                //WinGet
                //Web Browsers
                if(chrome_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget install Google.Chrome");
                    process.WaitForExit();
                    Console.WriteLine("Installing Chrome - Done");
                }
                if(firefox_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget install Mozilla.Firefox");
                    process.WaitForExit();
                    Console.WriteLine("Installing Firefox - Done");
                }
                if(opera_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget install -e --id Opera.Opera");
                    process.WaitForExit();
                    Console.WriteLine("Installing Opera - Done");
                }
                //Software
                if(steam_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget install Valve.Steam");
                    process.WaitForExit();
                    Console.WriteLine("Installing Steam - Done");
                }
                if(discord_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget install Discord.Discord");
                    process.WaitForExit();
                    Console.WriteLine("Installing Discord - Done");
                }

                //command
                if(update_ins == true){
                    var process = System.Diagnostics.Process.Start("CMD.exe", "/C winget upgrade --all");
                    process.WaitForExit();
                    Console.WriteLine("Update - Done");
                }

                //Debuger
                if(SfcC == true){
                var process = System.Diagnostics.Process.Start("CMD.exe", "/C sfc /scannow >> log.txt");
                process.WaitForExit();
                Console.WriteLine("System File Checker - Done");
                SfcC = false;
                }
                if(DismC == true){
                var process = System.Diagnostics.Process.Start("CMD.exe", "/C DISM /Online /Cleanup-Image /RestoreHealth >> log.txt");
                process.WaitForExit();
                Console.WriteLine("Deployment Image Servicing and Management Fix - Done");
                DismC = false;
                }
                if(CopyC == true){
                    //var command = "";
                    /*Process p = new Process();
                    p.StartInfo.UseShellExecute = false;
                    p.StartInfo.RedirectStandardOutput = true;
                    p.StartInfo.FileName = @"C:\Windows\System32\WindowsPowerShell\v1.0\powershell.exe";
                    p.StartInfo.RedirectStandardInput = true;
                    p.Start();
                    /*if(!Directory.Exists(drive + @"C\")){
                        p.StandardInput.WriteLine("mkdir " + drive + @"C\");
                    }*//*
                    Console.WriteLine("Unlocking Scripts");
                    p.StandardInput.WriteLine("Set-ExecutionPolicy RemoteSigned");
                    Thread.Sleep(5000);
                    p.StandardInput.WriteLine("A");
                    p.WaitForExit();
                    Console.WriteLine("Done");*/




                    // Get information about the source directory
                    var dir = new DirectoryInfo(@"C:\users");

                    // Check if the source directory exists
                    if (!dir.Exists)
                        throw new DirectoryNotFoundException($"Source directory not found: {dir.FullName}");

                    // Cache directories before we start copying
                    DirectoryInfo[] dirs = dir.GetDirectories();

                    // Create the destination directory
                    Directory.CreateDirectory(destinationDir);

                    // Get the files in the source directory and copy to the destination directory
                    foreach (FileInfo file in dir.GetFiles())
                    {
                        string targetFilePath = Path.Combine(destinationDir, file.Name);
                        file.CopyTo(targetFilePath);
                    }

                    // If recursive and copying subdirectories, recursively call this method
                    if (recursive)
                    {
                        foreach (DirectoryInfo subDir in dirs)
                        {
                            string newDestinationDir = Path.Combine(destinationDir, subDir.Name);
                            CopyDirectory(subDir.FullName, newDestinationDir, true);
                        }
                    }



                    CopyC = false;
                }



                Console.WriteLine("DONE");
            };

            Button WinGet = new Button(){
                Height = 100,
                Width = 100,
                Text = "Winget",
                Location = new System.Drawing.Point(240, 10)
            };
            WinGet.Click += (o ,s) => {
                SFC.Visible = false;
                DISM.Visible = false;
                Copy.Visible = false;
                WinGet.Visible = false;
                RUN.Visible = false;

                //WinGet Menu
                WinGet_L.Visible = true;
                chrome.Visible = true;
                firefox.Visible = true;
                opera.Visible = true;
                steam.Visible = true;
                discord.Visible = true;
                update.Visible = true;
                WinGet_Back.Visible = true;
            };
            WinGet_Back.Click += (o ,s) => {
                SFC.Visible = true;
                DISM.Visible = true;
                Copy.Visible = true;
                WinGet.Visible = true;
                RUN.Visible = true;

                //WinGet Menu
                WinGet_L.Visible = false;
                chrome.Visible = false;
                firefox.Visible = false;
                opera.Visible = false;
                steam.Visible = false;
                discord.Visible = false;
                update.Visible = false;
                WinGet_Back.Visible = false;
            };

            

            myform.Controls.Add(SFC);
            myform.Controls.Add(DISM);
            myform.Controls.Add(WinGet);
            myform.Controls.Add(Copy);

            //WinGet
            myform.Controls.Add(WinGet_L);
            myform.Controls.Add(chrome);
            myform.Controls.Add(firefox);
            myform.Controls.Add(opera);
            myform.Controls.Add(steam);
            myform.Controls.Add(discord);
            myform.Controls.Add(update);
            myform.Controls.Add(WinGet_Back);

            myform.Controls.Add(RUN);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}