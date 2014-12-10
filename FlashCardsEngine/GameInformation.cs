using IniParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace FlashCardsEngine
{
    /// <summary>
    /// The class used to retrieve information for the game from the Game.ini.
    /// For example: Window title, author, icon, etc
    /// </summary>
    class GameInformation
    {
        /// <summary>
        /// Gets the game specific window title
        /// </summary>
        /// <param name="directory">The game's directory</param>
        /// <returns>string</returns>
        public static string WindowTitle(string directory)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
            return data["Information"]["WindowTitle"];
        }
        /// <summary>
        /// Gets whether or not the game wants an input panel to input special characters
        /// </summary>
        /// <param name="directory">The game's directory</param>
        /// <returns>bool</returns>
        public static bool EnableInputPanel(string directory)
        {
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
            return bool.Parse(data["Information"]["AllowInputPanel"]);
        }
        /// <summary>
        /// Gets the list of characters to be shown in the InputCharacters panel
        /// </summary>
        /// <returns>KeyValuePair list</returns>
        public static List<KeyValuePair<string, string>> InputCharacters(string directory)
        {
            List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>();
            var parser = new FileIniDataParser();
            var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
            foreach(var i in data["Input Panel Characters"])
            {
                KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(i.KeyName, i.Value);
                ret.Add(kvp);
            }
            return ret;
        }

        public static System.Drawing.Icon CustomIcon(string directory)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(directory + Path.DirectorySeparatorChar.ToString() + "Game.ico");
                return ico;
            }
            catch(FileNotFoundException fx)
            {
                Console.WriteLine("[DEBUG]: Icon not found in game {0} ({1})", directory, fx.Message);
                return null;
            }
        }
        //
    }
}
