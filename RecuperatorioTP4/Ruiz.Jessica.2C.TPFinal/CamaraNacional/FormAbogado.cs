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
    public partial class FormAbogado : Form
    {
        /// <summary>
        /// EVENTO PARA INFORMAR AL "FormIniciarCausa" que termino.
        /// </summary>
        public event DelegadoTerminar InformaQueTermino;
        private Abogado abogado;
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="abogado"></param> referencia a asignar en el atributo abogado
        public FormAbogado(Abogado abogado)
        {
            InitializeComponent();
            this.abogado = abogado;
        }
        /// <summary>
        /// Elimina los mensajes de error de los error provider
        /// </summary> true si no hay error, false si hay error
        private void BorrarMensajesDeError()
        {
            epTomo.SetError(txtTomo, "");
            epFolio.SetError(txtFolio, "");
            epNombreYApellido.SetError(txtNombreYApellido, "");
            epDireccion.SetError(txtDireccion, "");
            epCUIT.SetError(txtCUIT, "");
        }
        /// <summary>
        /// Valida que los campos no se encuentren vacios y en caso de estarlos indica el error con el error provider
        /// </summary>
        /// <returns></returns>
        private bool ValidarInformacion()
        {
            bool correcto = true;
            if (txtNombreYApellido.Text == "")
            {
                epNombreYApellido.SetError(txtNombreYApellido, "Ingrese nombre del abogado");
                correcto = false;
            }
            if (txtDireccion.Text == "")
            {
                epDireccion.SetError(txtDireccion, "Ingrese direcciòn del abogado");
                correcto = false;
            }
            if (txtCUIT.Text == "")
            {
                epCUIT.SetError(txtCUIT, "Ingrese CUIT del abogado");
                correcto = false;
            }
            if (txtTomo.Text == "")
            {
                epTomo.SetError(txtTomo, "Ingrese número de tomo del abogado");
                correcto = false;
            }
            if (txtFolio.Text == "")
            {
                epFolio.SetError(txtFolio, "Ingrese número de folio del abogado");
                correcto = false;
            }
            return correcto;
        }
        /// <summary>
        /// No deja ingresar caracteres no validos ni pasarse del largo permitido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreYApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloLetrasTxt(e);
            FormActor.LargoPermitido(50, txtNombreYApellido, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtNombreYApellido);
        }
        /// <summary>
        /// No deja ingresar caracteres no validos ni pasarse del largo permitido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(11, txtCUIT, e);
        }
        /// <summary>
        /// No deja ingresar caracteres no validos ni pasarse del largo permitido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.LargoPermitido(200, txtDireccion, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtDireccion);
        }
        /// <summary>
        /// No deja ingresar caracteres no validos ni pasarse del largo permitido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(1, txtTomo, e);
        }
        /// <summary>
        /// No deja ingresar caracteres no validos ni pasarse del largo permitido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(2, txtFolio, e);
        }
        /// <summary>
        /// Carga los datos de los controles en el form al atributo abogado
        /// </summary>
        private void CargarDatos()
        {
            this.abogado.Nombre = txtNombreYApellido.Text;
            this.abogado.NumeroIdentificacion = long.Parse(txtCUIT.Text);
            this.abogado.Direccion = txtDireccion.Text;
            this.abogado.Tomo = int.Parse(txtTomo.Text);
            this.abogado.Folio = int.Parse(txtFolio.Text);
        }
        /// <summary> SE INVOCA AL EVENTO PARA INFORMAR QUE TERMINO SU PROCESO A "FormIniciarCausa"
        /// Valida y carga datos si corresponde al atributo abogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                CargarDatos();
                if (InformaQueTermino is not null)
                    this.InformaQueTermino.Invoke(2);
            }
        }
    }
}
