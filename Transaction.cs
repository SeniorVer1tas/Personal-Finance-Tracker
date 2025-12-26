using System.Runtime.CompilerServices;
using ConsoleHelper;

namespace Operation
{
    class Transaction
    {
        public string TypeOperation { get; set; }
        public string Description { get ;set; }
        public int Amount { get; set; }
        
        public Transaction(string _type, string description, int amount)
        {
            TypeOperation = _type;
            Description = description;
            Amount = amount;
        }

        public override string ToString()
        {
            return $"{TypeOperation} | {Description} | {Amount}";
        }
    }
}