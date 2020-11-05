using static System.Console;
using System;

namespace Moment2
{
    class Program
    {
        static void Main(string[] args)
        {
            Write("År(tex 2020):");                  // Fyll i år
            double year = double.Parse(ReadLine()); // Gör om input till double för nedre beräkningar

            Write("Månad(1-12):");                  // Fyll i månad i nummer format
            double m = double.Parse(ReadLine());    // Gör om till integer

            Write("Dag(1-31):");                    // Fyll i dag i nummer format
            double d = double.Parse(ReadLine());    // Gör om till integer

            if(m < 3)           // Om månad är mindre än 3
            {          
            m = m + 12;         // lägg till 12 på månad
            year = year - 1;    // ta bort 1 från år
            }

            double c = Math.Floor(year / 100);     // Plocka ut århundrade genom år/100 och runda av neråt
            double y = year % 100;                 // Plocka ut året genom år modulus 100
            

            WriteLine($"({year})Du är född: {c}{y} - {m} - {d}");  // för att se uträkningen
            // d m year c y
            

            /*
            
            double dayOfWeekCentury = Math.Floor((c/4) + (5*c)) % 7; // Seklets första dag
            double dayOfWeekYear = (dayOfWeekCentury + c + Math.Floor(c/4) ) % 7;
            double dayOfWeekMonth = dayOfWeekYear + Math.Floor(((m + 1 ) * 26 ) / 10);
            double dayOfWeek = dayOfWeekMonth % 7;
            WriteLine($"c = {dayOfWeekCentury} y = {dayOfWeekYear} m = {dayOfWeekMonth} w = {dayOfWeek}");
            
            */
            double veckodag = (d + Math.Floor((13*(m-1))/5) + y + Math.Floor(y/4) + Math.Floor(c/4) + (5*c) ) % 7;
            double dag = ((veckodag + 5) % 7) + 1;
        
            WriteLine($"veckodag innan ändring: {veckodag} och efter: {dag}");
            

            

            // 0 = söndag, 1 = måndag, 2 = tisdag, 3 = onsdag, 4 = torsdag, 5 = fredag, 6 = lördag
            // 3 = söndag, 4 = måndag, 5 = tisdag, 6 = onsdag, 7 = torsdag, 1 = fredag, 2 = lördag
            // (bara en uträkning) 4 = söndag, 5 = måndag, 6 = tisdag, 0 = onsdag, 7 = torsdag, 2 = fredag, 3 = lördag


        }
    }
}
