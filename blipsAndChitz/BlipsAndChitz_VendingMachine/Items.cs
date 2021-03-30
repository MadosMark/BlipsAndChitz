
namespace BlipsAndChitzStore
{
    public class ChitzItem
    {
        public class Items
        {
            public string Product { get; set; }
            public double Blemflarcks { get; set; }
            public int Inventory { get; set; }

            public Items(string product, double blemflarcks, int inventory)
            {
                Product = product;
                Blemflarcks = blemflarcks;
                Inventory = inventory;
            }
        }
    }
}
