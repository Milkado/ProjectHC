using ProjetoHC.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoHC
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            userAdmin();
        }

        void userAdmin()
        {
            if(LoginID.UserID == "admin")
            {
                pctBoxChange.Image = GlobalImages.unlocked_image;
          
            }else
            {
                pctBoxChange.Image = GlobalImages.locked;
                lblBlocked.Visible = true;
            }         
        }

        private void btnTelaModal_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModalidade frmModalidade = new FrmModalidade();
            frmModalidade.Show();
             
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
         
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogar frmLogar = new FrmLogar();
            frmLogar.Show();
        }

        private void btnTelaGrupo_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmGrupo frmGrupo = new FrmGrupo();
            frmGrupo.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void btnAC_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAtivCom frmAtivCom = new FrmAtivCom();
            frmAtivCom.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmRelatorios frmRelatorios = new FrmRelatorios();
            frmRelatorios.Show();
        }
    }
}
