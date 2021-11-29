using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamaraNacional
{
    public partial class FormIniciarCausa : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Actor actor;
        private Abogado abogado;
        private Demandado demandado;
        private FormActor formActor;
        private FormAbogado formAbogado;
        private FormDemandado formDemandado;
        private FormAsignarJuzgado formAsignarJuzgado;
        private Form formHijoActual;

        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="causas"></param> referencia a darle al atributo causas
        /// <param name="juzgados"></param> referencia a darle al atributo juzgados
        public FormIniciarCausa(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.actor = new Actor();
            this.abogado = new Abogado();
            this.demandado = new Demandado();
            this.formActor = new FormActor(actor);
            this.formAbogado = new FormAbogado(abogado);
            this.formDemandado = new FormDemandado(demandado);
            this.formAsignarJuzgado = new FormAsignarJuzgado(causas, juzgados, actor, abogado, demandado);
        }
        /// <summary>
        /// Abrira al formulario que se le indique por parametro dentro de si mismo
        /// </summary>
        /// <param name="formHijo"></param>
        public void abrirFormularioHijo(Form formHijo)
        {
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formHijo);
            panelEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        /// <summary> ACA SE SUSCRIBEN AL EVENTO LOS MANEJADORES CORRESPONDIENTES
        /// Suscribe los eventos de los formularios a utilizar y gestiona los botones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIniciarCausa_Load(object sender, EventArgs e)
        {
            formActor.InformaQueTermino += Terminar;
            formAbogado.InformaQueTermino += Terminar;
            formDemandado.InformaQueTermino += Terminar;
            formAsignarJuzgado.InformaQueTermino += Terminar;
            btnActor.Enabled = true;
            btnAbogado.Enabled = false;
            btnDemandado.Enabled = false;
            btnJuzgado.Enabled = false;
        }
        /// <summary> ESTE METODO ES EL MANEJADOR DE LOS EVENTOS QUE VAN A INVOCAR LAS DEMAS CLASES PARA AVISAR QUE TERMINARON CON SU TAREA
        /// Controlara los botones y cierres de formularios correspondientes dependiendo el parametro recibido
        /// </summary>
        /// <param name="paso"></param> indica que accion debe realizar
        private void Terminar(int paso)
        {
            switch(paso)
            {
                case 1:
                    btnActor.Enabled = false;
                    btnAbogado.Enabled = true;
                    break;
                case 2:
                    btnAbogado.Enabled = false;
                    btnDemandado.Enabled = true;
                    break;
                case 3:
                    btnDemandado.Enabled = false;
                    btnJuzgado.Enabled = true;
                    break;
                case 4:
                    this.Close();
                    break;
            }
            
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
        }
        /// <summary>
        /// Abre el formulario FormActor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formActor);
        }
        /// <summary>
        /// Abre el formulario FormAbogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAbogado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formAbogado);
        }
        /// <summary>
        /// Abre el formulario FormDemandado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDemandado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formDemandado);
        }
        /// <summary>
        /// Abre el formulario FormJuzgado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnJuzgado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formAsignarJuzgado);
        }
        /// <summary>
        /// Permite minimizar el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Corrobora que el usuario este seguro de cerrar el formulario antes de hacerlo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblSalir_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                this.Close();
            }
        }
        /// <summary>
        /// Permite mover el formulario hacia la parte de la pantalla que se desee
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pSuperior_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
