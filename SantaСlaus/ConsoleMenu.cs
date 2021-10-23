using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    public class ConsoleMenu
    {
        public ConsoleMenu(string Path)
        {
            menu = 100;
            max_menu = 2;
            switch_on = menu;
            path = Path;
          
        }
        int menu { get; }
        int max_menu { get; }
        int switch_on { get; set; }

        string path { get; } = "";
        


        public void Start()
        {
            // санта є власником колекції клієнтів, він надає доступ до надсилання листа по ID новому або існуючому клієнту

            Santa santa = Santa.Instanse();
            Client client;
            DataMadager manager = new DataMadager(path);
            santa.clients = manager.LoadData(); // санта завантажує дані про клієнтів при запуску програми
            do
            {
                switch (switch_on)
                {
                    case 100:
                        do
                        {
                            try
                            {
                                Print();
                                switch_on = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception msg)
                            {
                                Console.WriteLine(msg.Message);
                                switch_on = menu;
                            }
                            Console.Clear();
                        } while (switch_on < 0 || switch_on > max_menu);

                        break;
                    case 1:
                        Console.WriteLine("login\nEnter ID");
                        switch_on = Convert.ToInt32(Console.ReadLine());
                        client = santa.GetClient(switch_on); // пошук по ІД повертає існуючого або нового клієнта
                        do
                        {
                            try
                            { 
                                Console.WriteLine("What GoingOn do you want send me?\n1 - good goings-on\n2 - bad goings-on\n");
                                switch_on = Convert.ToInt32(Console.ReadLine());
                            }
                            catch (Exception msg)
                            {
                                Console.WriteLine(msg.Message);
                                switch_on = 0;
                            }
                            Console.Clear();
                        } while (switch_on < 1 || switch_on > 2);
                        if (switch_on == 1) santa.SendGoodGoingOn(client); //лист до санти про добру справу
                        else santa.SendBadGoingOn(client); //лист до санти про погану справу
                        switch_on = menu;
                        break;
                    case 2:
                        Console.WriteLine("");
                   
                        santa.TimeToPresents(); // // це б мав запускати час але тут запуск в ручну
                        

                        switch_on = menu;
                        break;
                   
                    default:
                        break;
                }

            } while (switch_on != 0);
            manager.SaveData(santa.clients); // санта зберігає дані про клієнтів при завершенні програми
            Console.WriteLine("Data saved...");
        }
        void Print()
        {
            Console.WriteLine();
            Console.WriteLine($"1 - Login");
            Console.WriteLine("2 - Time to presents");
           // Console.WriteLine("3 - Time to presents");
            //Console.WriteLine("4 - Find worker");
           // Console.WriteLine($"5 - Save XML from file: {path}");
            Console.WriteLine("0 - exit");
        }
    }
}
