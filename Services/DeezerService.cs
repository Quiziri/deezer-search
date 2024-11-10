using DeezerSearch.Responses;

namespace DeezerSearch.Services;

public class DeezerService
{
    private readonly HttpClient _httpClient;

    public DeezerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<DeezerResponse> SearchTracksAsync(string searchTerm) 
    {
        var response = await _httpClient.GetFromJsonAsync<DeezerResponse>($"https://api.deezer.com/search/track?q={searchTerm}");
        return response!;
    }
}