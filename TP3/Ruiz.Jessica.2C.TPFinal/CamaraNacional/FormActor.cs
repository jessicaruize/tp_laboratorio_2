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
    public delegate void Termine(int paso);
    public partial class FormActor : Form
    {
        public event Termine termino;
        Actor actor;
        public FormActor(Actor actor)
        {
            InitializeComponent();
            this.actor = actor;
        }

        private void FormActor_Load(object sender, EventArgs e)
        {
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Actor.Genero));

        }

        private void BorrarMensajesDeError()
        {
            epFechaNacimiento.SetError(dtpFechaNacimiento, "");
            epNombreYApellido.SetError(txtNombreYApellido, "");
            epDireccion.SetError(txtDireccion, "");
            epDNI.SetError(txtDNI, "");
        }
        private bool ValidarInformacion()
        {
            bool correcto = true;
            if (dtpFechaNacimiento.Value.CompareTo(DateTime.Now.AddYears(-18)) > 0)
            {
                epFechaNacimiento.SetError(dtpFechaNacimiento, "Error, Debe ser mayor a 18 años.");
                correcto = false;
            }
            if (txtNombreYApellido.Text == "")
            {
                epNombreYApellido.SetError(txtNombreYApellido, "Ingrese nombre del actor");
                correcto = false;
            }
            if (txtDireccion.Text == "")
            {
                epDireccion.SetError(txtDireccion, "Ingrese direcciòn del actor");
                correcto = false;
            }
            if (txtDNI.Text == "")
            {
                epDNI.SetError(txtDNI, "Ingrese DNI del actor");
                correcto = false;
            }
            return correcto;
        }
        private void CargarDatos()
        {
            this.actor.Nombre = txtNombreYApellido.Text;
            this.actor.NumeroIdentificacion = long.Parse(txtDNI.Text);
            this.actor.GeneroActor = (Actor.Genero)this.cmbGenero.SelectedItem;
            this.actor.FechaNacimiento = dtpFechaNacimiento.Value;
            this.actor.Direccion = txtDireccion.Text;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if(ValidarInformacion())
            {
                CargarDatos();
                if(termino is not null)
                termino.Invoke(1);
            }
        }
        /// <summary>
        /// Solo permite letras y esoacios
        /// </summary>
        /// <param name="e"></param>
        public static void SoloLetrasTxt(KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || char.IsControl(e.KeyChar) || char.IsSeparator(e.KeyChar)))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede contener letras o espacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Solo permite números
        /// </summary>
        /// <param name="e"></param>
        public static void SoloNumerosTxt(KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo puede contener nùmeros", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Solo permite un largo de texto en el textbox recibido
        /// </summary>
        /// <param name="maximo"></param> cantidad maxima a permitir
        /// <param name="txt"></param> textbox a controlar
        /// <param name="e"></param>
        public static void LargoPermitido(int maximo, TextBox txt, KeyPressEventArgs e)
        {
            if (txt.Text.Length > maximo)
            {
                e.Handled = true;
                MessageBox.Show($"No puede tener mas de {maximo + 1} caràcteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        /// <summary>
        /// No permite que haya espacios al principio
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        public  static void BloquearEspaciosAlPrincipio(KeyPressEventArgs e, TextBox txt)
        {
            if (txt.TextLength < 1 && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida el campo del txtNombreYApellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreYApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasTxt(e);
            LargoPermitido(50, txtNombreYApellido, e);
            BloquearEspaciosAlPrincipio(e, txtNombreYApellido);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(8, txtDNI, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            LargoPermitido(200, txtDireccion, e);
            BloquearEspaciosAlPrincipio(e, txtDireccion);
        }
    }
}
