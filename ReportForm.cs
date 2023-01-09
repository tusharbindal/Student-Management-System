using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using MyControls;


namespace Student_Project
{
    public partial class ReportForm : Form
    {
      

        public ReportForm()
        {
            InitializeComponent();
        }
        ReportFilter filter = null;
        private void ReportForm1_Load(object sender, EventArgs e)
        {
            filter = new ReportFilter();
            filter.from_date = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            filter.to_date = DateTime.Now;

            cmbReport.Items.Clear();
            cmbReport.Items.Add(new ComboItem(ReportType.StudentReport.GetHashCode().ToString(), "Student Report"));
            cmbReport.Items.Add(new ComboItem(ReportType.TeacherReport.GetHashCode().ToString(), "Teacher Report"));
            cmbReport.Items.Add(new ComboItem(ReportType.FeesReport.GetHashCode().ToString(), "Fees Report"));
            cmbReport.Items.Add(new ComboItem(ReportType.AttendanceReport.GetHashCode().ToString(), "Attendance Report"));
            cmbReport.SelectedIndex = 0;


        }

        private void ShowReport()
        {
            ComboItem SelectedItem = cmbReport.SelectedItem as ComboItem;
            if (SelectedItem == null)
            {
                return;
            }

            ReportType rpt_type = (ReportType)Convert.ToInt32(SelectedItem.ID);
            if (rpt_type == ReportType.None)
            {
                return;
            }

            string query = "";
            string crit = "";

            switch (rpt_type)
            {
                case ReportType.StudentReport:
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                        crit += " And name like '%" + filter.name_like + "%'";
                    }

                    query = "Select * from mst_student Where 1=1 " + crit;
                    break;

                case ReportType.TeacherReport:
                    crit += " And doj >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                    crit += " And doj <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                        crit += " And name like '%" + filter.name_like + "%'";
                    }

                    query = "Select * from mst_teacher Where 1=1 " + crit;
                    break;



                case ReportType.FeesReport:
                    crit += " And date >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                    crit += " And date <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                       // crit += " And name like '%" + filter.name_like + "%'";
                        //crit += " And date >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                        //crit += " And date <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    }
                    query = "Select * from et_fees Where 1=1 " + crit;
                    break;

                case ReportType.AttendanceReport:
                    crit += " And date >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                    crit += " And date <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    if (string.IsNullOrWhiteSpace(filter.name_like) == false)
                    {
                       // crit += " And Name like '%" + filter.name_like + "%'";
                        //crit += " And date >= '" + filter.from_date.ToString("yyyy-MM-dd") + "'";
                        //crit += " And date <= '" + filter.to_date.ToString("yyyy-MM-dd") + "'";
                    }
                    query = "Select * from et_attendance Where 1=1 " + crit;
                    break;
            }

            DataSet ds = Connection.GetData(query);
            if(ds == null)
            {
                MessageBox.Show("No Data");
                return;
            }

            gvReport.DataSource = ds.Tables[0];
            lblTotal.Text = $"Total Records: {gvReport.RowCount}";
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void cmbReport_SelectedIndexChanged(object sender, EventArgs e)
        {
            ShowReport();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            saveFileDialog1.InitialDirectory = "C:";
            saveFileDialog1.Title = "Save as Excel File";
            saveFileDialog1.FileName = "";
            saveFileDialog1.Filter = "Excel Files(2010)|*.xls|Excel Files(2007)|*.xlsx";
            if (saveFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
                ExcelApp.Application.Workbooks.Add(Type.Missing);
                //change properties of the workbook
                ExcelApp.Columns.ColumnWidth = 20;
                //storing hearder part in excel
                for (int i = 1; i < gvReport.Columns.Count + 1; i++)
                {
                    ExcelApp.Cells[1, i] = gvReport.Columns[i - 1].HeaderText;
                }
                //storing each row and column value to excel sheet
                for (int i = 0; i < gvReport.Rows.Count; i++)
                {
                    for (int j = 0; j < gvReport.Columns.Count; j++)
                    {
                        ExcelApp.Cells[i + 2, j + 1] = gvReport.Rows[i].Cells[j].Value.ToString();
                    }
                }
                ExcelApp.ActiveWorkbook.SaveCopyAs(saveFileDialog1.FileName.ToString());
                ExcelApp.ActiveWorkbook.Saved = true;
                ExcelApp.Quit();
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            ComboItem SelectedItem = cmbReport.SelectedItem as ComboItem;
            if (SelectedItem == null)
            {
                return;
            }

            ReportType rpt_type = (ReportType)Convert.ToInt32(SelectedItem.ID);
            if (rpt_type == ReportType.None)
            {
                return;
            }

            ReportFilterForm form = new ReportFilterForm(rpt_type, filter);
            if (form.ShowDialog() == DialogResult.OK)
            {
                ShowReport();
            }
        }

        private void gvReport_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
    

    
    
