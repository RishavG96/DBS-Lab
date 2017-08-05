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
    public partial class Form1 : Form
    {
        public static String username = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String n = name1.Text.ToString();
            String p = password1.Text.ToString();
            if (n.Equals(p))
            {
                error.Text = "Logged IN";
                username = name1.Text;
                this.Hide();
                Login ob = new Login();
                ob.Show();
            }
            else
            {
                error.Text = "Invalid Login credentials";
            }
        }
    }
}
