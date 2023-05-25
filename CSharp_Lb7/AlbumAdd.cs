using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace CSharp_Lb7
{
    public partial class AlbumAdd : Form
    {
        internal Album album = new Album();
        internal String artistName = string.Empty;
        bool artistSaved = false;
        List<Artist> artistList;

        //initialize AlbumAdd form
        internal AlbumAdd(List<Artist> mainArtistList)
        {
            InitializeComponent();
            artistList = mainArtistList;
            Functions functions = new Functions();
            functions.addInfoToComboBox(comboBoxAuthor, artistList);
        }

        //add song to album
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Functions functions = new Functions();

            if (comboBoxAuthor.Text == String.Empty && artistName == String.Empty)
                MessageBox.Show("Введіть ім'я автора!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (textBoxAlbumName.Text == String.Empty)
                MessageBox.Show("Введіть назву альбома!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (functions.checkAlbumRepeat(textBoxAlbumName.Text, comboBoxAuthor.Text, artistList))
                MessageBox.Show("В цього виконавця вже існує алюбом с такою назвою!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (numericUpDownCountTracks.Value == 0)
                MessageBox.Show("Кількість треків не може бути нульовою!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (!artistSaved)
                {
                    bool somethingCheck = false;
                    foreach (CheckBox c in groupBoxGenres.Controls.OfType<CheckBox>())
                    {
                        if (c.Checked)
                        {
                            somethingCheck = true;
                            break;
                        }
                    }
                    if (!somethingCheck)
                        MessageBox.Show("Оберіть жанр!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                    {
                        artistName = comboBoxAuthor.Text;
                        album.AlbumName = textBoxAlbumName.Text;
                        album.Year = dateTimePickerYear.Value.Year;
                        album.CountTracks = ((int)numericUpDownCountTracks.Value);
                        foreach (CheckBox c in groupBoxGenres.Controls.OfType<CheckBox>())
                        {
                            if (c.Checked)
                                album.Genres.Add(c.Text);
                        }
                        artistSaved = true;
                    }
                }
                if (artistSaved)
                {
                    if (textBoxTrackName.Text == String.Empty)
                        MessageBox.Show("Введіть назву треку", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else if (timePickerTrackLenth.Value.Minute == 0 && timePickerTrackLenth.Value.Second == 0)
                        MessageBox.Show("Введіть довжину треку", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //add to song array
                    else
                    {
                        //check on repeat
                        if (functions.checkTrackRepeat(textBoxTrackName.Text, album.Tracks))
                            MessageBox.Show("Такий трек вже збережений!", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        else
                        {
                            Track newTrack = new Track();
                            newTrack.TrackName = textBoxTrackName.Text;
                            newTrack.TrackLength = timePickerTrackLenth.Value;

                            album.Tracks.Add(newTrack);
                            dataGridViewAdd1.Rows.Add(album.Tracks.Count, newTrack.TrackName, newTrack.TrackLength.TimeOfDay);
                            comboBoxAuthor.Enabled = false;
                            textBoxAlbumName.Enabled = false;
                            dateTimePickerYear.Enabled = false;
                            numericUpDownCountTracks.Enabled = false;
                            groupBoxGenres.Enabled = false;
                            textBoxTrackName.Text = String.Empty;
                            timePickerTrackLenth.Value = new DateTime(2001, 10, 20);

                            //this.Controls.IndexOf(textBoxTrackName);

                            if (album.Tracks.Count == album.CountTracks)
                                buttonAdd.Enabled = false;
                        }
                    }
                }
            }
        }

        //exit to form AlbumAdd
        private void buttonDone_Click(object sender, EventArgs e)
        {
            if (comboBoxAuthor.Text == String.Empty || comboBoxAuthor.Enabled == true)
                this.Close();
            else if (album.Tracks.Count != album.CountTracks)
            {
                DialogResult mb = MessageBox.Show("Ви точно бажаете зберегти не повністю заповнений альбом?", "Question!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mb == DialogResult.Yes)
                {
                    album.CountTracks = album.Tracks.Count;
                    this.Close();
                }
            }
            else
                this.Close();
        }
    }
}
