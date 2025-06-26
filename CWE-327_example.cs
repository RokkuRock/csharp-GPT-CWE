// WeakCrypto.cs
using System;
using System.Security.Cryptography;
using System.Text;

class WeakCrypto {
    static void Main() {
        string data = "sensitive-data";
        string key  = "hardcoded-key";
        // CWE-327: 使用 MD5 而非更強演算法
        using var hmac = new HMACMD5(Encoding.UTF8.GetBytes(key));
        byte[] sig = hmac.ComputeHash(Encoding.UTF8.GetBytes(data));
        Console.WriteLine("Signature: " + BitConverter.ToString(sig));
    }
}
