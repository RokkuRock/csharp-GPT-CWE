// File: SqlInject.cs
using System;
using Microsoft.Data.Sqlite;

class SqlInject {
    static void Main(){
        var conn = new SqliteConnection("Data Source=:memory:");
        conn.Open();
        conn.CreateCommand().CommandText =
            "CREATE TABLE users(u TEXT, p TEXT); INSERT INTO users VALUES('admin','secret');";
        conn.ExecuteNonQuery();

        Console.Write("User: ");
        var u = Console.ReadLine();
        Console.Write("Pass: ");
        var p = Console.ReadLine();

        string q = $"SELECT COUNT(*) FROM users WHERE u='{u}' AND p='{p}';"; // CWE-89
        var cmd = conn.CreateCommand();
        cmd.CommandText = q;
        var cnt = Convert.ToInt32(cmd.ExecuteScalar());
        Console.WriteLine(cnt > 0 ? "OK" : "Fail");
    }
}
