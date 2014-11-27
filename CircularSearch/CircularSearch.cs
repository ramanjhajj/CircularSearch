using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Deployment.Application;

namespace CircularSearch
{
    public partial class CircularSearch : Form
    {
        //Constants
        public const string K_FILE_NAME = "DataStore.xml";
        public const string K_CIRDATE = "CIRDATE";
        public const string K_CIRNO = "CIRNO";
        public const string K_CIRSUB = "CIRSUB";

        //Global Variables
        DataTable circularTable = new DataTable("CircularRecords");
        bool processingStopped = false;
        bool newEntryToWrite = false;
        bool deleteMultiple = false;
        int rowsToDelete = 0;
        bool deleteConfirmed = false;


        public CircularSearch()
        {
            InitializeComponent();

            try
            {
                CreateDataTable();
                ReadRecords();

                foreach (DataRow row in circularTable.Select())
                {
                    string year = row[K_CIRDATE].ToString().Substring(6, 4);

                    int yearInt = Convert.ToInt32(year);

                    if (yearInt <= 2005)
                    {
                        row.Delete();
                    }
                }

                labelTotal.Text = circularTable.Rows.Count.ToString();

                dataGridView1.DataSource = circularTable;
                dataGridView1.Columns[0].HeaderText = "Date";
                dataGridView1.Columns[1].HeaderText = "Circular Number";
                dataGridView1.Columns[2].HeaderText = "Circular";
            }
            catch
            {
                labelMessage.Text = "Error is reading data, Please restart the program";
            }

            //foreach (DataRow row in circularTable.Rows)
            //{
            //string date = row[K_CIRDATE].ToString().Substring(0, 2);
            //string month = row[K_CIRDATE].ToString().Substring(3, 2);
            //string year = row[K_CIRDATE].ToString().Substring(6, 4);

            //DateTime value = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(date));
            //row[K_CIRDATE] = value.ToString().Split(' ')[0];
            //}

            //WriteRecords();

        }

        #region CREATE TABLE
        /// <summary>
        /// Function to create datatable to store records.
        /// </summary>
        public void CreateDataTable()
        {
            //Column PK id
            //DataColumn pkID = new DataColumn(K_PK_ID);

            //pkID.DataType = typeof(int);
            //pkID.Unique = true;
            //pkID.AllowDBNull = false;
            //pkID.Caption = K_PK_ID;
            //pkID.AutoIncrement = true;
            //pkID.AutoIncrementSeed = 1;
            //pkID.AutoIncrementStep = 1;
            //circularTable.Columns.Add(pkID);

            //Column Circular Date
            DataColumn cirDate = new DataColumn(K_CIRDATE);
            cirDate.DataType = typeof(string);
            cirDate.MaxLength = 250;
            cirDate.Caption = "Date";
            //cirDate.ColumnName = "Date";
            circularTable.Columns.Add(cirDate);

            //Column Circular Number
            DataColumn cirNo = new DataColumn(K_CIRNO);
            cirNo.DataType = typeof(string);
            cirNo.MaxLength = 250;
            cirNo.Caption = "Number";
            //cirNo.ColumnName = "Number";
            circularTable.Columns.Add(cirNo);

            //Column Circular Subject
            DataColumn cirSub = new DataColumn(K_CIRSUB);
            cirSub.DataType = typeof(string);
            //cirSub.MaxLength = 250;
            cirSub.Caption = "Subject";
            //cirSub.ColumnName = "Circular Subject";
            circularTable.Columns.Add(cirSub);

            //setting the PK id column as the primary key of the data table
            //circularTable.PrimaryKey = new DataColumn[] { pkID };
        }
        #endregion

        #region READ RECORDS
        /// <summary>
        /// Function to read records from the XML file if present and storing in Datatable
        /// </summary>
        public void ReadRecords()
        {
            //try
            //{
            //    if (File.Exists(K_FILE_NAME))
            //    {
            //        circularTable.ReadXml(K_FILE_NAME);
            //    }
            //}
            //catch
            //{
            //    labelMessage.Text = "Error in reading data, Please restart the program";
            //}

            if (ApplicationDeployment.IsNetworkDeployed)
            {
                try
                {
                    if(File.Exists(ApplicationDeployment.CurrentDeployment.DataDirectory + @"\DataStore.xml"))
                    {
                        circularTable.ReadXml(ApplicationDeployment.CurrentDeployment.DataDirectory + @"\DataStore.xml");
                    }
                }
                catch (Exception ex)
                {
                    labelMessage.Text = "Error is reading data, Please restart the program";
                }
            }
        }
        #endregion

        #region WRITE RECORD
        /// <summary>
        /// Function to insert new row in the datatable and writing data to XML
        /// </summary>
        /// <returns></returns>
        public void WriteRecords()
        {
            try
            {
                //Write the XML file
                //circularTable.WriteXml(K_FILE_NAME);
                circularTable.WriteXml(ApplicationDeployment.CurrentDeployment.DataDirectory + @"\DataStore.xml");
            }
            catch { }

        }
        #endregion

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {
                labelMessage.Text = "Processing. Please Wait....";

                if (textBoxSearch.Text.Length > 0)
                {
                    (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = K_CIRSUB + " LIKE '%" + textBoxSearch.Text + "%'";
                }

                labelMessage.Text = "";
            }
            catch
            {
                labelMessage.Text = "There is an issue with data, Please restart the program";
            }
        }

        public bool processNewEntries(string path)
        {
            string cirDate = null;
            string number = null;
            string subject = null;
            string txtFileName = null;
            bool result = true;

            //CreateDataTable();
            try
            {
                string[] files = Directory.GetFiles(path);

                if (files.Length > 0)
                {
                    textBoxOutput.Text += "No. of files found: " + files.Length.ToString() + Environment.NewLine;

                    // create an instance of the pdfparser class
                    PDFParser pdfParser = new PDFParser();

                    foreach (string pdfFile in files)
                    {
                        if (!processingStopped)
                        {
                            textBoxOutput.Text += "Processing File : " + pdfFile.ToString() + Environment.NewLine;
                            txtFileName = Path.GetFileNameWithoutExtension(pdfFile);
                            number = txtFileName;

                            // extract the text
                            pdfParser.ExtractText(pdfFile, txtFileName + ".txt");

                            StreamReader file = new StreamReader(txtFileName + ".txt");
                            string line;
                            bool marker = false;
                            while ((line = file.ReadLine()) != null)
                            {
                                if (line.Trim() == "O")
                                {
                                    marker = false;
                                    break;
                                }
                                else if (line.Trim().Length > 0)
                                {
                                    if (!marker)
                                    {
                                        int index = line.IndexOf("Date:");
                                        if (index > 0)
                                        {
                                            cirDate = line.Substring(index + 5).Trim();

                                            if (cirDate != "")
                                            {
                                                string date = cirDate.Substring(0, 2);
                                                string month = cirDate.Substring(3, 2);
                                                string year = cirDate.Substring(6, 4);

                                                DateTime value = new DateTime(Convert.ToInt32(year), Convert.ToInt32(month), Convert.ToInt32(date));
                                                cirDate = value.ToString().Split(' ')[0];
                                            }
                                        }
                                        else
                                        {
                                            int utilIndex = line.IndexOf("UTILITY");
                                            if (utilIndex > 0)
                                            {
                                                marker = true;
                                            }
                                        }
                                    }
                                    else
                                    {
                                        subject += line.Trim() + " ";
                                    }
                                }
                            }

                            file.Close();

                            File.Delete(txtFileName + ".txt");

                            //Create a data row and assign values from the patient property
                            if (cirDate != "" && number != "" && subject != "")
                            {
                                DataRow newRecord = circularTable.NewRow();
                                newRecord[K_CIRDATE] = cirDate;
                                newRecord[K_CIRNO] = number;
                                newRecord[K_CIRSUB] = subject;

                                circularTable.Rows.Add(newRecord);
                            }
                            else
                            {
                                textBoxOutput.Text += "PROBLEM PROCESSING FILE " + number + Environment.NewLine;
                            }

                            cirDate = "";
                            number = "";
                            subject = "";
                        }
                        else
                        {
                            textBoxOutput.Text += "PROCESSING OF NEW FILE CANCELED "+ Environment.NewLine;
                            break;
                        }
                    }

                    if (!processingStopped)
                    {
                        textBoxOutput.Text += "----------COMPLETED------------" + Environment.NewLine;
                    }

                    btnStop.Enabled = false;
                    btnBackToSearch.Enabled = true;
                }
                result = true;
            }
            catch
            {
                result = false;
                textBoxOutput.Text += "ERROR IN PROCESSING FILES, PLEASE RESTART THE PROGRAM";
            }
            return result;
        }
        
        private void btnBackToSearch_Click(object sender, EventArgs e)
        {
            panelAddNew.Visible = false;
            panelSearch.Visible = true;
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            processingStopped = true;
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelTotal.Text = circularTable.Rows.Count.ToString();

            panelAddNew.Visible = false;
            panelManualEntry.Visible = false;
            panelSearch.Visible = true;

            if (newEntryToWrite)
            {
                newEntryToWrite = false;
                WriteRecords();
            }
        }

        private void autoProcessNewFilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bool processingResult;
            DialogResult result = folderBrowserDialog1.ShowDialog();

            if (result == DialogResult.OK) // Test result.
            {
                try
                {
                    panelSearch.Visible = false;
                    panelManualEntry.Visible = false;

                    string path = folderBrowserDialog1.SelectedPath;

                    labelProcessing.Text = path;
                    btnStop.Enabled = true;
                    btnBackToSearch.Enabled = false;
                    panelAddNew.Visible = true;

                    processingResult = processNewEntries(path);

                    if (processingResult)
                    {
                        WriteRecords();
                    }
                    else
                    {
                        ReadRecords();
                    }

                    labelTotal.Text = circularTable.Rows.Count.ToString();
                }
                catch (IOException)
                {
                }
            }

            if (newEntryToWrite)
            {
                newEntryToWrite = false;
                WriteRecords();
            }
        }

        private void manualEntryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            labelMETotalRecords.Text = circularTable.Rows.Count.ToString();

            panelAddNew.Visible = false;
            panelSearch.Visible = false;
            panelManualEntry.Visible = true;

            if (newEntryToWrite)
            {
                newEntryToWrite = false;
                WriteRecords();
            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            textBoxDate.Text = String.Empty;
            textBoxNumber.Text = String.Empty;
            textBoxSubject.Text = String.Empty;
        }

        private void btnSaveEntry_Click(object sender, EventArgs e)
        {
            string date = textBoxDate.Text;
            string number = textBoxNumber.Text;
            string subject = textBoxSubject.Text;

            //Create a data row and assign values from the patient property
            if (date != "" && number != "" && subject != "")
            {
                DataRow newRecord = circularTable.NewRow();
                newRecord[K_CIRDATE] = date;
                newRecord[K_CIRNO] = number;
                newRecord[K_CIRSUB] = subject;

                circularTable.Rows.Add(newRecord);

                labelMETotalRecords.Text = circularTable.Rows.Count.ToString();
                labelSuccess.Visible = true;

                newEntryToWrite = true;

                btnCancel_Click(sender, e);
            }
            else
            {
                labelErrorMessage.Visible = true;
            }
        }

        private void CircularSearch_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (newEntryToWrite)
            {
                newEntryToWrite = false;
                WriteRecords();
            }
        }

        private void hideMessages(object sender, EventArgs e)
        {
            labelErrorMessage.Visible = false;
            labelSuccess.Visible = false;
        }

        private void dataGridView1_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            labelMessage.Text = "Processing. Please Wait....";
            //Delete multuple is used to make sure if multiple rows are being delete, dialog is not displayed for everyrow, just for first row.
            if (deleteMultiple == false)
            {
                DialogResult res = MessageBox.Show("Are you sure you want to delete "+ dataGridView1.SelectedRows.Count +" row(s)?", "Delete confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                //if selected rows are more then 1, multiple delete is true and dialog should not be displayed again.
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    deleteMultiple = true;
                }
                else
                {
                    deleteMultiple = false;
                }

                //check no. of rows to delete, this is used in UserDeletedRows function. To make sure file is written only after all the deletion and not after every row deletion.
                rowsToDelete = dataGridView1.SelectedRows.Count;

                if (res == DialogResult.No)
                {
                    deleteConfirmed = false;
                }

                if (res == DialogResult.Yes)
                {
                    deleteConfirmed = true;
                }
            }

            if (!deleteConfirmed)
            {
                e.Cancel = true;
            }
        }

        private void dataGridView1_UserDeletedRow(object sender, DataGridViewRowEventArgs e)
        {
            --rowsToDelete;
            labelMessage.Text = "Done";
            if (rowsToDelete == 0)
            {
                WriteRecords();
                labelTotal.Text = circularTable.Rows.Count.ToString();
                deleteMultiple = false;
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                labelMessage.Text = "Press [Del] to delete selected row(s).";
            }
            else
            {
                labelMessage.Text = "";
            }
        }
    }
}
