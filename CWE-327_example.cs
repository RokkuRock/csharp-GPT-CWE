// File: WeakCrypto.cs
using System;
using System.Security.Cryptography;
using System.Text;

class WeakCrypto {
    static void Main() {
        byte[] key = Encoding.UTF8.GetBytes("statickey");
        // CWE-327: 使用 MD5 而非 SHA-2/3
        using var hmac = new HMACMD5(key);
        byte[] sig = hmac.ComputeHash(Encoding.UTF8.GetBytes("sensitive-data"));
        Console.WriteLine(BitConverter.ToString(sig).Replace("-", ""));
    }
}
