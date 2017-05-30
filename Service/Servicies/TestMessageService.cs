using NFX;
using NFX.DataAccess.CRUD;
using NFX.DataAccess.MySQL;
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
        public static MySQLDataStore DataStore
        {
            get
            {
                return App.DataStore as MySQLDataStore;
            }
        }


        public TestMessage Recive(string reciever)
        {
            var query = new Query("Data.Scripts.GetLastMessage", typeof(TestMessage))
            {
                new Query.Param("reciever", reciever)
            } ;
            TestMessage result = DataStore.LoadOneRow(query) as TestMessage;
            if (result != null)
            {
                result.readed = "true";
                DataStore.Upsert(result);
                Console.WriteLine("recieved - " + result.ToString());

            } else
            {
                Console.WriteLine("Not readed message for "+reciever+" not found!" );
            }
            return result;
        }

        public void Send(TestMessage message)
        {
            if (message != null)
            {
                if(message.dob == null)
                {
                    message.ID = Guid.NewGuid().ToString("N");
                    message.readed = "false";
                    message.dob = DateTime.Now;
                }
                DataStore.Upsert(message);
                Console.WriteLine("sended - " + message.ToString());
            }
        }
    }
}
