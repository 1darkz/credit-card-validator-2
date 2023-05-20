using System;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string creditCardNumber;
            Console.WriteLine("Enter a credit card number: ");
            creditCardNumber = Console.ReadLine();
            Console.WriteLine($"You entered: {creditCardNumber}");

            if (creditCardNumber.Length != 16)
            {
                DisplayInvalidCardNumber();
                return; 
            }

            for (int i = 0; i < creditCardNumber.Length; i++)
            {
                if (!char.IsDigit(creditCardNumber[i]))
                {
                    DisplayInvalidCardNumber();
                    return;
                }
            }

            CardChecker(creditCardNumber);
        }

        private static void DisplayInvalidCardNumber()
        {
            Console.WriteLine("Invalid card number");
            Console.ReadLine();
        }

        private static void CardChecker(string creditCardNumber)
        {
            char firstDigit = creditCardNumber[0];

            if (firstDigit == '4')
            {
                Console.WriteLine("Visa card");
            }
            else if (firstDigit == '5')
            {
                Console.WriteLine("Mastercard");
            }
            else if (firstDigit == '2')
            {
                Console.WriteLine("Mastercard (digital)");
            }
            else if (firstDigit == '3')
            {
                Console.WriteLine("American Express");
            }
            else if (firstDigit == '6')
            {
                Console.WriteLine("Discover");
            }
            else
            {
                Console.WriteLine("Unknown card");
            }

            Console.ReadLine();
        }
    }
}