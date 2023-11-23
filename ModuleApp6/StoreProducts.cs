namespace ModuleApp6
{
    class StoreProducts 
    {
        readonly string TV = "Телевизор";
        readonly string PC = "ПК";
        readonly string Phone = "Телефон";
        readonly int PriceTV = 80000;
        readonly int PricePC = 100000;
        readonly int PricePhone = 25000;
        internal int totalAmount;
        internal int TotalAmount
        {
            get { return totalAmount; }
            set
            {
                if(totalAmount == 0)
                {
                    totalAmount = value;
                }
                else
                {
                    totalAmount += value;
                }
            }
        }

        internal List<string> basket;
        internal StoreProducts()
        {
            basket = new List<string>();
        }
        internal void AddProducts()
        {
            ShowProducts();
            Console.WriteLine("Напишите желаемый товар в виде Телефон / ПК / Телевизор" +
                "\nЧтобы посмотреть корзину товаров введите К\nЧтобы выйти и завершить выбор нажмите В");
            do
            {
                string userInput = Console.ReadLine();
                switch (userInput)
                {
                    case "Телевизор":
                    case "Телефон":
                    case "ПК":
                        basket.Add(userInput);
                        Console.WriteLine($"Вы добавили в корзину {userInput}"); 
                        break;
                    case "К":
                        ShowBasket();
                        break;
                    case "В":
                        if (basket.Count == 0)
                        {
                            Console.WriteLine("Ваша корзина пуста! Чтобы оформить заказ вы должны положить товары в корзину!");
                            break;
                        }
                        else
                        {
                            ShowBasket();
                            return;
                        }
                    default:
                        Console.WriteLine("Чтобы посмотреть корзину товаров введите К\nЧтобы завершить выбор нажмите В");
                        break;
                }
            } while (true);
        }
        internal void ShowBasket()
        {
            if (basket.Count == 0)
            {
                Console.WriteLine("Ваша корзина пуста!");
                return;
            }
            Console.WriteLine("Ваша корзина товаров:");
            foreach (var product in basket)
            {
                Console.WriteLine(product);
                switch (product)
                {
                    case "ПК":
                        TotalAmount = PricePC;
                        break;
                    case "Телефон":
                        TotalAmount = PricePhone;
                        break;
                    case "Телевизор":
                        TotalAmount = PriceTV;
                        break;
                }
            }
        }
        internal void ShowProducts()
        {
            Console.WriteLine("Ассортимент товаров:");
            Console.WriteLine("{0} - {1} р", TV, PriceTV);
            Console.WriteLine("{0} - {1} р", PC, PricePC);
            Console.WriteLine("{0} - {1} р", Phone, PricePhone);
        }
    }
}
