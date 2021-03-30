using System; 
using System.Collections.Generic;


namespace BlipsAndChitzStore
{
    public class Wallet
    {
        public double Amount { get; set; }

        List<double> DepositList = new List<double>();

        public double YourMoney()
        {
            Amount = Amount;
            Console.WriteLine($"This is all you have:  ${Amount}, you broke son of a b*tch!");
            Console.WriteLine(" ");
            return Amount;
            

        }
        
        public double WalletSize()
        {   
            
            Console.WriteLine("This is all you got: {0}$", Amount);
            Console.WriteLine("Do you even have anything to deposit?");
            double DepositAmt = Convert.ToDouble(Console.ReadLine());
            
            DepositList.Add(DepositAmt);

            Amount = Amount + DepositAmt;
            Console.WriteLine($"This ain't much: {Amount}$, you broke son of a b*tch!");
            Console.WriteLine(" ");

            return DepositAmt;

        }

        public double GetDollaz(double value)
        {
            if (value > Amount)
                throw new Exception("You wish you were this rich b*tch!");
            Console.WriteLine(" ");
            Amount = Amount - value;
            return value;
            
        }
    }
}