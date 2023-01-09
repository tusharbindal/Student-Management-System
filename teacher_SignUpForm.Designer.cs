
namespace Student_Project
{
    partial class teacher_SignUpForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCross = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegisterTeacher = new System.Windows.Forms.Button();
            this.checkTeacher = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblbackTeacher = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnClearRegister = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTeacherConf = new System.Windows.Forms.TextBox();
            this.txtTeacherName = new System.Windows.Forms.TextBox();
            this.txtMobileTeacher = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtEmailTeacher = new System.Windows.Forms.TextBox();
            this.txtTeacherPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Maroon;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(348, 15);
            this.panel1.TabIndex = 106;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Maroon;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 773);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(348, 15);
            this.panel2.TabIndex = 107;
            // 
            // btnCross
            // 
            this.btnCross.AutoSize = true;
            this.btnCross.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCross.ForeColor = System.Drawing.Color.Red;
            this.btnCross.Location = new System.Drawing.Point(303, 17);
            this.btnCross.Name = "btnCross";
            this.btnCross.Size = new System.Drawing.Size(35, 38);
            this.btnCross.TabIndex = 108;
            this.btnCross.Text = "X";
            this.btnCross.Click += new System.EventHandler(this.btnCross_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("MS UI Gothic", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Maroon;
            this.label4.Location = new System.Drawing.Point(44, 72);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 33);
            this.label4.TabIndex = 118;
            this.label4.Text = "Teacher Register";
            // 
            // btnRegisterTeacher
            // 
            this.btnRegisterTeacher.BackColor = System.Drawing.Color.Maroon;
            this.btnRegisterTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRegisterTeacher.FlatAppearance.BorderSize = 0;
            this.btnRegisterTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegisterTeacher.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegisterTeacher.ForeColor = System.Drawing.Color.White;
            this.btnRegisterTeacher.Location = new System.Drawing.Point(49, 576);
            this.btnRegisterTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnRegisterTeacher.Name = "btnRegisterTeacher";
            this.btnRegisterTeacher.Size = new System.Drawing.Size(216, 35);
            this.btnRegisterTeacher.TabIndex = 115;
            this.btnRegisterTeacher.Text = "REGISTER";
            this.btnRegisterTeacher.UseVisualStyleBackColor = false;
            this.btnRegisterTeacher.Click += new System.EventHandler(this.btnRegisterTeacher_Click_1);
            // 
            // checkTeacher
            // 
            this.checkTeacher.AutoSize = true;
            this.checkTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkTeacher.Location = new System.Drawing.Point(179, 534);
            this.checkTeacher.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkTeacher.Name = "checkTeacher";
            this.checkTeacher.Size = new System.Drawing.Size(143, 24);
            this.checkTeacher.TabIndex = 114;
            this.checkTeacher.Text = "Show Password";
            this.checkTeacher.UseVisualStyleBackColor = true;
            this.checkTeacher.CheckedChanged += new System.EventHandler(this.checkShowTeacher_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(45, 464);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(209, 29);
            this.label7.TabIndex = 119;
            this.label7.Text = "Confirm Password";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(45, 313);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(130, 29);
            this.label10.TabIndex = 124;
            this.label10.Text = "Mobile No.";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(45, 241);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(76, 29);
            this.label11.TabIndex = 120;
            this.label11.Text = "Email";
            // 
            // lblbackTeacher
            // 
            this.lblbackTeacher.AutoSize = true;
            this.lblbackTeacher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblbackTeacher.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblbackTeacher.ForeColor = System.Drawing.Color.Maroon;
            this.lblbackTeacher.Location = new System.Drawing.Point(91, 720);
            this.lblbackTeacher.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblbackTeacher.Name = "lblbackTeacher";
            this.lblbackTeacher.Size = new System.Drawing.Size(146, 24);
            this.lblbackTeacher.TabIndex = 117;
            this.lblbackTeacher.Text = "Back to LOGIN";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Georgia", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(57, 691);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(234, 24);
            this.label13.TabIndex = 121;
            this.label13.Text = "Already Have an Account";
            // 
            // btnClearRegister
            // 
            this.btnClearRegister.BackColor = System.Drawing.Color.White;
            this.btnClearRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClearRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClearRegister.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearRegister.ForeColor = System.Drawing.Color.Maroon;
            this.btnClearRegister.Location = new System.Drawing.Point(49, 629);
            this.btnClearRegister.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnClearRegister.Name = "btnClearRegister";
            this.btnClearRegister.Size = new System.Drawing.Size(216, 35);
            this.btnClearRegister.TabIndex = 116;
            this.btnClearRegister.Text = "CLEAR";
            this.btnClearRegister.UseVisualStyleBackColor = false;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(45, 159);
            this.label14.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(132, 29);
            this.label14.TabIndex = 122;
            this.label14.Text = "User Name";
            // 
            // txtTeacherConf
            // 
            this.txtTeacherConf.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTeacherConf.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherConf.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherConf.Location = new System.Drawing.Point(49, 499);
            this.txtTeacherConf.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeacherConf.Multiline = true;
            this.txtTeacherConf.Name = "txtTeacherConf";
            this.txtTeacherConf.PasswordChar = '*';
            this.txtTeacherConf.Size = new System.Drawing.Size(273, 28);
            this.txtTeacherConf.TabIndex = 113;
            // 
            // txtTeacherName
            // 
            this.txtTeacherName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTeacherName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherName.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherName.Location = new System.Drawing.Point(49, 197);
            this.txtTeacherName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeacherName.Multiline = true;
            this.txtTeacherName.Name = "txtTeacherName";
            this.txtTeacherName.Size = new System.Drawing.Size(273, 28);
            this.txtTeacherName.TabIndex = 109;
            // 
            // txtMobileTeacher
            // 
            this.txtMobileTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtMobileTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMobileTeacher.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobileTeacher.Location = new System.Drawing.Point(49, 350);
            this.txtMobileTeacher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtMobileTeacher.Multiline = true;
            this.txtMobileTeacher.Name = "txtMobileTeacher";
            this.txtMobileTeacher.Size = new System.Drawing.Size(273, 28);
            this.txtMobileTeacher.TabIndex = 111;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(45, 389);
            this.label15.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(115, 29);
            this.label15.TabIndex = 123;
            this.label15.Text = "Password";
            // 
            // txtEmailTeacher
            // 
            this.txtEmailTeacher.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtEmailTeacher.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmailTeacher.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmailTeacher.Location = new System.Drawing.Point(49, 277);
            this.txtEmailTeacher.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtEmailTeacher.Multiline = true;
            this.txtEmailTeacher.Name = "txtEmailTeacher";
            this.txtEmailTeacher.Size = new System.Drawing.Size(273, 28);
            this.txtEmailTeacher.TabIndex = 110;
            // 
            // txtTeacherPassword
            // 
            this.txtTeacherPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(231)))), ((int)(((byte)(233)))));
            this.txtTeacherPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeacherPassword.Font = new System.Drawing.Font("MS UI Gothic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacherPassword.Location = new System.Drawing.Point(45, 427);
            this.txtTeacherPassword.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtTeacherPassword.Multiline = true;
            this.txtTeacherPassword.Name = "txtTeacherPassword";
            this.txtTeacherPassword.PasswordChar = '*';
            this.txtTeacherPassword.Size = new System.Drawing.Size(277, 28);
            this.txtTeacherPassword.TabIndex = 112;
            // 
            // teacher_SignUpForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(348, 788);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnRegisterTeacher);
            this.Controls.Add(this.checkTeacher);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblbackTeacher);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.btnClearRegister);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTeacherConf);
            this.Controls.Add(this.txtTeacherName);
            this.Controls.Add(this.txtMobileTeacher);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtEmailTeacher);
            this.Controls.Add(this.txtTeacherPassword);
            this.Controls.Add(this.btnCross);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "teacher_SignUpForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "teacher_SignUpForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label btnCross;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnRegisterTeacher;
        private System.Windows.Forms.CheckBox checkTeacher;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblbackTeacher;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnClearRegister;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTeacherConf;
        private System.Windows.Forms.TextBox txtTeacherName;
        private System.Windows.Forms.TextBox txtMobileTeacher;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtEmailTeacher;
        private System.Windows.Forms.TextBox txtTeacherPassword;
    }
}