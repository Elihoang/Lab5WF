namespace GUI
{
    partial class frmFaculty
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
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dvgFaculty = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblResultGS = new System.Windows.Forms.Label();
            this.txtTongGSFooter = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.lblSort = new System.Windows.Forms.Label();
            this.cmbSort = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblTongGS = new System.Windows.Forms.Label();
            this.txtTongGS = new System.Windows.Forms.TextBox();
            this.txtTenKhoa = new System.Windows.Forms.TextBox();
            this.txtMaKhoa = new System.Windows.Forms.TextBox();
            this.lblMaKhoa = new System.Windows.Forms.Label();
            this.lblTenKhoa = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.GroupBox();
            this.lblHeader = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dvgFaculty)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.b1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TotalProfessor";
            this.Column3.HeaderText = "Tổng Số GS";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FacultyID";
            this.Column1.HeaderText = "Mã Khoa";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // dvgFaculty
            // 
            this.dvgFaculty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgFaculty.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvgFaculty.Location = new System.Drawing.Point(324, 96);
            this.dvgFaculty.Name = "dvgFaculty";
            this.dvgFaculty.RowHeadersWidth = 51;
            this.dvgFaculty.RowTemplate.Height = 24;
            this.dvgFaculty.Size = new System.Drawing.Size(504, 410);
            this.dvgFaculty.TabIndex = 27;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "FacultyName";
            this.Column2.HeaderText = "Tên Khoa";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // lblResultGS
            // 
            this.lblResultGS.AutoSize = true;
            this.lblResultGS.Location = new System.Drawing.Point(321, 531);
            this.lblResultGS.Name = "lblResultGS";
            this.lblResultGS.Size = new System.Drawing.Size(81, 16);
            this.lblResultGS.TabIndex = 26;
            this.lblResultGS.Text = "Tổng Số GS";
            // 
            // txtTongGSFooter
            // 
            this.txtTongGSFooter.Enabled = false;
            this.txtTongGSFooter.Location = new System.Drawing.Point(408, 531);
            this.txtTongGSFooter.Name = "txtTongGSFooter";
            this.txtTongGSFooter.Size = new System.Drawing.Size(100, 22);
            this.txtTongGSFooter.TabIndex = 25;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(740, 523);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 38);
            this.btnClose.TabIndex = 24;
            this.btnClose.Text = "Đóng";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(12, 468);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(87, 38);
            this.btnInsert.TabIndex = 23;
            this.btnInsert.Text = "Thêm";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(114, 468);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(87, 38);
            this.btnEdit.TabIndex = 22;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(216, 468);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 38);
            this.btnDelete.TabIndex = 21;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(23, 30);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(59, 16);
            this.lblSort.TabIndex = 15;
            this.lblSort.Text = "Sắp Xếp";
            // 
            // cmbSort
            // 
            this.cmbSort.FormattingEnabled = true;
            this.cmbSort.Items.AddRange(new object[] {
            "DESC",
            "ASC"});
            this.cmbSort.Location = new System.Drawing.Point(89, 27);
            this.cmbSort.Name = "cmbSort";
            this.cmbSort.Size = new System.Drawing.Size(159, 24);
            this.cmbSort.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSort);
            this.groupBox2.Controls.Add(this.cmbSort);
            this.groupBox2.Location = new System.Drawing.Point(12, 372);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(292, 63);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Chức Năng";
            // 
            // lblTongGS
            // 
            this.lblTongGS.AutoSize = true;
            this.lblTongGS.Location = new System.Drawing.Point(23, 181);
            this.lblTongGS.Name = "lblTongGS";
            this.lblTongGS.Size = new System.Drawing.Size(81, 16);
            this.lblTongGS.TabIndex = 14;
            this.lblTongGS.Text = "Tổng Số GS";
            // 
            // txtTongGS
            // 
            this.txtTongGS.Location = new System.Drawing.Point(110, 181);
            this.txtTongGS.Name = "txtTongGS";
            this.txtTongGS.Size = new System.Drawing.Size(159, 22);
            this.txtTongGS.TabIndex = 8;
            // 
            // txtTenKhoa
            // 
            this.txtTenKhoa.Location = new System.Drawing.Point(110, 117);
            this.txtTenKhoa.Name = "txtTenKhoa";
            this.txtTenKhoa.Size = new System.Drawing.Size(159, 22);
            this.txtTenKhoa.TabIndex = 9;
            // 
            // txtMaKhoa
            // 
            this.txtMaKhoa.Location = new System.Drawing.Point(110, 55);
            this.txtMaKhoa.Name = "txtMaKhoa";
            this.txtMaKhoa.Size = new System.Drawing.Size(159, 22);
            this.txtMaKhoa.TabIndex = 10;
            // 
            // lblMaKhoa
            // 
            this.lblMaKhoa.AutoSize = true;
            this.lblMaKhoa.Location = new System.Drawing.Point(23, 55);
            this.lblMaKhoa.Name = "lblMaKhoa";
            this.lblMaKhoa.Size = new System.Drawing.Size(60, 16);
            this.lblMaKhoa.TabIndex = 12;
            this.lblMaKhoa.Text = "Mã Khoa";
            // 
            // lblTenKhoa
            // 
            this.lblTenKhoa.AutoSize = true;
            this.lblTenKhoa.Location = new System.Drawing.Point(23, 117);
            this.lblTenKhoa.Name = "lblTenKhoa";
            this.lblTenKhoa.Size = new System.Drawing.Size(65, 16);
            this.lblTenKhoa.TabIndex = 13;
            this.lblTenKhoa.Text = "Tên Khoa";
            // 
            // b1
            // 
            this.b1.Controls.Add(this.lblTongGS);
            this.b1.Controls.Add(this.txtTongGS);
            this.b1.Controls.Add(this.txtTenKhoa);
            this.b1.Controls.Add(this.txtMaKhoa);
            this.b1.Controls.Add(this.lblMaKhoa);
            this.b1.Controls.Add(this.lblTenKhoa);
            this.b1.Location = new System.Drawing.Point(12, 96);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(292, 251);
            this.b1.TabIndex = 19;
            this.b1.TabStop = false;
            this.b1.Text = "Thông Tin Khoa";
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(318, 31);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(200, 32);
            this.lblHeader.TabIndex = 18;
            this.lblHeader.Text = "Quan Li Khoa";
            // 
            // frmFaculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(839, 579);
            this.Controls.Add(this.dvgFaculty);
            this.Controls.Add(this.lblResultGS);
            this.Controls.Add(this.txtTongGSFooter);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.lblHeader);
            this.Name = "frmFaculty";
            this.Text = "frmFaculty";
            ((System.ComponentModel.ISupportInitialize)(this.dvgFaculty)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.b1.ResumeLayout(false);
            this.b1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dvgFaculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.Label lblResultGS;
        private System.Windows.Forms.TextBox txtTongGSFooter;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.ComboBox cmbSort;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblTongGS;
        private System.Windows.Forms.TextBox txtTongGS;
        private System.Windows.Forms.TextBox txtTenKhoa;
        private System.Windows.Forms.TextBox txtMaKhoa;
        private System.Windows.Forms.Label lblMaKhoa;
        private System.Windows.Forms.Label lblTenKhoa;
        private System.Windows.Forms.GroupBox b1;
        private System.Windows.Forms.Label lblHeader;
    }
}