using System;
using System.IO;
using System.Threading;

namespace city_pumping
{

    class New_Game
    {
        
        public static string nameOfGame = "";
        static public void Greate_New_Game()
        {
                 
            Console.Clear();
            System.Threading.Thread.Sleep(1500);
            Interface_of_creating_the_game.Print_Interface();
            Interface_of_creating_the_game.Print_ofCreate_newGame();

            Creating_new_game.Create_new_game(nameOfGame = Console.ReadLine());

            Interface_of_creating_the_game.Print_InterfaceTwo();
            System.Threading.Thread.Sleep(5000);
            Console.Clear();
            Game.Start_Game();
        }

        static public void Load_Game()
        {

            Console.Clear();
            System.Threading.Thread.Sleep(500);
            
            /*Interface_of_creating_the_game.Print_ofCreate_newGame();*/

 

            Interface_of_creating_the_game.Print_InterfaceTwo();

            System.Threading.Thread.Sleep(4000);
            Console.Clear();
            Game.Start_Game();
        }
    }
    class Creating_new_game
    {
        //поля

        public static string nameOfGame = "";
        //конструктор
        public Creating_new_game(string nameOfGame)
        {
            Creating_new_game.nameOfGame = nameOfGame;
        }
        public static string pathString = @"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + ".d&d";
        static public  void Create_new_game(string nameOfGame)
        {

            /*FileStream stream_food = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_food" + ".d&d", FileMode.OpenOrCreate);
*/        

        }

    }
    class Load_residents
    {
        
        public static void Print_residents()
        {
                StreamReader number_residents = new StreamReader(Program.stream);
                int x = 125 + 12;
                int y = 17;
                string text = number_residents.ReadLine();
                Console.SetCursorPosition(x, y);
                Console.Write(text);
                Console.SetCursorPosition(0, 36);
                Program.stream.Close();
                number_residents.Close();

        }
    }

    class Interface_of_creating_the_game
    {
        static public void Print_Interface()
        {
            StreamReader reader_Intr = new StreamReader("new_game\\intr-1.txt");
            string text;
            do
            {
                text = reader_Intr.ReadLine();
                Console.WriteLine(text);
            } while (text != null);

            reader_Intr.Close();
        }

        static public void Print_ofCreate_newGame()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Придумайте название нового мира: ");
        }

        public static void Print_InterfaceTwo()
        {
            System.Threading.Thread.Sleep(2000);
            Console.Clear();
            System.Threading.Thread.Sleep(1000);
            StreamReader reader_Intr_two = new StreamReader("new_game\\intr-2.txt");
            string text;
            do
            {
                text = reader_Intr_two.ReadLine();
                Console.WriteLine(text);
            } while (text != null);

            reader_Intr_two.Close();

        }

       
    }
}
