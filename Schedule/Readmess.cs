using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Schedule
{
    public partial class Readmess : Form
    {
        messageDB message= new messageDB();
        string ID;
        public Readmess(string id)
        {
            InitializeComponent();
            ID = id;
        }

        private void Readmess_Load(object sender, EventArgs e)
        {

            List<string> listMess = new List<string>();
            lb_message.Items.Clear();
            listMess = message.returnmessages(ID);

            foreach (string Item in listMess)
                lb_message.Items.Add(Item);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Return_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
