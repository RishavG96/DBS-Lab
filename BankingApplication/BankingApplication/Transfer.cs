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
    public partial class Transfer : Form
    { 
        public Transfer()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!textBox4.Text.Equals(""))
            {
                Login.dates = dateTimePicker1.Value.ToString("dd-MM-yyyy");
                Login.balance -= Convert.ToDouble(textBox4.Text);
                Login.trans = Convert.ToDouble(textBox4.Text);
                MessageBox.Show("Amount Transferred : " + textBox4.Text + "\n" + "Current Balance :" + Login.balance);
                this.Hide();
                new Login().Show();
            }
            else
            {
                label6.Text = "ENter the details";
            }
        }
    }
}
