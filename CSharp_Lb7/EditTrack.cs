using System;
using System.Windows.Forms;

namespace CSharp_Lb7
{
    public partial class EditTrack : Form
    {
        internal String trackName = String.Empty;
        internal DateTime trackLenth;

        //initialize EditTrack form
        internal EditTrack(String trackName, DateTime trackLenth)
        {
            InitializeComponent();
            textBoxTrackName.Text = trackName;
            timePickerTrackLenth.Value = trackLenth;
        }

        //save edit information
        private void buttonDone_Click(object sender, EventArgs e)
        {
            trackName = textBoxTrackName.Text;
            trackLenth = timePickerTrackLenth.Value;
            this.Close();
        }
    }
}
