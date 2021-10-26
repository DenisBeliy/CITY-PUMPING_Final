using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading; 

namespace city_pumping
{
    class Program
    {
        [DllImport("user32.dll")]
      
    public static extern bool ShowWindow(System.IntPtr hWnd, int cmdShow);
    public static FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d", FileMode.OpenOrCreate);
    public static FileStream stream_scientist = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d", FileMode.OpenOrCreate);

        static void Main(string[] args)
        {
            stream.Close();
            stream_scientist.Close();
            Directory.CreateDirectory(@"C://Сохранения игры [City-pumping]//" + ""); //создание своей папки
            Console.CursorVisible = false;
          /*  FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + " _resident_class_shepherd3" + ".d&d", FileMode.OpenOrCreate);
            stream.Close();*/
            Console.Title = " City-pumping  v0.1";
            //Welcome_Logo.Print_Welcome_Logo();
            //Prints_Game_Map.waiting_for_pressing_Enter();
            //  Prints_Game_Map.Print_map();
            //  Saves_game.Save_game();
            // New_Game.Greate_New_Game();
            //Menu.Menu_print();
            // Menu.Menu_print();
            // Prints_Game_Map.waiting_for_pressing_Enter();
            Console.WindowHeight = Console.LargestWindowHeight;
            Console.WindowWidth = Console.LargestWindowWidth;
            //Console.WriteLine(Accounting_resources.Give_residents);
            Process p = Process.GetCurrentProcess();
            ShowWindow(p.MainWindowHandle, 3);
            Welcome_Logo.Print_Welcome_Logo();

           /* Game.Start_Game();*/

            /*Load_residents.Print_residents();*/
            Threads.Thr_residents();
            Residents.Resident_management();
            /*  Threads.THR_food();*/
            Console.ReadLine();

        }
            
    
    }


    class Threads
    {
      
        
         public static void Thr_residents()
        {
            Thread thread = new Thread(new ThreadStart(ResTtimers.DAndD_coins));
             thread.Start();
            thread.IsBackground = true;
           // thread.IsBackground = true;

         
        }

    

        
  
    }



}
