using System;

namespace BlipsAndChitzStore
{
    class Program
    {
      public static Wallet Wallet = new Wallet();
      public static Store Store = new Store();
        
        static void Main(string[] args)
        {
            
            var menu = new Menu();
            menu.MainMenu();

        }
    }
}