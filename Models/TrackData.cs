namespace DeezerSearch.Models;

public partial class TrackData
{
    public long Id { get; set; }
    public string Title { get; set; }
    public string Link { get; set; }
    public long Duration { get; set; }
    public long Rank { get; set; }
    public string Preview { get; set; }
    public Artist Artist { get; set; }
    public Album Album { get; set; }
    public string Type { get; set; }
}

public partial class Album
{
    public Uri Cover_medium { get; set; }
}

public partial class Artist
{
    public string Name { get; set; }
    public Uri PictureMedium { get; set; }
}