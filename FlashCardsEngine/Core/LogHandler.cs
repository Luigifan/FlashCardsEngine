using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace FlashCardsEngine
{
    class LogHandler
    {
        public List<string> logs = new List<string>();

        public void WriteToLog(string fileName)
        {
            StreamWriter sw = new StreamWriter(fileName);
            foreach (var log in logs)
            {
                sw.WriteLine(log);
            }
            sw.Flush();
            sw.Close();
            //
        }
        //
    }
}
