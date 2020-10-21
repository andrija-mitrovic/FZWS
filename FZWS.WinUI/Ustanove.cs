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
    public partial class Ustanove : Form
    {
        private readonly FZWSClient _client;

        public Ustanove(FZWSClient client)
        {
            InitializeComponent();

            _client = client;

            this.Load += Ustanove_Load;
        }

        private void Ustanove_Load(object sender, EventArgs e)
        {
            ustanoveGridView.DataSource = _client.GetUstanove();

            ustanoveGridView.Columns[0].Width = 66;
            ustanoveGridView.Columns[1].Width = 370;
            ustanoveGridView.Columns[2].Width = 90;
            ustanoveGridView.Columns[3].Width = 50;
        }
    }
}
