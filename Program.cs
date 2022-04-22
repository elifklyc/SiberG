using System;
using System.Diagnostics;

namespace SiberG
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            Console.WriteLine("Lütfen ip adresinizi girin: ");
            a = Console.ReadLine();
            Process process = new Process();
            // Configure the process using the StartInfo properties.
            process.StartInfo.FileName = "nmap.exe";
            process.StartInfo.Arguments = "nmap -T4 -A -v " + a;
            process.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
            process.Start();
            process.WaitForExit();// Waits here for the process to exit.

        }
    }
}