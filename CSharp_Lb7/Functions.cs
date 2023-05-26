namespace CSharp_Lb7
{
    class Functions
    {
        //check album name repeat in necessary artist list
        public bool checkAlbumRepeat(string albumName, string artist, List<Artist> artists)
        {
            bool result = false;
            
            if (artists.Count > 0)
            {
                Artist findArtist = artists.Find(x => x.ArtistName.Equals(artist));
                if (findArtist != null)
                {
                    Album findAlbum = findArtist.Albums.Find(x => x.AlbumName.Equals(albumName));
                    if (findAlbum != null)
                        result = true;
                }
            }

            return result;
        }

        //check track name repeat in necessary album list
        public bool checkTrackRepeat(string trackName, List<Track> listTracks)
        {
            bool result = false;

            if (listTracks.Count > 0)
            {
                Track findTrack = listTracks.Find(x => x.Equals(trackName));
                if (findTrack != null)
                    result = true;
            }
            return result;
        }

        //add artist name to combobox
        public void addInfoToComboBox(ComboBox comboBox, List<Artist> artists)
        {
            if (artists.Count > 0)
            {
                for (int i = 0; i < artists.Count; i++)
                    comboBox.Items.Add(artists[i].ArtistName);
            }
        }

        //find artist in array
        public int findArtist(string artistName, List<Artist> artists)
        {
            int result = -1;

            if (artists.Count > 0)
            {
                Artist findArtist = artists.Find(x => x.Equals(artistName));
                if (findArtist != null)
                    result = artists.FindIndex(x => x.Equals(artistName));
            }

            return result;
        }

        //show all albums and tracks
        public void updateDataGridView(DataGridView dataGridView, List<Artist> artists)
        {
            dataGridView.Rows.Clear();
            if (artists.Count > 0)
            {
                int count = 1;
                for (int i = 0; i < artists.Count; i++)
                {
                    for (int j = 0; j < artists[i].Albums.Count; j++)
                    {
                        String genres = artists[i].Albums[j].Genres.Aggregate((current, next) => current + " " + next);

                        for (int k = 0; k < artists[i].Albums[j].Tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].Albums[j].Tracks[k].TrackName, artists[i].ArtistName, genres, artists[i].Albums[j].AlbumName, artists[i].Albums[j].Tracks[k].TrackLength.TimeOfDay);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }
        
        //find and show albums in necessary artist
        public void updateDataGridViewAuthors(DataGridView dataGridView, List<Artist> artists, String artist)
        {
            dataGridView.Rows.Clear();
            int count = 1;
            for (int i = 0; i < artists.Count; i++)
            {
                if (artists[i].ArtistName == artist)
                {
                    for (int j = 0; j < artists[i].Albums.Count; j++)
                    {
                        String genres = artists[i].Albums[j].Genres.Aggregate((current, next) => current + " " + next);

                        for (int k = 0; k < artists[i].Albums[j].Tracks.Count; k++)
                        {
                            dataGridView.Rows.Add(count, k + 1, artists[i].Albums[j].Tracks[k].TrackName, artists[i].ArtistName, genres, artists[i].Albums[j].AlbumName, artists[i].Albums[j].Tracks[k].TrackLength.TimeOfDay);
                            count++;
                        }
                        dataGridView.Rows.Add();
                    }
                }
            }
        }

        //find and show albums in necessary genre
        public void updateDataGridViewOfGenres(DataGridView dataGridView, List<Artist> artists, String genre)
        {
            if (genre == String.Empty)
                updateDataGridView(dataGridView, artists);
            else
            {
                dataGridView.Rows.Clear();
                int count = 1;
                for (int i = 0; i < artists.Count; i++)
                {
                    for (int j = 0; j < artists[i].Albums.Count; j++)
                    {
                        String findGenres = artists[i].Albums[j].Genres.Find(g => g.Equals(genre));

                        if (findGenres != null)
                        {
                            String genres = artists[i].Albums[j].Genres.Aggregate((current, next) => current + " " + next);

                            for (int k = 0; k < artists[i].Albums[j].Tracks.Count; k++)
                            {
                                dataGridView.Rows.Add(count, k + 1, artists[i].Albums[j].Tracks[k].TrackName, artists[i].ArtistName, genres, artists[i].Albums[j].AlbumName, artists[i].Albums[j].Tracks[k].TrackLength.TimeOfDay);
                                count++;
                            }
                            dataGridView.Rows.Add();
                        }
                    }
                }
            }
        }

        //update combobox item authors
        public void updateComboBoxAuthors(ComboBox comboBox, List<Artist> artists)
        {
            comboBox.Items.Clear();
            comboBox.Items.Add(String.Empty);
            for (int i = 0; i < artists.Count; i++)
                comboBox.Items.Add(artists[i].ArtistName);
        }
    }
}
