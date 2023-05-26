using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    public class RemoveArtistFromDataBase
    {
        private DataBase _dataBase = new DataBase();
        public void RemoveArtistDataBase(string artistName)
        {
            _dataBase.openConnection();

            // Get the artist ID
            int artistId;
            string artistIdQuery = "SELECT ArtistId FROM Table_Artist WHERE ArtistName = @ArtistName";
            using (SqlCommand artistIdCommand = new SqlCommand(artistIdQuery, _dataBase.getConnection()))
            {
                artistIdCommand.Parameters.AddWithValue("@ArtistName", artistName);
                artistId = (int)artistIdCommand.ExecuteScalar();
            }

            if (artistId != 0)
            {
                // Remove the tracks associated with the artist's albums from Table_Track
                string trackDeleteQuery =
                    "DELETE FROM Table_Track WHERE AlbumId IN (SELECT AlbumId FROM Table_Album WHERE ArtistId = @ArtistId)";
                using (SqlCommand trackDeleteCommand = new SqlCommand(trackDeleteQuery, _dataBase.getConnection()))
                {
                    trackDeleteCommand.Parameters.AddWithValue("@ArtistId", artistId);
                    trackDeleteCommand.ExecuteNonQuery();
                }

                // Remove the connections between albums and genres from Table_AlbumGenre
                string albumGenreDeleteQuery =
                    "DELETE FROM Table_AlbumGenre WHERE AlbumId IN (SELECT AlbumId FROM Table_Album WHERE ArtistId = @ArtistId)";
                using (SqlCommand albumGenreDeleteCommand = new SqlCommand(albumGenreDeleteQuery, _dataBase.getConnection()))
                {
                    albumGenreDeleteCommand.Parameters.AddWithValue("@ArtistId", artistId);
                    albumGenreDeleteCommand.ExecuteNonQuery();
                }

                // Remove the albums from Table_Album
                string albumDeleteQuery = "DELETE FROM Table_Album WHERE ArtistId = @ArtistId";
                using (SqlCommand albumDeleteCommand = new SqlCommand(albumDeleteQuery, _dataBase.getConnection()))
                {
                    albumDeleteCommand.Parameters.AddWithValue("@ArtistId", artistId);
                    albumDeleteCommand.ExecuteNonQuery();
                }

                // Remove the artist from Table_Artist
                string artistDeleteQuery = "DELETE FROM Table_Artist WHERE ArtistId = @ArtistId";
                using (SqlCommand artistDeleteCommand = new SqlCommand(artistDeleteQuery, _dataBase.getConnection()))
                {
                    artistDeleteCommand.Parameters.AddWithValue("@ArtistId", artistId);
                    artistDeleteCommand.ExecuteNonQuery();
                }
            }
            _dataBase.closeConnection();
        }
    }
}