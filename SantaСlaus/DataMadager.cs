using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace SantaСlaus
{
    class DataMadager
    {
        public string Path { get; private set; } = "";
        public DataMadager(string path)
        {
            Path = path;
        }
        public void SaveData(ClientCollection clients)
        {
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(Path, FileMode.Create, FileAccess.Write))
                    formatter.Serialize(stream, clients);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
        public ClientCollection LoadData()
        {
                ClientCollection clients = new ClientCollection();
            try
            {
                BinaryFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(Path, FileMode.Open, FileAccess.Read))
                    clients = formatter.Deserialize(stream) as ClientCollection;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return clients;
        }
    }
}
