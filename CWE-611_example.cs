// File: XxeVuln.cs
using System;
using System.Xml;

class XxeVuln {
    static void Main() {
        var doc = new XmlDocument();
        // CWE-611: 未停用 DTD/外部實體
        doc.Load("user.xml");
        Console.WriteLine("Root: " + doc.DocumentElement.Name);
    }
}
