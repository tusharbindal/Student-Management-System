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
    public partial class FeesForm : BaseForm
    {
        //private int FormID = 0;
        public FeesForm()
        {
            InitializeComponent();
            FormMenuObject = MenuObject.Fees;
        }

        protected override void SetControlProperty()
        {
            cmbName.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds1 = Connection.GetData("Select id, name from mst_student");
            if (ds1 != null && ds1.Tables.Count > 0 && ds1.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds1.Tables[0].Rows)
                {
                    //cmbName.Items.Add(dr["name"]);
                    cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                }
            }
            cmbClass.DropDownStyle = ComboBoxStyle.DropDownList;
            DataSet ds = Connection.GetData("Select id, concat(class, ' - ', section) as name from mst_class order by class");
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                foreach (DataRow dr in ds.Tables[0].Rows)
                {
                    cmbClass.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
                }
            }
            cmbName.MaxLength = 10;
            txtAmount.MaxLength = 10;
            cmbClass.MaxLength = 20;
        }

        protected override void InitEntry()
        {
            base.InitEntry();
            dateTimePickerDate.Text = "";
            cmbName.Text = "";
            txtAmount.Text = "";
            cmbClass.Text = "";
        }

        protected override object ControlToClass()
        {
            Fees f = new Fees();
            f.date = Convert.ToDateTime(dateTimePickerDate.Text);
            ComboItem SelectedItem1 = cmbName.SelectedItem as ComboItem;
            if (SelectedItem1 != null)
            {
                f.studentID = Convert.ToInt32(SelectedItem1.ID);
            }
            f.amount = Convert.ToInt32(txtAmount.Text);

            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem != null)
            {
                f.classID = Convert.ToInt32(SelectedItem.ID);
            }
            return f;
        }

        protected override bool InputIsValid()
        {
            base.InputIsValid();
            Fees f = objControlToClass as Fees;
            //if (f.name == "")
            //{
            //    MessageBox.Show("Student name cannot be left blank");
            //    cmbName.Focus();
            //    return false;
            //}

            //if (f.classID == "")
            //{
            //    MessageBox.Show("Class name cannot be left blank");
            //    cmbClass.Focus();
            //    return false;
            //}

            return true;
        }

        protected override string SaveAsNew()
        {
           
            Fees f = objControlToClass as Fees;
            return Connection.SetData("Insert into et_fees(date,amount, class_id,student_id)" + "" +
                "values ('" + f.date.ToString("yyyy-MM-dd") + "',  '" + f.amount + "','" + f.classID + "','" + f.studentID + "') ");
           
            
          
        }

        protected override string Update()
        {
            Fees f = objControlToClass as Fees;
            return Connection.SetData("Update et_fees Set date = '" + f.date.ToString("yyyy-MM-dd") + "', amount = '" + f.amount + "'  class_id = '" + f.classID + "', student_id = '" + f.studentID + "' where id = " + FormId);
        }

        protected override void Display()
        {

            DataSet ds = Connection.GetData("Select f.id, st.name, f.amount, f.date, concat(c.class, ' - ', c.section) as class_name " +
            " from et_fees f " +
                    " left outer join mst_class c on c.id = f.class_id " +
                    " left outer join mst_student st on st.id = f.student_id " +
                    "where f.id = " + FormId);
            if (ds == null ||
                ds.Tables.Count <= 0 ||
                ds.Tables[0].Rows.Count <= 0)
            {
                return;
            }
            DataRow dr = ds.Tables[0].Rows[0];
            ControlUtility.SetComboItem(cmbName, Convert.ToString(dr["student_id"]));
            ControlUtility.SetComboItem(cmbClass, Convert.ToString(dr["id"]));
            txtAmount.Text = Convert.ToString(dr["amount"]);
            dateTimePickerDate.Text = Convert.ToString(dr["date"]);
            
            
        }

        protected override string Delete()
        {
            return Connection.SetData("Delete from et_fees where id = " + FormId);
        }

        private void FeesForm_Load(object sender, EventArgs e)
        {
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            Fees_PrintForm frm = new Fees_PrintForm();
            if (cmbName.SelectedIndex == -1)
            {
                frm.S_Name = "";
            }
            else
            {
                frm.S_Name = cmbName.SelectedItem.ToString();
            }
          
            if (cmbClass.SelectedIndex == -1)
            {
                frm.Class = "";
            }
            else
            {
                frm.Class = cmbClass.SelectedItem.ToString();
            }
            frm.Date1 = dateTimePickerDate.Text;
            frm.Amount = txtAmount.Text;

            frm.ShowDialog();
        }

        private void cmbClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbName.Items.Clear();

            ComboItem SelectedItem = cmbClass.SelectedItem as ComboItem;
            if (SelectedItem == null)
            {
                return;
            }


            DataSet ds = Connection.GetData("Select name, id from mst_student where class_id = " + SelectedItem.ID);
            if (ds == null)
            {
                return;
            }

            foreach (DataRow dr in ds.Tables[0].Rows)
            {
                cmbName.Items.Add(new ComboItem(Convert.ToString(dr["id"]), Convert.ToString(dr["name"])));
            }
        }
    }
}