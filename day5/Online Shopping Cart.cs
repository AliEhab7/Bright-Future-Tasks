using System.Net.Cache;
using System.Numerics;

namespace DotNet_task1
{

     class Product
    {
        private string name;
        private int price , quantity;
        public Product(string name, int price, int quantity)
        {
            this.name = name;
            this.price = price;
            this.quantity = quantity;
        }
        public string get_name() { return name; }
        public int get_price() { return price; }
        public int get_quantity() { return quantity; }

    }
    class DigitalProduct : Product
    {
        public DigitalProduct(string name, int price, int quantity) : base(name, price, quantity)
        {
        }
    }
    class PhysicalProduct : Product
    {
        public PhysicalProduct(string name, int price, int quantity) : base(name, price, quantity)
        {
        }
    }
    class ShoppingCart
    {
        List<Product> current_cart;
        public void Add_Product(string name, int price, int quantity)
        {
            current_cart.Add(new Product(name,price,quantity));
        }
        public void remove_Product(string name)
        {
            foreach(var product in current_cart)
            {
                if(product.get_name() == name)
                {
                    current_cart.Remove(product);
                    break;
                }
            }
        }
        public int calculate_total_price()
        {
            int total_price = 0 , total_quantity = 0;
            foreach(var product in current_cart)
            {
                total_price += product.get_price() * product.get_quantity();
                total_quantity += product.get_quantity();
            }
            if (total_quantity > 10) { total_price = (int)(total_price * 0.95); }
            return total_price;
        }
    }



        internal class Program
    {
    
        static void Main(string[] args)
        {
         

        }
    }
}
