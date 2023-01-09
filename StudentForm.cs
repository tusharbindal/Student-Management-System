using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;

namespace Student_Project
{
    public partial class StudentForm : BaseForm
    {

        public StudentForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Student;
        }

        protected override void SetControlProperty()
        {
            //For connect the database add class and show data in student class
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select id, concat(class, ' - ', section) as name from mst_class order by class");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbClass.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                }
            }

            txtFather.InputType = MyControls.ListSelection.TextInputType.String;
            cmbGender.MaxLength = 20;
            txtAddress.MaxLength = 100;
            txtStudentName.InputType = MyControls.ListSelection.TextInputType.String;
            txtMobile.InputType = MyControls.ListSelection.TextInputType.Phone;
            cmbClass.MaxLength = 10;
            txtMother.InputType = MyControls.ListSelection.TextInputType.String;
            txtFees.InputType = MyControls.ListSelection.TextInputType.Numeric;
            txtReligion.InputType = MyControls.ListSelection.TextInputType.String;
        }

        protected override void InitEntry()
        {
            base.InitEntry();
            dateTimePickerDOB.Text = "";
            dateTimePickerReg.Text = "";
            cmbGender.Text = "";
            txtFather.Text = "";
            txtAddress.Text = "";
            txtStudentName.Text = "";
            txtMobile.Text = "";
            cmbClass.Text = "";
            txtMother.Text = "";
            txtFees.Text = "";
            txtReligion.Text = "";
            pictureBoxStudent.Tag = "";

            
        }
        protected override object ControlToClass()
        {
            Student st = new Student();
            st.dob = Convert.ToDateTime(dateTimePickerDOB.Text.ToString());
            st.reg_date = Convert.ToDateTime(dateTimePickerReg.Text.ToString());
            st.gender = cmbGender.Text;
            st.father_name = txtFather.Text;
            st.fees = Convert.ToInt32(txtFees.Text.ToString());
            st.religion = txtReligion.Text;
            st.address = txtAddress.Text;
            st.name = txtStudentName.Text;
            st.mobile_no = txtMobile.Text;
            st.images = Convert.ToString(pictureBoxStudent.Tag).Replace("\\", "\\\\");
            

            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem != null)
            {
                st.classID = Convert.ToInt32(SelectedItem.ID);
            }

            st.mother_name = txtMother.Text;
            return st;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Student st = objControlToClass as Student;

            if (st.name == "")
            {
                MessageBox.Show("Student name cannot be left blank");
                txtStudentName.Focus();
                return false;
            }

            if (st.address == "")
            {
                MessageBox.Show("Address name cannot be left blank");
                txtAddress.Focus();
                return false;
            }
            if (st.classID == 0)
            {
                MessageBox.Show("Class name cannot be left blank");
                cmbClass.Focus();
                return false;
            }

            return true;

        }

        protected override string SaveAsNew()
        {

            Student st = objControlToClass as Student;
            return Connection.SetData("Insert into mst_student(name, dob,  gender,  father_name, fees, address, mobile_no, mother_name, class_id, religion, reg_date, images )" +
           " values ('" + st.name + "', '" + st.dob.ToString("yyyy-MM-dd") + "','" + st.gender + "', '" + st.father_name + "', '" + st.fees + "', "+
           "'" + st.address + "', '" + st.mobile_no + "',  '" + st.mother_name + "', " + st.classID + ",'" + st.religion + "' ,'" + st.reg_date.ToString("yyyy-MM-dd") + "',"+
           " '" + st.images + "') ");
        }

        protected override string Update()
        {
            Student st = objControlToClass as Student;
            return Connection.SetData("Update mst_student Set  name = '" + st.name + "', dob ='" + st.dob.ToString("yyyy-MM-dd") + "',"+
                "  gender = '" + st.gender + "', father_name = '" + st.father_name + "', fees = '" + st.fees + "', address = '" + st.address + "', "+
                " mobile_no = '" + st.mobile_no + "', mother_name = '" + st.mother_name + "',  class_id = " + st.classID + ","+
                " religion ='" + st.religion + "' , reg_date = '" + st.reg_date.ToString("yyyy-MM-dd") + "' ,"+
                " images= '" + st.images + "'  where id = " + FormId);
        }
        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select st.*, st.reg_date , concat(c.class, ' - ', c.section) as class_name " +
                " from mst_student st " +
                " left outer join mst_class c on c.id = st.class_id " +
                " where st.id = " + FormId);

            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtStudentName.Text = Convert.ToString(dr["name"]);
            dateTimePickerDOB.Text = Convert.ToString(dr["dob"]);
           
            cmbGender.Text = Convert.ToString(dr["gender"]);
            txtFather.Text = Convert.ToString(dr["father_name"]);
            txtFees.Text = Convert.ToString(dr["fees"]);
            txtAddress.Text = Convert.ToString(dr["address"]);
            txtMobile.Text = Convert.ToString(dr["mobile_no"]);
            ControlUtility.SetComboItem(cmbClass, Convert.ToString(dr["class_id"]));
            txtMother.Text = Convert.ToString(dr["mother_name"]);
            txtReligion.Text = Convert.ToString(dr["religion"]);
            dateTimePickerReg.Text = Convert.ToString(dr["reg_date"]);

        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_student where id = " + FormId);
        }
        private void StudentForm_Load(object sender, EventArgs e)
        {


        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {

           // openFileDialog1.Filter = "Select image(*.jpg; .png; .Gif) | .jpg; .png; *.Gif";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                pictureBoxStudent.Image = Image.FromFile(openFileDialog1.FileName);
                pictureBoxStudent.Tag = openFileDialog1.FileName;
            }
        }

        
    }
}