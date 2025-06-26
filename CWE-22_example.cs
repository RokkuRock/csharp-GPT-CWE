// File: PathTraversal.cs
using System;
using System.IO;

class PathTraversal {
    static void Main(){
        Console.Write("Enter filename in safe/: ");
        var fn = Console.ReadLine();
        var path = Path.Combine("safe", fn); // CWE-22
        var content = File.ReadAllText(path);
        Console.WriteLine(content);
    }
}
