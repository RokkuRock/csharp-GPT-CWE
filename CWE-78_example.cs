// File: CmdInjection.cs
using System;
using System.Diagnostics;

class CmdInjection {
    static void Main() {
        Console.Write("Enter folder to list: ");
        string folder = Console.ReadLine();
        // CWE-78: 未驗證 folder，可能注入 `& del sensitive.txt`
        Process.Start(new ProcessStartInfo {
            FileName = "cmd.exe",
            Arguments = "/c dir " + folder,
            RedirectStandardOutput = true,
            UseShellExecute = false
        }).StandardOutput.Dump();
    }
}

static class Ext {
    public static void Dump(this System.IO.StreamReader sr) {
        Console.WriteLine(sr.ReadToEnd());
    }
}
