using System;
using System.Collections.Generic;


namespace BlipsAndChitzStore
{
    public class Store
    {
        private List<string> _storeList = new List<string>();

        public string Products(string value)
        {
            
            _storeList.Add(value);
            return value;
        }


        public void Display()
        {
           
            foreach (var value in _storeList)
            {
                Console.WriteLine("Item: " + value);
                Console.WriteLine(" ");
            }
        }
    }
}