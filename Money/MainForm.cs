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
    public partial class BudgetForm : Form
    {
        public BudgetForm()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void addBillBTN_Click(object sender, EventArgs e)
        {
            var addBill = new AddBillForm();
            addBill.ShowDialog();

            ListViewItem listItem = new ListViewItem(addBill.Bill);
            listItem.SubItems.Add(addBill.Amount.ToString());
            listItem.SubItems.Add(addBill.DueDate.ToString());
            billGroupView.Items.Add(listItem);
        }

        private void removeBTN_Click(object sender, EventArgs e)
        {
            billGroupView.SelectedItems[0].Remove();
        }

        private void calculateBTN_Click(object sender, EventArgs e)
        {
            double total = 0.00;

            for (int i = 0, n = billGroupView.Items.Count; i < n; i++)
            {
                total += double.Parse(billGroupView.Items[i].SubItems[1].Text);
            }

            priceLabel.Text = total.ToString();
            priceLabel.Show();
        }
    }
}