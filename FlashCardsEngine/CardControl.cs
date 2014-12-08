using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace FlashCardsEngine
{
    public partial class CardControl : UserControl
    {
        public string question;
        public string answer;
        public bool correct;
        bool ansCaseSensitive = false;
        Game game;

        public CardControl(string ques, string ans, bool _ansCaseSensitive, Game _game)
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            question = ques;
            answer = ans;
            questionLabel.Text = question;
            ansCaseSensitive = _ansCaseSensitive;
            game = _game;
            //
            if (GameInformation.EnableInputPanel(game.CurrentGame) == true)
            {
                foreach (ListViewItem del in listView1.Items)
                    del.Remove();
                foreach (var k in IniInformation.InputCharacters())
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = k.Key;
                    lvi.SubItems.Add(k.Value);
                    listView1.Items.Add(lvi);
                }
            }
			answerTextBox.Focus ();
            //
        }

        public void IsCorrect()
        {
            if (ansCaseSensitive)
            {
                if (answerTextBox.Text == answer)
                {
                    //feedbackPictureBox.Image = Chem.Properties.Resources.correct;
                    MessageBox.Show("Correct!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    correct = true;
                    game.GetResult(question, answer, answerTextBox.Text, "is correct");
                    game.SelectCard();

                }
                else
                {    //feedbackPictureBox.Image = Chem.Properties.Resources.incorrect;
                    MessageBox.Show("Incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correct = false;
                    game.GetResult(question, answer, answerTextBox.Text, "is wrong");
                }
            }
            else
            {
                if (answerTextBox.Text.IndexOf(answer, 0, StringComparison.CurrentCultureIgnoreCase) != -1)
                {
                    MessageBox.Show("Correct!", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    correct = true;
                    game.GetResult(question, answer, answerTextBox.Text, "is correct");
                    game.SelectCard();
                }
                else
                {
                    MessageBox.Show("Incorrect", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    correct = false;
                    game.GetResult(question, answer, answerTextBox.Text, "is wrong");
                }
            }
        }
        
        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (listView1.SelectedItems.Count == 1)
            {
                ListViewItem lvi = listView1.SelectedItems[0];
                answerTextBox.AppendText(lvi.Text);
                answerTextBox.Focus();
            }
        }

        private void answerTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                IsCorrect();
            }
        }
    }
}
