using System;

namespace Bank
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            BankAccount B = new BankAccount();
            B.FillBankNumber(random.Next(1, 999999));
            B.FillBalance(100000);
            B.FillType(TypeBankAccount.DEBIT);
            B.FullInfo();
        }
    }
}
