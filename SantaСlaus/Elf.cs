using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    class Elf
    {
        private AbstractEatPres EatPres { get; set; }
        private AbstractNotEatPres NotEatPres { get; set; }
        public Elf(AbstractFactory factory)
        {
            EatPres = factory.EatPres();
            NotEatPres = factory.NotEatPres();
        }
        public void GiveGift(Client client)
        {
            Console.WriteLine($"{client} \nyour gift is {EatPres.ToString().Split('.')[1]} and {NotEatPres.ToString().Split('.')[1]}");
        } 
    }
}
