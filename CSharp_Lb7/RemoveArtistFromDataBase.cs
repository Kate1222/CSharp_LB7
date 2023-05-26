using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    public class RemoveArtistFromDataBase
    {
        private DataBase _dataBase = new DataBase();
        public void RemoveArtistDataBase(string artistName)
        {
            _dataBase.openConnection();

            int artistId;
            string artistIdQuery = $"SELECT ArtistId FROM Table_Artist WHERE ArtistName = '{artistName}'";
            using (SqlCommand artistIdCommand = new SqlCommand(artistIdQuery, _dataBase.getConnection()))
                artistId = (int)artistIdCommand.ExecuteScalar();

            if (artistId != 0)
            {
                // Remove the tracks associated with the artist's albums from Table_Track
                string trackDeleteQuery =
                    $"DELETE FROM Table_Track WHERE AlbumId IN (SELECT AlbumId FROM Table_Album WHERE ArtistId = '{artistId}')";
                using (SqlCommand trackDeleteCommand = new SqlCommand(trackDeleteQuery, _dataBase.getConnection()))
                    trackDeleteCommand.ExecuteNonQuery();

                // Remove the connections between albums and genres from Table_AlbumGenre
                string albumGenreDeleteQuery =
                    $"DELETE FROM Table_AlbumGenre WHERE AlbumId IN (SELECT AlbumId FROM Table_Album WHERE ArtistId = '{artistId}')";
                using (SqlCommand albumGenreDeleteCommand = new SqlCommand(albumGenreDeleteQuery, _dataBase.getConnection()))
                    albumGenreDeleteCommand.ExecuteNonQuery();

                // Remove the albums from Table_Album
                string albumDeleteQuery = $"DELETE FROM Table_Album WHERE ArtistId = '{artistId}'";
                using (SqlCommand albumDeleteCommand = new SqlCommand(albumDeleteQuery, _dataBase.getConnection()))
                    albumDeleteCommand.ExecuteNonQuery();

                // Remove the artist from Table_Artist
                string artistDeleteQuery = $"DELETE FROM Table_Artist WHERE ArtistId = '{artistId}'";
                using (SqlCommand artistDeleteCommand = new SqlCommand(artistDeleteQuery, _dataBase.getConnection()))
                    artistDeleteCommand.ExecuteNonQuery();
            }
            _dataBase.closeConnection();
        }
    }
}