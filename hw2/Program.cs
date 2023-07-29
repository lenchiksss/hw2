using System.Text;

namespace hw2
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            while (true)
            {
                Console.WriteLine("Меню:");
                Console.WriteLine("а. Завдання 1 (ООП)");
                Console.WriteLine("б. Завдання 2 (ООП)");
                Console.WriteLine("в. Завдання 3 (Структури)");
                Console.WriteLine("г. Вийти");
                Console.Write("Введіть Ваш вибір: ");
                string choice = Console.ReadLine();
                Console.WriteLine();

                switch (choice.ToLower())
                {
                    case "а":
                        int dollars, cents;
                        Money money = new Money(0, 0);
                        Product product = new Product(0, 0);

                        while (true)
                        {
                            Console.WriteLine("Оберіть необхідну опцію:");
                            Console.WriteLine("а. Введення суми грошей");
                            Console.WriteLine("б. Виведення суми");
                            Console.WriteLine("в. Введення ціни продукту");
                            Console.WriteLine("г. Виведення ціни продукту");
                            Console.WriteLine("д. Зміна ціни продукту");
                            Console.WriteLine("е. Вийти назад у меню");
                            Console.Write("Ваш вибір: ");
                            string choice1 = Console.ReadLine();
                            Console.WriteLine();

                            switch (choice1.ToLower())
                            {
                                case "а":
                                    Console.Write("Введіть цілу частину (долари): ");
                                    while (!int.TryParse(Console.ReadLine(), out dollars))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть цілу частину (долари): ");
                                    }
                                    Console.Write("Введіть копійки (центи): ");
                                    while (!int.TryParse(Console.ReadLine(), out cents))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть копійки (центи): ");
                                    }
                                    money.SetMoney(dollars, cents);
                                    break;
                                case "б":
                                    money.Display();
                                    break;
                                case "в":
                                    Console.Write("Введіть ціну продукту (долари): ");
                                    while (!int.TryParse(Console.ReadLine(), out dollars))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть ціну продукту (долари): ");
                                    }
                                    Console.Write("Введіть копійки (центи): ");
                                    while (!int.TryParse(Console.ReadLine(), out cents))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть копійки (центи): ");
                                    }
                                    product.SetMoney(dollars, cents);
                                    break;
                                case "г":
                                    product.Display();
                                    break;
                                case "д":
                                    Console.Write("Введіть нову ціну продукту (долари): ");
                                    while (!int.TryParse(Console.ReadLine(), out dollars))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть нову ціну продукту (долари): ");
                                    }
                                    Console.Write("Введіть копійки (центи): ");
                                    while (!int.TryParse(Console.ReadLine(), out cents))
                                    {
                                        Console.WriteLine("Щось не так. Спробуйте ще раз.");
                                        Console.Write("Введіть копійки (центи): ");
                                    }
                                    product.ChangePrice(dollars, cents);
                                    break;
                                case "е":
                                    Console.WriteLine("Повертаємося до головного меню...");
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                                    Console.WriteLine();
                                    break;
                            }
                            if (choice1.ToLower() == "е")
                            {
                                break;
                            }
                            Console.WriteLine();
                        }
                        break;
                    case "б":
                        while (true)
                        {
                            Console.WriteLine("Оберіть музичний інструмент, про який хочете дізнатися:");
                            Console.WriteLine("а. Скрипка");
                            Console.WriteLine("б. Тромбон");
                            Console.WriteLine("в. Укулеле");
                            Console.WriteLine("г. Віолонченль");
                            Console.WriteLine("д. Вийти назад у меню");
                            string choice2 = Console.ReadLine();
                            Console.WriteLine();

                            switch (choice2.ToLower())
                            {
                                case "а":
                                    Violin violin = new Violin();
                                    violin.Show();
                                    violin.Description();
                                    violin.History();
                                    violin.Sound();
                                    Console.WriteLine();
                                    break;
                                case "б":
                                    Trombone trombone = new Trombone();
                                    trombone.Show();
                                    trombone.Description();
                                    trombone.History();
                                    trombone.Sound();
                                    Console.WriteLine();
                                    break;
                                case "в":
                                    Ukulele ukulele = new Ukulele();
                                    ukulele.Show();
                                    ukulele.Description();
                                    ukulele.History();
                                    ukulele.Sound();
                                    Console.WriteLine();
                                    break;
                                case "г":
                                    Cello cello = new Cello();
                                    cello.Show();
                                    cello.Description();
                                    cello.History();
                                    cello.Sound();
                                    Console.WriteLine();
                                    break;
                                case "д":
                                    Console.WriteLine("Повертаємося до головного меню...");
                                    Console.WriteLine();
                                    break;
                                default:
                                    Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                                    Console.WriteLine();
                                    break;
                            }
                            if (choice2.ToLower() == "д")
                            {
                                break;
                            }
                        }
                        break;
  
                    case "в":
                        int number;

                        Console.Write("Введіть число: ");
                        while (!int.TryParse(Console.ReadLine(), out number))
                        {
                            Console.WriteLine("Щось не так. Спробуйте ще раз.");
                            Console.Write("Введіть число: ");
                        }

                        DecimalNumber decimalNumber = new DecimalNumber(number);

                        Console.WriteLine($"Число: {number}");
                        Console.WriteLine($"Двійкова система: {decimalNumber.ToBinary()}");
                        Console.WriteLine($"Вісімкова система: {decimalNumber.ToOctal()}");
                        Console.WriteLine($"Шістнадцяткова система: {decimalNumber.ToHex().ToUpper()}");
                        Console.WriteLine();
                        break;
                    case "г":
                        Console.WriteLine("Хай щастить!");
                        return;
                    default:
                        Console.WriteLine("Неправильний вибір, спробуйте ще раз.");
                        break;
                }
            }

        }
    }
}