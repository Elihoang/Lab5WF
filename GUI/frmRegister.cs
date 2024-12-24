using BUS.Services;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class frmRegister : Form
    {
       
        StudentService studentService = new StudentService();
        FacultyService facultyService = new FacultyService();
        MajorService majorService = new MajorService();
        public frmRegister()
        {
            InitializeComponent();
        }
        
        private void frmRegister_Load(object sender, EventArgs e)
        {
            LoadFaculty();
            /*var listMajor = majorService.GetAllMajors();
            LoadMajor(listMajor);*/
        }
        void LoadFaculty()
        {
            var listFaculty = facultyService.GetAll();

            cmbFaculty.DataSource = listFaculty;
            cmbFaculty.DisplayMember = "FacultyName";
            cmbFaculty.ValueMember = "FacultyID";
        }
        void LoadMajor(List<Major> listMajor)
        {
            cmbMajor.DataSource = listMajor;
            cmbMajor.DisplayMember = "Name";
            cmbMajor.ValueMember = "MajorID";
        }

        private void cmbFaculty_SelectedIndexChanged(object sender, EventArgs e)
        {
            Faculty selectedFaculty = cmbFaculty.SelectedItem as Faculty;

            if (selectedFaculty != null)
            {
                var listMajor = majorService.GetAllFaculty(selectedFaculty.FacultyID);
                LoadMajor(listMajor);
                var listStudent = studentService.GetAllNoMajor(selectedFaculty.FacultyID);
                Datagrid(listStudent);

            }
        }
        void Datagrid(List<Student> listStudent)
        {
            dgvStudent.Rows.Clear();

            foreach (var item in listStudent)
            {
                int row = dgvStudent.Rows.Add();
                dgvStudent.Rows[row].Cells[1].Value = item.StudentID;
                dgvStudent.Rows[row].Cells[2].Value = item.FullName;

                if (item.Faculty != null)
                {
                    dgvStudent.Rows[row].Cells[3].Value = item.Faculty.FacultyName;
                }
                dgvStudent.Rows[row].Cells[4].Value = item.AverageScore;

            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            try
            {
                var selectedMajor = cmbMajor.SelectedItem as Major;
                
                foreach (DataGridViewRow row in dgvStudent.Rows)
                {
                    if (Convert.ToBoolean(row.Cells[0].Value) == true)
                    {
                        
                        var studentId = row.Cells[1].Value.ToString();
                        var student = studentService.FindById(studentId);

                        if (student != null)
                        {
                            student.MajorID = selectedMajor.MajorID;
                            studentService.UpdateInsert(student);
                        }
                    }
                }
                var selectedFaculty = cmbFaculty.SelectedItem as Faculty;
                if (selectedFaculty != null)
                {
                    var listStudent = studentService.GetAllNoMajor(selectedFaculty.FacultyID);
                    Datagrid(listStudent);
                }

                MessageBox.Show("Đăng ký ngành thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Đã xảy ra lỗi: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
