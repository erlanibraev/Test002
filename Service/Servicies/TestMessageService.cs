using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Test002.Contracts;
using Test002.Contracts.Servicies;

namespace Test002.Service.Servicies
{
    public class TestMessageService : ITestMessage
    {
        private List<TestMessage> messages;
        
        public TestMessageService()
        {
            messages = new List<TestMessage>();
        }

        TestMessage ITestMessage.recive(string reciever)
        {
            TestMessage result = null;
            if (reciever != null)
            {
                foreach (TestMessage message in messages)
                {
                    if (reciever == message.reciever)
                    {
                        result = message;
                        messages.Remove(message);
                        break;
                    }
                }
            }
            return result;
        }

        void ITestMessage.send(TestMessage message)
        {
            messages.Add(message);
        }
    }
}
