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
    public partial class BaseForm : Form
    {
        internal int FormId = 0;
        internal object objControlToClass = null;
        internal MenuObject FormMenuObject = MenuObject.None;
        public BaseForm()
        {
            InitializeComponent();
        }

        private void BaseForm_Load(object sender, EventArgs e)
        {
            FormSetup(); 
            btnSave.Enabled = true;
            btnOpen.Enabled = true;
            btnClear.Enabled = true;
            btnDelete.Enabled = false;
            btnExit.Enabled = true;



        }

        private void FormSetup()
        {
            SetControlProperty();
            InitEntry();
        }

        virtual protected void SetControlProperty()
        {
        }

        virtual protected void InitEntry()
        {
            FormId = 0;
        }

        virtual protected bool InputIsValid()
        {
            objControlToClass = ControlToClass();
            return true;
        }

        virtual protected object ControlToClass()
        {
            return null;
        }

        private bool Save()
        {
            objControlToClass = ControlToClass();

            string error = "";

            if (FormId == 0)
            {
                error = SaveAsNew();
            }
            else
            {
                error = Update();
            }

            if (error == "")
            {
                MessageBox.Show("Save sucessfully");
                return true;
            }
            else
            {
                MessageBox.Show("Error in saving : " + error);
                return false;
            }

        }

        virtual protected string SaveAsNew()
        {

            return "";
        }

        virtual protected string Update()
        {

            return "";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (InputIsValid() == false)
            {
                return;
            }

            if (Save() == false)
            {
                return;
            }

            if (FormId == 0)//New Mode
            {
                InitEntry();

                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnClear.Enabled = true;
                btnDelete.Enabled = false;
                btnExit.Enabled = true;
            }
            else
            {
                InitEntry();
                OpenList();
            }
        }

        private void OpenList()
        {
            ListForm frm = new ListForm(FormMenuObject);
            frm.StartPosition = FormStartPosition.CenterScreen;
            if (frm.ShowDialog() == DialogResult.OK)
            {
                InitEntry();
                FormId = frm.Id;
                Display();


                btnSave.Enabled = true;
                btnOpen.Enabled = false;
                btnClear.Enabled = true;
                btnDelete.Enabled = true;
                btnExit.Enabled = true;
            }
            else
            {
                btnSave.Enabled = true;
                btnOpen.Enabled = true;
                btnClear.Enabled = true;
                btnDelete.Enabled = false;
                btnExit.Enabled = true;
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            OpenList();
        }

        virtual protected void Display()
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            if (FormId == 0)
            {
                InitEntry();
            }
            else
            {
                InitEntry();
                OpenList();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        virtual protected string Delete()
        {
            return "";
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (FormId == 0)
            {
                return;
            }

            string error = Delete();
            if (error == "")
            {
                MessageBox.Show("Delete successfully");
                InitEntry();
                OpenList();
            }
            else
            {
                MessageBox.Show("Error in delete: " + error);
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
