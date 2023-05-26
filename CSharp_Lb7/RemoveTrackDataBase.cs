using Microsoft.Data.SqlClient;

namespace CSharp_Lb7
{
    internal class RemoveTrackDataBase
    {
        DataBase _dataBase = new DataBase();
        public void RemoveTrackFromDataBase(string artistName, string albumName, string trackName)
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
                    // Remove the track from the Table_Track
                    string trackDeleteQuery = $"DELETE FROM Table_Track WHERE AlbumId = '{albumId}' AND TrackName = '{trackName}'";
                    using (SqlCommand trackDeleteCommand = new SqlCommand(trackDeleteQuery, _dataBase.getConnection()))
                    {
                        trackDeleteCommand.ExecuteNonQuery();
                    }
                }

            }
            _dataBase.closeConnection();
        }
    }
}
