namespace IOT_IssueTracker
{
    partial class frmIssueTracker
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
            System.Windows.Forms.Label resolutionCommentLabel;
            System.Windows.Forms.Label thingLabel;
            System.Windows.Forms.Label homeUserLabel;
            System.Windows.Forms.Label statusLabel;
            System.Windows.Forms.Label descriptionLabel;
            System.Windows.Forms.Label iDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIssueTracker));
            this.internetOfThingsDataSet = new IOT_IssueTracker.InternetOfThingsDataSet();
            this.issuesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.issuesTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.IssuesTableAdapter();
            this.tableAdapterManager = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.TableAdapterManager();
            this.homeUsersTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.HomeUsersTableAdapter();
            this.statusesTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.StatusesTableAdapter();
            this.thingsTableAdapter = new IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.ThingsTableAdapter();
            this.issuesBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonCancel = new System.Windows.Forms.ToolStripButton();
            this.issuesBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.statusesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.homeUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.thingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fillByUserToolStrip = new System.Windows.Forms.ToolStrip();
            this.homeUserToolStripLabel = new System.Windows.Forms.ToolStripLabel();
            this.homeUserToolStripComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.fillByUserToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonAll = new System.Windows.Forms.ToolStripButton();
            this.resolutionCommentTextBox = new System.Windows.Forms.TextBox();
            this.thingComboBox = new System.Windows.Forms.ComboBox();
            this.homeUserComboBox = new System.Windows.Forms.ComboBox();
            this.statusComboBox = new System.Windows.Forms.ComboBox();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.iDTextBox = new System.Windows.Forms.TextBox();
            this.btnIssueReport = new System.Windows.Forms.Button();
            resolutionCommentLabel = new System.Windows.Forms.Label();
            thingLabel = new System.Windows.Forms.Label();
            homeUserLabel = new System.Windows.Forms.Label();
            statusLabel = new System.Windows.Forms.Label();
            descriptionLabel = new System.Windows.Forms.Label();
            iDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.internetOfThingsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingNavigator)).BeginInit();
            this.issuesBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsBindingSource)).BeginInit();
            this.fillByUserToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // resolutionCommentLabel
            // 
            resolutionCommentLabel.AutoSize = true;
            resolutionCommentLabel.Location = new System.Drawing.Point(61, 227);
            resolutionCommentLabel.Name = "resolutionCommentLabel";
            resolutionCommentLabel.Size = new System.Drawing.Size(107, 13);
            resolutionCommentLabel.TabIndex = 11;
            resolutionCommentLabel.Text = "Resolution Comment:";
            // 
            // thingLabel
            // 
            thingLabel.AutoSize = true;
            thingLabel.Location = new System.Drawing.Point(61, 174);
            thingLabel.Name = "thingLabel";
            thingLabel.Size = new System.Drawing.Size(37, 13);
            thingLabel.TabIndex = 9;
            thingLabel.Text = "Thing:";
            // 
            // homeUserLabel
            // 
            homeUserLabel.AutoSize = true;
            homeUserLabel.Location = new System.Drawing.Point(61, 147);
            homeUserLabel.Name = "homeUserLabel";
            homeUserLabel.Size = new System.Drawing.Size(63, 13);
            homeUserLabel.TabIndex = 7;
            homeUserLabel.Text = "Home User:";
            // 
            // statusLabel
            // 
            statusLabel.AutoSize = true;
            statusLabel.Location = new System.Drawing.Point(61, 120);
            statusLabel.Name = "statusLabel";
            statusLabel.Size = new System.Drawing.Size(40, 13);
            statusLabel.TabIndex = 5;
            statusLabel.Text = "Status:";
            // 
            // descriptionLabel
            // 
            descriptionLabel.AutoSize = true;
            descriptionLabel.Location = new System.Drawing.Point(61, 201);
            descriptionLabel.Name = "descriptionLabel";
            descriptionLabel.Size = new System.Drawing.Size(63, 13);
            descriptionLabel.TabIndex = 3;
            descriptionLabel.Text = "Description:";
            // 
            // iDLabel
            // 
            iDLabel.AutoSize = true;
            iDLabel.Location = new System.Drawing.Point(61, 94);
            iDLabel.Name = "iDLabel";
            iDLabel.Size = new System.Drawing.Size(21, 13);
            iDLabel.TabIndex = 1;
            iDLabel.Text = "ID:";
            // 
            // internetOfThingsDataSet
            // 
            this.internetOfThingsDataSet.DataSetName = "InternetOfThingsDataSet";
            this.internetOfThingsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // issuesBindingSource
            // 
            this.issuesBindingSource.DataMember = "Issues";
            this.issuesBindingSource.DataSource = this.internetOfThingsDataSet;
            // 
            // issuesTableAdapter
            // 
            this.issuesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.HomeUsersTableAdapter = this.homeUsersTableAdapter;
            this.tableAdapterManager.IssuesTableAdapter = this.issuesTableAdapter;
            this.tableAdapterManager.StatusesTableAdapter = this.statusesTableAdapter;
            this.tableAdapterManager.ThingsTableAdapter = this.thingsTableAdapter;
            this.tableAdapterManager.UpdateOrder = IOT_IssueTracker.InternetOfThingsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // homeUsersTableAdapter
            // 
            this.homeUsersTableAdapter.ClearBeforeFill = true;
            // 
            // statusesTableAdapter
            // 
            this.statusesTableAdapter.ClearBeforeFill = true;
            // 
            // thingsTableAdapter
            // 
            this.thingsTableAdapter.ClearBeforeFill = true;
            // 
            // issuesBindingNavigator
            // 
            this.issuesBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.issuesBindingNavigator.BindingSource = this.issuesBindingSource;
            this.issuesBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.issuesBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.issuesBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.toolStripButtonCancel,
            this.issuesBindingNavigatorSaveItem});
            this.issuesBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.issuesBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.issuesBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.issuesBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.issuesBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.issuesBindingNavigator.Name = "issuesBindingNavigator";
            this.issuesBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.issuesBindingNavigator.Size = new System.Drawing.Size(473, 25);
            this.issuesBindingNavigator.TabIndex = 0;
            this.issuesBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(36, 22);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 21);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonCancel
            // 
            this.toolStripButtonCancel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonCancel.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCancel.Image")));
            this.toolStripButtonCancel.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCancel.Name = "toolStripButtonCancel";
            this.toolStripButtonCancel.Size = new System.Drawing.Size(43, 22);
            this.toolStripButtonCancel.Text = "Cancel";
            this.toolStripButtonCancel.Click += new System.EventHandler(this.toolStripButtonCancel_Click);
            // 
            // issuesBindingNavigatorSaveItem
            // 
            this.issuesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.issuesBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("issuesBindingNavigatorSaveItem.Image")));
            this.issuesBindingNavigatorSaveItem.Name = "issuesBindingNavigatorSaveItem";
            this.issuesBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.issuesBindingNavigatorSaveItem.Text = "Save Data";
            this.issuesBindingNavigatorSaveItem.Click += new System.EventHandler(this.issuesBindingNavigatorSaveItem_Click);
            // 
            // statusesBindingSource
            // 
            this.statusesBindingSource.DataMember = "Statuses";
            this.statusesBindingSource.DataSource = this.internetOfThingsDataSet;
            // 
            // homeUsersBindingSource
            // 
            this.homeUsersBindingSource.DataMember = "HomeUsers";
            this.homeUsersBindingSource.DataSource = this.internetOfThingsDataSet;
            // 
            // thingsBindingSource
            // 
            this.thingsBindingSource.DataMember = "Things";
            this.thingsBindingSource.DataSource = this.internetOfThingsDataSet;
            // 
            // fillByUserToolStrip
            // 
            this.fillByUserToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.homeUserToolStripLabel,
            this.homeUserToolStripComboBox,
            this.fillByUserToolStripButton,
            this.toolStripSeparator1,
            this.toolStripButtonAll});
            this.fillByUserToolStrip.Location = new System.Drawing.Point(0, 25);
            this.fillByUserToolStrip.Name = "fillByUserToolStrip";
            this.fillByUserToolStrip.Size = new System.Drawing.Size(473, 25);
            this.fillByUserToolStrip.TabIndex = 13;
            this.fillByUserToolStrip.Text = "fillByUserToolStrip";
            // 
            // homeUserToolStripLabel
            // 
            this.homeUserToolStripLabel.Name = "homeUserToolStripLabel";
            this.homeUserToolStripLabel.Size = new System.Drawing.Size(63, 22);
            this.homeUserToolStripLabel.Text = "Home User:";
            // 
            // homeUserToolStripComboBox
            // 
            this.homeUserToolStripComboBox.Name = "homeUserToolStripComboBox";
            this.homeUserToolStripComboBox.Size = new System.Drawing.Size(100, 25);
            // 
            // fillByUserToolStripButton
            // 
            this.fillByUserToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.fillByUserToolStripButton.Name = "fillByUserToolStripButton";
            this.fillByUserToolStripButton.Size = new System.Drawing.Size(68, 22);
            this.fillByUserToolStripButton.Text = "Get By User";
            this.fillByUserToolStripButton.Click += new System.EventHandler(this.fillByUserToolStripButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripButtonAll
            // 
            this.toolStripButtonAll.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAll.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonAll.Name = "toolStripButtonAll";
            this.toolStripButtonAll.Size = new System.Drawing.Size(76, 22);
            this.toolStripButtonAll.Text = "Get All Issues";
            this.toolStripButtonAll.Click += new System.EventHandler(this.toolStripButtonAll_Click);
            // 
            // resolutionCommentTextBox
            // 
            this.resolutionCommentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuesBindingSource, "ResolutionComment", true));
            this.resolutionCommentTextBox.Location = new System.Drawing.Point(174, 224);
            this.resolutionCommentTextBox.Name = "resolutionCommentTextBox";
            this.resolutionCommentTextBox.Size = new System.Drawing.Size(234, 20);
            this.resolutionCommentTextBox.TabIndex = 12;
            // 
            // thingComboBox
            // 
            this.thingComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.issuesBindingSource, "Thing", true));
            this.thingComboBox.DataSource = this.thingsBindingSource;
            this.thingComboBox.DisplayMember = "Description";
            this.thingComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.thingComboBox.FormattingEnabled = true;
            this.thingComboBox.Location = new System.Drawing.Point(174, 171);
            this.thingComboBox.Name = "thingComboBox";
            this.thingComboBox.Size = new System.Drawing.Size(121, 21);
            this.thingComboBox.TabIndex = 10;
            this.thingComboBox.ValueMember = "ID";
            // 
            // homeUserComboBox
            // 
            this.homeUserComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.issuesBindingSource, "HomeUser", true));
            this.homeUserComboBox.DataSource = this.homeUsersBindingSource;
            this.homeUserComboBox.DisplayMember = "Name";
            this.homeUserComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.homeUserComboBox.FormattingEnabled = true;
            this.homeUserComboBox.Location = new System.Drawing.Point(174, 144);
            this.homeUserComboBox.Name = "homeUserComboBox";
            this.homeUserComboBox.Size = new System.Drawing.Size(121, 21);
            this.homeUserComboBox.TabIndex = 8;
            this.homeUserComboBox.ValueMember = "ID";
            // 
            // statusComboBox
            // 
            this.statusComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.issuesBindingSource, "Status", true));
            this.statusComboBox.DataSource = this.statusesBindingSource;
            this.statusComboBox.DisplayMember = "StatusName";
            this.statusComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.statusComboBox.FormattingEnabled = true;
            this.statusComboBox.Location = new System.Drawing.Point(174, 117);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Size = new System.Drawing.Size(121, 21);
            this.statusComboBox.TabIndex = 6;
            this.statusComboBox.ValueMember = "StatusCode";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuesBindingSource, "Description", true));
            this.descriptionTextBox.Location = new System.Drawing.Point(174, 198);
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(234, 20);
            this.descriptionTextBox.TabIndex = 4;
            // 
            // iDTextBox
            // 
            this.iDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.issuesBindingSource, "ID", true));
            this.iDTextBox.Enabled = false;
            this.iDTextBox.Location = new System.Drawing.Point(174, 91);
            this.iDTextBox.Name = "iDTextBox";
            this.iDTextBox.Size = new System.Drawing.Size(51, 20);
            this.iDTextBox.TabIndex = 2;
            // 
            // btnIssueReport
            // 
            this.btnIssueReport.Location = new System.Drawing.Point(174, 310);
            this.btnIssueReport.Name = "btnIssueReport";
            this.btnIssueReport.Size = new System.Drawing.Size(104, 23);
            this.btnIssueReport.TabIndex = 14;
            this.btnIssueReport.Text = "Report Viewer";
            this.btnIssueReport.UseVisualStyleBackColor = true;
            this.btnIssueReport.Click += new System.EventHandler(this.btnIssueReport_Click);
            // 
            // frmIssueTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 354);
            this.Controls.Add(this.btnIssueReport);
            this.Controls.Add(this.fillByUserToolStrip);
            this.Controls.Add(iDLabel);
            this.Controls.Add(this.iDTextBox);
            this.Controls.Add(descriptionLabel);
            this.Controls.Add(this.descriptionTextBox);
            this.Controls.Add(statusLabel);
            this.Controls.Add(this.statusComboBox);
            this.Controls.Add(homeUserLabel);
            this.Controls.Add(this.homeUserComboBox);
            this.Controls.Add(thingLabel);
            this.Controls.Add(this.thingComboBox);
            this.Controls.Add(resolutionCommentLabel);
            this.Controls.Add(this.resolutionCommentTextBox);
            this.Controls.Add(this.issuesBindingNavigator);
            this.Name = "frmIssueTracker";
            this.Text = "Internet Of Things Issue Tracker - Capstone Project - Jim Harris";
            this.Load += new System.EventHandler(this.frmIssueTracker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.internetOfThingsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.issuesBindingNavigator)).EndInit();
            this.issuesBindingNavigator.ResumeLayout(false);
            this.issuesBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.homeUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.thingsBindingSource)).EndInit();
            this.fillByUserToolStrip.ResumeLayout(false);
            this.fillByUserToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private InternetOfThingsDataSet internetOfThingsDataSet;
        private System.Windows.Forms.BindingSource issuesBindingSource;
        private InternetOfThingsDataSetTableAdapters.IssuesTableAdapter issuesTableAdapter;
        private InternetOfThingsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator issuesBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton issuesBindingNavigatorSaveItem;
        private InternetOfThingsDataSetTableAdapters.StatusesTableAdapter statusesTableAdapter;
        private System.Windows.Forms.BindingSource statusesBindingSource;
        private InternetOfThingsDataSetTableAdapters.HomeUsersTableAdapter homeUsersTableAdapter;
        private System.Windows.Forms.BindingSource homeUsersBindingSource;
        private InternetOfThingsDataSetTableAdapters.ThingsTableAdapter thingsTableAdapter;
        private System.Windows.Forms.BindingSource thingsBindingSource;
        private System.Windows.Forms.ToolStrip fillByUserToolStrip;
        private System.Windows.Forms.ToolStripLabel homeUserToolStripLabel;
        private System.Windows.Forms.ToolStripButton fillByUserToolStripButton;
        private System.Windows.Forms.ToolStripComboBox homeUserToolStripComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripButtonAll;
        private System.Windows.Forms.ToolStripButton toolStripButtonCancel;
        private System.Windows.Forms.TextBox resolutionCommentTextBox;
        private System.Windows.Forms.ComboBox thingComboBox;
        private System.Windows.Forms.ComboBox homeUserComboBox;
        private System.Windows.Forms.ComboBox statusComboBox;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.TextBox iDTextBox;
        private System.Windows.Forms.Button btnIssueReport;
    }
}

