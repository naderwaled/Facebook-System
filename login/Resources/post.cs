using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace FACEBOOK
{
   public class post 
    {
  
        public byte[] image;
        public  List<List<int>> postsss = new List<List<int>>();


       public void write_in_database_photo_text(int iduser,string text,string date,string Praivcy,byte[] image,List<int> tag)

        {
            
            try
            {
            string road = "datasource=localhost;port=3306;username=root;password=516526";
            string task = "INSERT INTO facebook.post (iduser, text,postimage, date, privacy) VALUES ('"+iduser+"',"+"'"+text+"',@IMG,'"+date+"','"+Praivcy+"');";
            MySqlConnection connect = new MySqlConnection(road);
            MySqlCommand insert = new MySqlCommand(task,connect);
            MySqlDataReader reader;
                connect.Open();
                insert.Parameters.Add(new MySqlParameter("@IMG", image));
                reader = insert.ExecuteReader();
                reader.Read();
                reader.Close();

               
                //MessageBox.Show("saved");
                reader.Close();
                if (tag.Count > 0)
                {
                task="select max(idpost) from facebook.post;";
                MySqlCommand cmd2 = new MySqlCommand(task,connect);
                reader = cmd2.ExecuteReader();
                reader.Read();
                    int idpost = reader.GetInt16("max(idpost)");
                    reader.Close();
                    for(int i = 0; i < tag.Count; i++)
                    {
                        task = "insert into facebook.tags (idpost,iduser) values ('" + idpost + "','" + tag[i] + "')";
                        MySqlCommand cmd3 = new MySqlCommand(task,connect);
                        reader = cmd3.ExecuteReader();
                        reader.Read();
                        reader.Close();
                        
                    }
                   
                }

              
                connect.Close();

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
        public void write_in_database_photo(int iduser, string date, string Praivcy, byte[] image, List<int> tag)

        {

            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                string task = "INSERT INTO facebook.post (iduser,postimage, date, privacy) VALUES ('" + iduser   + "',@IMG,'" + date + "','" + Praivcy + "');";
                MySqlConnection connect = new MySqlConnection(road);
                MySqlCommand insert = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                insert.Parameters.Add(new MySqlParameter("@IMG", image));
                reader = insert.ExecuteReader();
                reader.Read();
                reader.Close();
                // MessageBox.Show("saved");
                if (tag.Count > 0)
                {
                    task = "select max(idpost) from facebook.post;";
                    MySqlCommand cmd2 = new MySqlCommand(task, connect);
                    reader = cmd2.ExecuteReader();
                    reader.Read();
                    int idpost = reader.GetInt16("max(idpost)");
                    reader.Close();
                    for (int i = 0; i < tag.Count; i++)
                    {
                        task = "insert into facebook.tags (idpost,iduser) values ('" + idpost + "','" + tag[i] + "')";
                        MySqlCommand cmd3 = new MySqlCommand(task, connect);
                        reader = cmd3.ExecuteReader();
                        reader.Read();
                        reader.Close();

                    }

                }
                connect.Close();

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }

        public void write_in_database_text(int iduser, string text, string date, string Praivcy, List<int> tag)

        {

            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                string task = "INSERT INTO facebook.post (iduser, text, date, privacy) VALUES ('" + iduser + "'," + "'" + text + "','"  + date + "','" + Praivcy + "');";
                MySqlConnection connect = new MySqlConnection(road);
                MySqlCommand insert = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = insert.ExecuteReader();
                reader.Read();
                reader.Close();
               
                if (tag.Count > 0)
                {
                    task = "select max(idpost) from facebook.post;";
                    MySqlCommand cmd2 = new MySqlCommand(task, connect);
                    reader = cmd2.ExecuteReader();
                    reader.Read();
                    int idpost = reader.GetInt16("max(idpost)");
                    reader.Close();
                    for (int i = 0; i < tag.Count; i++)
                    {
                        task = "insert into facebook.tags (idpost,iduser) values ('" + idpost + "','" + tag[i] + "')";
                        MySqlCommand cmd3 = new MySqlCommand(task, connect);
                        reader = cmd3.ExecuteReader();
                        reader.Read();
                        reader.Close();

                    }

                }
                connect.Close();

            }
            catch (Exception exx)
            {
                MessageBox.Show(exx.Message);
            }
        }
       public void getposts(ref List<List<int>> posts,int iduser,List<int>frined)
        {
            try { 
            List<List<int>> idpost=new List<List<int>>();
            string road = "datasource=localhost;port=3306;username=root;password=516526";
            MySqlConnection connect = new MySqlConnection(road);
            string task = "SELECT * FROM facebook.post ORDER BY idpost DESC;";
            MySqlCommand cmd = new MySqlCommand(task,connect);
            MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();

            for (int i=0; reader.Read();i++)
            {
                idpost.Add(new List<int>());
                idpost[i].Add(reader.GetInt16("idpost"));
            }
            reader.Close();
            int j = 0;
                for (int i = 0; i < idpost.Count; i++)
                {
                    task = "select * from facebook.post where idpost='" + idpost[i][0] + "';";
                    MySqlCommand cmd2 = new MySqlCommand(task, connect);
                    reader = cmd2.ExecuteReader();
                    reader.Read();
                    int ido = reader.GetInt16("iduser");
                    reader.Close();
                    bool tag = false;
                    task = "select * from facebook.tags where idpost='" + idpost[i][0] + "' and iduser='" + ido + "';";
                    MySqlCommand cmd3 = new MySqlCommand(task, connect);
                    reader = cmd3.ExecuteReader();
                    while (reader.Read())
                    {
                        tag = true;
                    }
                    reader.Close();
                    if (ido == iduser && tag == false)
                    {
                        posts.Add(new List<int>());
                        posts[j].Add(idpost[i][0]);
                        posts[j].Add(1);
                        j++;

                    }
                    else if (ido == iduser && tag == true)
                    {
                        posts.Add(new List<int>());
                        posts[j].Add(idpost[i][0]);
                        posts[j].Add(2);
                        j++;

                    }
                    else if (frined.Contains(ido) && tag == false)
                    {
                        posts.Add(new List<int>());
                        posts[j].Add(idpost[i][0]);
                        posts[j].Add(3);
                        j++;

                    }
                    else if (frined.Contains(ido) && tag == true)
                    {
                        posts.Add(new List<int>());
                        posts[j].Add(idpost[i][0]);
                        posts[j].Add(2);
                        j++;

                    }
                }  
                    connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
           


        }
        public void showpost(int idpost,int tag,ref int iduser,ref string text,ref byte[] image,ref string date,ref int counttag,ref string privacy)
        {
            string road = "datasource=localhost;port=3306;username=root;password=516526";
            MySqlConnection connect = new MySqlConnection(road);
            string task = "select * from facebook.post where idpost='"+idpost+"';";
            MySqlCommand cmd = new MySqlCommand(task,connect);
            MySqlDataReader reader;
            connect.Open();
            reader = cmd.ExecuteReader();
            reader.Read();
                date = reader.GetString("date");
               iduser = reader.GetInt16("iduser");
                privacy = reader.GetString("privacy");
            try
            {
                text = reader.GetString("text");
                
            }
            catch(Exception ex)
            {
               
            }
            try
            {
                image = (byte[])(reader["postimage"]);
            }
            catch(Exception ex)
            {
               
            }
                reader.Close();
            if (tag == 2 || tag == 4)
            {
                task = "select * from facebook.tags where idpost='"+idpost+"';";
                MySqlCommand cmd2 = new MySqlCommand(task,connect);
                reader = cmd2.ExecuteReader();
                while (reader.Read())
                {
                    counttag += 1;
                }
            }
            reader.Close();
            connect.Close();
       
        }
        public string reactbutton(string react, int perantid, string peranttype, int iduser)
        {
            string rer=null;
            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(road);
                string task = "select * from facebook.reacts where iduser='" + iduser + "' and perantID='" + perantid + "' and type='" + peranttype + "';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                bool isnew = true;
                int id = 0;
                while (reader.Read())
                {
                    id = reader.GetInt16("id");
                    rer = reader.GetString("reacttype");

                    isnew = false;
                }
                reader.Close();
                if (isnew == false)
                {
                    task = "update facebook.reacts set reacttype='" + react + "' where (id='" + id + "');";
                }
                else
                {
                    task = "insert into facebook.reacts (iduser,reacttype,type,perantID)values('" + iduser + "','" + react + "','" + peranttype + "','" + perantid + "')";
                }
                MySqlCommand cmd2 = new MySqlCommand(task, connect);
                reader = cmd2.ExecuteReader();
                reader.Read();
                
                reader.Close();
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return rer;
         
        }
        public void reactcount(int idpost,ref List<int> reactlist)
        {
            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(road);
                string task = "select * from facebook.reacts where perantID='" + idpost + "';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                for (int i = 0; i < 6; i++)
                    reactlist.Add(0);
                while (reader.Read())
                {
                    string typee = reader.GetString("reacttype");
                    if (typee == "like")
                        reactlist[0] += 1;
                    else if (typee == "love")
                        reactlist[1] += 1;
                    else if (typee == "haha")
                        reactlist[2] += 1;
                    else if (typee == "sad")
                        reactlist[3] += 1;
                    else if (typee == "wow")
                        reactlist[4] += 1;
                    else if (typee == "angry")
                        reactlist[5] += 1;

                }
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
















