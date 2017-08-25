using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Money
{
    public partial class AddBillForm : Form
    {
        #region Properties

        public string Bill { get; private set; }
        public double Amount { get; private set; }
        public short DueDate { get; private set; }

        #endregion

        private readonly ListView homeView;

        public AddBillForm(ListView homeView)
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
            this.homeView = homeView;
        }

        private void okayBTN_Click(object sender, EventArgs e)
        {
            if (CheckName() && CheckAmount() && CheckDate())
            {
                AddInformation();
                this.Close();
            }
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddInformation()
        {
            var listItem = new ListViewItem(Bill);
            listItem.SubItems.Add(Amount.ToString());
            listItem.SubItems.Add(DueDate.ToString());
            homeView.Items.Add(listItem);
        }

        private bool CheckName()
        {
            Bill = addBillTextBox.Text;

            if (Bill == "")
            {
                MessageBox.Show("Enter a name for the bill", "Name Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private bool CheckAmount()
        {
            if (double.TryParse(amountTextBox.Text, out var verifiedAmount))
            {
                Amount = verifiedAmount;
                if (Amount < 0)
                {
                    MessageBox.Show("No negative amounts allowed", "Amount Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Amount Input Type \nPlease use a number", "Incorrect Number",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private bool CheckDate()
        {
            if (short.TryParse(dueDateTextBox.Text, out var verifiedDate))
            {
                DueDate = verifiedDate;
                if (DueDate < 1 || DueDate > 31)
                {
                    MessageBox.Show("Not a valid date", "Date Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
                return true;
            }
            else
            {
                MessageBox.Show("Incorrect Date Input Type \nPlease use a number", "Incorrect Date",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}