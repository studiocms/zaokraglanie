using System;

namespace zaokraglanie
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Zaokrąglenie liczby 2,25 w górę");
            
            var liczba = Math.Round(2.25, 1, MidpointRounding.AwayFromZero);
            Console.WriteLine(liczba);


        }
    }
}
