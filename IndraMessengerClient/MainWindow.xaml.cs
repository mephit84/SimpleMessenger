using IndraMessengerClient.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace IndraMessengerClient
{
    /// <summary>
    /// Logica di interazione per MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Server.MessengerServiceClient servizio;
        User utente;
        public MainWindow()
        {
            //string distinguishedName = string.Empty;
            //var LdapDomain = "INDRA";

            //var v = GetUsedAttributes(LdapDomain);
            //string connectionPrefix = "LDAP://" + LdapDomain;
            //DirectoryEntry entry = new DirectoryEntry(connectionPrefix);
            //DirectorySearcher mySearcher = new DirectorySearcher(entry);
            //var objectName = "vpietrantoni";
            //mySearcher.Filter = "(&(objectClass=user)(objectCategory=person)(SAMAccountName=vborrelli))";

            //SearchResult result = mySearcher.FindOne();

            //if (result == null)
            //{
            //    throw new NullReferenceException
            //    ("unable to locate the distinguishedName for the object " +
            //    objectName + " in the " + LdapDomain + " domain");
            //}
            //DirectoryEntry directoryObject = result.GetDirectoryEntry();

            //    distinguishedName = "LDAP://" + directoryObject.Properties
            //        ["distinguishedName"].Value;

            //entry.Close();
            //entry.Dispose();
            //mySearcher.Dispose();



            InitializeComponent();
            servizio = new Server.MessengerServiceClient();
            servizio.Open();

            BackgroundWorker getMessagesWorker = new BackgroundWorker();
            getMessagesWorker.DoWork += GetMessagesWorker_DoWork;
            getMessagesWorker.RunWorkerAsync();

            listaUtentiLoggati.Visibility = Visibility.Hidden;
            sendButton.Visibility = Visibility.Hidden;
            recuperaUtentiButton.Visibility = Visibility.Hidden;
            textBoxMessage.Visibility = Visibility.Hidden;
            messaggi.Visibility = Visibility.Hidden;

        }

        private void GetMessagesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
           
            while (true)
            {
                Thread.Sleep(1000);
                var messaggiperme= servizio.GetMessageForMe(utente);
                Dispatcher.Invoke((Action)delegate
                {
                    messaggi.Text = "";



                    foreach (Message messaggio in messaggiperme)
                    {
                    
                        messaggi.Text += "\n Da:" + messaggio.From.Username + " - " + messaggio.Content;
                   
                    }

                });
            }
            //Recupera i messaggi
        }
        
        private void loginButton_Click(object sender, RoutedEventArgs e)
        {

           
            utente = servizio.Login(loginTextbox.Text);

            if (utente == null)
            {
                ErrLabel.Content = "Utente non autorizzato";
                email.Content = " ";
                datadinascita.Content = " ";
            }
            else
            {
                email.Content = utente.Email;
                datadinascita.Content = utente.DataDiNascita;
                loginButton.IsEnabled = false;
                listaUtentiLoggati.Visibility = Visibility.Visible;
                sendButton.Visibility = Visibility.Visible;
                recuperaUtentiButton.Visibility = Visibility.Visible;
                textBoxMessage.Visibility = Visibility.Visible;
                messaggi.Visibility = Visibility.Visible;
            }
        }

        private void sendButton_Click(object sender, RoutedEventArgs e)
        {
            
            User SelectUser = ((User)listaUtentiLoggati.SelectedItem);
            if (SelectUser != null)
            {

                Message messaggio = new Message();

            messaggio.Content = textBoxMessage.Text;

            messaggio.To = SelectUser;
            messaggio.From = utente;

            servizio.SendMessage(messaggio);
            }
            //Invia il messaggio che sta nella textbox
        }

        private void recuperaUtentiButton_Click(object sender, RoutedEventArgs e)
        {
            //recupera utenti e li mostra nella lista
            var ut = servizio.GetUtentiLoggati();
            listaUtentiLoggati.ItemsSource = null;
            listaUtentiLoggati.ItemsSource = ut;
        }
    }
}
