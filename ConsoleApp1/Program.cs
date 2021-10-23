using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public class MergeNames
        {
            public static string[] UniqueNames(string[] names1, string[] names2)
            {
                names1[names1.Length] = "";
                names1[names1.Length-1] = names2[1];
                return names1;
            }

            public static void Main(string[] args)
            {
                string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
                string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
                Console.WriteLine(string.Join(", ", MergeNames.UniqueNames(names1, names2))); // should print Ava, Emma, Olivia, Sophia
            }
        }
        /// <summary>
        /// /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        //public class AlertService
        //{
        //    private readonly AlertDAO storage = new AlertDAO();

        //    public Guid RaiseAlert()
        //    {
        //        return this.storage.AddAlert(DateTime.Now);
        //    }

        //    public DateTime GetAlertTime(Guid id)
        //    {
        //        return this.storage.GetAlert(id);
        //    }
        //}

        //public class AlertDAO
        //{
        //    private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

        //    public Guid AddAlert(DateTime time)
        //    {
        //        Guid id = Guid.NewGuid();
        //        this.alerts.Add(id, time);
        //        return id;
        //    }

        //    public DateTime GetAlert(Guid id)
        //    {
        //        return this.alerts[id];
        //    }
        //}
        /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        ///
    }
}
