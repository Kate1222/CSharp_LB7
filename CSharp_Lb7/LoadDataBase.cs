using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Lb7
{
    internal class LoadDataBase
    {
        private DataBase _dataBase = new DataBase();

        public List<Artist> LoadFunc()
        {
            string databaseQuery = @"SELECT 
                    a.ArtistId,
                    a.ArtistName,
                    al.AlbumId,
                    al.AlbumName,
                    al.Year,
                    al.CountTracks,
                    g.GenreId,
                    g.GenreName,
                    t.TrackId,
                    t.TrackName,
                    t.TrackLength
                FROM Table_Artist a
                INNER JOIN Table_Album al ON a.ArtistId = al.ArtistId
                INNER JOIN Table_AlbumGenre ag ON al.AlbumId = ag.AlbumId
                INNER JOIN Table_Genre g ON ag.GenreId = g.GenreId
                INNER JOIN Table_Track t ON al.AlbumId = t.AlbumId";
            List<Artist> artists = new List<Artist>();
            _dataBase.openConnection();
            using (SqlCommand command = new SqlCommand(databaseQuery, _dataBase.getConnection()))
            {
                Dictionary<int, Artist> artistMap = new Dictionary<int, Artist>();
                Dictionary<int, Album> albumMap = new Dictionary<int, Album>();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int artistId = reader.GetInt32(reader.GetOrdinal("ArtistId"));
                        if (!artistMap.ContainsKey(artistId))
                        {
                            string artistName = reader.GetString(reader.GetOrdinal("ArtistName"));
                            Artist artist = new Artist { ArtistName = artistName };
                            artistMap.Add(artistId, artist);
                            artists.Add(artist);
                        }

                        Artist currentArtist = artistMap[artistId];

                        int albumId = reader.GetInt32(reader.GetOrdinal("AlbumId"));
                        if (!albumMap.ContainsKey(albumId))
                        {
                            string albumName = reader.GetString(reader.GetOrdinal("AlbumName"));
                            int year = reader.GetInt32(reader.GetOrdinal("Year"));
                            int countTracks = reader.GetInt32(reader.GetOrdinal("CountTracks"));

                            Album album = new Album
                            {
                                AlbumName = albumName,
                                Year = year,
                                CountTracks = countTracks,
                                Genres = new List<string>(),
                                Tracks = new List<Track>()
                            };
                            albumMap.Add(albumId, album);
                            currentArtist.Albums.Add(album);
                        }

                        Album currentAlbum = albumMap[albumId];

                        int genreId = reader.GetInt32(reader.GetOrdinal("GenreId"));
                        string genreName = reader.GetString(reader.GetOrdinal("GenreName"));
                        if (!currentAlbum.Genres.Contains(genreName))
                        {
                            currentAlbum.Genres.Add(genreName);
                        }

                        int trackId = reader.GetInt32(reader.GetOrdinal("TrackId"));
                        string trackName = reader.GetString(reader.GetOrdinal("TrackName"));
                        DateTime trackLength = reader.GetDateTime(reader.GetOrdinal("TrackLength"));
                        Track newTrack = new Track
                        {
                            TrackName = trackName,
                            TrackLength = trackLength
                        };
                        bool save = true;
                        if (currentAlbum.Tracks.Count > 0)
                        {
                            Track findThisTrack = currentAlbum.Tracks.Find(tr => tr.Equals(newTrack));
                            if (findThisTrack != null)
                                save = false;
                        }
                        if (save)
                            currentAlbum.Tracks.Add(newTrack);
                    }
                }
            }
            _dataBase.closeConnection();
            return TrackFilter(artists);
        }

        public List<Artist> TrackFilter(List<Artist> artists)
        {
            foreach (Artist artist in artists)
            {
                foreach (Album album in artist.Albums)
                {
                    HashSet<string> uniqueTracks = new HashSet<string>();

                    List<Track> filteredTracks = new List<Track>();

                    foreach (Track track in album.Tracks)
                    {
                        if (!uniqueTracks.Contains(track.TrackName))
                        {
                            uniqueTracks.Add(track.TrackName);

                            filteredTracks.Add(track);
                        }
                    }

                    album.Tracks = filteredTracks;
                }
            }
            return artists;
        }
    }
}
