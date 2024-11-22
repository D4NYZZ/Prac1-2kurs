using BusinessLogic;
using System.Xml.Linq;

namespace ViewWinForms
{
    public partial class Form1 : Form
    {
        private Logic _logic;

        public Form1()
        {
            InitializeComponent();
            _logic = new Logic();
            LoadStudents();
        }

        /// <summary>
        /// «агружает список студентов в DataGridView.
        /// </summary>
        private void LoadStudents()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = _logic.GetStudentList();
        }

        /// <summary>
        /// ќткрывает форму дл€ добавлени€ нового студента.
        /// </summary>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm(_logic);
            addForm.ShowDialog();
            LoadStudents();
        }

        /// <summary>
        /// ”дал€ет выбранного студента.
        /// </summary>
        private void btnRemoveStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int index = dataGridViewStudents.SelectedRows[0].Index;
                _logic.RemoveStudent(index);
                LoadStudents();
            }
            else
            {
                MessageBox.Show("¬ыберите студента дл€ удалени€");
            }
        }

        /// <summary>
        /// ќткрывает форму дл€ редактировани€ данных выбранного студента.
        /// </summary>
        private void btnUpdateStudent_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudents.SelectedRows.Count > 0)
            {
                int index = dataGridViewStudents.SelectedRows[0].Index;
                var updateForm = new UpdateStudentForm(_logic, index);
                updateForm.ShowDialog();
                LoadStudents();
            }
            else
            {
                MessageBox.Show("¬ыберите студента дл€ изменени€.");
            }
        }

        /// <summary>
        /// ѕоказывает гистограмму распределени€ студентов по специальност€м.
        /// </summary>
        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_logic);

            form2.Show();

        }
    }
}

