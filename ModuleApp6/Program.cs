using ModuleApp6;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Добро пожаловать в магазин!");
        StoreProducts myProducts = new();
        myProducts.AddProducts();
        Order<Delivery, StoreProducts> order = new(DeliveryService.ChooseDelivery(), myProducts);
        order.PlacingAnOrder();
    }
}