// File: CmdInject.cs
using System;
using System.Diagnostics;

class CmdInject {
    static void Main(){
        Console.Write("Folder to list: ");
        var dir = Console.ReadLine();
        var psi = new ProcessStartInfo("cmd.exe", "/c dir " + dir); // CWE-78
        psi.RedirectStandardOutput = true;
        var p = Process.Start(psi);
        Console.WriteLine(p.StandardOutput.ReadToEnd());
    }
}
