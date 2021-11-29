using Entidades;
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
    public partial class FormExplorar : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        List<Causa> causas;
        List<Juzgado> juzgados;
        /// <summary>
        /// Constructor parametrizado que recibe listas de causas y juzgados la cual se asignan a los atributos 
        /// </summary>
        /// <param name="causas"></param> lista a cargar en el atributo causas
        /// <param name="juzgados"></param> lista a cargar en el atributo juzgados
        public FormExplorar(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
        }
        /// <summary> SE SUSCRIBE EL AL EVENTO EL MANEJADOR QUE INDICARA QUE SE CREO UNA NUEVA CAUSA
        /// Inicializa los controles con sus correspondientes valores
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExplorar_Load(object sender, EventArgs e)
        {
            lblIndicacion.Visible = true;
            rbCausaEspecifica.Checked = true;
            cmbEleccion.Visible = false;
            lblIndicacion.Text = "Ingrese número de causa:";
            txtValor.Visible = true;
            FormAsignarJuzgado.InformaNuevaCausa += AvisarHayCambios;
        }
        /// <summary>
        /// Avisara cuando se cree una nueva causa.
        /// </summary>
        private void AvisarHayCambios()
        {
            MessageBox.Show("Se creó una nueva causa, lo cual puede ocasionar cambios en sus búsquedas ya realizadas.", "Alerta", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Segun lo que indique el usuario va a abrir el formulario resultados con la informacion correspondiente.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            List<Causa> causasFiltradas = new List<Causa>();
            FormResultados.EIdentificadorDeFormulario identificadorForm = FormResultados.EIdentificadorDeFormulario.VisualizarCausas;
            bool seguir = true;
            if (rbCausaEspecifica.Checked)
            {
                BuscarCausaPorNumeroIdentificacion(txtValor.Text, causasFiltradas);
                if (causasFiltradas.Count > 0)
                {
                    identificadorForm = FormResultados.EIdentificadorDeFormulario.IniciarCausa;
                }
                else
                {
                    seguir = false;
                    MessageBox.Show("No se encontro ningúna causa con ese número", "Error.", MessageBoxButtons.OK);
                    txtValor.Focus();

                }
            }
            else
            {
                if (rbCausasJuzgado.Checked)
                {
                    SelecionDeJuzgados(causasFiltradas);
                    if (!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show("El juzgado no tiene causas.", "Error.", MessageBoxButtons.OK);
                        cmbEleccion.Focus();
                    }
                }
                else
                {
                    if (rbCausasObjeto.Checked)
                    {
                        SelecionarObjeto(causasFiltradas);
                        if (!(causasFiltradas.Count > 0))
                        {
                            seguir = false;
                            MessageBox.Show("No hay causas con el objeto elegido.", "Error.", MessageBoxButtons.OK);
                            cmbEleccion.Focus();
                        }
                    }
                    else
                    {
                        if (rbCausasMontoInferior.Checked)
                        {
                            FiltrarPorMonto(cmbEleccion.Text, causasFiltradas, true);
                            if (!(causasFiltradas.Count > 0))
                            {
                                seguir = false;
                                MessageBox.Show($"No hay ninguna causa con un monto menor a {cmbEleccion.Text}.", "Error.", MessageBoxButtons.OK);
                                cmbEleccion.Focus();
                            }
                        }
                        else
                        {
                            if (rbCausasMontoSuperior.Checked)
                            {
                                FiltrarPorMonto(cmbEleccion.Text, causasFiltradas, false);
                                if (!(causasFiltradas.Count > 0))
                                {
                                    seguir = false;
                                    MessageBox.Show($"No hay ninguna causa con un monto mayor a {cmbEleccion.Text}.", "Error.", MessageBoxButtons.OK);
                                    cmbEleccion.Focus();
                                }
                            }
                            else
                            {
                                if (rbCausas.Checked)
                                {
                                    causasFiltradas = causas;
                                    if (!(causasFiltradas.Count > 0))
                                    {
                                        seguir = false;
                                        MessageBox.Show($"No hay ninguna causa", "Error.", MessageBoxButtons.OK);
                                        cmbEleccion.Focus();
                                    }
                                }
                                else
                                {
                                    if (rbJuzgados.Checked)
                                    {
                                        identificadorForm = FormResultados.EIdentificadorDeFormulario.MostrarJuzgados;
                                        if (!(juzgados.Count > 0))
                                        {
                                            seguir = false;
                                            MessageBox.Show($"No hay ninguna juzgado", "Error.", MessageBoxButtons.OK);
                                            cmbEleccion.Focus();
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            if (seguir)
            {
                PasarInformacionAlFormResultados(causasFiltradas, identificadorForm);
            }
        }
        /// <summary>
        /// En caso de que el número sea valido filtrara la causa y la cargara en la lista de causas filtradas
        /// </summary>
        /// <param name="numeroIdentificatorio"></param> numero de identificacion de la causa a buscar
        /// <param name="causasFiltradas"></param> lista que guardara la causa una vez filtrada
        /// <returns></returns> true si la encontro, false si no la encontro
        private bool BuscarCausaPorNumeroIdentificacion(string numeroIdentificatorio, List<Causa> causasFiltradas)
        {
            int numero;
            if (int.TryParse(numeroIdentificatorio, out numero))
            {
                epTxt.SetError(txtValor, "");
                foreach (Causa item in causas)
                {
                    if (item.NumeroIdentificacion == numero)
                    {
                        causasFiltradas.Add(item);
                        return true;
                    }
                }
            }
            else
            {
                epTxt.SetError(txtValor, "Solo el nùmero de casua (no poner /año)");
            }
            return false;
        }
        /// <summary>
        /// Filtra las causas por numero de juzgado
        /// </summary>
        /// <param name="numeroJuzgado"></param> número de juzgado con el cual se tomara de refrencia para filtrar las causas
        /// <param name="causasFiltradas"></param> lista que guardara las causas una vez filtradas
        private void FiltrarPorJuzgados(int numeroJuzgado, List<Causa> causasFiltradas)
        {
            foreach (Causa c in causas)
            {
                if (c.Juzgado.NumeroIdentificacion == numeroJuzgado)
                {
                    causasFiltradas.Add(c);
                }
            }
        }
        /// <summary>
        /// Filtra las causas segun el juzgado indicado en el combo box de juzgados
        /// </summary>
        /// <param name="causasFiltradas"></param> lista que guardara las causas una vez filtradas
        private void SelecionDeJuzgados(List<Causa> causasFiltradas)
        {
            switch (cmbEleccion.SelectedIndex)
            {
                case 0:
                    FiltrarPorJuzgados(1, causasFiltradas);
                    break;
                case 1:
                    FiltrarPorJuzgados(2, causasFiltradas);
                    break;
                case 2:
                    FiltrarPorJuzgados(3, causasFiltradas);
                    break;
                case 3:
                    FiltrarPorJuzgados(4, causasFiltradas);
                    break;
                case 4:
                    FiltrarPorJuzgados(5, causasFiltradas);
                    break;
                case 5:
                    FiltrarPorJuzgados(6, causasFiltradas);
                    break;
                case 6:
                    FiltrarPorJuzgados(7, causasFiltradas);
                    break;
                case 7:
                    FiltrarPorJuzgados(8, causasFiltradas);
                    break;
                case 8:
                    FiltrarPorJuzgados(9, causasFiltradas);
                    break;
                case 9:
                    FiltrarPorJuzgados(10, causasFiltradas);
                    break;
            }
        }
        /// <summary>
        /// filtra causas por un objeto específico
        /// </summary>
        /// <param name="objeto"></param> objeto que se usara para filtrar las causas
        /// <param name="causasFiltradas"></param> lista que guardara las causas una vez filtradas
        private void FiltrarPorObjeto(Causa.Objeto objeto, List<Causa> causasFiltradas)
        {
            foreach (Causa c in causas)
            {
                if (c.ObjetoCausa == objeto)
                {
                    causasFiltradas.Add(c);
                }
            }
        }
        /// <summary>
        /// filtra causas segun el objeto que se eleja en el combo box de objetos
        /// </summary>
        /// <param name="causasFiltradas"></param> lista que guardara las causas una vez filtradas
        private void SelecionarObjeto(List<Causa> causasFiltradas)
        {
            switch (cmbEleccion.SelectedIndex)
            {
                case 0:
                    FiltrarPorObjeto(Causa.Objeto.Accidente, causasFiltradas);
                    break;
                case 1:
                    FiltrarPorObjeto(Causa.Objeto.Amparo, causasFiltradas);
                    break;
                case 2:
                    FiltrarPorObjeto(Causa.Objeto.Despido, causasFiltradas);
                    break;
                case 3:
                    FiltrarPorObjeto(Causa.Objeto.DirefenciaSalario, causasFiltradas);
                    break;
                case 4:
                    FiltrarPorObjeto(Causa.Objeto.EjecucionDeCredito, causasFiltradas);
                    break;
            }
        }
        /// <summary>
        /// filtra por el monto espeficando si debe ser menor o mayor
        /// </summary>
        /// <param name="monto"></param> monto con el cual se tomara en cuenta para filtrar las causas
        /// <param name="causasFiltradas"></param> lista que guardara las causas una vez filtradas
        /// <param name="motivo"></param> true si es menor, false si es mayor
        private void FiltrarPorMonto(string monto, List<Causa> causasFiltradas, bool motivo)
        {
            if (float.TryParse(monto, out float montoAux))
            {
                if (motivo == true)
                {
                    foreach (Causa c in causas)
                    {
                        if (c.MontoReclamo < montoAux)
                        {
                            causasFiltradas.Add(c);
                        }
                    }
                }
                else
                {
                    if (motivo == false)
                    {
                        foreach (Causa c in causas)
                        {
                            if (c.MontoReclamo > montoAux)
                            {
                                causasFiltradas.Add(c);
                            }
                        }
                    }
                }
            }
        }
        /// <summary>
        /// Abrira el formulario resultado con la informacion 
        /// </summary>
        /// <param name="causasFiltradas"></param>
        /// <param name="identificador"></param>
        private void PasarInformacionAlFormResultados(List<Causa> causasFiltradas, FormResultados.EIdentificadorDeFormulario identificador)
        {
            FormResultados formResultados = new FormResultados(causasFiltradas, juzgados, identificador);
            formResultados.Show();
        }
        /// <summary>
        /// Antes de cerrar el formulario corrobora que el usuario este seguro
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormExplorar_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
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
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausaEspecifica_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausaEspecifica.Checked)
            {
                cmbEleccion.Visible = false;
                lblIndicacion.Text = "Ingrese número de causa:";
                txtValor.Visible = true;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausasJuzgado_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausasJuzgado.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Items.Clear();
                lblIndicacion.Text = "Selecciones el juzgado:";
                cmbEleccion.Items.Add("Juzgado 1");
                cmbEleccion.Items.Add("Juzgado 2");
                cmbEleccion.Items.Add("Juzgado 3");
                cmbEleccion.Items.Add("Juzgado 4");
                cmbEleccion.Items.Add("Juzgado 5");
                cmbEleccion.Items.Add("Juzgado 6");
                cmbEleccion.Items.Add("Juzgado 7");
                cmbEleccion.Items.Add("Juzgado 8");
                cmbEleccion.Items.Add("Juzgado 9");
                cmbEleccion.Items.Add("Juzgado 10");
                cmbEleccion.SelectedIndex = 0;
                cmbEleccion.Visible = true;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausasObjeto_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausasObjeto.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Items.Clear();
                cmbEleccion.Items.Add("Accidente");
                cmbEleccion.Items.Add("Amparo");
                cmbEleccion.Items.Add("Despido");
                cmbEleccion.Items.Add("Diferencia salario");
                cmbEleccion.Items.Add("Ejecuciòn de credito");
                lblIndicacion.Text = "Seleciones el objeto: ";
                cmbEleccion.SelectedIndex = 0;
                cmbEleccion.Visible = true;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausasMontoInferior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausasMontoInferior.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Items.Clear();
                lblIndicacion.Text = "Selecciones el monto de reclamo:";
                cmbEleccion.Items.Add("50.000");
                cmbEleccion.Items.Add("100.000");
                cmbEleccion.Items.Add("200.000");
                cmbEleccion.Items.Add("500.000");
                cmbEleccion.Items.Add("1.000.000");
                cmbEleccion.Items.Add("3.000.000");
                cmbEleccion.Items.Add("6.000.000");
                cmbEleccion.Items.Add("10.000.000");
                cmbEleccion.SelectedIndex = 0;
                cmbEleccion.Visible = true;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausasMontoSuperior_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausasMontoSuperior.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Items.Clear();
                lblIndicacion.Text = "Selecciones el monto de reclamo:";
                cmbEleccion.Items.Add("50000");
                cmbEleccion.Items.Add("100000");
                cmbEleccion.Items.Add("200000");
                cmbEleccion.Items.Add("500000");
                cmbEleccion.Items.Add("1000000");
                cmbEleccion.Items.Add("3000000");
                cmbEleccion.Items.Add("6000000");
                cmbEleccion.Items.Add("10000000");
                cmbEleccion.SelectedIndex = 0;
                cmbEleccion.Visible = true;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbCausas_CheckedChanged(object sender, EventArgs e)
        {
            if (rbCausas.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Visible = false;
                txtValor.Visible = false;
                lblIndicacion.Visible = false;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void rbJuzgados_CheckedChanged(object sender, EventArgs e)
        {
            if (rbJuzgados.Checked)
            {
                txtValor.Visible = false;
                cmbEleccion.Visible = false;
                txtValor.Visible = false;
                lblIndicacion.Visible = false;
            }
        }
        /// <summary>
        /// Gestiona los controles como corresponde para su operación
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Permite mover el formulario a la parte de la pantalla que querramos
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
