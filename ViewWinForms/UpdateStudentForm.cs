using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewWinForms
{
    public partial class UpdateStudentForm : Form
    {
        private Logic _logic;
        private int studentIndex;

        public UpdateStudentForm(Logic logic, int index)
        {
            InitializeComponent();
            _logic = logic;
            studentIndex = index;

            LoadStudentData();
        }

        /// <summary>
        /// Загружает данные студента в текстовые поля.
        /// </summary>
        private void LoadStudentData()
        {
            var student = _logic.GetStudentByIndex(studentIndex);
            if (student != null)
            {
                txtName.Text = student.Name;
                txtSpeciality.Text = student.Speciality;
                txtGroup.Text = student.Group;
            }
        }

        /// <summary>
        /// Сохраняет изменения данных студента.
        /// </summary>
        private void btnSave_Click(object sender, EventArgs e)
        {
            string newName = txtName.Text;
            string newSpeciality = txtSpeciality.Text;
            string newGroup = txtGroup.Text;

            _logic.UpdateStudent(studentIndex, newName, newSpeciality, newGroup);

            LoadStudentData();

            this.Close();
        }
    }
}
