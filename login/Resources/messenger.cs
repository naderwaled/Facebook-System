using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Messenger;
using Login.Resources;
using new_design;
//using MySql.Data.MySqlClient;
using FACEBOOK;
namespace Messenger
{
    public class messenger
    {
        public int login_me_Id =login.me.Id , IdChat = 0, NumOfChats = -1;
    
        // nader's hbd
        int idSender;
        string fname;
        string sname;
        byte[] pic;
        public List<List<int>> idchats = new List<List<int>>();
        

        public bool found = false;
        public  int indexy ;

      public  messenger(int id)
        {
            mycon();
        }


      

      
        
        public void mycon()
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select * from facebook.chat where iduser='" + login_me_Id + "';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    int id_chat = reader.GetInt16("idchat");
                    idchats.Add(new List<int>());
                    idchats[i].Add(id_chat);

                }
                reader.Close();
                for (int i = 0; i < idchats.Count; i++)
                {
                    task = "select * from facebook.chat where idchat='" + idchats[i][0] + "' and iduser!='"+login_me_Id+"';";
                    MySqlCommand cmd2 = new MySqlCommand(task, connect);
                    reader = cmd2.ExecuteReader();
                    
                    
                        
                        while (reader.Read())
                        {
                            int id2 = reader.GetInt16("iduser");
                            idchats[i].Add(id2);
                        }
                    
                    reader.Close();
                }
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void loadmessage(int idchat)
        {
          //  MessageBox.Show(idchat.ToString());
            try
            {
                Messenger2 me = new Messenger2();
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task4 = "select * from facebook.messagechat where idchat='" + idchat + "';";
                MySqlCommand cmd4 = new MySqlCommand(task4, connect);
                connect.Open();
                MySqlDataReader reader = cmd4.ExecuteReader();
               // reader.Read();
                while (reader.Read())
                {
                    int count = 0;
                    Label lbl = new Label();
                    Label lblname = new Label();
                     idSender = reader.GetInt16("iduser");
                    string msg;
                    try {
                        msg = reader.GetString("text");
                        count += 1;
                        if (idSender == login_me_Id && count == 1)
                        {
                            lblname.Text = login.me.FristName + " :";
                            lblname.ForeColor = Color.Blue;
                            lblname.Location = new Point(0, indexy);
                            lblname.Font = new Font("Bold", 12);


                            indexy += lblname.Height;

                            lbl.Location = new Point(10, indexy);
                            lbl.ForeColor = Color.White;
                            lbl.BackColor = Color.Green;
                            lbl.AutoSize = true;
                            lbl.Font = new Font("Bold", 12);
                            lbl.Text = msg;
                            //lbl.TextAlign = ContentAlignment.MiddleRight;
                            indexy += lbl.Size.Height;
                            login.moo.panel2.Controls.Add(lblname);
                            login.moo.panel2.Controls.Add(lbl);

                        }
                        else
                        {
                            login.me.frienddata(idSender, ref fname, ref sname, ref pic);
                            lblname.Text = fname+ " :";
                            lblname.ForeColor = Color.Red;
                            lblname.Location = new Point(0, indexy);
                            lblname.Font = new Font("Bold", 12);
                            indexy += lblname.Size.Height;

                            lbl.BackColor = Color.White;
                            lbl.Location = new Point(10, indexy);
                            lbl.ForeColor = Color.Black;
                            lbl.AutoSize = true;
                            lbl.Font = new Font("Regular", 12);
                            lbl.Text = msg;
                            indexy += lbl.Size.Height;
                            login.moo.panel2.Controls.Add(lblname);
                            login.moo.panel2.Controls.Add(lbl);
                        }
                    }
                    catch(Exception ex)
                    {
                       
                        if (idSender == login_me_Id)
                        {
                            lblname.Text = login.me.FristName + " :";
                            lblname.ForeColor = Color.Blue;
                            lblname.Location = new Point(0, indexy);
                            lblname.Font = new Font("Bold", 12);
                            indexy += lblname.Height;
                        }
                        else {
                            login.me.frienddata(idSender, ref fname, ref sname, ref pic);
                            lblname.Text = fname + " :";
                            lblname.ForeColor = Color.Red;
                            lblname.Location = new Point(0, indexy);
                            lblname.Font = new Font("Bold", 12);
                            indexy += lblname.Height;
                        }
                        pic = (byte[])(reader["image"]);
                        PictureBox pics = new PictureBox();
                        pics.Size = new Size(360, 300);
                        pics.Location = new Point(10, indexy);
                        pics.SizeMode = PictureBoxSizeMode.StretchImage;
                        indexy += pics.Height;
                        MemoryStream stream = new MemoryStream(pic);
                        pics.Image = System.Drawing.Image.FromStream(stream);
                        login.moo.panel2.Controls.Add(lblname);
                        login.moo.panel2.Controls.Add(pics);

                    }
                   
                   
                   
                    
                   

                }


                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sendmessage(int idchat,string message)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = " INSERT INTO facebook.messagechat (idchat, text, iduser,time, date) VALUES('" + idchat + "','" + message + "', '" + login.me.Id + "', 'oo', 'aa');";
                MySqlCommand cmd = new MySqlCommand(task,connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void sendimage(int idchat,ref byte[] image)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = " INSERT INTO facebook.messagechat (idchat,image, iduser,time, date) VALUES('" + idchat + "',@IMG, '" + login.me.Id + "', 'oo', 'aa');";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG",image));
                reader = cmd.ExecuteReader();
                reader.Read();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void insert_in_chat(int iduser,int  idsenduser)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select max(id) from facebook.chat;";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                int id = reader.GetInt16("max(id)");
                id += 1;
                reader.Close();
                task = "insert into facebook.chat (iduser,idchat,chattype)values ('" + iduser + "','" + id + "','private')";
                MySqlCommand cmd2 = new MySqlCommand(task, connect);
                reader = cmd2.ExecuteReader();
                reader.Read();
                reader.Close();
                task = "insert into facebook.chat (iduser,idchat,chattype)values ('" + idsenduser + "','" + id + "','private')";
                MySqlCommand cmd3 = new MySqlCommand(task, connect);
                reader = cmd3.ExecuteReader();
                reader.Read();
                reader.Close();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
