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
    public partial class FormInicio : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormInicio()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Abre un formulario de bienvenida y lugo el del menu principal, ocultandose, en caso de cerrar el formulario de menu principal vuelve a mostrarse
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormBienvenida formBienvenida = new FormBienvenida();
            formBienvenida.ShowDialog();
            FormMenuPrincipal formMenuPrincipal = new FormMenuPrincipal();
            formMenuPrincipal.ShowDialog();
            if(formMenuPrincipal.DialogResult == DialogResult.Cancel)
            {
                this.Show();
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
        /// <summary>
        /// Antes de cerrar el formulario pregunta al usuario si esta seguro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormInicio_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Desea cerrar el programa?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }
        /// <summary>
        /// Cierra el formulario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
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
        /// Permite mover el formulario hacia la parte de la pantalla que deseemos
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
