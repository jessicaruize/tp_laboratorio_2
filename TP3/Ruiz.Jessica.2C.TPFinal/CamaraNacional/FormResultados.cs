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
    public partial class FormResultados : Form
    {
        public enum EIdentificadorDeFormulario { IniciarCausa, VisualizarCausas, MostrarJuzgados };
        List<Causa> causas;
        List<Juzgado> juzgados;
        EIdentificadorDeFormulario identificador;
        string archivo;
        SaveFileDialog saveFileDialog;
        /// <summary>
        /// Constructor con parámetros que instancian el saveFileDialog y asigna los valores recibidos a los atributos correspondientes.
        /// </summary>
        public FormResultados(List<Causa> causas, List<Juzgado> juzgados, EIdentificadorDeFormulario identificador)
        {
            InitializeComponent();
            saveFileDialog = new SaveFileDialog();
            this.juzgados = juzgados;
            this.causas = causas;
            this.identificador = identificador;
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            switch (this.identificador)
            {
                case EIdentificadorDeFormulario.IniciarCausa:
                    rtbResultados.Text = causas.Last().MostrarDatos();
                    break;
                case EIdentificadorDeFormulario.VisualizarCausas:
                    rtbResultados.Text = $"\n\t\t\tCAUSAS FILTRADAS\n\nCANTIDAD: {causas.Count}\n\n";
                    foreach (Causa item in causas)
                    {
                        rtbResultados.Text += item.MostrarDatos();
                        rtbResultados.Text += "\n\n\t--------------------------------------------------------------------------------------------\n\n";
                    }
                    break;
                case EIdentificadorDeFormulario.MostrarJuzgados:
                    rtbResultados.Text = $"\n\t\t\tJUZGADOS\n\nCANTIDAD: {juzgados.Count}\n\n\n";
                    foreach (Juzgado item in juzgados)
                    {
                        rtbResultados.Text += item.MostrarDatos();
                        rtbResultados.Text += "\n\n\t---------------------------------------------------------------------------------------------\n\n";
                    }
                    break;
            }
        }
        /// <summary>
        /// Guarda el archivo.
        /// </summary>
        /// <param name="extension"></param>
        private void GuardarArchivoFileDialog(string extension)
        {
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                archivo = saveFileDialog.FileName;
                GuardarArchivo(archivo, extension);
            }
        }
        /// <summary>
        /// Filtra por extension y guarda los archivos segùn corresponda.
        /// </summary>
        /// <param name="ruta"></param>
        /// <param name="extension"></param>
        private void GuardarArchivo(string ruta, string extension)
        {
            switch (extension)
            {
                case ".txt":
                    GuardarEnArchivoTxt(ruta);
                    break;
                case ".xml":
                    GuardarEnXML(ruta);
                    break;
                case ".json":
                    GuardarEnJSON(ruta);
                    break;
            }
        }
        /// <summary>
        /// Guarda en la ruta recibida un archivo de texto con la informacion que hay en rtbInformacion.
        /// </summary>
        /// <param name="ruta"></param>
        private void GuardarEnArchivoTxt(string ruta)
        {
            ArchivoTexto archivoTexto = new ArchivoTexto();
            try
            {
                archivoTexto.Escribir(rtbResultados.Text, ruta);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Serializa la informacion segun corresponda en xml.
        /// </summary>
        /// <param name="ruta"></param>
        private void GuardarEnXML(string ruta)
        {
            switch (this.identificador)
            {
                case EIdentificadorDeFormulario.IniciarCausa:
                    Serializador<Causa> serializadorCausa = new Serializador<Causa>(IArchivos<Causa>.ETipoArchivo.XML);
                    try
                    {
                        serializadorCausa.Escribir(causas.Last(), ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EIdentificadorDeFormulario.VisualizarCausas:
                    Serializador<List<Causa>> serializadorCausas = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
                    try
                    {
                        serializadorCausas.Escribir(causas, ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case EIdentificadorDeFormulario.MostrarJuzgados:
                    Serializador<List<Juzgado>> serializadorJuzgadosAux = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.XML);
                    try
                    {
                        serializadorJuzgadosAux.Escribir(juzgados, ruta);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
            }
        }
        /// <summary>
        /// Serializa en JSON si corresponde los juzgados.
        /// </summary>
        /// <param name="ruta"></param>
        private void GuardarEnJSON(string ruta)
        {
            Serializador<List<Juzgado>> serializadorJuzgados = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.JSON);
            if (EIdentificadorDeFormulario.MostrarJuzgados == this.identificador)
            {
                try
                {
                    serializadorJuzgados.Escribir(juzgados, ruta);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Solo se puede guardar en archivos .JSON la lista de juzgados");
            }
        }
        /// <summary>
        /// Guarda en archivo de texto lo que se encuentra en el rtbInformacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archivoDeTextoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog(".txt");
        }
        /// <summary>
        /// serializa en XML la informacion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void archivoXMLToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog(".xml");
        }

        private void archivoJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog(".json");
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
            else
            {
                this.DialogResult = DialogResult.Yes;
            }
        }
    }
}
