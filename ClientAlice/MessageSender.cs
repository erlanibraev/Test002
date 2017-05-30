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
    public class MessageSender
    {
        public string sender { get; set; }

        public MessageSender(string sender)
        {
            this.sender = sender;
        }

        public void send(string receiver, string message)
        {
            try
            {
                using (var service = new TestMessageAutoClient(App.ConfigRoot.AttrByName("test-service-node").Value))
                {
                    TestMessage msg = new TestMessage();
                    msg.sender = sender;
                    msg.reciever = receiver;
                    msg.message = message;
                    service.Send(msg);
                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }

        }
    }
}
