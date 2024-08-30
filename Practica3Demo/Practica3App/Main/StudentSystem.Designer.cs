namespace Practica3App.Main
{
    partial class StudentSystem
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
            NameLabel = new Label();
            LastNameLabel = new Label();
            phoneNumberLabel = new Label();
            careerLabel = new Label();
            txtName = new TextBox();
            txtLastName = new TextBox();
            txtPhoneNumber = new TextBox();
            txtCareer = new TextBox();
            titleLabel = new Label();
            btnAdd = new Button();
            btnDelete = new Button();
            lstBoxStudents = new ListBox();
            SuspendLayout();
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Location = new Point(194, 106);
            NameLabel.Margin = new Padding(4, 0, 4, 0);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(174, 18);
            NameLabel.TabIndex = 0;
            NameLabel.Text = "nombres del alumno";
            // 
            // LastNameLabel
            // 
            LastNameLabel.AutoSize = true;
            LastNameLabel.Location = new Point(194, 189);
            LastNameLabel.Margin = new Padding(4, 0, 4, 0);
            LastNameLabel.Name = "LastNameLabel";
            LastNameLabel.Size = new Size(173, 18);
            LastNameLabel.TabIndex = 1;
            LastNameLabel.Text = "apellidos del alumno";
            // 
            // phoneNumberLabel
            // 
            phoneNumberLabel.AutoSize = true;
            phoneNumberLabel.BackColor = Color.LightBlue;
            phoneNumberLabel.Location = new Point(194, 286);
            phoneNumberLabel.Margin = new Padding(4, 0, 4, 0);
            phoneNumberLabel.Name = "phoneNumberLabel";
            phoneNumberLabel.Size = new Size(168, 18);
            phoneNumberLabel.TabIndex = 2;
            phoneNumberLabel.Text = "numero de telefono";
            // 
            // careerLabel
            // 
            careerLabel.AutoSize = true;
            careerLabel.Location = new Point(194, 365);
            careerLabel.Margin = new Padding(4, 0, 4, 0);
            careerLabel.Name = "careerLabel";
            careerLabel.Size = new Size(161, 18);
            careerLabel.TabIndex = 3;
            careerLabel.Text = "carrera del alumno";
            // 
            // txtName
            // 
            txtName.Location = new Point(450, 100);
            txtName.Margin = new Padding(4, 3, 4, 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(589, 26);
            txtName.TabIndex = 4;
            // 
            // txtLastName
            // 
            txtLastName.Location = new Point(450, 186);
            txtLastName.Margin = new Padding(4, 3, 4, 3);
            txtLastName.Name = "txtLastName";
            txtLastName.Size = new Size(589, 26);
            txtLastName.TabIndex = 5;
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.Location = new Point(450, 286);
            txtPhoneNumber.Margin = new Padding(4, 3, 4, 3);
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.Size = new Size(589, 26);
            txtPhoneNumber.TabIndex = 6;
            // 
            // txtCareer
            // 
            txtCareer.Location = new Point(450, 363);
            txtCareer.Margin = new Padding(4, 3, 4, 3);
            txtCareer.Name = "txtCareer";
            txtCareer.Size = new Size(589, 26);
            txtCareer.TabIndex = 7;
            // 
            // titleLabel
            // 
            titleLabel.AutoSize = true;
            titleLabel.Location = new Point(450, 19);
            titleLabel.Margin = new Padding(4, 0, 4, 0);
            titleLabel.Name = "titleLabel";
            titleLabel.Size = new Size(198, 18);
            titleLabel.TabIndex = 8;
            titleLabel.Text = "registro de estudiantes";
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(398, 436);
            btnAdd.Margin = new Padding(4, 3, 4, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(118, 26);
            btnAdd.TabIndex = 9;
            btnAdd.Text = "agregar";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(669, 434);
            btnDelete.Margin = new Padding(4, 3, 4, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(118, 26);
            btnDelete.TabIndex = 10;
            btnDelete.Text = "eliminar";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // lstBoxStudents
            // 
            lstBoxStudents.FormattingEnabled = true;
            lstBoxStudents.ItemHeight = 18;
            lstBoxStudents.Location = new Point(250, 483);
            lstBoxStudents.Margin = new Padding(4, 3, 4, 3);
            lstBoxStudents.Name = "lstBoxStudents";
            lstBoxStudents.Size = new Size(1050, 166);
            lstBoxStudents.TabIndex = 11;
            // 
            // StudentSystem
            // 
            AutoScaleDimensions = new SizeF(10F, 18F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightBlue;
            ClientSize = new Size(1561, 668);
            Controls.Add(lstBoxStudents);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(titleLabel);
            Controls.Add(txtCareer);
            Controls.Add(txtPhoneNumber);
            Controls.Add(txtLastName);
            Controls.Add(txtName);
            Controls.Add(careerLabel);
            Controls.Add(phoneNumberLabel);
            Controls.Add(LastNameLabel);
            Controls.Add(NameLabel);
            Font = new Font("Verdana", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4, 3, 4, 3);
            Name = "StudentSystem";
            Text = "MianForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NameLabel;
        private Label LastNameLabel;
        private Label phoneNumberLabel;
        private Label careerLabel;
        private TextBox txtName;
        private TextBox txtLastName;
        private TextBox txtPhoneNumber;
        private TextBox txtCareer;
        private Label titleLabel;
        private Button btnAdd;
        private Button btnDelete;
        private ListBox lstBoxStudents;
    }
}