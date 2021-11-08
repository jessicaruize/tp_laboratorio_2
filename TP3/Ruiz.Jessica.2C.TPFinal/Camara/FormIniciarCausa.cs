using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Camara
{
    public partial class FormIniciarCausa : Form
    {
        List<Causa> causas;
        List<Juzgado> juzgados;
        /// <summary>
        /// Constructor parametrizado
        /// </summary>
        /// <param name="causas"></param> valor a cargar en el atributo causas
        /// <param name="juzgados"></param> valor a cargar en el atributo juzgados
        public FormIniciarCausa(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
        }
        /// <summary>
        /// Inicializa el formulario dandole valores a los cmb de genero y objetos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIniciarCausa_Load(object sender, EventArgs e)
        {
            //lblFecha.Text = DateTime.Now.Date.ToString();
            this.cmbGenero.DataSource = Enum.GetValues(typeof(Actor.Genero));
            this.cmbObjeto.DataSource = Enum.GetValues(typeof(Causa.Objeto));
        }

        /// <summary>
        /// Crea la causa, la agrega a la lista y al archivo XML y abre el formulario FormResultados.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearCausa_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                AgregarCausaAListaYArchivo();
                FormResultados formResultados = new FormResultados(causas, juzgados, FormResultados.EIdentificadorDeFormulario.IniciarCausa);
                formResultados.ShowDialog();
                if(formResultados.DialogResult == DialogResult.Cancel)
                {
                    ReiniciarValores();
                }
            }
        }
        /// <summary>
        /// Agrega la causa a la lista y al archivo Causas.xml que se encuentra en este proyecto
        /// </summary>
        private void AgregarCausaAListaYArchivo()
        {
            Causa causa = CrearCausa();
            bool aux = true; ;
            foreach(Causa item in causas)
            {
                if(item == causa)
                {
                    MessageBox.Show("La causa ya existe, no se puede volver a crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aux = false;
                }
            }
            if(aux)
            {
                causas.Add(CrearCausa());
                Serializador<List<Causa>> serializador = new Serializador<List<Causa>>(IArchivos<List<Causa>>.ETipoArchivo.XML);
                try
                {
                    serializador.Escribir(causas, "Causas.xml");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// Crea la causa con los datos en su formulario y la retorna
        /// </summary>
        /// <returns></returns> causa creada con los datos del formulario
        private Causa CrearCausa()
        {
            Random rmd = new Random();
            int numeroRandom = rmd.Next(1, 11);
            Juzgado juzgado = null;
            foreach (Juzgado item in juzgados)
            {
                if (item.NumeroIdentificaciòn == numeroRandom)
                {
                    juzgado = item;
                }
            }
            Causa ultimaCausa = causas.Last();
            Actor actor = new Actor(dtpFechaNacimiento.Value, (Actor.Genero)this.cmbGenero.SelectedItem, txtNombreActor.Text, txtDireccionActor.Text, long.Parse(txtDNI.Text));
            Abogado abogado = new Abogado(int.Parse(txtFolio.Text), int.Parse(txtTomo.Text), txtNombreAbogado.Text, txtDireccionAbogado.Text, long.Parse(txtCuitAbogado.Text));
            Demandado demandado = new Demandado(txtActividadEmpresarial.Text, txtNombreDemandado.Text, txtDireccionDemandado.Text, long.Parse(txtCUITDemandado.Text));
            return new Causa(demandado, abogado, actor, juzgado, DateTime.Now, (Causa.Objeto)this.cmbObjeto.SelectedItem, float.Parse(txtMontoReclamo.Text), (ultimaCausa.NumeroIdentificacion + 1));
        }
        /// <summary>
        /// Corrobora que la informacion proveniente del formulario sea valida.
        /// </summary>
        /// <returns></returns> false si no es valida la informaciòn y true si la es.
        private bool ValidarInformacion()
        {
            bool correcto = true;
            if(dtpFechaNacimiento.Value.CompareTo(DateTime.Now.AddYears(-18)) > 0)
            {
                epFechaNacimiento.SetError(dtpFechaNacimiento, "Error, Debe ser mayor a 18 años.");
                correcto = false;
            }
            if (txtNombreActor.Text == "")
            {
                epNombreActor.SetError(txtNombreActor, "Ingrese nombre del actor");
                correcto = false;
            }
            if (txtNombreAbogado.Text == "")
            {
                epNombreAbogado.SetError(txtNombreAbogado, "Ingrese nombre del abogado");
                correcto = false;
            }
            if (txtNombreDemandado.Text == "")
            {
                epNombreDemandado.SetError(txtNombreDemandado, "Ingrese nombre del demandado");
                correcto = false;
            }
            if (txtDireccionActor.Text == "")
            {
                epDireccionActor.SetError(txtDireccionActor, "Ingrese direcciòn del actor");
                correcto = false;
            }
            if (txtDireccionAbogado.Text == "")
            {
                epDireccionAbogado.SetError(txtDireccionAbogado, "Ingrese direcciòn del abogado");
                correcto = false;
            }
            if (txtDireccionDemandado.Text == "")
            {
                epDireccionDemandado.SetError(txtDireccionDemandado, "Ingrese direcciòn del demandado");
                correcto = false;
            }
            if (txtDNI.Text == "")
            {
                epDNI.SetError(txtDNI, "Ingrese DNI del actor");
                correcto = false;
            }
            if (txtCUITDemandado.Text == "")
            {
                epCuitDemandado.SetError(txtCUITDemandado, "Ingrese CUIT del demandado");
                correcto = false;
            }
            if (txtCuitAbogado.Text == "")
            {
                epCuitAbogado.SetError(txtCuitAbogado, "Ingrese CUIT del abogado");
                correcto = false;
            }
            if (txtFolio.Text == "")
            {
                epFolio.SetError(txtFolio, "Ingrese nùmero de folio de la matrìcula del abogado");
                correcto = false;
            }
            if (txtTomo.Text == "")
            {
                epTomo.SetError(txtTomo, "Ingrese nùmero de tomo de la matrìcula del abogado");
                correcto = false;
            }
            if (txtMontoReclamo.Text == "")
            {
                epMontoReclamo.SetError(txtMontoReclamo, "Ingrese el monto del reclamo");
                correcto = false;
            }
            if (txtActividadEmpresarial.Text == "")
            {
                epActEmpresa.SetError(txtActividadEmpresarial, "Ingrese nùmero de folio de la matrìcula del abogado");
                correcto = false;
            }
            return correcto;
        }
        /// <summary>
        /// En caso de existir mensajes de error los elimina.
        /// </summary>
        private void BorrarMensajesDeError()
        {
            epFechaNacimiento.SetError(dtpFechaNacimiento, "");
            epNombreActor.SetError(txtNombreActor, "");
            epNombreAbogado.SetError(txtNombreAbogado, "");
            epNombreDemandado.SetError(txtNombreDemandado, "");
            epDireccionActor.SetError(txtDireccionActor, "");
            epDireccionAbogado.SetError(txtDireccionAbogado, "");
            epDireccionDemandado.SetError(txtDireccionDemandado, "");
            epDNI.SetError(txtDNI, "");
            epCuitDemandado.SetError(txtCUITDemandado, "");
            epCuitAbogado.SetError(txtCuitAbogado, "");
            epFolio.SetError(txtFolio, "");
            epTomo.SetError(txtTomo, "");
            epMontoReclamo.SetError(txtMontoReclamo, "");
            epActEmpresa.SetError(txtActividadEmpresarial, "");
        }
        /// <summary>
        /// pone los valores como la primera vez que se abrio el formulario
        /// </summary>
        private void ReiniciarValores()
        {
            dtpFechaNacimiento.Value = DateTime.Now;
            txtNombreActor.Text = "";
            txtNombreAbogado.Text = "";
            txtNombreDemandado.Text = "";
            txtDireccionActor.Text = "";
            txtDireccionAbogado.Text = "";
            txtDireccionDemandado.Text = "";
            txtDNI.Text = "";
            txtCUITDemandado.Text = "";
            txtCuitAbogado.Text = "";
            txtFolio.Text = "";
            txtTomo.Text = "";
            txtMontoReclamo.Text = "";
            txtActividadEmpresarial.Text = "";
            cmbGenero.SelectedIndex = 0;
            cmbObjeto.SelectedIndex = 0;
        }
        /// <summary>
        /// Solo permite letras y esoacios
        /// </summary>
        /// <param name="e"></param>
        private void SoloLetrasTxt(KeyPressEventArgs e)
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
        private void SoloNumerosTxt(KeyPressEventArgs e)
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
        private void LargoPermitido(int maximo, TextBox txt, KeyPressEventArgs e)
        {
            if (txt.Text.Length > maximo)
            {
                e.Handled = true;
                MessageBox.Show($"No puede tener mas de {maximo+1} caràcteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Solo permite numeros y una coma o punto
        /// </summary>
        /// <param name="e"></param>
        private void SoloFlotante(KeyPressEventArgs e)
        {
            int contadosComa = 0;
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtMontoReclamo.Text.Length > 0)
                {
                    foreach (char c in txtMontoReclamo.Text)
                    {
                        if (c == ',')
                        {
                            contadosComa++;
                        }
                    }
                    if (contadosComa == 0)
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
                        e.Handled = true;
                        MessageBox.Show("No se puede ingresar mas de una coma.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    e.Handled = true;
                    MessageBox.Show("No se puede ingresar comas al inicio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (!char.IsNumber(e.KeyChar) && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true;
                    MessageBox.Show("Esta ingresando caracteres invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        /// <summary>
        /// No permite que haya espacios al principio
        /// </summary>
        /// <param name="e"></param>
        /// <param name="txt"></param>
        private void BloquearEspaciosAlPrincipio(KeyPressEventArgs e, TextBox txt)
        {
            if(txt.TextLength < 1 && e.KeyChar == ' ')
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Valida el campo del txtDNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(8, txtDNI, e);
        }
        /// <summary>
        /// Valida el campo del txtNombreActor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreActor_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasTxt(e);
            LargoPermitido(50, txtNombreActor, e);
            BloquearEspaciosAlPrincipio(e, txtNombreActor);
        }
        /// <summary>
        /// Valida el campo del txtDireccionActor
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccionActor_KeyPress(object sender, KeyPressEventArgs e)
        {
            LargoPermitido(200, txtDireccionActor, e);
            BloquearEspaciosAlPrincipio(e, txtDireccionActor);
        }
        /// <summary>
        /// txtNombreAbogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreAbogado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasTxt(e);
            LargoPermitido(50, txtNombreAbogado, e);
            BloquearEspaciosAlPrincipio(e, txtNombreAbogado);
        }
        /// <summary>
        /// Valida el campo del txtDireccionAbogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDireccionAbogado_KeyPress(object sender, KeyPressEventArgs e)
        {
            LargoPermitido(200, txtDireccionAbogado, e);
            BloquearEspaciosAlPrincipio(e, txtDireccionAbogado);
        }
        /// <summary>
        /// Valida el campo del txtCuitAbogado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCuitAbogado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(11, txtCuitAbogado, e);
        }
        /// <summary>
        /// Valida el campo del txtTomo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtTomo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(1, txtTomo, e);
        }
        /// <summary>
        /// Valida el campo del txtFolio
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtFolio_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(2, txtFolio, e);
        }
        /// <summary>
        /// Valida el campo del txtNombreDemandado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNombreDemandado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloLetrasTxt(e);
            LargoPermitido(50, txtNombreDemandado, e);
            BloquearEspaciosAlPrincipio(e, txtNombreDemandado);
        }
        /// <summary>
        /// txtDireccionDemandado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDirecciònDemandado_KeyPress(object sender, KeyPressEventArgs e)
        {
            LargoPermitido(200, txtDireccionAbogado, e);
            BloquearEspaciosAlPrincipio(e, txtDireccionDemandado);
        }
        /// <summary>
        /// Valida el campo del txtCUITDemandado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCUITDemandado_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloNumerosTxt(e);
            LargoPermitido(11, txtCUITDemandado, e);
        }
        /// <summary>
        /// Valida el campo del txtActividadEmpresarial
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtActividadEmpresarial_KeyPress(object sender, KeyPressEventArgs e)
        {
            LargoPermitido(40, txtActividadEmpresarial, e);
            BloquearEspaciosAlPrincipio(e, txtActividadEmpresarial);
        }
        /// <summary>
        /// Valida el campo del txtMontoReclamo
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMontoReclamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFlotante(e);
        }
        /// <summary>
        /// Corrobora que este seguro de salir.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormIniciarCausa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
