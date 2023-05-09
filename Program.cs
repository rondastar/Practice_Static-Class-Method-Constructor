namespace Practice_Static_Class_Method_Constructor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display business name
            Console.WriteLine($"{BusinessInfo._businessName}");
            // pre-populate transactions
            Transaction transaction1 = new Transaction("banana", .25);
            Transaction transaction2 = new Transaction("banana bread", 9.99);
            Transaction transaction3 = new Transaction("banoffee pie", 24.99);
            Transaction transaction4 = new Transaction("banana onesie", 49.99);
            Transaction transaction5 = new Transaction("fruit basket with banana hook", 17.99);
            // add all 5 transactions to Daily Transactions list
            DailyTransactions._transactions.Add(transaction1);
            DailyTransactions._transactions.Add(transaction2);
            DailyTransactions._transactions.Add(transaction3);
            DailyTransactions._transactions.Add(transaction4);
            DailyTransactions._transactions.Add(transaction5);
            // Display all transaction info
            DailyTransactions.DisplayAllInfo();
        }
    }
}