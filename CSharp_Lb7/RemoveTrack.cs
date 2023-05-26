using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CSharp_Lb7
{
    public partial class RemoveTrack : Form
    {
        List<Artist> artists = new List<Artist>();
        Functions functions = new Functions();

        //initialize RemoceTrack form
        internal RemoveTrack(List<Artist> mainArtists, String title, bool showAlbumName, bool showTrackName)
        {
            InitializeComponent();

            label2.Visible = showAlbumName;
            comboBoxAlbumName.Visible = showAlbumName;
            label3.Visible = showTrackName;
            comboBoxTrackName.Visible = showTrackName;

            this.Text = title;

            artists = mainArtists;
            functions.addInfoToComboBox(comboBoxAuthor, artists);
        }

        //make action when in comboBoxAuthor change select item
        private void comboBoxAuthor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (artists[comboBoxAuthor.SelectedIndex].Albums.Count == 0 && comboBoxAlbumName.Visible == true)
                MessageBox.Show("В цього виконвця відсутні альбоми!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                comboBoxAlbumName.Items.Clear();
                comboBoxAlbumName.Text = String.Empty;
                comboBoxTrackName.Items.Clear();
                comboBoxTrackName.Text = String.Empty;
                for (int i = 0; i < artists[comboBoxAuthor.SelectedIndex].Albums.Count; i++)
                    comboBoxAlbumName.Items.Add(artists[comboBoxAuthor.SelectedIndex].Albums[i].AlbumName);
            }
        }

        //make action when in comboBoxAlbumName change select item
        private void comboBoxAlbumName_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBoxTrackName.Items.Clear();
            comboBoxTrackName.Text = String.Empty;
            for (int i = 0; i < artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks.Count; i++)
                comboBoxTrackName.Items.Add(artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks[i].TrackName);
        }

        //make action when buttonDone pressed
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (this.Text == "Remove Track" || this.Text == "Edit Track")
            {
                if (comboBoxAuthor.Text == String.Empty || comboBoxAlbumName.Text == String.Empty || comboBoxTrackName.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    if (this.Text == "Remove Track")
                    {
                        DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей трек?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (mb == DialogResult.Yes)
                        {
                            if (artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks
                                    .Count == 1)
                            {
                                RemoveAlbumDataBase removeAlbumDataBase = new RemoveAlbumDataBase();
                                removeAlbumDataBase.RemoveAlbumFromDataBase(
                                    artists[comboBoxAuthor.SelectedIndex].ArtistName,
                                    artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex]
                                        .AlbumName);
                                artists[comboBoxAuthor.SelectedIndex].Albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                            }
                            else
                            {
                                RemoveTrackDataBase removeTrackDataBase = new RemoveTrackDataBase();
                                removeTrackDataBase.RemoveTrackFromDataBase(
                                    artists[comboBoxAuthor.SelectedIndex].ArtistName,
                                    artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex]
                                        .AlbumName,
                                    artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex]
                                        .Tracks[comboBoxTrackName.SelectedIndex].TrackName);
                                artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks.RemoveAt(comboBoxTrackName.SelectedIndex);
                                artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].CountTracks--;
                            }
                            this.Close();
                        }
                    }
                    /*else
                    {
                        EditTrack editTrack = new EditTrack(artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks[comboBoxTrackName.SelectedIndex].TrackName,
                            artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks[comboBoxTrackName.SelectedIndex].TrackLength);
                        this.Hide();
                        editTrack.ShowDialog();
                        if (editTrack.trackName == String.Empty)
                        {
                            DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей трек?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (mb == DialogResult.Yes)
                            {
                                if (artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks.Count == 1)
                                    artists[comboBoxAuthor.SelectedIndex].Albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                                else
                                {
                                    artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks.RemoveAt(comboBoxTrackName.SelectedIndex);
                                    artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].CountTracks--;
                                }
                            }
                        }
                        else
                        {
                            artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks[comboBoxTrackName.SelectedIndex].TrackName = editTrack.trackName;
                            artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].Tracks[comboBoxTrackName.SelectedIndex].TrackLength = editTrack.trackLenth;
                        }
                        this.Close();
                    }*/
                }
            }

            else if (this.Text == "Remove Album")
            {
                if (comboBoxAuthor.Text == String.Empty || comboBoxAlbumName.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цей альбом?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mb == DialogResult.Yes)
                    {
                        RemoveAlbumDataBase removeAlbumDataBase = new RemoveAlbumDataBase();
                        removeAlbumDataBase.RemoveAlbumFromDataBase(artists[comboBoxAuthor.SelectedIndex].ArtistName,
                            artists[comboBoxAuthor.SelectedIndex].Albums[comboBoxAlbumName.SelectedIndex].AlbumName);
                        artists[comboBoxAuthor.SelectedIndex].Albums.RemoveAt(comboBoxAlbumName.SelectedIndex);
                        this.Close();
                    }
                }
            }

            else
            {
                if (comboBoxAuthor.Text == String.Empty)
                    MessageBox.Show("Недостатньо інформації!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                {
                    DialogResult mb = MessageBox.Show("Ви точно бажаете ВИДАЛИТИ цього виконавця?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (mb == DialogResult.Yes)
                    {
                        RemoveArtistFromDataBase removeArtistFromDataBase = new RemoveArtistFromDataBase();
                        removeArtistFromDataBase.RemoveArtistDataBase(artists[comboBoxAuthor.SelectedIndex].ArtistName);
                        artists.RemoveAt(comboBoxAuthor.SelectedIndex);
                        this.Close();
                    }
                }
            }
        }
    }
}
