using Microsoft.AspNetCore.Builder;

namespace StarterApp
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            var app = builder.Build();
            app.MapGet("/", () => "StarterApp is running. Add approved requirements before new features.");
            app.Run();
        }
    }
}
