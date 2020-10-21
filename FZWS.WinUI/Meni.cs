using FZWS.Core;
using FZWS.Core.Models.Lager;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FZWS.WinUI
{
    public partial class Meni : Form
    {
        const string USTANOVA_ID = "******";
        const string ORG_JEDINICA = "******";
        const string USERNAME = "******";
        const string PASSWORD = "******";

        private FZWSConfig _config;
        private FZWSClient _client;

        public Meni()
        {
            InitializeComponent();

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
        }

        private void ustanoveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Ustanove ustanove = new Ustanove(_client);
            ustanove.Show();
        }

        private void organizacioneJediniceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OrgJedinice orgJedinice = new OrgJedinice(_client);
            orgJedinice.Show();
        }

        private void jediniceMjereToolStripMenuItem_Click(object sender, EventArgs e)
        {
            JedMjere jedMjere = new JedMjere(_client);
            jedMjere.Show();
        }

        private void lijekoviLagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LijekLager lijekLager = new LijekLager(_client);
            lijekLager.Show();
        }

        private void proizvodjaciToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Proizvodjaci proizvodjaci = new Proizvodjaci(_client);
            proizvodjaci.Show();
        }

        private void posaljiLagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var testData = TestData();
            var result = _client.SendLager(testData);
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
