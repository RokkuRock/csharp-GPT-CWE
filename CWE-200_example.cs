// File: InfoLeak.cs
using System;
using System.IO;

class InfoLeak {
    static void Main(){
        Console.Write("Enter config file path: ");
        var fn = Console.ReadLine();
        try {
            var txt = File.ReadAllText(fn);
            Console.WriteLine(txt);
        } catch (Exception ex){
            Console.WriteLine("Error reading file: " + ex); // CWE-200
        }
    }
}
