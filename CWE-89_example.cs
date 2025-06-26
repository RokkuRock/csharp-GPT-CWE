// File: SqlInjection.cs
using System;
using System.Data.SqlClient;

class SqlInjection {
    static void Main() {
        var conn = new SqlConnection("Data Source=(local);Initial Catalog=TestDb;Integrated Security=true");
        conn.Open();
        Console.Write("Username: ");
        string u = Console.ReadLine();
        Console.Write("Password: ");
        string p = Console.ReadLine();
        // CWE-89: 直接串接 u 和 p
        string q = $"SELECT COUNT(*) FROM Users WHERE Username='{u}' AND Password='{p}'";
        using var cmd = new SqlCommand(q, conn);
        int count = (int)cmd.ExecuteScalar();
        Console.WriteLine(count > 0 ? "Welcome" : "Access Denied");
        conn.Close();
    }
}
