using MessengerSharedLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraMessengerServer
{
    class MessengerService : IMessengerService
    {
        public List<Message> GetMessageForMe(User user)
        {
            //throw new NotImplementedException();
            return new List<Message>();
        }

        public User Login(string user, string pass)
        {
            return new User();
        }

        public bool SendMessage(Message message)
        {
            return true;
        }
    }
}
