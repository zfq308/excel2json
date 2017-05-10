using System;
using System.IO;
using System.Data;
using System.Text;
using System.Collections.Generic;

namespace excel2json
{
    /// <summary>
    /// 根据表头，生成Java类定义数据结构
    /// 表头使用三行定义：字段名称、字段类型、注释
    /// </summary>
    class JavaDefineGenerator
    {
        struct FieldDef
        {
            public string name;
            public string type;
            public string comment;
        }

        List<FieldDef> m_fieldList;

        public String ClassComment
        {
            get;
            set;
        }

        public JavaDefineGenerator(DataTable sheet)
        {
            //-- First Row as Column Name
            if (sheet.Rows.Count < 2)
                return;

            m_fieldList = new List<FieldDef>();
            DataRow typeRow = sheet.Rows[0];
            DataRow commentRow = sheet.Rows[1];

            foreach (DataColumn column in sheet.Columns)
            {
                FieldDef field;

                var fieldName = column.ToString().Trim();
                if (fieldName.StartsWith("R_"))
                {
                    fieldName = fieldName.Replace("R_", "");
                }

                if (fieldName.StartsWith("QP_"))
                {
                    fieldName = fieldName.Replace("QP_", "");
                }

                if (fieldName.StartsWith("MP_"))
                {
                    fieldName = fieldName.Replace("MP_", "");
                }

                if (fieldName.StartsWith("P_"))
                {
                    fieldName = fieldName.Replace("P_", "");
                }

                field.name = fieldName;
                field.type = typeRow[column].ToString().Trim();
                field.comment = commentRow[column].ToString().Trim();

                m_fieldList.Add(field);
            }
        }

        public string ConvertJavaDataType(string type)
        {
            type = type.ToLower();
            switch (type)
            {
                case "integer":
                    return "Integer";
                case "string":
                    return "String";
                case "date":
                    return "Date";
                case "double":
                    return "Double";
                default:
                    return type;
            }
        }


        public void SaveToFile(string filePath, Encoding encoding, String NameSpace = "")
        {
            if (m_fieldList == null)
                throw new Exception("JavaDefineGenerator内部数据为空。");

            string defName = Path.GetFileNameWithoutExtension(filePath);

            //-- 创建代码字符串
            StringBuilder sbForEntity = new StringBuilder();
            StringBuilder sbForEntityToString = new StringBuilder();
            sbForEntity.AppendLine("package com.morningstar.qa.references.Models" + NameSpace + ";");
            sbForEntity.AppendLine();

            sbForEntity.AppendLine();
            sbForEntity.AppendFormat("public class {0}\r\n{{", defName + "Entity");
            sbForEntity.AppendLine();
            foreach (FieldDef field in m_fieldList)
            {
                sbForEntity.AppendFormat("\tpublic {0} {1}; // {2}", ConvertJavaDataType(field.type), field.name, field.comment);
                sbForEntityToString.AppendLine("\t\tif(" + field.name + " == null){sb.append(\"" + field.name + "=null<br>\");} else {sb.append(\"" + field.name + " = \" + " + field.name + ".toString() + \"<br>\");}");
                //sbForEntityToString.AppendLine("\t\tsb.append(\"" + field.name + "=\" + " + field.name + " == null ? \"null\" : "+ field.name + ".toString() + \"\\n\");");
                sbForEntity.AppendLine();
            }

            sbForEntity.AppendLine();
            sbForEntity.AppendLine();
            sbForEntity.AppendLine("\t@Override");
            sbForEntity.AppendLine("\tpublic String toString() {");
            sbForEntity.AppendLine("\t\tStringBuilder sb=new StringBuilder();");
            sbForEntity.Append(sbForEntityToString.ToString());
            sbForEntity.AppendLine("\t\treturn sb.toString();");
            sbForEntity.AppendLine("\t}");
            sbForEntity.AppendLine("}");
            sbForEntity.AppendLine();
            //-- 保存文件
            String filePath1 = filePath.Replace(defName, defName + "Entity");
            using (FileStream file = new FileStream(filePath1, FileMode.Create, FileAccess.Write))
            {
                using (TextWriter writer = new StreamWriter(file, encoding))
                    writer.Write(sbForEntity.ToString());
            }

        }
    }
}
