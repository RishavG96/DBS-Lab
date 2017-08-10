using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace BankingApplication
{
    public partial class Form1 : Form
    {
        public static double balance = 10000;
        public static String username = "";
        public static ArrayList n1 = new ArrayList();
        public static ArrayList pwd1 = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            n1.Add("rishav");
            pwd1.Add("rishav");
        }

        private void submit_Click(object sender, EventArgs e)
        {
            String n = name1.Text.ToString();
            String p = password1.Text.ToString();
            int flag = 0;
            for (int i = 0; i < n1.Count; i++) {
                if (n1[i].Equals(n)&&pwd1[i].Equals(p))
                {
                    error.Text = "Logged IN";
                    username = n;
                    flag = 1;
                    this.Hide();
                    Login ob = new Login();
                    ob.Show();
                }
            }
            if(flag==0)
            {
                error.Text = "Invalid Login credentials";
            }
        }
	}
}
