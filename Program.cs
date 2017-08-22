using System;
using Microsoft.AspNetCore.Hosting;

namespace hello_dotnet
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("Hello World!");

			var host = new WebHostBuilder()
			.UseKestrel()
			.UseStartup<Startup>()
			.Build();

			host.Run();
        }
    }
}
