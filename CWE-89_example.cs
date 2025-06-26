// SqlInjection.cs
using System;
using System.Data.SqlClient;

class SqlInjection {
    static void Main() {
        var conn = new SqlConnection("Server=(local);Database=TestDb;Trusted_Connection=True;");
        conn.Open();
        Console.Write("Username: ");
        string u = Console.ReadLine();
        Console.Write("Password: ");
        string p = Console.ReadLine();
        // CWE-89: 直接將使用者輸入串接到 SQL
        string q = $"SELECT COUNT(*) FROM Users WHERE Username='{u}' AND Password='{p}'";
        using var cmd = new SqlCommand(q, conn);
        int count = (int)cmd.ExecuteScalar();
        Console.WriteLine(count > 0 ? "Login success" : "Login failed");
    }
}
