namespace CustomerInvoices
{
    partial class Form1
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
            this.lvInvoices = new System.Windows.Forms.ListView();
            this.clmHeaderCust = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderInvID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderInvDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clmHeaderInvTot = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lvInvoices
            // 
            this.lvInvoices.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmHeaderCust,
            this.clmHeaderInvID,
            this.clmHeaderInvDate,
            this.clmHeaderInvTot});
            this.lvInvoices.Location = new System.Drawing.Point(29, 27);
            this.lvInvoices.Name = "lvInvoices";
            this.lvInvoices.Size = new System.Drawing.Size(455, 445);
            this.lvInvoices.TabIndex = 0;
            this.lvInvoices.UseCompatibleStateImageBehavior = false;
            this.lvInvoices.View = System.Windows.Forms.View.Details;
            // 
            // clmHeaderCust
            // 
            this.clmHeaderCust.Text = "Customer";
            this.clmHeaderCust.Width = 158;
            // 
            // clmHeaderInvID
            // 
            this.clmHeaderInvID.Text = "Invoice ID";
            this.clmHeaderInvID.Width = 93;
            // 
            // clmHeaderInvDate
            // 
            this.clmHeaderInvDate.Text = "Invoice Date";
            this.clmHeaderInvDate.Width = 87;
            // 
            // clmHeaderInvTot
            // 
            this.clmHeaderInvTot.Text = "Invoice Total";
            this.clmHeaderInvTot.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.clmHeaderInvTot.Width = 90;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 521);
            this.Controls.Add(this.lvInvoices);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Invoices By Invoice Total";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lvInvoices;
        private System.Windows.Forms.ColumnHeader clmHeaderCust;
        private System.Windows.Forms.ColumnHeader clmHeaderInvID;
        private System.Windows.Forms.ColumnHeader clmHeaderInvDate;
        private System.Windows.Forms.ColumnHeader clmHeaderInvTot;

    }
}

