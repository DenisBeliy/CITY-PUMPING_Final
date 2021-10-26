using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace city_pumping
{
    class Prints_Game_Map
    {
        public static void waiting_for_pressing_Enter()
        {
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();

            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
        public static void Print_map()
        {


            // Print_Villages.Print_Vil_lvl1();
            //  System.Threading.Thread.Sleep(1000);
            Village_type.voidSelect_Village_Type();
            Prints_baseline_indicators.Print_baseline_indicators();
            Console.SetCursorPosition(0,31);
        }


   




    }


    class Village_type
    {

        public enum Vill_type
        {
            первый_уровень, второй_уровень, третий_уровень, четвёртый_уровень,
            пятый_уровень, шестой_уровень, седьмой_уровень
        }// 6

        static public Vill_type vill_Type = Vill_type.первый_уровень;
        static public void voidSelect_Village_Type()
        {
            if (vill_Type == Vill_type.первый_уровень)
            {
                Print_Villages.Print_Vil_lvl1();

            }
            else if (vill_Type == Vill_type.второй_уровень)
            {
                Print_Villages.Print_Vil_lvl2();
            }
            else if (vill_Type == Vill_type.третий_уровень)
            {
                Print_Villages.Print_Vil_lvl3();

            }
            else if (vill_Type == Vill_type.четвёртый_уровень)
            {
                Print_Villages.Print_Vil_lvl4();
            }
            if (vill_Type == Vill_type.пятый_уровень)
            {
                Print_Villages.Print_Vil_lvl5();

            }
            else if (vill_Type == Vill_type.шестой_уровень)
            {
                Print_Villages.Print_Vil_lvl6();
            }
            else if (vill_Type == Vill_type.седьмой_уровень)
            {
                Print_Villages.Print_Vil_lvl7();
            }

        }
    }



    class Print_Villages
    {
        private static void waiting_for_pressing_Enter()
        {
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();

            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);
        }
        static public void Print_Vil_lvl1()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-1(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);



            



        }
        static public void Print_Vil_lvl2()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-2(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
        static public void Print_Vil_lvl3()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-3(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
        static public void Print_Vil_lvl4()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-4(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
        static public void Print_Vil_lvl5()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-5(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
        static public void Print_Vil_lvl6()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-6(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
        static public void Print_Vil_lvl7()
        {
            //waiting_for_pressing_Enter();

            StreamReader print_reader = new StreamReader("new_game\\игровая граффика\\деревня-7(lvl).txt");
            string text;
            Console.SetCursorPosition(0, 0);
            do
            {
                text = print_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);
            print_reader.Close();

            Console.SetCursorPosition(4, 0);







        }
    }


    class Prints_baseline_indicators
    {
       
        static public void Print_baseline_indicators()
        {
            StreamReader baseline_indicators_reader = new StreamReader("new_game\\показатели\\базовые показатели.txt");
           
         //   waiting_for_pressing_Enter();

           
            int x = 125;
            int y = 0;
            string text;
            Console.SetCursorPosition(125, y);
            
            do
            {
                text = baseline_indicators_reader.ReadLine();
                Console.WriteLine(text);

                Console.SetCursorPosition(x,y);
                y++;
            } while (text != null);


            Console.SetCursorPosition(x,1);
            text = baseline_indicators_reader.ReadLine();
            Console.WriteLine(text);
            baseline_indicators_reader.Close();
        }
    }
}
