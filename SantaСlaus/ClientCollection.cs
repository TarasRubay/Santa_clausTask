using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SantaСlaus
{
    [Serializable]
    public class ClientCollection : IEnumerable<Client>
    {
        public List<Client> Clients { get; private set; } = new List<Client>();

        public IEnumerator<Client> GetEnumerator()
        {
            return Clients.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(Client client)
        {
            Clients.Add(client);
        }

        public void Remove(Client client)
        {
            Clients.Remove(client);
        }

       
    }
}
