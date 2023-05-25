using System;
using System.Collections.Generic;

namespace CSharp_Lb7
{
    internal class Track
    {
        public string TrackName { get; set; } = string.Empty;
        public DateTime TrackLength { get; set; } = DateTime.Now;
    }

    internal class Album
    {
        public string AlbumName { get; set; } = string.Empty;
        public int Year { get; set; } = 0;
        public int CountTracks { get; set; } = 0;
        public List<string> Genres { get; set; } = new List<string>();
        public List<Track> Tracks { get; set; } = new List<Track>();
    }

    internal class Artist
    {
        public string ArtistName { get; set; } = string.Empty;
        public List<Album> Albums { get; set; } = new List<Album>();
    }
}
