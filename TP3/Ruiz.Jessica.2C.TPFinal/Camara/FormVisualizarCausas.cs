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

namespace Camara
{
    public partial class FormVisualizarCausas : Form
    {
        List<Causa> causas;
        List<Juzgado> juzgados;
        /// <summary>
        /// Constructor parametrizado que recibe listas de causas y juzgados la cual se asignan a los atributos 
        /// </summary>
        /// <param name="causas"></param> lista a cargar en el atributo causas
        /// <param name="juzgados"></param> lista a cargar en el atributo juzgados
        public FormVisualizarCausas(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
        }
        /// <summary>
        /// Inicializa los controles con los valores de inicio correspondientes.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormVisualizarCausas_Load(object sender, EventArgs e)
        {
            cmbFiltros.Items.Add("Causa especifica");
            cmbFiltros.Items.Add("Causas pertenecientes a un juzgado en particular");
            cmbFiltros.Items.Add("Causas pertenecientes a un objeto en particular");
            cmbFiltros.Items.Add("Causas inferiores a un monto de reclamo");
            cmbFiltros.Items.Add("Causas superiores a un monto de reclamo");
            cmbFiltros.Items.Add("Todas las causas");
            cmbFiltros.Items.Add("Todos los juzgados");
            cmbCambiante.Visible = false;
            cmbFiltros.SelectedIndex = 0;
            lblCambiante.Text = "Ingrese número de causa:";
            txtNumeroDeCausa.Visible = true; ;
        }
        /// <summary>
        /// Cada vez que se cambia de indice del cmbFiltro se modifican los controles segun corresponda.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbFiltros_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cmbFiltros.SelectedIndex)
            {
                case 0:
                    cmbCambiante.Visible = false;
                    lblCambiante.Text = "Ingrese número de causa:";
                    txtNumeroDeCausa.Visible = true;
                    break;
                case 1:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Items.Clear();
                    lblCambiante.Text = "Selecciones el juzgado:";
                    cmbCambiante.Items.Add("Juzgado 1");
                    cmbCambiante.Items.Add("Juzgado 2");
                    cmbCambiante.Items.Add("Juzgado 3");
                    cmbCambiante.Items.Add("Juzgado 4");
                    cmbCambiante.Items.Add("Juzgado 5");
                    cmbCambiante.Items.Add("Juzgado 6");
                    cmbCambiante.Items.Add("Juzgado 7");
                    cmbCambiante.Items.Add("Juzgado 8");
                    cmbCambiante.Items.Add("Juzgado 9");
                    cmbCambiante.Items.Add("Juzgado 10");
                    cmbCambiante.SelectedIndex = 0;
                    cmbCambiante.Visible = true;
                    break;
                case 2:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Items.Clear();
                    cmbCambiante.Items.Add("Accidente");
                    cmbCambiante.Items.Add("Amparo");
                    cmbCambiante.Items.Add("Despido");
                    cmbCambiante.Items.Add("Diferencia salario");
                    cmbCambiante.Items.Add("Ejecuciòn de credito");
                    lblCambiante.Text = "Seleciones el objeto: ";
                    cmbCambiante.SelectedIndex = 0;
                    cmbCambiante.Visible = true;
                    break;
                case 3:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Items.Clear();
                    lblCambiante.Text = "Selecciones el monto de reclamo:";
                    cmbCambiante.Items.Add("50.000");
                    cmbCambiante.Items.Add("100.000");
                    cmbCambiante.Items.Add("200.000");
                    cmbCambiante.Items.Add("500.000");
                    cmbCambiante.Items.Add("1.000.000");
                    cmbCambiante.Items.Add("3.000.000");
                    cmbCambiante.Items.Add("6.000.000");
                    cmbCambiante.Items.Add("10.000.000");
                    cmbCambiante.SelectedIndex = 0;
                    cmbCambiante.Visible = true;
                    break;
                case 4:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Items.Clear();
                    lblCambiante.Text = "Selecciones el monto de reclamo:";
                    cmbCambiante.Items.Add("50000");
                    cmbCambiante.Items.Add("100000");
                    cmbCambiante.Items.Add("200000");
                    cmbCambiante.Items.Add("500000");
                    cmbCambiante.Items.Add("1000000");
                    cmbCambiante.Items.Add("3000000");
                    cmbCambiante.Items.Add("6000000");
                    cmbCambiante.Items.Add("10000000");
                    cmbCambiante.SelectedIndex = 0;
                    cmbCambiante.Visible = true;
                    break;
                case 5:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Visible = false;
                    txtNumeroDeCausa.Visible = false;
                    lblCambiante.Visible = false;
                    break;
                case 6:
                    txtNumeroDeCausa.Visible = false;
                    cmbCambiante.Visible = false;
                    txtNumeroDeCausa.Visible = false;
                    lblCambiante.Visible = false;
                    break;
            }
            
        }
        private void btnAplicarBusqueda_Click(object sender, EventArgs e)
        {
            List<Causa> causasFiltradas = new List<Causa>();
            FormResultados.EIdentificadorDeFormulario identificadorForm = FormResultados.EIdentificadorDeFormulario.VisualizarCausas;
            string mensajeError = string.Empty;
            bool seguir = true; ;
            switch (cmbFiltros.SelectedIndex)
            {
                case 0:
                    BuscarCausaPorNumeroIdentificacion(txtNumeroDeCausa.Text, causasFiltradas);
                    if(causasFiltradas.Count > 0)
                    {
                        identificadorForm = FormResultados.EIdentificadorDeFormulario.IniciarCausa;
                    }
                    else
                    {
                        seguir = false;
                        MessageBox.Show("No se encontro ningúna causa con ese número", "Error.", MessageBoxButtons.OK);
                        txtNumeroDeCausa.Focus();

                    }
                    break;
                case 1:
                    SelecionDeJuzgados(causasFiltradas);
                    if(!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show("El juzgado no tiene causas.", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
                case 2:
                    SelecionarObjeto(causasFiltradas);
                    if (!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show("No hay causas con el objeto elegido.", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
                case 3:
                    FiltrarPorMonto(cmbCambiante.Text, causasFiltradas, true);
                    if (!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show($"No hay ninguna causa con un monto menor a {cmbCambiante.Text}.", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
                case 4:
                    FiltrarPorMonto(cmbCambiante.Text, causasFiltradas, false);
                    if (!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show($"No hay ninguna causa con un monto mayor a {cmbCambiante.Text}.", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
                case 5:
                    causasFiltradas = causas;
                    if (!(causasFiltradas.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show($"No hay ninguna causa", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
                case 6:
                    identificadorForm = FormResultados.EIdentificadorDeFormulario.MostrarJuzgados;
                    if (!(juzgados.Count > 0))
                    {
                        seguir = false;
                        MessageBox.Show($"No hay ninguna juzgado", "Error.", MessageBoxButtons.OK);
                        cmbCambiante.Focus();
                    }
                    break;
            }
            if (seguir)
            {
                PasarInformacionAlFormResultados(causasFiltradas, identificadorForm);
            }
        }
        private bool BuscarCausaPorNumeroIdentificacion(string numeroIdentificatorio, List<Causa> causasFiltradas)
        {
            int numero;
            if (int.TryParse(numeroIdentificatorio, out numero))
            {
                epCambiante.SetError(txtNumeroDeCausa, "");
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
                epCambiante.SetError(txtNumeroDeCausa, "Solo el nùmero de casua (no poner /año)");
            }
            return false;
        }
        private void FiltrarPorJuzgados(int numeroJuzgado, List<Causa> causasFiltradas)
        {
            foreach (Causa c in causas)
            {
                if (c.Juzgado.NumeroIdentificaciòn == numeroJuzgado)
                {
                    causasFiltradas.Add(c);
                }
            }
        }
        private void SelecionDeJuzgados(List<Causa> causasFiltradas)
        {
            switch (cmbCambiante.SelectedIndex)
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
        private void SelecionarObjeto(List<Causa> causasFiltradas)
        {
            switch (cmbCambiante.SelectedIndex)
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
        private void FiltrarPorMonto(string monto, List<Causa> causasFiltradas, bool motivo)
        {
            float montoAux = float.Parse(monto);
            if (motivo == true) //menor
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
                if (motivo == false) //mayor
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
        private void PasarInformacionAlFormResultados(List<Causa> causasFiltradas, FormResultados.EIdentificadorDeFormulario identificador)
        {
            FormResultados formResultados = new FormResultados(causasFiltradas, juzgados,  identificador);
            formResultados.ShowDialog();
        }
        private void FormVisualizarCausas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
    }
}
