using System;
using System.Collections.Generic;

namespace Esercizio4
{
    internal static class Utente
    {
        private static string _username;
        public static string Username { get { return _username; } set { _username = value; } }

        private static string _password;
        public static string Password { get { return _password; } set { _password = value; } }

        private static string _conferma;
        public static string Conferma { get { return _conferma} set { _conferma = value; } }

        static List<string> utentiLoggati = new List<string>();
        public static void Menu()
        {
            Console.WriteLine("==========================");
            Console.WriteLine("Benvenuto!!!");
            Console.WriteLine("Scegli l'operazione che vuoi effetuare");
            Console.WriteLine("1)Login");
            Console.WriteLine("2)Logout");
            Console.WriteLine("3)Verifica date e ora di accesso");
            Console.WriteLine("4)Visualizza lista degli accessi");
            Console.WriteLine("5)Vuoi uscire dall'applicazione (y/n)");
            int scelta = int.Parse(Console.ReadLine());

            switch (scelta)
            {
                case 1: Login(); break;
                case 2: Logout(); break;
                case 3: DataOra(); break;
                case 4: ListAccess(); break;
                case 5: ExitToApp(); break;
                default:
                    Console.WriteLine("Riprova, opzione non trovata");
                    Menu(); break;
            }
        }

        public static void Login()
        {
            Console.WriteLine("Inserisci la tua username");
            _username = Console.ReadLine();

            Console.WriteLine("Inserisci la tua Password");
            _password = Console.ReadLine();

            Console.WriteLine("Conferma la tua Password");
            _conferma = Console.ReadLine();

            if (_username != null || _password == _conferma)
            {
                Console.WriteLine("Accesso consentito");
                utentiLoggati.Add(_username);
                Menu();
            }
            else
            {
                Console.WriteLine("Le password non corrispondono");
            }

        }

        public static void Logout()
        {
            if (_username != null && _password != null)
            {
                _username = null; _password = null; _conferma = null;
                Console.WriteLine("Ciao Ciao");
            }
        }



        public static void ListAccess()
        {
            if (string.IsNullOrEmpty(_username))
            {
                Console.WriteLine("Lista vuota");
                Menu();
            }
            else
            {
                foreach (var utente in utentiLoggati)
                {
                    Console.WriteLine(utente);
                    Menu();
                }
            }

        }

        public static void DataOra()
        {

        }
    }


}
