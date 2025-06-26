// PathTraversal.cs
using System;
using System.IO;

class PathTraversal {
    static void Main() {
        Console.Write("Enter filename under data/: ");
        string fn = Console.ReadLine();
        // CWE-22: 未過濾 '../' 可讀取任意路徑
        string path = Path.Combine("data", fn);
        string content = File.ReadAllText(path);
        Console.WriteLine("Content:\n" + content);
    }
}
