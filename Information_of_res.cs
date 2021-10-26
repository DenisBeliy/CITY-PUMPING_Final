using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace city_pumping
{
   
    public partial class Information_of_res : Form
    {
       public int names_nomber;
       public Random random_names = new Random();
            /* stream.Close();*/
       public static int number_shepherd;
    
     
        
        public Information_of_res()
        {
            Form newForm = new Form();
            
            //настройка вида формы
                                                                   // random_names.Next(0,100);

    
           
            InitializeComponent();
        }
        //данные для таблицы

        enum Names
        {
            Август, Августин, Авраам, Аврора, Агата, Агафон, Агнесса, 
            Агния, Ада, Аделаида, Аделина, Адонис, Акайо, Акулина, 
            Алан, Алевтина, Александр, Александра, Алексей, Алена,

            Беатрис, Белла, Бенедикт, Берта, Богдан, Божена, Болеслав, 
            Борис, Борислав, Бронислав, Бронислава, Булат,

            Габриэлла, Гавриил, Галина, Гарри, Гелла, Геннадий, Генриетта,
            Георгий, Герман, Гертруда, Глафира, Глеб, Глория, Гордей, Грейс,
            Грета, Григорий, Гульмира,

            Магдалина, Майя, Макар, Максим, Марат, Маргарита, Марианна, Марина,
            Мария, Марк, Марта, Мартин, Марфа, Матвей, Мелания, Мелисса, Милана, 
            Милена,

            Оксана, Олег, Олеся, Оливер, Оливия, Ольга, Оскар,

            Эдгар, Эдита, Эдуард, Элеонора, Элина, Элла, Эльвира, Эльдар, Эльза,
            Эмили, Эмилия, Эмма, Эрик, Эрика,


            Сабина, Савва, Савелий, Саки, Сакура, Самсон, Самуил, Сарра, Светлана,
            Святослав, Севастьян, Семен
        }

        enum Profession
        {
            Сталкер, Охотник_за_головами, Ученый, Пастух, Каменщик, Кузнец,
            Свяще́нник, Монах, Торговец
        }

        enum Temperament
        {
            Сангвини, Флегматик, Холерик, Меланхолик
        }


        private void Information_of_res_Load(object sender, EventArgs e)
        {

            /*        FileStream streamOne = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d", FileMode.OpenOrCreate);



                if (streamOne.Length == 0)
                {
                    number_shepherd = 0;
                    streamOne.Close();
                }
                else
                {
                    streamOne.Close();*/
            try
            {
                number_shepherd = int.Parse(File.ReadAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d"));
            }
            catch { number_shepherd = 0; }
            

            button3_Click(sender, e);
            label1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            timer1.Enabled = true;
            
        }
        public static int Give_shepherds = number_shepherd;
        static public string num = "1";
        private EventArgs e;
        private object sender;

        private void button1_Click(object sender, EventArgs e)
        {
            int colIndex = 0; //индекс столбца
            int a = 0;
            //рандомы 
            Random random_pos = new Random();
            random_pos.Next(0, 3);
            Random random_percent = new Random();
            a =random_percent.Next(0,100);
            

            // Вывод enum и random 
            Names name_random_print = (Names)random_names.Next(0,100);
            Profession profession_random_print;
            if (Accounting_resources.Give_food >= 200)
            {
                profession_random_print = (Profession)random_names.Next(0, 8);
            }
            else
            {
                profession_random_print = Profession.Пастух;
            }
           
            if (profession_random_print == Profession.Пастух&& number_shepherd <= 5)
            {

                number_shepherd++;

            }
            else
            {
                profession_random_print = (Profession)random_names.Next(0, 8);
            }
            int abc = 0;
            if (profession_random_print == Profession.Ученый)
            {
               FileStream stream_scientist = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_scientist_residents" + ".d&d", FileMode.OpenOrCreate);
               StreamWriter streamWriter_scientist = new StreamWriter(stream_scientist);
                abc++;
                streamWriter_scientist.Write(abc.ToString());

                streamWriter_scientist.Close();
                stream_scientist.Close();
             }

    Temperament temperament_random_print = (Temperament)random_names.Next(0, 3);
            string n_pos = "Я_хороший-ты_хороший";
            if (random_pos.Next(0, 3) == 0)
            {
                n_pos = "Я_хороший-ты_хороший";
            }
             if (random_pos.Next(0,3) == 1)
            {
                n_pos = "Я_хороший-ты_плохой";
            }
             if (random_pos.Next(0, 3) == 2)
            {
                n_pos = "Я_плохой-ты_хорший";
            }
             if (random_pos.Next(0, 3) == 3)
            {
                n_pos = "Я_плохой-ты_плохой";
            }


            dataGridView1.Rows.Add("", name_random_print, profession_random_print, n_pos,
            temperament_random_print, a+"%");
            

            for (int i = 0; i < dataGridView1.RowCount - 1; i++)
            {
                dataGridView1.Rows[i].Cells[colIndex].Value = i + 1;
                Accounting_resources.Give_residents = i + 1;
                Accounting_resources.Plus_residents();
            }
        }
 
  
       


        public void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
 
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (Accounting_resources.Give_DAndD_coins >= 500f)
            {
                
                Accounting_resources.Minus_gold(500f);
                button1_Click(sender, e);
               // ccounting_resources.Plus_residents(Accounting_resources.Give_residents);
            }
            else
            {
                MessageBox.Show("У вас недостаточно золота! (у вас " + Accounting_resources.Give_DAndD_coins + ")","Внимание!",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            try
            {
                FileStream stream1 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d", FileMode.OpenOrCreate);
                StreamWriter streamWriter = new StreamWriter(stream1);
                streamWriter.Write(number_shepherd.ToString());
                streamWriter.Close();
                stream1.Close();
            }
            catch { }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            /*       Stream fs = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_residentsSave" + ".d&d", FileMode.Open, FileAccess.Read);
                   StreamReader sr = new StreamReader(fs);
                   DataTable dt = new DataTable();
                   *//*dt.Columns.Add("Номер п/п");
                   dt.Columns.Add("Данные");*//*
                   int count = 1;

                   while (sr.Peek() != -1)
                   {
                       string s = sr.ReadLine();
                       dt.Rows.Add(count, s);
                       count++;
                   }
                   dataGridView1.DataSource = dt;*/
            try
            {

           
            foreach (var line in File.ReadLines(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_residentsSave" + ".d&d"))
            {
                var array = line.Split();
                dataGridView1.Rows.Add(array);
                   
                }
                dataGridView1.Rows.RemoveAt(dataGridView1.Rows.Count - 2);//!!!!!!!
            }
            catch
            {
                //MessageBox.Show("Нет данных");
            }
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button6_Click(sender, e);
            this.Close();
            


        }

        private void button5_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_residentsSave" + ".d&d");
            string[] values;


            for (int i = 0; i < lines.Length; i++)
            {
                values = lines[i].ToString().Split();
                string[] row = new string[values.Length];
                for (int j = 0; j < values.Length; j++)
                {
                    row[j] = values[j].Trim();

                }
                dataGridView1.Rows.Add(row);

            }
        }
   
        private void button6_Click(object sender, EventArgs e)
        {
            int rows = dataGridView1.Rows.Count;

            FileStream fs = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_residentsSave" + ".d&d", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(fs);
            
            try
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    int a = j;
                    for (int i = 0; i < dataGridView1.Rows[j].Cells.Count; i++)
                    {
                        streamWriter.Write(dataGridView1.Rows[j].Cells[i].Value+" ");
                       // Console.Write(" ");
                    }
                   
                        streamWriter.WriteLine();

                    




                }
                
                streamWriter.Close();
                fs.Close();
               
                // MessageBox.Show("Файл успешно сохранен");
            }
            catch
            {
                MessageBox.Show("Ошибка при сохранении файла!");
            }
            FileStream stream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_number_residents" + ".d&d", FileMode.OpenOrCreate);

            StreamWriter number_residents = new StreamWriter(stream);
            if (rows-1>= 0)
            {
                number_residents.Write(rows - 1);
            }
            else
            {
                number_residents.Write(0);
            }
           
            number_residents.Close();
            stream.Close();
       

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
           
            

        }

        private void button7_Click(object sender, EventArgs e)
        {
            int a = dataGridView1.CurrentRow.Index;
            
        }

        private void Information_of_res_FormClosed(object sender, FormClosedEventArgs e)
        {
            button6_Click(sender, e);
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            label2.Text = number_shepherd.ToString();
            label1.Text = "У вас " + Accounting_resources.Give_DAndD_coins + " D/D coins";
            if (Accounting_resources.Give_DAndD_coins <= 1000)
            {
                label1.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                label1.ForeColor = System.Drawing.Color.Black;
            }
             
        }

        private void Information_of_res_FormClosing(object sender, FormClosingEventArgs e)
        {

            //FileStream stream1 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d", FileMode.OpenOrCreate);
            StreamWriter streamWriter = new StreamWriter(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d");
            streamWriter.WriteAsync(number_shepherd.ToString());
            streamWriter.Close();
           // stream1.Close();
            string a = number_shepherd.ToString();

            
            
            /* File.WriteAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d",a.ToString());
 */
            /*      FileStream stream2 = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd3" + ".d&d", FileMode.OpenOrCreate);
                  StreamWriter streamWriter2 = new StreamWriter(stream2);
                  streamWriter2.Write(number_shepherd.ToString());
                  streamWriter2.Close();
                  stream2.Close();*/
        }


  



        /*      async Task A()
             {
                 *//*var filePath = "simple.txt";*//*
                 var text = await File.WriteAllText(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d", number_shepherd.ToString());

             }*/
        /* using var sourceStream = new FileStream(@"C:\Сохранения игры [City-pumping]\" + Creating_new_game.nameOfGame + "\\" + "Saves_of - " + Creating_new_game.nameOfGame + "_resident_class_shepherd2" + ".d&d",
                                              FileMode.OpenOrCreate,

                                              useAsync: true);*/



        private void button4_Click_1(object sender, EventArgs e)
        {
            int colIndex = 0; //индекс столбца
            int a = 0;
            //рандомы 
            Random random_pos = new Random();
            random_pos.Next(0, 3);
            Random random_percent = new Random();
            a = random_percent.Next(0, 100);


            // Вывод enum и random 
            Names name_random_print = (Names)random_names.Next(0, 100);
            Profession profession_random_print;
            if (Accounting_resources.Give_food >= 200)
            {
                profession_random_print = (Profession)random_names.Next(0, 8);
            }
            else
            {
                profession_random_print = Profession.Пастух;
            }

            if (profession_random_print == Profession.Пастух && number_shepherd <= 5)
            {

                number_shepherd++;

            }
            else
            {
                profession_random_print = (Profession)random_names.Next(0, 8);
            }

            Temperament temperament_random_print = (Temperament)random_names.Next(0, 3);
            string n_pos = "Я_хороший-ты_хороший";
            if (random_pos.Next(0, 3) == 0)
            {
                n_pos = "Я_хороший-ты_хороший";
            }
            if (random_pos.Next(0, 3) == 1)
            {
                n_pos = "Я_хороший-ты_плохой";
            }
            if (random_pos.Next(0, 3) == 2)
            {
                n_pos = "Я_плохой-ты_хорший";
            }
            if (random_pos.Next(0, 3) == 3)
            {
                n_pos = "Я_плохой-ты_плохой";
            }
        }

        
    }
}

