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
        public event Termine termino;
        private Demandado demandado;
        public FormDemandado(Demandado demandado)
        {
            InitializeComponent();
            this.demandado = demandado;
        }
        private void BorrarMensajesDeError()
        {
            epNombreYApellido.SetError(txtNombreYApellido, "");
            epDireccion.SetError(txtDireccion, "");
            epCUIT.SetError(txtCUIT, "");
            epActividadEmpresa.SetError(txtActividadEmpresarial, "");
        }
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
       

        private void txtNombreYApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloLetrasTxt(e);
            FormActor.LargoPermitido(50, txtNombreYApellido, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtNombreYApellido);
        }

        private void txtCUIT_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(11, txtCUIT, e);
        }

        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.LargoPermitido(200, txtDireccion, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtDireccion);
        }

        private void txtActividadEmpresarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.LargoPermitido(40, txtActividadEmpresarial, e);
            FormActor.BloquearEspaciosAlPrincipio(e, txtActividadEmpresarial);
        }

        private void CargarDatos()
        {
            this.demandado.Nombre = txtNombreYApellido.Text;
            this.demandado.NumeroIdentificacion = long.Parse(txtCUIT.Text);
            this.demandado.Direccion = txtDireccion.Text;
            this.demandado.ActividadEmpresa = txtActividadEmpresarial.Text;
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                CargarDatos();
                if (termino is not null)
                    termino.Invoke(3);
            }
        }
    }
}
