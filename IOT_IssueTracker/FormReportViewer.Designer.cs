namespace IOT_IssueTracker
{
    partial class FormReportViewer
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
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.reportViewerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.InternetOfThingsDataSet = new IOT_IssueTracker.InternetOfThingsDataSet();
            this.IssuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.IssuesTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.IssuesTableAdapter();
            this.issuesBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewerTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.ReportViewerTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.reportViewerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternetOfThingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewerBindingSource
            // 
            this.reportViewerBindingSource.DataMember = "ReportViewer";
            this.reportViewerBindingSource.DataSource = this.InternetOfThingsDataSet;
            // 
            // InternetOfThingsDataSet
            // 
            this.InternetOfThingsDataSet.DataSetName = "InternetOfThingsDataSet";
            this.InternetOfThingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // IssuesBindingSource
            // 
            this.IssuesBindingSource.DataMember = "Issues";
            this.IssuesBindingSource.DataSource = this.InternetOfThingsDataSet;
            // 
            // reportViewer1
            // 
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.reportViewerBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "IOT_IssueTracker.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(61, 44);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(529, 366);
            this.reportViewer1.TabIndex = 0;
            // 
            // IssuesTableAdapter
            // 
            this.IssuesTableAdapter.ClearBeforeFill = true;
            // 
            // issuesBindingSource1
            // 
            this.issuesBindingSource1.DataMember = "Issues";
            this.issuesBindingSource1.DataSource = this.InternetOfThingsDataSet;
            // 
            // reportViewerTableAdapter
            // 
            this.reportViewerTableAdapter.ClearBeforeFill = true;
            // 
            // FormReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(694, 451);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormReportViewer";
            this.Text = "Issue Report By User";
            this.Load += new System.EventHandler(this.FormReportViewer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reportViewerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.InternetOfThingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IssuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource IssuesBindingSource;
        private InternetOfThingsDataSet InternetOfThingsDataSet;
        private InternetOfThingsDataSetTableAdapters.IssuesTableAdapter IssuesTableAdapter;
        private System.Windows.Forms.BindingSource issuesBindingSource1;
        private System.Windows.Forms.BindingSource reportViewerBindingSource;
        private InternetOfThingsDataSetTableAdapters.ReportViewerTableAdapter reportViewerTableAdapter;
    }
}