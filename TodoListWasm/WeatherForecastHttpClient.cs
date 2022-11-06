using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

public class WeatherForecastHttpClient
{
    private readonly HttpClient http;

    public WeatherForecastHttpClient(HttpClient http)
    {
        this.http = http;
    }

    public async Task<WeatherForecast[]> GetForecastAsync()
    {
        try
        {
            return await http.GetFromJsonAsync<WeatherForecast[]>("sample-data/weather.json");
        }
        catch
        {
            return new WeatherForecast[0];
        }
    }
}