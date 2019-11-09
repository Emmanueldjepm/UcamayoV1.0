using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ucamayo_V._01
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void UtileriasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void AbrirForma(object Formulario)
        {
            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
            }

            Form FH = Formulario as Form;
            FH.TopLevel = false;
            FH.Dock = DockStyle.Fill;
            this.PanelPrincipal.Controls.Add(FH);
            this.PanelPrincipal.Tag = FH;
            FH.Show();
            }

        private void CultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Cultivos());

        }

        private void ClientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Clientes());

        }

        private void DatosDeEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Datos_de_la_empresa());

        }
    }
}
