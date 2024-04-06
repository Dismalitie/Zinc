using System;
using System.Drawing;
using System.Windows.Forms;
using ZincBrowser.Properties;

namespace ZincBrowser.UCs
{
    public partial class SearchHandle : UserControl
    {
        public string searchTitle = "Google";
        public string searchUrl = "https://www.google.com/";
        public string searchTime;

        Form1 f = new Form1();

        public SearchHandle(string searchTitle, string searchUrl, string searchTime)
        {
            InitializeComponent();
            this.searchTitle = searchTitle;
            this.searchUrl = searchUrl;
            this.searchTime = searchTime;
        }

        public string timeDiffFmt(DateTime timestamp, DateTime currentTime)
        {
            TimeSpan difference = currentTime - timestamp;

            if (difference.TotalDays >= 365)
            {
                int years = (int)(difference.TotalDays / 365);
                return years == 1 ? "1 year ago" : years + " years ago";
            }
            else if (difference.TotalDays >= 30)
            {
                int months = (int)(difference.TotalDays / 30);
                return months == 1 ? "1 month ago" : months + " months ago";
            }
            else if (difference.TotalDays >= 7)
            {
                int weeks = (int)(difference.TotalDays / 7);
                return weeks == 1 ? "1 week ago" : weeks + " weeks ago";
            }
            else if (difference.TotalDays >= 1)
            {
                return difference.TotalDays == 1 ? "Yesterday" : ((int)difference.TotalDays) + " days ago";
            }
            else if (difference.TotalHours >= 1)
            {
                return difference.TotalHours == 1 ? "1 hour ago" : ((int)difference.TotalHours) + " hours ago";
            }
            else if (difference.TotalMinutes >= 1)
            {
                return difference.TotalMinutes == 1 ? "1 minute ago" : ((int)difference.TotalMinutes) + " minutes ago";
            }
            else
            {
                return "Just now";
            }
        }

        private void SearchHandle_Load(object sender, EventArgs e)
        {
            ColorMgr cm = new ColorMgr();

            cm.setButtonColors(open);

            title.Text = searchTitle;
            try
            {
                url.Text = new Uri(searchUrl).Host;
                time.Text = timeDiffFmt(DateTime.Parse(searchTime), DateTime.Now);
            }
            catch
            {
                
            }

            Size titleSz = TextRenderer.MeasureText(title.Text, title.Font);
            Size timeSz = TextRenderer.MeasureText(time.Text, time.Font);

            url.Location = new Point(ico.Location.X + ico.Width + titleSz.Width + 10, title.Location.Y);
            time.Location = new Point(Width - 5 - timeSz.Width - open.Width, url.Location.Y);

            eli.BorderRadius = Settings.Default.BorderRadius + 5;
        }

        private void SearchHandle_Click(object sender, EventArgs e)
        {
            
        }

        private void open_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(searchUrl);
        }
    }
}
