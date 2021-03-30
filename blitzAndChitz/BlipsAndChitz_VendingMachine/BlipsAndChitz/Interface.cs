using System;



namespace BlipsAndChitzStore
{
    public class Menu
    {
        public void MainMenu()
        {
            
        var blipsAndChitz = new BlipsAndChitz();
        
            while (true)
        {
            Console.WriteLine("([̲̅$̲̅(̲̅5̲̅)̲̅$̲̅             (￣ω￣﻿)                [̲̅$̲̅(̲̅5̲̅)̲̅$̲̅) ");
            Console.WriteLine("|********  Welcome to Blips and Chitz!   *******| ");
            Console.WriteLine("|===============================================|");
            Console.WriteLine("|        Press 1 for Snacks Machine             |");
            Console.WriteLine("|        Press 2 for wallet                     |");
            Console.WriteLine("|        Press 3 to deposit Blemflarck          |");
            Console.WriteLine("|        Press 4 for your purchase receipt      |");
                Console.WriteLine(" ");
            var stringMenu = Console.ReadLine();
            var nextChoice = Convert.ToInt32(stringMenu);

            switch (nextChoice)
            {
                case 1:
                    blipsAndChitz.DisplayBlips();
                    break;
                case 2:
                    Program.Wallet.YourMoney();
                    break;
                case 3:
                    Program.Wallet.WalletSize();
                    break;
                case 4:
                    Program.Store.Display();
                    break;
                } 
            } 
        }
    }
}