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
             string userpath = System.Environment.GetEnvironmentVariable("USERPROFILE");
            Console.WriteLine(userpath + @"\AppData\Local\Microsoft\Windows\INetCache");

            Console.ReadLine();
        }
    }
}