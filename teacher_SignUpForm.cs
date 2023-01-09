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
    public partial class teacher_SignUpForm : Form
    {
        public teacher_SignUpForm()
        {
            InitializeComponent();
        }

        private void btnCross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRegisterTeacher_Click_1(object sender, EventArgs e)
        {

            if (txtTeacherName.Text == "" && txtTeacherPassword.Text == "" && txtTeacherConf.Text == "")
            {
                MessageBox.Show("Username and Password fields are empty", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            else if (txtTeacherPassword.Text == txtTeacherConf.Text)
            {
                String error = Connection.SetData("Insert into mst_teacher_user(user_name, phone_no, email, password) values ('" + txtTeacherName.Text + "', '" + txtMobileTeacher.Text + "', '" + txtEmailTeacher.Text + "','" + txtTeacherPassword.Text + "')");
                txtTeacherName.Text = "";
                txtMobileTeacher.Text = "";
                txtEmailTeacher.Text = "";
                txtTeacherPassword.Text = "";
                txtTeacherConf.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Password does not Match, Please Re-enter", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtTeacherPassword.Text = "";
                txtTeacherConf.Text = "";
                txtTeacherPassword.Focus();

            }
        }

        private void checkShowTeacher_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTeacher.Checked == true)
            {
                txtTeacherPassword.PasswordChar = '\0';
                checkTeacher.Text = "Hide Password";
            }
            else
            {
                txtTeacherPassword.PasswordChar = '*';
                checkTeacher.Text = "Show Password";
            }
        }
    }
}
