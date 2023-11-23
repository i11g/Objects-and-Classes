namespace Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command=Console.ReadLine();
            while(command != "end")
            {
                string[] itemInfo = command.Split(' ').ToArray();

                int serialNumber = int.Parse(itemInfo[0]);
                string itemName = itemInfo[1];
                int itemQuantity = int.Parse(itemInfo[2]);
                double itemPrice = double.Parse(itemInfo[3]);

                double priceForABox = itemPrice * itemQuantity;


            }
        }
    }

    public class Item
    {
        public string Name { get; set; } 
        public decimal Price { get; set; }
    }

    public class Box
    {
        public int SerialNumber { get; set; }
        public string Item { get; set; }
        public int ItemQuantity { get; set; }
        public int PriceForABox { get; set; }
    }
}