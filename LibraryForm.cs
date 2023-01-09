using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyControls;



namespace Student_Project
{
    public partial class LibraryForm : BaseForm
    {
        //private int FormID = 0;
        public LibraryForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Library;
        }
        protected override void SetControlProperty()
        {
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds1 = Connection.GetData("Select name from mst_student order by id");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    cmbName.Items.Add(dr["name"]);
                }
            }

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

            //For connect the database add class and show data in student class
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds2 = Connection.GetData("Select title as name from mst_addbook order by id");
            if (ds2 != null && ds2.Tables.Count > 0 && ds2.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds2.Tables[0].Rows)
                {
                    txtTitle.Items.Add(dr["name"]);
                }
            }

            //For connect the database add class and show data in student class
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds3 = Connection.GetData("Select author as name from mst_addbook order by author");
            if (ds3 != null && ds.Tables.Count > 0 && ds3.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds3.Tables[0].Rows)
                {
                    txtAuthor.Items.Add(dr["name"]);
                }
            }
            txtTitle.MaxLength = 20;
            cmbClass.MaxLength = 10;
            cmbName.MaxLength = 10;
            txtAuthor.MaxLength = 40;

        }

        protected override void InitEntry()
        {
            dateTimePickerBooks.Text = "";
            cmbName.Text = "";
            txtTitle.Text = "";
            txtAuthor.Text = "";

            dateTimeReturn.Text = "";
            cmbClass.Text = "";
        }

        protected override object ControlToClass()
        {
            Library b = new Library();

            b.title = txtTitle.Text;
            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem != null)
            {
                b.classID = Convert.ToInt32(SelectedItem.ID);
            }
            b.issue_date = Convert.ToDateTime(dateTimePickerBooks.Text);
            b.name = cmbName.Text;
            b.author = txtAuthor.Text;

            b.return_date = Convert.ToDateTime(dateTimeReturn.Text);
            return b;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Library b = objControlToClass as Library;
            if (b.title == "")
            {
                MessageBox.Show("Title name cannot be left blank");
                txtTitle.Focus();
                return false;
            }
            //if (b.classID == "")
            //{
            //    MessageBox.Show("Class name cannot be left blank");
            //    cmbClass.Focus();
            //    return false;
            //}
            if (b.name == "")
            {
                MessageBox.Show("Student name cannot be left blank");
                cmbName.Focus();
                return false;
            }

            return true;
        }

        protected override string SaveAsNew()
        {
            Library b = objControlToClass as Library;
            return Connection.SetData("Insert into et_library(title, class_id, name, author, issue_date, return_date )" + "" +
                    " values ('" + b.title + "', '" + b.classID + "','" + b.name + "', '" + b.author + "','" + b.issue_date.ToString("yyyy-MM-dd") + "','" + b.return_date.ToString("yyyy-MM-dd") + "') ");
        }

        protected override string Update()
        {
            Library b = objControlToClass as Library;
            return Connection.SetData("Update et_library Set title = '" + b.title + "',class_id; = '" + b.classID + "',  name = '" + b.name + "',"+
                " author = '" + b.author + "' , issue_date = '" + b.issue_date.ToString("yyyy-MM-dd") + "',  return_date = '" + b.return_date.ToString("yyyy-MM-dd") + "' where id = " + FormId);
        }

        protected override void Display()
        {
            //DataSet ds = Connection.GetData("Select * from et_library where ID = " + FormId);
            DataSet ds = Connection.GetData("Select st.id, st.name,b.title, b.author, b.issue_date, b.return_date, concat(c.class, ' - ', c.section) as class_name " +
                  " from mst_student st " +
                  " left outer join mst_class c on c.id = st.class_id " +
                  " left outer join et_library b on b.class_id = st.class_id " +
                   "where b.id = " + FormId);

            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            txtTitle.Text = Convert.ToString(dr["title"]);
            ControlUtility.SetComboItem(cmbClass, Convert.ToString(dr["class_id"]));
            dateTimePickerBooks.Text = Convert.ToString(dr["issue_date"]);
            dateTimePickerBooks.Text = Convert.ToString(dr["return_date"]);
            cmbName.Text = Convert.ToString(dr["name"]);
            txtAuthor.Text = Convert.ToString(dr["author"]);

           
        }
        protected override string Delete()
        {
            return Connection.SetData("Delete from et_library where id = " + FormId);
        }

        private void BooksForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}