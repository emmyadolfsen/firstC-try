using static System.Console; // För att kunna ta bort Console.
using System;

namespace Moment2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool check = true;  // Bool som är satt till true för att start while-loop
            
            while(check)        // Start av while loop så länge check = true
            {
            Write("Skriv in ditt födelsedatum(yyyy-MM-dd) och tryck ENTER:");  // Fyll i datum
            string input = ReadLine();                      // Spara input i string
            DateTime birthday;                              // datum variabel som sparar input i datetime format
            if(!DateTime.TryParse(input, out birthday))     // Om input inte går att köra igenom parse
            {
                WriteLine("Fel inmatning. Försök igen.");   // skriv ut fel inmatning
                check = true;                               // Start om loopen
            }
            else                                            // Om string input gick att göra om till datetime
            {
                int d = birthday.Day;                       // Plocka ut dag, månad och år
                int m = birthday.Month;
                int year = birthday.Year;

                if(m < 3)                   // Om månad är mindre än 3
                {          
                m = m + 12;                 // lägg till 12 på månad
                year = year - 1;            // ta bort 1 från år
                }

                int c = (year / 100);       // Plocka ut århundrade genom år/100 och runda av neråt
                int y = year % 100;         // Plocka ut året genom år modulus 100
                
                int day = (d + ((13*(m-1))/5) + y + (y/4) + (c/4) + (5*c) ) % 7;    // Räkna ut veckodag med zellers algoritm
                int weekDay = ((day + 3) % 7) + 1;                                  // Gör om till ISO standard
            
                WriteLine($"Du är född på en:");    // skriv ut
                
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

                check = false;  // Avsluta loopen
            }
            }

        }

    }
}
