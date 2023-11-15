namespace ModuleApp6
{
    class StoreProducts // Даем более осмысленные названия переменным/методам/классам 
    {
        readonly string TV = "Телевизор";
        readonly string PC = "ПК";
        readonly string Phone = "Телефон";

        private List<string> basket;
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
                string userInput = Console.ReadLine(); // Даем более осмысленные названия переменным/методам/классам
                switch (userInput)
                {
                    case "Телевизор":
                    case "Телефон":
                    case "ПК":
                        basket.Add(userInput);
                        Console.WriteLine($"Вы добавили в корзину {userInput}"); // Можно сократить код использовав интерполяцию строк 
                        break;
                    case "К":
                        ShowBasket();
                        break;
                    case "В":
                        ShowBasket();
                        return;
                    default:
                        Console.WriteLine("Неизвестный товар!");
                        break;
                }
            } while (true);
        }
        internal void ShowBasket()
        {
            Console.WriteLine("Ваша корзина товаров:");
            foreach (var temp in basket)
            {
                Console.WriteLine(temp);
            }
        }
        internal void ShowProducts()
        {
            Console.WriteLine("Ассортимент товаров:");
            Console.WriteLine(TV);
            Console.WriteLine(PC);
            Console.WriteLine(Phone);
        }
    }
}
