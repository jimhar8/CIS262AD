namespace CS8
{
    partial class CS8Form
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
            this.btnExit = new System.Windows.Forms.Button();
            this.txtSearchResults = new System.Windows.Forms.TextBox();
            this.Label5 = new System.Windows.Forms.Label();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.Label4 = new System.Windows.Forms.Label();
            this.btnSearchByName = new System.Windows.Forms.Button();
            this.btnSortByName = new System.Windows.Forms.Button();
            this.lstName = new System.Windows.Forms.ListBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(251, 211);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(72, 36);
            this.btnExit.TabIndex = 40;
            this.btnExit.Text = "Exit";
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtSearchResults
            // 
            this.txtSearchResults.Enabled = false;
            this.txtSearchResults.Location = new System.Drawing.Point(110, 317);
            this.txtSearchResults.Name = "txtSearchResults";
            this.txtSearchResults.ReadOnly = true;
            this.txtSearchResults.Size = new System.Drawing.Size(280, 20);
            this.txtSearchResults.TabIndex = 50;
            // 
            // Label5
            // 
            this.Label5.Location = new System.Drawing.Point(6, 317);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(88, 16);
            this.Label5.TabIndex = 49;
            this.Label5.Text = "Search Results:";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(110, 277);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(280, 20);
            this.txtSearchName.TabIndex = 42;
            // 
            // Label4
            // 
            this.Label4.Location = new System.Drawing.Point(6, 277);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(80, 23);
            this.Label4.TabIndex = 48;
            this.Label4.Text = "Search Name:";
            // 
            // btnSearchByName
            // 
            this.btnSearchByName.Location = new System.Drawing.Point(251, 91);
            this.btnSearchByName.Name = "btnSearchByName";
            this.btnSearchByName.Size = new System.Drawing.Size(72, 36);
            this.btnSearchByName.TabIndex = 39;
            this.btnSearchByName.Text = "Search by Name";
            this.btnSearchByName.Click += new System.EventHandler(this.btnSearchByName_Click);
            // 
            // btnSortByName
            // 
            this.btnSortByName.Location = new System.Drawing.Point(251, 35);
            this.btnSortByName.Name = "btnSortByName";
            this.btnSortByName.Size = new System.Drawing.Size(72, 36);
            this.btnSortByName.TabIndex = 38;
            this.btnSortByName.Text = "Sort by Name";
            this.btnSortByName.Click += new System.EventHandler(this.btnSortByName_Click);
            // 
            // lstName
            // 
            this.lstName.Enabled = false;
            this.lstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstName.ItemHeight = 20;
            this.lstName.Location = new System.Drawing.Point(9, 35);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(215, 224);
            this.lstName.TabIndex = 45;
            // 
            // Label1
            // 
            this.Label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.Location = new System.Drawing.Point(30, 9);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(100, 23);
            this.Label1.TabIndex = 37;
            this.Label1.Text = "Names";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(251, 153);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(72, 36);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete Name";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // CS8Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 359);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.txtSearchResults);
            this.Controls.Add(this.Label5);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.btnSearchByName);
            this.Controls.Add(this.btnSortByName);
            this.Controls.Add(this.lstName);
            this.Controls.Add(this.Label1);
            this.Name = "CS8Form";
            this.Text = "CS8 Jim Harris";
            this.Load += new System.EventHandler(this.CS8Form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.Button btnExit;
        internal System.Windows.Forms.TextBox txtSearchResults;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.TextBox txtSearchName;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Button btnSearchByName;
        internal System.Windows.Forms.Button btnSortByName;
        internal System.Windows.Forms.ListBox lstName;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.Button btnDelete;
    }
}

