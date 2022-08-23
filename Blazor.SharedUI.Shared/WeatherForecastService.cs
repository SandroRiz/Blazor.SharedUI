namespace Blazor.SharedUI.Shared
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
        "FreddoBecco", "Freddo", "Fresco", "CosìCosì", "Calduccio",  "Caldo", "Afa", "Bollente"
    };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            }).ToArray());
        }
    }
}