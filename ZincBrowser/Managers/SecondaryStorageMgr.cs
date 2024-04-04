using SoftCircuits.IniFileParser;
using System.Collections.Generic;

namespace ZincBrowser
{
    internal class SecondaryStorageMgr
    {
        public static IniFile themefile = new IniFile();

        public SecondaryStorageMgr()
        {
            themefile.Load(".\\secondaryStorage\\themes.ini");
            // this is secondary storage, storage that is only really accessed when the user requests it via the settings or history page
            // ZincBrowser.exe.config is for more frequently accessed configuration example the user's color preferences
        }

        public List<List<string>> loadHistory()
        {
            int index = 0;
            List<List<string>> history = new List<List<string>>();

            foreach (string section in themefile.GetSections())
            {
                if (section.Split(':')[0] == "search")
                {
                    history[index][0] = themefile.GetSetting(section, "title", string.Empty); // page title
                    history[index][1] = themefile.GetSetting(section, "url", string.Empty); // url
                    index++;
                }
            }
            return history;
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
    }
}
