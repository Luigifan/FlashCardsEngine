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
    public partial class Help : Form
    {
        Game game;
        bool hasCustomInfo = false;

        public Help()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.Icon = SystemIcons.Information;
        }
        public Help(Game _game)
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            this.Icon = SystemIcons.Information;
            game = _game;
            ShowCustomInformation();
        }

        //
        private void ShowCustomInformation()
        {
            if(game != null)
            {
                if(GameInformation.CustomIcon(game.CurrentGame) != null)
                {
                    iconPictureBox.Image = GameInformation.CustomIcon(game.CurrentGame, 256, 256).ToBitmap();
                    hasCustomInfo = true;
                }
                else
                {
                    iconPictureBox.Image = FlashCardsEngine.Properties.Resources._256_png;
                }
                //
                if(GameInformation.WindowTitle(game.CurrentGame) != null)
                {
                    titleText.Text = GameInformation.WindowTitle(game.CurrentGame);
                    hasCustomInfo = true;
                }
                else
                {
                    titleText.Text = "Flash Cards Engine";
                }
                //
                if(GameInformation.Author(game.CurrentGame) != null)
                {
                    authorLabel.Text = "by " + GameInformation.Author(game.CurrentGame);
                    hasCustomInfo = true;
                }
                else
                {
                    authorLabel.Text = "by Mike Santiago";
                }
            }
            //
        }

        //0 is custom, 1 is mine
        int info = 0;
        private void iconPictureBox_Click(object sender, EventArgs e)
        {
            if(hasCustomInfo)
            {
                switch(info)
                {
                    case(0): //switch to mine
                        iconPictureBox.Image = FlashCardsEngine.Properties.Resources._128_png;
                        titleText.Text = "Flash Cards Engine";
                        authorLabel.Text = "by Mike Santiago";
                        info = 1;
                        break;
                    case(1): //switch to custom
                        ShowCustomInformation();
                        info = 0;
                        break;
                }
            }
        }
        //
    }
}
