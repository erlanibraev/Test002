using NFX.DataAccess.CRUD;
using NFX.RelationalModel.DataTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test002.Contracts
{
    public class TestMessage : TypedRow
    {
        [Field(key: true, required: true)]
        public string ID { get; set; }
        [Field(required:true, maxLength:2000, description:"message")]
        public string message { get; set; }
        [Field(required: true, maxLength: 100, description: "message")]
        public string sender { get; set; }
        [Field(required: true, maxLength: 100, description: "message")]
        public string reciever { get; set; }
        [Field(required: true, kind:DataKind.DateTime, description: "message")]
        public DateTime? dob { get; set; }
        [Field(required: false, description: "message"), ]
        public string readed { get; set; }

        public override string ToString()
        {
            return "[" + dob.ToString() + "] " + sender + " => " + reciever + " (" + (readed=="true" ? "readed" : "not readed") + ") : "+message;
        }
    }
}
