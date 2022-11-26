using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Drawing;

namespace myform
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SfcC = false;
            bool DismC = false;

            Form myform = new Form()
            {
                Height = 500,
                Width = 400,
            };




            //WINGET
            bool chrome_ins = false;


            Label WinGet_L = new Label(){
                Height = 25,
                Width = 500,
                Text = "Chose What you want to install",
                Location = new Point(120, 10),
                Visible = false
            };

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
                    chrome_ins == false;
                    chrome.Text == "";
                }
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


            Button RUN = new Button()
            {
                Height = 50,
                Width = 100,
                Text = "RUN",
                Location = new System.Drawing.Point(10, 200)
            };
            RUN.Click += (o ,s) =>
            {
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
                
            };

            Button WinGet = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "Winget",
                Location = new System.Drawing.Point(240, 10)
            };
            WinGet.Click += (o ,s) => 
            {
                SFC.Visible = false;
                DISM.Visible = false;
                WinGet.Visible = false;
                RUN.Visible = false;

                //WinGet Menu
                WinGet_L.Visible = true;
                chrome.Visible = true;
            };

            

            myform.Controls.Add(SFC);
            myform.Controls.Add(DISM);
            myform.Controls.Add(WinGet);

            //WinGet
            myform.Controls.Add(WinGet_L);
            myform.Controls.Add(chrome);

            myform.Controls.Add(RUN);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}