using BusinessLogic;
using System;
using System.Windows.Forms;

namespace ViewWinForms
{
    public partial class AddStudentForm : Form
    {
        private Logic _logic;

        public AddStudentForm(Logic logic)
        {
            InitializeComponent();
            this._logic = logic;
        }

        /// <summary>
        /// Сохраняет нового студента.
        /// </summary>
        public void btnSave_Click(object sender, EventArgs e)
        {
            
            string name = txtName.Text;
            string speciality = txtSpeciality.Text;
            string group = txtGroup.Text;

            _logic.AddStudent(name, speciality, group);

            this.Close();
        }
    }
}
