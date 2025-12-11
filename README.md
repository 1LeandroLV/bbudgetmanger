Budget Manager – Console App

Detta är ett konsolprogram skrivet i C# som låter användaren hantera sina transaktioner.  
Man kan lägga till, visa, räkna ut balans och ta bort transaktioner.

 Funktioner

 Lägg till transaktion  
 Visa alla transaktioner  
 Beräkna total balans  
 Ta bort en specifik transaktion  
 Menysystem som guidar användaren  

 Programstruktur

`Transaction`
- Description
- Amount
- Category
- Date
- ShowInfo()

Budgetmangerrr
- AddTransaction()
- ShowAll()
- CalculateBalance()
- DeleteTransaction()

   Program`
- Main-meny och programloop

  Teknologier
- C#
- .NET
- Git & GitHub

 Branch-struktur
I projektet används flera branches:
- `main` – skyddad branch
- `dev` – utvecklingsbranch
- Flera feature-branches för olika delar av projektet

Pull requests används för att slå samman kod från feature-branches → dev → main.

## 📦 Hur man kör programmet

1. Klona projektet  
   ```bash
   git clone <repo-länk>
