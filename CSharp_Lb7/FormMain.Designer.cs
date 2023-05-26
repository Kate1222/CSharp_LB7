namespace CSharp_Lb7
{
    partial class SongsLibrary
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            Num = new DataGridViewTextBoxColumn();
            NumberInAlbum = new DataGridViewTextBoxColumn();
            songName = new DataGridViewTextBoxColumn();
            artistName = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            albumName = new DataGridViewTextBoxColumn();
            TrackLenth = new DataGridViewTextBoxColumn();
            menuStrip1 = new MenuStrip();
            файлToolStripMenuItem = new ToolStripMenuItem();
            addAlbumToolStripMenuItem = new ToolStripMenuItem();
            deleteAlbumToolStripMenuItem = new ToolStripMenuItem();
            removeExecutorToolStripMenuItem = new ToolStripMenuItem();
            removeTrackToolStripMenuItem = new ToolStripMenuItem();
            label1 = new Label();
            comboBoxGenres = new ComboBox();
            label2 = new Label();
            comboBoxAuthors = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Num, NumberInAlbum, songName, artistName, genre, albumName, TrackLenth });
            dataGridView1.Location = new Point(14, 93);
            dataGridView1.Margin = new Padding(4, 3, 4, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(905, 412);
            dataGridView1.TabIndex = 0;
            // 
            // Num
            // 
            Num.HeaderText = "№";
            Num.Name = "Num";
            Num.ReadOnly = true;
            Num.Resizable = DataGridViewTriState.False;
            Num.Width = 30;
            // 
            // NumberInAlbum
            // 
            NumberInAlbum.HeaderText = "№(альбом)";
            NumberInAlbum.Name = "NumberInAlbum";
            NumberInAlbum.ReadOnly = true;
            NumberInAlbum.Resizable = DataGridViewTriState.False;
            NumberInAlbum.Width = 80;
            // 
            // songName
            // 
            songName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            songName.HeaderText = "Назва треку";
            songName.Name = "songName";
            songName.ReadOnly = true;
            songName.Resizable = DataGridViewTriState.False;
            // 
            // artistName
            // 
            artistName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            artistName.HeaderText = "Ім'я виконавця";
            artistName.Name = "artistName";
            artistName.ReadOnly = true;
            artistName.Resizable = DataGridViewTriState.False;
            // 
            // genre
            // 
            genre.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            genre.HeaderText = "Жанр";
            genre.Name = "genre";
            genre.ReadOnly = true;
            genre.Resizable = DataGridViewTriState.False;
            // 
            // albumName
            // 
            albumName.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            albumName.HeaderText = "Назва альбому";
            albumName.Name = "albumName";
            albumName.ReadOnly = true;
            albumName.Resizable = DataGridViewTriState.False;
            // 
            // TrackLenth
            // 
            TrackLenth.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            TrackLenth.HeaderText = "Довжина треку";
            TrackLenth.Name = "TrackLenth";
            TrackLenth.ReadOnly = true;
            TrackLenth.Resizable = DataGridViewTriState.False;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { файлToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7, 2, 0, 2);
            menuStrip1.Size = new Size(933, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            файлToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addAlbumToolStripMenuItem, deleteAlbumToolStripMenuItem, removeExecutorToolStripMenuItem, removeTrackToolStripMenuItem });
            файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            файлToolStripMenuItem.Size = new Size(48, 20);
            файлToolStripMenuItem.Text = "Файл";
            // 
            // addAlbumToolStripMenuItem
            // 
            addAlbumToolStripMenuItem.Name = "addAlbumToolStripMenuItem";
            addAlbumToolStripMenuItem.Size = new Size(194, 22);
            addAlbumToolStripMenuItem.Text = "Додати альбом";
            addAlbumToolStripMenuItem.Click += addAlbumToolStripMenuItem_Click;
            // 
            // deleteAlbumToolStripMenuItem
            // 
            deleteAlbumToolStripMenuItem.Name = "deleteAlbumToolStripMenuItem";
            deleteAlbumToolStripMenuItem.Size = new Size(194, 22);
            deleteAlbumToolStripMenuItem.Text = "Видалення альбому";
            deleteAlbumToolStripMenuItem.Click += deleteAlbumToolStripMenuItem_Click;
            // 
            // removeExecutorToolStripMenuItem
            // 
            removeExecutorToolStripMenuItem.Name = "removeExecutorToolStripMenuItem";
            removeExecutorToolStripMenuItem.Size = new Size(194, 22);
            removeExecutorToolStripMenuItem.Text = "Видалення виконавця";
            removeExecutorToolStripMenuItem.Click += removeExecutorToolStripMenuItem_Click;
            // 
            // removeTrackToolStripMenuItem
            // 
            removeTrackToolStripMenuItem.Name = "removeTrackToolStripMenuItem";
            removeTrackToolStripMenuItem.Size = new Size(194, 22);
            removeTrackToolStripMenuItem.Text = "Видалення треку";
            removeTrackToolStripMenuItem.Click += removeTrackToolStripMenuItem_Click;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.Location = new Point(234, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(143, 15);
            label1.TabIndex = 2;
            label1.Text = "Сортування за жанрами:";
            // 
            // comboBoxGenres
            // 
            comboBoxGenres.Anchor = AnchorStyles.Top;
            comboBoxGenres.FormattingEnabled = true;
            comboBoxGenres.Items.AddRange(new object[] { "", "Фолк-музика", "Кантрі", "Блюз", "Джаз", "Шансон", "Електро", "Рок", "Хіп-хоп", "Реп", "Репкор", "Діско", "Поп" });
            comboBoxGenres.Location = new Point(397, 62);
            comboBoxGenres.Margin = new Padding(4, 3, 4, 3);
            comboBoxGenres.Name = "comboBoxGenres";
            comboBoxGenres.Size = new Size(283, 23);
            comboBoxGenres.TabIndex = 3;
            comboBoxGenres.SelectedIndexChanged += comboBoxGenres_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top;
            label2.AutoSize = true;
            label2.Location = new Point(238, 35);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(139, 15);
            label2.TabIndex = 4;
            label2.Text = "Сортування за автором:";
            // 
            // comboBoxAuthors
            // 
            comboBoxAuthors.Anchor = AnchorStyles.Top;
            comboBoxAuthors.FormattingEnabled = true;
            comboBoxAuthors.Location = new Point(397, 31);
            comboBoxAuthors.Margin = new Padding(4, 3, 4, 3);
            comboBoxAuthors.Name = "comboBoxAuthors";
            comboBoxAuthors.Size = new Size(283, 23);
            comboBoxAuthors.TabIndex = 5;
            comboBoxAuthors.SelectedIndexChanged += comboBoxAuthors_SelectedIndexChanged;
            // 
            // SongsLibrary
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(comboBoxAuthors);
            Controls.Add(label2);
            Controls.Add(comboBoxGenres);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(4, 3, 4, 3);
            Name = "SongsLibrary";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Аудіо-бібліотека";
            FormClosing += SongsLibrary_FormClosing;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem addAlbumToolStripMenuItem;
        private ToolStripMenuItem deleteAlbumToolStripMenuItem;
        private ToolStripMenuItem removeExecutorToolStripMenuItem;
        private ToolStripMenuItem removeTrackToolStripMenuItem;
        private Label label1;
        private ComboBox comboBoxGenres;
        private Label label2;
        private ComboBox comboBoxAuthors;
        private DataGridViewTextBoxColumn Num;
        private DataGridViewTextBoxColumn NumberInAlbum;
        private DataGridViewTextBoxColumn songName;
        private DataGridViewTextBoxColumn artistName;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn albumName;
        private DataGridViewTextBoxColumn TrackLenth;
    }
}

