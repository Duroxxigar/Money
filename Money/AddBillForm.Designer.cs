namespace Money
{
    partial class AddBillForm
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
            this.billNameLabel = new System.Windows.Forms.Label();
            this.amountLabel = new System.Windows.Forms.Label();
            this.dateDueLabel = new System.Windows.Forms.Label();
            this.okayBTN = new System.Windows.Forms.Button();
            this.cancelBTN = new System.Windows.Forms.Button();
            this.addBillTextBox = new System.Windows.Forms.TextBox();
            this.amountTextBox = new System.Windows.Forms.TextBox();
            this.dueDateTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // billNameLabel
            // 
            this.billNameLabel.AutoSize = true;
            this.billNameLabel.Location = new System.Drawing.Point(13, 22);
            this.billNameLabel.Name = "billNameLabel";
            this.billNameLabel.Size = new System.Drawing.Size(58, 13);
            this.billNameLabel.TabIndex = 0;
            this.billNameLabel.Text = "Bill To Add";
            // 
            // amountLabel
            // 
            this.amountLabel.AutoSize = true;
            this.amountLabel.Location = new System.Drawing.Point(13, 49);
            this.amountLabel.Name = "amountLabel";
            this.amountLabel.Size = new System.Drawing.Size(43, 13);
            this.amountLabel.TabIndex = 1;
            this.amountLabel.Text = "Amount";
            // 
            // dateDueLabel
            // 
            this.dateDueLabel.AutoSize = true;
            this.dateDueLabel.Location = new System.Drawing.Point(13, 74);
            this.dateDueLabel.Name = "dateDueLabel";
            this.dateDueLabel.Size = new System.Drawing.Size(53, 13);
            this.dateDueLabel.TabIndex = 2;
            this.dateDueLabel.Text = "Date Due";
            // 
            // okayBTN
            // 
            this.okayBTN.Location = new System.Drawing.Point(16, 125);
            this.okayBTN.Name = "okayBTN";
            this.okayBTN.Size = new System.Drawing.Size(75, 23);
            this.okayBTN.TabIndex = 3;
            this.okayBTN.Text = "OK";
            this.okayBTN.UseVisualStyleBackColor = true;
            this.okayBTN.Click += new System.EventHandler(this.okayBTN_Click);
            // 
            // cancelBTN
            // 
            this.cancelBTN.Location = new System.Drawing.Point(131, 125);
            this.cancelBTN.Name = "cancelBTN";
            this.cancelBTN.Size = new System.Drawing.Size(75, 23);
            this.cancelBTN.TabIndex = 4;
            this.cancelBTN.Text = "Cancel";
            this.cancelBTN.UseVisualStyleBackColor = true;
            this.cancelBTN.Click += new System.EventHandler(this.cancelBTN_Click);
            // 
            // addBillTextBox
            // 
            this.addBillTextBox.Location = new System.Drawing.Point(77, 22);
            this.addBillTextBox.Name = "addBillTextBox";
            this.addBillTextBox.Size = new System.Drawing.Size(100, 20);
            this.addBillTextBox.TabIndex = 5;
            // 
            // amountTextBox
            // 
            this.amountTextBox.Location = new System.Drawing.Point(77, 48);
            this.amountTextBox.Name = "amountTextBox";
            this.amountTextBox.Size = new System.Drawing.Size(100, 20);
            this.amountTextBox.TabIndex = 6;
            // 
            // dueDateTextBox
            // 
            this.dueDateTextBox.Location = new System.Drawing.Point(77, 74);
            this.dueDateTextBox.Name = "dueDateTextBox";
            this.dueDateTextBox.Size = new System.Drawing.Size(100, 20);
            this.dueDateTextBox.TabIndex = 7;
            // 
            // AddBillForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(276, 160);
            this.Controls.Add(this.dueDateTextBox);
            this.Controls.Add(this.amountTextBox);
            this.Controls.Add(this.addBillTextBox);
            this.Controls.Add(this.cancelBTN);
            this.Controls.Add(this.okayBTN);
            this.Controls.Add(this.dateDueLabel);
            this.Controls.Add(this.amountLabel);
            this.Controls.Add(this.billNameLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "AddBillForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Add A Bill";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label billNameLabel;
        private System.Windows.Forms.Label amountLabel;
        private System.Windows.Forms.Label dateDueLabel;
        private System.Windows.Forms.Button okayBTN;
        private System.Windows.Forms.Button cancelBTN;
        private System.Windows.Forms.TextBox addBillTextBox;
        private System.Windows.Forms.TextBox amountTextBox;
        private System.Windows.Forms.TextBox dueDateTextBox;
    }
}