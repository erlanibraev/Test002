using NFX;
using NFX.Environment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test002.Contracts;
using Test002.Contracts.Servicies.GluedClients;

namespace Test002
{
    public class Test
    {
        public void run()
        {
            try
            {
                using (var service = new TestMessageAutoClient(App.ConfigRoot.AttrByName("test-service-node").Value))
                {
                    TestMessage message = new TestMessage();
                    message.sender = "Alice";
                    message.reciever = "Bob";
                    message.message = "TEST!!!";
                    message.dob = DateTime.Now;
                    service.Send(message);
                    TestMessage recive = service.Recive("Bob");
                    Console.WriteLine(recive.message);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
