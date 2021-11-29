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
    public partial class FormAsignarJuzgado : Form
    {
        /// <summary>
        /// Delegado creado para utilizarlo en el evento de la clase.
        /// </summary>
        public delegate void  MiDelegado();
        /// <summary>
        ///  EVENTO UTILIZADO PARA INFORMAR QUE SE INICIO UNA NUEVA CAUSA
        /// </summary>
        public static event MiDelegado InformaNuevaCausa;
        /// <summary>
        ///  EVENTO UTILIZADO PARA INFORMAR QUE TERMINO DE HACER LO QUE LE CORRESPONDE
        /// </summary>
        public event DelegadoTerminar InformaQueTermino;
        List<Causa> causas;
        List<Juzgado> juzgados;
        Actor actor;
        Abogado abogado; 
        Demandado demandado;
        Causa causa;
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="causas"></param> referencia a asignar al atributo causas
        /// <param name="juzgados"></param> referencia a asignar al atributo juzgados
        /// <param name="actor"></param> referencia a asignar al atributo actor
        /// <param name="abogado"></param> referencia a asignar al atributo abogado
        /// <param name="demandado"></param> referencia a asignar al atributo demandado
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
        /// <summary>
        /// Al cargar el formulario se carga el combo box de objetos con sus respectivos datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAsignarJuzgado_Load(object sender, EventArgs e)
        {
            this.cmbObjeto.DataSource = Enum.GetValues(typeof(Causa.Objeto));
        }
        /// <summary>
        /// valida que se ingresen caracteres validos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtMontoReclamo_KeyPress(object sender, KeyPressEventArgs e)
        {
            SoloFlotante(e);
        }
        /// <summary>
        /// Valida que no se este vacio el text box monto reclamo, en caso de estarlo avisa con un error provider
        /// </summary>
        /// <returns></returns> true si no hay error, false si hay error
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
        /// <summary>
        /// Elimina el mensaje de error del error provider
        /// </summary>
        private void BorrarMensajesDeError()
        {
            epMontoReclamo.SetError(txtMontoReclamo, "");
        }
        /// <summary> ACA SE CREA UN HILO Y SE LO CORRE EL CUAL VA A GUARDAR LA NUEVA CAUSA EN LA BASE DE DATOS Y ACTUALIZAR EL ASCHIVO XML, TAMBIEN SE INVOCA LOS DOS EVENTOS DE LA CLASE.
        /// Valida que los campos esten correctamente cargados, crea la causa, agrega la causa a la lista de causas si corresponde, en caso de hacerlo guarda en la base de datos y archivo xml, invoca el evento para informar de la nueva causa, luego abre el FormResultados con la informacion de la nueva causa creada e invoca el evento para indicar que termino su tarea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCrearCausa_Click(object sender, EventArgs e)
        {
            BorrarMensajesDeError();
            if (ValidarInformacion())
            {
                this.causa = CrearCausa();

                if (AgregarCausaALista())
                {
                    Task hilo = Task.Run(GuardarCausa);
                    if (InformaNuevaCausa is not null)
                    {
                        InformaNuevaCausa.Invoke();
                    }
                    FormResultados formResultados = new FormResultados(causas, juzgados, FormResultados.EIdentificadorDeFormulario.IniciarCausa);
                    formResultados.Show();
                    if(this.InformaQueTermino is not null)
                    {
                        this.InformaQueTermino.Invoke(4);
                    }
                }
            }
        }
        
        /// <summary>
        /// Agrega la causa a la lista y al archivo Causas.xml que se encuentra en este proyecto
        /// </summary>
        private bool AgregarCausaALista()
        {
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
                causas.Add(this.causa);
            }
            return aux;
        }
        /// <summary> SE CONTROLAN LAS EXCEPCIONES, SE IMPLEMENTA BASE DE DATOS Y ARCHIVOS
        /// Actualiza el archivo xml con la nueva causa y también la agrega a la base de datos
        /// </summary>
        private void GuardarCausa()
        {
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
            try
            {
                bd.Guardar(actor);
                bd.Guardar(abogado);
                bd.Guardar(demandado);
                bd.Guardar(causa);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /// <summary>
        /// Asigan un juzgado de forma aleatoria, crea la causa con los datos en su formulario y la retorna
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
                    break;
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
