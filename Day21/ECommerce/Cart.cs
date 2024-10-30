namespace ECommerce
{
    public class Cart
    {
        var cart = new List<CartItems>();

        public void Add()
        {
            System.Console.WriteLine("Add to Cart");

            System.Console.Write("Item Name : ");
            string name = Console.ReadLine();
            cart.Add(name);

            System.Console.Write("Quantity : ");
            int quantity = int.Parse(Console.ReadLine());
            cart.Add(quantity);

            System.Console.Write("Price : ");
            decimal price = decimal.Parse(Console.ReadLine()); 
            cart.Add(price);

            System.Console.WriteLine("Added to Cart!");
        }

        public void Update()
        {
            System.Console.Write("Item to Update : ");
            string newItem = Console.ReadLine();
            cart.Name = newName;

            System.Console.Write("Updated Quantity : ");
            int newQuantity = int.Parse(Console.ReadLine());
            cart.Quantity = newQuantity;

            
            Console.WriteLine($"Item : {newItem}    Quantity : {quantity}   updated");
        }

        public void Remove()
        {
            System.Console.Write("Item to Remove from Cart : ");
            string removeItem = Console.ReadLine();
            cart.RemoveAll(removeItem);

            System.Console.WriteLine($"{removeName} removed from cart");
        }

        public void Total()
        {
            return cart;
        }

    }
}