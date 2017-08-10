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
    public partial class ChangePwd : Form
    {
        public static int f = 0;
        public ChangePwd()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String oldpwd = maskedTextBox1.Text;
            String newpwd = maskedTextBox2.Text;
            int index = 0;int flag = 0;
            for(int i=0;i<Form1.n1.Count;i++)
            {
                if(Form1.pwd1[i].Equals(oldpwd))
                {
                    index = i;
                    flag = 1;
                    break;
                }
            }
            Console.WriteLine(Form1.pwd1[index]);
            if(flag==1)
            {
                Form1.pwd1[index] = newpwd;
                f = 1;
                this.Hide();
                new Login().Show();
            }
            else
            {
                label3.Text = "Wrong password";
            }
            Console.WriteLine(Form1.pwd1[index]);
            
        }
    }
}
