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
    public partial class JedMjere : Form
    {
        private readonly FZWSClient _client;

        public JedMjere(FZWSClient client)
        {
            InitializeComponent();

            _client = client;

            this.Load += JedMjere_Load;
        }

        private void JedMjere_Load(object sender, EventArgs e)
        {
            jedMjereGridView.DataSource = _client.GetJediniceMjere();

            jedMjereGridView.Columns[0].Width = 66;
            jedMjereGridView.Columns[1].Width = 177;
            jedMjereGridView.Columns[2].Width = 90;
        }
    }
}
