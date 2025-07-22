namespace ExampleIISHostedBackgroundService
{
    class Program
    {
        static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddHostedService<BackgroundWorker>();

            var app = builder.Build();

            app.MapGet("/", () => "IIS Application Is Running!");

            app.Run();
        }
    }
}