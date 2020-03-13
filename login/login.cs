using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using FACEBOOK;
using MySql.Data.MySqlClient;
using new_design;
using Messenger;
using Login.Resources;
namespace FACEBOOK
{
    

    public partial class login : Form
    {
        string Gender = "";
        string birthday="";
        int count = 0;
        public static Messenger2 moo;
        



        user newuser = new user();
        user User = new user();


        public login()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            panel2.Hide();
            panel1.Show();
        }


        private void button2_Click(object sender, EventArgs e)
        {
         //   panel1.Hide();
            panel2.Show();


        }







        public void button4_Click(object sender, EventArgs e)
        {
            bool iscorrect = true;
            birthday = comboBox1.Text + '/'+ comboBox3.Text + '/'+comboBox2.Text ;
            if (fname.Text == "")
            {
                fristnamecheck.Visible = true;
                iscorrect = false;
            }
            else
                fristnamecheck.Visible = false;
            if (sname.Text == "")
            {
                secondnamecheck.Visible = true;
                iscorrect = false;
            }
            else
                secondnamecheck.Visible = false;
            if (textpass.Text == "")
            {
                Passwordcheck.Visible = true;
                iscorrect = false;
            }
            else
                Passwordcheck.Visible = false;
          
            if (comboBox1.Text==""||comboBox2.Text==""||comboBox3.Text=="")
            {
                birthdaycheck.Visible = true;
                iscorrect = false;
            }
            else
                birthdaycheck.Visible = false;
            if (Gender == "")
            {
                Gendercheck.Visible = true;
                iscorrect = false;
            }
            else
                Gendercheck.Visible = false;


            if (iscorrect == true)
            {
                bool isuse = newuser.signup(fname.Text, sname.Text, email.Text, textpass.Text, Gender, birthday);
                if (isuse == true)
                {
                    //  this.Hide();
                    //Form1 tl = new Form1();
                    //tl.email = email.Text;
                    //tl.Show();
                    Form1 tle = new Form1();
                    me = new user(email.Text);
                    message = new messenger(5);
                    
                    tle.Show();
                    this.Hide();

                    //newuser.data(textBox1.Text,ref newuser.Id, ref newuser.Name,ref newuser.Email, ref newuser.Password, ref newuser.Birthday, ref newuser.Gender);
                }
            }
        }




        private void female_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "female";
            count += 1;
        }

        private void male_CheckedChanged(object sender, EventArgs e)
        {
            Gender = "male";

            count += 1;

        }



     

      
        public static user me;
        public static messenger message;
        public static post post2=new post();

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

   

            private void email_TextChanged(object sender, EventArgs e)

        { 
          
}


private void label5_Click(object sender, EventArgs e)
        {

        }

        private void email_VisibleChanged(object sender, EventArgs e)
        {

        }

        private void fname_VisibleChanged(object sender, EventArgs e)
        {

        }

      

     

        private void login_Load(object sender, EventArgs e)
        {
          
        }

        private void sname_TextChanged(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(sname.Text))
            {
                e.Cancel = true;
                sname.Focus();
                errorProvider5.SetError(sname, "Please enter your Second name");//signup form
                
            }
            else
            {
                e.Cancel = false;
                errorProvider5.SetError(sname, null);
                count += 1;

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtemail_Click(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            if (Regex.IsMatch(textemail.Text, pattern))
            {
                errorProvider7.Clear();
                count += 1;
            }
            else
            {
                errorProvider7.SetError(this.textemail, "Please enter Valid email");


                return;
            }
        }

        private void txtmail_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            bool Iscorrect = true;

            if (textemail.Text == "")
            {
                emailcheck.Visible = true;
                Iscorrect = false;
            }
            else
                emailcheck.Visible = false;
            if (txtpass.Text == "")
            {
                passcheck.Visible = true;
                Iscorrect = false;
            }
            else
                passcheck.Visible = false;
            if (Iscorrect == true)
            {
                bool isuser = newuser.Login(textemail.Text, txtpass.Text);
                if (isuser == true)
                {
                    me = new user(textemail.Text);
                    message = new messenger(5);
                    post2.getposts(ref post2.postsss, me.Id, me.friendssort);
                    //  MessageBox.Show(textBox1.Text);


                    Form1 wr = new Form1();
                    this.Hide();
                    wr.Show();
                   // this.Close();
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void fname_TextChanged(object sender, EventArgs e)
        {

        }

        private void email_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void email_Leave(object sender, EventArgs e)
        {
            string pattern = @"^[a-zA-Z][\w\.-]*[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$";
            if (Regex.IsMatch(email.Text, pattern))
            {
                errorProvider3.Clear();
                count += 1;
            }
            else
            {
                errorProvider3.SetError(this.email, "Please enter Valid email");
                
               
                return;
            }
        }

       

       
    }
    }

