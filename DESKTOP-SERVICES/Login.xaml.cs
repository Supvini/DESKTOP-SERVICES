using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;
using System.IO;
using DESKTOP_SERVICES.Helpers;
using DESKTOP_SERVICES.Model;
using System.Text.RegularExpressions;
using System.Windows.Navigation;
using System.Threading;
using System.DirectoryServices;

namespace DESKTOP_SERVICES
{
    /// <summary>
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        protected String folderName = @"c:\SERVICES";
        protected String fileName = @"c:\SERVICES\auth.txt";
        protected String securityKey = "mdsi@";
        HelperSecurity HSecurity = new HelperSecurity();
        SERVICES20Entities BDD = new SERVICES20Entities();
        int USERID = 0;
        string USERNAME = "";
        string USERPASSWORD = "";
        System.Windows.Threading.DispatcherTimer dispatcherTimer = new System.Windows.Threading.DispatcherTimer();


        public Login()
        {
            InitializeComponent();

            ProgBar.Visibility = System.Windows.Visibility.Visible;

            // Thread sleep
            dispatcherTimer.Tick += new EventHandler(dispatcherTimer_Tick);
            dispatcherTimer.Interval = new TimeSpan(0, 0, 1);
            dispatcherTimer.Start();

        }

        private void dispatcherTimer_Tick(object sender, EventArgs e)
        {
            dispatcherTimer.Stop();
            ProgBar.Visibility = System.Windows.Visibility.Hidden;

            if (checkCookie())
            {
                ProgBar.Visibility = System.Windows.Visibility.Hidden;
                redir();
            }

        }

        private bool checkCookie()
        {
            // verification si le fichier Auth Existe
            try
            {
                if (Directory.Exists(folderName))
                {
                    if (File.Exists(fileName))
                    {
                        string line;
                        string contenuFichier = "";
                        System.IO.StreamReader file = new System.IO.StreamReader(fileName);
                        while ((line = file.ReadLine()) != null) contenuFichier += line;
                        file.Close();

                        var decrypt = HSecurity.Decrypt(contenuFichier, securityKey);

                        if (decrypt != string.Empty)
                        {
                            var tab = Regex.Split(decrypt, "###");

                            var _username = tab[1];
                            var _password = tab[2];

                            bool auth = AuthenticateUser(_username, _password);

                            if (auth == true)
                            {
                                generateSession();
                                return true;
                            }
                        }
                    }
                }

            }
            catch (Exception ee) { }

            return false;
        }

        private void Validate_Click(object sender, RoutedEventArgs e)
        {
            ProgBar.Visibility = System.Windows.Visibility.Visible;

            bool auth = AuthenticateUser(txt_login.Text, txt_password.Password);
            if (auth == true)
            {
                bool ret = true;
                if (generateSession() == false) ret = false;
                if (generateCookie() == false) ret = false;

                if (ret == true) redir();
            }

            ProgBar.Visibility = System.Windows.Visibility.Hidden;
        }

        public bool AuthenticateUser(string _username, string _password)
        {
            bool ret = false;

            try
            {
                DirectoryEntry de = new DirectoryEntry("LDAP://mdsi.local", _username, _password);
                DirectorySearcher dsearch = new DirectorySearcher(de);
                SearchResult results = null;

                results = dsearch.FindOne();

                ret = true;

            }
            catch
            {
                ret = false;
            }


            if (ret == true)
            {
                USERNAME = _username.ToLower(); // ***
                if (!USERNAME.Contains(@"mdsi\")) USERNAME = @"mdsi\" + USERNAME;

                USERPASSWORD = _password;   // ***

                var itemUser = (from p in BDD.Utilisateur where p.SQL_ID == USERNAME && p.Actif == 1 select p).FirstOrDefault();

                if (itemUser != null)
                {
                    USERID = itemUser.Id;   // ***
                }
                else ret = false;
            }
            else txt_rtn.Text = "Mauvais login/mot de passe.";

            return ret;
        }

        private bool generateSession()
        {
            try
            {

                // **************************************************** SESSION
                HelperSession.SetValue("USERID", USERID);
                HelperSession.SetValue("USERNAME", USERNAME);
                // ****************************************************

                return true;
            }
            catch (Exception ee)
            {
                txt_rtn.Text = "Une erreur est survenue.\n";
                txt_rtn.Text = "Détails : " + ee.ToString();
            }

            return false;
        }

        private bool generateCookie()
        {
            try
            {
                // creation du dossier C:\SERVICES si il nexiste pas 
                if (!Directory.Exists(folderName)) Directory.CreateDirectory(folderName);

                // creation du fichier C:\SERVICES\Auth
                if (File.Exists(fileName)) File.Delete(fileName);

                string CONCAT_VALUE = HSecurity.Encrypt(USERID + "###" + USERNAME + "###" + USERPASSWORD, securityKey);

                System.IO.File.WriteAllText(fileName, CONCAT_VALUE);

                return true;
            }
            catch (Exception ee)
            {
                txt_rtn.Text = "Une erreur est survenue.\n";
                txt_rtn.Text = "Détails : " + ee.ToString();
            }

            return false;
        }

        private void redir()
        {
            MainWindow window = new MainWindow();
            window.Show();
            this.Close();
        }
    }
}
