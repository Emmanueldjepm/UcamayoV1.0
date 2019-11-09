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

        private void CultivosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (this.PanelPrincipal.Controls.Count > 0)
            {
                this.PanelPrincipal.Controls.RemoveAt(0);
                Cultivos Culti = new Cultivos();
                Culti.TopLevel = false;
                Culti.Dock = DockStyle.Fill;
                this.PanelPrincipal.Controls.Add(Culti);
                this.PanelPrincipal.Tag = Culti;
                Culti.Show();


                c.Show();
            }

        }
    }
}
