namespace CircularSearch
{
    partial class CircularSearch
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.panelAddNew = new System.Windows.Forms.Panel();
            this.btnStop = new System.Windows.Forms.Button();
            this.btnBackToSearch = new System.Windows.Forms.Button();
            this.labelProcessing = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.panelSearch = new System.Windows.Forms.Panel();
            this.btnViewAll = new System.Windows.Forms.Button();
            this.labelMessage = new System.Windows.Forms.Label();
            this.labelSelectedRows = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autoProcessNewFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualEntryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panelManualEntry = new System.Windows.Forms.Panel();
            this.labelErrorMessage = new System.Windows.Forms.Label();
            this.labelSuccess = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.labelMETotalRecords = new System.Windows.Forms.Label();
            this.textBoxDate = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSaveEntry = new System.Windows.Forms.Button();
            this.textBoxSubject = new System.Windows.Forms.TextBox();
            this.textBoxNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panelAddNew.SuspendLayout();
            this.panelSearch.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.panelManualEntry.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelAddNew
            // 
            this.panelAddNew.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelAddNew.Controls.Add(this.btnStop);
            this.panelAddNew.Controls.Add(this.btnBackToSearch);
            this.panelAddNew.Controls.Add(this.labelProcessing);
            this.panelAddNew.Controls.Add(this.label9);
            this.panelAddNew.Controls.Add(this.textBoxOutput);
            this.panelAddNew.Location = new System.Drawing.Point(0, 37);
            this.panelAddNew.Name = "panelAddNew";
            this.panelAddNew.Size = new System.Drawing.Size(852, 430);
            this.panelAddNew.TabIndex = 13;
            this.panelAddNew.Visible = false;
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(488, 19);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(139, 23);
            this.btnStop.TabIndex = 7;
            this.btnStop.Text = "Stop and Revert";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnBackToSearch
            // 
            this.btnBackToSearch.Enabled = false;
            this.btnBackToSearch.Location = new System.Drawing.Point(633, 18);
            this.btnBackToSearch.Name = "btnBackToSearch";
            this.btnBackToSearch.Size = new System.Drawing.Size(183, 23);
            this.btnBackToSearch.TabIndex = 6;
            this.btnBackToSearch.Text = "Back To Search";
            this.btnBackToSearch.UseVisualStyleBackColor = true;
            this.btnBackToSearch.Click += new System.EventHandler(this.btnBackToSearch_Click);
            // 
            // labelProcessing
            // 
            this.labelProcessing.AutoSize = true;
            this.labelProcessing.Location = new System.Drawing.Point(146, 29);
            this.labelProcessing.Name = "labelProcessing";
            this.labelProcessing.Size = new System.Drawing.Size(35, 13);
            this.labelProcessing.TabIndex = 5;
            this.labelProcessing.Text = "label2";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(30, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 13);
            this.label9.TabIndex = 4;
            this.label9.Text = "Processing files from :";
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.Location = new System.Drawing.Point(33, 63);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(783, 345);
            this.textBoxOutput.TabIndex = 3;
            // 
            // panelSearch
            // 
            this.panelSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelSearch.Controls.Add(this.btnViewAll);
            this.panelSearch.Controls.Add(this.labelMessage);
            this.panelSearch.Controls.Add(this.labelSelectedRows);
            this.panelSearch.Controls.Add(this.label4);
            this.panelSearch.Controls.Add(this.labelTotal);
            this.panelSearch.Controls.Add(this.label1);
            this.panelSearch.Controls.Add(this.buttonSearch);
            this.panelSearch.Controls.Add(this.textBoxSearch);
            this.panelSearch.Controls.Add(this.dataGridView1);
            this.panelSearch.Location = new System.Drawing.Point(0, 37);
            this.panelSearch.Name = "panelSearch";
            this.panelSearch.Size = new System.Drawing.Size(852, 430);
            this.panelSearch.TabIndex = 14;
            // 
            // btnViewAll
            // 
            this.btnViewAll.Location = new System.Drawing.Point(682, 10);
            this.btnViewAll.Name = "btnViewAll";
            this.btnViewAll.Size = new System.Drawing.Size(134, 23);
            this.btnViewAll.TabIndex = 24;
            this.btnViewAll.Text = "View All Records";
            this.btnViewAll.UseVisualStyleBackColor = true;
            this.btnViewAll.Click += new System.EventHandler(this.btnViewAll_Click);
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.ForeColor = System.Drawing.Color.Red;
            this.labelMessage.Location = new System.Drawing.Point(12, 405);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(0, 13);
            this.labelMessage.TabIndex = 23;
            // 
            // labelSelectedRows
            // 
            this.labelSelectedRows.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelSelectedRows.AutoSize = true;
            this.labelSelectedRows.Location = new System.Drawing.Point(641, 405);
            this.labelSelectedRows.Name = "labelSelectedRows";
            this.labelSelectedRows.Size = new System.Drawing.Size(0, 13);
            this.labelSelectedRows.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(535, 405);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 21;
            // 
            // labelTotal
            // 
            this.labelTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotal.AutoSize = true;
            this.labelTotal.Location = new System.Drawing.Point(776, 405);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(0, 13);
            this.labelTotal.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(678, 405);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Total Records :";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(522, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(120, 23);
            this.buttonSearch.TabIndex = 17;
            this.buttonSearch.Text = "Search";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(15, 14);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(483, 20);
            this.textBoxSearch.TabIndex = 16;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridView1.Location = new System.Drawing.Point(0, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(851, 341);
            this.dataGridView1.TabIndex = 15;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.UserDeletedRow += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_UserDeletedRow);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.dataGridView1_UserDeletingRow);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.autoProcessNewFilesToolStripMenuItem,
            this.manualEntryToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(851, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // autoProcessNewFilesToolStripMenuItem
            // 
            this.autoProcessNewFilesToolStripMenuItem.Name = "autoProcessNewFilesToolStripMenuItem";
            this.autoProcessNewFilesToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.autoProcessNewFilesToolStripMenuItem.Text = "Auto Process New Circulars";
            this.autoProcessNewFilesToolStripMenuItem.Click += new System.EventHandler(this.autoProcessNewFilesToolStripMenuItem_Click);
            // 
            // manualEntryToolStripMenuItem
            // 
            this.manualEntryToolStripMenuItem.Name = "manualEntryToolStripMenuItem";
            this.manualEntryToolStripMenuItem.Size = new System.Drawing.Size(89, 20);
            this.manualEntryToolStripMenuItem.Text = "Manual Entry";
            this.manualEntryToolStripMenuItem.Click += new System.EventHandler(this.manualEntryToolStripMenuItem_Click);
            // 
            // panelManualEntry
            // 
            this.panelManualEntry.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panelManualEntry.Controls.Add(this.labelErrorMessage);
            this.panelManualEntry.Controls.Add(this.labelSuccess);
            this.panelManualEntry.Controls.Add(this.label7);
            this.panelManualEntry.Controls.Add(this.labelMETotalRecords);
            this.panelManualEntry.Controls.Add(this.textBoxDate);
            this.panelManualEntry.Controls.Add(this.label6);
            this.panelManualEntry.Controls.Add(this.btnCancel);
            this.panelManualEntry.Controls.Add(this.btnSaveEntry);
            this.panelManualEntry.Controls.Add(this.textBoxSubject);
            this.panelManualEntry.Controls.Add(this.textBoxNumber);
            this.panelManualEntry.Controls.Add(this.label5);
            this.panelManualEntry.Controls.Add(this.label3);
            this.panelManualEntry.Controls.Add(this.label2);
            this.panelManualEntry.Location = new System.Drawing.Point(0, 37);
            this.panelManualEntry.Name = "panelManualEntry";
            this.panelManualEntry.Size = new System.Drawing.Size(852, 430);
            this.panelManualEntry.TabIndex = 16;
            this.panelManualEntry.Visible = false;
            // 
            // labelErrorMessage
            // 
            this.labelErrorMessage.AutoSize = true;
            this.labelErrorMessage.ForeColor = System.Drawing.Color.Red;
            this.labelErrorMessage.Location = new System.Drawing.Point(71, 284);
            this.labelErrorMessage.Name = "labelErrorMessage";
            this.labelErrorMessage.Size = new System.Drawing.Size(323, 13);
            this.labelErrorMessage.TabIndex = 17;
            this.labelErrorMessage.Text = "* Required field(s) missing. All the 3 fields are required. Please Enter";
            this.labelErrorMessage.Visible = false;
            // 
            // labelSuccess
            // 
            this.labelSuccess.AutoSize = true;
            this.labelSuccess.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.labelSuccess.Location = new System.Drawing.Point(71, 323);
            this.labelSuccess.Name = "labelSuccess";
            this.labelSuccess.Size = new System.Drawing.Size(142, 13);
            this.labelSuccess.TabIndex = 18;
            this.labelSuccess.Text = "* Record added successfully";
            this.labelSuccess.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(71, 245);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Total Records :";
            // 
            // labelMETotalRecords
            // 
            this.labelMETotalRecords.AutoSize = true;
            this.labelMETotalRecords.Location = new System.Drawing.Point(178, 245);
            this.labelMETotalRecords.Name = "labelMETotalRecords";
            this.labelMETotalRecords.Size = new System.Drawing.Size(0, 13);
            this.labelMETotalRecords.TabIndex = 18;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Location = new System.Drawing.Point(181, 21);
            this.textBoxDate.Mask = "00-00-0000";
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(211, 20);
            this.textBoxDate.TabIndex = 9;
            this.textBoxDate.Enter += new System.EventHandler(this.hideMessages);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(398, 24);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "(dd-mm-yyyy)";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(246, 179);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(135, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel / Clear";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSaveEntry
            // 
            this.btnSaveEntry.Location = new System.Drawing.Point(74, 179);
            this.btnSaveEntry.Name = "btnSaveEntry";
            this.btnSaveEntry.Size = new System.Drawing.Size(120, 23);
            this.btnSaveEntry.TabIndex = 6;
            this.btnSaveEntry.Text = "Save";
            this.btnSaveEntry.UseVisualStyleBackColor = true;
            this.btnSaveEntry.Click += new System.EventHandler(this.btnSaveEntry_Click);
            // 
            // textBoxSubject
            // 
            this.textBoxSubject.Location = new System.Drawing.Point(181, 108);
            this.textBoxSubject.Name = "textBoxSubject";
            this.textBoxSubject.Size = new System.Drawing.Size(595, 20);
            this.textBoxSubject.TabIndex = 5;
            this.textBoxSubject.Enter += new System.EventHandler(this.hideMessages);
            // 
            // textBoxNumber
            // 
            this.textBoxNumber.Location = new System.Drawing.Point(181, 63);
            this.textBoxNumber.Name = "textBoxNumber";
            this.textBoxNumber.Size = new System.Drawing.Size(211, 20);
            this.textBoxNumber.TabIndex = 4;
            this.textBoxNumber.Enter += new System.EventHandler(this.hideMessages);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(58, 108);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Circular Subject :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Circular Number :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(71, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Circular Date :";
            // 
            // CircularSearch
            // 
            this.AcceptButton = this.buttonSearch;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(851, 467);
            this.Controls.Add(this.panelSearch);
            this.Controls.Add(this.panelAddNew);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.panelManualEntry);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CircularSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Circular Search";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CircularSearch_FormClosing);
            this.panelAddNew.ResumeLayout(false);
            this.panelAddNew.PerformLayout();
            this.panelSearch.ResumeLayout(false);
            this.panelSearch.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panelManualEntry.ResumeLayout(false);
            this.panelManualEntry.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.Panel panelAddNew;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.Button btnBackToSearch;
        private System.Windows.Forms.Label labelProcessing;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Panel panelSearch;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Label labelSelectedRows;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autoProcessNewFilesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualEntryToolStripMenuItem;
        private System.Windows.Forms.Button btnViewAll;
        private System.Windows.Forms.Panel panelManualEntry;
        private System.Windows.Forms.MaskedTextBox textBoxDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSaveEntry;
        private System.Windows.Forms.TextBox textBoxSubject;
        private System.Windows.Forms.TextBox textBoxNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label labelMETotalRecords;
        private System.Windows.Forms.Label labelErrorMessage;
        private System.Windows.Forms.Label labelSuccess;
        private System.Windows.Forms.DataGridView dataGridView1;



    }
}

