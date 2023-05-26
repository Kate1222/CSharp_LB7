namespace CSharp_Lb7
{
    public class Album
    {
        public string AlbumName { get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public int CountTracks { get; set; } = 0;
        public List<string> Genres { get; set; } = new List<string>();
        public List<Track> Tracks { get; set; } = new List<Track>();
    }
}