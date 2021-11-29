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
    public partial class FormDemandado : Form
    {
        /// <summary>
        /// EVENTO UTILIZADO PARA INFORMAR QUE TERMINO DE HACER LO QUE LE CORRESPONDE
        /// </summary>
        public event DelegadoTerminar InformaQueTermino;
        private Demandado demandado;
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="demandado"></param> asigna la referencia al atributo demandado
        public FormDemandado(Demandado demandado)
        {
            InitializeComponent();
            this.demandado = demandado;
        }
        /// <summary>
        /// Elimina los mensajes de error de los error provider
        /// </summary>
        private void BorrarMensajesDeError()
        {
            epNombreYApellido.SetError(txtNombreYApellido, "");
            epDireccion.SetError(txtDireccion, "");
            epCUIT.SetError(txtCUIT, "");
            epActividadEmpresa.SetError(txtActividadEmpresarial, "");
        }
        /// <summary>
        /// Valida que los campos no se encuentren vacios, en caso de estarlo/s indica el error con el error provider
        /// </summary>
        /// <returns></returns> true si no hay error, false si hay error
        private bool ValidarInformacion()
        {
            bool correcto = true;
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
            if (txtCUIT.Text == "")
            {
                epCUIT.SetError(txtCUIT, "Ingrese DNI del actor");
                correcto = false;
            }
            if (txtActividadEmpresarial.Text == "")
            {
                epActividadEmpresa.SetError(txtActividadEmpresarial, "Ingrese la actividad de la empresa");
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
        private void txtActividadEmpresarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.LargoPermitido(40, txtActividadEmpresarial, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtActividadEmpresarial);
        }
        /// <summary>
        /// Carga los datos de los controles en el form al atributo demandado
        /// </summary>
        private void CargarDatos()
        {
            this.demandado.Nombre = txtNombreYApellido.Text;
            this.demandado.NumeroIdentificacion = long.Parse(txtCUIT.Text);
            this.demandado.Direccion = txtDireccion.Text;
            this.demandado.ActividadEmpresa = txtActividadEmpresarial.Text;
        }
        /// <summary> SE INVOCA AL EVENTO PARA INFORMAR QUE TERMINO SU PROCESO A "FormIniciarCausa"
        /// Valida y carga datos si corresponde al atributo demandado, invoca al evento que indica que termino su trabajo
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
                    InformaQueTermino.Invoke(3);
            }
        }
    }
}
