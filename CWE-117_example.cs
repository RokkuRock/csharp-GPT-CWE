// LogInjection.cs
using System;
using System.IO;

class LogInjection {
    static void Main() {
        Console.Write("Enter your message: ");
        string msg = Console.ReadLine();
        // CWE-117: 未中和 CRLF，可偽造其他日誌行
        File.AppendAllText("app.log", DateTime.Now + " - " + msg + "\n");
        Console.WriteLine("Logged.");
    }
}
