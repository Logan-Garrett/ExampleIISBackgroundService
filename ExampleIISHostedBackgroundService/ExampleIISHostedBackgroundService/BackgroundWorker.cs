
namespace ExampleIISHostedBackgroundService
{
    public class BackgroundWorker : BackgroundService
    {
        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                Console.WriteLine("Background Worker Is Running.");

                // Do Work

                await Task.Delay(1000);
            }
        }
    }
}
