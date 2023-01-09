
namespace Student_Project
{
    partial class DashboardForm
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DashboardForm));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.lbltotalbooks = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.lbltotalteacher = new System.Windows.Forms.Label();
            this.btnTeacher = new System.Windows.Forms.Button();
            this.lbltotalclass = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.lbltotalstudent = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.btnStudent = new System.Windows.Forms.Button();
            this.lbltotalfees = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.chartFees = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBar = new System.Windows.Forms.Button();
            this.btnArea = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnPie = new System.Windows.Forms.Button();
            this.btnCandleStick = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cb6 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb5 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb3 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb4 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb2 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.cb1 = new Guna.UI2.WinForms.Guna2CustomRadioButton();
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFees)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbltotalbooks
            // 
            this.lbltotalbooks.AutoSize = true;
            this.lbltotalbooks.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalbooks.Location = new System.Drawing.Point(1109, 232);
            this.lbltotalbooks.Name = "lbltotalbooks";
            this.lbltotalbooks.Size = new System.Drawing.Size(31, 32);
            this.lbltotalbooks.TabIndex = 30;
            this.lbltotalbooks.Text = "0";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.DodgerBlue;
            this.button4.Font = new System.Drawing.Font("Georgia", 12F);
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Image = ((System.Drawing.Image)(resources.GetObject("button4.Image")));
            this.button4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button4.Location = new System.Drawing.Point(875, 58);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(283, 219);
            this.button4.TabIndex = 29;
            this.button4.Text = "Books";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // lbltotalteacher
            // 
            this.lbltotalteacher.AutoSize = true;
            this.lbltotalteacher.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalteacher.Location = new System.Drawing.Point(528, 232);
            this.lbltotalteacher.Name = "lbltotalteacher";
            this.lbltotalteacher.Size = new System.Drawing.Size(31, 32);
            this.lbltotalteacher.TabIndex = 28;
            this.lbltotalteacher.Text = "0";
            // 
            // btnTeacher
            // 
            this.btnTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(204)))), ((int)(((byte)(113)))));
            this.btnTeacher.Font = new System.Drawing.Font("Georgia", 12F);
            this.btnTeacher.ForeColor = System.Drawing.Color.White;
            this.btnTeacher.Image = ((System.Drawing.Image)(resources.GetObject("btnTeacher.Image")));
            this.btnTeacher.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTeacher.Location = new System.Drawing.Point(297, 58);
            this.btnTeacher.Name = "btnTeacher";
            this.btnTeacher.Size = new System.Drawing.Size(283, 219);
            this.btnTeacher.TabIndex = 27;
            this.btnTeacher.Text = "Teacher";
            this.btnTeacher.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnTeacher.UseVisualStyleBackColor = false;
            // 
            // lbltotalclass
            // 
            this.lbltotalclass.AutoSize = true;
            this.lbltotalclass.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalclass.Location = new System.Drawing.Point(816, 231);
            this.lbltotalclass.Name = "lbltotalclass";
            this.lbltotalclass.Size = new System.Drawing.Size(31, 32);
            this.lbltotalclass.TabIndex = 26;
            this.lbltotalclass.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.button2.Font = new System.Drawing.Font("Georgia", 12F);
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button2.Location = new System.Drawing.Point(586, 58);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(283, 219);
            this.button2.TabIndex = 25;
            this.button2.Text = "Class";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // lbltotalstudent
            // 
            this.lbltotalstudent.AutoSize = true;
            this.lbltotalstudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalstudent.Location = new System.Drawing.Point(240, 232);
            this.lbltotalstudent.Name = "lbltotalstudent";
            this.lbltotalstudent.Size = new System.Drawing.Size(31, 32);
            this.lbltotalstudent.TabIndex = 24;
            this.lbltotalstudent.Text = "0";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Maroon;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 1314);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1459, 30);
            this.panel4.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1459, 52);
            this.panel1.TabIndex = 20;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Maroon;
            this.label5.Font = new System.Drawing.Font("Georgia", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(630, 10);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 32);
            this.label5.TabIndex = 0;
            this.label5.Text = "DASHBOARD";
            // 
            // btnStudent
            // 
            this.btnStudent.BackColor = System.Drawing.Color.SteelBlue;
            this.btnStudent.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStudent.ForeColor = System.Drawing.Color.White;
            this.btnStudent.Image = ((System.Drawing.Image)(resources.GetObject("btnStudent.Image")));
            this.btnStudent.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnStudent.Location = new System.Drawing.Point(8, 58);
            this.btnStudent.Name = "btnStudent";
            this.btnStudent.Size = new System.Drawing.Size(283, 219);
            this.btnStudent.TabIndex = 19;
            this.btnStudent.Text = "Student ";
            this.btnStudent.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btnStudent.UseVisualStyleBackColor = false;
            // 
            // lbltotalfees
            // 
            this.lbltotalfees.AutoSize = true;
            this.lbltotalfees.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltotalfees.Location = new System.Drawing.Point(1392, 232);
            this.lbltotalfees.Name = "lbltotalfees";
            this.lbltotalfees.Size = new System.Drawing.Size(31, 32);
            this.lbltotalfees.TabIndex = 32;
            this.lbltotalfees.Text = "0";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Maroon;
            this.button1.Font = new System.Drawing.Font("Georgia", 12F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.button1.Location = new System.Drawing.Point(1161, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 219);
            this.button1.TabIndex = 31;
            this.button1.Text = "Fess";
            this.button1.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // chartFees
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFees.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartFees.Legends.Add(legend1);
            this.chartFees.Location = new System.Drawing.Point(8, 283);
            this.chartFees.Name = "chartFees";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Fees";
            this.chartFees.Series.Add(series1);
            this.chartFees.Size = new System.Drawing.Size(621, 378);
            this.chartFees.TabIndex = 33;
            this.chartFees.Text = "Fees Chart";
            title1.Name = "Title1";
            title1.Text = "Fees Chart";
            this.chartFees.Titles.Add(title1);
            this.chartFees.Click += new System.EventHandler(this.chartFees_Click);
            // 
            // btnBar
            // 
            this.btnBar.Location = new System.Drawing.Point(650, 313);
            this.btnBar.Name = "btnBar";
            this.btnBar.Size = new System.Drawing.Size(99, 37);
            this.btnBar.TabIndex = 36;
            this.btnBar.Text = "Bar";
            this.btnBar.UseVisualStyleBackColor = true;
            this.btnBar.Click += new System.EventHandler(this.btnBar_Click);
            // 
            // btnArea
            // 
            this.btnArea.Location = new System.Drawing.Point(650, 356);
            this.btnArea.Name = "btnArea";
            this.btnArea.Size = new System.Drawing.Size(99, 37);
            this.btnArea.TabIndex = 37;
            this.btnArea.Text = "Area";
            this.btnArea.UseVisualStyleBackColor = true;
            this.btnArea.Click += new System.EventHandler(this.btnArea_Click_1);
            // 
            // btnLine
            // 
            this.btnLine.Location = new System.Drawing.Point(650, 399);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(99, 37);
            this.btnLine.TabIndex = 38;
            this.btnLine.Text = "Line";
            this.btnLine.UseVisualStyleBackColor = true;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnPie
            // 
            this.btnPie.Location = new System.Drawing.Point(650, 442);
            this.btnPie.Name = "btnPie";
            this.btnPie.Size = new System.Drawing.Size(99, 37);
            this.btnPie.TabIndex = 39;
            this.btnPie.Text = "Pie";
            this.btnPie.UseVisualStyleBackColor = true;
            this.btnPie.Click += new System.EventHandler(this.btnPie_Click);
            // 
            // btnCandleStick
            // 
            this.btnCandleStick.Location = new System.Drawing.Point(650, 485);
            this.btnCandleStick.Name = "btnCandleStick";
            this.btnCandleStick.Size = new System.Drawing.Size(99, 37);
            this.btnCandleStick.TabIndex = 40;
            this.btnCandleStick.Text = "Candel";
            this.btnCandleStick.UseVisualStyleBackColor = true;
            this.btnCandleStick.Click += new System.EventHandler(this.btnCandleStick_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(755, 290);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(685, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 41;
            this.pictureBox1.TabStop = false;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.White;
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageSize = new System.Drawing.Size(40, 40);
            this.btnPrevious.Location = new System.Drawing.Point(762, 414);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(54, 83);
            this.btnPrevious.TabIndex = 42;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.White;
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageSize = new System.Drawing.Size(40, 40);
            this.btnNext.Location = new System.Drawing.Point(1389, 414);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(44, 83);
            this.btnNext.TabIndex = 43;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cb6);
            this.panel2.Controls.Add(this.cb5);
            this.panel2.Controls.Add(this.cb3);
            this.panel2.Controls.Add(this.cb4);
            this.panel2.Controls.Add(this.cb2);
            this.panel2.Controls.Add(this.cb1);
            this.panel2.Location = new System.Drawing.Point(1039, 615);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(134, 35);
            this.panel2.TabIndex = 44;
            // 
            // cb6
            // 
            this.cb6.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb6.CheckedState.BorderThickness = 0;
            this.cb6.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb6.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb6.Location = new System.Drawing.Point(115, 10);
            this.cb6.Name = "cb6";
            this.cb6.Size = new System.Drawing.Size(15, 15);
            this.cb6.TabIndex = 5;
            this.cb6.Text = "guna2CustomRadioButton5";
            this.cb6.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb6.UncheckedState.BorderThickness = 2;
            this.cb6.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb6.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb5
            // 
            this.cb5.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.BorderThickness = 0;
            this.cb5.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb5.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb5.Location = new System.Drawing.Point(94, 10);
            this.cb5.Name = "cb5";
            this.cb5.Size = new System.Drawing.Size(15, 15);
            this.cb5.TabIndex = 4;
            this.cb5.Text = "guna2CustomRadioButton5";
            this.cb5.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb5.UncheckedState.BorderThickness = 2;
            this.cb5.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb5.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb3
            // 
            this.cb3.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.BorderThickness = 0;
            this.cb3.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb3.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb3.Location = new System.Drawing.Point(50, 10);
            this.cb3.Name = "cb3";
            this.cb3.Size = new System.Drawing.Size(15, 15);
            this.cb3.TabIndex = 3;
            this.cb3.Text = "guna2CustomRadioButton4";
            this.cb3.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb3.UncheckedState.BorderThickness = 2;
            this.cb3.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb3.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb4
            // 
            this.cb4.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.BorderThickness = 0;
            this.cb4.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb4.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb4.Location = new System.Drawing.Point(73, 10);
            this.cb4.Name = "cb4";
            this.cb4.Size = new System.Drawing.Size(15, 15);
            this.cb4.TabIndex = 2;
            this.cb4.Text = "guna2CustomRadioButton3";
            this.cb4.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb4.UncheckedState.BorderThickness = 2;
            this.cb4.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb4.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb2
            // 
            this.cb2.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.BorderThickness = 0;
            this.cb2.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb2.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb2.Location = new System.Drawing.Point(30, 10);
            this.cb2.Name = "cb2";
            this.cb2.Size = new System.Drawing.Size(15, 15);
            this.cb2.TabIndex = 1;
            this.cb2.Text = "guna2CustomRadioButton2";
            this.cb2.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb2.UncheckedState.BorderThickness = 2;
            this.cb2.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb2.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            // 
            // cb1
            // 
            this.cb1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.BorderThickness = 0;
            this.cb1.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cb1.CheckedState.InnerColor = System.Drawing.Color.White;
            this.cb1.Location = new System.Drawing.Point(9, 10);
            this.cb1.Name = "cb1";
            this.cb1.Size = new System.Drawing.Size(15, 15);
            this.cb1.TabIndex = 0;
            this.cb1.Text = "guna2CustomRadioButton1";
            this.cb1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cb1.UncheckedState.BorderThickness = 2;
            this.cb1.UncheckedState.FillColor = System.Drawing.Color.Transparent;
            this.cb1.UncheckedState.InnerColor = System.Drawing.Color.Transparent;
            this.cb1.CheckedChanged += new System.EventHandler(this.cb1_CheckedChanged);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2DragControl1.TargetControl = this.pictureBox1;
            this.guna2DragControl1.UseTransparentDrag = true;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 30;
            this.guna2Elipse1.TargetControl = this;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 3000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // DashboardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnCandleStick);
            this.Controls.Add(this.btnPie);
            this.Controls.Add(this.btnLine);
            this.Controls.Add(this.btnArea);
            this.Controls.Add(this.btnBar);
            this.Controls.Add(this.chartFees);
            this.Controls.Add(this.lbltotalfees);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbltotalbooks);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.lbltotalteacher);
            this.Controls.Add(this.btnTeacher);
            this.Controls.Add(this.lbltotalclass);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbltotalstudent);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStudent);
            this.Name = "DashboardForm";
            this.Size = new System.Drawing.Size(1459, 1344);
            this.Load += new System.EventHandler(this.DashboardForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartFees)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbltotalbooks;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbltotalteacher;
        private System.Windows.Forms.Button btnTeacher;
        private System.Windows.Forms.Label lbltotalclass;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lbltotalstudent;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnStudent;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbltotalfees;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFees;
        private System.Windows.Forms.Button btnBar;
        private System.Windows.Forms.Button btnArea;
        private System.Windows.Forms.Button btnLine;
        private System.Windows.Forms.Button btnPie;
        private System.Windows.Forms.Button btnCandleStick;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb3;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb4;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb2;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb5;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2CustomRadioButton cb6;
    }
}
