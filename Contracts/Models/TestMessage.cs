using NFX.DataAccess.CRUD;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test002.Contracts
{
    public class TestMessage : TypedRow
    {
        [Field(required:true, maxLength:2000, description:"message")]
        public string message { get; set; }
        [Field(required: true, maxLength: 100, description: "message")]
        public string sender { get; set; }
        [Field(required: true, maxLength: 100, description: "message")]
        public string reciever { get; set; }
        [Field(required: true, kind:DataKind.DateTime, description: "message")]
        public DateTime? dob { get; set; }
    }
}
