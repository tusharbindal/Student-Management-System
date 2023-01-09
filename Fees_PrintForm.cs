using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Printing;


namespace Student_Project
{
    public partial class Fees_PrintForm : Form
    {
        public string Date, S_Name, Class, Date1, Amount;

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Rectangle pagearea = e.PageBounds;
            e.Graphics.DrawImage(memoryimg,(pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
           // e.Graphics.DrawImage(memoryimg, (pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
            e.Graphics.DrawString(panelPrint.Text, new Font("Microsoft Sans Serif", 18, FontStyle.Bold), Brushes.Black, new Point(10, 10));
            // e.Graphics.DrawImage
        }



        private void pictureBoxPrint_Click_1(object sender, EventArgs e)
        {
            Print(this.panelPrint);
        }

        

        private void pictureBoxPrint_MouseHover_1(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(pictureBoxPrint, "Print");
        }

       

        public Fees_PrintForm()
        {
            InitializeComponent();
            Date = DateTime.Now.ToString("yyyy-MM-dd");
        }

        private void panelPrint_Paint(object sender, PaintEventArgs e)
        {

        }

        //private void printDocument1_PrintPage_2(object sender, PrintPageEventArgs e)
        //{
        //    Rectangle.pagearea = e.PageBounds;
        //    e.Graphics.DrawImage(memoryimg.(pagearea.Width / 2) - (this.panelPrint.Width / 2), this.panelPrint.Location.Y);
        //}

        private void Print(Panel pnl)
        {
            PrinterSettings ps = new PrinterSettings();
            panelPrint = pnl;
            getprintarea(pnl);
            printPreviewDialog1.Document = printDocument1;
            printDocument1.PrintPage += new PrintPageEventHandler(printDocument1_PrintPage);
            printPreviewDialog1.ShowDialog();
        }

        private Bitmap memoryimg;
        private void getprintarea(Panel pnl)
        {
            memoryimg = new Bitmap(pnl.Width, pnl.Height);
            pnl.DrawToBitmap(memoryimg, new Rectangle(0, 0, pnl.Width, pnl.Height));
        }


        private void Fees_PrintForm_Load(object sender, EventArgs e)
        {
            labelDat.Text = Date;
            labelName.Text = S_Name;
            labelClass.Text = Class;
            labelDate.Text = Date1;
            labelAmount.Text = Amount;

        }
    }
}
