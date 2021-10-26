using System;
using System.IO;
using System.Media;
using System.Threading;

namespace city_pumping
{
    class Welcome_Logo
    {
        public static SoundPlayer Back_Player = new SoundPlayer("фоновая музыка.wav"); /*текстовые файлы\\*/

        static public void Back_MusicPlayer()
        {
           // Back_Player.PlayLooping();

        }
        static public void Print_Welcome_Logo()
        {
            
            Info();
            
            StreamReader reader_logo = new StreamReader("текстовые файлы\\logo.txt");
            Thread.Sleep(1000);
            string text;
            do
            {
                text = reader_logo.ReadLine();
                Console.WriteLine(text);
            } while (text != null);


            reader_logo.Close();

            Thread.Sleep(1500);

            StreamReader present_reader = new StreamReader("текстовые файлы\\present_text.txt");
            string present_text;
            do
            {
                present_text = present_reader.ReadLine();
                Console.WriteLine(present_text);
            } while (present_text != null);

            present_reader.Close();

            Thread.Sleep(3000);
            System.Console.Clear();
            Thread.Sleep(1500);

            StreamReader game_name_reader = new StreamReader("текстовые файлы\\game_name.txt");
            string game_name_text;
            do
            {
                game_name_text = game_name_reader.ReadLine();
                Console.WriteLine(game_name_text);
            } while (game_name_text != null);

            game_name_reader.Close();

            Thread.Sleep(4500);
            System.Console.Clear();
            Thread.Sleep(900);

            Menu.Menu_print();


        }

        static private void Info()
        {
            Console.WriteLine("Быстрые кнопки: R и F");
            Console.WriteLine("Советую поставить front у консоли 20");
            Console.WriteLine("Внимание! Откройте игру в полноэкрвнном режиме! Если вы это сделали, то нажмите Enter");

            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();
               
            }
            while (consoleKeyInfo.Key != ConsoleKey.Enter);
            Console.Clear();
            Back_MusicPlayer();
            Thread.Sleep(700);
            
            
        }



      

    }
}
