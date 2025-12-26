using System;
using ChoiceMenu;
using Operation;
using OperationHistory;
using financeTrack;
using ConsoleHelper;

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
                        int amount = TransactionInput.TransactionIncome();
                        Transaction transaction = new Transaction("Доходы", decription, amount);
                        transHistory.Add(transaction);
                        ConsoleOutput.WriteSuccess(); // Транзакция успешно добавлена
                        break;
                    case 2: // Добавить расход
                        string _decription = TransactionInput.TransactionDescription();
                        int expense = TransactionInput.TransactionExpense();
                        if (transHistory.CalculateBalance() < expense)
                        {
                            ConsoleOutput.WriteError(); // недостаточно средств
                        }
                        else
                        {
                            Transaction _transaction = new Transaction("Расходы", _decription, expense);
                            transHistory.Add(_transaction);
                            ConsoleOutput.WriteSuccess(); // Транзакция успешно добавлена
                        }
                        break;
                    case 3: // Показать все операции
                        if (transHistory.GetAll().Count > 0)
                        {
                            Console.WriteLine();
                            foreach (var t in transHistory.GetAll())
                            {
                                if (t.TypeOperation == "Доходы")
                                {
                                    ConsoleColor defaultColor = Console.ForegroundColor;
                                    Console.ForegroundColor = ConsoleColor.Green;
                                    Console.WriteLine(t.ToString());
                                    Console.ForegroundColor = defaultColor;
                                }
                                else if (t.TypeOperation == "Расходы")
                                {
                                    ConsoleColor defaultColor = Console.ForegroundColor;
                                    Console.ForegroundColor = ConsoleColor.Red;
                                    Console.WriteLine(t.ToString());
                                    Console.ForegroundColor = defaultColor;
                                }
                            }
                            Console.WriteLine();
                        }
                        else
                            ConsoleOutput.NoTransaction();
                            break;
                    case 4: //  Показать баланс
                        Console.WriteLine();
                        Console.WriteLine(transHistory.CalculateBalance());
                        Console.WriteLine();
                        break;
                    case 5: // Очистить историю.
                        transHistory.Clean();
                        break;
                    case 0: //  Выход
                        isWork = false;
                        break;
                }
            }
        }
    }
}