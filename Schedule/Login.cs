using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Schedule
{
    public partial class Login : Form
    {
        private UsersDB users_db;
        private User user;
        bool firstclickUser=false;
        bool firstclickpass = false;


        public Login()
        {
            InitializeComponent();
            

        }

        private void button1_Click(object sender, EventArgs e) // Exit
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            b_login.Select();
            tb_user.SelectionStart = 8;
        }



        private void button3_Click(object sender, EventArgs e) //connecting button
        { 
            //--- Design pattern factory method ---
            UserFactory user_factory = new UserFactory();                      
            user = user_factory.GetUser(tb_user.Text, tb_Pass.Text, "");      //factory method - creat object - User by connection details

            if (user.GetUserType() != null)
            {                        
                if (user.GetUserType() == "Student")
                {
                    this.Hide();
                    user.GetStudent().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Professor") {
                    this.Hide();
                    user.GetProfessor().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Doctor") {
                    this.Hide();
                    user.GetDoctor().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Junior") {
                    this.Hide();
                    user.GetJunior().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Tutor") {
                    this.Hide();
                    user.GetTutor().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Secretary") {
                    this.Hide();
                    user.GetSecretary().Menu(); /* Needs to be implemented */
                }
                else if (user.GetUserType() == "Department Manager") {
                    this.Hide();
                    user.GetDepartmentManager().Menu(); /* Needs to be implemented */
                }
                else MessageBox.Show("Invalid username or password.");
            }
            this.Show();


        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            
            if (!firstclickUser)
            {
                tb_user.ForeColor = Color.Black;
                tb_user.Text = "";
                firstclickUser = true;
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            if (!firstclickpass)
            {
                tb_Pass.ForeColor = Color.Black;
                tb_Pass.Text = "";
                firstclickpass = true;
            }
        }

        private void tb_user_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_user.Text == "Username")
                tb_user.Text = "";
            tb_user.ForeColor = Color.Black;
        }

        private void tb_user_Leave(object sender, EventArgs e)
        {
            if (tb_user.Text == "")
            {
                tb_user.ForeColor = Color.Gray;
                tb_user.Text = "Username";
                firstclickUser = true;
            }
        }

        private void textBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (tb_Pass.Text == "Password")
                tb_Pass.Text = "";
            tb_Pass.ForeColor = Color.Black;
        }

        private void tb_Pass_Leave(object sender, EventArgs e)
        {
            if (tb_Pass.Text == "")
            {
                tb_Pass.ForeColor = Color.Gray;
                tb_Pass.Text = "Password";
                firstclickpass = true;
            }
        }


        private void tb_usert_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click(this, new EventArgs());
            }
        }


    }
}
