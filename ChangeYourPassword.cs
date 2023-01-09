using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Student_Project
{
    public partial class ChangeYourPassword : Form
    {
        string m_user_name = "";
        public ChangeYourPassword(string username)
        {
            InitializeComponent();
            m_user_name = username;

           
        }


        private void btnReset_Click_1(object sender, EventArgs e)
        {

            if (txtNewPassword.Text == txtConfirmPassword.Text)
            {
                //String error = Connection.SetData("Insert into mst_user(password) values ('" + txtNewPassword + "')");
                //tring error = Connection.SetData("Update mst_user Set password = '" + txtNewPassword.Text + "' where user_name = " + m_user_name + "'");
                String error = Connection.SetData("Update mst_user Set password = '" + txtNewPassword.Text + "' where user_name = '" + m_user_name + "'");
                txtNewPassword.Text = "";
                txtConfirmPassword.Text = "";
                txtNewPassword.Focus();

                MessageBox.Show("Reset Successfully");
            }
            else
            {
                MessageBox.Show("The new password do not match so enter same password");
            }
        }

        
       

        private void ChangeYourPassword_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            new LoginForm().Show();
            this.Hide();
        }
    }
}
