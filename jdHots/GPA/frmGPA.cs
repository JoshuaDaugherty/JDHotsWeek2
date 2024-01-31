using System;
using System.CodeDom;
using System.Diagnostics;
using System.Drawing.Design;
using System.Windows.Forms;

namespace GPA
{
    public partial class frmGPA : Form
    {
        public frmGPA()
        {
            InitializeComponent();
        }

        const int MINGPA = 0;
        const int MAXGPA = 4;
        

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtGPA.Text = "";
            lblResult.Text = "";
            txtGPA.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot ()
        {
            DialogResult dialog = MessageBox.Show(
        "Do You Really Want To Exit The Program?",
        "EXIT NOW?",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question);

            if (dialog == DialogResult.Yes)
            {
                Application.Exit();
            }

        }

        private void ShowErrorMessage(string msg, string title)
        {
            MessageBox.Show(msg, title,
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
        }

        private void btnLetterGrade_Click(object sender, EventArgs e)
        {
            CalculateGPA();
        }

        private void CalculateGPA()
        {
            decimal GPA = decimal.Parse(txtGPA.Text);
            string LetterGrade = "";


            if (txtGPA.Text == "")
            {
                ShowErrorMessage("You Must Enter A Number. Try Again.",
                                "NO INPUT");
                txtGPA.Focus();
                return;
            }




           

           
            
            

            if (GPA < MINGPA || GPA > MAXGPA)
            {
                MessageBox.Show("GPA Must Be Between " +
                               MINGPA + " and " + MAXGPA,
                               "OUT-OF-RANGE GPA INPUT",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);

                txtGPA.Text = "";
                txtGPA.Focus();
            }

            else if (GPA > 3.0m )
            {
                LetterGrade = "A";
            }
            else if (GPA > 2.0m && GPA <= 3.0m)
            {
                LetterGrade = "B";
            }
            else if (GPA > 1.0m && GPA <= 2.0m)
            {
                LetterGrade = "C";
            }
            else if (GPA > 0.0m && GPA <= 1.0m)
            {
                LetterGrade = "D";
            }
            else if (GPA <= 0.0m)
            {
                LetterGrade = "F";
            }

            lblResult.Text = ($"Your Letter Grade a: {LetterGrade}");
        }

       
    }


}
