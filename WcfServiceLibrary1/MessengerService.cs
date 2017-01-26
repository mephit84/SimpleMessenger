using MessengerSharedLibrary.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndraMessengerService
{
    class MessengerService : IMessengerService
    {
        private List<User> _AuthorizedUsers;
        private List<User> _LoggedUsers;
        private List<Message> _Messaggi;

        public MessengerService()
        {
            _Messaggi = new List<Message>() ;
            _LoggedUsers = new List<User>();

            _AuthorizedUsers = GetAuthorizedUsers();
        }

        /// <summary>
        /// Restituisce una lista di utenti autorizzati
        /// </summary>
        /// <returns></returns>
        private List<User> GetAuthorizedUsers()
        {
            List<User> lista = new List<User>();
            User Andrea = new User();
            Andrea.Username = "Andrea";
            Andrea.DataDiNascita = DateTime.Today.AddDays(-1);
            Andrea.Email = "Andrea@email.it";

            User Giuseppe = new User();
            User Flavio = new User();


            Giuseppe.Username = "Giuseppe";
            Giuseppe.DataDiNascita = DateTime.Today.AddDays(-1);
            Giuseppe.Email = "Giuseppe@email.it";

            Flavio.Username = "Flavio";
            Flavio.DataDiNascita = DateTime.Today.AddDays(-1);
            Flavio.Email = "Flavio@email.it";

            lista.Add(Andrea);
            lista.Add(Giuseppe);
            lista.Add(Flavio);

            return lista;
            //Creare una lista di utenti e restituirla
            //Inserire i seguenti utenti inventandone i campi:
            /*
             * Andrea
             * Silvia
             * Giuseppe
             * Fiorello
             * Angela
             * Vincenzo
             * Marta
             * Flavio
             * Lucia
             * Karrar
             * Valerio
             * */
            return null;
        }
        
        /// <summary>
        /// Ritorna i messaggi da inviare all'utente corrispondente
        /// (dove TO nel messaggio è uguale a USER
        /// </summary>
        /// <param name="user">L'utente che richiede i messaggi per se</param>
        /// <returns>La lista dei messaggi per l'utente</returns>
        public List<Message> GetMessageForMe(User user)
        {

            List<Message> MessageUser = new List<Message>();
            //throw new NotImplementedException();
            for (int i=0; i<_Messaggi.Count; i++)
            {
                if ((_Messaggi.ElementAt(i).To==(user)))
                {
                    ///MessageUser.ElementAt(i) = _Messaggi.ElementAt(i);
                }

            }

            return MessageUser;
        }

        /// <summary>
        /// ritorna la l'utente cercandolo nella lista degli utenti autorizzati  (_AuthorizedUsers)
        /// E aggiunge l'utente (se trovato) nella lista degli utenti loggati
        /// </summary>
        /// <param name="username">Il nome utente da controllare</param>
        /// <returns>Ritorna l'utente se trovato, null altrimenti</returns>
        public User Login(string username)
        {

            //ritorna la l'utente cercandolo nella lista degli utenti autorizzati  (_AuthorizedUsers)


            return null;
        }

        /// <summary>
        /// Aggiunge il messaggio alla lista dei messaggi  (_Messaggi)
        /// </summary>
        /// <param name="message">Il messaggio da aggiungere</param>
        public void SendMessage(Message message)
        {

            _Messaggi.Add(message);

        }

        /// <summary>
        /// Restituisce la lista degli utenti loggati
        /// </summary>
        /// <returns></returns>
        public List<User> GetUtentiLoggati()
        { 
            //throw new NotImplementedException();
            List<User> Loggati = new List<User>();

            //list User =    Login(string username)r 
              
            foreach (var item in _LoggedUsers)
            {
                
                    Loggati.Add(item);                    

            }
            return Loggati;
        }
    }
}
