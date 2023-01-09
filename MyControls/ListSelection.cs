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


namespace MyControls
{
    public partial class ListSelection : UserControl
    {

        public enum TextInputType
        {
            String = 0,
            Numeric = 1,
            Email = 2,
            Phone = 3
            //Alphabet = 4

        }
        private TextInputType m_InputType = TextInputType.String;

        public delegate void InvalidKeyCaptureEvent();
        public event InvalidKeyCaptureEvent InvalidKeyCapture;

        public ListSelection()
        {
            InitializeComponent();
        }

        private void ListSelection_Load_1(object sender, EventArgs e)
        {
            txtBox.Width = 200;
            txtBox.Height = 50;
            txtBox.BorderStyle = BorderStyle.Fixed3D;
            txtBox.MaxLength = 0;

            txtBox.AcceptsReturn = true;
            txtBox.AcceptsTab = true;
        }

        public double GetNumValue()
        {
            try
            {
                return Convert.ToDouble(txtBox.Text);
            }
            catch (Exception)
            {
                return 0;
            }

        }

        private void txtBox_Enter(object sender, EventArgs e)
        {
            txtBox.BackColor = Color.Cyan;
            if (txtBox.Text == "Enter your text here")
            {
                txtBox.Text = "";

                txtBox.ForeColor = Color.Black;

            }
        }

        private void txtBox_Leave(object sender, EventArgs e)
        {
                txtBox.BackColor = Color.PapayaWhip;

                if (txtBox.Text == "")
                {
                    txtBox.Text = "Enter your text here";

                    txtBox.ForeColor = Color.Silver;
                }
            }
      
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (m_InputType == TextInputType.Numeric)
            {
                if (Char.IsDigit(ch) || ch == 8 || ch == '.')
                {
                    e.Handled = false;//allow
                }
                else
                {
                    e.Handled = true;//not allow
                    if (InvalidKeyCapture != null)
                    {
                        InvalidKeyCapture();
                    }
                }
            }
            /*else if (m_InputType == TextInputType.Alphabet)
            {
                if (Char.IsDigit(ch) || ch == 8 || ch == '.')
               {
                    e.Handled = false;//allow
                }
                else
                {
                    e.Handled = true;//not allow
                    if (InvalidKeyCapture != null)
                    {
                        InvalidKeyCapture();
                    }
                }*/
           // }
            else if (m_InputType == TextInputType.Phone)
            {
                if (Char.IsDigit(ch) || ch == (Char)Keys.Back)
                {
                    e.Handled = false;//allow
                }
                else
                {
                    e.Handled = true;//Not allow
                    if (InvalidKeyCapture != null)
                    {
                        InvalidKeyCapture();
                    }
                }
            }
        }

        private void txtBox_Validating(object sender, CancelEventArgs e)
        {
            if (AllowBlank == false && string.IsNullOrWhiteSpace(txtBox.Text))
            {
                MessageBox.Show("Blank value is not allowed");
                e.Cancel = true;
                return;
            }

            if (m_InputType == TextInputType.Email)
            {
                if (IsValidEmail(txtBox.Text) == false)
                {
                    e.Cancel = true;
                }
            }
            else if (m_InputType == TextInputType.Numeric)
            {
                if (AllowNegative == false)
                {
                    if (string.IsNullOrWhiteSpace(txtBox.Text) == false &&
                        Convert.ToDouble(txtBox.Text) < 0)
                    {
                        MessageBox.Show("Negative value is not allowed");
                        e.Cancel = true;
                    }
                }
            }
        }

        public static bool IsValidEmail(String email)
        {
            if (email.Contains("@") &&
                email.Contains("."))
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        [Browsable(true)]
        [DefaultValue(TextInputType.String)]
        public TextInputType InputType
        {
            get
            {
                return m_InputType;
            }
            set
            {
                m_InputType = value;
            }
        }

        private bool m_AllowBlank = true;
        [Browsable(true)]
        [DefaultValue(true)]
        public bool AllowBlank
        {
            get
            {
                return m_AllowBlank;
            }
            set
            {
                m_AllowBlank = value;
            }
        }

        private bool m_AllowNegative = true;
        [Browsable(true)]
        [DefaultValue(true)]
        public bool AllowNegative
        {
            get
            {
                return m_AllowNegative;
            }
            set
            {
                m_AllowNegative = value;
            }
        }
        public override string Text
        {
            get
            {
                return txtBox.Text;
            }

            set
            {
                txtBox.Text = value;
            }
        }



        private void txtBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("Tab");
            }
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
