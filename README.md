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

 Reflektionsfrågor
 Hur hjälpte klasser och metoder dig att organisera programmet?
 Klasser och metoder hjälpte mig att organisera programmet genom att dela upp koden i tydliga delar som har olika ansvar. Till exempel hade jag en klass för transaktioner och en annan för budgethantering, vilket gjorde det lättare att hålla ordning på datan. Metoderna gjorde att jag kunde lägga funktioner som att lägga till, visa eller ta bort transaktioner på ett ställe istället för att skriva allt i Program.cs. Det gjorde koden mer strukturerad, lättare att förstå.

  Vilken del av projektet var mest utmanande?
  Det som var svårast i projektet var att arbeta med GitHub. Det tog tid att förstå hur man skulle committa, pusha och skapa Pull Requests. Allt som hade med GitHub-hantering att göra kändes nytt och lite förvirrande, troligen eftersom det var första gången jag arbetade med det. Jag hoppas att det blir enklare med tiden när jag får mer erfarenhet.
