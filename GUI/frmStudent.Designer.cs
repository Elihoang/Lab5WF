namespace GUI
{
    partial class frmStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStudent));
            this.cbDangKi = new System.Windows.Forms.CheckBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btnDangKi = new System.Windows.Forms.ToolStripMenuItem();
            this.thốngKêToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvStudent = new System.Windows.Forms.DataGridView();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Major = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.picAvatar = new System.Windows.Forms.PictureBox();
            this.btnLink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.txtAverageScore = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblHeader = new System.Windows.Forms.Label();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.lblFaculty = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMssv = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDTB = new System.Windows.Forms.Label();
            this.btnIsertEdit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.ToolStripButton();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbDangKi
            // 
            this.cbDangKi.AutoSize = true;
            this.cbDangKi.Location = new System.Drawing.Point(859, 144);
            this.cbDangKi.Name = "cbDangKi";
            this.cbDangKi.Size = new System.Drawing.Size(198, 20);
            this.cbDangKi.TabIndex = 61;
            this.cbDangKi.Text = "Chưa Đăng ký chuyên ngành";
            this.cbDangKi.UseVisualStyleBackColor = true;
            this.cbDangKi.CheckedChanged += new System.EventHandler(this.cbDangKi_CheckedChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnDangKi,
            this.thốngKêToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 27);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1078, 28);
            this.menuStrip1.TabIndex = 58;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btnDangKi
            // 
            this.btnDangKi.Name = "btnDangKi";
            this.btnDangKi.Size = new System.Drawing.Size(76, 24);
            this.btnDangKi.Text = "Đăng Kí";
            this.btnDangKi.Click += new System.EventHandler(this.btnDangKi_Click);
            // 
            // thốngKêToolStripMenuItem
            // 
            this.thốngKêToolStripMenuItem.Name = "thốngKêToolStripMenuItem";
            this.thốngKêToolStripMenuItem.Size = new System.Drawing.Size(86, 24);
            this.thốngKêToolStripMenuItem.Text = "Thống Kê";
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.StudentID,
            this.FullName,
            this.Faculty,
            this.AverageScore,
            this.Major});
            this.dgvStudent.Location = new System.Drawing.Point(404, 170);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(652, 386);
            this.dgvStudent.TabIndex = 57;
            this.dgvStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvStudent_CellClick);
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "MSSV";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
            this.StudentID.ReadOnly = true;
            this.StudentID.Width = 125;
            // 
            // FullName
            // 
            this.FullName.HeaderText = "Ho Ten";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            this.FullName.Width = 125;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.Width = 125;
            // 
            // AverageScore
            // 
            this.AverageScore.HeaderText = "DTB";
            this.AverageScore.MinimumWidth = 6;
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.ReadOnly = true;
            this.AverageScore.Width = 125;
            // 
            // Major
            // 
            this.Major.HeaderText = "Chuyên Ngành";
            this.Major.MinimumWidth = 6;
            this.Major.Name = "Major";
            this.Major.Width = 125;
            // 
            // picAvatar
            // 
            this.picAvatar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picAvatar.Location = new System.Drawing.Point(0, 0);
            this.picAvatar.Name = "picAvatar";
            this.picAvatar.Size = new System.Drawing.Size(137, 147);
            this.picAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picAvatar.TabIndex = 53;
            this.picAvatar.TabStop = false;
            // 
            // btnLink
            // 
            this.btnLink.Location = new System.Drawing.Point(275, 214);
            this.btnLink.Name = "btnLink";
            this.btnLink.Size = new System.Drawing.Size(38, 35);
            this.btnLink.TabIndex = 53;
            this.btnLink.Text = "...";
            this.btnLink.UseVisualStyleBackColor = true;
            this.btnLink.Click += new System.EventHandler(this.btnLink_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 214);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "ảnh đại diện";
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(132, 158);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(181, 24);
            this.cmbFaculty.TabIndex = 9;
            // 
            // txtAverageScore
            // 
            this.txtAverageScore.Location = new System.Drawing.Point(132, 112);
            this.txtAverageScore.Name = "txtAverageScore";
            this.txtAverageScore.Size = new System.Drawing.Size(91, 22);
            this.txtAverageScore.TabIndex = 8;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(132, 72);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(181, 22);
            this.txtName.TabIndex = 7;
            // 
            // lblHeader
            // 
            this.lblHeader.AutoSize = true;
            this.lblHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeader.Location = new System.Drawing.Point(380, 99);
            this.lblHeader.Name = "lblHeader";
            this.lblHeader.Size = new System.Drawing.Size(293, 25);
            this.lblHeader.TabIndex = 53;
            this.lblHeader.Text = "Quan Li Thong Tin Sinh Vien";
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(132, 31);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(181, 22);
            this.txtMSSV.TabIndex = 2;
            // 
            // lblFaculty
            // 
            this.lblFaculty.AutoSize = true;
            this.lblFaculty.Location = new System.Drawing.Point(16, 166);
            this.lblFaculty.Name = "lblFaculty";
            this.lblFaculty.Size = new System.Drawing.Size(102, 16);
            this.lblFaculty.TabIndex = 5;
            this.lblFaculty.Text = "Chuyên Nghành";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(16, 75);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(52, 16);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Họ Tên";
            // 
            // lblMssv
            // 
            this.lblMssv.AutoSize = true;
            this.lblMssv.Location = new System.Drawing.Point(16, 37);
            this.lblMssv.Name = "lblMssv";
            this.lblMssv.Size = new System.Drawing.Size(85, 16);
            this.lblMssv.TabIndex = 2;
            this.lblMssv.Text = "Mã Sinh Viên";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(253, 527);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(111, 35);
            this.btnDelete.TabIndex = 55;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnLink);
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cmbFaculty);
            this.groupBox1.Controls.Add(this.txtAverageScore);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.txtMSSV);
            this.groupBox1.Controls.Add(this.lblDTB);
            this.groupBox1.Controls.Add(this.lblFaculty);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Controls.Add(this.lblMssv);
            this.groupBox1.Location = new System.Drawing.Point(34, 154);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 367);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thong Tin Sinh Vien";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.picAvatar);
            this.panel1.Location = new System.Drawing.Point(132, 214);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(137, 147);
            this.panel1.TabIndex = 62;
            // 
            // lblDTB
            // 
            this.lblDTB.AutoSize = true;
            this.lblDTB.Location = new System.Drawing.Point(16, 118);
            this.lblDTB.Name = "lblDTB";
            this.lblDTB.Size = new System.Drawing.Size(105, 16);
            this.lblDTB.TabIndex = 6;
            this.lblDTB.Text = "Điểm Trung Bình";
            // 
            // btnIsertEdit
            // 
            this.btnIsertEdit.Location = new System.Drawing.Point(104, 527);
            this.btnIsertEdit.Name = "btnIsertEdit";
            this.btnIsertEdit.Size = new System.Drawing.Size(111, 35);
            this.btnIsertEdit.TabIndex = 56;
            this.btnIsertEdit.Text = "Thêm/Sửa";
            this.btnIsertEdit.UseVisualStyleBackColor = true;
            this.btnIsertEdit.Click += new System.EventHandler(this.btnIsertEdit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(96, 24);
            this.btnSearch.Text = "Tìm Kiếm";
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.btnSearch});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1078, 27);
            this.toolStrip1.TabIndex = 59;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(121, 24);
            this.toolStripButton1.Text = "Quản Lí Khoa";
            // 
            // frmStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 596);
            this.Controls.Add(this.cbDangKi);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.lblHeader);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnIsertEdit);
            this.Controls.Add(this.toolStrip1);
            this.Name = "frmStudent";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frmStudent_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picAvatar)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbDangKi;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnDangKi;
        private System.Windows.Forms.ToolStripMenuItem thốngKêToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.PictureBox picAvatar;
        private System.Windows.Forms.Button btnLink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.TextBox txtAverageScore;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label lblFaculty;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMssv;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblDTB;
        private System.Windows.Forms.Button btnIsertEdit;
        private System.Windows.Forms.ToolStripButton btnSearch;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Major;
        private System.Windows.Forms.Panel panel1;
    }
}

