namespace EmployeeApplication_
{
    partial class frmComputeSalary
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_firstname = new TextBox();
            txt_department = new TextBox();
            label2 = new Label();
            txt_lastname = new TextBox();
            label3 = new Label();
            txt_jobtitle = new TextBox();
            label4 = new Label();
            txt_rateperhour = new TextBox();
            label5 = new Label();
            txt_totalhoursworked = new TextBox();
            label6 = new Label();
            butt_compute = new Button();
            label7 = new Label();
            lbl_firstname = new Label();
            lbl_lastname = new Label();
            label10 = new Label();
            lbl_basicsalary = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 19);
            label1.Name = "label1";
            label1.Size = new Size(91, 21);
            label1.TabIndex = 0;
            label1.Text = "First Name";
            // 
            // txt_firstname
            // 
            txt_firstname.Location = new Point(12, 43);
            txt_firstname.Name = "txt_firstname";
            txt_firstname.Size = new Size(278, 27);
            txt_firstname.TabIndex = 1;
            txt_firstname.TextChanged += txt_firstname_TextChanged;
            // 
            // txt_department
            // 
            txt_department.Location = new Point(12, 122);
            txt_department.Name = "txt_department";
            txt_department.Size = new Size(278, 27);
            txt_department.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 98);
            label2.Name = "label2";
            label2.Size = new Size(99, 21);
            label2.TabIndex = 2;
            label2.Text = "Department";
            // 
            // txt_lastname
            // 
            txt_lastname.Location = new Point(296, 43);
            txt_lastname.Name = "txt_lastname";
            txt_lastname.Size = new Size(278, 27);
            txt_lastname.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(296, 19);
            label3.Name = "label3";
            label3.Size = new Size(89, 21);
            label3.TabIndex = 4;
            label3.Text = "Last Name";
            // 
            // txt_jobtitle
            // 
            txt_jobtitle.Location = new Point(296, 122);
            txt_jobtitle.Name = "txt_jobtitle";
            txt_jobtitle.Size = new Size(278, 27);
            txt_jobtitle.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(296, 98);
            label4.Name = "label4";
            label4.Size = new Size(73, 21);
            label4.TabIndex = 6;
            label4.Text = "Job Title";
            // 
            // txt_rateperhour
            // 
            txt_rateperhour.Location = new Point(12, 250);
            txt_rateperhour.Name = "txt_rateperhour";
            txt_rateperhour.Size = new Size(278, 27);
            txt_rateperhour.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 226);
            label5.Name = "label5";
            label5.Size = new Size(112, 21);
            label5.TabIndex = 8;
            label5.Text = "Rate per hour";
            // 
            // txt_totalhoursworked
            // 
            txt_totalhoursworked.Location = new Point(296, 250);
            txt_totalhoursworked.Name = "txt_totalhoursworked";
            txt_totalhoursworked.Size = new Size(278, 27);
            txt_totalhoursworked.TabIndex = 11;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(296, 226);
            label6.Name = "label6";
            label6.Size = new Size(157, 21);
            label6.TabIndex = 10;
            label6.Text = "Total Hours Worked";
            // 
            // butt_compute
            // 
            butt_compute.Location = new Point(12, 301);
            butt_compute.Name = "butt_compute";
            butt_compute.Size = new Size(130, 41);
            butt_compute.TabIndex = 12;
            butt_compute.Text = "Compute Salary";
            butt_compute.UseVisualStyleBackColor = true;
            butt_compute.Click += butt_compute_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(12, 372);
            label7.Name = "label7";
            label7.Size = new Size(102, 21);
            label7.TabIndex = 13;
            label7.Text = "First Name: ";
            // 
            // lbl_firstname
            // 
            lbl_firstname.AutoSize = true;
            lbl_firstname.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_firstname.Location = new Point(120, 372);
            lbl_firstname.Name = "lbl_firstname";
            lbl_firstname.Size = new Size(147, 21);
            lbl_firstname.TabIndex = 14;
            lbl_firstname.Text = "<first name here>";
            // 
            // lbl_lastname
            // 
            lbl_lastname.AutoSize = true;
            lbl_lastname.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_lastname.Location = new Point(120, 420);
            lbl_lastname.Name = "lbl_lastname";
            lbl_lastname.Size = new Size(145, 21);
            lbl_lastname.TabIndex = 16;
            lbl_lastname.Text = "<last name here>";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(12, 420);
            label10.Name = "label10";
            label10.Size = new Size(100, 21);
            label10.TabIndex = 15;
            label10.Text = "Last Name: ";
            // 
            // lbl_basicsalary
            // 
            lbl_basicsalary.AutoSize = true;
            lbl_basicsalary.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_basicsalary.Location = new Point(128, 467);
            lbl_basicsalary.Name = "lbl_basicsalary";
            lbl_basicsalary.Size = new Size(51, 21);
            lbl_basicsalary.TabIndex = 18;
            lbl_basicsalary.Text = "00.00";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Tahoma", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(12, 467);
            label12.Name = "label12";
            label12.Size = new Size(110, 21);
            label12.TabIndex = 17;
            label12.Text = "Basic Salary: ";
            // 
            // frmComputeSalary
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(614, 581);
            Controls.Add(lbl_basicsalary);
            Controls.Add(label12);
            Controls.Add(lbl_lastname);
            Controls.Add(label10);
            Controls.Add(lbl_firstname);
            Controls.Add(label7);
            Controls.Add(butt_compute);
            Controls.Add(txt_totalhoursworked);
            Controls.Add(label6);
            Controls.Add(txt_rateperhour);
            Controls.Add(label5);
            Controls.Add(txt_jobtitle);
            Controls.Add(label4);
            Controls.Add(txt_lastname);
            Controls.Add(label3);
            Controls.Add(txt_department);
            Controls.Add(label2);
            Controls.Add(txt_firstname);
            Controls.Add(label1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "frmComputeSalary";
            Text = "Employee Salary Calculator";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_firstname;
        private TextBox txt_department;
        private Label label2;
        private TextBox txt_lastname;
        private Label label3;
        private TextBox txt_jobtitle;
        private Label label4;
        private TextBox txt_rateperhour;
        private Label label5;
        private TextBox txt_totalhoursworked;
        private Label label6;
        private Button butt_compute;
        private Label label7;
        private Label lbl_firstname;
        private Label lbl_lastname;
        private Label label10;
        private Label lbl_basicsalary;
        private Label label12;
    }
}
