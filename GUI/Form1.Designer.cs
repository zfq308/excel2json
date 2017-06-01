namespace excel2json
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtExcel = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtDataPoint = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCategory = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtEntityRootPath = new System.Windows.Forms.TextBox();
            this.TxtRootPath = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.BtnGenerateSQL = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtSQLPath = new System.Windows.Forms.TextBox();
            this.ChkGenerateCreateTableScript = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Location = new System.Drawing.Point(605, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Generate";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Excel File";
            // 
            // TxtExcel
            // 
            this.TxtExcel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TxtExcel.Location = new System.Drawing.Point(84, 10);
            this.TxtExcel.Name = "TxtExcel";
            this.TxtExcel.ReadOnly = true;
            this.TxtExcel.Size = new System.Drawing.Size(589, 20);
            this.TxtExcel.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Location = new System.Drawing.Point(679, 8);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.TxtDataPoint);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.TxtCategory);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.TxtEntityRootPath);
            this.groupBox1.Controls.Add(this.TxtRootPath);
            this.groupBox1.Location = new System.Drawing.Point(20, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(660, 192);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Output";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Entity Root Path";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 28);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(473, 39);
            this.label6.TabIndex = 5;
            this.label6.Text = "Sheet name Keyword:\r\n\r\n        Mock data: method or change ;     Init data: init " +
    ";        Clean data: clean ;        Delta data: delta";
            // 
            // TxtDataPoint
            // 
            this.TxtDataPoint.Location = new System.Drawing.Point(110, 154);
            this.TxtDataPoint.Name = "TxtDataPoint";
            this.TxtDataPoint.Size = new System.Drawing.Size(537, 20);
            this.TxtDataPoint.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "DataPoint";
            // 
            // TxtCategory
            // 
            this.TxtCategory.Location = new System.Drawing.Point(110, 128);
            this.TxtCategory.Name = "TxtCategory";
            this.TxtCategory.Size = new System.Drawing.Size(537, 20);
            this.TxtCategory.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Output Root Path";
            // 
            // TxtEntityRootPath
            // 
            this.TxtEntityRootPath.Location = new System.Drawing.Point(110, 102);
            this.TxtEntityRootPath.Name = "TxtEntityRootPath";
            this.TxtEntityRootPath.ReadOnly = true;
            this.TxtEntityRootPath.Size = new System.Drawing.Size(537, 20);
            this.TxtEntityRootPath.TabIndex = 0;
            this.TxtEntityRootPath.Text = "D:\\Git\\atlas-aws-qa\\qa-testframework\\src\\main\\java\\com\\morningstar\\qa\\references\\" +
    "Models";
            // 
            // TxtRootPath
            // 
            this.TxtRootPath.Location = new System.Drawing.Point(110, 76);
            this.TxtRootPath.Name = "TxtRootPath";
            this.TxtRootPath.ReadOnly = true;
            this.TxtRootPath.Size = new System.Drawing.Size(537, 20);
            this.TxtRootPath.TabIndex = 0;
            this.TxtRootPath.Text = "D:\\Git\\atlas-aws-qa\\qa-testframework\\src\\main\\testcases\\Atlas\\FunctionTesting";
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 36);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(694, 300);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(686, 274);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Excel2Json";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.ChkGenerateCreateTableScript);
            this.tabPage2.Controls.Add(this.TxtSQLPath);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.BtnGenerateSQL);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(686, 274);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Excel2SQL";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // BtnGenerateSQL
            // 
            this.BtnGenerateSQL.Location = new System.Drawing.Point(503, 227);
            this.BtnGenerateSQL.Name = "BtnGenerateSQL";
            this.BtnGenerateSQL.Size = new System.Drawing.Size(127, 23);
            this.BtnGenerateSQL.TabIndex = 7;
            this.BtnGenerateSQL.Text = "Generate SQL";
            this.BtnGenerateSQL.UseVisualStyleBackColor = true;
            this.BtnGenerateSQL.Click += new System.EventHandler(this.BtnGenerateSQL_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(25, 55);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "SQL Script path";
            // 
            // TxtSQLPath
            // 
            this.TxtSQLPath.Location = new System.Drawing.Point(136, 52);
            this.TxtSQLPath.Name = "TxtSQLPath";
            this.TxtSQLPath.Size = new System.Drawing.Size(521, 20);
            this.TxtSQLPath.TabIndex = 9;
            this.TxtSQLPath.Text = "D:\\Output\\";
            // 
            // ChkGenerateCreateTableScript
            // 
            this.ChkGenerateCreateTableScript.AutoSize = true;
            this.ChkGenerateCreateTableScript.Location = new System.Drawing.Point(28, 17);
            this.ChkGenerateCreateTableScript.Name = "ChkGenerateCreateTableScript";
            this.ChkGenerateCreateTableScript.Size = new System.Drawing.Size(164, 17);
            this.ChkGenerateCreateTableScript.TabIndex = 10;
            this.ChkGenerateCreateTableScript.Text = "Generate Create Table Script";
            this.ChkGenerateCreateTableScript.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(718, 347);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.TxtExcel);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Excel2Json";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TxtExcel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtDataPoint;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCategory;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtRootPath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEntityRootPath;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button BtnGenerateSQL;
        private System.Windows.Forms.TextBox TxtSQLPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox ChkGenerateCreateTableScript;
    }
}

