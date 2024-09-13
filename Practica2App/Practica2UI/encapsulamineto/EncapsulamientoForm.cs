using Practica2UI.encapsulamineto.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Practica2UI.encapsulamineto
{
    public partial class EncapsulamientoForm : Form
    {
        Account account = new Account();
        public EncapsulamientoForm()
        {
            InitializeComponent();
        }

        private void depositButton_Click(object sender, EventArgs e)
        {
            account.MakeDeposit(double.Parse(InputTextBox.Text));

        }

        private void withdrawButton_Click(object sender, EventArgs e)
        {
            double amount=double.Parse(InputTextBox.Text);
            if(amount > 0)
            {
                account.Makewhithdraw(amount);
            }
            else { MessageBox.Show("por favor ingrese valores valido", "error", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void balanceButton_Click(object sender, EventArgs e)
        {
            account.ShowBalance();
        }
    }
}
