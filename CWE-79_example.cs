// File: XSS.cs
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

var builder = WebApplication.CreateBuilder();
var app = builder.Build();

app.MapGet("/", async ctx => {
    var msg = ctx.Request.Query["msg"];
    await ctx.Response.WriteAsync($"<h1>Hello {msg}</h1>"); // CWE-79
});

app.Run("http://localhost:5001");
