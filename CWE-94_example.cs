// File: CodeInject.cs
using System;
using Microsoft.CSharp;
using System.CodeDom.Compiler;

class CodeInject {
    static void Main(){
        Console.Write("Enter method body, e.g. return 1+2; : ");
        var body = Console.ReadLine();
        string src = @"
using System;
public class D {
  public int Run(){ " + body + @" }
}";
        var cp = new CompilerParameters { GenerateInMemory = true };
        var res = new CSharpCodeProvider().CompileAssemblyFromSource(cp, src);
        if (res.Errors.Count > 0){
            Console.WriteLine("Compile error");
        } else {
            var inst = res.CompiledAssembly.CreateInstance("D");
            Console.WriteLine(inst.GetType().GetMethod("Run").Invoke(inst,null));
        }
    }
}
