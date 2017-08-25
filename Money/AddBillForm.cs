using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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
        public int DueDate { get; private set; }
        #endregion

        public AddBillForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void okayBTN_Click(object sender, EventArgs e)
        {
            Bill = addBillTextBox.Text;
            Amount = double.Parse(amountTextBox.Text);
            DueDate = Int32.Parse(dueDateTextBox.Text);
            this.Close();
        }

        private void cancelBTN_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}