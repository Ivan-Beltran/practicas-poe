using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica2UI.encapsulamineto.modelo
{
    public class Account
    {
        private double balance;

        public double Balance
        {
            get { return balance; }
            set { balance = value; }
        }

        private void Deposit(double amount)
        {
            balance += amount;
            MessageBox.Show("deposito realizado con exito");
        }

        private void Withdraw(double amount)
        {
           
                if (amount <= balance)
                {
                    balance -= amount;
                    MessageBox.Show("se retiro con exito");
                }
                else
                {
                    MessageBox.Show("saldo insuficiente");
                }
            
        }

        public void MakeDeposit(double amount)
        {
            Deposit(amount);
        }
        public void Makewhithdraw(double amount)
        {
            Withdraw(amount);
        }

        public void ShowBalance()
        {
            MessageBox.Show($"su saldo actual es {balance}");
        }

    }
}
