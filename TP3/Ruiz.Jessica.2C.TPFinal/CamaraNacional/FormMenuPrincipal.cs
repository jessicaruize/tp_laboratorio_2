using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamaraNacional
{
    public partial class FormMenuPrincipal : Form
    {
        List<Causa> causas;
        List<Juzgado> juzgados;
        Serializador<List<Causa>> serializadorCausas;
        Serializador<List<Juzgado>> serializadorJuzgados;
        public FormMenuPrincipal()
        {
            InitializeComponent();
            causas = new List<Causa>();
            juzgados = new List<Juzgado>();
            serializadorCausas = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
            serializadorJuzgados = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.JSON);
        }

        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            try
            {
                causas = serializadorCausas.Leer(ArchivoTexto.ObtenerRuta("Causas.xml"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            try
            {
                juzgados = serializadorJuzgados.Leer(ArchivoTexto.ObtenerRuta("Juzgados.json"));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciarCausa_Click(object sender, EventArgs e)
        {
            FormIniciarCausa formIniciarCausa = new FormIniciarCausa(causas, juzgados);
            formIniciarCausa.Show();
        }

        private void btnExplorar_Click(object sender, EventArgs e)
        {
            FormExplorar formExplorar = new FormExplorar(causas, juzgados);
            formExplorar.Show();

        }

        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            FormEstadicticas formEstadicticas = new FormEstadicticas(causas, juzgados);
            formEstadicticas.Show();
        }
    }
}
