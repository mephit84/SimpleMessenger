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
        public override bool Equals(object obj)
        {
            if (obj is User)
            {
                return ((User)obj).Username == this.Username;
            }
            else
                return false;

            //return base.Equals(obj);
        }

        public override string ToString()
        {
            return Username;

        }

    }
}
