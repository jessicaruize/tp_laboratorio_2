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
        public event Termine termino;
        private Abogado abogado;
        public FormAbogado(Abogado abogado)
        {
            InitializeComponent();
            this.abogado = abogado;
        }
        private void BorrarMensajesDeError()
        {
            epTomo.SetError(txtTomo, "");
            epFolio.SetError(txtFolio, "");
            epNombreYApellido.SetError(txtNombreYApellido, "");
            epDireccion.SetError(txtDireccion, "");
            epCUIT.SetError(txtCUIT, "");
        }
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

        private void txtTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(1, txtTomo, e);
        }

        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            FormActor.SoloNumerosTxt(e);
            FormActor.LargoPermitido(2, txtFolio, e);
        }
        private void CargarDatos()
        {
            this.abogado.Nombre = txtNombreYApellido.Text;
            this.abogado.NumeroIdentificacion = long.Parse(txtCUIT.Text);
            this.abogado.Direccion = txtDireccion.Text;
            this.abogado.Tomo = int.Parse(txtTomo.Text);
            this.abogado.Folio = int.Parse(txtFolio.Text);
        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                CargarDatos();
                if (termino is not null)
                    this.termino.Invoke(2);
            }
        }
    }
}
