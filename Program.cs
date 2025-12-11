namespace budgetmanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Budgetmangerrr mybudgetmanger = new Budgetmangerrr();
            bool altenativ = true;
            while (altenativ)
            {
              string menyval = Console.ReadLine();
                switch (menyval)
                {
                    case "1":
                        mybudgetmanger.AddTransaction();
                        break;
                    case "2":
                        mybudgetmanger.ShowAll();
                        break;
                    case "3":
                        mybudgetmanger.CalculateBalance();
                        break;
                    case "4":
                        mybudgetmanger.DeleteTrasaction();
                        break;
                    case "5":
                         altenativ = false;
                        break;
                    default:
                     Console.WriteLine("Fel val, va vänlig och försök igen");
                     break;
                }
            }
            Console.WriteLine("Välkommen till Personal budget meny");
            Console.WriteLine("Välj ett Alnativ nedan!");
            Console.WriteLine("------------------------");
            Console.WriteLine("1: Lägg till transaktion");
            Console.WriteLine("2: Visa alla transaktioner");
            Console.WriteLine("3: Visa total balans");
            Console.WriteLine("4: Ta bort Transaktion");
            Console.WriteLine("5: Avsluta programmet");
        }
    }
}
