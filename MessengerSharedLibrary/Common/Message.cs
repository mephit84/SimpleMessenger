using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace MessengerSharedLibrary.Common
{
    [DataContract]
    public class Message
    {
        [DataMember]
        public User From { get; set; }
        [DataMember]
        public User To { get; set; }
        [DataMember]
        public String Content { get; set; }
    }
}
