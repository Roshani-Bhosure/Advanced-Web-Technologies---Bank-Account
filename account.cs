using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Account
{
    class account
    {
        int balance = 0;
        public void open(int amount)
        {
            int amt = amount;
            balance += amt;
            MessageBox.Show("Account Successfully Opened");
        }
        public void withdraw(int amount)
        {
            balance -= amount;
            MessageBox.Show("Withdrawal Successful, Current Balance Amount " + balance);
        }
        public void deposit(int amount)
        {
            balance += amount;
            MessageBox.Show("Deposit Successful, Current Balance Amount " + balance);
        }
        public void checkbalance()
        {
            MessageBox.Show("Avaliable Balance is " + balance);
        }
    }
}
