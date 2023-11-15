namespace ModuleApp6
{
    class DeliveryService
    {
        public static void ChooseDelivery()
        {
            ShopDelivery shopDelivery;
            HomeDelivery homeDelivery;

            Console.WriteLine("Выберите тип доставки:\n1 - Доставка в магазин" +
                "\n2 - Доставка на дом курьером");

            do
            {
                string deliveryType = Console.ReadLine(); // Даем более осмысленные названия переменным/методам/классам
                switch (deliveryType)
                {
                    case "1":
                        shopDelivery = new ShopDelivery();
                        Console.WriteLine("Вы выбрали доставку в магазин! Самовывоз из магазина по адресу {0}", shopDelivery.Address);
                        return;
                    case "2":
                        Console.Write("Введите адрес доставки: ");
                        string address = Console.ReadLine();
                        homeDelivery = new HomeDelivery(address);
                        return;
                    default:
                        Console.WriteLine("Некорректный ввод! Формат 1 или 2!");
                        break;
                }
            } while (true);
        }
    }
}
