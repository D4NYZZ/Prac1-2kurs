namespace ViewWinForms
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridViewStudents = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            specialityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            groupDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            studentBindingSource = new BindingSource(components);
            btnAddStudent = new Button();
            btnRemoveStudent = new Button();
            btnUpdateStudent = new Button();
            btnShow = new Button();
            studentBindingSource1 = new BindingSource(components);
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewStudents
            // 
            dataGridViewStudents.AutoGenerateColumns = false;
            dataGridViewStudents.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewStudents.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, specialityDataGridViewTextBoxColumn, groupDataGridViewTextBoxColumn });
            dataGridViewStudents.DataSource = studentBindingSource;
            dataGridViewStudents.Location = new Point(316, 12);
            dataGridViewStudents.Name = "dataGridViewStudents";
            dataGridViewStudents.Size = new Size(344, 417);
            dataGridViewStudents.TabIndex = 0;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "Имя";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // specialityDataGridViewTextBoxColumn
            // 
            specialityDataGridViewTextBoxColumn.DataPropertyName = "Speciality";
            specialityDataGridViewTextBoxColumn.HeaderText = "Специальность";
            specialityDataGridViewTextBoxColumn.Name = "specialityDataGridViewTextBoxColumn";
            // 
            // groupDataGridViewTextBoxColumn
            // 
            groupDataGridViewTextBoxColumn.DataPropertyName = "Group";
            groupDataGridViewTextBoxColumn.HeaderText = "Группа";
            groupDataGridViewTextBoxColumn.Name = "groupDataGridViewTextBoxColumn";
            // 
            // studentBindingSource
            // 
            studentBindingSource.DataSource = typeof(Model.Student);
            // 
            // btnAddStudent
            // 
            btnAddStudent.Location = new Point(48, 72);
            btnAddStudent.Name = "btnAddStudent";
            btnAddStudent.Size = new Size(120, 40);
            btnAddStudent.TabIndex = 1;
            btnAddStudent.Text = "Добавить студента";
            btnAddStudent.UseVisualStyleBackColor = true;
            btnAddStudent.Click += btnAddStudent_Click;
            // 
            // btnRemoveStudent
            // 
            btnRemoveStudent.Location = new Point(48, 164);
            btnRemoveStudent.Name = "btnRemoveStudent";
            btnRemoveStudent.Size = new Size(120, 40);
            btnRemoveStudent.TabIndex = 2;
            btnRemoveStudent.Text = "Удалить студента";
            btnRemoveStudent.UseVisualStyleBackColor = true;
            btnRemoveStudent.Click += btnRemoveStudent_Click;
            // 
            // btnUpdateStudent
            // 
            btnUpdateStudent.Location = new Point(48, 255);
            btnUpdateStudent.Name = "btnUpdateStudent";
            btnUpdateStudent.Size = new Size(120, 40);
            btnUpdateStudent.TabIndex = 3;
            btnUpdateStudent.Text = "Изменить данные студента";
            btnUpdateStudent.UseVisualStyleBackColor = true;
            btnUpdateStudent.Click += btnUpdateStudent_Click;
            // 
            // btnShow
            // 
            btnShow.Location = new Point(48, 343);
            btnShow.Name = "btnShow";
            btnShow.Size = new Size(120, 40);
            btnShow.TabIndex = 4;
            btnShow.Text = "Вывод гистограммы\r\n";
            btnShow.UseVisualStyleBackColor = true;
            btnShow.Click += btnShowHistogram_Click;
            // 
            // studentBindingSource1
            // 
            studentBindingSource1.DataSource = typeof(Model.Student);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(672, 468);
            Controls.Add(btnShow);
            Controls.Add(btnUpdateStudent);
            Controls.Add(btnRemoveStudent);
            Controls.Add(btnAddStudent);
            Controls.Add(dataGridViewStudents);
            Name = "Form1";
            Text = "ДеканатПРО";
            ((System.ComponentModel.ISupportInitialize)dataGridViewStudents).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)studentBindingSource1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridViewStudents;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn specialityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn groupDataGridViewTextBoxColumn;
        private BindingSource studentBindingSource;
        private Button btnAddStudent;
        private Button btnRemoveStudent;
        private Button btnUpdateStudent;
        private Button btnShow;
        private BindingSource studentBindingSource1;
    }
}
