using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace city_pumping
{
    class Game
    {

        public static SoundPlayer Back_Player2 = new SoundPlayer("текстовые файлы\\фоновая музыка2.wav");
    
        public static void Start_Game()
        {
            Welcome_Logo.Back_Player.Stop();
          //  Back_Player2.PlayLooping();
         /*   Prints_Game_Map.waiting_for_pressing_Enter();*/
            Prints_Game_Map.Print_map();
       /*     FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d", FileMode.OpenOrCreate);
            if (stream.Length == 0)
            {
                StreamWriter streamWriter = new StreamWriter(stream);
                streamWriter.Write("0");
                streamWriter.Close();
            }*/
            Accounting_resources.Prin_Info_of_res();
            Creating_new_game.Create_new_game(Creating_new_game.nameOfGame);
          
        }

        


    }


    class Residents
    {

        public static ConsoleKeyInfo consoleKeyInfo;
        static public void Resident_management()
        {
            while (true)
            {

           
            do
            {
                    if (consoleKeyInfo.Key == ConsoleKey.F)
                    {
                        tree_nuke tree_nuke = new tree_nuke();
                        tree_nuke.ShowDialog();
                    }
                   

                    consoleKeyInfo = Console.ReadKey(true);
                /*consoleKeyInfo = Console.ReadKey();*/
                if (consoleKeyInfo.Key == ConsoleKey.Escape)
                {
                    Environment.Exit(0);
                }//добавил своё закрытие игры
            }
            while (consoleKeyInfo.Key != ConsoleKey.R);

           
            Information_of_res information_Of_Res = new Information_of_res();
            information_Of_Res.ShowDialog();
            }

        }





    }




    class ResTtimers
    {
        static System.Timers.Timer timer1 = new System.Timers.Timer(5000);//60000);//300000);
       
        static public void DAndD_coins()
        {
            timer1.Elapsed += Timer1_Elapsed;
            timer1.Enabled = true;
            timer1.Start();
        }




      
        private static void Timer1_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
             
                              /*DAndD_coins*/
            int redis = Accounting_resources.Give_residents;
            float gold = 100;
            if (Accounting_resources.Give_food >0)
            {
                if (redis == 0)
                {

                }
                gold = redis * 50;
                Accounting_resources.Plus_gold(gold);
            }
            else
            {
            }
            FileStream goldSave = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "gold_save" + ".d&d", FileMode.OpenOrCreate);
            StreamWriter writer_gold = new StreamWriter(goldSave);
            float goldWithSave = Accounting_resources.Give_DAndD_coins;
            writer_gold.Write(goldWithSave);
            writer_gold.Close();
            goldSave.Close();


                                                         /*Food*/
            int number_of_shepherds = Information_of_res.Give_shepherds;
            int i;
            try
            {
                 i = int.Parse(File.ReadAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d").ToString());

            }
            catch 
            {
                i = 0;
                Console.WriteLine("erroorr");
            }
            int food_one_out;

            food_one_out = i * 3;
            
    

            if (true)
            {
                Accounting_resources.Give_food = Accounting_resources.Give_food + food_one_out;
                Accounting_resources.Plus_food();
            }

            int food = Accounting_resources.Give_food;
            if (food > 0)
            {
                int food_one_give = redis * 2;
                /*Console.WriteLine(food_one_give);*/
                Accounting_resources.Give_food = Accounting_resources.Give_food - food_one_give;
                /*Console.WriteLine(Accounting_resources.Give_food);*/
                Accounting_resources.Minus_food();
            }
            Save_food();


        }

        /* static int A()
        {

            int a = 0;
            try
            {
                StreamReader sr = new StreamReader(p);
                string line;
                while (!sr.EndOfStream)
                {
                    a = int.Parse(sr.ReadLine());
                    //бла-бла-бла
                }
                sr.Close();
            }
            catch { a = 0; }
           *//* stream1.Close();*//*
            
            return a;
        }*/

        public static void Save_food()
        {
             FileStream stream_food = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_food" + ".d&d", FileMode.OpenOrCreate);
            int food_save = Accounting_resources.Give_food;
            StreamWriter writer_food = new StreamWriter(stream_food);
            writer_food.Write(food_save.ToString());
            writer_food.Close();
            stream_food.Close();
        }
    }



   class Accounting_resources
    {
       static private int village_level = 1; // допилить (чтобы можно было из 1 места менять!)
        static private int residents = Load_Data.Load__number_residents(); // Print_red(res);//
        static private int food = Load_Data.Load__food();
        static private float DAndD_coins = Load_Data.Load_D_Dcoins();


        static public float Give_DAndD_coins = DAndD_coins;
        static public int Give_residents = residents;
        static public int Give_food = food;
        public static int Give_food_one = 3;
        static public int uchonaya_mana = 100;
        static private int res = 0;
       
        static private int Print_red(int i)
        {
            //EEEEEEEEEEEEEEEEEEEEEEEEEEEEEEEee!!
            try
            {
                FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d", FileMode.OpenOrCreate);
                StreamReader number_residents = new StreamReader(stream);
                i += int.Parse(number_residents.ReadToEnd());
                number_residents.Close();
                stream.Close();
                return res = i;
            }
            catch { return res = 0; }
        }
        public static void Minus_gold(float a)
        {
            float b = DAndD_coins = DAndD_coins - a;
            if (b >= 0)
            {
                
                int x = 125 + 15;
                int y = 25;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("        ");
                DAndD_coins = b;
                Give_DAndD_coins = DAndD_coins;
                Print_bace_res_DAndD_coins();
                Cleaning();
            }

      
        }// списывание среств у игрока
        public static void Plus_gold(float a)
        {
            float b  = DAndD_coins + a;
            if (b >= 0)
            {

                int x = 125 + 15;
                int y = 25;
                Console.SetCursorPosition(x, y);
                Console.WriteLine("        ");
                DAndD_coins = b;
                Give_DAndD_coins = DAndD_coins;
                Print_bace_res_DAndD_coins();
                Cleaning();
            }
        }
        public static void Cleaning()
        {
            Console.SetCursorPosition(0, 36);
            Console.WriteLine("        ");
            Console.SetCursorPosition(0, 36);
        }
        public static void Plus_residents()
        {
            residents = Give_residents;
            Print_bace_residents();
            Cleaning();

            /* int b = residents + a;
             residents = b;
             Give_residents = b;

             int x = 125 + 12;
             int y = 17;
             Console.SetCursorPosition(x, y);
             Console.WriteLine("ww    ");
             Print_bace_residents();
             Console.SetCursorPosition(0, 36);
             Console.WriteLine("        ");
             Console.SetCursorPosition(0, 36);*/
        }


        public static void Plus_food()
        {
            food = Give_food;
            int x = 125 + 12 - 3;
            int y = 17 + 4;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("        ");
            Print_bace_res_food();
            Cleaning();
        }

        public static void Minus_food()
        {
            food = Give_food;
            int x = 125 + 12 - 3;
            int y = 17 + 4;
            Console.SetCursorPosition(x, y);
            Console.WriteLine("        ");
            if (Accounting_resources.Give_food < 0)
            {
                Console.SetCursorPosition(x, y);
                food = 0;
                Console.WriteLine("0");
            }
            Print_bace_res_food();
            Cleaning();
        }
        public static void Prin_Info_of_res()
        {
            Print_bace_res_village_level();
            Print_bace_residents();
            Print_bace_res_food();
            Print_bace_res_DAndD_coins();
            Console.SetCursorPosition(0,36);
        }
   
        static private void Print_bace_res_village_level()
        {
            int x = 125 + 13+8;
            int y = 9+4;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(village_level);
            
        }
        static private void Print_bace_residents()
        {
            int x = 125 + 12;
            int y = 17;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(residents);
        }


        static private void Print_bace_res_food()
        {
            int x = 125 + 12 - 3;
            int y = 17 + 4;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(food);
        }
        static private void Print_bace_res_DAndD_coins()
        {
            int x = 125 + 15;
            int y = 25;
            Console.SetCursorPosition(x, y);
            Console.WriteLine(DAndD_coins);
        }

    }//ввывод базовой инфы на экран




class Load_Data
    {
        static FileStream stream1 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d", FileMode.OpenOrCreate);

        public static int Load__number_residents()
        {
            int a;

            /*StreamReader reader_of_number_residents = new StreamReader(Program.stream);




        if (Program.stream.Length == 0)
        {
            a = 0;
        }*/
            /*  try
              {*/
            try
            {
                a = int.Parse(File.ReadAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d").ToString());
            }
            catch { a = 0; }
            /*catch { a = 0; }*/
            /*    reader_of_number_residents.Close();
                stream1.Close();


                *//*catch { a = 0; }*//*

                stream1.Close();*/
            stream1.Close();
            return a;
        }

        static FileStream stream2 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_food" + ".d&d", FileMode.OpenOrCreate);

        public static int Load__food()
        {
            int b;
            try
            {
                StreamReader reader_of_food = new StreamReader(stream2);
                /*
                            if (stream2.Length == 0)
                            {
                                b = 0;
                            }*/
                b = int.Parse(reader_of_food.ReadToEnd());
                reader_of_food.Close();
                stream2.Close();
            }
            catch { b = 50; }
            stream2.Close();
            return b;
        }
         public static float Load_D_Dcoins()
        {
            FileStream goldLoad = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "gold_save" + ".d&d", FileMode.OpenOrCreate);
            if (goldLoad.Length ==0)
            {
                goldLoad.Close();
                return 500f;
            }
            try
            {
                 if (goldLoad.Length ==0)
                {
                    return 0f;
                }
                StreamReader reader_gold = new StreamReader(goldLoad);
                float coins_load = float.Parse(reader_gold.ReadLine());

                goldLoad.Close();
                reader_gold.Close();
                return coins_load;
            }
            catch { return 100f; goldLoad.Close(); }
            goldLoad.Close();
        }
    }


}
