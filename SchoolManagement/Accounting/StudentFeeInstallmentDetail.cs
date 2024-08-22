using DocumentFormat.OpenXml.Drawing.Charts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagement.Accounting
{
    public partial class StudentFeeInstallmentDetail : Form
    {
        public StudentFeeInstallmentDetail()
        {
            InitializeComponent();
        }

        private void StudentFeeInstallmentDetail_Load(object sender, EventArgs e)
        {

        }

        private void totalNoOfInstallment_KeyUp(object sender, KeyEventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(seeAmount.Text) && !string.IsNullOrWhiteSpace(firstPayPayment.Text))
            {
                int newRow;
                bool isValidNumber = int.TryParse(totalNoOfInstallment.Text, out newRow);

                if (isValidNumber && newRow > 0)
                {
                    StuFeeInstaDataGridView.Rows.Clear();

                    for (int i = 0; i < newRow; i++)
                    {

                        StuFeeInstaDataGridView.Rows.Add();
                        StuFeeInstaDataGridView.Rows[i].Cells[1].Value = (i + 1);
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a valid number", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    totalNoOfInstallment.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill the see amount and first pay payment", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                totalNoOfInstallment.Text = string.Empty;
            }
        }

        private void StudFeeInstallSubmit_Click(object sender, EventArgs e)
        {

        }
    }
}
