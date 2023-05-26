using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    public class UpdateDataBase
    {
        private DataBase _dataBase = new DataBase();

        public void UpdateFunc(Artist artist, Album album)
        {
            _dataBase.openConnection();
            // Check if the artist already exists in the database
            int artistId = GetArtistId(artist.ArtistName, _dataBase.getConnection());

            if (artistId == 0)
                artistId = InsertArtist(artist.ArtistName, _dataBase.getConnection());

            // Insert the new album into the database
            int albumId = InsertAlbum(artistId, album, _dataBase.getConnection());

            // Insert or associate genres with the album
            foreach (string genre in album.Genres)
            {
                int genreId = GetGenreId(genre, _dataBase.getConnection());

                if (genreId == 0)
                    genreId = InsertGenre(genre, _dataBase.getConnection());

                // Check if the album is already associated with the genre
                if (!IsAlbumGenreAssociated(albumId, genreId, _dataBase.getConnection()))
                    InsertAlbumGenre(albumId, genreId, _dataBase.getConnection());
            }

            // Associate tracks with the album
            foreach (Track track in album.Tracks)
            {
                // Check if the track already exists in the album
                if (!IsTrackExistsInAlbum(albumId, track.TrackName, _dataBase.getConnection()))
                    InsertTrack(albumId, track, _dataBase.getConnection());
            }
            _dataBase.closeConnection();
        }

        private static int InsertGenre(string genreName, SqlConnection connection)
        {
            string query = "INSERT INTO Table_Genre (GenreName) VALUES (@GenreName); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GenreName", genreName);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            return 0;
        }

        private static void InsertAlbumGenre(int albumId, int genreId, SqlConnection connection)
        {
            string query = "INSERT INTO Table_AlbumGenre (AlbumId, GenreId) VALUES (@AlbumId, @GenreId)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AlbumId", albumId);
                command.Parameters.AddWithValue("@GenreId", genreId);
                command.ExecuteNonQuery();
            }
        }

        private static void InsertTrack(int albumId, Track track, SqlConnection connection)
        {
            string query = "INSERT INTO Table_Track (AlbumId, TrackName, TrackLength) " +
                           "VALUES (@AlbumId, @TrackName, @TrackLength)";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AlbumId", albumId);
                command.Parameters.AddWithValue("@TrackName", track.TrackName);
                command.Parameters.AddWithValue("@TrackLength", track.TrackLength);
                command.ExecuteNonQuery();
            }
        }

        private static int GetArtistId(string artistName, SqlConnection connection)
        {
            string query = "SELECT ArtistId FROM Table_Artist WHERE ArtistName = @ArtistName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ArtistName", artistName);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            return 0;
        }

        private static int InsertArtist(string artistName, SqlConnection connection)
        {
            string query = "INSERT INTO Table_Artist (ArtistName) VALUES (@ArtistName); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ArtistName", artistName);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            return 0;
        }

        private static int InsertAlbum(int artistId, Album album, SqlConnection connection)
        {
            string query = "INSERT INTO Table_Album (ArtistId, AlbumName, Year, CountTracks) " +
                           "VALUES (@ArtistId, @AlbumName, @Year, @CountTracks); SELECT SCOPE_IDENTITY();";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@ArtistId", artistId);
                command.Parameters.AddWithValue("@AlbumName", album.AlbumName);
                command.Parameters.AddWithValue("@Year", album.Year);
                command.Parameters.AddWithValue("@CountTracks", album.CountTracks);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            return 0;
        }

        private static int GetGenreId(string genreName, SqlConnection connection)
        {
            string query = "SELECT GenreId FROM Table_Genre WHERE GenreName = @GenreName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@GenreName", genreName);
                object result = command.ExecuteScalar();

                if (result != null && result != DBNull.Value)
                    return Convert.ToInt32(result);
            }

            return 0;
        }

        private static bool IsAlbumGenreAssociated(int albumId, int genreId, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Table_AlbumGenre WHERE AlbumId = @AlbumId AND GenreId = @GenreId";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AlbumId", albumId);
                command.Parameters.AddWithValue("@GenreId", genreId);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }

        private static bool IsTrackExistsInAlbum(int albumId, string trackName, SqlConnection connection)
        {
            string query = "SELECT COUNT(*) FROM Table_Track WHERE AlbumId = @AlbumId AND TrackName = @TrackName";

            using (SqlCommand command = new SqlCommand(query, connection))
            {
                command.Parameters.AddWithValue("@AlbumId", albumId);
                command.Parameters.AddWithValue("@TrackName", trackName);
                int count = Convert.ToInt32(command.ExecuteScalar());

                return count > 0;
            }
        }
    }
}