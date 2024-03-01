using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 1; i <= 31; i++)
            {
                DayBox.Items.Add(i);

            }
            ArrayList month = new ArrayList();
            month.Add("January");
            month.Add("February");
            month.Add("March");
            month.Add("April");
            month.Add("May");
            month.Add("June");
            month.Add("July");
            month.Add("August");
            month.Add("Septrmber");
            month.Add("October");
            month.Add("November");
            month.Add("December");
            for (int i = 0; i < 12; i++)
            {
                MonthBox.Items.Add(month[i]);

            }
            int Year = DateTime.Now.Year;
            for (int i = 1900; i <= Year; i++)
            {
                YearBox.Items.Add(i);
            }


            ArrayList Programs = new ArrayList();
            Programs.Add("Bachelor of Science in Computer Science");
            Programs.Add("Bachelor of Science in Information Technology");
            Programs.Add("Bachelor of Science in Information System");
            Programs.Add("Bachelor of Science in Computer Engineering");

            foreach (String Program in Programs)
            {
                ProgramBox.Items.Add(Program);
            }

        }



        private void RegisterStudent_Click(object sender, EventArgs e)
        {
            string LastN = LastnameBox.Text;
            string FirstN = FirstnameBox.Text;
            string MiddleN = MiddlenameBox.Text;
            string gender;


            if (male.Checked == true)
            {

                    
                gender = "Male";
            }

            else
            {

                gender = "Female";

            }   
            MessageBox.Show("Student Name:" + LastN + "   " +  FirstN + "   " + MiddleN + "   "+ "\nDate of Birth: "
                + DayBox.Text + MonthBox.Text + YearBox.Text
                + "\nGender: " + gender 
                + "\nProgram: " + ProgramBox.Text);

        }
    }
}