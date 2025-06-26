// File: InfoLeak.cs
using System;
using System.IO;

class InfoLeak {
    static void Main(string[] args) {
        try {
            string path = args.Length>0 ? args[0] : "nofile.txt";
            string txt = File.ReadAllText(path); // 可能拋出異常
            Console.WriteLine(txt);
        } catch (Exception ex) {
            // CWE-200: 洩漏完整例外資訊
            Console.WriteLine("Error: " + ex.ToString());
        }
    }
}
