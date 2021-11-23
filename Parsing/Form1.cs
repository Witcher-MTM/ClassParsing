using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Timers;
using System.Net;

namespace Parsing
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer aTimer;
        private ScreenInfo screen;
        private DirectoryInfo directoryInfo;
        public Form1()
        {
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Interval = 1000;
            aTimer.Tick += ATimer_Tick;
            InitializeComponent();
            aTimer.Start();
            screen = new ScreenInfo();
            directoryInfo = new DirectoryInfo();
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            this.TextHtmlInner.Text = string.Empty;
            Init();
        }
        public void Init()
        {
            screen.InitScreen();
            var html = @"https://prnt.sc/"+screen.RandScreen;
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var node = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='image-constrain js-image-wrap']");
            try
            {
                if (node != null)
                { 
                    this.TextHtmlInner.Text = node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["src"].Value;
                    using (WebClient client = new WebClient())
                    {
                        aTimer.Enabled = false;
                        client.DownloadFile(node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["src"].Value, $@"D:\Img\{node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["image-id"].Value}.png");
                        
                        if (directoryInfo.CheckDirectory())
                        {
                            aTimer.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception)
            {
                aTimer.Enabled = true;
            }

            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TextHtmlInner.ReadOnly = true;
            Init();
        }
    }
}
