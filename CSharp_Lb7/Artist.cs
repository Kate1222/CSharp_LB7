namespace CSharp_Lb7
{
    public class Artist
    {
        public string ArtistName { get; set; } = string.Empty;
        public List<Album> Albums { get; set; } = new List<Album>();
    }
}