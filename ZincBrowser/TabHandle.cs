using Microsoft.Web.WebView2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using HtmlAgilityPack;
using HtmlDocument = HtmlAgilityPack.HtmlDocument;
using ZincBrowser.Properties;
using Siticone.UI.WinForms;
using Microsoft.Web.WebView2.Core;

namespace ZincBrowser
{
    public partial class TabHandle : UserControl
    {
        public string url;
        public WebView2 page;
        private SiticoneMaterialTextBox addr;

        Form1 f = new Form1();

        public TabHandle(string url, WebView2 page, SiticoneMaterialTextBox addr)
        {
            InitializeComponent();
            this.url = url;
            this.page = page;
            this.addr = addr;
        }

        public static async Task<string> GetPageTitleAsync(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    // Make a GET request to fetch the webpage content
                    HttpResponseMessage response = await client.GetAsync(url);

                    if (response.IsSuccessStatusCode)
                    {
                        // Read the webpage content as a string
                        string htmlContent = await response.Content.ReadAsStringAsync();

                        // Load the HTML content into HtmlDocument
                        HtmlDocument doc = new HtmlDocument();
                        doc.LoadHtml(htmlContent);

                        // Get the title node from the HTML document
                        HtmlNode titleNode = doc.DocumentNode.SelectSingleNode("//title");

                        if (titleNode != null)
                        {
                            // Return the inner text of the title node
                            return titleNode.InnerText.Trim();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error fetching page title: {ex.Message}");
            }

            return null;
        }

        private async void TabHandle_Load(object sender, EventArgs e)
        {
            // TODO: add favicons
            main.Text = await GetPageTitleAsync(url);
            main.Width = Parent.Width - 20 - cls.Width;
            cls.Location = new Point(main.Width + 10, cls.Location.Y);
            cls.Height = main.Height;
            cls.Width = cls.Height;
            f.setButtonColors(main);
            f.setButtonColors(cls);

            page.SourceChanged += Page_SourceChanged;
        }

        private async void Page_SourceChanged(object sender, Microsoft.Web.WebView2.Core.CoreWebView2SourceChangedEventArgs e)
        {
            main.Text = await GetPageTitleAsync(page.Source.ToString());
            addr.Text = page.Source.ToString();
            f.history.Add(page.Source.ToString());
        }

        private void TabHandle_Click(object sender, EventArgs e)
        {
            page.BringToFront();
            addr.Text = page.Source.ToString();
            f.currentPage = page;
        }

        private void close_Click(object sender, EventArgs e)
        {
            addr.Text = "";
            page.Dispose();
            Dispose();
        }
    }
}
