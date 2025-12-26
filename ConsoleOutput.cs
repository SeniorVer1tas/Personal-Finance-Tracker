using Operation;

namespace ConsoleHelper
{
	class ConsoleOutput
	{
		public static void WriteError()
		{
			ConsoleColor defaultColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nНедостаточно средств.\n");
			Console.ForegroundColor = defaultColor;
		}

		public static void WriteSuccess()
		{
			ConsoleColor defaultColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Green;
			Console.WriteLine("\nТранзакция успешно добавлена!\n");
			Console.ForegroundColor = defaultColor;
		}

		public static void NoTransaction()
		{
			ConsoleColor defaultColor = Console.ForegroundColor;
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("\nТранзакций нет.\n");
			Console.ForegroundColor = defaultColor;
		}

		//public static void WriteTypeTransaction(Transaction TypeOperation)
		//{
		//	if(TypeOperation == "Доходы")
		//	{
		//		ConsoleColor defaultColor = Console.ForegroundColor;
		//		Console.ForegroundColor = ConsoleColor.Green;
		//		Console.WriteLine("\nДоходы\n");
		//		Console.ForegroundColor = defaultColor;
		//	}
		//	else if (TypeOperation == "Расходы")
		//	{
		//		ConsoleColor defaultColor = Console.ForegroundColor;
		//		Console.ForegroundColor = ConsoleColor.Red;
		//		Console.WriteLine("\nРасходы\n");
		//		Console.ForegroundColor = defaultColor;
		//	}
			
		//}
	}
}