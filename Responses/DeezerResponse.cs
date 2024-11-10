using DeezerSearch.Models;

namespace DeezerSearch.Responses;

public class DeezerResponse
{
    public List<TrackData> Data { get; set; } = new();
}
