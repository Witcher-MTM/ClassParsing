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

namespace Parsing
{
    public partial class Form1 : Form
    {
        private System.Windows.Forms.Timer aTimer;
        public Form1()
        {
            aTimer = new System.Windows.Forms.Timer();
            aTimer.Interval = 30000;
            aTimer.Tick += ATimer_Tick;
            InitializeComponent();
            aTimer.Start();
        }

        private void ATimer_Tick(object sender, EventArgs e)
        {
            this.TextHtmlInner.Text = string.Empty;
            Init();
        }
        public void Init()
        {
            var html = @"https://www.gismeteo.ua/";
            HtmlWeb web = new HtmlWeb();
            var htmlDoc = web.Load(html);
            var node = htmlDoc.DocumentNode.SelectSingleNode(@"//div[@class='wn_body']");
            this.TextHtmlInner.Text += node.SelectSingleNode(@"//a[@class='link blue weather_current_link no_border']").InnerText.Trim();
            this.TextHtmlInner.Text += node.SelectSingleNode(@"//div[@class='js_meas_container temperature']").InnerText.Trim();
            this.TextHtmlInner.Text += node.SelectSingleNode(@"//div[@class='ii info_label']").InnerText.Trim() + node.SelectSingleNode(@"//div[@class='ii info_value']").InnerText.Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.TextHtmlInner.ReadOnly = true;
            Init();
        }
    }
}
