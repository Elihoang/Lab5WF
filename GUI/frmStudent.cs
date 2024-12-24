
using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmStudent : Form
    {
        StudentService studentService= new StudentService();
        FacultyService facultyService = new FacultyService();
        MajorService majorService = new MajorService(); 
        private string avatarPath = string.Empty;

        public frmStudent()
        {
            InitializeComponent();
        }

        private void frmStudent_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            var listStudent = studentService.GetAllStudents();
            Datagrid(listStudent);
            
        }
        void LoadFaculty()
        {
            var listFaculty = facultyService.GetAll();

            cmbFaculty.DataSource = listFaculty;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }

        void Datagrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();

            foreach (var item in listStudent)
            {
                int index = dgvStudent.Rows.Add();
                dgvStudent.Rows[index].Cells[0].Value = item.StudentID;
                dgvStudent.Rows[index].Cells[1].Value = item.FullName;

                if (item.Faculty != null)
                {
                    dgvStudent.Rows[index].Cells[2].Value = item.Faculty.FacultyName;
                }
                dgvStudent.Rows[index].Cells[3].Value = item.AverageScore;

                if (item.MajorID != null)
                {
                    dgvStudent.Rows[index].Cells[4].Value = item.Major.Name;  
                }
            }
        }

        private void cbDangKi_CheckedChanged(object sender, EventArgs e)
        {
            var listStudent = new List<Student>();  
            if (this.cbDangKi.Checked)
            {

                listStudent = studentService.GetAllNoMajor();
            }
            else
            {
                listStudent = studentService.GetAllStudents();
            }

            Datagrid(listStudent);
        }

       

        private void btnIsertEdit_Click(object sender, EventArgs e)
        {
            string mssv = txtMSSV.Text;
            string fullName = txtName.Text;
            string avgScoreStr = txtAverageScore.Text;
            int faculty = (cmbFaculty.SelectedItem as Faculty).FacultyID;

            if (string.IsNullOrWhiteSpace(mssv) || string.IsNullOrWhiteSpace(fullName) || string.IsNullOrEmpty(avgScoreStr))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (mssv.Length != 10 || !mssv.All(char.IsDigit))
            {
                MessageBox.Show("Mã số sinh viên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (fullName.Length < 3 || fullName.Length > 100 || !fullName.All(c => char.IsLetter(c) || c == ' '))
            {
                MessageBox.Show("Tên sinh viên không hợp lệ", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(avgScoreStr, out double averageScore) || averageScore < 0 || averageScore > 10)
            {
                MessageBox.Show("Điểm trung bình sinh viên không hợp lệ. Giá trị phải nằm trong khoảng từ 0 đến 10.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var student = studentService.FindById(mssv) ?? new Student();
            
            student.StudentID = mssv;
            student.FullName = fullName;
            student.AverageScore = double.Parse(averageScore.ToString());
            student.FacultyID= int.Parse(cmbFaculty.SelectedValue.ToString());

            if (!string.IsNullOrEmpty(avatarPath))
            {
                string avatarFileName = SaveImage(avatarPath, student.StudentID);
                if (!string.IsNullOrEmpty(avatarFileName))
                {
                    student.Avatar = avatarFileName;
                }
            }
            studentService.UpdateInsert(student);
            MessageBox.Show("Cập nhập thành công!");
            var listStudent = studentService.GetAllStudents();
            Datagrid(listStudent);
            ClearData();
            reload();
            avatarPath = string.Empty;

        }
      
        void ClearData()
        {
            txtAverageScore.Clear();
            txtMSSV.Clear();
            txtName.Clear();    
            cmbFaculty.SelectedIndex = -1;
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn muốn xóa sinh viên này", "Thông báo", MessageBoxButtons.YesNo);

            Student studentDelete = studentService.FindById(txtMSSV.Text);

            if (studentDelete == null)
            {
                MessageBox.Show("Mã sinh viên không tồn tại trong hệ thống");
                return;
            }
            if (result == DialogResult.Yes)
            {
                studentService.Delete(studentDelete);
                MessageBox.Show("Xóa sinh viên thành công!");
            }
            var listStudent = studentService.GetAllStudents();
            Datagrid(listStudent);
        }

        private void dgvStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dgvStudent.Rows[e.RowIndex];
            txtMSSV.Text = row.Cells[0].Value.ToString();
            txtName.Text = row.Cells[1].Value.ToString();
            cmbFaculty.Text = row.Cells[2].Value.ToString();
            txtAverageScore.Text = row.Cells[3].Value.ToString();
            LoadAvatar(txtMSSV.Text);
        }

        private void btnLink_Click(object sender, EventArgs e)
        {
            using(OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Filter = "Image File (*.jpg, *.jpeg,*.png)|*.jpg;*.jpeg; *.png";
                if(dlg.ShowDialog() == DialogResult.OK)
                {
                    avatarPath = dlg.FileName;
                    picAvatar.Image=Image.FromFile(avatarPath);
                }
            }
        }
        private void LoadAvatar(string studentId)
        {
            string foderPath = Path.Combine(Application.StartupPath, "Images");
            var student = studentService.FindById(studentId);
            if(student != null && !string.IsNullOrEmpty(student.Avatar))
            {
                string avatarFath = Path.Combine(foderPath, student.Avatar);
                if(File.Exists(avatarFath))
                {
                    picAvatar.Image=Image.FromFile(avatarFath);
                }
                else
                {
                    picAvatar.Image = null;
                }
            }
            else
            {
                picAvatar.Image = null;
            }

        }

        private string SaveImage(string sourcePath,string studentId)
        {
            try
            {
                string folderPath = Path.Combine(Application.StartupPath, "Images");
                if(!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                string fileExtension = Path.GetExtension(sourcePath);
                string targetPath= Path.Combine(folderPath, $"{studentId}{fileExtension}");
                if (!File.Exists(sourcePath))
                {
                    throw new FileNotFoundException($"KO tìm thấy file {sourcePath}");
                }
                File.Copy(sourcePath, targetPath, true);
                return $"{studentId}{fileExtension}";

            }
            catch(Exception ex)
            {
                MessageBox.Show("Avatar error ");
                return null;
            }
        }

        private void btnDangKi_Click(object sender, EventArgs e)
        {
            frmRegister f = new frmRegister();
            f.ShowDialog();
            var listStudent = studentService.GetAllStudents();
            Datagrid(listStudent);
        }
        void reload()
        {
            var listStudent = studentService.GetAllStudents();
            Datagrid(listStudent);
        }
    }
}
