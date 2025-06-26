// File: CodeInjection.cs
using System;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

class CodeInjection {
    static void Main() {
        Console.Write("Enter C# expression (e.g. return 1+2;): ");
        string body = Console.ReadLine();
        string src = @"
using System;
public class D {
  public int Run() { " + body + @" }
}";
        var cp = new CompilerParameters { GenerateInMemory = true };
        var prov = new CSharpCodeProvider();
        var res = prov.CompileAssemblyFromSource(cp, src);
        if (res.Errors.HasErrors) {
            Console.WriteLine("Compile errors");
        } else {
            dynamic inst = res.CompiledAssembly.CreateInstance("D");
            Console.WriteLine("Result: " + inst.Run());
        }
    }
}
