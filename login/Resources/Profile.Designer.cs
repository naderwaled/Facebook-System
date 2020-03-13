namespace Login.Resources
{
    partial class Profile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profile));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Minimize = new System.Windows.Forms.PictureBox();
            this.Exit = new System.Windows.Forms.PictureBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.searchBtn = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.PictureBox();
            this.profileBtn = new System.Windows.Forms.PictureBox();
            this.settingBtn = new System.Windows.Forms.PictureBox();
            this.notifBtn = new System.Windows.Forms.PictureBox();
            this.msgBtn = new System.Windows.Forms.PictureBox();
            this.requestBtn = new System.Windows.Forms.PictureBox();
            this.homeBtn = new System.Windows.Forms.PictureBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tagText = new System.Windows.Forms.TextBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.About = new System.Windows.Forms.Button();
            this.Name = new System.Windows.Forms.Label();
            this.Friends = new System.Windows.Forms.Button();
            this.Photos = new System.Windows.Forms.Button();
            this.ChangeCP = new System.Windows.Forms.Button();
            this.ChangePP = new System.Windows.Forms.Button();
            this.profilePic = new System.Windows.Forms.PictureBox();
            this.splitContainer3 = new System.Windows.Forms.SplitContainer();
            this.coverPhoto = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).BeginInit();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).BeginInit();
            this.splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Minimize);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(929, 36);
            this.panel1.TabIndex = 3;
            // 
            // Minimize
            // 
            this.Minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Minimize.Image = ((System.Drawing.Image)(resources.GetObject("Minimize.Image")));
            this.Minimize.Location = new System.Drawing.Point(789, 0);
            this.Minimize.Name = "Minimize";
            this.Minimize.Size = new System.Drawing.Size(35, 35);
            this.Minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Minimize.TabIndex = 1;
            this.Minimize.TabStop = false;
            this.Minimize.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Minimize_MouseClick);
            // 
            // Exit
            // 
            this.Exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit.Image = ((System.Drawing.Image)(resources.GetObject("Exit.Image")));
            this.Exit.Location = new System.Drawing.Point(845, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(35, 35);
            this.Exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Exit.TabIndex = 0;
            this.Exit.TabStop = false;
            this.Exit.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Exit_MouseClick);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.IsSplitterFixed = true;
            this.splitContainer1.Location = new System.Drawing.Point(0, 36);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.tableLayoutPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(929, 752);
            this.splitContainer1.SplitterDistance = 45;
            this.splitContainer1.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.DimGray;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.searchBtn, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel5, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.tableLayoutPanel1.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.515957F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 93.48404F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(47, 752);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // searchBtn
            // 
            this.searchBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.searchBtn.Image = ((System.Drawing.Image)(resources.GetObject("searchBtn.Image")));
            this.searchBtn.Location = new System.Drawing.Point(3, 4);
            this.searchBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(41, 40);
            this.searchBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.searchBtn.TabIndex = 0;
            this.searchBtn.TabStop = false;
            this.searchBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.searchBtn_MouseClick);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.logoutBtn);
            this.panel5.Controls.Add(this.profileBtn);
            this.panel5.Controls.Add(this.settingBtn);
            this.panel5.Controls.Add(this.notifBtn);
            this.panel5.Controls.Add(this.msgBtn);
            this.panel5.Controls.Add(this.requestBtn);
            this.panel5.Controls.Add(this.homeBtn);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 52);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(41, 696);
            this.panel5.TabIndex = 1;
            // 
            // logoutBtn
            // 
            this.logoutBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutBtn.Image = ((System.Drawing.Image)(resources.GetObject("logoutBtn.Image")));
            this.logoutBtn.Location = new System.Drawing.Point(2, 379);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(35, 35);
            this.logoutBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoutBtn.TabIndex = 2;
            this.logoutBtn.TabStop = false;
            this.logoutBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.logoutBtn_MouseClick);
            // 
            // profileBtn
            // 
            this.profileBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.profileBtn.Image = ((System.Drawing.Image)(resources.GetObject("profileBtn.Image")));
            this.profileBtn.Location = new System.Drawing.Point(2, 44);
            this.profileBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.profileBtn.Name = "profileBtn";
            this.profileBtn.Size = new System.Drawing.Size(35, 35);
            this.profileBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.profileBtn.TabIndex = 1;
            this.profileBtn.TabStop = false;
            // 
            // settingBtn
            // 
            this.settingBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.settingBtn.Image = ((System.Drawing.Image)(resources.GetObject("settingBtn.Image")));
            this.settingBtn.Location = new System.Drawing.Point(2, 335);
            this.settingBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.settingBtn.Name = "settingBtn";
            this.settingBtn.Size = new System.Drawing.Size(35, 35);
            this.settingBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.settingBtn.TabIndex = 1;
            this.settingBtn.TabStop = false;
            // 
            // notifBtn
            // 
            this.notifBtn.BackColor = System.Drawing.Color.Transparent;
            this.notifBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.notifBtn.Image = ((System.Drawing.Image)(resources.GetObject("notifBtn.Image")));
            this.notifBtn.Location = new System.Drawing.Point(2, 123);
            this.notifBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.notifBtn.Name = "notifBtn";
            this.notifBtn.Size = new System.Drawing.Size(35, 35);
            this.notifBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.notifBtn.TabIndex = 0;
            this.notifBtn.TabStop = false;
            this.notifBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifBtn_MouseClick);
            // 
            // msgBtn
            // 
            this.msgBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.msgBtn.Image = ((System.Drawing.Image)(resources.GetObject("msgBtn.Image")));
            this.msgBtn.Location = new System.Drawing.Point(2, 167);
            this.msgBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.msgBtn.Name = "msgBtn";
            this.msgBtn.Size = new System.Drawing.Size(35, 35);
            this.msgBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.msgBtn.TabIndex = 1;
            this.msgBtn.TabStop = false;
            this.msgBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.msgBtn_MouseClick);
            // 
            // requestBtn
            // 
            this.requestBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.requestBtn.Image = ((System.Drawing.Image)(resources.GetObject("requestBtn.Image")));
            this.requestBtn.Location = new System.Drawing.Point(2, 212);
            this.requestBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.requestBtn.Name = "requestBtn";
            this.requestBtn.Size = new System.Drawing.Size(35, 35);
            this.requestBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.requestBtn.TabIndex = 2;
            this.requestBtn.TabStop = false;
            this.requestBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.requestBtn_MouseClick);
            // 
            // homeBtn
            // 
            this.homeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.homeBtn.Image = ((System.Drawing.Image)(resources.GetObject("homeBtn.Image")));
            this.homeBtn.Location = new System.Drawing.Point(2, 0);
            this.homeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(37, 37);
            this.homeBtn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.homeBtn.TabIndex = 0;
            this.homeBtn.TabStop = false;
            this.homeBtn.MouseClick += new System.Windows.Forms.MouseEventHandler(this.homeBtn_MouseClick);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.BackColor = System.Drawing.Color.DimGray;
            this.splitContainer2.Panel1.Controls.Add(this.tagText);
            this.splitContainer2.Panel1.Controls.Add(this.panel6);
            this.splitContainer2.Panel1.Controls.Add(this.About);
            this.splitContainer2.Panel1.Controls.Add(this.Name);
            this.splitContainer2.Panel1.Controls.Add(this.Friends);
            this.splitContainer2.Panel1.Controls.Add(this.Photos);
            this.splitContainer2.Panel1.Controls.Add(this.ChangeCP);
            this.splitContainer2.Panel1.Controls.Add(this.ChangePP);
            this.splitContainer2.Panel1.Controls.Add(this.profilePic);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer3);
            this.splitContainer2.Panel2.Controls.Add(this.coverPhoto);
            this.splitContainer2.Size = new System.Drawing.Size(880, 752);
            this.splitContainer2.SplitterDistance = 250;
            this.splitContainer2.TabIndex = 0;
            // 
            // tagText
            // 
            this.tagText.Location = new System.Drawing.Point(0, 0);
            this.tagText.Name = "tagText";
            this.tagText.Size = new System.Drawing.Size(290, 24);
            this.tagText.TabIndex = 9;
            this.tagText.Visible = false;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(0, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(290, 752);
            this.panel6.TabIndex = 8;
            this.panel6.Visible = false;
            // 
            // About
            // 
            this.About.AutoSize = true;
            this.About.FlatAppearance.BorderSize = 0;
            this.About.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.About.Font = new System.Drawing.Font("Tahoma", 11F);
            this.About.ForeColor = System.Drawing.Color.White;
            this.About.Location = new System.Drawing.Point(0, 550);
            this.About.Name = "About";
            this.About.Size = new System.Drawing.Size(296, 35);
            this.About.TabIndex = 7;
            this.About.Text = "About";
            this.About.UseVisualStyleBackColor = true;
            this.About.MouseClick += new System.Windows.Forms.MouseEventHandler(this.About_MouseClick);
            // 
            // Name
            // 
            this.Name.AutoSize = true;
            this.Name.Dock = System.Windows.Forms.DockStyle.Top;
            this.Name.Font = new System.Drawing.Font("Perpetua Titling MT", 20F, System.Drawing.FontStyle.Bold);
            this.Name.ForeColor = System.Drawing.Color.White;
            this.Name.Location = new System.Drawing.Point(0, 250);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(145, 82);
            this.Name.TabIndex = 6;
            this.Name.Text = "Karim\r\nAtef";
            // 
            // Friends
            // 
            this.Friends.FlatAppearance.BorderSize = 0;
            this.Friends.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Friends.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Friends.ForeColor = System.Drawing.Color.White;
            this.Friends.Location = new System.Drawing.Point(0, 650);
            this.Friends.Name = "Friends";
            this.Friends.Size = new System.Drawing.Size(296, 35);
            this.Friends.TabIndex = 5;
            this.Friends.Text = "Friends";
            this.Friends.UseVisualStyleBackColor = true;
            // 
            // Photos
            // 
            this.Photos.FlatAppearance.BorderSize = 0;
            this.Photos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Photos.Font = new System.Drawing.Font("Tahoma", 11F);
            this.Photos.ForeColor = System.Drawing.Color.White;
            this.Photos.Location = new System.Drawing.Point(0, 600);
            this.Photos.Name = "Photos";
            this.Photos.Size = new System.Drawing.Size(296, 35);
            this.Photos.TabIndex = 4;
            this.Photos.Text = "Photos";
            this.Photos.UseVisualStyleBackColor = true;
            // 
            // ChangeCP
            // 
            this.ChangeCP.AutoSize = true;
            this.ChangeCP.FlatAppearance.BorderSize = 0;
            this.ChangeCP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangeCP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ChangeCP.ForeColor = System.Drawing.Color.White;
            this.ChangeCP.Location = new System.Drawing.Point(0, 500);
            this.ChangeCP.Name = "ChangeCP";
            this.ChangeCP.Size = new System.Drawing.Size(296, 35);
            this.ChangeCP.TabIndex = 3;
            this.ChangeCP.Text = "Change Cover Photo";
            this.ChangeCP.UseVisualStyleBackColor = true;
            this.ChangeCP.Click += new System.EventHandler(this.ChangeCP_Click);
            // 
            // ChangePP
            // 
            this.ChangePP.FlatAppearance.BorderSize = 0;
            this.ChangePP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ChangePP.Font = new System.Drawing.Font("Tahoma", 11F);
            this.ChangePP.ForeColor = System.Drawing.Color.White;
            this.ChangePP.Location = new System.Drawing.Point(0, 450);
            this.ChangePP.Name = "ChangePP";
            this.ChangePP.Size = new System.Drawing.Size(296, 35);
            this.ChangePP.TabIndex = 2;
            this.ChangePP.Text = "Change Profile Picture";
            this.ChangePP.UseVisualStyleBackColor = true;
            this.ChangePP.Click += new System.EventHandler(this.ChangePP_Click);
            // 
            // profilePic
            // 
            this.profilePic.Dock = System.Windows.Forms.DockStyle.Top;
            this.profilePic.Location = new System.Drawing.Point(0, 0);
            this.profilePic.Name = "profilePic";
            this.profilePic.Size = new System.Drawing.Size(248, 250);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // splitContainer3
            // 
            this.splitContainer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer3.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer3.Location = new System.Drawing.Point(0, 300);
            this.splitContainer3.Name = "splitContainer3";
            this.splitContainer3.Size = new System.Drawing.Size(626, 452);
            this.splitContainer3.SplitterDistance = 426;
            this.splitContainer3.TabIndex = 0;
            // 
            // coverPhoto
            // 
            this.coverPhoto.Dock = System.Windows.Forms.DockStyle.Top;
            this.coverPhoto.Location = new System.Drawing.Point(0, 0);
            this.coverPhoto.Name = "coverPhoto";
            this.coverPhoto.Size = new System.Drawing.Size(626, 300);
            this.coverPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coverPhoto.TabIndex = 0;
            this.coverPhoto.TabStop = false;
            this.coverPhoto.Click += new System.EventHandler(this.coverPhoto_Click);
            // 
            // Profile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(929, 788);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
        //    this.Name = "Profile";
            this.Text = "Profile";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Profile_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Exit)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchBtn)).EndInit();
            this.panel5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoutBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.profileBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.settingBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.notifBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.msgBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requestBtn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeBtn)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer3)).EndInit();
            this.splitContainer3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.coverPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox Minimize;
        private System.Windows.Forms.PictureBox Exit;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button Friends;
        private System.Windows.Forms.Button Photos;
        private System.Windows.Forms.Button ChangeCP;
        private System.Windows.Forms.Button ChangePP;
        private System.Windows.Forms.PictureBox profilePic;
        private System.Windows.Forms.SplitContainer splitContainer3;
        private System.Windows.Forms.PictureBox coverPhoto;
        private System.Windows.Forms.Label Name;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox searchBtn;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox logoutBtn;
        private System.Windows.Forms.PictureBox profileBtn;
        private System.Windows.Forms.PictureBox settingBtn;
        private System.Windows.Forms.PictureBox notifBtn;
        private System.Windows.Forms.PictureBox msgBtn;
        private System.Windows.Forms.PictureBox requestBtn;
        private System.Windows.Forms.PictureBox homeBtn;
        private System.Windows.Forms.Button About;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox tagText;
    }
}