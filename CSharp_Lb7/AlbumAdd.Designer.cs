namespace CSharp_Lb7
{
    partial class AlbumAdd
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBoxAlbumName = new TextBox();
            dateTimePickerYear = new DateTimePicker();
            numericUpDownCountTracks = new NumericUpDown();
            checkBoxFolk = new CheckBox();
            groupBoxGenres = new GroupBox();
            checkBoxPop = new CheckBox();
            checkBoxDisco = new CheckBox();
            checkBoxRapcore = new CheckBox();
            checkBoxRap = new CheckBox();
            checkBoxHipHop = new CheckBox();
            checkBoxRock = new CheckBox();
            checkBoxElectro = new CheckBox();
            checkBoxChanson = new CheckBox();
            checkBoxJazz = new CheckBox();
            checkBoxBlues = new CheckBox();
            checkBoxCountry = new CheckBox();
            label5 = new Label();
            dataGridViewAdd1 = new DataGridView();
            textBoxTrackName = new TextBox();
            label6 = new Label();
            buttonAdd = new Button();
            buttonDone = new Button();
            timePickerTrackLenth = new DateTimePicker();
            comboBoxAuthor = new ComboBox();
            Number = new DataGridViewTextBoxColumn();
            TrackName = new DataGridViewTextBoxColumn();
            TrackLenth = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountTracks).BeginInit();
            groupBoxGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdd1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 65);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(40, 15);
            label1.TabIndex = 0;
            label1.Text = "Автор";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 96);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(90, 15);
            label2.TabIndex = 1;
            label2.Text = "Назва альбома";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(103, 127);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Рік виходу";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(91, 158);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 15);
            label4.TabIndex = 3;
            label4.Text = "К-сть пісень";
            // 
            // textBoxAlbumName
            // 
            textBoxAlbumName.Location = new Point(178, 92);
            textBoxAlbumName.Margin = new Padding(4, 3, 4, 3);
            textBoxAlbumName.Name = "textBoxAlbumName";
            textBoxAlbumName.Size = new Size(262, 23);
            textBoxAlbumName.TabIndex = 2;
            // 
            // dateTimePickerYear
            // 
            dateTimePickerYear.CustomFormat = "yyyy";
            dateTimePickerYear.Format = DateTimePickerFormat.Custom;
            dateTimePickerYear.Location = new Point(178, 127);
            dateTimePickerYear.Margin = new Padding(4, 3, 4, 3);
            dateTimePickerYear.MaxDate = new DateTime(2023, 12, 31, 0, 0, 0, 0);
            dateTimePickerYear.Name = "dateTimePickerYear";
            dateTimePickerYear.ShowUpDown = true;
            dateTimePickerYear.Size = new Size(262, 23);
            dateTimePickerYear.TabIndex = 3;
            // 
            // numericUpDownCountTracks
            // 
            numericUpDownCountTracks.Location = new Point(178, 158);
            numericUpDownCountTracks.Margin = new Padding(4, 3, 4, 3);
            numericUpDownCountTracks.Name = "numericUpDownCountTracks";
            numericUpDownCountTracks.Size = new Size(262, 23);
            numericUpDownCountTracks.TabIndex = 4;
            // 
            // checkBoxFolk
            // 
            checkBoxFolk.AutoSize = true;
            checkBoxFolk.Location = new Point(7, 22);
            checkBoxFolk.Margin = new Padding(4, 3, 4, 3);
            checkBoxFolk.Name = "checkBoxFolk";
            checkBoxFolk.Size = new Size(99, 19);
            checkBoxFolk.TabIndex = 5;
            checkBoxFolk.Text = "Фолк-музика";
            checkBoxFolk.UseVisualStyleBackColor = true;
            // 
            // groupBoxGenres
            // 
            groupBoxGenres.Controls.Add(checkBoxPop);
            groupBoxGenres.Controls.Add(checkBoxDisco);
            groupBoxGenres.Controls.Add(checkBoxRapcore);
            groupBoxGenres.Controls.Add(checkBoxRap);
            groupBoxGenres.Controls.Add(checkBoxHipHop);
            groupBoxGenres.Controls.Add(checkBoxRock);
            groupBoxGenres.Controls.Add(checkBoxElectro);
            groupBoxGenres.Controls.Add(checkBoxChanson);
            groupBoxGenres.Controls.Add(checkBoxJazz);
            groupBoxGenres.Controls.Add(checkBoxBlues);
            groupBoxGenres.Controls.Add(checkBoxCountry);
            groupBoxGenres.Controls.Add(checkBoxFolk);
            groupBoxGenres.Location = new Point(178, 188);
            groupBoxGenres.Margin = new Padding(4, 3, 4, 3);
            groupBoxGenres.Name = "groupBoxGenres";
            groupBoxGenres.Padding = new Padding(4, 3, 4, 3);
            groupBoxGenres.Size = new Size(262, 202);
            groupBoxGenres.TabIndex = 5;
            groupBoxGenres.TabStop = false;
            groupBoxGenres.Text = "Жанри";
            // 
            // checkBoxPop
            // 
            checkBoxPop.AutoSize = true;
            checkBoxPop.Location = new Point(176, 155);
            checkBoxPop.Margin = new Padding(4, 3, 4, 3);
            checkBoxPop.Name = "checkBoxPop";
            checkBoxPop.Size = new Size(49, 19);
            checkBoxPop.TabIndex = 16;
            checkBoxPop.Text = "Поп";
            checkBoxPop.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisco
            // 
            checkBoxDisco.AutoSize = true;
            checkBoxDisco.Location = new Point(176, 128);
            checkBoxDisco.Margin = new Padding(4, 3, 4, 3);
            checkBoxDisco.Name = "checkBoxDisco";
            checkBoxDisco.Size = new Size(56, 19);
            checkBoxDisco.TabIndex = 15;
            checkBoxDisco.Text = "Діско";
            checkBoxDisco.UseVisualStyleBackColor = true;
            // 
            // checkBoxRapcore
            // 
            checkBoxRapcore.AutoSize = true;
            checkBoxRapcore.Location = new Point(176, 102);
            checkBoxRapcore.Margin = new Padding(4, 3, 4, 3);
            checkBoxRapcore.Name = "checkBoxRapcore";
            checkBoxRapcore.Size = new Size(66, 19);
            checkBoxRapcore.TabIndex = 14;
            checkBoxRapcore.Text = "Репкор";
            checkBoxRapcore.UseVisualStyleBackColor = true;
            // 
            // checkBoxRap
            // 
            checkBoxRap.AutoSize = true;
            checkBoxRap.Location = new Point(176, 75);
            checkBoxRap.Margin = new Padding(4, 3, 4, 3);
            checkBoxRap.Name = "checkBoxRap";
            checkBoxRap.Size = new Size(46, 19);
            checkBoxRap.TabIndex = 13;
            checkBoxRap.Text = "Реп";
            checkBoxRap.UseVisualStyleBackColor = true;
            // 
            // checkBoxHipHop
            // 
            checkBoxHipHop.AutoSize = true;
            checkBoxHipHop.Location = new Point(176, 48);
            checkBoxHipHop.Margin = new Padding(4, 3, 4, 3);
            checkBoxHipHop.Name = "checkBoxHipHop";
            checkBoxHipHop.Size = new Size(68, 19);
            checkBoxHipHop.TabIndex = 12;
            checkBoxHipHop.Text = "Хіп-хоп";
            checkBoxHipHop.UseVisualStyleBackColor = true;
            // 
            // checkBoxRock
            // 
            checkBoxRock.AutoSize = true;
            checkBoxRock.Location = new Point(176, 22);
            checkBoxRock.Margin = new Padding(4, 3, 4, 3);
            checkBoxRock.Name = "checkBoxRock";
            checkBoxRock.Size = new Size(46, 19);
            checkBoxRock.TabIndex = 11;
            checkBoxRock.Text = "Рок";
            checkBoxRock.UseVisualStyleBackColor = true;
            // 
            // checkBoxElectro
            // 
            checkBoxElectro.AutoSize = true;
            checkBoxElectro.Location = new Point(7, 155);
            checkBoxElectro.Margin = new Padding(4, 3, 4, 3);
            checkBoxElectro.Name = "checkBoxElectro";
            checkBoxElectro.Size = new Size(70, 19);
            checkBoxElectro.TabIndex = 10;
            checkBoxElectro.Text = "Електро";
            checkBoxElectro.UseVisualStyleBackColor = true;
            // 
            // checkBoxChanson
            // 
            checkBoxChanson.AutoSize = true;
            checkBoxChanson.Location = new Point(7, 128);
            checkBoxChanson.Margin = new Padding(4, 3, 4, 3);
            checkBoxChanson.Name = "checkBoxChanson";
            checkBoxChanson.Size = new Size(70, 19);
            checkBoxChanson.TabIndex = 9;
            checkBoxChanson.Text = "Шансон";
            checkBoxChanson.UseVisualStyleBackColor = true;
            // 
            // checkBoxJazz
            // 
            checkBoxJazz.AutoSize = true;
            checkBoxJazz.Location = new Point(7, 102);
            checkBoxJazz.Margin = new Padding(4, 3, 4, 3);
            checkBoxJazz.Name = "checkBoxJazz";
            checkBoxJazz.Size = new Size(54, 19);
            checkBoxJazz.TabIndex = 8;
            checkBoxJazz.Text = "Джаз";
            checkBoxJazz.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlues
            // 
            checkBoxBlues.AutoSize = true;
            checkBoxBlues.Location = new Point(7, 75);
            checkBoxBlues.Margin = new Padding(4, 3, 4, 3);
            checkBoxBlues.Name = "checkBoxBlues";
            checkBoxBlues.Size = new Size(55, 19);
            checkBoxBlues.TabIndex = 7;
            checkBoxBlues.Text = "Блюз";
            checkBoxBlues.UseVisualStyleBackColor = true;
            // 
            // checkBoxCountry
            // 
            checkBoxCountry.AutoSize = true;
            checkBoxCountry.Location = new Point(7, 48);
            checkBoxCountry.Margin = new Padding(4, 3, 4, 3);
            checkBoxCountry.Name = "checkBoxCountry";
            checkBoxCountry.Size = new Size(61, 19);
            checkBoxCountry.TabIndex = 6;
            checkBoxCountry.Text = "Кантрі";
            checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(90, 400);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(72, 15);
            label5.TabIndex = 7;
            label5.Text = "Назва треку";
            // 
            // dataGridViewAdd1
            // 
            dataGridViewAdd1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewAdd1.Columns.AddRange(new DataGridViewColumn[] { Number, TrackName, TrackLenth });
            dataGridViewAdd1.Location = new Point(472, 61);
            dataGridViewAdd1.Margin = new Padding(4, 3, 4, 3);
            dataGridViewAdd1.Name = "dataGridViewAdd1";
            dataGridViewAdd1.ReadOnly = true;
            dataGridViewAdd1.Size = new Size(413, 422);
            dataGridViewAdd1.TabIndex = 10;
            // 
            // textBoxTrackName
            // 
            textBoxTrackName.Location = new Point(178, 397);
            textBoxTrackName.Margin = new Padding(4, 3, 4, 3);
            textBoxTrackName.Name = "textBoxTrackName";
            textBoxTrackName.Size = new Size(262, 23);
            textBoxTrackName.TabIndex = 6;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(85, 430);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(80, 15);
            label6.TabIndex = 10;
            label6.Text = "Довжина (хв)";
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(178, 457);
            buttonAdd.Margin = new Padding(4, 3, 4, 3);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(127, 27);
            buttonAdd.TabIndex = 8;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // buttonDone
            // 
            buttonDone.Location = new Point(314, 457);
            buttonDone.Margin = new Padding(4, 3, 4, 3);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(127, 27);
            buttonDone.TabIndex = 9;
            buttonDone.Text = "Done";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // timePickerTrackLenth
            // 
            timePickerTrackLenth.CustomFormat = "mm:ss";
            timePickerTrackLenth.Format = DateTimePickerFormat.Custom;
            timePickerTrackLenth.Location = new Point(178, 427);
            timePickerTrackLenth.Margin = new Padding(4, 3, 4, 3);
            timePickerTrackLenth.Name = "timePickerTrackLenth";
            timePickerTrackLenth.ShowUpDown = true;
            timePickerTrackLenth.Size = new Size(262, 23);
            timePickerTrackLenth.TabIndex = 7;
            timePickerTrackLenth.Value = new DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // comboBoxAuthor
            // 
            comboBoxAuthor.FormattingEnabled = true;
            comboBoxAuthor.Location = new Point(178, 55);
            comboBoxAuthor.Margin = new Padding(4, 3, 4, 3);
            comboBoxAuthor.Name = "comboBoxAuthor";
            comboBoxAuthor.Size = new Size(262, 23);
            comboBoxAuthor.TabIndex = 1;
            // 
            // Number
            // 
            Number.HeaderText = "№";
            Number.Name = "Number";
            Number.ReadOnly = true;
            Number.Resizable = DataGridViewTriState.False;
            Number.Width = 30;
            // 
            // TrackName
            // 
            TrackName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrackName.HeaderText = "Назва треку";
            TrackName.Name = "TrackName";
            TrackName.ReadOnly = true;
            TrackName.Resizable = DataGridViewTriState.False;
            // 
            // TrackLenth
            // 
            TrackLenth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrackLenth.HeaderText = "Довжина треку";
            TrackLenth.Name = "TrackLenth";
            TrackLenth.ReadOnly = true;
            TrackLenth.Resizable = DataGridViewTriState.False;
            // 
            // AlbumAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 526);
            Controls.Add(comboBoxAuthor);
            Controls.Add(timePickerTrackLenth);
            Controls.Add(buttonDone);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxTrackName);
            Controls.Add(label6);
            Controls.Add(dataGridViewAdd1);
            Controls.Add(label5);
            Controls.Add(groupBoxGenres);
            Controls.Add(numericUpDownCountTracks);
            Controls.Add(dateTimePickerYear);
            Controls.Add(textBoxAlbumName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(4, 3, 4, 3);
            MaximizeBox = false;
            MaximumSize = new Size(949, 565);
            MinimizeBox = false;
            MinimumSize = new Size(949, 565);
            Name = "AlbumAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AlbumAdd";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCountTracks).EndInit();
            groupBoxGenres.ResumeLayout(false);
            groupBoxGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewAdd1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBoxAlbumName;
        private DateTimePicker dateTimePickerYear;
        private NumericUpDown numericUpDownCountTracks;
        private CheckBox checkBoxFolk;
        private GroupBox groupBoxGenres;
        private CheckBox checkBoxElectro;
        private CheckBox checkBoxChanson;
        private CheckBox checkBoxJazz;
        private CheckBox checkBoxBlues;
        private CheckBox checkBoxCountry;
        private CheckBox checkBoxPop;
        private CheckBox checkBoxDisco;
        private CheckBox checkBoxRapcore;
        private CheckBox checkBoxRap;
        private CheckBox checkBoxHipHop;
        private CheckBox checkBoxRock;
        private Label label5;
        private DataGridView dataGridViewAdd1;
        private TextBox textBoxTrackName;
        private Label label6;
        private Button buttonAdd;
        private Button buttonDone;
        private DateTimePicker timePickerTrackLenth;
        private ComboBox comboBoxAuthor;
        private DataGridViewTextBoxColumn Number;
        private DataGridViewTextBoxColumn TrackName;
        private DataGridViewTextBoxColumn TrackLenth;
    }
}