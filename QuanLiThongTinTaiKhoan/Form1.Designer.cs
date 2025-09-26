namespace QuanLiThongTinTaiKhoan
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
            this.lvInfos = new System.Windows.Forms.ListView();
            this.clSTT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.clMoneyAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblAppName = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtMoneyAmount = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblMoneyAmount = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.lblTotalMoneyAmount = new System.Windows.Forms.Label();
            this.txtTotalMoneyAmount = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lvInfos
            // 
            this.lvInfos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clSTT,
            this.clId,
            this.clName,
            this.clAddress,
            this.clMoneyAmount});
            this.lvInfos.FullRowSelect = true;
            this.lvInfos.HideSelection = false;
            this.lvInfos.Location = new System.Drawing.Point(12, 248);
            this.lvInfos.MultiSelect = false;
            this.lvInfos.Name = "lvInfos";
            this.lvInfos.Size = new System.Drawing.Size(776, 287);
            this.lvInfos.TabIndex = 0;
            this.lvInfos.UseCompatibleStateImageBehavior = false;
            this.lvInfos.View = System.Windows.Forms.View.Details;
            this.lvInfos.SelectedIndexChanged += new System.EventHandler(this.lvInfos_SelectedIndexChanged);
            // 
            // clSTT
            // 
            this.clSTT.Text = "STT";
            this.clSTT.Width = 43;
            // 
            // clId
            // 
            this.clId.Text = "Mã tài khoản";
            this.clId.Width = 124;
            // 
            // clName
            // 
            this.clName.Text = "Tên khách hàng";
            this.clName.Width = 170;
            // 
            // clAddress
            // 
            this.clAddress.Text = "Địa chỉ";
            this.clAddress.Width = 211;
            // 
            // clMoneyAmount
            // 
            this.clMoneyAmount.Text = "Số tiền";
            this.clMoneyAmount.Width = 224;
            // 
            // lblAppName
            // 
            this.lblAppName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblAppName.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAppName.Location = new System.Drawing.Point(0, 0);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(800, 71);
            this.lblAppName.TabIndex = 1;
            this.lblAppName.Text = "QUẢN LÍ THÔNG TIN TÀI KHOẢN";
            this.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(159, 71);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(67, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Số tài khoản";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(232, 68);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(459, 20);
            this.txtID.TabIndex = 3;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(510, 191);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(232, 94);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(459, 20);
            this.txtName.TabIndex = 3;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(232, 120);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(459, 20);
            this.txtAddress.TabIndex = 3;
            // 
            // txtMoneyAmount
            // 
            this.txtMoneyAmount.Location = new System.Drawing.Point(232, 146);
            this.txtMoneyAmount.Name = "txtMoneyAmount";
            this.txtMoneyAmount.Size = new System.Drawing.Size(459, 20);
            this.txtMoneyAmount.TabIndex = 3;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(140, 97);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(86, 13);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "Tên khách hàng";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(126, 123);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(100, 13);
            this.lblAddress.TabIndex = 2;
            this.lblAddress.Text = "Địa chỉ khách hàng";
            // 
            // lblMoneyAmount
            // 
            this.lblMoneyAmount.AutoSize = true;
            this.lblMoneyAmount.Location = new System.Drawing.Point(112, 149);
            this.lblMoneyAmount.Name = "lblMoneyAmount";
            this.lblMoneyAmount.Size = new System.Drawing.Size(114, 13);
            this.lblMoneyAmount.TabIndex = 2;
            this.lblMoneyAmount.Text = "Số tiền trong tài khoản";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(616, 191);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 4;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(385, 191);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 23);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Thêm/Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblTotalMoneyAmount
            // 
            this.lblTotalMoneyAmount.AutoSize = true;
            this.lblTotalMoneyAmount.Location = new System.Drawing.Point(421, 549);
            this.lblTotalMoneyAmount.Name = "lblTotalMoneyAmount";
            this.lblTotalMoneyAmount.Size = new System.Drawing.Size(58, 13);
            this.lblTotalMoneyAmount.TabIndex = 2;
            this.lblTotalMoneyAmount.Text = "Tổng tiền: ";
            // 
            // txtTotalMoneyAmount
            // 
            this.txtTotalMoneyAmount.Location = new System.Drawing.Point(485, 546);
            this.txtTotalMoneyAmount.Name = "txtTotalMoneyAmount";
            this.txtTotalMoneyAmount.ReadOnly = true;
            this.txtTotalMoneyAmount.Size = new System.Drawing.Size(303, 20);
            this.txtTotalMoneyAmount.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtTotalMoneyAmount);
            this.Controls.Add(this.txtMoneyAmount);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblTotalMoneyAmount);
            this.Controls.Add(this.lblMoneyAmount);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblAppName);
            this.Controls.Add(this.lvInfos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvInfos;
        private System.Windows.Forms.ColumnHeader clSTT;
        private System.Windows.Forms.ColumnHeader clId;
        private System.Windows.Forms.ColumnHeader clName;
        private System.Windows.Forms.ColumnHeader clAddress;
        private System.Windows.Forms.ColumnHeader clMoneyAmount;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtMoneyAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblMoneyAmount;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label lblTotalMoneyAmount;
        private System.Windows.Forms.TextBox txtTotalMoneyAmount;
    }
}

