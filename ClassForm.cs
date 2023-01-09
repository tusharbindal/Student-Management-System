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
    public partial class ClassForm : BaseForm
    {
        
        public ClassForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Class;
        }

        private void ClassForm_Load(object sender, EventArgs e)
        {
            //FormSetup();
        }

        

        protected override void SetControlProperty()
        {
            txtClass.MaxLength = 10;
            txtsection.MaxLength = 10;
        }

        protected override void InitEntry()
        {
            base.InitEntry();
            FormId = 0;
            txtClass.Text = "";
            txtsection.Text = "";
        }

        protected override object ControlToClass()
        {
            ClassInfo cl = new ClassInfo();
            cl.class_name = txtClass.Text;
            cl.section_name = txtsection.Text;

            return cl;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            ClassInfo cl = objControlToClass as ClassInfo;

            if (cl.class_name ==  "")
            {
                MessageBox.Show("Class name cannot be left blank");
                txtClass.Focus();
                return false;
            }

            if (cl.section_name == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtsection.Focus();
                return false;
            }

            return true;
        }

        protected override string SaveAsNew()
        {
            ClassInfo cl = objControlToClass as ClassInfo;
            return Connection.SetData("Insert into mst_class(class, section) values ('" + cl.class_name + "','" + cl.section_name + "') ");

        }
        protected override string Update()
        {

            ClassInfo cl = objControlToClass as ClassInfo;
            return Connection.SetData("Update mst_class Set class = '" + cl.class_name + "', section = '" + cl.section_name + "' where id = " + FormId);
        }

        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from mst_class where ID = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtClass.Text = Convert.ToString(dr["class"]);
            txtsection.Text = Convert.ToString(dr["section"]);

        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_class where id = " + FormId);
        }
       
        private void txtClass_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
