namespace btBuoi4
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
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.clMssv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clAvgScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFalculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblQLSV = new System.Windows.Forms.Label();
            this.txtStudentID = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.optFemale = new System.Windows.Forms.RadioButton();
            this.optMale = new System.Windows.Forms.RadioButton();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.lblStudentId = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.lblFullName = new System.Windows.Forms.Label();
            this.lblGender = new System.Windows.Forms.Label();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.lblAverageScore = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblMaleCount = new System.Windows.Forms.Label();
            this.lblFemaleCount = new System.Windows.Forms.Label();
            this.txtMaleCount = new System.Windows.Forms.TextBox();
            this.txtFemaleCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.AllowUserToAddRows = false;
            this.dgvStudent.AllowUserToDeleteRows = false;
            this.dgvStudent.AllowUserToResizeColumns = false;
            this.dgvStudent.AllowUserToResizeRows = false;
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clMssv,
            this.clName,
            this.clGender,
            this.clAvgScore,
            this.clFalculty});
            this.dgvStudent.Location = new System.Drawing.Point(364, 115);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStudent.Size = new System.Drawing.Size(523, 259);
            this.dgvStudent.TabIndex = 0;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // clMssv
            // 
            this.clMssv.HeaderText = "MSSV";
            this.clMssv.Name = "clMssv";
            // 
            // clName
            // 
            this.clName.HeaderText = "Họ Tên";
            this.clName.Name = "clName";
            this.clName.Width = 150;
            // 
            // clGender
            // 
            this.clGender.HeaderText = "Giới tính";
            this.clGender.Name = "clGender";
            this.clGender.Width = 70;
            // 
            // clAvgScore
            // 
            this.clAvgScore.HeaderText = "ĐTB";
            this.clAvgScore.Name = "clAvgScore";
            this.clAvgScore.Width = 80;
            // 
            // clFalculty
            // 
            this.clFalculty.HeaderText = "Khoa";
            this.clFalculty.Name = "clFalculty";
            this.clFalculty.Width = 80;
            // 
            // lblQLSV
            // 
            this.lblQLSV.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblQLSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQLSV.ForeColor = System.Drawing.Color.Blue;
            this.lblQLSV.Location = new System.Drawing.Point(0, 0);
            this.lblQLSV.Name = "lblQLSV";
            this.lblQLSV.Size = new System.Drawing.Size(925, 85);
            this.lblQLSV.TabIndex = 1;
            this.lblQLSV.Text = "Quản lí thông tin sinh viên";
            this.lblQLSV.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtStudentID
            // 
            this.txtStudentID.Location = new System.Drawing.Point(119, 126);
            this.txtStudentID.Name = "txtStudentID";
            this.txtStudentID.Size = new System.Drawing.Size(100, 20);
            this.txtStudentID.TabIndex = 2;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(82, 277);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(32, 13);
            this.lblFaculty.TabIndex = 3;
            this.lblFaculty.Text = "Khoa";
            this.lblFaculty.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(119, 328);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Thêm/Sửa";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // optFemale
            // 
            this.optFemale.AutoSize = true;
            this.optFemale.Location = new System.Drawing.Point(172, 201);
            this.optFemale.Name = "optFemale";
            this.optFemale.Size = new System.Drawing.Size(39, 17);
            this.optFemale.TabIndex = 5;
            this.optFemale.TabStop = true;
            this.optFemale.Text = "Nữ";
            this.optFemale.UseVisualStyleBackColor = true;
            // 
            // optMale
            // 
            this.optMale.AutoSize = true;
            this.optMale.Location = new System.Drawing.Point(119, 201);
            this.optMale.Name = "optMale";
            this.optMale.Size = new System.Drawing.Size(47, 17);
            this.optMale.TabIndex = 6;
            this.optMale.TabStop = true;
            this.optMale.Text = "Nam";
            this.optMale.UseVisualStyleBackColor = true;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Items.AddRange(new object[] {
            "QTKD",
            "CNTT",
            "NNA"});
            this.cmbFaculty.Location = new System.Drawing.Point(119, 274);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(191, 21);
            this.cmbFaculty.TabIndex = 7;
            // 
            // lblStudentId
            // 
            this.lblStudentId.AutoSize = true;
            this.lblStudentId.Location = new System.Drawing.Point(32, 129);
            this.lblStudentId.Name = "lblStudentId";
            this.lblStudentId.Size = new System.Drawing.Size(81, 13);
            this.lblStudentId.TabIndex = 3;
            this.lblStudentId.Text = "Mã số sinh viên";
            this.lblStudentId.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(119, 164);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(191, 20);
            this.txtFullName.TabIndex = 2;
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Location = new System.Drawing.Point(59, 167);
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(54, 13);
            this.lblFullName.TabIndex = 3;
            this.lblFullName.Text = "Họ và tên";
            this.lblFullName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Location = new System.Drawing.Point(66, 201);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(47, 13);
            this.lblGender.TabIndex = 3;
            this.lblGender.Text = "Giới tính";
            this.lblGender.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(119, 234);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(64, 20);
            this.txtAverageScore.TabIndex = 2;
            // 
            // lblAverageScore
            // 
            this.lblAverageScore.AutoSize = true;
            this.lblAverageScore.Location = new System.Drawing.Point(66, 237);
            this.lblAverageScore.Name = "lblAverageScore";
            this.lblAverageScore.Size = new System.Drawing.Size(48, 13);
            this.lblAverageScore.TabIndex = 3;
            this.lblAverageScore.Text = "Điểm TB";
            this.lblAverageScore.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(235, 328);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // lblMaleCount
            // 
            this.lblMaleCount.AutoSize = true;
            this.lblMaleCount.Location = new System.Drawing.Point(643, 407);
            this.lblMaleCount.Name = "lblMaleCount";
            this.lblMaleCount.Size = new System.Drawing.Size(77, 13);
            this.lblMaleCount.TabIndex = 3;
            this.lblMaleCount.Text = "Tổng SV Nam:";
            this.lblMaleCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblFemaleCount
            // 
            this.lblFemaleCount.AutoSize = true;
            this.lblFemaleCount.Location = new System.Drawing.Point(788, 407);
            this.lblFemaleCount.Name = "lblFemaleCount";
            this.lblFemaleCount.Size = new System.Drawing.Size(24, 13);
            this.lblFemaleCount.TabIndex = 3;
            this.lblFemaleCount.Text = "Nữ:";
            this.lblFemaleCount.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMaleCount
            // 
            this.txtMaleCount.Location = new System.Drawing.Point(726, 404);
            this.txtMaleCount.Name = "txtMaleCount";
            this.txtMaleCount.ReadOnly = true;
            this.txtMaleCount.Size = new System.Drawing.Size(56, 20);
            this.txtMaleCount.TabIndex = 8;
            // 
            // txtFemaleCount
            // 
            this.txtFemaleCount.Location = new System.Drawing.Point(818, 404);
            this.txtFemaleCount.Name = "txtFemaleCount";
            this.txtFemaleCount.ReadOnly = true;
            this.txtFemaleCount.Size = new System.Drawing.Size(56, 20);
            this.txtFemaleCount.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(925, 462);
            this.Controls.Add(this.txtFemaleCount);
            this.Controls.Add(this.txtMaleCount);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.optMale);
            this.Controls.Add(this.optFemale);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblAverageScore);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblFullName);
            this.Controls.Add(this.lblStudentId);
            this.Controls.Add(this.lblFemaleCount);
            this.Controls.Add(this.lblMaleCount);
            this.Controls.Add(this.lblFaculty);
            this.Controls.Add(this.txtAverageScore);
            this.Controls.Add(this.txtFullName);
            this.Controls.Add(this.txtStudentID);
            this.Controls.Add(this.lblQLSV);
            this.Controls.Add(this.dgvStudent);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.DataGridViewTextBoxColumn clMssv;
        private System.Windows.Forms.DataGridViewTextBoxColumn clName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn clAvgScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFalculty;
        private System.Windows.Forms.Label lblQLSV;
        private System.Windows.Forms.TextBox txtStudentID;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.RadioButton optFemale;
        private System.Windows.Forms.RadioButton optMale;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label lblStudentId;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label lblFullName;
        private System.Windows.Forms.Label lblGender;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.Label lblAverageScore;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblMaleCount;
        private System.Windows.Forms.Label lblFemaleCount;
        private System.Windows.Forms.TextBox txtMaleCount;
        private System.Windows.Forms.TextBox txtFemaleCount;
    }
}

