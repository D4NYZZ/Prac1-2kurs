﻿using BusinessLogic;
namespace ViewWinForms
{
    partial class AddStudentForm
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
            txtName = new TextBox();
            txtSpeciality = new TextBox();
            txtGroup = new TextBox();
            btnSave = new Button();
            txtLabelName = new Label();
            txtLabelSpeciality = new Label();
            txtLabelGroup = new Label();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.Location = new Point(31, 35);
            txtName.Multiline = true;
            txtName.Name = "txtName";
            txtName.Size = new Size(110, 30);
            txtName.TabIndex = 0;
            // 
            // txtSpeciality
            // 
            txtSpeciality.Location = new Point(31, 100);
            txtSpeciality.Multiline = true;
            txtSpeciality.Name = "txtSpeciality";
            txtSpeciality.Size = new Size(110, 30);
            txtSpeciality.TabIndex = 1;
            // 
            // txtGroup
            // 
            txtGroup.Location = new Point(31, 165);
            txtGroup.Multiline = true;
            txtGroup.Name = "txtGroup";
            txtGroup.Size = new Size(110, 30);
            txtGroup.TabIndex = 2;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(31, 230);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(110, 34);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // txtLabelName
            // 
            txtLabelName.AutoSize = true;
            txtLabelName.Location = new Point(24, 9);
            txtLabelName.Name = "txtLabelName";
            txtLabelName.Size = new Size(125, 15);
            txtLabelName.TabIndex = 4;
            txtLabelName.Text = "Введите имя студента";
            // 
            // txtLabelSpeciality
            // 
            txtLabelSpeciality.AutoSize = true;
            txtLabelSpeciality.Location = new Point(5, 75);
            txtLabelSpeciality.Name = "txtLabelSpeciality";
            txtLabelSpeciality.Size = new Size(186, 15);
            txtLabelSpeciality.TabIndex = 5;
            txtLabelSpeciality.Text = "Введите специальность студента";
            // 
            // txtLabelGroup
            // 
            txtLabelGroup.AutoSize = true;
            txtLabelGroup.Location = new Point(20, 140);
            txtLabelGroup.Name = "txtLabelGroup";
            txtLabelGroup.Size = new Size(141, 15);
            txtLabelGroup.TabIndex = 6;
            txtLabelGroup.Text = "Введите группу студента";
            // 
            // AddStudentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtLabelGroup);
            Controls.Add(txtLabelSpeciality);
            Controls.Add(txtLabelName);
            Controls.Add(btnSave);
            Controls.Add(txtGroup);
            Controls.Add(txtSpeciality);
            Controls.Add(txtName);
            Name = "AddStudentForm";
            Text = "AddStudentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtName;
        private TextBox txtSpeciality;
        private TextBox txtGroup;
        private Button btnSave;
        private Label txtLabelName;
        private Label txtLabelSpeciality;
        private Label txtLabelGroup;
    }
}