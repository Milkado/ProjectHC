using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHC
{
    public partial class dashControl : UserControl
    {
        public dashControl()
        {
            InitializeComponent();
            lblUserName.Text = LoginID.name;
            this.Dock = DockStyle.Fill;
        }
    }
}
