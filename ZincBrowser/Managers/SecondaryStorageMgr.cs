using SoftCircuits.IniFileParser;
using System;
using System.Collections.Generic;
using System.IO;

namespace ZincBrowser
{
    internal class SecondaryStorageMgr
    {
        public static IniFile themefile = new IniFile();
        public static IniFile historyfile = new IniFile();

        public bool incognitoMode = false; // throws a tantrum if we refrence from form1, so we need this here, idk why, dont ask

        public SecondaryStorageMgr()
        {
            themefile.Load(".\\secondaryStorage\\themes.ini");
            historyfile.Load(".\\secondaryStorage\\history.ini");
            // this is secondary storage, storage that is only really accessed when the user requests it directly
            // ZincBrowser.exe.config is for more frequently accessed configuration example the user's color preferences
        }

        public List<Dictionary<string, object>> loadThemes()
        {
            List<Dictionary<string, object>> themes = new List<Dictionary<string, object>>();

            // rewrite counter: 4

            foreach (string section in themefile.GetSections())
            {
                Dictionary<string, object> theme = new Dictionary<string, object>()
                {
                    { "DisplayName", themefile.GetSetting(section, "DisplayName", "Theme") },
                    { "BorderColor_R", int.Parse(themefile.GetSetting(section, "BorderColor", "245,101,101").Split(',')[0]) },
                    { "BorderColor_G", int.Parse(themefile.GetSetting(section, "BorderColor", "245,101,101").Split(',')[1]) },
                    { "BorderColor_B", int.Parse(themefile.GetSetting(section, "BorderColor", "245,101,101").Split(',')[2]) },
                    { "PanelTint_R", int.Parse(themefile.GetSetting(section, "PanelTint", "235,91,91").Split(',')[0]) },
                    { "PanelTint_G", int.Parse(themefile.GetSetting(section, "PanelTint", "235,91,91").Split(',')[1]) },
                    { "PanelTint_B", int.Parse(themefile.GetSetting(section, "PanelTint", "235,91,91").Split(',')[2]) },
                    { "AccentColor_R", int.Parse(themefile.GetSetting(section, "AccentColor", "255,111,111").Split(',')[0]) },
                    { "AccentColor_G", int.Parse(themefile.GetSetting(section, "AccentColor", "255,111,111").Split(',')[1]) },
                    { "AccentColor_B", int.Parse(themefile.GetSetting(section, "AccentColor", "255,111,111").Split(',')[2]) },
                    { "BaseTransp", themefile.GetSetting(section, "BaseTransp", 50) },
                    { "BorderThickness", themefile.GetSetting(section, "BorderThickness", 1) },
                    { "BorderRadius", themefile.GetSetting(section, "BorderRad", 10) },
                    { "BorderStyle", themefile.GetSetting(section, "BorderStyle", "solid") },
                    { "MaterialStyle", themefile.GetSetting(section, "MatStyle", "tabbed") },
                };
                themes.Add(theme);
            }
            return themes;
        }

        public void writeSearch(string title, Uri addr)
        {
            if (!incognitoMode) // dont log stuff if incognito mode is active
            {
                DateTime currentDateTime = DateTime.Now;

                historyfile.SetSetting("search:" + title.Replace(' ', '_'), "url", addr.ToString());
                historyfile.SetSetting("search:" + title.Replace(' ', '_'), "timestamp", currentDateTime);
                historyfile.SetSetting("search:" + title.Replace(' ', '_'), "title", title);
                historyfile.Save(".\\secondaryStorage\\history.ini");
            }
        }

        public List<Dictionary<string, string>> getSearches()
        {
            List<Dictionary<string, string>> searches = new List<Dictionary<string, string>>();
            if (File.ReadAllLines(".\\secondaryStorage\\history.ini", System.Text.Encoding.Default).Length < 3)
            {
                // normal entry is at least three lines, so of there is less, the history is empty so return nothing
                return searches;
            }

            foreach (string section in historyfile.GetSections())
            {
                Dictionary<string, string> search = new Dictionary<string, string>()
                {
                    { "url", historyfile.GetSetting(section, "url", "https://www.google.com/") },
                    { "time", historyfile.GetSetting(section, "timestamp", "2/13/2002 12:00:00") },
                    { "title", historyfile.GetSetting(section, "title", "Google") },
                };
                searches.Add(search);
            }
            return searches;
        }
    }
}
