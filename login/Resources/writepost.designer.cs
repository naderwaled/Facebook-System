namespace writepost
{
    partial class WritePosts
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Post = new System.Windows.Forms.Button();
            this.Write_Post = new System.Windows.Forms.Label();
            this.Exit = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Panel();
            this.textsearch = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tag = new System.Windows.Forms.Button();
            this.Write = new System.Windows.Forms.Label();
            this.Text22 = new System.Windows.Forms.TextBox();
            this.pict = new System.Windows.Forms.Button();
            this.username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.list = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.back.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.Post);
            this.panel1.Controls.Add(this.Write_Post);
            this.panel1.Controls.Add(this.Exit);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(896, 50);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Post
            // 
            this.Post.FlatAppearance.BorderSize = 0;
            this.Post.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Post.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Post.Location = new System.Drawing.Point(813, 0);
            this.Post.Name = "Post";
            this.Post.Size = new System.Drawing.Size(80, 47);
            this.Post.TabIndex = 1;
            this.Post.Text = "Post";
            this.Post.UseVisualStyleBackColor = true;
            this.Post.Click += new System.EventHandler(this.button2_Click);
            // 
            // Write_Post
            // 
            this.Write_Post.AutoSize = true;
            this.Write_Post.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write_Post.Location = new System.Drawing.Point(402, 3);
            this.Write_Post.Name = "Write_Post";
            this.Write_Post.Size = new System.Drawing.Size(141, 34);
            this.Write_Post.TabIndex = 2;
            this.Write_Post.Text = "Write Post";
            // 
            // Exit
            // 
            this.Exit.FlatAppearance.BorderSize = 0;
            this.Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Exit.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit.Image = global::Login.Properties.Resources.exit;
            this.Exit.Location = new System.Drawing.Point(0, 0);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(47, 50);
            this.Exit.TabIndex = 1;
            this.Exit.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.button1_Click);
            // 
            // back
            // 
            this.back.AutoScroll = true;
            this.back.Controls.Add(this.button1);
            this.back.Controls.Add(this.textsearch);
            this.back.Controls.Add(this.panel2);
            this.back.Controls.Add(this.tag);
            this.back.Controls.Add(this.Write);
            this.back.Controls.Add(this.Text22);
            this.back.Controls.Add(this.pict);
            this.back.Controls.Add(this.username);
            this.back.Controls.Add(this.pictureBox1);
            this.back.Controls.Add(this.list);
            this.back.Location = new System.Drawing.Point(12, 56);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(884, 410);
            this.back.TabIndex = 2;
            this.back.Paint += new System.Windows.Forms.PaintEventHandler(this.back_Paint);
            // 
            // textsearch
            // 
            this.textsearch.Location = new System.Drawing.Point(655, 61);
            this.textsearch.Name = "textsearch";
            this.textsearch.Size = new System.Drawing.Size(200, 24);
            this.textsearch.TabIndex = 0;
            this.textsearch.Visible = false;
            this.textsearch.TextChanged += new System.EventHandler(this.textsearch_TextChanged);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Location = new System.Drawing.Point(655, 85);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 299);
            this.panel2.TabIndex = 16;
            this.panel2.Visible = false;
            // 
            // tag
            // 
            this.tag.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tag.FlatAppearance.BorderSize = 0;
            this.tag.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tag.Image = global::Login.Properties.Resources.red_tag_icon;
            this.tag.Location = new System.Drawing.Point(824, 3);
            this.tag.Name = "tag";
            this.tag.Size = new System.Drawing.Size(57, 43);
            this.tag.TabIndex = 15;
            this.tag.UseVisualStyleBackColor = true;
            this.tag.Click += new System.EventHandler(this.tag_Click);
            // 
            // Write
            // 
            this.Write.AutoSize = true;
            this.Write.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Write.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.Write.Location = new System.Drawing.Point(12, 73);
            this.Write.Name = "Write";
            this.Write.Size = new System.Drawing.Size(123, 29);
            this.Write.TabIndex = 14;
            this.Write.Text = "Write Post";
            // 
            // Text22
            // 
            this.Text22.AllowDrop = true;
            this.Text22.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.Text22.BackColor = System.Drawing.Color.White;
            this.Text22.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Text22.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Text22.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Text22.Location = new System.Drawing.Point(17, 73);
            this.Text22.Multiline = true;
            this.Text22.Name = "Text22";
            this.Text22.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.Text22.Size = new System.Drawing.Size(856, 89);
            this.Text22.TabIndex = 13;
            this.Text22.TextChanged += new System.EventHandler(this.Text_TextChanged);
            // 
            // pict
            // 
            this.pict.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pict.FlatAppearance.BorderSize = 0;
            this.pict.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pict.Image = global::Login.Properties.Resources.camera_icon;
            this.pict.Location = new System.Drawing.Point(773, 3);
            this.pict.Name = "pict";
            this.pict.Size = new System.Drawing.Size(45, 43);
            this.pict.TabIndex = 12;
            this.pict.UseVisualStyleBackColor = true;
            this.pict.Click += new System.EventHandler(this.pict_Click);
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.username.Location = new System.Drawing.Point(69, 9);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(133, 23);
            this.username.TabIndex = 11;
            this.username.Text = "Nader Waled";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources._36374578_986556764855841_7833573697075019776_o;
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(60, 60);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // list
            // 
            this.list.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.list.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.list.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list.FormattingEnabled = true;
            this.list.Items.AddRange(new object[] {
            "Frinds Only",
            "Public"});
            this.list.Location = new System.Drawing.Point(73, 35);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(121, 32);
            this.list.Sorted = true;
            this.list.TabIndex = 9;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(655, 383);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Ok";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // WritePosts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(897, 473);
            this.Controls.Add(this.back);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WritePosts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.WritePosts_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.back.ResumeLayout(false);
            this.back.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Exit;
        private System.Windows.Forms.Label Write_Post;
        private System.Windows.Forms.Button Post;
        private System.Windows.Forms.Panel back;
        private System.Windows.Forms.Label Write;
        private System.Windows.Forms.TextBox Text22;
        private System.Windows.Forms.Button pict;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button tag;
        private System.Windows.Forms.ComboBox list;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textsearch;
        private System.Windows.Forms.Button button1;
    }
}

