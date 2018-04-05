﻿namespace MovieRental
{
    partial class UC2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.YourMovieTab = new System.Windows.Forms.TabControl();
            this.Features = new System.Windows.Forms.TabPage();
            this.panelGenre = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.newRelease = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.Suggestion = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.top = new System.Windows.Forms.Panel();
            this.like = new System.Windows.Forms.Panel();
            this.youmayalsolike = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.rank = new System.Windows.Forms.Panel();
            this.YourMovie = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.SearchPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.YourMoviePanel = new System.Windows.Forms.Panel();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.YourMovieTab.SuspendLayout();
            this.Features.SuspendLayout();
            this.Suggestion.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // YourMovieTab
            // 
            this.YourMovieTab.Controls.Add(this.Features);
            this.YourMovieTab.Controls.Add(this.Suggestion);
            this.YourMovieTab.Controls.Add(this.YourMovie);
            this.YourMovieTab.Controls.Add(this.tabPage1);
            this.YourMovieTab.Location = new System.Drawing.Point(0, 63);
            this.YourMovieTab.Margin = new System.Windows.Forms.Padding(6);
            this.YourMovieTab.Name = "YourMovieTab";
            this.YourMovieTab.SelectedIndex = 0;
            this.YourMovieTab.Size = new System.Drawing.Size(1466, 1485);
            this.YourMovieTab.TabIndex = 0;
            this.YourMovieTab.SelectedIndexChanged += new System.EventHandler(this.YourMovieTab_SelectedIndexChanged);
            this.YourMovieTab.TabIndexChanged += new System.EventHandler(this.YourMovieTab_TabIndexChanged);
            // 
            // Features
            // 
            this.Features.AutoScroll = true;
            this.Features.Controls.Add(this.panelGenre);
            this.Features.Controls.Add(this.label3);
            this.Features.Controls.Add(this.newRelease);
            this.Features.Controls.Add(this.label2);
            this.Features.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Features.Location = new System.Drawing.Point(8, 39);
            this.Features.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Features.Name = "Features";
            this.Features.Padding = new System.Windows.Forms.Padding(6);
            this.Features.Size = new System.Drawing.Size(1450, 1438);
            this.Features.TabIndex = 0;
            this.Features.Text = "Feature";
            this.Features.UseVisualStyleBackColor = true;
            // 
            // panelGenre
            // 
            this.panelGenre.Location = new System.Drawing.Point(32, 844);
            this.panelGenre.Margin = new System.Windows.Forms.Padding(6);
            this.panelGenre.Name = "panelGenre";
            this.panelGenre.Size = new System.Drawing.Size(1400, 792);
            this.panelGenre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(22, 779);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(360, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "Choose Your Favorite Genre";
            // 
            // newRelease
            // 
            this.newRelease.AutoSize = true;
            this.newRelease.Location = new System.Drawing.Point(28, 77);
            this.newRelease.Margin = new System.Windows.Forms.Padding(6);
            this.newRelease.Name = "newRelease";
            this.newRelease.Size = new System.Drawing.Size(1410, 677);
            this.newRelease.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(22, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(191, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "New Released";
            // 
            // Suggestion
            // 
            this.Suggestion.AutoScroll = true;
            this.Suggestion.Controls.Add(this.label4);
            this.Suggestion.Controls.Add(this.top);
            this.Suggestion.Controls.Add(this.like);
            this.Suggestion.Controls.Add(this.youmayalsolike);
            this.Suggestion.Controls.Add(this.label1);
            this.Suggestion.Controls.Add(this.rank);
            this.Suggestion.Location = new System.Drawing.Point(8, 39);
            this.Suggestion.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.Suggestion.Name = "Suggestion";
            this.Suggestion.Padding = new System.Windows.Forms.Padding(6);
            this.Suggestion.Size = new System.Drawing.Size(1450, 1438);
            this.Suggestion.TabIndex = 1;
            this.Suggestion.Text = "Suggestion";
            this.Suggestion.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 1479);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 31);
            this.label4.TabIndex = 5;
            this.label4.Text = "Top Rented";
            // 
            // top
            // 
            this.top.Location = new System.Drawing.Point(22, 1527);
            this.top.Margin = new System.Windows.Forms.Padding(4);
            this.top.Name = "top";
            this.top.Size = new System.Drawing.Size(1410, 715);
            this.top.TabIndex = 4;
            // 
            // like
            // 
            this.like.Location = new System.Drawing.Point(22, 812);
            this.like.Margin = new System.Windows.Forms.Padding(4);
            this.like.Name = "like";
            this.like.Size = new System.Drawing.Size(1410, 638);
            this.like.TabIndex = 3;
            // 
            // youmayalsolike
            // 
            this.youmayalsolike.AutoSize = true;
            this.youmayalsolike.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.youmayalsolike.Location = new System.Drawing.Point(16, 765);
            this.youmayalsolike.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.youmayalsolike.Name = "youmayalsolike";
            this.youmayalsolike.Size = new System.Drawing.Size(237, 31);
            this.youmayalsolike.TabIndex = 2;
            this.youmayalsolike.Text = "You May Also Like";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 19);
            this.label1.Margin = new System.Windows.Forms.Padding(12, 0, 12, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ranking";
            // 
            // rank
            // 
            this.rank.Location = new System.Drawing.Point(22, 71);
            this.rank.Margin = new System.Windows.Forms.Padding(4);
            this.rank.Name = "rank";
            this.rank.Size = new System.Drawing.Size(1410, 662);
            this.rank.TabIndex = 0;
            // 
            // YourMovie
            // 
            this.YourMovie.AutoScroll = true;
            this.YourMovie.Location = new System.Drawing.Point(8, 39);
            this.YourMovie.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.YourMovie.Name = "YourMovie";
            this.YourMovie.Padding = new System.Windows.Forms.Padding(12);
            this.YourMovie.Size = new System.Drawing.Size(1450, 1438);
            this.YourMovie.TabIndex = 0;
            this.YourMovie.Text = "Your Movie";
            this.YourMovie.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.SearchPanel);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(6);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(6);
            this.tabPage1.Size = new System.Drawing.Size(1450, 1438);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Search";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // SearchPanel
            // 
            this.SearchPanel.Location = new System.Drawing.Point(0, 22);
            this.SearchPanel.Margin = new System.Windows.Forms.Padding(6);
            this.SearchPanel.Name = "SearchPanel";
            this.SearchPanel.Size = new System.Drawing.Size(1450, 1413);
            this.SearchPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(627, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(740, 92);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(426, 10);
            this.button2.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 83);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wishlist";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(582, 10);
            this.button1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(140, 83);
            this.button1.TabIndex = 2;
            this.button1.Text = "Account";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(0, 48);
            this.textBox1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(268, 31);
            this.textBox1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::MovieRental.Properties.Resources.Icons8_Ios7_Very_Basic_Search;
            this.pictureBox1.Location = new System.Drawing.Point(272, 42);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(12, 13, 12, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(68, 44);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // YourMoviePanel
            // 
            this.YourMoviePanel.Location = new System.Drawing.Point(9, 10);
            this.YourMoviePanel.Name = "YourMoviePanel";
            this.YourMoviePanel.Size = new System.Drawing.Size(862, 483);
            this.YourMoviePanel.TabIndex = 2;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // UC2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.YourMovieTab);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "UC2";
            this.Size = new System.Drawing.Size(1478, 1565);
            this.Load += new System.EventHandler(this.UC2_Load);
            this.YourMovieTab.ResumeLayout(false);
            this.Features.ResumeLayout(false);
            this.Features.PerformLayout();
            this.Suggestion.ResumeLayout(false);
            this.Suggestion.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl YourMovieTab;
        private System.Windows.Forms.TabPage Features;
        private System.Windows.Forms.TabPage Suggestion;
        private System.Windows.Forms.TabPage YourMovie;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel rank;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel YourMoviePanel;
        private System.Windows.Forms.Panel like;
        private System.Windows.Forms.Label youmayalsolike;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel newRelease;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panelGenre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel top;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel SearchPanel;
    }
}
