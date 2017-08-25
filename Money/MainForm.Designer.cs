namespace Money
{
    partial class BudgetForm
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
            this.billGroupView = new System.Windows.Forms.ListView();
            this.billColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.amountColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.dueDateColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addBillBTN = new System.Windows.Forms.Button();
            this.removeBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.priceLabel = new System.Windows.Forms.Label();
            this.calculateBTN = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // billGroupView
            // 
            this.billGroupView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.billColumn,
            this.amountColumn,
            this.dueDateColumn});
            this.billGroupView.FullRowSelect = true;
            this.billGroupView.GridLines = true;
            this.billGroupView.Location = new System.Drawing.Point(12, 12);
            this.billGroupView.Name = "billGroupView";
            this.billGroupView.Size = new System.Drawing.Size(401, 199);
            this.billGroupView.TabIndex = 0;
            this.billGroupView.UseCompatibleStateImageBehavior = false;
            this.billGroupView.View = System.Windows.Forms.View.Details;
            // 
            // billColumn
            // 
            this.billColumn.Text = "Bill Name";
            this.billColumn.Width = 215;
            // 
            // amountColumn
            // 
            this.amountColumn.Text = "Amount";
            this.amountColumn.Width = 95;
            // 
            // dueDateColumn
            // 
            this.dueDateColumn.Text = "Due Date";
            this.dueDateColumn.Width = 75;
            // 
            // addBillBTN
            // 
            this.addBillBTN.Location = new System.Drawing.Point(12, 302);
            this.addBillBTN.Name = "addBillBTN";
            this.addBillBTN.Size = new System.Drawing.Size(75, 23);
            this.addBillBTN.TabIndex = 1;
            this.addBillBTN.Text = "Add Bill";
            this.addBillBTN.UseVisualStyleBackColor = true;
            this.addBillBTN.Click += new System.EventHandler(this.addBillBTN_Click);
            // 
            // removeBTN
            // 
            this.removeBTN.Location = new System.Drawing.Point(338, 302);
            this.removeBTN.Name = "removeBTN";
            this.removeBTN.Size = new System.Drawing.Size(75, 23);
            this.removeBTN.TabIndex = 2;
            this.removeBTN.Text = "Remove Bill";
            this.removeBTN.UseVisualStyleBackColor = true;
            this.removeBTN.Click += new System.EventHandler(this.removeBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(214, 218);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total:";
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(255, 218);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(31, 13);
            this.priceLabel.TabIndex = 4;
            this.priceLabel.Text = "Price";
            this.priceLabel.Visible = false;
            // 
            // calculateBTN
            // 
            this.calculateBTN.Location = new System.Drawing.Point(217, 235);
            this.calculateBTN.Name = "calculateBTN";
            this.calculateBTN.Size = new System.Drawing.Size(75, 23);
            this.calculateBTN.TabIndex = 5;
            this.calculateBTN.Text = "Calculate";
            this.calculateBTN.UseVisualStyleBackColor = true;
            this.calculateBTN.Click += new System.EventHandler(this.calculateBTN_Click);
            // 
            // BudgetForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 337);
            this.Controls.Add(this.calculateBTN);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.removeBTN);
            this.Controls.Add(this.addBillBTN);
            this.Controls.Add(this.billGroupView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "BudgetForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Budget";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView billGroupView;
        private System.Windows.Forms.ColumnHeader billColumn;
        private System.Windows.Forms.ColumnHeader amountColumn;
        private System.Windows.Forms.ColumnHeader dueDateColumn;
        private System.Windows.Forms.Button addBillBTN;
        private System.Windows.Forms.Button removeBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.Button calculateBTN;
    }
}

