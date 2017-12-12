using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;


namespace Schedule
{
    class SecretarysDB 
    {
        Databases con = Databases.Instance();
        SqlCommand com;

        public void insertSecretarys(String username, String password, String fname, String lname, String id, String address)
        {
            try
            {
                con.OpenCon();
                //---select high ID course
                com = new SqlCommand("INSERT into Secretarys VALUES('" + username + "','" + password + "','" + fname + "','" + lname + "','" + address + "','" + id + "');", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                MessageBox.Show("Secretary Saved");
                while (rdr.Read())
                {

                }
                con.CloseCon();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public bool existSecretarys(String username, String id)
        {
            bool flag = false;
            int flag1 = 0;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM  Secretarys", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(0);
                    if (name == username)
                    {
                        flag = true;
                        break;
                    }
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            if (flag)
                flag1++;
            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Secretarys", con.GetCon());
                SqlDataReader rdr;
                rdr = com.ExecuteReader();
                String name = "";
                while (rdr.Read())
                {
                    name = rdr.GetString(4);
                    if (name == id)
                    {
                        flag = true;
                        break;
                    }
                }

                con.CloseCon();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return true;
            }
            if (flag)
                flag1++;
            if (flag1 == 2)
                return true;
            return false;
        }


        public void Update_Password(string password, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Secretarys SET Password = '" + password + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Password changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }

        public void Update_Address(string address, string id)
        {
            try
            {
                con.OpenCon();
                com = new SqlCommand("UPDATE Secretarys SET Address = '" + address + "' WHERE ID = '" + id + "'", con.GetCon());
                com.ExecuteNonQuery();
                MessageBox.Show("Address Changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
        }

        public List<Secretary> Get_All_Secretary()
        {
            List<Secretary> secretaries = new List<Secretary>();
            Secretary secretary = new Secretary();

            try
            {
                con.OpenCon();
                com = new SqlCommand("SELECT * FROM Secretarys", con.GetCon());
                SqlDataReader rdr = com.ExecuteReader();

                while (rdr.Read())
                {
                    secretary = new Secretary();
                    secretary.setAddress(rdr["Address"].ToString());
                    secretary.setFirstName(rdr["First_Name"].ToString());
                    secretary.setID(rdr["ID"].ToString());
                    secretary.setLastName(rdr["Last_Name"].ToString());
                    secretary.setPassword(rdr["Password"].ToString());
                    secretary.setUserName(rdr["User_Name"].ToString());


                    secretaries.Add(secretary);
                }
                rdr.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            con.CloseCon();
            return secretaries;
        }
    }
}
