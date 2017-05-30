using NFX.ApplicationModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test002;
using Test002.Contracts;

namespace ClientAlice
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using(var application = new ServiceBaseApplication(args, null))
                {
                    MessageReader Bob = new MessageReader("Bob");
                    MessageReader Alice = new MessageReader("Alice");

                    RandomTextMessageSender AliceSendBob = new RandomTextMessageSender("Alice", "Bob");
                    RandomTextMessageSender BobSendAlice = new RandomTextMessageSender("Bob", "Alice");

                    Console.ReadLine();
                    AliceSendBob.stop();
                    BobSendAlice.stop();
                    //RandomTextMessageSender JackSendBob = new RandomTextMessageSender("Jack", "Bob");
                    //RandomTextMessageSender JackSendAlice = new RandomTextMessageSender("Jack", "Alice");
                    //Console.ReadLine();
                    //JackSendBob.stop();
                    //JackSendAlice.stop();
                    Bob.stop();
                    Alice.stop();

                    //MessageReciever test = new MessageReciever("Bob");
                    //TestMessage msg = test.recive();
                    //Console.WriteLine(msg);

                    //Console.ReadLine();

                }
            } catch(Exception ex)
            {
                Console.WriteLine(ex);
            }
        }
    }
}
