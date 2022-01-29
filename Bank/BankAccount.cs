using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank
{
    public class BankAccount
    {
        private int banknumber;
        private decimal balance;
        private TypeBankAccount type;

        public int BankNumberInfo()
        {
            return banknumber;
        }

        public decimal BalanceInfo()
        {
            return balance;
        }
        
        public TypeBankAccount AccountTypeInfo()
        {
            return type;
        }

        public void FillBankNumber(int number)
        {
            banknumber = number;
        }

        public void FillBalance(decimal xbalance)
        {
            balance = xbalance;
        }

        public void FillType(TypeBankAccount typeaccount)
        {
            type = typeaccount;
        }

        public void FullInfo()
        {
            Console.WriteLine($"Тип счёта: {type}, Номер счёта: {banknumber}, Баланс: {balance}");
        }
    }

}
