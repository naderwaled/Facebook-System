using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using FACEBOOK;
using new_design;
namespace Messenger
{
    public partial class newGroup : Form
    {
        string fname;
        string sname;
        byte[] pic;
     //   messenger me = new messenger(5);
            newGroup2 frm2 = new newGroup2();

        public newGroup()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void newGroup_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frm2.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (textBox1.Text != "")// & if he is a friend
            //{
            //    listBox1.Items.Add(textBox1.Text);
            //    textBox1.AutoCompleteCustomSource.Add(textBox1.Text);
            //    me.Members.Add(textBox1.Text);

            //}

            textBox1.Clear();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            frm2.Show();
            this.Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            //if (listBox1.SelectedIndex > -1)
            //{
            //    me.Members.RemoveAt(listBox1.SelectedIndex);
            //    listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            //}
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel2.Controls.Clear();
            int j = 0;
            for (int i = 0; i < login.me.friendssort.Count; i++)
            {
                bool isfound = login.me.search(login.me.friendssort[i], textBox1.Text);
                if (isfound == true)
                {
                    int id = login.me.friendssort[i];
                    login.me.frienddata(id, ref fname, ref sname, ref pic);
                    Button btn = new Button();
                    btn.Dock = DockStyle.Top;
                    btn.Anchor = (AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right);
                    btn.BackColor = Color.FloralWhite;
                    btn.FlatStyle = FlatStyle.Popup;
                    btn.ForeColor = Color.DarkRed;
                    btn.Font = new Font("Bold", 14);
                    btn.Text = fname + " " + sname;

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
                    panel2.Controls.Add(btn);

                }

            }
        }
    }
}
