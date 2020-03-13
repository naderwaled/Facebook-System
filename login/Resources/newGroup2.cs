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

namespace Messenger
{

    public partial class newGroup2 : Form
    {
     //   public messenger me = new messenger(5);
        //public 
        public newGroup2()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";
            if(dlg.ShowDialog()==DialogResult.OK)
            {
                string pic = dlg.FileName.ToString();
                pictureBox1.ImageLocation = pic;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Login.message.GroupChat(textBox1);
            this.Close();
        }
    }
}
