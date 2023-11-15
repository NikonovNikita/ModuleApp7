namespace ModuleApp6
{
    class HomeDelivery : Delivery
    {
        private Courier courier;

        public HomeDelivery(string address)
        {
            Address = address;
            courier = new Courier();
            courier.OrderDelivery(Address);
        }
    }
}
