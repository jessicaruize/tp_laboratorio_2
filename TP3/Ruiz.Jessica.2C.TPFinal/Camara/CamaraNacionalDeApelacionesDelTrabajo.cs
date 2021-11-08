using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace Camara
{
    public partial class FormCamaraNacionalDeApelacionesDelTrabajo : Form
    {
        List<Causa> causas;
        List<Juzgado> juzgados;
        Serializador<List<Causa>> serializadorCausas;
        Serializador<List<Juzgado>> serializadorJuzgados;
        /// <summary>
        /// Constructor sin parametros que inicializa los componentes del form e instancia las listas causas, juzgados e instancia a los serializadores serializadorCausas y serializadorJuzgados
        /// </summary>
        public FormCamaraNacionalDeApelacionesDelTrabajo()
        {
            InitializeComponent();
            causas = new List<Causa>();
            juzgados = new List<Juzgado>();
            serializadorCausas = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
            serializadorJuzgados = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.JSON);
        }
        /// <summary>
        /// Abre el formulario FormIniciarCausa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnInicioCausa_Click(object sender, EventArgs e)
        {
            FormIniciarCausa frmIniciarCausa = new FormIniciarCausa(causas, juzgados);
            frmIniciarCausa.ShowDialog();
        }
        /// <summary>
        /// Abre el formulario VisualizarCausa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVisualizarCausa_Click(object sender, EventArgs e)
        {
            FormVisualizarCausas frmVisualizarCausas = new FormVisualizarCausas(causas, juzgados);
            frmVisualizarCausas.ShowDialog();
        }
        /// <summary>
        /// Deserializa los archivos contenidos en la ruta del programa para obtener las listas de juzgados y causas.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCamaraNacionalDeApelacionesDelTrabajo_Load(object sender, EventArgs e)
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
        /// <summary>
        /// Antes de cerrar corrobora que se este seguro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCamaraNacionalDeApelacionesDelTrabajo_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
