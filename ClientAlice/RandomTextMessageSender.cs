using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Test002
{
    class RandomTextMessageSender
    {
        public string reciever { get; set; }
        public Boolean terminate { get; set; }
        public MessageSender messageSender { get; }
        Thread thread;

        public RandomTextMessageSender(string sender, string reciever)
        {
            terminate = false;
            this.reciever = reciever;
            messageSender = new MessageSender(sender);
            thread = new Thread(this.send);
            thread.Start();
        }

        public void stop()
        {
            terminate = true;
        }

        public void send()
        {
            while(!terminate)
            {
                messageSender.send(reciever, createRandomMessage());
            }
        }

        private string createRandomMessage()
        {
            return Guid.NewGuid().ToString();
        }
    }
}
