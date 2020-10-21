using FZWS.Core;
using FZWS.Core.Models.Lager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace FZWS.ConsoleUI
{
    class Program
    {
        const string USTANOVA_ID = "******";
        const string ORG_JEDINICA = "*******";
        const string USERNAME = "*******";
        const string PASSWORD = "*******";

        static FZWSConfig _config;
        static FZWSClient _client;

        static void Main(string[] args)
        {
            ServicePointManager.Expect100Continue = true;
            ServicePointManager.SecurityProtocol = SecurityProtocolType.Tls12;

            _config = new FZWSConfig()
            {
                UstanoveId = USTANOVA_ID,
                OrgJedinicaId = ORG_JEDINICA,
                Username = USERNAME,
                Password = PASSWORD
            };

            _client = new FZWSClient(_config);

            Execute();
        }

        private static void Execute()
        {
            Console.WriteLine("============================");
            Console.WriteLine("1. SF Ustanove");
            Console.WriteLine("2. SF OrganizacioneJedinice");
            Console.WriteLine("3. SF JediniceMjere");
            Console.WriteLine("4. SF LijekoviLager");
            Console.WriteLine("5. SF Proizvodjaci");
            Console.WriteLine("6. Send Lager");

            var res = Console.ReadLine();
            var broj = 0;
            if (Int32.TryParse(res, out broj))
            {
                try
                {
                    switch (broj)
                    {
                        case 1:
                            GetUstanove();
                            break;
                        case 2:
                            GetOrganizacioneJedinice();
                            break;
                        case 3:
                            GetJediniceMjere();
                            break;
                        case 4:
                            GetLijekoviLager();
                            break;
                        case 5:
                            GetProizvodjaci();
                            break;
                        case 6:
                            SendLager();
                            break;
                    }
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Greske:");
                    Console.WriteLine(ex.Message);
                }
            }

            Console.WriteLine("============================");
            Execute();
        }

        private static void GetUstanove()
        {
            var result = _client.GetUstanove();
            PrintResult(result);
        }

        private static void GetOrganizacioneJedinice()
        {
            var result = _client.GetOrganizacioneJedinice();
            PrintResult(result);
        }

        private static void GetJediniceMjere()
        {
            var result = _client.GetJediniceMjere();
            PrintResult(result);
        }

        private static void GetLijekoviLager()
        {
            var result = _client.GetLijekoviLager();
            PrintResult(result);
        }

        private static void GetProizvodjaci()
        {
            var result = _client.GetProizvodajci();
            PrintResult(result);
        }

        private static void SendLager()
        {
            var testData = TestData();
            var result = _client.SendLager(testData);
            PrintResult(result);
        }

        private static void PrintResult(object data)
        {
            var json = Newtonsoft.Json.JsonConvert.SerializeObject(data, Newtonsoft.Json.Formatting.Indented);
            Console.Write(json);
            Console.WriteLine("============================");
        }

        private static PostLagerRequest TestData()
        {
            return new PostLagerRequest()
            {
                new Lager()
                {
                    ApotekaId = ORG_JEDINICA,
                    SifraFond = "N04BX601002",
                    Sifra = "1",
                    Naziv = "Test- Tasmar tabl.",
                    JMFond = "kut.",
                    Kolicina = 100,
                    Datum = $"{DateTime.Now:dd.MM.yyyy}"
                },
                new Lager()
                {
                    ApotekaId = ORG_JEDINICA,
                    SifraFond = "C02LA510203",
                    Sifra = "2",
                    Naziv = "Test- Brinedrin",
                    JMFond = "kut.",
                    Kolicina = 74,
                    Datum = $"{DateTime.Now:dd.MM.yyyy}"
                }
            };
        }
    }
}
