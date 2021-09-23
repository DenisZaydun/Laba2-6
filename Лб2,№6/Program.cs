using System;

namespace Лб2__6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Console.InputEncoding = System.Text.Encoding.Unicode;

            int ans = 0;
            int secondAns = 0;

            do
            {
                Console.WriteLine("Оберіть:");
                Console.WriteLine("1. Конвертувати з гривні у валюту(USD, EUR, RUB).");
                Console.WriteLine("2. Конвертувати з валюти(USD, EUR, RUB) в гривню.");
                Console.Write("Ваш вибір: ");
                ans = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (ans == 1 || ans == 2)
                {
                    break;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Введіть 1 або 2");
                    Console.ResetColor();
                }
            } while (ans != 1 || ans != 2);


            if (ans == 1)
            {
                Console.WriteLine("Ви обрали конвертувати з гривні у валюту(USD, EUR, RUB)");
                Console.Write("Введіть суму в гривнях:");
                double uah = double.Parse(Console.ReadLine());

                Converter converter = new Converter(uah);

                Console.WriteLine();
                converter.InfoUahToCurr();
            }
            else if (ans == 2)
            {
                do
                {
                    Console.WriteLine("Ви обрали конвертувати з валюти в гривню");
                    Console.WriteLine("Оберіть:");
                    Console.WriteLine("1. Задати значення валют(USD, EUR, RUB) одночасно");
                    Console.WriteLine("2. Задати значення валют(USD, EUR, RUB) окремо");
                    Console.Write("Ваш вибір: ");
                    secondAns = int.Parse(Console.ReadLine());
                    Console.WriteLine();

                    if (secondAns == 1 || secondAns == 2)
                    {
                        break;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Введіть 1 або 2");
                        Console.ResetColor();
                    }
                } while (secondAns != 1 || secondAns != 2);



                if (secondAns == 1)
                {
                    Console.Write("Введіть суму: ");
                    double val = double.Parse(Console.ReadLine());

                    Converter converter = new Converter(val, val, val);

                    Console.WriteLine();
                    converter.InfoCurrToUah();
                }
                else if (secondAns == 2)
                {
                    Console.Write("Введіть суму в доларах: ");
                    double usd = double.Parse(Console.ReadLine());

                    Console.Write("Введіть суму в євро: ");
                    double eur = double.Parse(Console.ReadLine());

                    Console.Write("Введіть суму в рублях: ");
                    double rub = double.Parse(Console.ReadLine());

                    Converter converter = new Converter(usd, eur, rub);

                    Console.WriteLine();
                    converter.InfoCurrToUah();
                }
            }

            Console.ReadKey();
        }
    }
}
