namespace StudentInfoManagement
{
    partial class StudentForm
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
            this.returnButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.sstudentIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.studentNameText = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.majorBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.classBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.sexBox = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.nationalityText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.politicalStatusText = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.StudentListGridView = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.StudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nationality = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PoliticalStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Class = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // returnButton
            // 
            this.returnButton.Location = new System.Drawing.Point(12, 12);
            this.returnButton.Name = "returnButton";
            this.returnButton.Size = new System.Drawing.Size(75, 23);
            this.returnButton.TabIndex = 1;
            this.returnButton.Text = "返回";
            this.returnButton.UseVisualStyleBackColor = true;
            this.returnButton.Click += new System.EventHandler(this.returnButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "学号";
            // 
            // sstudentIdText
            // 
            this.sstudentIdText.Location = new System.Drawing.Point(38, 3);
            this.sstudentIdText.Name = "sstudentIdText";
            this.sstudentIdText.Size = new System.Drawing.Size(100, 21);
            this.sstudentIdText.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "姓名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(285, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "专业";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // studentNameText
            // 
            this.studentNameText.Location = new System.Drawing.Point(179, 3);
            this.studentNameText.Name = "studentNameText";
            this.studentNameText.Size = new System.Drawing.Size(100, 21);
            this.studentNameText.TabIndex = 6;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.sstudentIdText);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.studentNameText);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.majorBox);
            this.flowLayoutPanel1.Controls.Add(this.label4);
            this.flowLayoutPanel1.Controls.Add(this.classBox);
            this.flowLayoutPanel1.Controls.Add(this.label5);
            this.flowLayoutPanel1.Controls.Add(this.sexBox);
            this.flowLayoutPanel1.Controls.Add(this.label6);
            this.flowLayoutPanel1.Controls.Add(this.nationalityText);
            this.flowLayoutPanel1.Controls.Add(this.label7);
            this.flowLayoutPanel1.Controls.Add(this.politicalStatusText);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(155, 12);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(628, 66);
            this.flowLayoutPanel1.TabIndex = 7;
            // 
            // majorBox
            // 
            this.majorBox.FormattingEnabled = true;
            this.majorBox.Items.AddRange(new object[] {
            "信息与计算科学",
            "数学与应用数学",
            "应用物理"});
            this.majorBox.Location = new System.Drawing.Point(320, 3);
            this.majorBox.Name = "majorBox";
            this.majorBox.Size = new System.Drawing.Size(121, 20);
            this.majorBox.TabIndex = 7;
            this.majorBox.SelectedIndexChanged += new System.EventHandler(this.majorBox_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(447, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "班级";
            // 
            // classBox
            // 
            this.classBox.FormattingEnabled = true;
            this.classBox.Location = new System.Drawing.Point(482, 3);
            this.classBox.Name = "classBox";
            this.classBox.Size = new System.Drawing.Size(121, 20);
            this.classBox.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 12);
            this.label5.TabIndex = 11;
            this.label5.Text = "性别";
            // 
            // sexBox
            // 
            this.sexBox.FormattingEnabled = true;
            this.sexBox.Items.AddRange(new object[] {
            "男",
            "女"});
            this.sexBox.Location = new System.Drawing.Point(38, 30);
            this.sexBox.Name = "sexBox";
            this.sexBox.Size = new System.Drawing.Size(100, 20);
            this.sexBox.TabIndex = 12;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(144, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(29, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "民族";
            // 
            // nationalityText
            // 
            this.nationalityText.Location = new System.Drawing.Point(179, 30);
            this.nationalityText.Name = "nationalityText";
            this.nationalityText.Size = new System.Drawing.Size(100, 21);
            this.nationalityText.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(285, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 12);
            this.label7.TabIndex = 15;
            this.label7.Text = "政治面貌";
            // 
            // politicalStatusText
            // 
            this.politicalStatusText.Location = new System.Drawing.Point(344, 30);
            this.politicalStatusText.Name = "politicalStatusText";
            this.politicalStatusText.Size = new System.Drawing.Size(100, 21);
            this.politicalStatusText.TabIndex = 16;
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(821, 15);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 8;
            this.searchButton.Text = "搜索";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(708, 467);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "导入";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(806, 467);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "导出";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // StudentListGridView
            // 
            this.StudentListGridView.AllowUserToAddRows = false;
            this.StudentListGridView.AllowUserToDeleteRows = false;
            this.StudentListGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StudentListGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.StudentName,
            this.Sex,
            this.Nationality,
            this.PoliticalStatus,
            this.Major,
            this.Class});
            this.StudentListGridView.Location = new System.Drawing.Point(13, 84);
            this.StudentListGridView.Name = "StudentListGridView";
            this.StudentListGridView.RowTemplate.Height = 23;
            this.StudentListGridView.Size = new System.Drawing.Size(905, 374);
            this.StudentListGridView.TabIndex = 9;
            this.StudentListGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.StudentListGridView_CellContentClick);
            // 
            // Id
            // 
            this.Id.HeaderText = "学号";
            this.Id.Name = "Id";
            // 
            // StudentName
            // 
            this.StudentName.HeaderText = "姓名";
            this.StudentName.Name = "StudentName";
            // 
            // Sex
            // 
            this.Sex.HeaderText = "性别";
            this.Sex.Name = "Sex";
            // 
            // Nationality
            // 
            this.Nationality.HeaderText = "民族";
            this.Nationality.Name = "Nationality";
            // 
            // PoliticalStatus
            // 
            this.PoliticalStatus.HeaderText = "政治面貌";
            this.PoliticalStatus.Name = "PoliticalStatus";
            // 
            // Major
            // 
            this.Major.HeaderText = "专业名称";
            this.Major.Name = "Major";
            // 
            // Class
            // 
            this.Class.HeaderText = "行政班";
            this.Class.Name = "Class";
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 502);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.StudentListGridView);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.returnButton);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentForm";
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StudentListGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button returnButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sstudentIdText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox studentNameText;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox majorBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.ComboBox classBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox sexBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox nationalityText;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox politicalStatusText;
        private System.Windows.Forms.DataGridView StudentListGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sex;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nationality;
        private System.Windows.Forms.DataGridViewTextBoxColumn PoliticalStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.DataGridViewTextBoxColumn Class;
    }
}