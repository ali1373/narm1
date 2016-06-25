using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bime_Iran
{
    
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Equals("admin") && textBox2.Text.Equals("admin"))
            {
                this.Hide();
                AdminsPage admin_page = new AdminsPage();
                
                admin_page.Show();
            }
            else if (textBox1.Text.Equals("manager") && textBox2.Text.Equals("manager"))
            {
                this.Hide();
                ManagerForm manager_page = new ManagerForm();
                
                manager_page.Show();
            }
            else if (textBox1.Text.Equals("user") && textBox2.Text.Equals("user"))
            {
                this.Hide();
                UserForm userForm = new UserForm();
                
                userForm.Show();
            }
            else {

                MessageBox.Show("نام کاربری و یا رمز عبور اشتباه است");
            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.ResetText();
            textBox2.ResetText();
        }
    }
}
