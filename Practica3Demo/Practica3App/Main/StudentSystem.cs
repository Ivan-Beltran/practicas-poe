using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using StudentSystemData;

namespace Practica3App.Main
{
    public partial class StudentSystem : Form
    {
        public StudentSystem()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Career career = new Career();
            Student student = new Student();

            career.Name = txtCareer.Text;
            student.firstName = txtName.Text;
            student.lastName = txtLastName.Text;
            student.phoneNumber = txtPhoneNumber.Text;
            student.career = career;

            lstBoxStudents.Items.Add(student);
            MessageBox.Show("estudiante agregado");
            LimpiarCampo();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(lstBoxStudents.SelectedItem is Student selectedStudent)
            {
                lstBoxStudents.Items.Remove(selectedStudent);
                MessageBox.Show("estudiante eliminado");
            }
            else
            {
                MessageBox.Show("no ha seleccionado un estudiante");
            }
        }

        public void LimpiarCampo()
        {
            txtName.Clear();
            txtLastName.Clear();
            txtPhoneNumber.Clear();
            txtCareer.Clear();
            txtName.Focus();


        }

    }
}
