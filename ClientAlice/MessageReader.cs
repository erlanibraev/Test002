using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Test002.Contracts;

namespace Test002
{
    public class MessageReader
    {
        public Boolean terminate { get; set; }
        public MessageReciever messageReciver { get; }

        Thread thread;

        public MessageReader(string reciever)
        {
            terminate = false;
            messageReciver = new MessageReciever(reciever);
            thread = new Thread(this.read);
            thread.Name = "reciever: " + reciever;
            thread.Start();
        }

        public void stop()
        {
            terminate = true;
        }

        public void read()
        {
            terminate = false;
            while(!terminate)
            {
                TestMessage message = messageReciver.recive();
                if (message != null)
                {
                    Console.Write(message.dob);
                    Console.Write(" : ");
                    Console.Write(message.sender);
                    Console.Write(" => ");
                    Console.Write(message.reciever);
                    Console.Write(" - ");
                    Console.WriteLine(message.message);
                }
            }
        }
    }
}
