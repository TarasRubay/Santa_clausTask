using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    
    class Santa
    {
        
        public ClientCollection clients { get; set; } = new ClientCollection();
    
        //public class GoingsOn {
        //    public int GoodGoingsOn { get; set; }
        //    public int BadGoingsOn { get; set; }
            
        //    }
        Elf elf { get; set; }
         
        private static Santa uniqueInstans { get; set; }
        private Santa() { }
        public static Santa Instanse()
        {
            if(uniqueInstans == null)
            {
                uniqueInstans = new Santa();
                return uniqueInstans;
            }
            return uniqueInstans;
        }
        // я не зміг серелізувати словник з вкладеним класом 
       //  Dictionary<Client, GoingsOn> clients { get; set; } = new Dictionary<Client, GoingsOn>();
        public void SendGoodGoingOn(Client client)
        {

            try
            {
                var seq = clients.Single(i => i.ID == client.ID);
                seq.GoodGoingsOn++;
            }
            catch
            {
                
                client.GoodGoingsOn = 1;
                client.BadGoingsOn = 0;
                clients.Add(client);
            }

        }
        public void SendBadGoingOn(Client client)
        {
            try
            {
                var seq = clients.Single(i => i.ID == client.ID);
                seq.BadGoingsOn++;
            }
            catch 
            {
                
                client.GoodGoingsOn = 0;
                client.BadGoingsOn = 1;
                clients.Add(client);
            }
        }
        //public Dictionary<Client, GoingsOn> ListClient()
        //{
        //    return clients;
        //}
        public Client GetClient(int id)
        {
            try
            {
                var seq = clients.Single(i => i.ID == id);
                Console.WriteLine($"Hello {seq.Name}");
                return seq;
            }
            catch (Exception e)
            {
                e.ToString();
                Console.WriteLine("Hello new user\nEnter you name: ");
                string name = Console.ReadLine();
                Console.WriteLine("Enter you surname: ");
                string surname = Console.ReadLine();
                return new Client(name, surname, id);
            }
        }
        public void TimeToPresents()
        {
            if (clients.Count() != 0) {
                foreach (var item in clients)
                {
                    if (item.BadGoingsOn <= item.GoodGoingsOn) {
                        elf = new Elf(new FactoryGoodPresents());
                        elf.GiveGift(item);
                    } else if (item.BadGoingsOn > item.GoodGoingsOn)
                    {
                        elf = new Elf(new FactoryBadPresents());
                        elf.GiveGift(item);
                    }
                }
            }
            else Console.WriteLine("List empty");
        }
    }
}
