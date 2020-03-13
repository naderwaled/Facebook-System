using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using FACEBOOK;
namespace Login
{
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
        }

        private void firstname_Click(object sender, EventArgs e)
        {

        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            string bb=txtcomboBox1.Text+'/'+txtcomboBox3.Text+'/'+txtcomboBox2.Text;
            login.me.updatedata(txtfirst.Text,txtsecond.Text,txtpass.Text,bb);
            this.Close();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Edit_Load(object sender, EventArgs e)
        {
            txtfirst.Text = login.me.FristName;
            txtsecond.Text = login.me.SecondName;
            txtpass.Text =login.me.Password;
            bool frist = true;
            bool second = true;
            for(int i = 0; i < login.me.Birthday.Length; i++)
            {
                if (login.me.Birthday[i] != '/' && frist == true)
                {
                    txtcomboBox1.Text += login.me.Birthday[i];
                }
                else if (login.me.Birthday[i] == '/' && frist == true)
                    frist = false;
                else if (login.me.Birthday[i] != '/' && frist == false && second == true)
                    txtcomboBox3.Text += login.me.Birthday[i];
                else if (login.me.Birthday[i] == '/' && frist == false && second == true)
                    second = false;
                else if (frist == false && second == false)
                    txtcomboBox2.Text += login.me.Birthday[i];

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
        }
    }
}
