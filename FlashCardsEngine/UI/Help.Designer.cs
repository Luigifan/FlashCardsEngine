namespace FlashCardsEngine
{
    partial class Help
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.aboutRichText = new System.Windows.Forms.RichTextBox();
            this.authorLabel = new System.Windows.Forms.Label();
            this.titleText = new System.Windows.Forms.Label();
            this.iconPictureBox = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 355);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 329);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Help";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 131);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Work in progress!";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.aboutRichText);
            this.tabPage2.Controls.Add(this.authorLabel);
            this.tabPage2.Controls.Add(this.titleText);
            this.tabPage2.Controls.Add(this.iconPictureBox);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 329);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "About";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // aboutRichText
            // 
            this.aboutRichText.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.aboutRichText.Location = new System.Drawing.Point(3, 209);
            this.aboutRichText.Name = "aboutRichText";
            this.aboutRichText.Size = new System.Drawing.Size(542, 117);
            this.aboutRichText.TabIndex = 3;
            this.aboutRichText.Text = "";
            // 
            // authorLabel
            // 
            this.authorLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.authorLabel.Location = new System.Drawing.Point(1, 164);
            this.authorLabel.Name = "authorLabel";
            this.authorLabel.Size = new System.Drawing.Size(547, 23);
            this.authorLabel.TabIndex = 2;
            this.authorLabel.Text = "by Mike Santiago";
            this.authorLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // titleText
            // 
            this.titleText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.titleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleText.Location = new System.Drawing.Point(0, 138);
            this.titleText.Name = "titleText";
            this.titleText.Size = new System.Drawing.Size(548, 26);
            this.titleText.TabIndex = 1;
            this.titleText.Text = "Flash Cards Engine";
            this.titleText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // iconPictureBox
            // 
            this.iconPictureBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.iconPictureBox.Location = new System.Drawing.Point(208, 3);
            this.iconPictureBox.Name = "iconPictureBox";
            this.iconPictureBox.Size = new System.Drawing.Size(128, 128);
            this.iconPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.iconPictureBox.TabIndex = 0;
            this.iconPictureBox.TabStop = false;
            this.iconPictureBox.Click += new System.EventHandler(this.iconPictureBox_Click);
            // 
            // Help
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(556, 355);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Help";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Help";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.PictureBox iconPictureBox;
        private System.Windows.Forms.Label titleText;
        private System.Windows.Forms.RichTextBox aboutRichText;
        private System.Windows.Forms.Label authorLabel;
    }
}