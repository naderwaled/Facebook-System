using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FACEBOOK;
using System.IO;
using Messenger;
using Login.Resources;
using Login;
using new_design;


namespace Login.Resources
{
    public partial class Profile : Form
    {

        string fname;
        string sname;
        byte[] pic;
        public Panel msgPanel = new Panel();
        public Panel notifPanel = new Panel();
        public Panel requestPanel = new Panel();

        public Profile()
        {
            InitializeComponent();
            hidePanels();
        }

        private void Profile_Load(object sender, EventArgs e)
        {
           
            chatFun();
            tooltipForIcons();
            writePostFun();
           // post_showCommentsFun();
            Name.Text = login.me.FristName + "\n" + login.me.SecondName;
            if (login.me.profileimage != null)
            {
               
                
                    MemoryStream stream = new MemoryStream(login.me.profileimage);
                    profilePic.Image = System.Drawing.Image.FromStream(stream);
                
            }
            if (login.me.coverimage != null)
            {


                MemoryStream stream = new MemoryStream(login.me.coverimage);
                coverPhoto.Image = System.Drawing.Image.FromStream(stream);

            }
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void homeBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Form1 goHome = new Form1();
            this.Close();
            goHome.Show();
        }

        private void About_MouseClick(object sender, MouseEventArgs e)
        {
            Edit ed = new Edit();
            ed.Show();
        }

        private void logoutBtn_MouseClick(object sender, MouseEventArgs e)
        {
            login lo = new login();
            this.Hide();
            lo.Show();
        }

        private void notifBtn_MouseClick(object sender, MouseEventArgs e)
        {
            msgPanel.Hide();
            requestPanel.Hide();
            notifPanel.Show();

            notifPanel.Size = new Size(200, 400);
            notifPanel.Location = new Point(40, 220);
            notifPanel.BackColor = Color.White;
            this.Controls.Add(notifPanel);
            notifPanel.BringToFront();
        }

        private void msgBtn_MouseClick(object sender, MouseEventArgs e)
        {
            //Messenger mo = new Messenger();

            //login.moo.Show();
            //notifPanel.Hide();
            //requestPanel.Hide();
            //msgPanel.Show();
            //youMayKnowFun();

            //msgPanel.Size = new Size(200, 400);
            //msgPanel.Location = new Point(40, 255);
            //msgPanel.BackColor = Color.White;
            //this.Controls.Add(msgPanel);
            //msgPanel.BringToFront();

            //Panel msgContainer = new Panel();
            //msgContainer.Size = new Size(190, 80);
            //msgContainer.Location = new Point(5, 5);
            //msgContainer.BorderStyle = BorderStyle.FixedSingle;
            ////postContainer.Anchor = (AnchorStyles.Top | AnchorStyles.Right | AnchorStyles.Left);
            //msgPanel.Controls.Add(msgContainer);

            //PictureBox userPic = new PictureBox();
            //userPic.Size = new Size(30, 30);
            //userPic.Location = new Point(5, 5);
            //userPic.BorderStyle = BorderStyle.FixedSingle;
            //userPic.Cursor = Cursors.Hand;
            //msgContainer.Controls.Add(userPic);

            //Label userName = new Label();
            //userName.AutoSize = true;
            //userName.Location = new Point(35, 5);
            //userName.Text = "Nader Waled";
            //userName.Font = new Font("Tahoma", 9, FontStyle.Bold);
            //userName.Cursor = Cursors.Hand;
            //msgContainer.Controls.Add(userName);

            //Label date = new Label();
            //date.AutoSize = true;
            //date.Location = new Point(35, 20);
            //date.Text = "3 minutes ago";
            //date.Font = new Font("Tahoma", 7, FontStyle.Regular);
            //msgContainer.Controls.Add(date);

            //Label postText = new Label();
            //postText.AutoSize = true;
            //postText.Location = new Point(5, 40);
            ////postText.BorderStyle = BorderStyle.FixedSingle;
            //postText.Text = "Hello , how are you ?";
            //postText.Font = new Font("Tahoma", 9, FontStyle.Regular);
            //msgContainer.Controls.Add(postText);
        }

        private void requestBtn_MouseClick(object sender, MouseEventArgs e)
        {
            notifPanel.Hide();
            msgPanel.Hide();
            requestPanel.Show();

            requestPanel.Size = new Size(200, 400);
            requestPanel.Location = new Point(40, 295);
            requestPanel.BackColor = Color.White;
            this.Controls.Add(requestPanel);
            requestPanel.BringToFront();
            for (int i = 0; i < login.me.friends_request.Count; i++)
            {
                login.me.frienddata(login.me.friends_request[i], ref fname, ref sname, ref pic);
                Panel requestContainer = new Panel();
                requestContainer.Size = new Size(190, 80);
                requestContainer.Location = new Point(5, 5 + 80 * i);
                requestContainer.BorderStyle = BorderStyle.FixedSingle;
                requestPanel.Controls.Add(requestContainer);

                PictureBox userPic = new PictureBox();
                userPic.Size = new Size(30, 30);
                userPic.Location = new Point(5, 5);
                userPic.BorderStyle = BorderStyle.FixedSingle;
                userPic.SizeMode = PictureBoxSizeMode.StretchImage;
                userPic.Cursor = Cursors.Hand;
                requestContainer.Controls.Add(userPic);
                if (pic != null)
                {
                    MemoryStream stream = new MemoryStream(pic);
                    userPic.Image = System.Drawing.Image.FromStream(stream);
                }

                Label userName = new Label();
                userName.AutoSize = true;
                userName.Location = new Point(40, 10);
                userName.Text = fname + " " + sname;
                userName.Font = new Font("Tahoma", 11, FontStyle.Bold);
                userName.Cursor = Cursors.Hand;
                requestContainer.Controls.Add(userName);



                Button acceptBtn = new Button();
                acceptBtn.Size = new Size(90, 25);
                acceptBtn.Location = new Point(5, 50);
                acceptBtn.Text = "Accept";
                acceptBtn.FlatStyle = FlatStyle.Flat;
                acceptBtn.FlatAppearance.BorderSize = 1;
                acceptBtn.FlatAppearance.BorderColor = Color.White;
                acceptBtn.ForeColor = Color.White;
                acceptBtn.BackColor = Color.DimGray;
                acceptBtn.Cursor = Cursors.Hand;
                requestContainer.Controls.Add(acceptBtn);


                Button deleteBtn = new Button();
                deleteBtn.Size = new Size(90, 25);
                deleteBtn.Location = new Point(95, 50);
                deleteBtn.Text = "Delete";
                deleteBtn.FlatStyle = FlatStyle.Flat;
                deleteBtn.FlatAppearance.BorderSize = 1;
                deleteBtn.FlatAppearance.BorderColor = Color.White;
                deleteBtn.ForeColor = Color.White;
                deleteBtn.BackColor = Color.DimGray;
                deleteBtn.Cursor = Cursors.Hand;
                requestContainer.Controls.Add(deleteBtn);

                int id = login.me.friends_request[i];
                acceptBtn.MouseClick += (s, t) =>
                {

                    acceptBtn.Visible = false;
                    deleteBtn.Visible = false;
                    Label respond = new Label();
                    respond.AutoSize = true;
                    respond.Location = new Point(45, 50);
                    respond.Text = "Request Accepted";
                    respond.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    requestContainer.Controls.Add(respond);
                    login.me.accept_request(id, login.me.Id);
                };
                deleteBtn.MouseClick += (s, y) =>
                {
                    acceptBtn.Visible = false;
                    deleteBtn.Visible = false;
                    Label respond = new Label();
                    respond.AutoSize = true;
                    respond.Location = new Point(45, 50);
                    respond.Text = "Request Deleted";
                    login.me.delete_request(id, login.me.Id);
                    //  login.me.delete_request();
                    respond.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    requestContainer.Controls.Add(respond);
                };
            }
        }

        private void hidePanels()
        {
            panel1.MouseClick += mouseClick;
            splitContainer2.Panel1.MouseClick += mouseClick;
            splitContainer3.Panel1.MouseClick += mouseClick;
            splitContainer3.Panel2.MouseClick += mouseClick;
            panel5.MouseClick += mouseClick;
            

        }

        private void mouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                notifPanel.Hide();
                msgPanel.Hide();
                requestPanel.Hide();
                panel6.Visible = false;
                tagText.Visible = false;
            }
        }

        private void chatFun()
        {
            for (int i = 0; i < login.me.friendssort.Count; i++)
            {
                string fname = null;
                string sname = null;

                Button chat = new Button();
                chat.Size = new Size(180, 45);
                chat.Location = new Point(5, 5 + 50 * i);
                chat.FlatStyle = FlatStyle.Flat;
                chat.Text = "Abo Salah";
                chat.Font = new Font("Tahoma", 10, FontStyle.Bold);
                chat.BackColor = Color.White;
                chat.Cursor = Cursors.Hand;
                splitContainer3.Panel2.Controls.Add(chat);
                chat.MouseClick += mouseClick;

                PictureBox friendPic = new PictureBox();
                friendPic.Size = new Size(35, 35);
                friendPic.Location = new Point(5, 5);
                friendPic.BorderStyle = BorderStyle.FixedSingle;
                friendPic.SizeMode = PictureBoxSizeMode.StretchImage;
                friendPic.Cursor = Cursors.Hand;
                chat.Controls.Add(friendPic);
                friendPic.MouseClick += mouseClick;

                //byte[] pic ;

                Button gotoProfile = new Button();
                gotoProfile.Size = new Size(30, 30);
                gotoProfile.Location = new Point(140, 7);
                chat.FlatStyle = FlatStyle.Flat;
                gotoProfile.Cursor = Cursors.Hand;
                chat.Controls.Add(gotoProfile);
                gotoProfile.MouseClick += mouseClick;

                ToolTip onChat = new ToolTip();
                onChat.ShowAlways = true;
                login.me.frienddata(login.me.friendssort[i], ref fname, ref sname, ref pic);
                if (pic != null)
                {
                    MemoryStream stream = new MemoryStream(pic);
                    friendPic.Image = System.Drawing.Image.FromStream(stream);
                }
                chat.Text = fname + " " + sname;
                onChat.SetToolTip(gotoProfile, fname + " " + sname + "'s profile");
            }

        }

        private void writePostFun()
        {
            Button writePost = new Button();
            writePost.Size = new Size(520, 40);
            writePost.Location = new Point(25, 10);
            writePost.FlatStyle = FlatStyle.Flat;
            writePost.Text = "Write post";
            writePost.Font = new Font("Tahoma", 10, FontStyle.Bold);
            splitContainer3.Panel1.Controls.Add(writePost);
            writePost.MouseClick += (s, t) => {
                Write_Post wp = new Write_Post();
                wp.Location = new Point(25, 25); splitContainer3.Panel1.Controls.Add(wp); wp.Show(); wp.BringToFront();
            };
        }

        private void post_showCommentsFun()
        {
            Panel postContainer = new Panel();
            postContainer.AutoSize = true;
            postContainer.Location = new Point(25, 70);
            postContainer.BorderStyle = BorderStyle.FixedSingle;
            splitContainer3.Panel1.Controls.Add(postContainer);

            PictureBox userPic = new PictureBox();
            userPic.Size = new Size(40, 40);
            userPic.Location = new Point(5, 5);
            userPic.BorderStyle = BorderStyle.FixedSingle;
            userPic.Cursor = Cursors.Hand;
            postContainer.Controls.Add(userPic);
            userPic.MouseClick += mouseClick;

            Label userName = new Label();
            userName.AutoSize = true;
            userName.Location = new Point(50, 5);
            userName.Text = "Karim Atef";
            userName.Font = new Font("Tahoma", 10, FontStyle.Bold);
            userName.Cursor = Cursors.Hand;
            postContainer.Controls.Add(userName);
            userName.MouseClick += mouseClick;

            Label date = new Label();
            date.AutoSize = true;
            date.Location = new Point(50, 25);
            date.Text = "7/9/2012";
            date.Font = new Font("Tahoma", 8, FontStyle.Regular);
            postContainer.Controls.Add(date);

            Label postText = new Label();
            postText.AutoSize = true;
            postText.Location = new Point(5, 50);
            //postText.BorderStyle = BorderStyle.FixedSingle;
            postText.Text = "Just Do It";
            postContainer.Controls.Add(postText);

            PictureBox postPic = new PictureBox();
            postPic.Size = new Size(510, 150);
            postPic.Location = new Point(5, 70);
            postPic.BorderStyle = BorderStyle.FixedSingle;
            postPic.Cursor = Cursors.Hand;
            postContainer.Controls.Add(postPic);
            postPic.MouseClick += mouseClick;

            for (int i = 0; i < 6; i++)
            {
                Button react = new Button();
                react.Size = new Size(20, 20);
                react.Location = new Point(5 + (50 * i), 230);
                react.FlatStyle = FlatStyle.Flat;
                react.Cursor = Cursors.Hand;
                postContainer.Controls.Add(react);
                react.MouseClick += mouseClick;

                Label reactsCount = new Label();
                reactsCount.AutoSize = true;
                reactsCount.Location = new Point(30 + (50 * i), 235);
                reactsCount.Text = "0";
                postContainer.Controls.Add(reactsCount);
            }

            TextBox commentText = new TextBox();
            commentText.Size = new Size(300, 25);
            commentText.Location = new Point(5, 260);
            commentText.Multiline = true;
            commentText.Font = new Font("Tahoma", 10, FontStyle.Regular);
            postContainer.Controls.Add(commentText);

            Button commentBtn = new Button();
            commentBtn.Size = new Size(75, 25);
            commentBtn.Location = new Point(310, 260);
            commentBtn.Text = "Comment";
            commentBtn.FlatStyle = FlatStyle.Flat;
            commentBtn.Cursor = Cursors.Hand;
            postContainer.Controls.Add(commentBtn);
            commentBtn.MouseClick += mouseClick;

            //show all comments
            Button showComments = new Button();
            showComments.Size = new Size(25, 25);
            showComments.Location = new Point(390, 260);
            showComments.Text = "show";
            showComments.Cursor = Cursors.Hand;
            postContainer.Controls.Add(showComments);
            showComments.MouseClick += mouseClick;

            showComments.Click += (s, f) =>
            {
                Panel forComments = new Panel();
                forComments.AutoSize = true;
                forComments.Location = new Point(620, 70);
                forComments.BorderStyle = BorderStyle.FixedSingle;
                splitContainer3.Panel1.Controls.Add(forComments);

                Panel commentContainer = new Panel();
                commentContainer.AutoSize = true;
                commentContainer.Location = new Point(5, 5);
                commentContainer.BorderStyle = BorderStyle.FixedSingle;
                forComments.Controls.Add(commentContainer);

                PictureBox commenterPic = new PictureBox();
                commenterPic.Size = new Size(35, 35);
                commenterPic.Location = new Point(5, 5);
                commenterPic.BorderStyle = BorderStyle.FixedSingle;
                commenterPic.Cursor = Cursors.Hand;
                commentContainer.Controls.Add(commenterPic);

                Label commenterName = new Label();
                commenterName.AutoSize = true;
                commenterName.Location = new Point(45, 5);
                commenterName.Text = "Nader Waled";
                commenterName.Font = new Font("Tahoma", 9, FontStyle.Bold);
                commenterName.Cursor = Cursors.Hand;
                commentContainer.Controls.Add(commenterName);

                Label time = new Label();
                time.AutoSize = true;
                time.Location = new Point(45, 20);
                time.Text = "5 minutes ago";
                time.Font = new Font("Tahoma", 7, FontStyle.Regular);
                commentContainer.Controls.Add(time);


                Label comment = new Label();
                comment.AutoSize = true;
                comment.Location = new Point(5, 40);
                comment.Text = "Everything will be fine inshallah";
                comment.Font = new Font("Tahoma", 10, FontStyle.Regular);
                commentContainer.Controls.Add(comment);

                for (int i = 0; i < 6; i++)
                {
                    Button reactOnCmt = new Button();
                    reactOnCmt.Size = new Size(15, 15);
                    reactOnCmt.Location = new Point(5 + (30 * i), 75);
                    reactOnCmt.FlatStyle = FlatStyle.Flat;
                    reactOnCmt.Cursor = Cursors.Hand;
                    commentContainer.Controls.Add(reactOnCmt);
                    reactOnCmt.MouseClick += mouseClick;

                    Label reactsCountOnCmt = new Label();
                    reactsCountOnCmt.AutoSize = true;
                    reactsCountOnCmt.Location = new Point(20 + (30 * i), 75);
                    reactsCountOnCmt.Text = "0";
                    commentContainer.Controls.Add(reactsCountOnCmt);

                    //reactOnCmt.Click += (s, r) => { ; };
                }

                Button reply = new Button();
                reply.Size = new Size(50, 23);
                reply.Location = new Point(200, 70);
                reply.Text = "Reply";
                reply.FlatStyle = FlatStyle.Flat;
                reply.Cursor = Cursors.Hand;
                commentContainer.Controls.Add(reply);
                reply.MouseClick += (q, r) =>
                {

                    notifPanel.Hide();
                    msgPanel.Hide();
                    requestPanel.Hide();

                    TextBox typeReply = new TextBox();
                    typeReply.Size = new Size(185, 20);
                    typeReply.Location = new Point(5, 95);
                    typeReply.Font = new Font("Tahoma", 8, FontStyle.Regular);
                    commentContainer.Controls.Add(typeReply);

                    PictureBox replyPic = new PictureBox();
                    replyPic.Size = new Size(30, 20);
                    replyPic.Location = new Point(195, 95);
                    replyPic.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\60525.png");
                    replyPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    commentContainer.Controls.Add(replyPic);


                };

            };
        }

        private void tooltipForIcons()
        {
            ToolTip search = new ToolTip();
            search.ShowAlways = true;
            search.SetToolTip(searchBtn, "Search");
            ToolTip home = new ToolTip();
            home.ShowAlways = true;
            home.SetToolTip(homeBtn, "Home");
            ToolTip profile = new ToolTip();
            profile.ShowAlways = true;
            profile.SetToolTip(profileBtn, "Profile");
            ToolTip notificatins = new ToolTip();
            notificatins.ShowAlways = true;
            notificatins.SetToolTip(notifBtn, "Notificatins");
            ToolTip msg = new ToolTip();
            msg.ShowAlways = true;
            msg.SetToolTip(msgBtn, "Messages");
            ToolTip requests = new ToolTip();
            requests.ShowAlways = true;
            requests.SetToolTip(requestBtn, "Friend Requests");
            ToolTip settings = new ToolTip();
            settings.ShowAlways = true;
            settings.SetToolTip(settingBtn, "Settings");
            ToolTip logout = new ToolTip();
            logout.ShowAlways = true;
            logout.SetToolTip(logoutBtn, "Logout");
        }

        private void ChangePP_Click(object sender, EventArgs e)
        {

            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pics = image.FileName.ToString();
                FileStream fstream = new FileStream(pics, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
               pic = br.ReadBytes((int)fstream.Length);
                profilePic.ImageLocation = pics;
                login.me.update_photo(login.me.Id,"profileimage",pic);


            }
        }

        private void ChangeCP_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pics = image.FileName.ToString();
                FileStream fstream = new FileStream(pics, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                pic = br.ReadBytes((int)fstream.Length);
                coverPhoto.ImageLocation = pics;
                login.me.update_photo(login.me.Id, "coverimage", pic);


            }
        }

        private void searchBtn_MouseClick(object sender, MouseEventArgs e)
        {
            searchFun();
        }

        private void searchFun()
        {
            tagText.Visible = true;
            panel6.Visible = true;

            tagText.BringToFront();
            tagText.TextChanged += search_textChanged;


        }

        private void search_textChanged(object sender, EventArgs e)
        {
            int j = 0;
            panel6.Controls.Clear();
            for (int i = 0; i < login.me.youmaynow.Count; i++)
            {
                bool isfound = login.me.search(login.me.youmaynow[i][0], tagText.Text);
                if (isfound == true)
                {
                    j++;
                    login.me.frienddata(login.me.youmaynow[i][0], ref fname, ref sname, ref pic);
                    Button searchResult = new Button();
                    searchResult.Size = new Size(245, 40);
                    searchResult.Location = new Point(5, 40 * j);
                    searchResult.TextAlign = ContentAlignment.MiddleCenter;
                    searchResult.FlatStyle = FlatStyle.Flat;
                    searchResult.FlatAppearance.BorderColor = Color.White;
                    searchResult.BackColor = Color.White;
                    searchResult.Text = fname + " " + sname;
                    panel6.Controls.Add(searchResult);

                    PictureBox userPic = new PictureBox();
                    userPic.Size = new Size(30, 30);
                    userPic.Location = new Point(5, 5);
                    userPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    userPic.Cursor = Cursors.Hand;
                    if (pic != null)
                    {
                        MemoryStream stream = new MemoryStream(pic);
                        userPic.Image = System.Drawing.Image.FromStream(stream);
                    }
                    searchResult.Controls.Add(userPic);

                }
            }
        }

        private void coverPhoto_Click(object sender, EventArgs e)
        {

        }
    }
}
