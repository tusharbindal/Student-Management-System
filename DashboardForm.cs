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
    public partial class DashboardForm : UserControl
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private int ImageNumber = 1;
        private void LoadNextImages()
        {
            timer1.Start();
            ImageNumber++;
            if(ImageNumber > 6)
            {
                ImageNumber = 1;
            }
            pictureBox1.ImageLocation = string.Format(@"D:\tushar Bindal\Student_Project\Images\" + ImageNumber + ".jpg ");
            LoadChecked();
        }

        private void LoadPreviousImages()
        {
            timer1.Start();
            ImageNumber--;
            if (ImageNumber < 1)
            {
                ImageNumber = 6;
            }
            pictureBox1.ImageLocation = string.Format(@"D:\tushar Bindal\Student_Project\Images\" + ImageNumber + ".jpg ");
            LoadChecked();
        }
        private void LoadChecked ()
        {
            if(ImageNumber == 1) { cb1.Checked = true; }
            else if (ImageNumber == 2) { cb2.Checked = true; }
            else if (ImageNumber == 3) { cb3.Checked = true; }
            else if (ImageNumber == 4) { cb4.Checked = true; }
            else if (ImageNumber == 5) { cb5.Checked = true; }
            else if (ImageNumber == 6) { cb6.Checked = true; }
        }
        private void ChangedCheck()
        {
            timer1.Start();
            if(cb1.Checked == true) { ImageNumber = 1; }
            else if (cb2.Checked == true) { ImageNumber = 2; }
            else if (cb3.Checked == true) { ImageNumber = 3; }
            else if (cb4.Checked == true) { ImageNumber = 4; }
            else if (cb5.Checked == true) { ImageNumber = 5; }
            else if (cb6.Checked == true) { ImageNumber = 6; }
            pictureBox1.ImageLocation = string.Format(@"D:\tushar Bindal\Student_Project\Images\" + ImageNumber + ".jpg ");
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FillChart()
        {
            DataSet ds = Connection.GetData("select fees_month,fees_amount from fees_chart");
            chartFees.DataSource = ds;
            chartFees.Series["Fees"].XValueMember = "fees_month";
            chartFees.Series["Fees"].YValueMembers = "fees_amount";
            chartFees.Titles.Add("fees_chart");
        }
        private void DashboardForm_Load(object sender, EventArgs e)
        {

            cb1.Checked = true;
            pictureBox1.ImageLocation = string.Format(@"D:\tushar Bindal\Student_Project\Images\" + ImageNumber + ".jpg ");
            FillChart();

            DataSet ds = Connection.GetData("Select Count(*) from mst_student");
            Int32 rows_count = Convert.ToInt32(ds.Tables[0].Rows[0][0]);
            lbltotalstudent.Text = rows_count.ToString();

            DataSet ds1 = Connection.GetData("Select Count(*) from mst_Teacher");
            Int32 rows_count1 = Convert.ToInt32(ds1.Tables[0].Rows[0][0]);
            lbltotalteacher.Text = rows_count1.ToString();

            DataSet ds2 = Connection.GetData("Select Count(*) from mst_class");
            Int32 rows_count2 = Convert.ToInt32(ds2.Tables[0].Rows[0][0]);
            lbltotalclass.Text = rows_count2.ToString();

            DataSet ds3 = Connection.GetData("Select Count(*) from mst_addbook");
            Int32 rows_count3 = Convert.ToInt32(ds3.Tables[0].Rows[0][0]);
           lbltotalbooks.Text = rows_count3.ToString();

            DataSet ds4 = Connection.GetData("Select Count(*) from et_fees");
            Int32 rows_count4 = Convert.ToInt32(ds4.Tables[0].Rows[0][0]);
            lbltotalfees.Text = rows_count4.ToString();

          

        }

        private void btnL_Click(object sender, EventArgs e)
        {

        }

        private void btnBar_Click(object sender, EventArgs e)
        {
            chartFees.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;
        }

        private void btnArea_Click_1(object sender, EventArgs e)
        {
            chartFees.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Area;

        }

        private void btnLine_Click(object sender, EventArgs e)
        {
            chartFees.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;

        }

        private void btnPie_Click(object sender, EventArgs e)
        {
            chartFees.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;

        }

        private void btnCandleStick_Click(object sender, EventArgs e)
        {

            chartFees.Series["Fees"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Candlestick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LoadNextImages();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadPreviousImages();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            LoadNextImages();
        }

        private void cb1_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Stop();
            ChangedCheck();
        }

        private void chartFees_Click(object sender, EventArgs e)
        {

        }
    }
}
