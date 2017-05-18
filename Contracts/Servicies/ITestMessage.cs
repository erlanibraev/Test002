using NFX.Glue;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test002.Contracts.Servicies
{
    [Glued]
    public interface ITestMessage
    {
        void Send(TestMessage message);
        TestMessage Recive(string reciever);
    }
}
