using static System.Console; // För att kunna ta bort Console.
using System;

namespace Moment2
{
    class Program
    {
        static void Main(string[] args)
        {

            // ÅR
            Write("År(tex 2020):");                     // Fyll i år
            string yearInput = ReadLine();              // Spara input i string
            int year;                                   // Skapa variabel year
            if (!int.TryParse(yearInput, out year))     // Kolla om det bara är nummer i input
            {
                WriteLine("Fel inmatning. Försök med endast nummer.");  // Annars skriv ut fel inmatning och avsluta
                Environment.Exit(0);
            }
            if (yearInput.Length != 4)                  // Kolla om längden på input är korrekt
            {
                WriteLine("Fel format. Försök igen.");  // Annars skriv ut fel format och avsluta
                Environment.Exit(0);
            }

            
            // MÅNAD
            Write("Månad(1-12):");                      // Fyll i månad i nummer format
            string monthInput = ReadLine();             // Spara input i string
            int m;                                      // Skapa variabel m
            if (!int.TryParse(monthInput, out m))       // Kolla om det bara är nummer i input
            {
                WriteLine("Fel inmatning. Försök med endast nummer.");  // Annars skriv ut fel inmatning och avsluta
                Environment.Exit(0);
            }
            if (m < 1 || m > 12)                        // Kolla om längden på input är korrekt
            {
                WriteLine("Fel format för månad. Försök igen.");        // Annars skriv ut fel inmatning och avsluta
                Environment.Exit(0);
            }

            
            // DAG
            Write("Dag(1-31):");                        // Fyll i dag i nummer format
            string dayInput = ReadLine();               // Spara input i string
            int d;                                      // Skapa variabel d
            if (!int.TryParse(dayInput, out d))         // Kolla om det bara är nummer i input
            {
                WriteLine("Fel inmatning. Försök med endast nummer.");  // Annars skriv ut fel inmatning och avsluta
                Environment.Exit(0);
            }
            if (d < 1 || d > 31)                        // Kolla om längden på input är korrekt
            {
                WriteLine("Fel format för dag. Försök igen.");  // Annars skriv ut fel inmatning och avsluta
                Environment.Exit(0);
            }


            if(m < 3)                   // Om månad är mindre än 3
            {          
            m = m + 12;                 // lägg till 12 på månad
            year = year - 1;            // ta bort 1 från år
            }

            int c = (year / 100);       // Plocka ut århundrade genom år/100 och runda av neråt
            int y = year % 100;         // Plocka ut året genom år modulus 100
            
            int day = (d + ((13*(m-1))/5) + y + (y/4) + (c/4) + (5*c) ) % 7;    // Räkna ut veckodag med zellers algoritm
            int weekDay = ((day + 3) % 7) + 1;                                  // Gör om till ISO standard
        
            WriteLine($"Du är född på en:");
            
            // switch-sats för att skriva ut rätt dag beroende på resultat
            switch(weekDay) 
            {
                case 1:
                WriteLine("Måndag");
                break;
                case 2:
                WriteLine("Tisdag");
                break;
                case 3: 
                WriteLine("Onsdag");
                break;
                case 4: 
                WriteLine("Torsdag");
                break;
                case 5: 
                WriteLine("Fredag");
                break;
                case 6: 
                WriteLine("Lördag");
                break;
                case 7: 
                WriteLine("Söndag");
                break;
            }

        }
    }
}
