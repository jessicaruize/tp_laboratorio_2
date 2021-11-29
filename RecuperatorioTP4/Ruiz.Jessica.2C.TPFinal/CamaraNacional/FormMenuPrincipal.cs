using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamaraNacional
{
    public partial class FormMenuPrincipal : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        List<Causa> causas;
        List<Juzgado> juzgados;
        Serializador<List<Causa>> serializadorCausas;
        Serializador<List<Juzgado>> serializadorJuzgados;
        /// <summary>
        /// Constructor con parametros que instancia las listas y los serializadores xml y json
        /// </summary>
        public FormMenuPrincipal()
        {
            InitializeComponent();
            causas = new List<Causa>();
            juzgados = new List<Juzgado>();
            serializadorCausas = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
            serializadorJuzgados = new Serializador<List<Juzgado>>(IArchivos<List<Juzgado>>.ETipoArchivo.JSON);
        }
        /// <summary>
        /// Antes de cerrarse corrobora que el usuario este seguro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary> ACA SE APLICA HILOS Y DESERIALIZACION EN XML Y JSON
        /// Carga la listas con los datos que se encuentrar en archivos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMenuPrincipal_Load(object sender, EventArgs e)
        {
            Task hilo = Task.Run(CargarListas); 
        }
        /// <summary> ACA SE APLICA DESERIALIZACIÓN EN XML Y JSON
        /// CArga la listas con los datos que se encuentrar en archivos
        /// </summary>
        private void CargarListas()
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
        /// Abre el formulario que nos va a permitir iniciar una causa
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIniciarCausa_Click(object sender, EventArgs e)
        {
            FormIniciarCausa formIniciarCausa = new FormIniciarCausa(causas, juzgados);
            formIniciarCausa.Show();
        }
        /// <summary>
        /// Abre el formulario que nos va a permitir explorar causas y/o juzgados
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExplorar_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormExplorar);
            if(frm != null)
            {
                frm.BringToFront();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                FormExplorar formExplorar = new FormExplorar(causas, juzgados);
                formExplorar.Show();
            }

        }
        /// <summary>
        /// Abre el formuario que nos va a permitir visualizar las estadísticas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEstadisticas_Click(object sender, EventArgs e)
        {
            Form frm = Application.OpenForms.Cast<Form>().FirstOrDefault(x => x is FormEstadisticas);
            if(frm != null)
            {
                frm.BringToFront();
                frm.WindowState = FormWindowState.Normal;
            }
            else
            {
                FormEstadisticas formEstadicticas = new FormEstadisticas(causas);
                formEstadicticas.Show();
            }
        }
        /// <summary>
        /// Permitira mover el formulario hacia la parte de la pantalla que deseemos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        /// <summary>
        /// Permitira minimizar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
