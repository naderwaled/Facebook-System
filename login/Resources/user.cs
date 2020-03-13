using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.IO;
using FACEBOOK;
namespace FACEBOOK
{
  public  class user
    {
        public int Id;
      public  string FristName;
      public string SecondName;
      public  string Email;
      public  string Password;
      public  string Birthday;
      public  string Gender;
      public byte[] profileimage=null;
      public byte[] coverimage=null;

         public List<int> friendssort = new List<int>();
        List<int> friends = new List<int>();
        public List<List<int>> youmaynow = new List<List<int>>();
        public List<int> friends_request = new List<int>();
        post post2 = new post();

        public user() { }
       public user(string email)
        {
            this.Email = email;
           string co = "datasource=localhost;port=3306;username=root;password=516526";
           string task = "select * from facebook.user where email='" + email + "';";
           MySqlConnection connect = new MySqlConnection(co);
           MySqlCommand cmd = new MySqlCommand(task,connect);
           MySqlDataReader r ;
           try
           {
               connect.Open();
               r = cmd.ExecuteReader();
               r.Read();
               this.Id = r.GetInt16("id");
               this.FristName = r.GetString("fristname");
               this.Password = r.GetString("password");
               this.Gender = r.GetString("gender");
               this.Birthday = r.GetString("birthday");
                try
                {
                    this.profileimage = (byte[])(r["profileimage"]);
                }
                catch(Exception ex)
                {
                    
                }
                try
                {
                    this.coverimage = (byte[])(r["coverimage"]);
                }
                catch (Exception ex)
                {

                }
                this.SecondName = r.GetString("secondname");
              

               
               connect.Close();
                friendsfun();
                showfriends();
                friendrequest();
                youmaynowfun();
               
           }
           catch (Exception ex)
           {
               MessageBox.Show(ex.Message);
           }
       }
        
        public bool Login(string email, string password)
        {

            try
            {
                string myConnection = "datasource=localhost;port=3306;username=root;password=516526";
                string task = "select * from facebook.user where email='" + email + "'and password='" + password + "';";
                MySqlConnection myConn = new MySqlConnection(myConnection);
                MySqlCommand SelectCommand = new MySqlCommand(task, myConn);

                MySqlDataReader myReader;
                myConn.Open();
                myReader = SelectCommand.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {
                    count = count + 1;
                   
                }
                if (count == 1)
                {
                  
                   // MessageBox.Show("Username and Password is Correct");
                  
                    return true;
                 
                }

                else

                    MessageBox.Show("Username and Password is InCorrect Please try again!");
                myConn.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return false;
        }
        public bool signup(string firstname,string secondname,string email,string password,string gender,string birthday)
        {
            bool isused = false;
            String constring = "datasource=localhost;port=3306;username=root;password=516526";
            String Query = "SELECT * FROM facebook.user where email='" + email + "';";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBasee = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBasee.ExecuteReader();
                int count = 0;
                while (myReader.Read())
                {

                    count += 1;
                }
                if (count > 0)
                {
                    isused = true;
                    MessageBox.Show("email is already used");
                    conDataBase.Close();
           
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            

            if (isused == false)
            {
                constring = "datasource=localhost;port=3306;username=root;password=516526";
                Query = "INSERT INTO facebook.user ( fristname, email, password, gender, birthday, secondname) VALUES('" + firstname + "','"+email + "','" + password + "','" + gender + "','" + birthday + "','" + secondname + "');";
                conDataBase = new MySqlConnection(constring);
                cmdDataBasee = new MySqlCommand(Query, conDataBase);

                try
                {
                    conDataBase.Open();
                    myReader = cmdDataBasee.ExecuteReader();
                    myReader.Read();
                    MessageBox.Show("Registration successfully");
                    conDataBase.Close();
                

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            if (isused == true)
                return false;
            else
                return true;
        }
        public void updatedata(string firstname, string secondname, string password, string birthday)
        {

            String constring = "datasource=localhost;port=3306;username=root;password=516526";
            String Query = "update facebook.user set  fristname='" + firstname + "',secondname='" + secondname + "',password='" + password + "',birthday='" + birthday + "' where (id='" + this.Id + "');";
            MySqlConnection conDataBase = new MySqlConnection(constring);
            MySqlCommand cmdDataBasee = new MySqlCommand(Query, conDataBase);
            MySqlDataReader myReader;
            try
            {
                conDataBase.Open();
                myReader = cmdDataBasee.ExecuteReader();
                MessageBox.Show("Updated");
                while (myReader.Read())
                {

                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void friendsfun()
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select * from facebook.friends where (iduser1='" + this.Id + "'or iduser2='" + this.Id + "') and levell='friends';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    int iduser = reader.GetInt16("iduser1");
                    int friendid = reader.GetInt16("iduser2");
                    if (friendid == this.Id)
                    {
                        friendid = iduser;
                    }

                    friends.Add(friendid);


                }
                connect.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void  frienddata(int id,ref string fname,ref string sname,ref byte[] picture)
        {
            string constring = "datasource=localhost;port=3306;username=root;password=516526";
            MySqlConnection connect = new MySqlConnection(constring);
            string task = "select * from facebook.user where id='"+id+"';";
            MySqlCommand cmd = new MySqlCommand(task,connect);
            connect.Open();
            MySqlDataReader reader;
            reader = cmd.ExecuteReader();
            reader.Read();
            fname = reader.GetString("fristname");
            sname = reader.GetString("secondname");
            picture = (byte[])(reader["profileimage"]);
            reader.Close();
            connect.Close();
        }
        public void friendrequest()
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select * from facebook.friends where (iduser2='" + this.Id + "') and levell='friend request';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    int iduser = reader.GetInt16("iduser1");
                    int friendid = reader.GetInt16("iduser2");
                    if (friendid == this.Id)
                    {
                        friendid = iduser;
                    }

                    friends_request.Add(friendid);
                   


                }
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void  youmaynowfun()




        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";

                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select id from facebook.user;";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;

                connect.Open();
                reader = cmd.ExecuteReader();
                for (int i = 0; reader.Read(); i++)
                {
                    youmaynow.Add(new List<int>());
                    youmaynow[i].Add(reader.GetInt16("id"));
                   
                }
                reader.Close();
                for (int i = 0; i < youmaynow.Count; i++)
                {
                    if (this.Id == youmaynow[i][0])
                    {
                        youmaynow[i].Add(0);
                        continue;
                    }
                    int count = 0;
                    string task2 = "select * from facebook.friends where (iduser1='" + youmaynow[i][0] + "'or iduser2='" + youmaynow[i][0] + "') and levell='friends';";
                    MySqlCommand cmd2 = new MySqlCommand(task2, connect);

                    reader = cmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        int iduser = reader.GetInt16("iduser1");
                        int friendid = reader.GetInt16("iduser2");
                        if (friendid == youmaynow[i][0])
                        {
                            friendid = iduser;
                        }
                        if (friends.Contains(friendid))
                        {
                            count++;

                        }

                    }
                   
                    
                    youmaynow[i].Add(count);
                    reader.Close();
                }
                    connect.Close();

                while (true)
                {
                    bool issorted = true;
                    for (int i = 0; i < youmaynow.Count - 1; i++)
                    {
                        if (youmaynow[i][1] < youmaynow[i + 1][1])
                        {
                            int x = youmaynow[i+1][0];
                            int y = youmaynow[i+1][1];
                            youmaynow[i + 1][0] = youmaynow[i][0];
                            youmaynow[i + 1][1] = youmaynow[i][1];
                            youmaynow[i][0] = x;
                            youmaynow[i][1] = y;
                            issorted = false;
                        }
                    }
                    if (issorted == true)
                    {
                        break;
                    }
                }






            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }
        public void delete_request(int iduser,int id_senduser)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select *  from facebook.friends where iduser1='"+id_senduser+"'and iduser2='"+iduser+"'and levell='friend request';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                int id = reader.GetInt16("id");
                reader.Close();
                task = "delete from facebook.friends where (id='"+id+"');";
                MySqlCommand cmd2 = new MySqlCommand(task, connect);
                reader = cmd2.ExecuteReader();
                reader.Read();
                reader.Close();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void send_request(int iduser, int id_senduser)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "insert into facebook.friends (iduser1,iduser2,levell) values ('" + id_senduser + "','" + iduser + "','friend request') ;";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                reader.Close();
                connect.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public  void  accept_request(int iduser,int id_senduser)
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select * from facebook.friends where iduser1='"+iduser+"' and iduser2='"+id_senduser+"';";
                
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                int id = reader.GetInt16("id");
                reader.Close();
                task = "update facebook.friends set levell ='friends' where (id='" + id + "');";
              MySqlCommand  cmd2 =new MySqlCommand (task, connect);
                reader = cmd2.ExecuteReader();
                reader.Read();
                reader.Close();

                connect.Close();
                login.message.insert_in_chat(iduser,id_senduser);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public void showfriends()
        {
            try
            {
                string constring = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(constring);
                string task = "select id from facebook.user ORDER BY fristname ASC;";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
               
                while (reader.Read())
                {
                    int id = reader.GetInt16("id");
                    if (friends.Contains(id))
                    {
                        friendssort.Add(id);
                       
                    }

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool search(int idfriend, string text)
        {
            string fname = "", sname = "";
            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(road);
                string task = "select * from facebook.user where id='" + idfriend + "';";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                reader = cmd.ExecuteReader();
                reader.Read();
                fname = reader.GetString("fristname");
                sname = reader.GetString("secondname");
                reader.Close();
                connect.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            if (fname.Contains(text) || sname.Contains(text))
                return true;
            else
                return false;
        }
        public void update_photo(int id,string type,byte[] photo)
        {
            try
            {
                string road = "datasource=localhost;port=3306;username=root;password=516526";
                MySqlConnection connect = new MySqlConnection(road);
                string task = "update facebook.user set " + type + "=@IMG where (id='" + id + "');";
                MySqlCommand cmd = new MySqlCommand(task, connect);
                MySqlDataReader reader;
                connect.Open();
                cmd.Parameters.Add(new MySqlParameter("@IMG", photo));
                reader = cmd.ExecuteReader();
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


            



           

          





        
       
     

