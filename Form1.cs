using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_GPA
{
    public partial class Form1 : Form
    {



        public Form1()
        {
           
            InitializeComponent();
            HideUI();
            AttachEventHandlers();
        }

        int totalHoursRequired;
        int enteredHours = 0;
        int totalCreditHours = 0;
        double totalPoints = 0;
        void HideUI()
        {

            mt_subjectOfHours.Visible = false;
            mt___letterGrade.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
        
            btnSave_TheDetails.Visible = false;
           
        }


        void Veiw()
        {

            mt_subjectOfHours.Visible = true;
            mt___letterGrade.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
             
            btnSave_TheDetails.Visible = true;
        }
        private void btnSave_NumberofHours_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(mt_NumbeOfHours.Text, out totalHoursRequired) || totalHoursRequired <= 0)
            {

                MessageBox.Show("Enter a valid number of hours !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            else
            {
                Veiw();
                mt_NumbeOfHours.Enabled = false;

            }

        }



  

        double Letter_Grades(string mt___letterGrade )
        {
            switch (mt___letterGrade) {
                case "A":
                    return 4.000;
                case "A-":
                    return 3.666;
                case "B+":
                    return 3.333;
                case "B":
                    return 3.000;
                case "B-":
                    return 2.666;
                case "C+":
                    return 2.333;
                case "C":
                    return 2.000;
                case "C-":
                    return 1.666;
                case "D+":
                    return 1.333;
                case "D":
                    return 1.000;
                case "F":
                case "Abs":
                    return 0.000;
            }
            return 0;


        }


        private void CheckInputs()
        {
            // Disable the Save button if either field is empty
            btnSave_TheDetails.Enabled = !string.IsNullOrWhiteSpace(mt_subjectOfHours.Text)
                                        && !string.IsNullOrWhiteSpace(mt___letterGrade.Text);
        }

        double CalcGPA()
        {

 


            if (!int.TryParse(mt_subjectOfHours.Text, out int creditHours) || creditHours <= 0)
            {
                MessageBox.Show("Invalid Hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }

            double gradePoints = Letter_Grades(mt___letterGrade.Text);
            

            totalCreditHours +=  creditHours;
            totalPoints += creditHours * gradePoints;
            enteredHours += creditHours;


            mt_subjectOfHours.Text = "";
            mt___letterGrade.Text = "";

            CheckInputs();

            if (enteredHours == totalHoursRequired)
            {
                  HideUI();
              //  btnFinsh.Visible = true;    
                MessageBox.Show("All subjects entered! Click 'ok' to see final GPA.", "Complete", MessageBoxButtons.OK, MessageBoxIcon.Information);
               
                double gpa = totalPoints / totalCreditHours;
                LbGPA.Visible = true;
                // MessageBox.Show($"Final GPA: {gpa:0.00}", "GPA Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LbGPA.Text = $"Your GPA is: {gpa:F2}";
                LbGPA.ForeColor = Color.Red; // If you want it red like in the image
                LbGPA.Font = new Font(LbGPA.Font, FontStyle.Bold);
            }
            
            if (enteredHours  > totalHoursRequired) {
                HideUI();
                mt_NumbeOfHours.Visible = false;
                label2.Visible = false;
                btnSave_NumberofHours.Visible = false;
                MessageBox.Show("You are exceeding the total required hours!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0; 
            }
            return Math.Round(totalPoints / totalCreditHours, 2);
        }


        

      // private void btnFinsh_Click(object sender, EventArgs e)
      // {
      //     Hide();
      //     double gpa = totalPoints /  totalCreditHours;
      //     LbGPA.Visible = true;
      //     // MessageBox.Show($"Final GPA: {gpa:0.00}", "GPA Result", MessageBoxButtons.OK, MessageBoxIcon.Information);
      //     LbGPA.Text = $"Your GPA is: {gpa:F4}";
      //     LbGPA.ForeColor = Color.Red; // If you want it red like in the image
      //     LbGPA.Font = new Font(LbGPA.Font, FontStyle.Bold);
      // }

        private void btnSave_TheDetails_Click(object sender, EventArgs e)
        {
            double gpa = CalcGPA();
            if (gpa == 0 && totalCreditHours == 0)
            {
                MessageBox.Show("Your Hours Is not Correct. Restart The app", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void bnRestart_Click(object sender, EventArgs e)
        {
            mt_NumbeOfHours.Text = "";
            mt_subjectOfHours.Text = "";
            mt___letterGrade.Text = "";

            // Reset stored values
            totalHoursRequired = 0;
            enteredHours = 0;
            totalCreditHours = 0;
            totalPoints = 0;


             HideUI();
             mt_NumbeOfHours.Visible = true;
            label2.Visible = true;
            LbGPA.Visible=false;
            btnSave_NumberofHours.Visible = true;

            mt_NumbeOfHours.Enabled = true;

            MessageBox.Show("Restarted successfully!", "Restart", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void AttachEventHandlers()
        {
            mt_subjectOfHours.TextChanged += (s, e) => CheckInputs();
            mt___letterGrade.TextChanged += (s, e) => CheckInputs();
        }

    
    }
    }
