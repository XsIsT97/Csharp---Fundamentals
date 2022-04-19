using System;

namespace Problem_1___Computer_Store
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
            decimal totalPriceNoTaxes = 0;

            while (command != "regular" && command != "special")
            {
                decimal price = decimal.Parse(command);

                if (price < 0)
                {
                    Console.WriteLine("Invalid price!");
                    command = Console.ReadLine();
                    continue;
                }

                totalPriceNoTaxes += price;

                command = Console.ReadLine();
            }

            if (totalPriceNoTaxes == 0)
            {
                Console.WriteLine("Invalid order!");
                return;
            }

            decimal taxes = totalPriceNoTaxes * 0.2m;

//            Congratulations you've just bought a new computer!
//Price without taxes: { total price without taxes}$
//Taxes: { total amount of taxes}$


            if (command == "special")
            {
                decimal totalWithTaxes = totalPriceNoTaxes + taxes;
                decimal totalPriceWithDiscount = totalWithTaxes * 0.9m;

                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceNoTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {totalPriceWithDiscount:F2}$");
            }
            else
            {
                Console.WriteLine("Congratulations you've just bought a new computer!");
                Console.WriteLine($"Price without taxes: {totalPriceNoTaxes:F2}$");
                Console.WriteLine($"Taxes: {taxes:F2}$");
                Console.WriteLine("-----------");
                Console.WriteLine($"Total price: {(totalPriceNoTaxes + taxes):F2}$");
            }
        }
    }
}
