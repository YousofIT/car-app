using System;
using System.Globalization;

namespace ücl
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bilmærke?");
            string brand = Console.ReadLine();
            Console.WriteLine("Bilmodel?");
            string model = Console.ReadLine();
            Console.WriteLine("Årgang?");
            int year = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("gearkasse?");
            char transM = Console.ReadLine()[0];

            Console.WriteLine("brændstoftype?");
            string fueltype = Console.ReadLine().ToLower();

            Console.WriteLine("Antal KM pr. liter?");
            double Forbrug = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Hvor mange kilometer har bilen kørt?");
            int Mileage = Convert.ToInt32(Console.ReadLine());

            // Spørg brugeren om køreturens distance
            Console.WriteLine("Hvor mange kilometer er din tur?");
            double distance = Convert.ToDouble(Console.ReadLine());

            // Sæt brændstofprisen
            double fuelprice = (fueltype == "benzin") ? 13.49 : 12.29;

            // Beregn brændstofforbruget og køreturens pris
            double FuelUsage = distance / Forbrug;
            double TripCost = FuelUsage * fuelprice;

            // Opdater kilometerstand
            Mileage += (int)Math.Round(distance);

            // Udskriv brændstofomkostninger med string.Format()
            string FuelCostMessage = string.Format("Brændstofudgifterne for {0} km er {1:F2} DKK.", distance, TripCost);
            Console.WriteLine(FuelCostMessage);

            // Udskriv en tabel med bilens oplysningerved hjælp ad PadRight() og PadLeft()
            Console.WriteLine("\nBilmærke | Model | Kilometertal");
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine(brand.PadRight(10) + "| " + model.PadRight(10) + "| " + Mileage.ToString("N0").PadLeft(10) + "Km");

            Console.ReadLine(); /* Wait for user input to exit program */




            


             }
        static bool IsPalindrome(int km)
{
    string kmString = km.ToString();
    char[] kmArray = kmString.ToCharArray();
    Array.Reverse(kmArray);
    string reversedKm = new string(kmArray);

    if (kmString == reversedKm)
    {
        return true;
    }
    else
    {
        return false;
    }
}

          
    }
 


}
    
