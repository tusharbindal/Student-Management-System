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
    public partial class AddBookForm : BaseForm
    {
        public AddBookForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.AddBook;
        }

        protected override void SetControlProperty()
        {
            txtTitle.InputType = MyControls.ListSelection.TextInputType.String;
            txtAuthor.InputType = MyControls.ListSelection.TextInputType.String;
        }

        protected override void InitEntry()
        {
            base.InitEntry();
            FormId = 0;
            txtTitle.Text = "";
            txtAuthor.Text = "";
        }

        protected override object ControlToClass()
        {
            AddBook ab = new AddBook();
            ab. title =txtTitle.Text;
            ab.author = txtAuthor.Text;

            return ab;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
           AddBook ab = objControlToClass as AddBook;

            if (ab.title == "")
            {
                MessageBox.Show("Class name cannot be left blank");
                txtTitle.Focus();
                return false;
            }
            if (ab.author == "")
            {
                MessageBox.Show("Section name cannot be left blank");
                txtAuthor.Focus();
                return false;
            }

            return true;
        }

        protected override string SaveAsNew()
        {
            AddBook ab = objControlToClass as AddBook;
            return Connection.SetData("Insert into mst_addbook(title, author) values ('" + ab.title + "','" + ab.author + "') ");

        }
        protected override string Update()
        {

            AddBook ab = objControlToClass as AddBook;
            return Connection.SetData("Update mst_addbook Set title = '" + ab.title + "', author = '" + ab.author + "' where id = " + FormId);
        }


        protected override void Display()
        {
            DataSet ds = Connection.GetData("Select * from mst_addbook where ID = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }

            DataRow dr = ds.Tables[0].Rows[0];
            txtTitle.Text = Convert.ToString(dr["title"]);
            txtAuthor.Text = Convert.ToString(dr["author"]);

        }


        protected override string Delete()
        {
            return Connection.SetData("Delete from mst_addbook where id = " + FormId);
        }

        private void AddBookForm_Load(object sender, EventArgs e)
        {

        }

        private void txtAuthor_Load(object sender, EventArgs e)
        {

        }
    }
}
