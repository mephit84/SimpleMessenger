using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessengerSharedLibrary.Common
{
    [DataContract]
    public class User
    {
        [DataMember]
        public string Username { get; set; }
        [DataMember]
        public DateTime DataDiNascita { get; set; }
        [DataMember]
        public string Email { get; set; }
    }
}
