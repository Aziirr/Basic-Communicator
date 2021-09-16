using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using System.IO;

namespace Serwer
{
    class Serwer
    {
        static string adres;
        static int port;
        static TcpListener tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100));
        static List<Client> users = new List<Client>();
        static List<string> nazwy = new List<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj adres serwera: ");
            adres = Console.ReadLine();
            Console.WriteLine("Podaj port: ");
            string line = Console.ReadLine();
            try
            {
                port = int.Parse(line);
                tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse(adres), port));
                tcpListener.Start(0);
            }
            catch
            {
                tcpListener = new TcpListener(new IPEndPoint(IPAddress.Parse("127.0.0.1"), 100));
                tcpListener.Start(0);
            }

            Thread oczekiwaniaPolaczenia = new Thread(() => {
                for (; ; )
                {
                    Console.WriteLine("connected");
                    TcpClient tcpClient = tcpListener.AcceptTcpClient();
                    StreamReader streamReader = new StreamReader(tcpClient.GetStream());
                    String nazwa = streamReader.ReadLine();
                    Console.WriteLine(nazwa);
                    while (nazwy.Contains(nazwa))
                    {
                        nazwa += "_copy";
                    }
                    nazwy.Add(nazwa);
                    users.Add(new Client(ref tcpClient, ref streamReader, ref nazwa, DateTime.Now.ToString("h:mm:ss tt")));
                }
            });
            oczekiwaniaPolaczenia.Start();
        }
        
        public static void Broadcast(String msg, ref String sender)
        {
            if (msg.StartsWith("/priv"))
            {
                string[] words = msg.Split(' ');
                Client docelowy = users.SingleOrDefault(cd => cd.nick == words[1]);
                if (docelowy == null){
                    Console.WriteLine("Brak użytkownika o podanym nicku");
                }
                else
                {
                    var privMsg = string.Join(" ", msg.Split(' ').Skip(2));
                    docelowy.StreamZapis.WriteLine(" <font color='red'>Priv from</font> <b>" + sender + "</b>: " + privMsg);
                    docelowy.StreamZapis.Flush();
                }
            }
            else if ( (msg.StartsWith("/active") || msg.StartsWith("/time")) || msg.StartsWith("/nick") )
            {
                String pochodzenie = sender;
                Client docelowy = users.SingleOrDefault(cd => cd.nick == pochodzenie);
                if(msg.StartsWith("/active"))
                    docelowy.StreamZapis.WriteLine( "<br>"+string.Join("<br>", nazwy) );
                else if(msg.StartsWith("/time"))
                    docelowy.StreamZapis.WriteLine("<br>Czas zalogowania: " + docelowy.connectionTime);
                else if(msg.StartsWith("/nick"))
                    docelowy.StreamZapis.WriteLine("<br>Twój nick to: " + docelowy.nick);
                docelowy.StreamZapis.Flush();
            }
            else
            {
                foreach (Client client in users)
                {
                    client.StreamZapis.WriteLine(" <b>" + sender + "</b>: " + msg);
                    client.StreamZapis.Flush();
                };
            }
        }

        public static void Delete(Client disconnectedClient)
        {
            Console.WriteLine("Disconected");
            nazwy.Remove(disconnectedClient.nick);
            users.Remove(disconnectedClient);
            disconnectedClient.wiadomosci.Abort();
        }
    }

    class Client
    {
        public TcpClient connection;
        public Thread wiadomosci;
        public String nick;
        public String connectionTime;
        public StreamReader StreamOdczyt;
        public StreamWriter StreamZapis;

        //konstruktor clienta
        public Client(ref TcpClient newConnection, ref StreamReader newStreamOdczyt, ref String newNick, String whenConnect)
        {
            Console.WriteLine("Tworzenie Klienta");
            connection = newConnection;
            nick = newNick;
            StreamOdczyt = newStreamOdczyt;
            connectionTime = whenConnect;
            StreamZapis = new StreamWriter(connection.GetStream());

            wiadomosci= new Thread(() => {
                for (; ; )
                {
                    try
                    {
                            Serwer.Broadcast(StreamOdczyt.ReadLine(), ref nick);
                    }
                    catch 
                    { 
                        Serwer.Delete(this);
                    }
                }
            });
            wiadomosci.Start();

        }
    }
}
