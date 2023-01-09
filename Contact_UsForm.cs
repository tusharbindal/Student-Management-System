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
    public partial class Contact_UsForm : Form
    {
        public Contact_UsForm()
        {
            InitializeComponent();
        }

       
     
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            String name = txtName.Text;
            String contact = txtContact.Text;
            String email = txtEmail.Text;
            String gender = txtGender.Text;
            String city = txtCity.Text;
            String message = txtMessage.Text;
            string error = Connection.SetData("Insert into et_contact_us(contact, email, gender, city, message, name) values ('" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtGender.Text + "', '" + txtCity.Text + "', '" + txtMessage.Text + "', '" + txtName.Text + "')");
            if (error == "")
            {
                MessageBox.Show("Save sucessfully");
            }
            else
            {
                MessageBox.Show("Error in saving : " + error);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Contact_UsForm_Load(object sender, EventArgs e)
        {

        }
    }
}
