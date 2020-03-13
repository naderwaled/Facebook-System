using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Messenger;
using FACEBOOK;
using System.IO;
using new_design;

using MySql.Data.MySqlClient;

namespace Login.Resources
{
    public partial class Messenger2 : Form
    {

        //  messenger message = new messenger(5);
        string fname;
        string sname;
        byte[] pic=null;
        byte[] pics=null;
        public int idch2;
        public Messenger2()
        {
            InitializeComponent();
        }

        private void msgButtons()
        {
            for (int i = 0; i < login.message.idchats.Count; i++)
            {
                string ffname;
                string ssname;
                Button btn = new Button();
                int id = login.message.idchats[i][1];
                int idch = login.message.idchats[i][0];
                login.me.frienddata(id, ref fname, ref sname, ref pic);
                ffname = fname;
                ssname = sname;
                btn.Dock = DockStyle.Top;
                btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                btn.BackColor = Color.FloralWhite;
                btn.FlatStyle = FlatStyle.Popup;
                btn.ForeColor = Color.DarkRed;
                btn.Font = new Font("Bold", 14);
                btn.Text = fname + " " + sname;
                btn.MouseClick += (s, t) =>
                {
                    panel5.Visible = true;
                    button4.Visible = true;
                    textBox1.Visible = true;
                    button1.Visible = true;
                    panel2.Visible = true;
                    button2.Visible = true;
                    
                    button4.Text = ffname + " " + ssname;
                    idch2 = idch;
                    login.message.indexy = 0;
                    login.moo.panel2.Controls.Clear();
                    login.message.loadmessage(idch);

                };

                btn.TextAlign = ContentAlignment.MiddleCenter;
                btn.Size = new Size(400, 51);
                btn.Location = new Point(0, 5 + 51 * i);

                PictureBox pics = new PictureBox();
                pics.BorderStyle = BorderStyle.None;
                pics.Size = new Size(41, 38);
                pics.Location = new Point(4, 6);
                pics.BackColor = Color.White;
                pics.SizeMode = PictureBoxSizeMode.StretchImage;
                if (pic != null)
                {
                    MemoryStream stream = new MemoryStream(pic);
                    pics.Image = System.Drawing.Image.FromStream(stream);
                }
                btn.Controls.Add(pics);
                panel6.Controls.Add(btn);
            }
        }

        private void Messenger2_Load(object sender, EventArgs e)
        {
            //message.mycon();
            msgButtons();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // panel6.Visible = false;
            panel7.Visible = true;
            panel7.Controls.Clear();
            int j = 0;
            for (int i = 0; i < login.message.idchats.Count; i++)
            {
                int x = login.message.idchats[i][1];
                login.me.frienddata(x,ref fname,ref sname,ref pic );
                if (sname.Contains(textBox2.Text) || fname.Contains(textBox2.Text))
                {
                    string ffname, ssname;
                    Button btn = new Button();
                    int id = login.message.idchats[i][1];
                    int idch = login.message.idchats[i][0];
                    login.me.frienddata(x, ref fname, ref sname, ref pic);
                    ffname = fname;
                    ssname = sname;
                    btn.Dock = DockStyle.Top;
                    btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.ForeColor = Color.DarkRed;
                    btn.Font = new Font("Bold", 14);
                    btn.Text = fname + " " + sname;
                    btn.MouseClick += (s, t) =>
                    {
                        panel5.Visible = true;
                        button4.Visible = true;
                        textBox1.Visible = true;
                        button1.Visible = true;
                        panel2.Visible = true;
                        button2.Visible = true;
                        button4.Text = ffname + " " + ssname;
                        idch2 = idch;
                        login.message.indexy = 0;
                        login.moo.panel2.Controls.Clear();
                        login.message.loadmessage(idch);

                    };

                    btn.TextAlign = ContentAlignment.MiddleCenter;
                    btn.Size = new Size(400, 51);
                    btn.Location = new Point(0, 5 + 51 * j);
                    j++;

                    PictureBox pics = new PictureBox();
                    pics.BorderStyle = BorderStyle.None;
                    pics.Size = new Size(41, 38);
                    pics.Location = new Point(4, 6);
                    pics.BackColor = Color.White;
                    pics.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (pic != null)
                    {
                        MemoryStream stream = new MemoryStream(pic);
                        pics.Image = System.Drawing.Image.FromStream(stream);
                    }
                    btn.Controls.Add(pics);
                    panel7.Controls.Add(btn);
                }
            }

        }

        private void designMsgs()
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            newGroup grp = new newGroup();
            grp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {
                Label lblname = new Label();
                Label lbl = new Label();
                lblname.Text = login.me.FristName + " :";
                lblname.ForeColor = Color.Blue;
                lblname.Location = new Point(0, login.message.indexy);
                lblname.Font = new Font("Bold", 12);


                login.message.indexy += lblname.Height;

                lbl.Location = new Point(10, login.message.indexy);
                lbl.ForeColor = Color.White;
                lbl.BackColor = Color.Green;
                lbl.AutoSize = true;
                lbl.Font = new Font("Bold", 12);
                lbl.Text = textBox1.Text;
                login.message.indexy += lbl.Height;
                login.moo.panel2.Controls.Add(lblname);
                login.moo.panel2.Controls.Add(lbl);
                login.message.sendmessage(idch2, textBox1.Text);
                textBox1.Text = "";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog image = new OpenFileDialog();
            image.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if (image.ShowDialog() == DialogResult.OK)
            {
                Label lblname = new Label();
                lblname.Text = login.me.FristName + " :";
                lblname.ForeColor = Color.Blue;
                lblname.Location = new Point(0, login.message.indexy);
                lblname.Font = new Font("Bold", 12);
                


                login.message.indexy += lblname.Height;


                string picc = image.FileName.ToString();
                PictureBox picture = new PictureBox();
                picture.ImageLocation = picc;
                picture.Size = new Size(360,300);
                
                FileStream fstream = new FileStream(image.FileName.ToString(), FileMode.Open, FileAccess.Read);
                BinaryReader br = new BinaryReader(fstream);
                pics = br.ReadBytes((int)fstream.Length);
                br.Close();
                fstream.Close();
               login.message.sendimage(idch2,ref pics);
               








                picture.Location = new Point(10, login.message.indexy);
                picture.SizeMode = PictureBoxSizeMode.StretchImage;
                panel2.Controls.Add(lblname);
                panel2.Controls.Add(picture);
                login.message.indexy += picture.Height;



            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Exit_MouseClick(object sender, MouseEventArgs e)
        {
            this.Hide();
        }
    }
}
     