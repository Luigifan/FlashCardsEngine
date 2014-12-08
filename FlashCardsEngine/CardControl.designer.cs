namespace FlashCardsEngine
{
    partial class CardControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
        	System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
			"⁺",
			"Superscript +"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
			"⁻",
			"Superscript -"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem3 = new System.Windows.Forms.ListViewItem(new string[] {
			"¹",
			"Superscript 1"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem(new string[] {
			"²",
			"Superscript 2"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem(new string[] {
			"³",
			"Superscript 3"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem(new string[] {
			"₂",
			"Subscript 2"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
			"₃",
			"Subscript 3"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem(new string[] {
			"₄",
			"Subscript 4"}, 0);
        	System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
			"₇",
			"Subscript 7"}, 0);
        	this.panel1 = new System.Windows.Forms.Panel();
        	this.listView1 = new System.Windows.Forms.ListView();
        	this.Character = new System.Windows.Forms.ColumnHeader();
        	this.Description = new System.Windows.Forms.ColumnHeader();
        	this.feedbackPictureBox = new System.Windows.Forms.PictureBox();
        	this.answerTextBox = new System.Windows.Forms.TextBox();
        	this.questionLabel = new System.Windows.Forms.Label();
        	this.panel1.SuspendLayout();
        	((System.ComponentModel.ISupportInitialize)(this.feedbackPictureBox)).BeginInit();
        	this.SuspendLayout();
        	// 
        	// panel1
        	// 
        	this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
        	this.panel1.Controls.Add(this.listView1);
        	this.panel1.Controls.Add(this.feedbackPictureBox);
        	this.panel1.Controls.Add(this.answerTextBox);
        	this.panel1.Controls.Add(this.questionLabel);
        	this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
        	this.panel1.Location = new System.Drawing.Point(0, 0);
        	this.panel1.Name = "panel1";
        	this.panel1.Size = new System.Drawing.Size(491, 308);
        	this.panel1.TabIndex = 0;
        	// 
        	// listView1
        	// 
        	this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
			| System.Windows.Forms.AnchorStyles.Left)));
        	this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
			this.Character,
			this.Description});
        	this.listView1.FullRowSelect = true;
        	this.listView1.GridLines = true;
        	this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
			listViewItem1,
			listViewItem2,
			listViewItem3,
			listViewItem4,
			listViewItem5,
			listViewItem6,
			listViewItem7,
			listViewItem8,
			listViewItem9});
        	this.listView1.Location = new System.Drawing.Point(8, 177);
        	this.listView1.MultiSelect = false;
        	this.listView1.Name = "listView1";
        	this.listView1.Size = new System.Drawing.Size(216, 120);
        	this.listView1.TabIndex = 3;
        	this.listView1.UseCompatibleStateImageBehavior = false;
        	this.listView1.View = System.Windows.Forms.View.Details;
        	this.listView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView1_MouseDoubleClick);
        	// 
        	// Character
        	// 
        	this.Character.Text = "Char";
        	// 
        	// Description
        	// 
        	this.Description.Text = "Description";
        	this.Description.Width = 126;
        	// 
        	// feedbackPictureBox
        	// 
        	this.feedbackPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
        	this.feedbackPictureBox.Location = new System.Drawing.Point(360, 177);
        	this.feedbackPictureBox.Name = "feedbackPictureBox";
        	this.feedbackPictureBox.Size = new System.Drawing.Size(128, 128);
        	this.feedbackPictureBox.TabIndex = 2;
        	this.feedbackPictureBox.TabStop = false;
        	// 
        	// answerTextBox
        	// 
        	this.answerTextBox.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.answerTextBox.Location = new System.Drawing.Point(175, 137);
        	this.answerTextBox.Name = "answerTextBox";
        	this.answerTextBox.Size = new System.Drawing.Size(135, 20);
        	this.answerTextBox.TabIndex = 1;
        	this.answerTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.answerTextBox_KeyPress);
        	// 
        	// questionLabel
        	// 
        	this.questionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
        	this.questionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        	this.questionLabel.Location = new System.Drawing.Point(3, 0);
        	this.questionLabel.Name = "questionLabel";
        	this.questionLabel.Size = new System.Drawing.Size(485, 134);
        	this.questionLabel.TabIndex = 0;
        	this.questionLabel.Text = "testing";
        	this.questionLabel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
        	// 
        	// CardControl
        	// 
        	this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
        	this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        	this.BackColor = System.Drawing.Color.White;
        	this.Controls.Add(this.panel1);
        	this.Name = "CardControl";
        	this.Size = new System.Drawing.Size(491, 308);
        	this.panel1.ResumeLayout(false);
        	this.panel1.PerformLayout();
        	((System.ComponentModel.ISupportInitialize)(this.feedbackPictureBox)).EndInit();
        	this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox answerTextBox;
        private System.Windows.Forms.Label questionLabel;
        private System.Windows.Forms.PictureBox feedbackPictureBox;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader Character;
        private System.Windows.Forms.ColumnHeader Description;
    }
}
