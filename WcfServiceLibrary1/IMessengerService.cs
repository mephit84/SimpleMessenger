using MessengerSharedLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace IndraMessengerService
{
    // NOTA: è possibile utilizzare il comando "Rinomina" del menu "Refactoring" per modificare il nome di interfaccia "IService1" nel codice e nel file di configurazione contemporaneamente.
    [ServiceContract]
    public interface IMessengerService
    {
        [OperationContract]
        User Login(string username);

        [OperationContract]
        List<Message> GetMessageForMe(User user);

        [OperationContract]
        void SendMessage(Message message);

        [OperationContract]
        List<User> GetUtentiLoggati();


        // TODO: aggiungere qui le operazioni del servizio
    }
    
}
