using NFX.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test002.Contracts.Servicies.GluedClients;

namespace Test002
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var application = new ServiceBaseApplication(args, null))
                {
                    Test test = new Test();
                    test.run();
                    Console.ReadLine();

                }
            } catch(Exception ex)
            {
                Console.WriteLine("error: ");
                Console.WriteLine(ex);
                Console.ReadLine();
            }
        }
    }
}
