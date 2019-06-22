namespace badwords
{
    partial class MainForm
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
            this.Textbox_artist = new System.Windows.Forms.TextBox();
            this.Textbox_song = new System.Windows.Forms.TextBox();
            this.button_confirm = new System.Windows.Forms.Button();
            this.Textbox_output = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Textbox_artist
            // 
            this.Textbox_artist.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Textbox_artist.Location = new System.Drawing.Point(161, 122);
            this.Textbox_artist.Name = "Textbox_artist";
            this.Textbox_artist.Size = new System.Drawing.Size(106, 20);
            this.Textbox_artist.TabIndex = 0;
            this.Textbox_artist.Text = "Artist";
            // 
            // Textbox_song
            // 
            this.Textbox_song.Location = new System.Drawing.Point(534, 122);
            this.Textbox_song.Name = "Textbox_song";
            this.Textbox_song.Size = new System.Drawing.Size(106, 20);
            this.Textbox_song.TabIndex = 1;
            this.Textbox_song.Text = "Song";
            // 
            // button_confirm
            // 
            this.button_confirm.Location = new System.Drawing.Point(363, 177);
            this.button_confirm.Name = "button_confirm";
            this.button_confirm.Size = new System.Drawing.Size(75, 23);
            this.button_confirm.TabIndex = 2;
            this.button_confirm.Text = "Find rapper";
            this.button_confirm.UseVisualStyleBackColor = true;
            this.button_confirm.Click += new System.EventHandler(this.button_confirm_Click);
            // 
            // Textbox_output
            // 
            this.Textbox_output.Location = new System.Drawing.Point(218, 254);
            this.Textbox_output.Multiline = true;
            this.Textbox_output.Name = "Textbox_output";
            this.Textbox_output.Size = new System.Drawing.Size(370, 116);
            this.Textbox_output.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Textbox_output);
            this.Controls.Add(this.button_confirm);
            this.Controls.Add(this.Textbox_song);
            this.Controls.Add(this.Textbox_artist);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "MainForm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Rapper Tinder";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Textbox_artist;
        private System.Windows.Forms.TextBox Textbox_song;
        private System.Windows.Forms.Button button_confirm;
        private System.Windows.Forms.TextBox Textbox_output;
    }
}