namespace ModuleApp6
{
    class HomeDelivery : Delivery
    {
        internal Courier courier;

        public HomeDelivery(string address)
        {
            Address = address;
            courier = new Courier();
            courier.OrderDelivery(Address);
        }
    }
}
