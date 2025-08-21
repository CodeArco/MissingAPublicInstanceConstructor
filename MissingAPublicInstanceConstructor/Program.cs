using Microsoft.Extensions.Configuration;
using MissingAPublicInstanceConstructor;
using System.Reflection;

internal class Program
{
    private static void Main(string[] args)
    {
        var build = new ConfigurationBuilder()
        .AddJsonFile("appsettings.json")
        .Build();

        // Alternative 1
        var config1 = build.Get<Config>();

        // Alternative 2
        var config2 = new Config();
        build.Bind(config2);

        // Output
        Console.WriteLine($"config1?.PropString: '{config1?.PropString}'");
        Console.WriteLine($"config1?.PropClass1.PropString: '{config1?.PropClass1.PropString}'");

        Console.WriteLine($"config2.PropString: '{config2.PropString}'");
        Console.WriteLine($"config2.PropClass1.PropString: '{config2.PropClass1.PropString}'");

        Console.ReadLine();
    }
}