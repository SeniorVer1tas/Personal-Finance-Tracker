using System;
using Operation;

namespace OperationHistory
{
    class TransactionHistory
    {
        private List<Transaction> _transactions = new List<Transaction>();

        public void Add (Transaction transaction)
        {
            _transactions.Add(transaction);
        }
        public List<Transaction> GetAll()
        {
            return _transactions;
        }
        public int CalculateBalance()
        {
            int balance = 0;
            foreach (var t in _transactions)
            {
                if(t.TypeOperation == "Доходы")
                {
                    balance += t.Amount;
                }
                else if (t.TypeOperation == "Расходы")
                {
                    balance -= t.Amount;
                }
            }
            return balance;
        }
        public void Clean()
        {
            _transactions.Clear();
            return;
        }
    }
}