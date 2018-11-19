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
using Bunifu.Framework;

namespace ProjetoHC
{
      
    public partial class FrmMenu : Form
    {
        
        public FrmMenu()
        {
            InitializeComponent();
            userAdmin();
            container.Controls.Add(dashControl);
            Icon = GlobalImages.icon;
        }
        dashControl dashControl = new dashControl();
        Relatorios Relatorios = new Relatorios();
        GrupoControl grupo = new GrupoControl();
        
        void userAdmin()
        {
            
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

        private void FrmMenu_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void FrmMenu_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void FrmMenu_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            Application.Exit();
        }

        private void sidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonGrupo_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(grupo);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void buttonModali_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmModalidade frmModalidade = new FrmModalidade();
            frmModalidade.Show();
        }

        private void buttonAtivdade_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmAtivCom frm = new FrmAtivCom();
            frm.Show();
        }

        private void buttonRelatorio_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(Relatorios);
        }

        private void buttonUser_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmUsuario frmUsuario = new FrmUsuario();
            frmUsuario.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            container.Controls.Clear();
            container.Controls.Add(dashControl);
        }

        private void buttonLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmLogar frmLogar = new FrmLogar();
            frmLogar.Show();
        }
    }
}
