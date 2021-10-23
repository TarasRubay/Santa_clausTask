using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    [Serializable]
    public class Client
    {
        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int ID { get; private set; }
        public int GoodGoingsOn { get; set; } // лічильник добрих справ змінює class Santa
        public int BadGoingsOn { get; set; } // лічильник поганих справ змінює class Santa

        public Client(string name, string surname, int id)
        {
            Name = name;
            Surname = surname;
            ID = id;
        }

        public override string ToString()
        {
            return $"\nid: {ID}\nname: {Name}\nsurname: {Surname}\ngood {GoodGoingsOn}; bad {BadGoingsOn}\n";
        }
    }
}
