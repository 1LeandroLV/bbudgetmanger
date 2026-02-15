using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace budgetmanger
{
    internal class Transaction
    {
        //// Egenskaper för en transaktion
        public string Description {  get; set; } //Beskrivning 
        public decimal Amount { get; set; } //belopp
        public string  Category { get; set; } //kategori
        public string  Date { get; set; } //datum

        public void ShowInfo()      //Showinfo metod som visa själva meny
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Beskrivningen {Description}");
            Console.WriteLine($"belopp {Amount}");
            Console.WriteLine($"Kategori {Category}");
            Console.WriteLine($"Datum {Date}");
            Console.WriteLine("---------------------------");
            
        }
    }
}
