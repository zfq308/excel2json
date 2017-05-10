﻿using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Dynamic;

namespace excel2json
{
    /// <summary>
    /// 将DataTable对象，转换成JSON string，并保存到文件中
    /// </summary>
    class JsonExporter2
    {
        List<ExpandoObject> m_data;


        /// <summary>
        /// 构造函数：完成内部数据创建
        /// </summary>
        /// <param name="sheet">ExcelReader创建的一个表单</param>
        /// <param name="headerRows">表单中的那几行是表头</param>
        public JsonExporter2(DataTable sheet, int headerRows, bool lowcase)
        {
            if (sheet.Columns.Count <= 0)
                return;
            if (sheet.Rows.Count <= 0)
                return;

            m_data = new List<ExpandoObject>();


            //--以第一列为ID，转换成ID->Object的字典
            int firstDataRow = headerRows - 1;
            for (int i = firstDataRow; i < sheet.Rows.Count; i++)
            {
                DataRow row = sheet.Rows[i];
                string ID = row[sheet.Columns[0]].ToString();
                if (ID.Length <= 0)
                    continue;

                var rowData = new Dictionary<string, object>();
                int ColumnIdx = 0;

                dynamic obj = new ExpandoObject();
                foreach (DataColumn column in sheet.Columns)
                {
                    string fieldName = column.ToString().Trim();
                    object value = row[column];

                    if (value.ToString() == "JsonObject")
                    {
                        Dictionary<string, string> matchKV = new Dictionary<string, string>();
                        for (int k = 0; k < ColumnIdx; k++)
                        {
                            matchKV.Add(sheet.Columns[k].ColumnName, row[k].ToString());
                        }
                        obj.rawPrice = matchKV;
                    }
                    else
                    {
                        // Do Nothing 
                    }

                    ColumnIdx += 1;
                }
                
                int operation = Convert.ToInt32(row[ColumnIdx - 1].ToString());
                obj.operation = operation;

                m_data.Add(obj);

            }
        }

        /// <summary>
        /// 将内部数据转换成Json文本，并保存至文件
        /// </summary>
        /// <param name="jsonPath">输出文件路径</param>
        public void SaveToFile(string filePath, Encoding encoding)
        {
            if (m_data == null)
                throw new Exception("JsonExporter内部数据为空。");

            //-- 转换为JSON字符串
            string json = JsonConvert.SerializeObject(m_data);
            //string json = JsonConvert.SerializeObject(m_data.Values, Formatting.Indented);

            //-- 保存文件
            using (FileStream file = new FileStream(filePath, FileMode.Create, FileAccess.Write))
            {
                using (TextWriter writer = new StreamWriter(file, encoding))
                    writer.Write(json);
            }
        }
    }



}
