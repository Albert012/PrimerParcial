using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PrimerParcial.UI.Consultas;
using PrimerParcial.UI.Registros;

namespace PrimerParcial
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            rRegistro registro = new rRegistro();
            registro.MdiParent = this.MdiParent;
            registro.ShowDialog();

        }

        private void consultaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            cConsulta consulta = new cConsulta();
            consulta.MdiParent = this.MdiParent;
            consulta.ShowDialog();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esperamos Que Vuelva!!", "Salida Del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            this.Close();
        }
    }
}
