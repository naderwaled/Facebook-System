using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FACEBOOK;
using System.IO;



namespace new_design
{
    public partial class Write_Post : UserControl
    {
        string fname;
        string sname;
        byte[] image;
        post pos = new post();
        List<int> idtag = new List<int>();
        public Write_Post()
        {
            InitializeComponent();
            Privacy.SelectedIndex = 0;
        }

        
        

        private void tagSomeone_MouseClick(object sender, MouseEventArgs e)
        {
            int counter = 0;

            tagText.Visible = true;
            tagContainer.Visible = true;
            button1.Visible = true;

            for (int i = 0; i < login.me.friendssort.Count; i++)
            {
                int id = login.me.friendssort[i];
                login.me.frienddata(login.me.friendssort[i], ref fname, ref sname, ref image);
                Button tagResult = new Button();
                tagResult.Size = new Size(160, 35);
                tagResult.Location = new Point(2, 5 + 40*i);
                tagResult.FlatStyle = FlatStyle.Flat;
                tagResult.BackColor = Color.White;
                tagResult.Text = fname + " " + sname;
                tagResult.Cursor = Cursors.Hand;
                tagContainer.Controls.Add(tagResult);

                PictureBox tagSign = new PictureBox();
                tagSign.Size = new Size(20, 20);
                tagSign.Location = new Point(130, 7);
                tagSign.Visible = false;
                tagSign.SizeMode = PictureBoxSizeMode.StretchImage;
                tagSign.Image = Image.FromFile(@"C:\Users\nader\OneDrive\Desktop\Check.png");
                tagResult.Controls.Add(tagSign);

                if (image != null)
                {
                    PictureBox proPic = new PictureBox();
                    proPic.Size = new Size(30, 30);
                    proPic.Location = new Point(2, 2);
                    proPic.BorderStyle = BorderStyle.FixedSingle;
                    MemoryStream stream = new MemoryStream(image);
                    proPic.Image = System.Drawing.Image.FromStream(stream);
                    proPic.SizeMode = PictureBoxSizeMode.StretchImage;
                    tagResult.Controls.Add(proPic);
                }

                tagResult.Click += (s, f) =>
                {
                    
                    if (tagSign.Visible == true)
                    {
                        tagSign.Visible = false;
                        counter--;
                        idtag.Remove(id);
                        if (counter > 0)
                            withTag.Visible = true;
                        else
                            withTag.Visible = false;
                        withTag.Text = "with " + counter.ToString() + " other";
                    }
                    else if (tagSign.Visible == false)
                    {
                        tagSign.Visible = true;
                        counter++;
                        idtag.Add(id);
                        if (counter > 0)
                            withTag.Visible = true;
                        else
                            withTag.Visible = false;
                        withTag.Text = "with " + counter.ToString()+" other" ;

                    }
                };
            }
        }

        private void tagText_TextChanged(object sender, EventArgs e)
        {
            int counter1 = 0;
            int j = 0;
            tagContainer.Controls.Clear();
            for (int i = 0; i < login.me.friendssort.Count; i++)
            {
                bool isfound = login.me.search(login.me.friendssort[i], tagText.Text);
                if (isfound == true)
                {
                    login.me.frienddata(login.me.friendssort[i], ref fname, ref sname, ref image);
                    Button tagResult = new Button();
                    tagResult.Size = new Size(160, 30);
                    tagResult.Location = new Point(2, 5 + 40 * j);
                    j++;
                    tagResult.BackColor = Color.White;
                    tagResult.FlatStyle = FlatStyle.Flat;
                    tagResult.Text = fname + " " + sname;
                    if (image != null)
                    {
                        //////MemoryStream stream = new MemoryStream(image);
                        //////tagBtn.Image = System.Drawing.Image.FromStream(stream);
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(30, 30);
                        pic.Location = new Point(2, 2);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        MemoryStream stream = new MemoryStream(image);
                        pic.Image = System.Drawing.Image.FromStream(stream);

                        tagResult.Controls.Add(pic);
                    }
                    tagContainer.Controls.Add(tagResult);

                    PictureBox tagSign = new PictureBox();
                    tagSign.Size = new Size(20, 20);
                    tagSign.Location = new Point(130, 7);
                    tagSign.BorderStyle = BorderStyle.FixedSingle;
                    tagSign.Visible = false;
                    tagSign.SizeMode = PictureBoxSizeMode.StretchImage;
                    tagResult.Controls.Add(tagSign);

                    tagResult.MouseClick += (s, f) =>
                    {
                        counter1++;
                        if (counter1 % 2 == 0)
                            tagSign.Visible = false;
                        else if (counter1 % 2 != 0)
                            tagSign.Visible = true;
                    };

                }
            }
        }

        private void addPicPost_MouseClick(object sender, MouseEventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pic = image.FileName.ToString();
                PictureBox picture = new PictureBox();
                picture.Size = new Size(500, 500);
                picture.ImageLocation = pic;
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                //panel3.Size = new Size(884, 233 + 500);
                picture.Location = new Point(5, 100);
                tagSomeone.Controls.Add(picture);
                addPicPost.Visible = false;
                FileStream fstream = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                pos.image = br.ReadBytes((int)fstream.Length);


            }
        }

        private void Text22_TextChanged(object sender, EventArgs e)
        {
            if (Text22.Text != "")
                label3.Visible = false;
            else
                label3.Visible = true;
        }

        private void postBtn_Click(object sender, EventArgs e)
        {
            if (Privacy.Text == "")
            {
                Privacy.Focus();
                MessageBox.Show("Select Pravicy Level");
            }
            else
            {

                post ps = new post();
                DateTime no = DateTime.Now;

                if (addPicPost.Visible == false && Text22.Text != "")
                {
                    ps.write_in_database_photo_text(login.me.Id, Text22.Text, no.ToString(), Privacy.Text, pos.image,idtag);
                }
                else if (addPicPost.Visible == false && Text22.Text == "")
                {
                    ps.write_in_database_photo(login.me.Id, no.ToString(), Privacy.Text, pos.image, idtag);
                }
                else if (addPicPost.Visible == true && Text22.Text != "")
                    ps.write_in_database_text(login.me.Id, Text22.Text, no.ToString(), Privacy.Text, idtag);



                this.Hide();
            }
        }

        private void Write_Post_Load(object sender, EventArgs e)
        {
            if (login.me.profileimage != null)
            {
                MemoryStream stream = new MemoryStream(login.me.profileimage);
                pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            }

            label2.Text = login.me.FristName + " " + login.me.SecondName;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            tagText.Visible = false;
            tagContainer.Visible = false;
            button1.Visible = false;
        }

        private void pictureBox3_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
            
        }

        private void addPicPost_Click(object sender, EventArgs e)
        {

        }
    }
}