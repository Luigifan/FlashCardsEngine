using IniParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            try
            {
                var parser = new FileIniDataParser();
                var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
                if (data["Information"]["WindowTitle"].Trim() != "")
                    return data["Information"]["WindowTitle"];
                else
                    return null;
            }
            catch(Exception ex)
            {
                Console.WriteLine("[DEBUG]: Couldn't load WindowTitle from INI (Stack: {0}", ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Get's the game's author
        /// </summary>
        /// <param name="directory">The game's directory</param>
        /// <returns>string</returns>
        public static string Author(string directory)
        {
            try
            {
                var parser = new FileIniDataParser();
                var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
                if (data["Information"]["Author"].Trim() != "")
                    return data["Information"]["Author"];
                else
                    return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("[DEBUG]: Couldn't load Author from INI (Stack: {0}", ex.Message);
                return null;
            }
        }
        /// <summary>
        /// Gets whether or not the game wants an input panel to input special characters
        /// </summary>
        /// <param name="directory">The game's directory</param>
        /// <returns>bool</returns>
        public static bool EnableInputPanel(string directory)
        {
            try
            {
                var parser = new FileIniDataParser();
                var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
                return bool.Parse(data["Information"]["AllowInputPanel"]);
            }
            catch(Exception idx)
            {
                try
                {
                    MessageBox.Show(string.Format("RUNTIME ERROR IN {0}\n\nStack trace: {0}\nPlease contact the author of this game for a fix.\nPlease click 'OK' so the game can crash", WindowTitle(directory),idx.Message), 
                        "Critical Error", 
                        MessageBoxButtons.OK, 
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(-5);
                }
                catch(Exception idxxx)
                {
                    MessageBox.Show(string.Format("RUNTIME ERROR IN GAME\n\nStack trace: {0}\nPlease contact the author of this game for a fix.\nPlease click 'OK' so the game can crash"),
                        "Critical Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                    Environment.Exit(-5);
                }
                return false;
            }
        }
        /// <summary>
        /// Gets the list of characters to be shown in the InputCharacters panel
        /// </summary>
        /// <returns>KeyValuePair list</returns>
        public static List<KeyValuePair<string, string>> InputCharacters(string directory)
        {
            try
            {
                List<KeyValuePair<string, string>> ret = new List<KeyValuePair<string, string>>();
                var parser = new FileIniDataParser();
                var data = parser.ReadFile(directory + Path.DirectorySeparatorChar.ToString() + "Game.ini");
                foreach (var i in data["Input Panel Characters"])
                {
                    KeyValuePair<string, string> kvp = new KeyValuePair<string, string>(i.KeyName, i.Value);
                    ret.Add(kvp);
                }
                return ret;
            }
            catch(Exception idx)
            {
                try
                {
                MessageBox.Show(string.Format("RUNTIME ERROR IN {0}\n\nStack Trace: {1}\nPlease contact the author of this game for a fix.\nPlease click 'OK' so the game can crash.", WindowTitle(directory), idx.Message), 
                    "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(-6);
                }
                catch(Exception ex)
                {
                   MessageBox.Show(string.Format("RUNTIME ERROR IN GAME\n\nStack Trace: {0}\nPlease contact the author of this game for a fix.\nPlease click 'OK' so the game can crash.", idx.Message), 
                    "Critical Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Environment.Exit(-6);
                }
            }
            return null;

        }
        /// <summary>
        /// Gets the Game.ico into a System.Drawing.Icon
        /// </summary>
        /// <param name="directory">The current game's directory</param>
        /// <returns>System.Drawing.Icon</returns>
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
        public static System.Drawing.Icon CustomIcon(string directory, int width, int height)
        {
            try
            {
                System.Drawing.Icon ico = new System.Drawing.Icon(directory + Path.DirectorySeparatorChar.ToString() + "Game.ico", width, height);
                return ico;
            }
            catch (FileNotFoundException fx)
            {
                Console.WriteLine("[DEBUG]: Icon not found in game {0} ({1})", directory, fx.Message);
                return null;
            }
        }
        //
    }
}
