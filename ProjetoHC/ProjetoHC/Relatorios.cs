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
    public partial class Relatorios : UserControl
    {
        public Relatorios()
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            tblLayoutTop.Dock = DockStyle.Top;
            panelBottom.Dock = DockStyle.Bottom;
            dgvRelatorio.Dock = DockStyle.Fill;
            
        }
    }
}
