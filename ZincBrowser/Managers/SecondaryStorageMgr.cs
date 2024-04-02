using SoftCircuits.IniFileParser;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZincBrowser
{
    internal class SecondaryStorageMgr
    {
        public static IniFile file = new IniFile();
            
        public SecondaryStorageMgr()
        {
            file.Load(".\\storage.ini");
            // this is secondary storage, storage that is only really accessed when the user requests it via the settings or history page
            // ZincBrowser.exe.config is for more frequently accessed configuration example the user's color preferences
        }

        public List<List<string>> loadHistory()
        {
            int index = 0;
            List<List<string>> history = new List<List<string>>();

            foreach (string section in file.GetSections())
            {
                if (section.Split(':')[0] == "search")
                {
                    history[index][0] = section.Split(':')[1]; // page title
                    history[index][1] = file.GetSetting(section, "url", string.Empty); // url
                    index++;
                }
            }
            return history;
        }
    }
}
