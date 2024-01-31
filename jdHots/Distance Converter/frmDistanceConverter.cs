using System;
using System.Windows.Forms;

namespace Distance_Converter
{
    public partial class frmDistanceConverter : Form
    {
        //const
        const decimal INCHES_PER_YD = 36;
        

        public frmDistanceConverter()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            exitProgramOrNot();
        }

        private void exitProgramOrNot()
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
            txtDistanceInInches.Text = "";
            lblResult.Text = "";
            txtDistanceInInches.Focus();
        }

        private void btnConvertToYards_Click(object sender, EventArgs e)
        {
            PerformConversion();
        }

        private void PerformConversion()
        {
            decimal inches;
            decimal yards;

            //If textbox is Empty

            if (txtDistanceInInches.Text.Trim() == "")
            {
                ShowErrorMessage("TextBox Cannot Be Empty",
                                "EMPTY INCHES TEXTBOX");

                txtDistanceInInches.Focus();
                return;
            }

            


            
            inches = Convert.ToDecimal(txtDistanceInInches.Text);
            yards = inches / INCHES_PER_YD;

            lblResult.Text = ($"{inches:n2} inches = {yards:n2} yards");
        }

        private void txtDistanceInInches_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

   



}
