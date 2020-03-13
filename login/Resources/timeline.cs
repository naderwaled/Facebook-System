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
namespace new_design
{
    public partial class Form1 : Form
    {
        string fname;
        string sname;
        byte[] pic;
        post potss = new post();
        public Panel msgPanel = new Panel();
        public Panel notifPanel = new Panel();
        public Panel requestPanel = new Panel();
        int indexy = 70;
        public Form1()
        {
            InitializeComponent();
            hidePanels();
        }
        login refreach = new login();
        private void Form1_Load(object sender, EventArgs e)
        {
            youMayKnowFun();
            post_showCommentsFun();
            writePostFun();
            chatFun();
            tooltipForIcons();
        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_MouseClick(object sender, MouseEventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void logoutBtn_Click(object sender, EventArgs e)
        {
            login lo = new login();
            this.Hide();
            lo.Show();
        }

        private void profileBtn_MouseClick(object sender, MouseEventArgs e)
        {
            Profile prof = new Profile();
            this.Close();
            prof.Show();
        }



        // 3  buttons

        private void notifBtn_Click(object sender, EventArgs e)
        {
            msgPanel.Hide();
            requestPanel.Hide();
            notifPanel.Show();
            youMayKnowFun();

            notifPanel.Size = new Size(200, 400);
            notifPanel.Location = new Point(40, 220);
            notifPanel.BackColor = Color.White;
            this.Controls.Add(notifPanel);
            notifPanel.BringToFront();
        }

        private void msgBtn_Click(object sender, EventArgs e)
        {
            //Messenger mo = new Messenger();
            login.moo = new Messenger2();
            login.moo.Show();
            notifPanel.Hide();
            requestPanel.Hide();
            msgPanel.Show();
            youMayKnowFun();

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

        private void requestBtn_Click(object sender, EventArgs e)
        {
            notifPanel.Hide();
            msgPanel.Hide();
            requestPanel.Show();
            youMayKnowFun();

            requestPanel.Size = new Size(200, 400);
            requestPanel.Location = new Point(40, 295);
            requestPanel.BackColor = Color.White;
            this.Controls.Add(requestPanel);
            requestPanel.BringToFront();
            for (int i = 0; i < login.me.friends_request.Count; i++)
            {
                login.me.frienddata(login.me.friends_request[i],ref fname,ref sname,ref pic);
                Panel requestContainer = new Panel();
                requestContainer.Size = new Size(190, 80);
                requestContainer.Location = new Point(5, 5+80*i);
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
                userName.Text =fname+" "+sname;
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
                login.me.accept_request(id,login.me.Id);
                };
                deleteBtn.MouseClick += (s, y) => {
                    acceptBtn.Visible = false;
                    deleteBtn.Visible = false;
                    Label respond = new Label();
                    respond.AutoSize = true;
                    respond.Location = new Point(45, 50);
                    respond.Text = "Request Deleted";
                    login.me.delete_request(id,login.me.Id);
                  //  login.me.delete_request();
                    respond.Font = new Font("Tahoma", 9, FontStyle.Bold);
                    requestContainer.Controls.Add(respond);
                };
            }

        }

        // functions
        private void hidePanels()
        {
            panel1.MouseClick += mouseClick;
            splitContainer1.Panel1.MouseClick += mouseClick;
            splitContainer2.Panel1.MouseClick += mouseClick;
            splitContainer2.Panel2.MouseClick += mouseClick;
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

        private void searchBtn_MouseClick(object sender, MouseEventArgs e)
        {
            searchFun();
        }

        private void youMayKnowFun()
        {
            int j = 0;
            for (int i = 0; i < login.me.youmaynow.Count; i++)
            {
                if (login.me.friendssort.Contains(login.me.youmaynow[i][0]))
                    continue;
                if (login.me.friends_request.Contains(login.me.youmaynow[i][0]))
                    continue;
                if (login.me.Id == login.me.youmaynow[i][0])
                    continue;

                Button uMayKnow = new Button();
                uMayKnow.Size = new Size(220, 200);
                uMayKnow.Location = new Point(5, 5+205*j);
                j++;
                uMayKnow.FlatStyle = FlatStyle.Flat;
                //uMayKnow.Text = "Nader Waled";
                uMayKnow.BackColor = Color.White;
                uMayKnow.TextAlign = ContentAlignment.BottomCenter;
                uMayKnow.Font = new Font("Tahoma", 10, FontStyle.Bold);
                uMayKnow.Cursor = Cursors.Hand;
                splitContainer1.Panel1.Controls.Add(uMayKnow);
                uMayKnow.MouseClick += mouseClick;

                PictureBox uMayKnowPic = new PictureBox();
                uMayKnowPic.Size = new Size(210, 110);
                uMayKnowPic.Location = new Point(5, 5);
                uMayKnowPic.BorderStyle = BorderStyle.FixedSingle;
                uMayKnowPic.SizeMode = PictureBoxSizeMode.StretchImage;
                uMayKnowPic.Cursor = Cursors.Hand;
                uMayKnow.Controls.Add(uMayKnowPic);
                uMayKnowPic.MouseClick += mouseClick;


                Button addFriend = new Button();
                addFriend.Size = new Size(210, 30);
                addFriend.Location = new Point(5, 120);
                addFriend.FlatStyle = FlatStyle.Flat;
                addFriend.Text = "Add friend";
                addFriend.Cursor = Cursors.Hand;
                uMayKnow.Controls.Add(addFriend);
                
                //addFriend.MouseClick += mouseClick;


                Button requestSent = new Button();
                requestSent.Size = new Size(210, 30);
                requestSent.Location = new Point(5, 120);
                requestSent.FlatStyle = FlatStyle.Flat;
                requestSent.Text = "Request sent";
                requestSent.Cursor = Cursors.Hand;
                uMayKnow.Controls.Add(requestSent);
                //requestSent.MouseClick += mouseClick;

                int id = login.me.youmaynow[i][0];
                addFriend.Click += (s, r) =>
                {
                    notifPanel.Hide();
                    msgPanel.Hide();
                    requestPanel.Hide();
                    addFriend.Visible = false;
                    requestSent.Visible = true;
                    login.me.send_request(id,login.me.Id);

                };
                requestSent.Click += (s, r) =>
                {
                    notifPanel.Hide();
                    msgPanel.Hide();
                    requestPanel.Hide();
                    addFriend.Visible = true;
                    requestSent.Visible = false;
                    login.me.delete_request(id,login.me.Id);
                };


                Label mutualFriends = new Label();
                mutualFriends.AutoSize = true;
                mutualFriends.Location = new Point(60, 155);
                mutualFriends.Font = new Font("Tahoma", 10, FontStyle.Regular);
                uMayKnow.Controls.Add(mutualFriends);

                login.me.frienddata(login.me.youmaynow[i][0], ref fname, ref sname, ref pic);
                if (pic != null)
                {
                    MemoryStream stream = new MemoryStream(pic);
                    uMayKnowPic.Image = System.Drawing.Image.FromStream(stream);
                }
                uMayKnow.Text = fname + " " + sname;
                if(login.me.youmaynow[i][1]>0)
                mutualFriends.Text = login.me.youmaynow[i][1].ToString() + " mutual friends";


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
            splitContainer2.Panel1.Controls.Add(writePost);
            writePost.MouseClick += (s, t) => {
                Write_Post wp = new Write_Post();
                wp.Location = new Point(25, 25); splitContainer2.Panel1.Controls.Add(wp); wp.Show(); wp.BringToFront(); };
        }

        private void post_showCommentsFun()
        {
         

          
            for (int u = 0; u < login.post2.postsss.Count; u++) {
                Button showComments = new Button();
                string text = null;
                byte[] image = null;
                int counttag = 0;
                string privacy = null;
                string date2 = null;
                string fname = login.me.FristName;
                string sname = login.me.SecondName;
                byte[] pic = login.me.profileimage;
                string lastreact = null;
                int iduser=0;
                int idpos = login.post2.postsss[u][0];
                int idtag = login.post2.postsss[u][1];
                login.post2.showpost(idpos, idtag, ref iduser,ref text, ref image, ref date2, ref counttag, ref privacy);
                List<int> reacts = new List<int>();
                login.post2.reactcount(idpos,ref reacts);
                //MessageBox.Show(date2);
                if (iduser != login.me.Id)
                {
                    login.me.frienddata(iduser, ref fname, ref sname, ref pic);
                }


                Panel postContainer = new Panel();
                postContainer.AutoSize = true;
                postContainer.MinimumSize = new Size(520, 0);
               
                postContainer.BorderStyle = BorderStyle.FixedSingle;
                splitContainer2.Panel1.Controls.Add(postContainer);

                PictureBox userPic = new PictureBox();
                userPic.Size = new Size(40, 40);
                userPic.Location = new Point(5, 5);
                userPic.BorderStyle = BorderStyle.FixedSingle;
                userPic.SizeMode = PictureBoxSizeMode.StretchImage;
                userPic.Cursor = Cursors.Hand;
                postContainer.Controls.Add(userPic);
                userPic.MouseClick += mouseClick;

                if (pic != null)
                {
                    MemoryStream stream = new MemoryStream(pic);
                    userPic.Image = System.Drawing.Image.FromStream(stream);
                }

                Label userName = new Label();
                userName.AutoSize = true;
                userName.Location = new Point(50, 5);
                userName.Text = fname+" "+sname;
                userName.Font = new Font("Tahoma", 12, FontStyle.Bold);
                userName.Cursor = Cursors.Hand;
                postContainer.Controls.Add(userName);
                userName.MouseClick += mouseClick;

                Label date = new Label();
                date.AutoSize = true;
                date.Location = new Point(50, 25);
                date.Text = date2;
                date.Font = new Font("Tahoma", 8, FontStyle.Regular);
                postContainer.Controls.Add(date);
                if (text != null)
                {
                    Label postText = new Label();
                    postText.AutoSize = true;
                    postText.Location = new Point(5, 50);
                    postText.Font = new Font("Tahoma", 12, FontStyle.Regular);
                    //postText.BorderStyle = BorderStyle.FixedSingle;
                    postText.Text = text;
                    postContainer.Controls.Add(postText);
                }
            
                

                  if (image != null)
                  {
                  //  postContainer.Location = new Point(25, 70 + 200 * u); // hena el location lw fe soora (x, y)

                    PictureBox postPic = new PictureBox();
                      postPic.Size = new Size(510, 150);
                      postPic.Location = new Point(5, 70);
                      postPic.BorderStyle = BorderStyle.FixedSingle;
                      postPic.Cursor = Cursors.Hand;
                      postPic.SizeMode = PictureBoxSizeMode.StretchImage;
                      postContainer.Controls.Add(postPic);
                      postPic.MouseClick += mouseClick;


                      MemoryStream stream = new MemoryStream(image);
                      postPic.Image = System.Drawing.Image.FromStream(stream);

                    Label reactLikeCount = new Label();
                    reactLikeCount.AutoSize = true;
                    reactLikeCount.Location = new Point(30, 235);
                    reactLikeCount.Text = reacts[0].ToString();
                    postContainer.Controls.Add(reactLikeCount);

                    Label reactLoveCount = new Label();
                    reactLoveCount.AutoSize = true;
                    reactLoveCount.Location = new Point(80, 235);
                    reactLoveCount.Text = reacts[1].ToString();
                    postContainer.Controls.Add(reactLoveCount);

                    Label reactHahaCount = new Label();
                    reactHahaCount.AutoSize = true;
                    reactHahaCount.Location = new Point(130, 235);
                    reactHahaCount.Text = reacts[2].ToString();
                    postContainer.Controls.Add(reactHahaCount);

                    Label reactSadCount = new Label();
                    reactSadCount.AutoSize = true;
                    reactSadCount.Location = new Point(180, 235);
                    reactSadCount.Text = reacts[3].ToString();
                    postContainer.Controls.Add(reactSadCount);

                    Label reactWowCount = new Label();
                    reactWowCount.AutoSize = true;
                    reactWowCount.Location = new Point(230, 235);
                    reactWowCount.Text = reacts[4].ToString();
                    postContainer.Controls.Add(reactWowCount);

                    Label reactAngryCount = new Label();
                    reactAngryCount.AutoSize = true;
                    reactAngryCount.Location = new Point(280, 235);
                    reactAngryCount.Text = reacts[5].ToString();
                    postContainer.Controls.Add(reactAngryCount);


                    // reacts

                    PictureBox reactLike = new PictureBox();
                    reactLike.Size = new Size(20, 20);
                    reactLike.Location = new Point(5, 230);
                    reactLike.Cursor = Cursors.Hand;
                    reactLike.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\like2.png");
                    reactLike.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactLike);
                    reactLike.MouseClick += (s, e) => {
                        lastreact = login.post2.reactbutton("like", idpos, "post", login.me.Id);

                        if (lastreact == "like") { }
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reactHahaCount.Text = reacts[2].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }




                    };



                    PictureBox reactLove = new PictureBox();
                    reactLove.Size = new Size(20, 20);
                    reactLove.Location = new Point(55, 230);
                    reactLove.Cursor = Cursors.Hand;
                    reactLove.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\love2.png");
                    reactLove.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactLove);
                    reactLove.MouseClick += (s, e) => {
                        login.post2.reactbutton("love", idpos, "post", login.me.Id);
                        if (lastreact == "love") { }
                        if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                    };



                    PictureBox reactHaha = new PictureBox();
                    reactHaha.Size = new Size(20, 20);
                    reactHaha.Location = new Point(105, 230);
                    reactHaha.Cursor = Cursors.Hand;
                    reactHaha.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\Haha2.png");
                    reactHaha.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactHaha);
                    reactHaha.MouseClick += (s, e) => {
                        login.post2.reactbutton("haha", idpos, "post", login.me.Id);
                        reacts[2] += 1;
                        reactHahaCount.Text = reacts[2].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };


                    PictureBox reactSad = new PictureBox();
                    reactSad.Size = new Size(20, 20);
                    reactSad.Location = new Point(155, 230);
                    reactSad.Cursor = Cursors.Hand;
                    reactSad.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\Sad2.png");
                    reactSad.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactSad);
                    reactSad.MouseClick += (s, e) => {
                        login.post2.reactbutton("sad", idpos, "post", login.me.Id);
                        reacts[3] += 1;
                        reactSadCount.Text = reacts[3].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();
                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };


                    PictureBox reactWow = new PictureBox();
                    reactWow.Size = new Size(20, 20);
                    reactWow.Location = new Point(205, 230);
                    reactWow.Cursor = Cursors.Hand;
                    reactWow.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\wow2.png");
                    reactWow.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactWow);
                    reactWow.MouseClick += (s, e) => {
                        login.post2.reactbutton("wow", idpos, "post", login.me.Id);
                        reacts[4] += 1;
                        reactWowCount.Text = reacts[4].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();

                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();


                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };



                    PictureBox reactAngry = new PictureBox();
                    reactAngry.Size = new Size(20, 20);
                    reactAngry.Location = new Point(255, 230);
                    reactAngry.Cursor = Cursors.Hand;
                    reactAngry.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\angry2.png");
                    reactAngry.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactAngry);
                    reactAngry.MouseClick += (s, e) => {
                        login.post2.reactbutton("angry", idpos, "post", login.me.Id);
                        reacts[5] += 1;
                        reactAngryCount.Text = reacts[5].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();

                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();

                        }
                    };

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
              
              showComments.Size = new Size(25, 25);
              showComments.Location = new Point(390, 260);
              showComments.Text = "show";
              showComments.Cursor = Cursors.Hand;
              postContainer.Controls.Add(showComments);
              showComments.MouseClick += mouseClick;


                  }

                else if (image == null)
                {

                  //  postContainer.Location = new Point(25, 70 + 150 * u); // hena el location lw mafeesh sora (x, y)

                    Label reactLikeCount = new Label();
                    reactLikeCount.AutoSize = true;
                    reactLikeCount.Location = new Point(30, 85);
                   reactLikeCount.Text = reacts[0].ToString();
                    postContainer.Controls.Add(reactLikeCount);

                    Label reactLoveCount = new Label();
                    reactLoveCount.AutoSize = true;
                    reactLoveCount.Location = new Point(80, 85);
                    reactLoveCount.Text = reacts[1].ToString();
                    postContainer.Controls.Add(reactLoveCount);

                    Label reactHahaCount = new Label();
                    reactHahaCount.AutoSize = true;
                    reactHahaCount.Location = new Point(130, 85);
                    reactHahaCount.Text = reacts[2].ToString();
                    postContainer.Controls.Add(reactHahaCount);

                    Label reactSadCount = new Label();
                    reactSadCount.AutoSize = true;
                    reactSadCount.Location = new Point(180, 85);
                    reactSadCount.Text = reacts[3].ToString();
                    postContainer.Controls.Add(reactSadCount);

                    Label reactWowCount = new Label();
                    reactWowCount.AutoSize = true;
                    reactWowCount.Location = new Point(230, 85);
                    reactWowCount.Text = reacts[4].ToString();
                    postContainer.Controls.Add(reactWowCount);

                    Label reactAngryCount = new Label();
                    reactAngryCount.AutoSize = true;
                    reactAngryCount.Location = new Point(280, 85);
                    reactAngryCount.Text = reacts[5].ToString();
                    postContainer.Controls.Add(reactAngryCount);


                    // reacts

                    PictureBox reactLike = new PictureBox();
                    reactLike.Size = new Size(20, 20);
                    reactLike.Location = new Point(5, 80);
                    reactLike.Cursor = Cursors.Hand;
                    reactLike.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\like2.png");
                    reactLike.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactLike);
                    reactLike.MouseClick += (s, e) => {
                      lastreact= login.post2.reactbutton("like",idpos,"post",login.me.Id);

                        if (lastreact == "like") { }
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if(lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reactHahaCount.Text = reacts[2].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();
                            reacts[0] += 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                       
                        
                          
                        
                    };



                    PictureBox reactLove = new PictureBox();
                    reactLove.Size = new Size(20, 20);
                    reactLove.Location = new Point(55, 80);
                    reactLove.Cursor = Cursors.Hand;
                    reactLove.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\love2.png");
                    reactLove.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactLove);
                    reactLove.MouseClick += (s, e) => {
                    login.post2.reactbutton("love", idpos, "post", login.me.Id);
                        if (lastreact == "love") { }
                        if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();
                            reacts[1] += 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                    };



                    PictureBox reactHaha = new PictureBox();
                    reactHaha.Size = new Size(20, 20);
                    reactHaha.Location = new Point(105, 80);
                    reactHaha.Cursor = Cursors.Hand;
                    reactHaha.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\Haha2.png");
                    reactHaha.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactHaha);
                    reactHaha.MouseClick += (s, e) => {
                        login.post2.reactbutton("haha", idpos, "post", login.me.Id);
                        reacts[2] += 1;
                        reactHahaCount.Text = reacts[2].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();
                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };


                    PictureBox reactSad = new PictureBox();
                    reactSad.Size = new Size(20, 20);
                    reactSad.Location = new Point(155, 80);
                    reactSad.Cursor = Cursors.Hand;
                    reactSad.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\Sad2.png");
                    reactSad.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactSad);
                    reactSad.MouseClick += (s, e) => {
                        login.post2.reactbutton("sad", idpos, "post", login.me.Id);
                        reacts[3] += 1;
                        reactSadCount.Text = reacts[3].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();
                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();
                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };


                    PictureBox reactWow = new PictureBox();
                    reactWow.Size = new Size(20, 20);
                    reactWow.Location = new Point(205, 80);
                    reactWow.Cursor = Cursors.Hand;
                    reactWow.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\wow2.png");
                    reactWow.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactWow);
                    reactWow.MouseClick += (s, e) => {
                        login.post2.reactbutton("wow", idpos, "post", login.me.Id);
                        reacts[4] += 1;
                        reactWowCount.Text = reacts[4].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();

                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();


                        }
                        else if (lastreact == "angry")
                        {
                            reacts[5] -= 1;
                            reactAngryCount.Text = reacts[5].ToString();

                        }
                    };



                    PictureBox reactAngry = new PictureBox();
                    reactAngry.Size = new Size(20, 20);
                    reactAngry.Location = new Point(255, 80);
                    reactAngry.Cursor = Cursors.Hand;
                    reactAngry.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\login\angry2.png");
                    reactAngry.SizeMode = PictureBoxSizeMode.StretchImage;
                    postContainer.Controls.Add(reactAngry);
                    reactAngry.MouseClick += (s, e) => {
                        login.post2.reactbutton("angry", idpos, "post", login.me.Id);
                        reacts[5] += 1;
                        reactAngryCount.Text = reacts[5].ToString();
                        if (lastreact == "love")
                        {
                            reacts[1] -= 1;
                            reactLoveCount.Text = reacts[1].ToString();

                        }
                        else if (lastreact == "haha")
                        {
                            reacts[2] -= 1;
                            reactHahaCount.Text = reacts[2].ToString();

                        }
                        else if (lastreact == "sad")
                        {
                            reacts[3] -= 1;
                            reactSadCount.Text = reacts[3].ToString();

                        }
                        else if (lastreact == "wow")
                        {
                            reacts[4] -= 1;
                            reactWowCount.Text = reacts[4].ToString();

                        }
                        else if (lastreact == "like")
                        {
                            reacts[0] -= 1;
                            reactLikeCount.Text = reacts[0].ToString();

                        }
                    };


                    TextBox commentText = new TextBox();
                    commentText.Size = new Size(300, 25);
                    commentText.Location = new Point(5, 110);
                    commentText.Multiline = true;
                    commentText.Font = new Font("Tahoma", 10, FontStyle.Regular);
                    postContainer.Controls.Add(commentText);

                    Button commentBtn = new Button();
                    commentBtn.Size = new Size(75, 25);
                    commentBtn.Location = new Point(310, 110);
                    commentBtn.Text = "Comment";
                    commentBtn.FlatStyle = FlatStyle.Flat;
                    commentBtn.Cursor = Cursors.Hand;
                    postContainer.Controls.Add(commentBtn);
                    commentBtn.MouseClick += mouseClick;

                    //show all comments

                    showComments.Size = new Size(25, 25);
                    showComments.Location = new Point(390, 110);
                    showComments.Text = "show";
                    showComments.Cursor = Cursors.Hand;
                    postContainer.Controls.Add(showComments);
                    showComments.MouseClick += mouseClick;

                }


               
            showComments.Click += (s, f) =>
            {
                Panel forComments = new Panel();
                forComments.AutoSize = true;
                forComments.Location = new Point(620, 70);
                forComments.BorderStyle = BorderStyle.FixedSingle;
                splitContainer2.Panel1.Controls.Add(forComments);

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
                postContainer.Location = new Point(25, indexy );
                indexy += postContainer.Height+5;
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
                splitContainer2.Panel2.Controls.Add(chat);
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
                    searchResult.Size = new Size(220, 40);
                    searchResult.Location = new Point(5, 40*j);
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

        private void splitContainer2_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
    
}