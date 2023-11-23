namespace ModuleApp6
{
    class Order<TDelivery, TProducts> where TDelivery : Delivery where TProducts : StoreProducts
    {
        public TDelivery ChosenDelivery;
        public TProducts ChosenProducts;
        public Order(TDelivery deliveryParam, TProducts productsParam)
        {
            ChosenDelivery = deliveryParam;
            ChosenProducts = productsParam;
        }
        internal void PlacingAnOrder()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Вы успешно оформили заказ! Ваши товары на сумму: {0} р ", ChosenProducts.TotalAmount);
            foreach(var temp in ChosenProducts.basket)
            {
                Console.Write(temp + " ");
                Console.WriteLine();
            }
            if(ChosenDelivery is HomeDelivery)
            {
                Console.WriteLine("Вами выбрана доставка на дом. Курьер доставит заказ по адресу: {0}", ChosenDelivery.Address);
            }
            else if (ChosenDelivery is ShopDelivery)
            {
                Console.WriteLine("Вами выбрана доставка в магазин. Самовывоз по адресу: {0}", ChosenDelivery.Address);
            }
        }
    }
}
