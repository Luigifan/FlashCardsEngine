using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsEngine
{
    public partial class SelectGame : Form
    {
        public string SelectedGame = null;

        public SelectGame()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();

            this.Icon = FlashCardsEngine.Properties.Resources._256;
            this.ShowIcon = true;

            ImageList icons = new ImageList();
            listView1.StateImageList = icons;
            foreach (var dir in Directory.GetDirectories(Environment.CurrentDirectory))
            {
                if(File.Exists(dir + Path.DirectorySeparatorChar + "Game.ico"))
                {
                    icons.Images.Add(GameInformation.CustomIcon(dir, 16, 16).ToBitmap());
                }
                else
                {
                    icons.Images.Add(FlashCardsEngine.Properties.Resources._16_png);
                }
                if (File.Exists(dir + Path.DirectorySeparatorChar + "Game.ini"))
                {
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = Path.GetFileName(dir);
                    string aut = GameInformation.Author(dir);
                    if (aut == null)
                        aut = "";
                    lvi.SubItems.Add(aut);
                    lvi.SubItems.Add(dir);
                    listView1.Items.Add(lvi);
                }
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(listView1.SelectedItems.Count == 1)
            {
                SelectedGame = listView1.SelectedItems[0].SubItems[2].Text;
                okButton.Enabled = true;
            }
            else
            {
                okButton.Enabled = false;
            }
        }
        //
    }
}
