
namespace Parsing
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextHtmlInner = new System.Windows.Forms.TextBox();
            this.CountElements = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.BtnPause = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.addFavouriteBtn = new System.Windows.Forms.Button();
            this.FavouriteFolderTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // TextHtmlInner
            // 
            this.TextHtmlInner.Location = new System.Drawing.Point(12, 12);
            this.TextHtmlInner.Name = "TextHtmlInner";
            this.TextHtmlInner.Size = new System.Drawing.Size(311, 20);
            this.TextHtmlInner.TabIndex = 0;
            // 
            // CountElements
            // 
            this.CountElements.AutoSize = true;
            this.CountElements.Location = new System.Drawing.Point(698, 15);
            this.CountElements.Name = "CountElements";
            this.CountElements.Size = new System.Drawing.Size(0, 13);
            this.CountElements.TabIndex = 1;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 38);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 368);
            this.listBox1.TabIndex = 2;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // BtnPause
            // 
            this.BtnPause.Location = new System.Drawing.Point(12, 415);
            this.BtnPause.Name = "BtnPause";
            this.BtnPause.Size = new System.Drawing.Size(75, 23);
            this.BtnPause.TabIndex = 3;
            this.BtnPause.Text = "Pause";
            this.BtnPause.UseVisualStyleBackColor = true;
            this.BtnPause.Click += new System.EventHandler(this.BtnPause_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(159, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 367);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnContinue
            // 
            this.btnContinue.Location = new System.Drawing.Point(93, 415);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(75, 23);
            this.btnContinue.TabIndex = 5;
            this.btnContinue.Text = "Continue";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // addFavouriteBtn
            // 
            this.addFavouriteBtn.Location = new System.Drawing.Point(329, 10);
            this.addFavouriteBtn.Name = "addFavouriteBtn";
            this.addFavouriteBtn.Size = new System.Drawing.Size(270, 23);
            this.addFavouriteBtn.TabIndex = 6;
            this.addFavouriteBtn.Text = "Add Favourite Folder";
            this.addFavouriteBtn.UseVisualStyleBackColor = true;
            this.addFavouriteBtn.Click += new System.EventHandler(this.addFavouriteBtn_Click);
            // 
            // FavouriteFolderTextBox
            // 
            this.FavouriteFolderTextBox.Location = new System.Drawing.Point(605, 12);
            this.FavouriteFolderTextBox.Name = "FavouriteFolderTextBox";
            this.FavouriteFolderTextBox.Size = new System.Drawing.Size(182, 20);
            this.FavouriteFolderTextBox.TabIndex = 7;
            this.FavouriteFolderTextBox.Text = "Enter path to Folder";
            this.FavouriteFolderTextBox.Visible = false;
            this.FavouriteFolderTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.FavouriteFolderTextBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(557, 425);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(202, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Click on Image to save in Favourite folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.FavouriteFolderTextBox);
            this.Controls.Add(this.addFavouriteBtn);
            this.Controls.Add(this.btnContinue);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnPause);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.CountElements);
            this.Controls.Add(this.TextHtmlInner);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextHtmlInner;
        private System.Windows.Forms.Label CountElements;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button BtnPause;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Button addFavouriteBtn;
        private System.Windows.Forms.TextBox FavouriteFolderTextBox;
        private System.Windows.Forms.Label label1;
    }
}

