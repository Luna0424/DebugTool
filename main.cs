using System;
using System.Windows.Forms;
using System.Security;
using System.Security.Permissions;
using System.Reflection;
using System.Diagnostics;

namespace myform
{
    class Program
    {
        static void Main(string[] args)
        {
            bool SfcC = false;
            bool DismC = false;
            //Icon icon = Icon.ExtractAssociatedIcon("icon.ico");

            Form myform = new Form()
            {
                Height = 500,
                Width = 400,
                //Icon = icon
            };

            Button SFC = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "SFC",
                Location = new System.Drawing.Point(10, 10)
            };
            SFC.Click += (o, s) =>
            {
                if(SfcC == false){
                    SfcC = true;
                    SFC.Text = "SFC ✓";
                }else if(SfcC == true){
                    SfcC = false;
                    SFC.Text = "SFC";
                }
            };

            Button DISM = new Button()
            {
                Height = 100,
                Width = 100,
                Text = "DISM",
                Location = new System.Drawing.Point(120, 10)
            };
            DISM.Click += (o ,s) =>
            {
                if(DismC == false){
                    DismC = true;
                    DISM.Text = "DISM ✓";
                }else if(DismC == true){
                    DismC = false;
                    DISM.Text = "DISM";
                }
                /*var process = System.Diagnostics.Process.Start("CMD.exe", "/C sfc /scannow");
                process.WaitForExit();
                Console.WriteLine("System File Checker - Done");*/
            };

            Button btn = new Button()
            {
                Height = 50,
                Width = 100,
                Text = "RUN",
                Location = new System.Drawing.Point(10, 200)
            };
            btn.Click += (o ,s) =>
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


            myform.Controls.Add(SFC);
            myform.Controls.Add(DISM);
            myform.Controls.Add(btn);
            myform.ShowDialog();

            while (myform.Created)
            {

            }
        }
    }
}