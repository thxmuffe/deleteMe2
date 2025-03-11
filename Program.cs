using System;
using Microsoft.AspNetCore.Builder;

public class Program {

    public static void Main(string[] args) {
        Console.WriteLine("Starting!");
        
        // CreateBuilder creates a builder (a factory)
        var builder = WebApplication.CreateBuilder();

        // builder.Build creates a web app
        var webapi = builder.Build();


        // after that we can use the builder to create the web api
        webapi.Run();


        // once we have the web api, we can start it

        Console.WriteLine("Ending...");
    }
}