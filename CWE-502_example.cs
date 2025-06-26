// InsecureDeser.cs
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
class Data { public string Msg; }

class InsecureDeser {
    static void Main() {
        Console.Write("Enter serialized file (e.g. payload.bin): ");
        string file = Console.ReadLine();
        // CWE-502: 未檢查來源直接反序列化
        var bf = new BinaryFormatter();
        using var fs = File.OpenRead(file);
        var obj = bf.Deserialize(fs);
        Console.WriteLine("Got object: " + obj.GetType().Name);
    }
}
