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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAlbumName = new System.Windows.Forms.TextBox();
            this.dateTimePickerYear = new System.Windows.Forms.DateTimePicker();
            this.numericUpDownCountTracks = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFolk = new System.Windows.Forms.CheckBox();
            this.groupBoxGenres = new System.Windows.Forms.GroupBox();
            this.checkBoxPop = new System.Windows.Forms.CheckBox();
            this.checkBoxDisco = new System.Windows.Forms.CheckBox();
            this.checkBoxRapcore = new System.Windows.Forms.CheckBox();
            this.checkBoxRap = new System.Windows.Forms.CheckBox();
            this.checkBoxHipHop = new System.Windows.Forms.CheckBox();
            this.checkBoxRock = new System.Windows.Forms.CheckBox();
            this.checkBoxElectro = new System.Windows.Forms.CheckBox();
            this.checkBoxChanson = new System.Windows.Forms.CheckBox();
            this.checkBoxJazz = new System.Windows.Forms.CheckBox();
            this.checkBoxBlues = new System.Windows.Forms.CheckBox();
            this.checkBoxCountry = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridViewAdd1 = new System.Windows.Forms.DataGridView();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TrackLenth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDone = new System.Windows.Forms.Button();
            this.timePickerTrackLenth = new System.Windows.Forms.DateTimePicker();
            this.comboBoxAuthor = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountTracks)).BeginInit();
            this.groupBoxGenres.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(110, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Автор";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Назва альбома";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(88, 110);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Рік виходу";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 137);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "К-сть пісень";
            // 
            // textBoxAlbumName
            // 
            this.textBoxAlbumName.Location = new System.Drawing.Point(153, 80);
            this.textBoxAlbumName.Name = "textBoxAlbumName";
            this.textBoxAlbumName.Size = new System.Drawing.Size(225, 20);
            this.textBoxAlbumName.TabIndex = 2;
            // 
            // dateTimePickerYear
            // 
            this.dateTimePickerYear.CustomFormat = "yyyy";
            this.dateTimePickerYear.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerYear.Location = new System.Drawing.Point(153, 110);
            this.dateTimePickerYear.MaxDate = new System.DateTime(2023, 12, 31, 0, 0, 0, 0);
            this.dateTimePickerYear.Name = "dateTimePickerYear";
            this.dateTimePickerYear.ShowUpDown = true;
            this.dateTimePickerYear.Size = new System.Drawing.Size(225, 20);
            this.dateTimePickerYear.TabIndex = 3;
            // 
            // numericUpDownCountTracks
            // 
            this.numericUpDownCountTracks.Location = new System.Drawing.Point(153, 137);
            this.numericUpDownCountTracks.Name = "numericUpDownCountTracks";
            this.numericUpDownCountTracks.Size = new System.Drawing.Size(225, 20);
            this.numericUpDownCountTracks.TabIndex = 4;
            // 
            // checkBoxFolk
            // 
            this.checkBoxFolk.AutoSize = true;
            this.checkBoxFolk.Location = new System.Drawing.Point(6, 19);
            this.checkBoxFolk.Name = "checkBoxFolk";
            this.checkBoxFolk.Size = new System.Drawing.Size(95, 17);
            this.checkBoxFolk.TabIndex = 5;
            this.checkBoxFolk.Text = "Фолк-музика";
            this.checkBoxFolk.UseVisualStyleBackColor = true;
            // 
            // groupBoxGenres
            // 
            this.groupBoxGenres.Controls.Add(this.checkBoxPop);
            this.groupBoxGenres.Controls.Add(this.checkBoxDisco);
            this.groupBoxGenres.Controls.Add(this.checkBoxRapcore);
            this.groupBoxGenres.Controls.Add(this.checkBoxRap);
            this.groupBoxGenres.Controls.Add(this.checkBoxHipHop);
            this.groupBoxGenres.Controls.Add(this.checkBoxRock);
            this.groupBoxGenres.Controls.Add(this.checkBoxElectro);
            this.groupBoxGenres.Controls.Add(this.checkBoxChanson);
            this.groupBoxGenres.Controls.Add(this.checkBoxJazz);
            this.groupBoxGenres.Controls.Add(this.checkBoxBlues);
            this.groupBoxGenres.Controls.Add(this.checkBoxCountry);
            this.groupBoxGenres.Controls.Add(this.checkBoxFolk);
            this.groupBoxGenres.Location = new System.Drawing.Point(153, 163);
            this.groupBoxGenres.Name = "groupBoxGenres";
            this.groupBoxGenres.Size = new System.Drawing.Size(225, 175);
            this.groupBoxGenres.TabIndex = 5;
            this.groupBoxGenres.TabStop = false;
            this.groupBoxGenres.Text = "Жанри";
            // 
            // checkBoxPop
            // 
            this.checkBoxPop.AutoSize = true;
            this.checkBoxPop.Location = new System.Drawing.Point(151, 134);
            this.checkBoxPop.Name = "checkBoxPop";
            this.checkBoxPop.Size = new System.Drawing.Size(46, 17);
            this.checkBoxPop.TabIndex = 16;
            this.checkBoxPop.Text = "Поп";
            this.checkBoxPop.UseVisualStyleBackColor = true;
            // 
            // checkBoxDisco
            // 
            this.checkBoxDisco.AutoSize = true;
            this.checkBoxDisco.Location = new System.Drawing.Point(151, 111);
            this.checkBoxDisco.Name = "checkBoxDisco";
            this.checkBoxDisco.Size = new System.Drawing.Size(55, 17);
            this.checkBoxDisco.TabIndex = 15;
            this.checkBoxDisco.Text = "Діско";
            this.checkBoxDisco.UseVisualStyleBackColor = true;
            // 
            // checkBoxRapcore
            // 
            this.checkBoxRapcore.AutoSize = true;
            this.checkBoxRapcore.Location = new System.Drawing.Point(151, 88);
            this.checkBoxRapcore.Name = "checkBoxRapcore";
            this.checkBoxRapcore.Size = new System.Drawing.Size(63, 17);
            this.checkBoxRapcore.TabIndex = 14;
            this.checkBoxRapcore.Text = "Репкор";
            this.checkBoxRapcore.UseVisualStyleBackColor = true;
            // 
            // checkBoxRap
            // 
            this.checkBoxRap.AutoSize = true;
            this.checkBoxRap.Location = new System.Drawing.Point(151, 65);
            this.checkBoxRap.Name = "checkBoxRap";
            this.checkBoxRap.Size = new System.Drawing.Size(45, 17);
            this.checkBoxRap.TabIndex = 13;
            this.checkBoxRap.Text = "Реп";
            this.checkBoxRap.UseVisualStyleBackColor = true;
            // 
            // checkBoxHipHop
            // 
            this.checkBoxHipHop.AutoSize = true;
            this.checkBoxHipHop.Location = new System.Drawing.Point(151, 42);
            this.checkBoxHipHop.Name = "checkBoxHipHop";
            this.checkBoxHipHop.Size = new System.Drawing.Size(61, 17);
            this.checkBoxHipHop.TabIndex = 12;
            this.checkBoxHipHop.Text = "Хіп-хоп";
            this.checkBoxHipHop.UseVisualStyleBackColor = true;
            // 
            // checkBoxRock
            // 
            this.checkBoxRock.AutoSize = true;
            this.checkBoxRock.Location = new System.Drawing.Point(151, 19);
            this.checkBoxRock.Name = "checkBoxRock";
            this.checkBoxRock.Size = new System.Drawing.Size(45, 17);
            this.checkBoxRock.TabIndex = 11;
            this.checkBoxRock.Text = "Рок";
            this.checkBoxRock.UseVisualStyleBackColor = true;
            // 
            // checkBoxElectro
            // 
            this.checkBoxElectro.AutoSize = true;
            this.checkBoxElectro.Location = new System.Drawing.Point(6, 134);
            this.checkBoxElectro.Name = "checkBoxElectro";
            this.checkBoxElectro.Size = new System.Drawing.Size(68, 17);
            this.checkBoxElectro.TabIndex = 10;
            this.checkBoxElectro.Text = "Електро";
            this.checkBoxElectro.UseVisualStyleBackColor = true;
            // 
            // checkBoxChanson
            // 
            this.checkBoxChanson.AutoSize = true;
            this.checkBoxChanson.Location = new System.Drawing.Point(6, 111);
            this.checkBoxChanson.Name = "checkBoxChanson";
            this.checkBoxChanson.Size = new System.Drawing.Size(65, 17);
            this.checkBoxChanson.TabIndex = 9;
            this.checkBoxChanson.Text = "Шансон";
            this.checkBoxChanson.UseVisualStyleBackColor = true;
            // 
            // checkBoxJazz
            // 
            this.checkBoxJazz.AutoSize = true;
            this.checkBoxJazz.Location = new System.Drawing.Point(6, 88);
            this.checkBoxJazz.Name = "checkBoxJazz";
            this.checkBoxJazz.Size = new System.Drawing.Size(55, 17);
            this.checkBoxJazz.TabIndex = 8;
            this.checkBoxJazz.Text = "Джаз";
            this.checkBoxJazz.UseVisualStyleBackColor = true;
            // 
            // checkBoxBlues
            // 
            this.checkBoxBlues.AutoSize = true;
            this.checkBoxBlues.Location = new System.Drawing.Point(6, 65);
            this.checkBoxBlues.Name = "checkBoxBlues";
            this.checkBoxBlues.Size = new System.Drawing.Size(53, 17);
            this.checkBoxBlues.TabIndex = 7;
            this.checkBoxBlues.Text = "Блюз";
            this.checkBoxBlues.UseVisualStyleBackColor = true;
            // 
            // checkBoxCountry
            // 
            this.checkBoxCountry.AutoSize = true;
            this.checkBoxCountry.Location = new System.Drawing.Point(6, 42);
            this.checkBoxCountry.Name = "checkBoxCountry";
            this.checkBoxCountry.Size = new System.Drawing.Size(58, 17);
            this.checkBoxCountry.TabIndex = 6;
            this.checkBoxCountry.Text = "Кантрі";
            this.checkBoxCountry.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 347);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Назва треку";
            // 
            // dataGridViewAdd1
            // 
            this.dataGridViewAdd1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewAdd1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.TrackName,
            this.TrackLenth});
            this.dataGridViewAdd1.Location = new System.Drawing.Point(405, 53);
            this.dataGridViewAdd1.Name = "dataGridViewAdd1";
            this.dataGridViewAdd1.ReadOnly = true;
            this.dataGridViewAdd1.Size = new System.Drawing.Size(354, 366);
            this.dataGridViewAdd1.TabIndex = 10;
            // 
            // Number
            // 
            this.Number.HeaderText = "№";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Number.Width = 30;
            // 
            // TrackName
            // 
            this.TrackName.HeaderText = "Назва треку";
            this.TrackName.Name = "TrackName";
            this.TrackName.ReadOnly = true;
            this.TrackName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // TrackLenth
            // 
            this.TrackLenth.HeaderText = "Довжина треку";
            this.TrackLenth.Name = "TrackLenth";
            this.TrackLenth.ReadOnly = true;
            this.TrackLenth.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // textBoxTrackName
            // 
            this.textBoxTrackName.Location = new System.Drawing.Point(153, 344);
            this.textBoxTrackName.Name = "textBoxTrackName";
            this.textBoxTrackName.Size = new System.Drawing.Size(225, 20);
            this.textBoxTrackName.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(73, 373);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Довжина (хв)";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(153, 396);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(109, 23);
            this.buttonAdd.TabIndex = 8;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(269, 396);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(109, 23);
            this.buttonDone.TabIndex = 9;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // timePickerTrackLenth
            // 
            this.timePickerTrackLenth.CustomFormat = "mm:ss";
            this.timePickerTrackLenth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerTrackLenth.Location = new System.Drawing.Point(153, 370);
            this.timePickerTrackLenth.Name = "timePickerTrackLenth";
            this.timePickerTrackLenth.ShowUpDown = true;
            this.timePickerTrackLenth.Size = new System.Drawing.Size(225, 20);
            this.timePickerTrackLenth.TabIndex = 7;
            this.timePickerTrackLenth.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // comboBoxAuthor
            // 
            this.comboBoxAuthor.FormattingEnabled = true;
            this.comboBoxAuthor.Location = new System.Drawing.Point(153, 48);
            this.comboBoxAuthor.Name = "comboBoxAuthor";
            this.comboBoxAuthor.Size = new System.Drawing.Size(225, 21);
            this.comboBoxAuthor.TabIndex = 1;
            // 
            // AlbumAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 456);
            this.Controls.Add(this.comboBoxAuthor);
            this.Controls.Add(this.timePickerTrackLenth);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.textBoxTrackName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridViewAdd1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBoxGenres);
            this.Controls.Add(this.numericUpDownCountTracks);
            this.Controls.Add(this.dateTimePickerYear);
            this.Controls.Add(this.textBoxAlbumName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(816, 495);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(816, 495);
            this.Name = "AlbumAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AlbumAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCountTracks)).EndInit();
            this.groupBoxGenres.ResumeLayout(false);
            this.groupBoxGenres.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewAdd1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAlbumName;
        private System.Windows.Forms.DateTimePicker dateTimePickerYear;
        private System.Windows.Forms.NumericUpDown numericUpDownCountTracks;
        private System.Windows.Forms.CheckBox checkBoxFolk;
        private System.Windows.Forms.GroupBox groupBoxGenres;
        private System.Windows.Forms.CheckBox checkBoxElectro;
        private System.Windows.Forms.CheckBox checkBoxChanson;
        private System.Windows.Forms.CheckBox checkBoxJazz;
        private System.Windows.Forms.CheckBox checkBoxBlues;
        private System.Windows.Forms.CheckBox checkBoxCountry;
        private System.Windows.Forms.CheckBox checkBoxPop;
        private System.Windows.Forms.CheckBox checkBoxDisco;
        private System.Windows.Forms.CheckBox checkBoxRapcore;
        private System.Windows.Forms.CheckBox checkBoxRap;
        private System.Windows.Forms.CheckBox checkBoxHipHop;
        private System.Windows.Forms.CheckBox checkBoxRock;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dataGridViewAdd1;
        private System.Windows.Forms.TextBox textBoxTrackName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackName;
        private System.Windows.Forms.DataGridViewTextBoxColumn TrackLenth;
        private System.Windows.Forms.Button buttonDone;
        private System.Windows.Forms.DateTimePicker timePickerTrackLenth;
        private System.Windows.Forms.ComboBox comboBoxAuthor;
    }
}