using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        }
                   
    }
}
