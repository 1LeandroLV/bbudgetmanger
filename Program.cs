namespace budgetmanger
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Budgetmangerrr mybudgetmanger = new Budgetmangerrr(); //skapa objekt från klassen 
            bool altenativ = true;
            while (altenativ)
            {
                Console.Clear(); // rensar konsolen varje gång menyn visas
                // meny som anvädaren kan välja
                Console.WriteLine("Välkommen till meny");
                Console.WriteLine("Välj ett altenativ nedan");
                Console.WriteLine("------------------------");
                Console.WriteLine("1: Lägg till transaktioner");
                Console.WriteLine("2: Visa alla transaktioner");
                Console.WriteLine("3: visa totala balans");
                Console.WriteLine("4: ta bort transaktion");
                Console.WriteLine("5: Avsluta program");
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
                        mybudgetmanger.DeleteTransaction();  
                        break;
                    case "5":
                         altenativ = false;
                        break;
                    default:
                     Console.WriteLine("Fel val, va vänlig och försök igen");
                     break;
                }
                if (altenativ)
                {
                    Console.WriteLine("Tryck på valfri tangent för att återgå till menyn...");
                    Console.ReadKey();
                }
            }
            
        }
    }
}
  