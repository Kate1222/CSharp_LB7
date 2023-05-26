using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    public class RemoveAlbumDataBase
    {
        private DataBase _dataBase = new DataBase();

        public void RemoveAlbumFromDataBase(string artistName, string albumName)
        {
            _dataBase.openConnection();

            // Get the artist ID
            int artistId;
            string artistIdQuery = $"SELECT ArtistId FROM Table_Artist WHERE ArtistName = '{artistName}'";
            using (SqlCommand artistIdCommand = new SqlCommand(artistIdQuery, _dataBase.getConnection()))
            {
                artistId = (int)artistIdCommand.ExecuteScalar();
            }

            if (artistId != 0)
            {
                // Get the album ID
                int albumId;
                string albumIdQuery = $"SELECT AlbumId FROM Table_Album WHERE ArtistId = '{artistId}' AND AlbumName = '{albumName}'";
                using (SqlCommand albumIdCommand = new SqlCommand(albumIdQuery, _dataBase.getConnection()))
                {
                    albumId = (int)albumIdCommand.ExecuteScalar();
                }

                if (albumId != 0)
                {
                    // Remove the tracks associated with the album from Table_Track
                    string trackDeleteQuery = $"DELETE FROM Table_Track WHERE AlbumId = '{albumId}'";
                    using (SqlCommand trackDeleteCommand = new SqlCommand(trackDeleteQuery, _dataBase.getConnection()))
                    {
                        trackDeleteCommand.ExecuteNonQuery();
                    }

                    // Remove the connection between album and genre from Table_AlbumGenre
                    string albumGenreDeleteQuery = $"DELETE FROM Table_AlbumGenre WHERE AlbumId = '{albumId}'";
                    using (SqlCommand albumGenreDeleteCommand = new SqlCommand(albumGenreDeleteQuery, _dataBase.getConnection()))
                    {
                        albumGenreDeleteCommand.ExecuteNonQuery();
                    }

                    // Remove the AlbumID from Table_AlbumGenre
                    string albumGenreIdDeleteQuery = $"UPDATE Table_AlbumGenre SET AlbumId = NULL WHERE AlbumId = '{albumId}'";
                    using (SqlCommand albumGenreIdDeleteCommand = new SqlCommand(albumGenreIdDeleteQuery, _dataBase.getConnection()))
                    {
                        albumGenreIdDeleteCommand.ExecuteNonQuery();
                    }

                    // Remove the album from Table_Album
                    string albumDeleteQuery = $"DELETE FROM Table_Album WHERE AlbumId = '{albumId}'";
                    using (SqlCommand albumDeleteCommand = new SqlCommand(albumDeleteQuery, _dataBase.getConnection()))
                    {
                        albumDeleteCommand.ExecuteNonQuery();
                    }
                }
            }
            _dataBase.closeConnection();
        }
    }
}