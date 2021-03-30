using System;



namespace BlipsAndChitzStore
{
    public class BlipsAndChitz : ChitzItem
    { 
        Items kalaxian = new Items("Kalaxian Crystal",          15, 34 );
        Items smiggles = new Items("Strawberry Smiggles",       25, 11);
        Items juice = new Items("Penp Juice",                   10, 55);
        Items holes = new Items("Eyeholes",                     25, 17);
        Items sauce = new Items("Szechuan Sauce",                5, 101);
        Items simple = new Items("Simple Rick's",               10, 24);
        
        public void DisplayBlips()
        { 
            
            Console.WriteLine("▬▬ι═══════-            ╭∩╮(Ο_Ο)╭∩╮                -═══════ι▬▬");
            Console.WriteLine(" ");
            Console.WriteLine("Selection     -     Product     -       Price    -   Inventory ");
            Console.WriteLine(" ");
            Console.WriteLine($"    1              {kalaxian.Product}      {kalaxian.Blemflarcks}$            {kalaxian.Inventory}");
            Console.WriteLine($"    2              {smiggles.Product}   {smiggles.Blemflarcks}$            {smiggles.Inventory}");
            Console.WriteLine($"    3              {juice.Product}            {juice.Blemflarcks}$            {juice.Inventory}");
            Console.WriteLine($"    4              {holes.Product}              {holes.Blemflarcks}$            {holes.Inventory}");
            Console.WriteLine($"    5              {sauce.Product}         {sauce.Blemflarcks}$            {sauce.Inventory}");
            Console.WriteLine($"    6              {simple.Product}         {simple.Blemflarcks}$            {simple.Inventory}");
            Console.WriteLine(" ");
            Console.WriteLine("================♫♪.ılılıll|̲̅̅●̲̅̅|̲̅̅=̲̅̅|̲̅̅●̲̅̅|llılılı.♫♪===================");
            Console.WriteLine(" ");
            Console.WriteLine("Choose your addiction:");
            ItemSelection(Convert.ToChar(Console.ReadLine().ToUpper()));
            Console.WriteLine(" ");
        }

        private void ItemSelection(char selection)
        {
            
            var validSelection = false;
            while (!validSelection)
            {
                double blemflarcks;

                try
                {
                    switch (selection)
                    {
                        case '1':
                            blemflarcks = 15;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Kalaxian Crystal");
                            kalaxian.Inventory = kalaxian.Inventory - 1;
                            Console.WriteLine($"You have purchased a Kalaxian Crystal, your total blemflarck is ${blemflarcks}");
                            Console.WriteLine(" ");
                            break;
                        case '2':
                            blemflarcks = 25;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Strawberry Smiggles");
                            smiggles.Inventory = smiggles.Inventory - 1; 
                            Console.WriteLine($"You have purchased Strawberry Smiggles, your total blemflarck is ${blemflarcks}");
                            Console.WriteLine(" ");
                            break;
                        case '3':
                            blemflarcks = 10;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Penp Juice");
                            juice.Inventory = juice.Inventory - 1;
                            Console.WriteLine($"You have purchased Penp Juice, your total blemflarck is ${blemflarcks}");
                            Console.WriteLine(" ");
                            break;
                        case '4':
                            blemflarcks = 25;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Eyeholes");
                            holes.Inventory = holes.Inventory - 1;
                            Console.WriteLine($"You have purchased Eyeholes, your total blemflarck is ${blemflarcks}");
                            Console.WriteLine(" ");
                            break;
                        case '5':
                            blemflarcks = 5;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Szechuan Sauce");
                            sauce.Inventory = sauce.Inventory - 1;
                            Console.WriteLine($"You have purchased Szechuan Sauce, your total blemflarck is ${blemflarcks}");
                            Console.WriteLine(" ");
                            break;
                        case '6':
                            blemflarcks = 10;
                            validSelection = true;
                            Program.Wallet.GetDollaz(blemflarcks);
                            Program.Store.Products("Simple Rick's");
                            simple.Inventory = simple.Inventory - 1;
                            Console.WriteLine($"You have purchased a Simple Rick's, your total blemflarck is ${blemflarcks}");
                            break;
                        default:
                            Console.WriteLine("You can't choose this, try again idiot");
                            selection = Convert.ToChar(Console.ReadLine().ToUpper());
                            Console.WriteLine(" ");
                            break;
                    }
                    
                }
                catch
                {
                    Console.WriteLine("Error, you are to broke to buy this idiot!");
                    Console.WriteLine(" ");
                }
            }
            
        }
    }
}