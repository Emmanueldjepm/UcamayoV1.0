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

        private void ReordenarInformacionToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Reindexar_archivos());

        }

        private void EmbarquesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ProductosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //AbrirForma(new Productos());

        }

        private void MovimientosESToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Movimientos());

        }

        private void AgenciaAduanalToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Agencia_aduanal());

        }

        private void LineaTrasportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirForma(new Linea_trasportadora());

        }

        private void MedidasYTamañosDeProduxtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(new Captura_de_medidas_y_tamaños_de_productos());
        }

        private void TipoDeEstibasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(new Captura_de_tipos_de_estibas__PALES_());
        }

        private void ArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void ReporteDeLiquidacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(new Reporte_liquidaciones());
        }

        private void GenerarSalidasDeArticulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirForma(new Generar_salidas_de_articulos());
        }
    }
}
