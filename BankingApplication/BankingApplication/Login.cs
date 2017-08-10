using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankingApplication
{
    public partial class Login : Form
    {
        public static double balance=1000.0;
        public Login()
        {
            InitializeComponent();
            if(ChangePwd.f==1)
            {
                label9.Text = "Password Changed Successfully";
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {
            name.Text ="Hello "+Form1.username+"!";
            label4.Text = balance+"";
            String res = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            label8.Text = "01-08-2017\n02-08-2017\n03-08-2017\n04-08-1997\n05-08-1997";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Transfer().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ChangePwd().Show();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Form1().Show();
        }
    }
}
