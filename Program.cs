using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Starting!");
        
        // CreateBuilder creates a builder (a factory)
        var builder = WebApplication.CreateBuilder();
        builder.Services.AddControllers();

        // builder.Build creates a web app
        var webapi = builder.Build();
        webapi.MapControllers();

        // after that we can use the builder to create the web api
        webapi.Run();

        Console.WriteLine("Ending...");
    }
}