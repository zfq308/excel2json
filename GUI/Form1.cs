using Excel;
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
using static excel2json.Program;

namespace excel2json
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Excel File|*.xlsx";
            ofd.Multiselect = false;

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                this.TxtExcel.Text = ofd.FileName;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(this.TxtCategory.Text.Trim()) ||
                String.IsNullOrEmpty(this.TxtDataPoint.Text.Trim()) ||
                String.IsNullOrEmpty(this.TxtExcel.Text.Trim()))
            {
                MessageBox.Show("Please fill the Excel, Category and Data Point information.");
            }
            else
            {
                DirectoryInfo diTestCaseDataPoint = CreateTestCaseDir();
                DirectoryInfo diEntityDataPoint = CreateEntityDir();

                try
                {
                    string excelPath = this.TxtExcel.Text.Trim();
                    String OutputExcelPath = Path.Combine(diTestCaseDataPoint.FullName, "Excel", new FileInfo(excelPath).Name);
                    File.Copy(excelPath, OutputExcelPath);

                    int header = 3;
                    // 加载Excel文件
                    using (FileStream excelFile = File.Open(excelPath, FileMode.Open, FileAccess.Read))
                    {
                        // Reading from a OpenXml Excel file (2007 format; *.xlsx)
                        IExcelDataReader excelReader = ExcelReaderFactory.CreateOpenXmlReader(excelFile);

                        // The result of each spreadsheet will be created in the result.Tables
                        excelReader.IsFirstRowAsColumnNames = true;
                        DataSet book = excelReader.AsDataSet();

                        // 数据检测
                        if (book.Tables.Count < 1) { throw new Exception("Excel文件中没有找到Sheet: " + excelPath); }


                        foreach (DataTable sheet in book.Tables)
                        {
                            if (sheet.Rows.Count <= 0)
                            {
                                throw new Exception("Excel Sheet中没有数据: " + excelPath);
                            }

                            if (sheet.TableName == "Config")
                            {
                                //TODO: 
                            }
                            else
                            {
                                String JsonPath = "";
                                if (sheet.TableName.ToLower().Contains("method") || sheet.TableName.ToLower().Contains("change"))
                                {
                                    JsonPath = Path.Combine(diTestCaseDataPoint.FullName, "MockData", sheet.TableName + "_" + this.TxtDataPoint.Text.Trim() + ".json");
                                    JsonExporter exporterForJson = new JsonExporter(sheet, header, true);
                                    exporterForJson.SaveToFile(JsonPath, new UTF8Encoding(false));

                                }
                                else if (sheet.TableName.ToLower().Contains("init"))
                                {
                                    JsonPath = Path.Combine(diTestCaseDataPoint.FullName, "InitData", sheet.TableName + "_" + this.TxtDataPoint.Text.Trim() + ".json");
                                    JsonExporter exporterForJson2 = new JsonExporter(sheet, header, true);
                                    exporterForJson2.SaveToFile(JsonPath, new UTF8Encoding(false));
                                }
                                else if (sheet.TableName.ToLower().Contains("clean"))
                                {
                                    JsonPath = Path.Combine(diTestCaseDataPoint.FullName, "CleanData", sheet.TableName + "_" + this.TxtDataPoint.Text.Trim() + ".json");
                                    JsonExporter exporterForJson = new JsonExporter(sheet, header, true);
                                    exporterForJson.SaveToFile(JsonPath, new UTF8Encoding(false));
                                }
                                else if (sheet.TableName.ToLower().Contains("delta"))
                                {
                                    JsonPath = Path.Combine(diTestCaseDataPoint.FullName, "DeltaData", sheet.TableName + "_" + this.TxtDataPoint.Text.Trim() + ".json");
                                    JsonExporter exporterForJson2 = new JsonExporter(sheet, header, true);
                                    exporterForJson2.SaveToFile(JsonPath, new UTF8Encoding(false));
                                }

                                String JavaPath = Path.Combine(diEntityDataPoint.FullName, sheet.TableName + "_Entity.java");
                                JavaDefineGenerator exporterForJava = new JavaDefineGenerator(sheet);
                                exporterForJava.SaveToFile(JavaPath, new UTF8Encoding(false));

                            }
                        }

                    }
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private DirectoryInfo CreateTestCaseDir()
        {
            DirectoryInfo diCategory = null;
            DirectoryInfo diDataPoint = null;

            DirectoryInfo di = new DirectoryInfo(this.TxtRootPath.Text);
            Boolean existCategoryDir = false;
            Boolean existDataPoint = false;
            foreach (DirectoryInfo subdi in di.GetDirectories())
            {
                if (subdi.Name.ToLower() == this.TxtCategory.Text.Trim().ToLower())
                {
                    existCategoryDir = true;
                    diCategory = subdi;
                    break;
                }
            }
            if (!existCategoryDir)
            {
                diCategory = di.CreateSubdirectory(this.TxtCategory.Text.Trim());
            }

            foreach (DirectoryInfo subdi in diCategory.GetDirectories())
            {
                if (subdi.Name.ToLower() == this.TxtDataPoint.Text.Trim().ToLower())
                {
                    existDataPoint = true;
                    diDataPoint = subdi;
                    break;
                }
            }
            if (!existDataPoint)
            {
                diDataPoint = diCategory.CreateSubdirectory(this.TxtDataPoint.Text.Trim());
            }

            diDataPoint.CreateSubdirectory("CleanData");
            diDataPoint.CreateSubdirectory("DeltaData");
            diDataPoint.CreateSubdirectory("Excel");
            diDataPoint.CreateSubdirectory("InitData");
            diDataPoint.CreateSubdirectory("MockData");
            return diDataPoint;
        }

        private DirectoryInfo CreateEntityDir()
        {
            DirectoryInfo diCategory = null;
            DirectoryInfo diDataPoint = null;

            DirectoryInfo di = new DirectoryInfo(this.TxtEntityRootPath.Text);
            Boolean existCategoryDir = false;
            Boolean existDataPoint = false;
            foreach (DirectoryInfo subdi in di.GetDirectories())
            {
                if (subdi.Name.ToLower() == this.TxtCategory.Text.Trim().ToLower())
                {
                    existCategoryDir = true;
                    diCategory = subdi; break;
                }
            }
            if (!existCategoryDir)
            {
                diCategory = di.CreateSubdirectory(this.TxtCategory.Text.Trim());
            }

            foreach (DirectoryInfo subdi in diCategory.GetDirectories())
            {
                if (subdi.Name.ToLower() == this.TxtDataPoint.Text.Trim().ToLower())
                {
                    existDataPoint = true;
                    diDataPoint = subdi; break;
                }
            }
            if (!existDataPoint)
            {
                diDataPoint = diCategory.CreateSubdirectory(this.TxtDataPoint.Text.Trim());
            }
            return diDataPoint;
        }
    }
}
