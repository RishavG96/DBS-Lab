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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            name.Text ="Hello "+Form1.username+"!";
            label8.Text = "01-08-2017\n02-08-2017\n03-08-2017\n04-08-1997";
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        
    }
}
