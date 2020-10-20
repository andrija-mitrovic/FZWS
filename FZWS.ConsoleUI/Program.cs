using FZWS.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FZWS.ConsoleUI
{
    class Program
    {
        const string USTANOVA_ID = "**";
        const string ORG_JEDINICA = "**";
        const string USERNAME = "zalihe13";
        const string PASSWORD = "8TRbXMK$dn5iy-+L";

        static FZWSConfig _config;

        static void Main(string[] args)
        {
            _config = new FZWSConfig()
            {
                UstanoveId = USTANOVA_ID,
                OrgJedinicaId = ORG_JEDINICA,
                Username = USERNAME,
                Password = PASSWORD
            };

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
            Console.WriteLine("6. Post lager");

            var res = Console.ReadLine();
            var broj = 0;
            if (Int32.TryParse(res, out broj))
            {
                try
                {

                }
                catch(Exception ex)
                {
                    Console.WriteLine("Greske:");
                    Console.WriteLine(ex.Message);
                }
            }
        }

        
    }
}
