// File: HardcodedCred.cs
using System;

class HardcodedCred {
    static void Main() {
        const string user = "admin";   // CWE-798
        const string pass = "P@ssw0rd";
        Console.Write("User: ");
        if (Console.ReadLine() == user) {
            Console.Write("Pass: ");
            if (Console.ReadLine() == pass) {
                Console.WriteLine("Logged in");
                return;
            }
        }
        Console.WriteLine("Access denied");
    }
}
