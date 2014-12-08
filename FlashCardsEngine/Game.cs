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

namespace FlashCardsEngine
{
    public partial class Game : Form
    {
        public string CurrentGame = null;
        List<KeyValuePair<string, string>> vals = new List<KeyValuePair<string, string>>();
        LogHandler lh = new LogHandler();
        //
        Random ran_KeyOrValue = new Random(); //A value = 0 or 1 as to whether or not to show key and ask for value, or show value and ask for key.
        Random ran_Key = new Random(DateTime.Now.Millisecond); //which key to use, from the ini

        public Game()
        {
            InitializeComponent();
            LookForGames();
            /*var parser = new FileIniDataParser();
            IniData data = parser.ReadFile("");
            foreach (var i in data.Sections["SpecialChar"])
            {
                
            }*/
        }
        //
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
                MessageBox.Show("");
            }
            else
            {
                CurrentGame = directoriesWithGames[0]; //set to the only one available
            }
        }
        //
    }
}
