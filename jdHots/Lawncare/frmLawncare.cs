using System;
using System.Windows.Forms;
using static System.Windows.Forms.MonthCalendar;

namespace Lawncare
{
    public partial class frmLawncare : Form
    {
        public frmLawncare()
        {
            InitializeComponent();
        }
        const decimal SEASONS = 20m;
        int WeekFee = 0;
        decimal length = 0;
        decimal width = 0;
        decimal area = 0;
        int total = 0;


        private void button3_Click(object sender, EventArgs e)
        {
            ExitProgramOrNot();
        }

        private void ExitProgramOrNot()
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

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearForm();
        }

        private void ClearForm()
        {
            txtLength.Text = "";
            txtWidth.Text = "";
            lblArea.Text = "";
            lblWeeklyFee.Text = "";
            
            lblTotalCost.Text = "";
            txtLength.Focus();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            SetLengthAndWidth();
            CalculateArea();
            CalculateWeeklyFee();
            CalculateTotal();
        }

        private void SetLengthAndWidth()
        {
            if (txtLength.Text == "")
            {
                ShowErrorMessage("TextBox Cannot Be Empty",
                                "EMPTY LENGTH TEXTBOX");
                txtLength.Focus();
            }

            if (txtWidth.Text == "")
            {
                ShowErrorMessage("TextBox Cannot Be Empty",
                                "EMPTY WIDTH TEXTBOX");
                txtLength.Focus();
            }

            length = Int32.Parse(txtLength.Text);
            width = Int32.Parse(txtWidth.Text);
            

        }

        private void CalculateArea()
        {
           

            area = length * width;
            lblArea.Text = ($"Area: {area} sq feet");

            
        }

        private void CalculateWeeklyFee()
        {
            string WeekFee = "";

            if (area >= 600)
            {
                 WeekFee = "$50";
            }
            else if (area >= 400 && area < 600)
            {
                WeekFee = "$35";
            }
            else if (area < 400)
            {
                WeekFee = "$25";
            }

            lblWeeklyFee.Text = ($"WeeklyFee:$ {WeekFee} ");
        }

        private void CalculateTotal()
        {
            int total = 0;
            int WeekFee = 0;

            if (area >= 600)
            {
                WeekFee = 50;
            }
            else if (area >= 400 && area < 600)
            {
                WeekFee = 35;
            }
            else if (area < 400)
            {
                WeekFee = 25;
            }




            total = ( WeekFee * 20);

            lblTotalCost.Text = ($"Total Cost: ${total} ");
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
