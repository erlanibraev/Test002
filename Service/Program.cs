using NFX;
using NFX.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var application = new ServiceBaseApplication(args, null))
                {
                    Console.WriteLine("server is running...");
                    Console.WriteLine("Glue servers:");
                    foreach (var service in App.Glue.Servers)
                        Console.WriteLine("   " + service);

                    Console.ReadLine();
                }
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("error: ");
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
