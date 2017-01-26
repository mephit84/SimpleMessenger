using IndraMessengerClient.Server;
using System;
using System.Collections;
using System.Collections.Generic;
using System.DirectoryServices;
using System.DirectoryServices.AccountManagement;
using System.Linq;
using System.Text;
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
        public static ArrayList GetUsedAttributes(string objectDn)
        {
            DirectoryEntry objRootDSE = new DirectoryEntry("LDAP://" + objectDn);
            ArrayList props = new ArrayList();

            foreach (string strAttrName in objRootDSE.Properties.PropertyNames)
            {
                props.Add(strAttrName);
            }
            return props;
        }

        public MainWindow()
        {
            string distinguishedName = string.Empty;
            var LdapDomain = "INDRA";

            var v = GetUsedAttributes(LdapDomain);
            string connectionPrefix = "LDAP://" + LdapDomain;
            DirectoryEntry entry = new DirectoryEntry(connectionPrefix);
            DirectorySearcher mySearcher = new DirectorySearcher(entry);
            var objectName = "vpietrantoni";
            mySearcher.Filter = "(&(objectClass=user)(objectCategory=person)(SAMAccountName=vborrelli))";

            SearchResult result = mySearcher.FindOne();

            if (result == null)
            {
                throw new NullReferenceException
                ("unable to locate the distinguishedName for the object " +
                objectName + " in the " + LdapDomain + " domain");
            }
            DirectoryEntry directoryObject = result.GetDirectoryEntry();

                distinguishedName = "LDAP://" + directoryObject.Properties
                    ["distinguishedName"].Value;
           
            entry.Close();
            entry.Dispose();
            mySearcher.Dispose();



            InitializeComponent();
            servizio = new Server.MessengerServiceClient();
            servizio.Open();
        }

        public int up(int a)
        {
            return 0;
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {

            User utente;
            utente = servizio.Login(loginTextbox.Text);

            if (utente == null)
            {
                ErrLabel.Content = "Utente non autorizzato"; 
            }
            else
            {
                email.Content = utente.Email;
                datadinascita.Content = utente.DataDiNascita;
            }
        }
    }
}
