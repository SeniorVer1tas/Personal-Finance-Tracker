using System;
using ChoiceMenu;
using Operation;
using OperationHistory;
using financeTrack;

namespace FinanceTrack
{
    class Program
    {
        static void Main(string[] args)
        {
            var transHistory = new TransactionHistory();
            bool isWork = true;

            while (isWork)
            {
                Menu.ShowMenu();
                int userChoice = Convert.ToInt32(Console.ReadLine());
                switch (userChoice)
                {
                    case 1: // Добавить доход
                        string decription = TransactionInput.TransactionDescription();
                        int amount = TransactionInput.TransactionAmount();
                        Transaction transaction = new Transaction("Доход", decription, amount);
                        transHistory.Add(transaction);

                        break;
                    case 2: // Добавить расход
                        break;
                    case 3: // Показать все операции

                        break;
                    case 4: //  Показать баланс
                        break;
                    case 0: //  Выход
                        isWork = false;
                        break;
                }
            }
        }
    }
}