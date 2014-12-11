using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsEngine
{
    public partial class InputPanel : Form
    {
        Game game;
        public InputPanel(List<KeyValuePair<string, string>> chars, Game _game)
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            game = _game;
            foreach(var i in chars)
            {
                ListViewItem lvi = new ListViewItem();
                lvi.Text = i.Key;
                lvi.SubItems.Add(i.Value);
                listView1.Items.Add(lvi);
            }
        }
        public InputPanel()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
        }

        private void listView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                game.cc.AnswerTextBoxValue = listView1.SelectedItems[0].Text;
            }
            game.Focus();
            game.cc.answerTextBox.Focus();
        }
        //
    }
}
