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
    public partial class LijekLager : Form
    {
        private readonly FZWSClient _client;

        public LijekLager(FZWSClient client)
        {
            InitializeComponent();

            _client = client;

            this.Load += LijekLager_Load;
        }

        private void LijekLager_Load(object sender, EventArgs e)
        {
            lijekLagerGridView.DataSource = _client.GetLijekoviLager();

            lijekLagerGridView.Columns[0].Width = 66;
            lijekLagerGridView.Columns[1].Width = 177;
            lijekLagerGridView.Columns[2].Width = 90;
        }
    }
}
