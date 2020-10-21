using FZWS.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FZWS.WinUI
{
    public partial class Proizvodjaci : Form
    {
        private readonly FZWSClient _client;

        public Proizvodjaci(FZWSClient client)
        {
            InitializeComponent();

            _client = client;

            this.Load += Proizvodjaci_Load;
        }

        private void Proizvodjaci_Load(object sender, EventArgs e)
        {
            proizvodjaciGridView.DataSource = _client.GetProizvodajci();

            proizvodjaciGridView.Columns[0].Width = 66;
            proizvodjaciGridView.Columns[1].Width = 177;
            proizvodjaciGridView.Columns[2].Width = 90;
        }
    }
}
