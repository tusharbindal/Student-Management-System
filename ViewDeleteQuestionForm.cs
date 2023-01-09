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
    public partial class ViewDeleteQuestionForm : Form
    {
        int id, questionNo;
        public ViewDeleteQuestionForm()
        {
            InitializeComponent();
        }

       
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ViewDeleteQuestionForm_Load(object sender, EventArgs e)
        {
            cmbSet.Items.Clear();
            cmbSet.Items.Add("All Questions");
            DataSet ds = Connection.GetData("Select distinct qset from et_questions");

            for (int i=0; i<ds.Tables[0].Rows.Count; i++)
            { 
               cmbSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }

        }

        private void cmbSet_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if(cmbSet.SelectedIndex !=0)
            {
                DataSet ds = Connection.GetData("Select id, qNo, question, optionA, optionB, optionC, optionD, ans from et_questions where qset = '" + cmbSet.Text + "'");
                dataGridView1.DataSource = ds.Tables[0];
            }

            else
            {
                DataSet ds = Connection.GetData("Select id, qNo, question, optionA, optionB, optionC, optionD, ans from et_questions");
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

       

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                id = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
                questionNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch
            {

            }
        }

       
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you Sure", "Delete Confirmation !", MessageBoxButtons.YesNo,MessageBoxIcon.Warning)==DialogResult.Yes)
            {
                DataSet ds = Connection.GetData("Delete from et_questions where id = " + id + " and qno = '" + questionNo + "' ");
                MessageBox.Show("Question Deleated..");
            }
        }
    }
}
