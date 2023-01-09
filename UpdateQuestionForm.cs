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
    public partial class UpdateQuestionForm : Form
    {
        public UpdateQuestionForm()
        {
            InitializeComponent();
        }

        private void UpdateQuestionForm_Load(object sender, EventArgs e)
        {
            cmbSet.Items.Clear();
            DataSet ds = Connection.GetData("Select distinct qset from et_questions");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbSet.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmbSet_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbQuestion.Items.Clear();
            DataSet ds = Connection.GetData("Select qno from et_questions where qset = '" + cmbSet.Text + "' ");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmbQuestion.Items.Add(ds.Tables[0].Rows[i][0].ToString());
            }
        }

        private void cmbQuestion_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select question, optionA, optionB, optionC, optionD, ans from et_questions where qset = '" + cmbSet.Text + "' and qno = '" + cmbQuestion.Text + "' ");
            txtQuestion.Text = ds.Tables[0].Rows[0][0].ToString();
            txtOption1.Text = ds.Tables[0].Rows[0][1].ToString();
            txtOption2.Text = ds.Tables[0].Rows[0][2].ToString();
            txtOption3.Text = ds.Tables[0].Rows[0][3].ToString();
            txtOption4.Text = ds.Tables[0].Rows[0][4].ToString();
            txtAnswer.Text = ds.Tables[0].Rows[0][5].ToString();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();
        }
        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
            cmbSet.SelectedIndex = -1;
            cmbQuestion.SelectedIndex = -1;
            
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if(cmbQuestion.SelectedIndex != -1)
            {
                String qset = cmbSet.Text;
                String qNo = cmbQuestion.Text;
                String question = txtQuestion.Text;
                String option1 = txtOption1.Text;
                String option2 = txtOption2.Text;
                String option3 = txtOption3.Text;
                String option4 = txtOption4.Text;
                String ans = txtAnswer.Text;

                DataSet ds = Connection.GetData(" update et_questions set question = '"+ question + "',  optionA = '" + option1 + "',  optionB = '" + option2 + "',  optionC = '" + option3 + "',  optionD = '" + option4 + "',  ans = '" + ans + "' where qset = '" + qset + "' and qNo = '" + qNo + "'   ");
                MessageBox.Show("Question No : "+qNo+"\n Qusestion Set : "+qset+" \n is Updated. " );
            }
            else
            {
                MessageBox.Show("Select Question First.", "Message !!!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

        }

        private void btnSyn_Click(object sender, EventArgs e)
        {
            UpdateQuestionForm_Load(this, null);
        }

        //private void btnSyn_Click(object sender, EventArgs e)
        //{
        //    UpdateQuestionForm_Load(this, null);
        //}
    }
}
