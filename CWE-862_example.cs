// File: MissingAuthz.cs
using System;
using System.IO;

class MissingAuthz {
    static void Main(){
        Console.Write("Role (user/admin)? ");
        var role = Console.ReadLine();
        Console.Write("File to read: ");
        var fn = Console.ReadLine();
        var data = File.ReadAllText(fn); // CWE-862
        Console.WriteLine("Content:\n" + data);
    }
}
