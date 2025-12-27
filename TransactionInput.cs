using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace financeTrack
{
    internal class TransactionInput
    {
        public static string TransactionDescription()
        {

            while (true)
            {
                Console.Write("Укажите описание транзакции: \n");
                string userInput = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(userInput))
                {
                    Console.WriteLine("Некорректный ввод");
                }
                else
                {
                    return userInput.ToUpper();
                }
            }
        }

        public static int TransactionIncome()
        {
            while (true)
            {
                Console.Write("Укажите сумму зачисления: \n");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput <= 0)
                {
                    Console.WriteLine("Некорректный ввод");
                }
                else
                {
                    return userInput;
                }
            }
        }
        public static int TransactionExpense()
        {
            while (true)
            {
                Console.Write("Укажите сумму Расходов: \n");
                int userInput = Convert.ToInt32(Console.ReadLine());

                return userInput;
            }
        }
    }
}
