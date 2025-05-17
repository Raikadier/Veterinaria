using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmPrincipal: Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void gestionarEspeciesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new Frm_Especie());
        }

        private void AbrirFormulario(Form frm)
        {
            frm.StartPosition = FormStartPosition.CenterParent;
            frm.ShowDialog();
        }

        private void gestionarRazasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmRaza());
        }

        private void SalirtoolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            tslabelFecha.Text = tslabelFecha.Text + DateTime.Now.ToShortDateString();
        }

        private void FrmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("desea salir","salir de l app",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                e.Cancel = false;
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.BackColor = Color.Red;
        }
    }
}
