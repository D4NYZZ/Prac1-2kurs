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
        /// ��������� ������ ��������� � DataGridView.
        /// </summary>
        private void LoadStudents()
        {
            dataGridViewStudents.DataSource = null;
            dataGridViewStudents.DataSource = _logic.GetStudentList();
        }

        /// <summary>
        /// ��������� ����� ��� ���������� ������ ��������.
        /// </summary>
        private void btnAddStudent_Click(object sender, EventArgs e)
        {
            var addForm = new AddStudentForm(_logic);
            addForm.ShowDialog();
            LoadStudents();
        }

        /// <summary>
        /// ������� ���������� ��������.
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
                MessageBox.Show("�������� �������� ��� ��������");
            }
        }

        /// <summary>
        /// ��������� ����� ��� �������������� ������ ���������� ��������.
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
                MessageBox.Show("�������� �������� ��� ���������.");
            }
        }

        /// <summary>
        /// ���������� ����������� ������������� ��������� �� ��������������.
        /// </summary>
        private void btnShowHistogram_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(_logic);

            form2.Show();

        }
    }
}

