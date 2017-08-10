using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnlineRegister
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            int c = 0;
            if(name.Text=="" || sn.Text=="" || rno.Text=="" ||email.Text==""||mob.Text=="")
            {
                MessageBox.Show("Complete the Form");
                c = 1;
            }
            if((name.Text.Any(char.IsDigit)) || (mn.Text.Any(char.IsDigit)) ||(sn.Text.Any(char.IsDigit)))
            {
            MessageBox.Show("Invalid Name or Middle Name or Surname");
            c=1;
            }
            if(rno.Text.Any(char.IsLetter) || rno.Text.Length!=9)
            {
                MessageBox.Show("Invalid Reg No");
                c=1;
            }
           if(!email.Text.Contains("@") && !email.Text.Contains(".") && (email.Text.IndexOf("@")<email.Text.IndexOf(".")))
           {
               MessageBox.Show("Invalid Email");
               c=1;
        }
           if (mob.Text.Length != 10 || !mob.Text.All(char.IsDigit))
           {
               MessageBox.Show("Invalid Mobile Number");
               c = 1;
           }
           if (!male.Checked && !female.Checked)
           {
               MessageBox.Show("Select Any one of the Genders ");
               c = 1;
           }
            if(c==0)
            {
                String r="Name = "+name.Text+"  "+mn.Text+"  "+sn.Text;
                r=r+"\n Mobile no: "+mob.Text;
                r=r+"\n Branch = "+branch.Text;
                r=r+"\n Semester = "+sem.Text;
                r=r+"\n Regn. NO = "+rno.Text;
                r=r+"\n Email = "+email.Text;
                if(male.Checked)
                    r=r+"\n Gender = MALE";
                else
                    r=r+"\n Gender = FEMALE";
                r = r + "\n Date of Birth : " + dateTimePicker1.Text;
                MessageBox.Show(r);
            }
        }
    }
}