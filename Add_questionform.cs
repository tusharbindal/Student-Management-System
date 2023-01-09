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
    public partial class Add_questionform : Form
    {
        Int64 questionNo = 1;
        public Add_questionform()
        {
            InitializeComponent();
            
        }

        private void Add_questionform_Load(object sender, EventArgs e)
        {
            DataSet ds = Connection.GetData("Select max(qset) from et_questions");
            if(ds.Tables[0].Rows.Count!=0 && ds.Tables[0].Rows[0][0].ToString()!="")
            {
                Int64 id = Int64.Parse(ds.Tables[0].Rows[0][0].ToString());
                txtSet.Text = (id + 1).ToString();
            }
            else
            {
                txtSet.Text = "1";
            }
            lblQuestion.Text = questionNo.ToString();
            lblNoSet.Visible = false;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            String qset = txtSet.Text;
            String qno = questionNo.ToString();
            string question = txtQuestion.Text;
            String option1 = txtOption1.Text;
            String option2 = txtOption2.Text;
            String option3 = txtOption3.Text;
            String option4 = txtOption4.Text;
            String ans = txtAnswer.Text;

            DataSet ds = Connection.GetData("insert into et_questions (qset, qno, question, optionA, optionB, optionC, optionD, ans) values ('" + qset + "', '" + qno + "', '" + question + "', '" + option1 + "', '" + option2 + "', '" + option3 + "', '" + option4 + "', '" + ans + "')");
            MessageBox.Show("Question Added.");
            clearAll();
            questionNo++;

            lblQuestion.Text = questionNo.ToString();
        }
        public void clearAll()
        {
            txtQuestion.Clear();
            txtOption1.Clear();
            txtOption2.Clear();
            txtOption3.Clear();
            txtOption4.Clear();
            txtAnswer.Clear();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("UnSaved Data Will be Lost", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)== DialogResult.Yes)
            {
                clearAll();
            }
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Set will be Changed.", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                txtSet.Text = (Int64.Parse(txtSet.Text.ToString()) + 1).ToString();
                lblQuestion.Text = "1";
            }
        }

        private void txtSet_TextChanged(object sender, EventArgs e)
        {
            clearAll();
            if(txtSet.Text!="")
            { 
                DataSet ds = Connection.GetData("Select qno from et_questions where qset = '" + txtSet.Text + "' ");
                if(ds.Tables[0].Rows.Count!=0 &&  ds.Tables[0].Rows[0][0].ToString()!= "")
                {
                    lblQuestion.Text = (ds.Tables[0].Rows.Count + 1).ToString(); 
                    questionNo = Int64.Parse(lblQuestion.Text.ToString());
                }
                else
                {
                    lblQuestion.Text = "1";
                    questionNo = Int64.Parse(lblQuestion.Text.ToString());
                    lblNoSet.Visible = true;
                }
            }
        }
    }
}
