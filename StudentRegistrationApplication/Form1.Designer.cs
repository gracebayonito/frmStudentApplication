namespace StudentRegistrationApplication
{
    partial class Form1
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
            this.LastnameBox = new System.Windows.Forms.TextBox();
            this.FirstnameBox = new System.Windows.Forms.TextBox();
            this.MiddlenameBox = new System.Windows.Forms.TextBox();
            this.male = new System.Windows.Forms.RadioButton();
            this.Female = new System.Windows.Forms.RadioButton();
            this.DayBox = new System.Windows.Forms.ComboBox();
            this.MonthBox = new System.Windows.Forms.ComboBox();
            this.YearBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.RegisterStudent = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ProgramBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // LastnameBox
            // 
            this.LastnameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LastnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LastnameBox.Location = new System.Drawing.Point(63, 117);
            this.LastnameBox.Name = "LastnameBox";
            this.LastnameBox.Size = new System.Drawing.Size(261, 35);
            this.LastnameBox.TabIndex = 0;
            // 
            // FirstnameBox
            // 
            this.FirstnameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.FirstnameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FirstnameBox.Location = new System.Drawing.Point(65, 188);
            this.FirstnameBox.Name = "FirstnameBox";
            this.FirstnameBox.Size = new System.Drawing.Size(258, 35);
            this.FirstnameBox.TabIndex = 1;
            // 
            // MiddlenameBox
            // 
            this.MiddlenameBox.BackColor = System.Drawing.Color.WhiteSmoke;
            this.MiddlenameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MiddlenameBox.Location = new System.Drawing.Point(64, 258);
            this.MiddlenameBox.Name = "MiddlenameBox";
            this.MiddlenameBox.Size = new System.Drawing.Size(258, 35);
            this.MiddlenameBox.TabIndex = 2;
            // 
            // male
            // 
            this.male.AutoSize = true;
            this.male.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.male.Location = new System.Drawing.Point(162, 294);
            this.male.Name = "male";
            this.male.Size = new System.Drawing.Size(61, 24);
            this.male.TabIndex = 3;
            this.male.TabStop = true;
            this.male.Text = "Male";
            this.male.UseVisualStyleBackColor = true;
            // 
            // Female
            // 
            this.Female.AutoSize = true;
            this.Female.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Female.Location = new System.Drawing.Point(240, 295);
            this.Female.Name = "Female";
            this.Female.Size = new System.Drawing.Size(80, 24);
            this.Female.TabIndex = 4;
            this.Female.TabStop = true;
            this.Female.Text = "Female";
            this.Female.UseVisualStyleBackColor = true;
            // 
            // DayBox
            // 
            this.DayBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DayBox.FormattingEnabled = true;
            this.DayBox.Location = new System.Drawing.Point(66, 348);
            this.DayBox.Name = "DayBox";
            this.DayBox.Size = new System.Drawing.Size(74, 28);
            this.DayBox.TabIndex = 5;
            this.DayBox.Text = "-Day-";
            // 
            // MonthBox
            // 
            this.MonthBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MonthBox.FormattingEnabled = true;
            this.MonthBox.Location = new System.Drawing.Point(155, 349);
            this.MonthBox.Name = "MonthBox";
            this.MonthBox.Size = new System.Drawing.Size(74, 28);
            this.MonthBox.TabIndex = 6;
            this.MonthBox.Text = "-Month-";
            // 
            // YearBox
            // 
            this.YearBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.YearBox.FormattingEnabled = true;
            this.YearBox.Location = new System.Drawing.Point(244, 349);
            this.YearBox.Name = "YearBox";
            this.YearBox.Size = new System.Drawing.Size(74, 28);
            this.YearBox.TabIndex = 7;
            this.YearBox.Text = "-Year-";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 95);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Last Name*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(61, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "First Name*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(60, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Middle Name*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(318, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Student Registration Form";
            // 
            // RegisterStudent
            // 
            this.RegisterStudent.BackColor = System.Drawing.Color.Crimson;
            this.RegisterStudent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegisterStudent.Location = new System.Drawing.Point(117, 454);
            this.RegisterStudent.Name = "RegisterStudent";
            this.RegisterStudent.Size = new System.Drawing.Size(155, 44);
            this.RegisterStudent.TabIndex = 8;
            this.RegisterStudent.Text = "Register Student";
            this.RegisterStudent.UseVisualStyleBackColor = false;
            this.RegisterStudent.Click += new System.EventHandler(this.RegisterStudent_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(65, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Gender*";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(65, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Date of Birth*";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(156, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = " Program to apply*";
            // 
            // ProgramBox
            // 
            this.ProgramBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramBox.FormattingEnabled = true;
            this.ProgramBox.Location = new System.Drawing.Point(67, 412);
            this.ProgramBox.Name = "ProgramBox";
            this.ProgramBox.Size = new System.Drawing.Size(255, 28);
            this.ProgramBox.TabIndex = 16;
            this.ProgramBox.Text = "-Select Program-";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Thistle;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(386, 511);
            this.Controls.Add(this.ProgramBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegisterStudent);
            this.Controls.Add(this.YearBox);
            this.Controls.Add(this.MonthBox);
            this.Controls.Add(this.DayBox);
            this.Controls.Add(this.Female);
            this.Controls.Add(this.male);
            this.Controls.Add(this.MiddlenameBox);
            this.Controls.Add(this.FirstnameBox);
            this.Controls.Add(this.LastnameBox);
            this.Name = "Form1";
            this.Text = "Student Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox LastnameBox;
        private System.Windows.Forms.TextBox FirstnameBox;
        private System.Windows.Forms.TextBox MiddlenameBox;
        private System.Windows.Forms.RadioButton male;
        private System.Windows.Forms.RadioButton Female;
        private System.Windows.Forms.ComboBox DayBox;
        private System.Windows.Forms.ComboBox MonthBox;
        private System.Windows.Forms.ComboBox YearBox;
        private System.Windows.Forms.Button RegisterStudent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox ProgramBox;
    }
}

