using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCard
{
    class Program
    {
        static void Main(string[] args)
        {
            string cardNumber;
            Console.WriteLine("Enter a credit card number: ");
            cardNumber = Console.ReadLine();
            Console.WriteLine("You entered: " + cardNumber);
            if (cardNumber.Length != 16)
            {
                Console.WriteLine("Invalid card number");
                Console.ReadLine();
                return;
            }
            for (int i = 0; i < cardNumber.Length; i++)
            {
                if (!char.IsDigit(cardNumber[i]))
                {
                    Console.WriteLine("Invalid card number");
                    Console.ReadLine();
                    return;
                }
            }
            CardChecker(cardNumber);
        }

        private static void CardChecker(string cardNumber)
        {
            if (cardNumber[0] == '4')
            {
                Console.WriteLine("Visa card");
                Console.ReadLine();
            }
            else if (cardNumber[0] == '5')
            {
                Console.WriteLine("Mastercard");
                Console.ReadLine();
            }
            else if (cardNumber[0] == '2')
            {
                Console.WriteLine("Mastercard (digital)");
                Console.ReadLine();
            }
            else if (cardNumber[0] == '3')
            {
                Console.WriteLine("American Express");
                Console.ReadLine();
            }
            else if (cardNumber[0] == '6')
            {
                Console.WriteLine("Discover");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Unknown card");
                Console.ReadLine();
            }
        }
    }
}
