using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;

namespace hello_dotnet
{
	public class Startup
    {
		public void Configure(IApplicationBuilder app)
		{
			app.Run(context => {
				return context.Response.WriteAsync("Hello world");
			});

		}
    }
}
