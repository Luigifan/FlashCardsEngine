using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using IniParser.Parser;
using IniParser;
using IniParser.Model;
using System.IO;
using Microsoft.WindowsAPICodePack.Dialogs;

namespace FlashCardsEngine
{
    public partial class Game : Form
    {
        public string CurrentGame = null;
        List<KeyValuePair<string, string>> vals = new List<KeyValuePair<string, string>>();
        LogHandler lh = new LogHandler();
        public CardControl cc = new CardControl();
        //
        Random ran_KeyOrValue = new Random(); //A value = 0 or 1 as to whether or not to show key and ask for value, or show value and ask for key.
        Random ran_Key = new Random(DateTime.Now.Millisecond); //which key to use, from the ini

        public Game()
        {
            Font = SystemFonts.MessageBoxFont;
            InitializeComponent();
            LookForGames();
            LoadInCards();
            EnableInputPanel();
            SelectCard();
        }
        //public voids
        public void GetResult(string ques, string ans, string userAnswer, string isCorrect)
        {
            string time = DateTime.Now.ToString();
            string format = string.Format("[{0}]: Question: {1}; user answered: {2} and it {3}. (Correct: {4})", time, ques, userAnswer, isCorrect, ans);
            lh.logs.Add(format);
        }
        public void SelectCard()
        {
            foreach (Control c in this.Controls)
                if (c is CardControl)
                    this.Controls.Remove(c);
            
            ran_KeyOrValue.Next(3);
            int keyorval = ran_KeyOrValue.Next(3);

            int MaxSelection = vals.Count - 1;
            ran_Key.Next(MaxSelection);
            int SelectedCard = ran_Key.Next(0, MaxSelection);
            if(keyorval == 1 || keyorval == 3) //Show Key, answer for value
            {
                cc = new CardControl(vals[SelectedCard].Key, vals[SelectedCard].Value, false, this);
                cc.Dock = DockStyle.Fill;
                this.Controls.Add(cc);
            }
            else if(keyorval == 2 || keyorval == 0)
            {
                cc = new CardControl(vals[SelectedCard].Value, vals[SelectedCard].Key, false, this);
                cc.Dock = DockStyle.Fill;
                this.Controls.Add(cc);
            }
        }
        //private/unset voids
        private void LoadInCards()
        {
            var parser = new FileIniDataParser();
            IniData data = parser.ReadFile((CurrentGame + Path.DirectorySeparatorChar.ToString() + "Game.ini"));
            foreach(var card in data["Cards"])
            {
                KeyValuePair<string, string> v = new KeyValuePair<string, string>(card.KeyName, card.Value);
                vals.Add(v);
            }
            SelectCard();
        }
        private void LookForGames()
        {
            List<string> directoriesWithGames = new List<string>();
            foreach(var dir in Directory.GetDirectories(Environment.CurrentDirectory))
            {
                if(File.Exists(dir + Path.DirectorySeparatorChar + "Game.ini"))
                {
                    directoriesWithGames.Add(dir);
                }
            }
            if(directoriesWithGames.Count > 1)
            {
                //allow user to pick game
            }
            else if(directoriesWithGames.Count == 0)
            {
                MessageBox.Show("Flash Card Engine could not find any applicable games containing a 'Game.ini' near the executable.", 
                        "Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Error);
                Environment.Exit(-2);
            }
            else
            {
                CurrentGame = directoriesWithGames[0]; //set to the only one available
            }
        }
        private void EnableInputPanel()
        {
            if (GameInformation.EnableInputPanel(CurrentGame) == true)
            {
                InputPanel ip = new InputPanel(GameInformation.InputCharacters(CurrentGame), this);
                ip.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
                ip.Show();
                ip.Location = new Point(this.Location.X + this.Width + 5, this.Location.Y);
            }
            this.Text = GameInformation.WindowTitle(CurrentGame);
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            DialogResult dr = MessageBox.Show("Would you like a text-based result of your game?", "Question", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            switch (dr)
            {
                case (DialogResult.Yes):
                    SaveFileDialog sfd = new SaveFileDialog();
                    sfd.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
                    sfd.FileName = "Game Result.txt";
                    DialogResult drr = sfd.ShowDialog();
                    switch (drr)
                    {
                        case (DialogResult.OK):
                            lh.WriteToLog(sfd.FileName);
                            break;
                    }
                    Environment.Exit(1);
                    break;
                case (DialogResult.No):
                    Environment.Exit(1);
                    break;
                case (DialogResult.Cancel):
                    break;
            }
        }

        private void Game_LocationChanged(object sender, EventArgs e)
        {
            
        }
        //
    }
}
