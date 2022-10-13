using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exercicio_proposto_155.Entities.Exceptions;

namespace Exercicio_proposto_155.Entities
{
    internal class Account
    {
        public int Number { get; set; }
        public string Holder { get; set; }
        public double Balance { get; set; }
        public double  WithDrawLimit { get; set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposit(double amount)
        {
            Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit) {
                throw new DomainExceptions("The amount exceeeds withdraw limit");
            }
            if (amount > Balance)
            {
                throw new DomainExceptions("Not enough balance");
            }
            Balance -= amount;
        }
    }
}
