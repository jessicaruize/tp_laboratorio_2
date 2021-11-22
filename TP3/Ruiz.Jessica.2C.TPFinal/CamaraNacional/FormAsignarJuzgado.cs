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
    public delegate void  MiDelegado();
    public partial class FormAsignarJuzgado : Form
    {
        public event MiDelegado evento;
        List<Causa> causas;
        List<Juzgado> juzgados;
        Actor actor;
        Abogado abogado; 
        Demandado demandado;
        Causa causa;
        public FormAsignarJuzgado(List<Causa> causas, List<Juzgado> juzgados, Actor actor, Abogado abogado, Demandado demandado)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
            this.actor = actor;
            this.demandado = demandado;
            this.abogado = abogado;
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

        private void FormAsignarJuzgado_Load(object sender, EventArgs e)
        {
            this.cmbObjeto.DataSource = Enum.GetValues(typeof(Causa.Objeto));
        }

        private void txtMontoReclamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFlotante(e);
        }
        private bool ValidarInformacion()
        {
            bool correcto = true;
            if (txtMontoReclamo.Text == "")
            {
                epMontoReclamo.SetError(txtMontoReclamo, "Ingrese el monto a reclamar");
                correcto = false;
            }
            return correcto;
        }
        private void BorrarMensajesDeError()
        {
            epMontoReclamo.SetError(txtMontoReclamo, "");
        }
        private void btnCrearCausa_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                if(AgregarCausaAListaBaseDeDatosYArchivo())
                {
                    if(evento is not null)
                    {
                        evento.Invoke();
                    }
                    FormResultados formResultados = new FormResultados(causas, juzgados, FormResultados.EIdentificadorDeFormulario.IniciarCausa);
                    formResultados.ShowDialog();
                }
            }
        }
        /// <summary>
        /// Agrega la causa a la lista y al archivo Causas.xml que se encuentra en este proyecto
        /// </summary>
        private bool AgregarCausaAListaBaseDeDatosYArchivo()
        {
            this.causa = CrearCausa();
            bool aux = true;
            foreach (Causa item in causas)
            {
                if (item == causa)
                {
                    MessageBox.Show("La causa ya existe, no se puede volver a crear", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    aux = false;
                }
            }
            if (aux)
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
                BaseDeDatos bd = new BaseDeDatos();
                bd.Guardar(actor);
                bd.Guardar(abogado);
                bd.Guardar(demandado);
                bd.Guardar(causa);
            }
            return aux;
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
                if (item.NumeroIdentificacion == numeroRandom)
                {
                    juzgado = item;
                }
            }
            Causa ultimaCausa = causas.Last();
            Actor actor = this.actor;
            Abogado abogado = this.abogado;
            Demandado demandado = this.demandado;
            return new Causa(demandado, abogado, actor, juzgado, DateTime.Now, (Causa.Objeto)this.cmbObjeto.SelectedItem, float.Parse(txtMontoReclamo.Text), (ultimaCausa.NumeroIdentificacion + 1));
        }
    }
}
