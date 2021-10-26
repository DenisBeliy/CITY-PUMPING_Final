using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace city_pumping
{
    class Menu
    {
        static public void Menu_print()
        {
            StreamReader menu_reader = new StreamReader("текстовые файлы\\Menu.txt");
            string text;
            do
            {
                text = menu_reader.ReadLine();
                Console.WriteLine(text);
            } while (text != null);


            menu_reader.Close();

            Console.WriteLine("Выберите пункт меню: ");//выбор пункта из меню

            Choice();
        }

        static private void Choice()
        {
            ConsoleKeyInfo consoleKeyInfo;
            do
            {
                consoleKeyInfo = Console.ReadKey();
                if (consoleKeyInfo.Key == ConsoleKey.D1)
                {
                  /*  DialogResult result = MessageBox.Show("При создании игры, будут стёрты все файлы с сохранениями!!!", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
                    if (result == DialogResult.Yes)
                    {*/

                    
                    DirectoryInfo dirInfo = new DirectoryInfo("C:\\Сохранения игры [City-pumping]\\");

                    foreach (FileInfo file in dirInfo.GetFiles())
                    {
                        file.Delete();
                    }
                     FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d", FileMode.OpenOrCreate);
                     FileStream stream_scientist = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d", FileMode.OpenOrCreate);
                    stream.Close();
                    stream_scientist.Close();
                    
                    New_Game.Greate_New_Game();
                    break;
              
                }
                if (consoleKeyInfo.Key == ConsoleKey.D2)
                {
                    New_Game.Load_Game();
                    break;
                }
                if (consoleKeyInfo.Key == ConsoleKey.D3)
                {
                    Console.WriteLine();
                    Console.WriteLine("Выход...");
                    Thread.Sleep(1000);
                    Exsit();
                    break;
                }
                Console.Clear();
                Menu_print();
                 
            }
            while (consoleKeyInfo.Key != ConsoleKey.D1 && consoleKeyInfo.Key != ConsoleKey.D2 && consoleKeyInfo.Key != ConsoleKey.D3);


        }
        static private void Exsit()
        {
            Environment.Exit(0);
        }

    }
}
