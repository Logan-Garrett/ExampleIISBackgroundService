
namespace ExampleIISHostedBackgroundService
{
    public class BackgroundWorker : BackgroundService
    {
        private readonly ILogger<BackgroundWorker> _logger;

        public BackgroundWorker(ILogger<BackgroundWorker> logger)
        {
            _logger = logger;
        }

        protected override async Task ExecuteAsync(CancellationToken stoppingToken)
        {
            while (!stoppingToken.IsCancellationRequested)
            {
                // _logger.LogInformation("Background Worker is running at: {time}", DateTimeOffset.Now);
                Console.WriteLine($"Background Worker is running at: {DateTimeOffset.Now}");

                // Do Work

                await Task.Delay(1000, stoppingToken);
            }
        }
    }
}
