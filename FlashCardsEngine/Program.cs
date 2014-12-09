using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FlashCardsEngine
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Game());
            //Now, we need to account for some different variables
            
        }
        //
    }
}
