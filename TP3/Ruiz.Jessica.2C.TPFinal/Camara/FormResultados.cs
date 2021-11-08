using Entidades;
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

namespace Camara
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
        /// <summary>
        /// Filtra lo que va a escribir en el rtbInformacion dependiendo del formulario que llamo a este formulario y la informacion que le paso.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormResultados_Load(object sender, EventArgs e)
        {
            switch(this.identificador)
            {
                case EIdentificadorDeFormulario.IniciarCausa:
                    rtbInformacion.Text = causas.Last().MostrarDatos();
                    break;
                case EIdentificadorDeFormulario.VisualizarCausas:
                    rtbInformacion.Text = $"\n\t\t\tCAUSAS FILTRADAS\n\nCANTIDAD: {causas.Count}\n\n";
                    foreach (Causa item in causas)
                    {
                        rtbInformacion.Text += item.MostrarDatos();
                        rtbInformacion.Text += "\n\n\t--------------------------------------------------------------------------------------------\n\n";
                    }
                    break;
                case EIdentificadorDeFormulario.MostrarJuzgados:
                    rtbInformacion.Text = $"\n\t\t\tJUZGADOS\n\nCANTIDAD: {juzgados.Count}\n\n\n";
                    foreach (Juzgado item in juzgados)
                    {
                        rtbInformacion.Text += item.MostrarDatos();
                        rtbInformacion.Text += "\n\n\t---------------------------------------------------------------------------------------------\n\n";
                    }
                    break;
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
        private void tsmiArchivoXML_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog(".xml");
        }
        /// <summary>
        /// Serializa en JSON los juzgados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiArchivoJSON_Click(object sender, EventArgs e)
        {
            GuardarArchivoFileDialog(".json");
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
        /// Corrobora si se esta seguro antes de salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormResultados_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¡Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Corrobora si esta seguro al momento de salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
                archivoTexto.Escribir(rtbInformacion.Text, ruta);
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
    }
}
