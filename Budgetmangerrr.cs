using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace budgetmanger
{
    internal class Budgetmangerrr
    {
       private  List<Transaction> Transactions = new List<Transaction>();
       
       public void AddTransaction() 
        {
            //fråga anvädaren om imformation och spara dem i variabler
            Console.WriteLine("Skriv in Beskrivningen");
            string description = Console.ReadLine();
            Console.WriteLine("Ange belopp");
            decimal amount = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Ange kategori");
            string category = Console.ReadLine();
            Console.WriteLine("Ange datum");
            string date = Console.ReadLine();

            //Skapa ett nytt Transaction objekt med namnet T och fyller objektet med information
            Transaction T = new Transaction();
            T.Description = description;
            T.Amount = amount;
            T.Category = category;
            T.Date = date;
            Transactions.Add(T); // sparar objktet i listan 
    
            Console.WriteLine("Transaktionen är sparad"); // Bekräftar för användaren att allt är sparad
        }
        public void ShowAll() 
        {
          if (Transactions.Count == 0)  // kolla Om listan är tom 
           {
             Console.WriteLine("Inga transaktioner finns ännu!"); // kommer detta att skrivas ut
             return;
           }
          foreach (Transaction transaction in Transactions) // loopa igenom alla transaktioner
           {
            transaction.ShowInfo(); // visa information om varje transaktion
           }
        }
        public void CalculateBalance()  
        {
            decimal balance = 0;
            // Loopa igenom alla transaktioner och addera beloppet
            foreach (Transaction transaction in Transactions) 
            {
                balance += transaction.Amount;
            }
            // Skriv ut balansen efter loopen
            Console.WriteLine($"Din totala balans är {balance}");
        }
        public void DeleteTrasaction()
        {
            // Kolla om listan är tom
            if (Transactions.Count == 0)
            {
                Console.WriteLine("Inga transaktioner finns ännu!");
                return; // Avslutar metoden om listan är tom
            }

            //Visa alla transaktioner med nummer
            for (int i = 0; i < Transactions.Count; i++)
            {
                Console.WriteLine($"{i + 1}: {Transactions[i].Description} - {Transactions[i].Amount} kr - {Transactions[i].Category} - {Transactions[i].Date}");
            }
            //Be användaren ange vilket nummer som ska tas bort
            Console.WriteLine("Ange numret på transaktionen du vill ta bort:");
            int index = Convert.ToInt32(Console.ReadLine()) - 1; 
            //Kontrollera att index är giltigt
            if (index < 0 || index >= Transactions.Count)
            {
                Console.WriteLine("Ogiltigt nummer!");
                return;
            }
            //Ta bort transaktionen
            Transactions.RemoveAt(index);
            Console.WriteLine("Transaktionen är borttagen");
        }

    
    }
}
