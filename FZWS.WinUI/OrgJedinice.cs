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
    public partial class OrgJedinice : Form
    {
        private readonly FZWSClient _client;

        public OrgJedinice(FZWSClient client)
        {
            InitializeComponent();

            _client = client;

            this.Load += OrgJedinice_Load;
        }

        private void OrgJedinice_Load(object sender, EventArgs e)
        {
            ordJediniceGridView.DataSource = _client.GetOrganizacioneJedinice();

            ordJediniceGridView.Columns[0].Width = 66;
            ordJediniceGridView.Columns[1].Width = 314;
            ordJediniceGridView.Columns[2].Width = 90;
        }
    }
}
