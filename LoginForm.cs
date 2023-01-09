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
    public partial class LoginForm : Form
    {
        public int logAttempt = 0;
        public LoginForm()
        {
            InitializeComponent();
            Init_Data();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            panelTeacher.Visible = false;
            panelStudent.Visible = false;
            
           
        }

        private void btnCreate_Click_1(object sender, EventArgs e)
        {
           new SignUpForm().Show();
            
            this.Hide();
        }



        private void btnForgot_Click_1(object sender, EventArgs e)
        {
            new VerifyForm().Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM mst_user Where user_name = '" + txtUsername.Text + " ' and password = '" + txtPassword.Text + " '");
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();
                
                //txtUserName.Text = "";
                //txtPassword.Text = "";
                txtUsername.Focus();
                logAttempt += 1;
                if (logAttempt == 3)
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                }


            }
            else
            {
                Save_Data();
                this.Hide();
                GeneralFunction.mdiForm = new MainForm();
                GeneralFunction.mdiForm.Show();

            }
        }

            //if (attempts == 4)
            //{
            //    MessageBox.Show("You'");
            //}

        
    public void Reset()
    {
        txtUsername.Text = string.Empty;
        txtPassword.Text = string.Empty;

    }

        private void btnClear_Click_1(object sender, EventArgs e)
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
            txtUsername.Focus();

        }

        private void checkShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkShow.Checked)
            {
                txtPassword.PasswordChar = '\0';
                
            }
            else
            {
                txtPassword.PasswordChar = '*';
                
            }
        }

        private void Init_Data()
        {
            if(Properties.Settings.Default.UserName != string.Empty)
            {
                if(Properties.Settings.Default.remme == "yes")
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;
                    txtPassword.Text = Properties.Settings.Default.Password;
                    checkRemember.Checked = true;
                }
                else
                {
                    txtUsername.Text = Properties.Settings.Default.UserName;


                }    
            }
        }
        private void Save_Data()
        {
            if(checkRemember.Checked)
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = txtPassword.Text;
                Properties.Settings.Default.remme = "yes";
                Properties.Settings.Default.Save();
            }
            else 
            {
                Properties.Settings.Default.UserName = txtUsername.Text;
                Properties.Settings.Default.Password = "";
                Properties.Settings.Default.remme = "no";
                Properties.Settings.Default.Save();
            }
        }

        //private void btnCross_Click(object sender, EventArgs e)
        //{
        //    this.Close();
        //}

        private void cmbSelectUser_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSelectUser.SelectedIndex == 0)
            {
                panelStudent.Visible = true;
                panelTeacher.Visible = false;
            }
            else if (cmbSelectUser.SelectedIndex == 1)
            {
                panelStudent.Visible = false;
                panelTeacher.Visible = true;
            }
        }

        private void checkTeacher_CheckedChanged(object sender, EventArgs e)
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

        private void btnTeacherLogin_Click(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select * FROM mst_teacher_user Where user_name = '" + txtTeacherName.Text + " ' and password = '" + txtTeacherPassword.Text + " '");
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                MessageBox.Show("Invalid Username or Password, Please Try Again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Reset();

                //txtUserName.Text = "";
                //txtPassword.Text = "";
                txtTeacherName.Focus();
                logAttempt += 1;
                if (logAttempt == 3)
                {
                    MessageBox.Show("You have exceeded the maximum number of login attempts", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtUsername.Enabled = false;
                    txtPassword.Enabled = false;
                    btnLogin.Enabled = false;
                }


            }
            else
            {
                Save_Data();
                this.Hide();
                GeneralFunction.mdiForm = new MainForm();
                GeneralFunction.mdiForm.Show();

            }
        }

        private void lblcross_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblCreateAccTeacher_Click(object sender, EventArgs e)
        {
            new teacher_SignUpForm().Show();

            this.Hide();
        }

        private void checkTeacherRem_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
