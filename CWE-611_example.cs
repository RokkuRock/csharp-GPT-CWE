// XxeExample.cs
using System;
using System.Xml;

class XxeExample {
    static void Main() {
        Console.Write("Enter XML file path: ");
        string xml = Console.ReadLine();
        // CWE-611: XmlDocument 預設允許外部實體
        var doc = new XmlDocument();
        doc.Load(xml);
        Console.WriteLine("Root element: " + doc.DocumentElement.Name);
    }
}
