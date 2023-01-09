using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

// using for dialog Box
namespace Student_Project
{
    public partial class ListForm : Form
    {
        internal int Id = 0;
        MenuObject m_mnuObject = MenuObject.None;
        public ListForm(MenuObject mnuObject)
        {
            InitializeComponent();

            m_mnuObject = mnuObject;
        }

        private void ListForm_Load(object sender, EventArgs e)
        {
            FillGrid();
            SetGrid();


        }

        private void SetColumn(string name, string caption, int width)
        {
            if (gvList.Columns.Contains(name) == false)
            {
                return;
            }


            gvList.Columns[name].HeaderText = caption;
            gvList.Columns[name].Width = width;
            if (width == 0)
            {
                gvList.Columns[name].Visible = false;
            }
        }

        private void SetGrid()
        {
            if (m_mnuObject == MenuObject.Class)
            {
                SetColumn("id", "id", 0);
                SetColumn("class", "Class", 100);
                SetColumn("section", "Section", 100);

            }

            else if (m_mnuObject == MenuObject.Student)
            {
                SetColumn("id", "id", 0);
                SetColumn("name", "Name", 100);
                SetColumn("roll_no", "Roll_No", 100);

                SetColumn("dob", "DOB", 100);
                SetColumn("doj", "DOJ", 100);
                SetColumn("gender", "Gender", 100);
                SetColumn("father_name", "Father_Name", 100);
                SetColumn("fees", "Fees", 100);
                SetColumn("address", "Address", 100);
                SetColumn("mobile_no", "Mobile_No", 100);
                SetColumn("class_id", "Class_name", 100);
                SetColumn("mother_name", "Mother_Name", 100);
               


            }

            else if (m_mnuObject == MenuObject.Teacher)
            {
                SetColumn("id", "id", 0);
                SetColumn("name", "Name", 100);
                SetColumn("email", "Email", 100);
                SetColumn("dob", "DOB", 100);
                SetColumn("doj", "DOJ", 100);
                SetColumn("gender", "Gender", 100);
                SetColumn("subject", "Subject", 100);
                SetColumn("qualification", "Qualification", 100);
                SetColumn("mobile_no", "Mobile_no", 100);
                SetColumn("father_name", "Father_Name", 100);
                SetColumn("address", "Address", 100);               
                SetColumn("mother_name", "Mother_Name", 100); 
                
            }

            else if (m_mnuObject == MenuObject.Fees)
            {
                SetColumn("id", "id", 0);
                SetColumn("Stuent_id", "Student_Name", 100);  
                SetColumn("amount", "Amount", 100);
                SetColumn("date", "Date", 100);
                SetColumn("class_id", "Class_Name", 100);
            }

            else if (m_mnuObject == MenuObject.Attendance)
            {
                SetColumn("id", "id", 0);
                SetColumn("date", "Date", 100);
                SetColumn("status", "Status", 100);
                SetColumn("name", "Name", 100);
                SetColumn("class_id", "Class_Name", 100);
            }

            else if (m_mnuObject == MenuObject.Library)
            {
                SetColumn("id", "id", 0);
                SetColumn("name", "Name", 100);
                SetColumn("title", "Title", 100);
                SetColumn("author", "Author", 100);
                SetColumn("issue_date", "Issue_Date", 100); 
                SetColumn("return_date", "Return_Date", 100);
                SetColumn("class_id", "Class_Name", 100);

            }
            else if (m_mnuObject == MenuObject.AddBook)
            {
                SetColumn("id", "id", 0);
                SetColumn("title", "Title", 100);
                SetColumn("author", "Author", 100);

            }

        }

        private void FillGrid()
        {
            DataSet ds = null;
            if (m_mnuObject == MenuObject.Class)
            {
                ds = Connection.GetData("Select id,class,section from mst_class order by class, section");
            }

            else if (m_mnuObject == MenuObject.Student)
            {
                ds = Connection.GetData("Select st.id, st.name, st.dob, st.reg_date , st.father_name,concat(c.class, ' - ', c.section) as class_name " +
                    " from mst_student st " +
                    " left outer join mst_class c on c.id = st.class_id " +
                    " order by st.id");
            }

            else if (m_mnuObject == MenuObject.Teacher)
            {
                ds = Connection.GetData("Select id, email, dob, doj, gender, subject, qualification, mobile_no, father_name,"+
                    " address, name, mother_name, images from mst_teacher order by name");
            }

            else if (m_mnuObject == MenuObject.Fees)
            {
                //ds = Connection.GetData("Select id, name, class1, amount, date from et_fees order by name");
                ds = Connection.GetData("Select f.id, st.name, f.amount, f.date, concat(c.class, ' - ', c.section) as class_name " +
                    " from et_fees f " +
                    " left outer join mst_class c on c.id = f.class_id " +
                    " left outer join mst_student st on st.id = f.student_id " +
                    " order by f.id ");
            }

            else if (m_mnuObject == MenuObject.Attendance)
            {
                ds = Connection.GetData("Select a.id, st.name,a.status,a.date, concat(c.class, ' - ', c.section) as class_name " +
                   " from et_attendance a " +
                   " left outer join mst_class c on c.id = a.class_id " +
                   " left outer join  mst_student st on st.id =  a.student_id " +
                    "order by a.id");
            }

            else if (m_mnuObject == MenuObject.Library)
            {
                ds = Connection.GetData("Select st.name,b.title, b.author, b.issue_date, b.return_date, concat(c.class, ' - ', c.section) as class_name " +
                   " from mst_student st " +
                   " left outer join mst_class c on c.id = st.class_id " +
                   " left outer join et_library b on b.class_id = st.class_id " +
                    "order by b.id");
            }
            else if (m_mnuObject == MenuObject.AddBook)
            {
                ds = Connection.GetData("Select id, title, author from mst_addbook order by title, author");
            }

            gvList.DataSource = ds.Tables[0];
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            Id = 0;
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (gvList.SelectedRows == null ||
                gvList.SelectedRows.Count <= 0)
            {
                return;
            }

            Id = Convert.ToInt32(gvList.SelectedRows[0].Cells["id"].Value);
            if (Id == 0)
            {
                return;
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }



    }
}
