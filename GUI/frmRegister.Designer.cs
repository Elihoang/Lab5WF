namespace GUI
{
    partial class frmRegister
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
            this.cmbMajor = new System.Windows.Forms.ComboBox();
            this.cmbFaculty = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbCheck = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.StudentID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AverageScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Faculty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvStudent
            // 
            this.dgvStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStudent.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cbCheck,
            this.StudentID,
            this.FullName,
            this.AverageScore,
            this.Faculty});
            this.dgvStudent.Location = new System.Drawing.Point(18, 215);
            this.dgvStudent.Name = "dgvStudent";
            this.dgvStudent.RowHeadersWidth = 51;
            this.dgvStudent.RowTemplate.Height = 24;
            this.dgvStudent.Size = new System.Drawing.Size(686, 254);
            this.dgvStudent.TabIndex = 52;
            // 
            // cmbMajor
            // 
            this.cmbMajor.FormattingEnabled = true;
            this.cmbMajor.Location = new System.Drawing.Point(263, 153);
            this.cmbMajor.Name = "cmbMajor";
            this.cmbMajor.Size = new System.Drawing.Size(230, 24);
            this.cmbMajor.TabIndex = 51;
            // 
            // cmbFaculty
            // 
            this.cmbFaculty.FormattingEnabled = true;
            this.cmbFaculty.Location = new System.Drawing.Point(263, 105);
            this.cmbFaculty.Name = "cmbFaculty";
            this.cmbFaculty.Size = new System.Drawing.Size(230, 24);
            this.cmbFaculty.TabIndex = 50;
            this.cmbFaculty.SelectedIndexChanged += new System.EventHandler(this.cmbFaculty_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 16);
            this.label3.TabIndex = 49;
            this.label3.Text = "Chuyen Nganh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(162, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 48;
            this.label2.Text = "Khoa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(225, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(268, 29);
            this.label1.TabIndex = 47;
            this.label1.Text = "Dang ki chuyen nganh";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(18, 490);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(86, 27);
            this.btnRegister.TabIndex = 53;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbCheck
            // 
            this.cbCheck.HeaderText = "Chọn";
            this.cbCheck.MinimumWidth = 6;
            this.cbCheck.Name = "cbCheck";
            this.cbCheck.Width = 125;
            // 
            // StudentID
            // 
            this.StudentID.HeaderText = "Mssv";
            this.StudentID.MinimumWidth = 6;
            this.StudentID.Name = "StudentID";
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
            // AverageScore
            // 
            this.AverageScore.HeaderText = "DTB";
            this.AverageScore.MinimumWidth = 6;
            this.AverageScore.Name = "AverageScore";
            this.AverageScore.ReadOnly = true;
            this.AverageScore.Width = 125;
            // 
            // Faculty
            // 
            this.Faculty.HeaderText = "Khoa";
            this.Faculty.MinimumWidth = 6;
            this.Faculty.Name = "Faculty";
            this.Faculty.ReadOnly = true;
            this.Faculty.Width = 125;
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 552);
            this.Controls.Add(this.dgvStudent);
            this.Controls.Add(this.cmbMajor);
            this.Controls.Add(this.cmbFaculty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnRegister);
            this.Name = "frmRegister";
            this.Text = "frmRegister";
            this.Load += new System.EventHandler(this.frmRegister_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvStudent;
        private System.Windows.Forms.ComboBox cmbMajor;
        private System.Windows.Forms.ComboBox cmbFaculty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.DataGridViewCheckBoxColumn cbCheck;
        private System.Windows.Forms.DataGridViewTextBoxColumn StudentID;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn AverageScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Faculty;
    }
}