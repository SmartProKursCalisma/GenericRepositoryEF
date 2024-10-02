using GenericRepositoryEF.Entities.Dtos.UserModels;
using GenericRepositoryEF.Helpers;
using GenericRepositoryEF.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GenericRepositoryEF
{
    public partial class StudentManagerForm : Form
    {
        StudentService _studentService;
        public StudentManagerForm()
        {
            InitializeComponent();
            _studentService = new StudentService();
        }

        private void StudentManagerForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = _studentService.GetAllStudentWithGrades();

        }
    }
}
