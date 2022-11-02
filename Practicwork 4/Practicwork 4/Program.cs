namespace Practicwork4
{
    internal class Programm
    {
        static void Main()
        {
            while (true)
            {
                int day = 1;
                ConsoleKey key;
                
                do
                {
                    DateTime date = new(2022, 10, day);
                    Console.WriteLine("Date choosed " + date);
                    Console.WriteLine("Press any button to open notes for this day");
                    if (day == 1)
                    {
                        Console.WriteLine("Do homework");
                    }

                    if (day == 3)
                    {
                        Console.WriteLine("Go to the gym");
                    }

                    if (day == 6)
                    {
                        Console.WriteLine("Go to the mpt");
                    }
                    key = Console.ReadKey().Key;
                    Console.Clear();
                    if (key == ConsoleKey.LeftArrow)
                    {
                        day--;
                        if (day < 1)
                        {
                            day = 30;
                        }
                    }
                    else if (key == ConsoleKey.RightArrow)
                    {
                        day++;
                        if (day > 30)
                        {
                            day = 1;
                        }
                    }
                } while (key != ConsoleKey.Enter);
                {
                    if (day == 1)
                    {
                        note();
                    }

                    if (day == 3)
                    { 
                        note2();
                    }

                    if (day == 6)
                    { 
                        note3();
                    }
                }
            }
        }
        static int positon = 1;
        static void cursor()
        {

            ConsoleKeyInfo keytwo = Console.ReadKey();
            while (keytwo.Key != ConsoleKey.Enter)
            {
                if (keytwo.Key == ConsoleKey.DownArrow)
                {
                    if (positon < 3)
                    {
                        positon++;
                    }
                }
                else if (keytwo.Key == ConsoleKey.UpArrow)
                {
                    if (positon > 1)
                    {
                        positon--;
                    }
                }

                Console.Clear();
                note();
                Console.SetCursorPosition(0, positon);
                Console.WriteLine("->");
                keytwo = Console.ReadKey();
            }
        }

        static void note()
        {
            Console.Clear();
            Console.WriteLine("Do homework");
            Console.WriteLine("--------------------");
            Console.WriteLine("I need to do my homework");
            Console.WriteLine("Press any button to exit from note");
        }

        static void note2()
        {
            Console.WriteLine("Go to the gym");
            Console.WriteLine("--------------------");
            Console.WriteLine("I need to go to the gym");
            Console.WriteLine("Press any button to exit from note");
        }

        static void note3()
        {
            Console.Clear();
            Console.WriteLine("Go to the mpt");
            Console.WriteLine("--------------------");
            Console.WriteLine("I need to go to the mpt");
            Console.WriteLine("Press any button to exit from note");
        }
    } 
}
