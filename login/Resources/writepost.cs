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


namespace writepost
{
    public partial class WritePosts : Form
    {
        
        string fname;
        string sname;
        byte[] image;
        post pos = new post();
        public WritePosts()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

       private void pict_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                string pic = image.FileName.ToString();
                PictureBox picture = new PictureBox();
                picture.Size = new Size(650, 500);
                picture.ImageLocation = pic;
                picture.SizeMode = PictureBoxSizeMode.Zoom;
                //panel3.Size = new Size(884, 233 + 500);
                picture.Location = new Point(82, 83 + 10);
                back.Controls.Add(picture);
                pict.Visible = false;
                FileStream fstream = new FileStream(pic, FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                pos.image = br.ReadBytes((int)fstream.Length);

            }
        }

        private void Text_TextChanged(object sender, EventArgs e)
        {
            if (Text22.Text != "")
                Write.Visible = false;
            else
                Write.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (list.Text == "")
            {
                list.Focus();
                MessageBox.Show("Select Pravicy Level");
            }
            else
            {

                post ps = new post();
                DateTime no = DateTime.Now;

                if (pict.Visible == false && Text22.Text != "")
                {
                    ps.write_in_database_photo_text(login.me.Id, Text22.Text, no.ToString(), list.Text, pos.image);
                }
                else if (pict.Visible == false && Text22.Text == "")
                {
                    ps.write_in_database_photo(login.me.Id, no.ToString(), list.Text, pos.image);
                }
                else if (pict.Visible == false && Text22.Text != "")
                    ps.write_in_database_text(login.me.Id, Text22.Text, no.ToString(), list.Text);
                 


                this.Close();
            }


        }

        private void back_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void WritePosts_Load(object sender, EventArgs e)
        {
            
            if (login.me.profileimage != null)
            {
                MemoryStream stream = new MemoryStream(login.me.profileimage);
                pictureBox1.Image = System.Drawing.Image.FromStream(stream);
            }

            username.Text = login.me.FristName + " " + login.me.SecondName;
        }

       

        private void tag_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
            panel2.Visible = true;
            textsearch.Visible = true;
            //TextBox tagSearch = new TextBox();
            //tagSearch.Size = new Size(150, 25);
            //tagSearch.Location = new Point(5, 5);
            //panel2.Controls.Add(tagSearch);


            //Panel tagsContainer = new Panel();
            //tagsContainer.Size = new Size(190, 80);
            //tagsContainer.Location = new Point(5, 40);
            //panel2.Controls.Add(tagsContainer);
            for (int i = 0; i < login.me.friendssort.Count; i++)
            {
                
                login.me.frienddata(login.me.friendssort[i], ref fname, ref sname, ref image);
                Button tagBtn = new Button();
                tagBtn.Size = new Size(168, 40);
                tagBtn.Location = new Point(1, 41*i);
                tagBtn.FlatStyle = FlatStyle.Flat;
                tagBtn.Text = fname + " " + sname;
                if (image != null)
                {
                    //////MemoryStream stream = new MemoryStream(image);
                    //////tagBtn.Image = System.Drawing.Image.FromStream(stream);
                    PictureBox pic = new PictureBox();
                    pic.Size = new Size(35, 35);
                    pic.Location = new Point(3, 3);
                    pic.SizeMode = PictureBoxSizeMode.StretchImage;
                    MemoryStream stream = new MemoryStream(image);
                    pic.Image = System.Drawing.Image.FromStream(stream);
                    
                    tagBtn.Controls.Add(pic);
                }
                
                tagBtn.TextAlign = ContentAlignment.MiddleCenter;
                //tagsContainer.Controls.Add(tagBtn);
                panel2.Controls.Add(tagBtn);
                PictureBox choosed = new PictureBox();
                choosed.Size = new Size(20, 20);
                choosed.Location = new Point(130, 10);
                choosed.BorderStyle = BorderStyle.FixedSingle;
                tagBtn.Controls.Add(choosed);
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            panel2.Visible = false;
            textsearch.Visible = false;
            button1.Visible = false;
        }

        private void textsearch_TextChanged(object sender, EventArgs e)
        {
            int j = 0;
            panel2.Controls.Clear();
            for(int i = 0; i < login.me.friendssort.Count; i++)
            {
                bool isfound=pos.tag(login.me.friendssort[i],textsearch.Text);
                if (isfound == true)
                {
                    login.me.frienddata(login.me.friendssort[i],ref fname,ref sname,ref image);
                    Button tagBtn = new Button();
                    tagBtn.Size = new Size(168, 40);
                    tagBtn.Location = new Point(1, 41 * j);
                    j++;
                    tagBtn.FlatStyle = FlatStyle.Flat;
                    tagBtn.Text = fname + " " + sname;
                    if (image != null)
                    {
                        //////MemoryStream stream = new MemoryStream(image);
                        //////tagBtn.Image = System.Drawing.Image.FromStream(stream);
                        PictureBox pic = new PictureBox();
                        pic.Size = new Size(35, 35);
                        pic.Location = new Point(3, 3);
                        pic.SizeMode = PictureBoxSizeMode.StretchImage;
                        MemoryStream stream = new MemoryStream(image);
                        pic.Image = System.Drawing.Image.FromStream(stream);

                        tagBtn.Controls.Add(pic);
                    }

                    tagBtn.TextAlign = ContentAlignment.MiddleCenter;
                    //tagsContainer.Controls.Add(tagBtn);
                    panel2.Controls.Add(tagBtn);
                    PictureBox choosed = new PictureBox();
                    choosed.Size = new Size(20, 20);
                    choosed.Location = new Point(130, 10);
                    choosed.BorderStyle = BorderStyle.FixedSingle;
                    tagBtn.Controls.Add(choosed);

                }

            }
                
        }
    }
}
      

       

     

      
