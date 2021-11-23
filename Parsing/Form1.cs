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
using System.IO;

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
            if (Directory.Exists(@"C:\ProgramData\ScreenProj\Img"))
            {
                if (Directory.GetFiles(@"C:\ProgramData\ScreenProj\Img").Length > 0)
                {
                    foreach (var item in Directory.GetFiles(@"C:\ProgramData\ScreenProj\Img"))
                    {
                        this.listBox1.Items.Add(Path.GetFileName(item));
                    }
                }
            }
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
                        client.DownloadFile(node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["src"].Value, $@"{screen.DefaultPath}\{node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["image-id"].Value}.png");
                        listBox1.Items.Add(node.SelectSingleNode(@"//img[@class='no-click screenshot-image']").Attributes["image-id"].Value+".png");
                        if (directoryInfo.CheckDirectory())
                        {
                            aTimer.Enabled = true;
                        }
                        CountElements.Text = listBox1.Items.Count.ToString();
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

        private void BtnPause_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = false;
        }

        private void btnContinue_Click(object sender, EventArgs e)
        {
            aTimer.Enabled = true;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem.ToString().Length > 0)
            {
            this.pictureBox1.Image = (Image.FromFile($@"{screen.DefaultPath}\{listBox1.SelectedItem}"));
            }
        }

        private void addFavouriteBtn_Click(object sender, EventArgs e)
        {
            this.FavouriteFolderTextBox.Visible = true;
            this.FavouriteFolderTextBox.Focus();
        }

        private void FavouriteFolderTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == ((char)Keys.Enter))
            {
                if (FavouriteFolderTextBox.Text.Length > 4)
                {
                   
                        directoryInfo.FavouriteDir = this.FavouriteFolderTextBox.Text;
                        if (directoryInfo.FavouriteDir.EndsWith(@"\"))
                        {

                            directoryInfo.FavouriteDir = directoryInfo.FavouriteDir.Remove(directoryInfo.FavouriteDir.Last(), 1);
                        }
                        this.FavouriteFolderTextBox.Visible = false;
                   
                }
                
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image != null)
            {
                aTimer.Enabled = false;
                File.Copy($@"D:\Img\{listBox1.SelectedItem}", directoryInfo.FavouriteDir + $@"\{listBox1.SelectedItem}");
            }
           
        }

        
    }
}
