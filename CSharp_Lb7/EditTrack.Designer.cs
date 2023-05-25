namespace CSharp_Lb7
{
    partial class EditTrack
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
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxTrackName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.timePickerTrackLenth = new System.Windows.Forms.DateTimePicker();
            this.buttonDone = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 50);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Назва треку";
            // 
            // textBoxTrackName
            // 
            this.textBoxTrackName.Location = new System.Drawing.Point(130, 47);
            this.textBoxTrackName.Name = "textBoxTrackName";
            this.textBoxTrackName.Size = new System.Drawing.Size(225, 20);
            this.textBoxTrackName.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(50, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Довжина (хв)";
            // 
            // timePickerTrackLenth
            // 
            this.timePickerTrackLenth.CustomFormat = "mm:ss";
            this.timePickerTrackLenth.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePickerTrackLenth.Location = new System.Drawing.Point(130, 73);
            this.timePickerTrackLenth.Name = "timePickerTrackLenth";
            this.timePickerTrackLenth.ShowUpDown = true;
            this.timePickerTrackLenth.Size = new System.Drawing.Size(225, 20);
            this.timePickerTrackLenth.TabIndex = 12;
            this.timePickerTrackLenth.Value = new System.DateTime(2023, 3, 16, 0, 0, 0, 0);
            // 
            // buttonDone
            // 
            this.buttonDone.Location = new System.Drawing.Point(179, 99);
            this.buttonDone.Name = "buttonDone";
            this.buttonDone.Size = new System.Drawing.Size(109, 23);
            this.buttonDone.TabIndex = 13;
            this.buttonDone.Text = "Done";
            this.buttonDone.UseVisualStyleBackColor = true;
            this.buttonDone.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // EditTrack
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(437, 185);
            this.Controls.Add(this.buttonDone);
            this.Controls.Add(this.timePickerTrackLenth);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textBoxTrackName);
            this.Controls.Add(this.label5);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(453, 224);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(453, 224);
            this.Name = "EditTrack";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Edit Track";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxTrackName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker timePickerTrackLenth;
        private System.Windows.Forms.Button buttonDone;
    }
}