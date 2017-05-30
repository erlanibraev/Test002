using NFX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test002.Contracts;
using Test002.Contracts.Servicies.GluedClients;

namespace Test002
{
    public class MessageReciever
    {
        public string reciver { get; set; }

        public MessageReciever(string client)
        {
            this.reciver = client;
        }

        public TestMessage recive()
        {
            try
            {
                using (var service = new TestMessageAutoClient(App.ConfigRoot.AttrByName("test-service-node").Value))
                {
                    return service.Recive(reciver);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
            return null;
        }
    }
}
