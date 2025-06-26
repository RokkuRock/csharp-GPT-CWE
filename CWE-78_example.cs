// CmdInjection.cs
using System;
using System.Diagnostics;

class CmdInjection {
    static void Main() {
        Console.Write("Enter directory to list: ");
        string dir = Console.ReadLine();
        // CWE-78: 未經驗證的 user input，直接拼接到 shell 命令
        var psi = new ProcessStartInfo("cmd.exe", "/c dir " + dir) {
            RedirectStandardOutput = true,
            UseShellExecute = false
        };
        var p = Process.Start(psi);
        Console.WriteLine(p.StandardOutput.ReadToEnd());
    }
}
