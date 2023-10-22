
namespace Тортики
{
    internal class Program
    {
        public static List<Price> list = new List<Price>();
        static void Main()
        {

            Menu();
            int selected = Checker(3, 7, "->");
            Check(selected);
        }
        static void Menu()
        {

            Console.WriteLine("Заказ тортов в Весёлый кондитер, торты на Ваш выбор!");
            Console.WriteLine("Выберите параметр торта");
            Console.WriteLine("----------------------");
            List<cake> cakes = new List<cake>() {
                new cake("Форма торта"),
                new cake("Размер торта"),
                new cake("Вкус коржей"),
                new cake("Количество коржей"),
                new cake("Глазурь"),
                new cake("Декор"),
                new cake("Конец заказа"),
            };
            cake.MenuOutput(cakes);
            Console.WriteLine("");
            Console.WriteLine($"Цена: {cake.FullPrice} p");
            Console.WriteLine($"Ваш заказ: {cake.Purchase}");

        }
        public static void Check(int i)
        {
            if (i == 3)
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");

                List<Price> Price = new List<Price>()
                        {
                          new Price("Круг", 500),
                          new Price("Квадрат", 500),
                          new Price("Прямоугольник", 500),
                          new Price("Сердечко", 700)
                        };
                cake.AdditionalMenuOutput(Price);



            }
            else if (i == 4)
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");
                List<Price> Price = new List<Price>()
                        {
                          new Price("Маленький (диаметр - 16 см, 8 порций)", 1000),
                          new Price("Обычный (диаметр - 18, 10 порций)", 1200),
                          new Price("Большой (диаметр - 28 см, 24 порции)", 2000)
                        };
                cake.AdditionalMenuOutput(Price);
            }
            else if ((i == 5))
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");
                List<Price> Price = new List<Price>()
                        {
                          new Price("Ванильный", 100),
                          new Price("Шоколадный", 100),
                          new Price("Карамельный", 150),
                        };
                cake.AdditionalMenuOutput(Price);
            }
            else if ((i == 6))
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");
                List<Price> Price = new List<Price>()
                        {
                          new Price("1 корж", 200),
                          new Price("2 коржа", 400),
                          new Price("3 коржа", 600),
                          new Price("4 коржа", 800)
                        };
                cake.AdditionalMenuOutput(Price);

            }
            else if ((i == 7))
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");
                List<Price> Price = new List<Price>()
                        {
                          new Price("Шоколад", 100),
                          new Price("Крем", 100),
                          new Price("Бизе", 150),
                          new Price("Ягоды", 200)

                        };
                cake.AdditionalMenuOutput(Price);
            }
            else if ((i == 8))
            {
                Console.Clear();
                Console.WriteLine("Для выхода нажмите Escape");
                Console.WriteLine("Выберите пункт меню");
                Console.WriteLine("------------------");
                List<Price> Price = new List<Price>()
                        {
                          new Price("Шоколадная", 150),
                          new Price("Ягодная", 150),
                          new Price("Кремовая", 150)
                        };
                cake.AdditionalMenuOutput(Price);
            }
            else if (i == 9)
            {
                Console.Clear();
           
                DateTime dateTime = DateTime.Now;
                FileT();
            }
            Console.Clear();
            Main();
        }
        public static int Checker(int startPos = 3, int count = 7, string arrow = "->")
        {
            string empty = new string(' ', arrow.Length);
            int i = startPos;
            Console.SetCursorPosition(0, startPos);
            Console.Write(arrow);
            ConsoleKeyInfo key;
            for (; ; )
            {

                key = Console.ReadKey(true);
                if (key.Key == ConsoleKey.DownArrow)
                {
                    if (i == count + startPos - 1)
                        continue;
                    Console.SetCursorPosition(0, i);
                    Console.Write(empty);
                    Console.SetCursorPosition(0, ++i);
                    Console.Write(arrow);
                }

                else if (key.Key == ConsoleKey.UpArrow)
                {
                    if (i == startPos)
                        continue;
                    Console.SetCursorPosition(0, i);
                    Console.Write(empty);
                    Console.SetCursorPosition(0, --i);
                    Console.Write(arrow);
                }
                else if (key.Key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    Menu();
                }
                else if (key.Key == ConsoleKey.Enter)
                {
                    break;
                }

            }
            return i;
        }

        private static void FileT()
        {
            DateTime dateTime = DateTime.Now;
            string path = $"\n Заказ от {dateTime} \n Заказ:{cake.Purchase} \n Цена: {cake.FullPrice} \n ----------------------"; 
            File.AppendAllText("C:\\Users\\efimb\\OneDrive\\Desktop\\История заказов.txt", path);
            cake.Nulli();
        }

    }
    
}