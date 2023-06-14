using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Emgu.CV;
using Emgu.CV.Structure;
using Excel = Microsoft.Office.Interop.Excel;
using MySql.Data.MySqlClient;
using System.IO;

namespace ToolDetectCropSyncImage
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        System.Data.DataTable dataTable = new System.Data.DataTable();
        public readonly Color color_missing = Color.Yellow;
        FileInfo[] files;
        Dictionary<string, Dictionary<string, int>> mapDataTable = new Dictionary<string, Dictionary<string, int>>();
        int startDataRow = 2;
        string imageForm = "";
        int numberImage = 5;
        List<string> accountNames = new List<string>();
        List<string> employeeCodes = new List<string>();
        int employeeCodeLength = 0;
        private void Form1_Load(object sender, EventArgs e)
        {
            rad5Image.Checked = true;
            radEmpCode.Checked = true;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblSheetName_Click(object sender, EventArgs e)
        {

        }

        private void picImage3_Click(object sender, EventArgs e)
        {

        }

        private void picbImage1_Click(object sender, EventArgs e)
        {

        }

        private void btnImportExcel_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files Only|*.xlsx;*.xls";
            openFileDialog.Title = "Chose the file";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                txtExcelPath.Text = openFileDialog.FileName;
                try
                {
                    Excel.Application excelApp = new Excel.Application();
                    //excelApp.Visible = false;
                    //excelApp.DisplayAlerts = false;
                    Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(openFileDialog.FileName);
                    List<string> sheetNames = new List<string>();
                    foreach (Excel.Worksheet ws in excelWorkbook.Worksheets)
                    {
                        string wsName = ws.Name;
                        sheetNames.Add(wsName);
                    }
                    cbSheetName.DataSource = sheetNames;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            else
            {
                MessageBox.Show("");
            }
        }

        public void ReadExcelToDataGridView(string worksheetName, int startDataRow)
        {
            try
            {
                Excel.Application excelApp = new Excel.Application();
                //excelApp.Visible = false;
                //excelApp.DisplayAlerts = false;
                Excel.Workbook excelWorkbook = excelApp.Workbooks.Open(txtExcelPath.Text);
                Excel.Worksheet excelSheet = excelWorkbook.Worksheets.Item[worksheetName];
                Excel.Range range = excelSheet.UsedRange;
                System.Data.DataTable dt = new System.Data.DataTable();

                int columnCount = range.Columns.Count;
                int rowcount = range.Rows.Count;
                // loop through each row and add values to our sheet
                //create the header of table
                // add 2 column not in excel
                dt.Columns.Add("#", typeof(string));
                dt.Columns.Add("Row Excel", typeof(Int32));
                for (int j = 1; j <= columnCount; j++)
                {
                    string columnName = Convert.ToString(range.Cells[1, j].Text);
                    checklbColumn.Items.Add(columnName);
                    dt.Columns.Add(Convert.ToString
                                         (range.Cells[1, j].Text), typeof(string));
                }
                //filling the table from  excel file                
                for (int i = startDataRow; i <= rowcount; i++)
                {
                    DataRow dr = dt.NewRow();
                    int rowExcel = i;
                    dr["#"] = "0";
                    dr[1] = i;
                    string accountName = Convert.ToString(range.Cells[i, 1].Value2);
                    if (!string.IsNullOrEmpty(accountName))
                    {
                        accountNames.Add(accountName);
                    }
                    string employeeCode = Convert.ToString(range.Cells[i, 2].Value2);
                    if (!string.IsNullOrEmpty(employeeCode))
                    {
                        employeeCodes.Add(employeeCode);
                    }
                    if (employeeCode.Length > employeeCodeLength)
                    {
                        employeeCodeLength = employeeCode.Length;
                    }
                    string companyCode = Convert.ToString(range.Cells[i, 13].Value2);

                    for (int j = 1; j <= columnCount; j++)
                    {
                        string value = string.IsNullOrEmpty(Convert.ToString(range.Cells[i, j].Value2)) ? "" : Convert.ToString(range.Cells[i, j].Value2);
                        dr[j + 1] = value;
                    }
                    dt.Rows.Add(dr);
                }

                //now close the workbook and make the function return the data table
                dataTable = dt;
                dataGridView1.DataSource = dt;
                dataGridView1.ReadOnly = true;
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                excelWorkbook.Close();
                excelApp.Quit();
                //setBackgroupMissing(dataGridView1);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cbSheetName_SelectedValueChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
            string sheetName = cb.SelectedValue.ToString();
            ReadExcelToDataGridView(sheetName, startDataRow);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items = checklbColumn.CheckedItems;
            List<string> columnChecks = new List<string>();
            foreach (var item in items)
            {
                columnChecks.Add(item.ToString());
            }
            checkValueCell(columnChecks);
        }
        private void checkValueCell(List<string> columnChecks)
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = dataTable;
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                dataTable.Rows[i]["#"] = "0";
            }

            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                string name = dataGridView1.Rows[i].Cells[4].Value.ToString();
                foreach (string columnName in columnChecks)
                {
                    string value = dataGridView1.Rows[i].Cells[columnName].Value.ToString();
                    if (string.IsNullOrEmpty(value))
                    {
                        dataGridView1.Rows[i].Cells[columnName].Style.BackColor = color_missing;
                        dataTable.Rows[i]["#"] = "1";
                    }
                }
            }
        }

        private void radAccountName_CheckedChanged(object sender, EventArgs e)
        {
            imageForm = "Account Name";
        }

        private void radEmpCode_CheckedChanged(object sender, EventArgs e)
        {
            imageForm = "Employee Code";
        }

        private void rad1Image_CheckedChanged(object sender, EventArgs e)
        {
            numberImage = 1;
        }

        private void rad5Image_CheckedChanged(object sender, EventArgs e)
        {
            numberImage = 5;
        }


        private void btnFolderImage_Click(object sender, EventArgs e)
        {
            int countImage = 0;
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                txtFolderImage.Text = folderBrowserDialog.SelectedPath;
                if (!File.Exists(txtExcelPath.Text))
                {
                    MessageBox.Show("ban nen nhap file excel truoc");
                }
                DirectoryInfo dir = new DirectoryInfo(folderBrowserDialog.SelectedPath);
                FileInfo[] files = dir.GetFiles(".", SearchOption.AllDirectories);
                foreach (FileInfo file in files)
                {
                    if (file.Name.ToLower().EndsWith(".jpg") || file.Name.ToLower().EndsWith(".jepg") || file.Name.ToLower().EndsWith(".png")
                        || file.Name.ToLower().EndsWith(".bmp"))
                    {
                        countImage++;
                        string imagePath = file.ToString();
                        if ("Account Name".Equals(imageForm) && numberImage == 1)
                        {
                            string name = file.Name.Substring(0, file.Name.LastIndexOf("."));
                            if (accountNames.Contains(name))
                            {
                                Dictionary<string, int> map = new Dictionary<string, int>();
                                if (mapDataTable.ContainsKey(name))
                                {
                                    mapDataTable[name].Add(imagePath, 1);
                                }
                                else
                                {
                                    map.Add(imagePath, 1);
                                    mapDataTable.Add(name, map);
                                }
                            }
                        }

                        if (radEmpCode.Checked && rad1Image.Checked)
                        {
                            string name = file.Name.Substring(0, file.Name.LastIndexOf("."));
                            if (name.Length < employeeCodeLength)
                            {
                                foreach (var empCode in employeeCodes)
                                {
                                    if (empCode.EndsWith(name))
                                    {
                                        Dictionary<string, int> map = new Dictionary<string, int>();
                                        if (mapDataTable.ContainsKey(empCode))
                                        {
                                            mapDataTable[empCode].Add(imagePath, 1);
                                        }
                                        else
                                        {
                                            map.Add(imagePath, 1);
                                            mapDataTable.Add(empCode, map);
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (employeeCodes.Contains(name))
                                {
                                    Dictionary<string, int> map = new Dictionary<string, int>();
                                    if (mapDataTable.ContainsKey(name))
                                    {
                                        mapDataTable[name].Add(imagePath, 1);
                                    }
                                    else
                                    {
                                        map.Add(imagePath, 1);
                                        mapDataTable.Add(name, map);
                                    }
                                }
                            }
                        }

                        if (radAccountName.Checked && rad5Image.Checked)
                        {
                            //mapImagePath.Add(path, path.Substring(0, path.LastIndexOf(".")));
                            string name = file.Name.Substring(0, file.Name.LastIndexOf(".") - 2);
                            if (accountNames.Contains(name))
                            {
                                Dictionary<string, int> map = new Dictionary<string, int>();
                                string imageName = file.Name.Substring(0, file.Name.LastIndexOf('.'));
                                string numImage = imageName.Substring(file.Name.LastIndexOf("_") + 1);
                                int Result;
                                if (int.TryParse(numImage, out Result))
                                {
                                    if (mapDataTable.ContainsKey(name))
                                    {
                                        mapDataTable[name].Add(imagePath, int.Parse(numImage));
                                    }
                                    else
                                    {
                                        map.Add(imagePath, int.Parse(numImage));
                                        mapDataTable.Add(name, map);
                                    }
                                }
                            }
                        }

                        if (radEmpCode.Checked && rad5Image.Checked)
                        {
                            string name = file.Name.Substring(0, file.Name.LastIndexOf(".") - 2);
                            Dictionary<string, int> map = new Dictionary<string, int>();
                            string imageName = file.Name.Substring(0, file.Name.LastIndexOf('.'));
                            string numImage = imageName.Substring(file.Name.LastIndexOf("_") + 1);
                            int Result;
                            if (name.Length < employeeCodeLength)
                            {
                                foreach (var empCode in employeeCodes)
                                {
                                    if (empCode.EndsWith(name))
                                    {
                                        if (int.TryParse(numImage, out Result))
                                        {
                                            if (mapDataTable.ContainsKey(empCode))
                                            {
                                                mapDataTable[empCode].Add(imagePath, int.Parse(numImage));
                                            }
                                            else
                                            {
                                                map.Add(imagePath, int.Parse(numImage));
                                                mapDataTable.Add(empCode, map);
                                            }
                                        }
                                    }
                                }
                            }
                            else
                            {
                                if (employeeCodes.Contains(name))
                                {
                                    if (int.TryParse(numImage, out Result))
                                    {
                                        if (mapDataTable.ContainsKey(name))
                                        {
                                            mapDataTable[name].Add(imagePath, int.Parse(numImage));
                                        }
                                        else
                                        {
                                            map.Add(imagePath, int.Parse(numImage));
                                            mapDataTable.Add(name, map);
                                        }
                                    }
                                }
                            }
                        }






                    }
                }
                lblImageCount.Text = countImage.ToString();
                assignImageToDataGridView(mapDataTable);
            }
        }

        private void assignImageToDataGridView(Dictionary<string, Dictionary<string, int>> mapDataTable)
        {
            if (mapDataTable != null)
            {
                dataGridView1.DataSource = null;
                System.Data.DataTable dt = new System.Data.DataTable();
                if (radEmpCode.Checked && rad5Image.Checked)
                {

                    dt.Columns.Add("Image 1", typeof(string)).SetOrdinal(0);
                    checklbColumn.Items.Insert(0, "Image 1");
                    dt.Columns.Add("Image 2", typeof(string)).SetOrdinal(1);
                    checklbColumn.Items.Insert(1, "Image 2");
                    dt.Columns.Add("Image 3", typeof(string)).SetOrdinal(2);
                    checklbColumn.Items.Insert(2, "Image 3");
                    dt.Columns.Add("Image 4", typeof(string)).SetOrdinal(3);
                    checklbColumn.Items.Insert(3, "Image 4");
                    dt.Columns.Add("Image 5", typeof(string)).SetOrdinal(4);
                    checklbColumn.Items.Insert(4, "Image 5");
                    //dataTable.Columns.Count
                    for (int i = 0; i < dataTable.Columns.Count; i++)
                    {
                        string columnName = dataTable.Columns[i].ColumnName;
                        dt.Columns.Add(columnName);
                    }
                    for (int i = 0; i < dataTable.Rows.Count; i++)
                    {
                        DataRow row = dt.NewRow();
                        string accountName = dataTable.Rows[i][2].ToString();
                        string employeeCode = dataTable.Rows[i][3].ToString();
                        if (radAccountName.Checked && mapDataTable.ContainsKey(accountName))
                        {
                            Dictionary<string, int> dic = mapDataTable[accountName];
                            foreach (KeyValuePair<string, int> keyValue in dic)
                            {
                                string image = "Image " + keyValue.Value;
                                row[image] = keyValue.Key;
                            }
                        }
                        else if (radEmpCode.Checked && mapDataTable.ContainsKey(employeeCode))
                        {
                            Dictionary<string, int> dic = mapDataTable[employeeCode];
                            foreach (KeyValuePair<string, int> keyValue in dic)
                            {
                                string image = "Image " + keyValue.Value;
                                row[image] = keyValue.Key;
                            }
                        }
                        for (int j = 0; j < dataTable.Columns.Count; j++)
                        {
                            string columnName = dataTable.Columns[j].ColumnName;
                            string value = dataTable.Rows[i][j].ToString();
                            row[j + 5] = value;
                        }
                        dt.Rows.Add(row);
                    }
                    dataTable = dt;
                    dataGridView1.DataSource = dt;
                }
            }
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {

        }

        private void cbSort_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox cb = sender as ComboBox;
                System.Data.DataTable dt = dataTable.Clone();
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                if (cb.SelectedIndex == 1 && "0".Equals(dataTable.Rows[i]["#"].ToString()))
                {
                    dt.Rows.Add(dataTable.Rows[i]);
                }
                if (cb.SelectedIndex == 2 && "1".Equals(dataTable.Rows[i]["#"].ToString()))
                {
                    dt.Rows.Add(dataTable.Rows[i]);
                }
                if (cb.SelectedIndex == 0 && "1".Equals(dataTable.Rows[i]["#"].ToString()))
                {
                    
                }
            }
            if (cb.SelectedIndex == 0)
            {
                for (int i = 0; i < dataTable.Rows.Count; i++)
                {
                    if ("0".Equals(dataTable.Rows[i]["#"].ToString()))
                    {
                        dt.Rows.Add(dataTable.Rows[i]);
                    }
                }
            }
            dataGridView1.DataSource = dt;
        }

        private void sortDataGridView(System.Data.DataTable dataTable, int index)
        {
            
        }
    }
}
