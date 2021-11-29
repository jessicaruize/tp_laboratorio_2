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
using System.Runtime.InteropServices;

namespace CamaraNacional
{
    public partial class FormEstadisticas : Form
    {
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd,int wMsg, int wParam, int lParam);

        private List<Causa> causas;
        private int cantidadDeCausas;
        /// <summary>
        /// Constructor con parametros
        /// </summary>
        /// <param name="causas"></param> referencia a cargar en el atributo causas
        public FormEstadisticas(List<Causa> causas)
        {
            InitializeComponent();
            this.causas = causas;
        }
        /// <summary>
        /// Asocia el evento que informa si hay nuevas causas al manejador AvisarHayCambios, carga los datos necesarios a los diferentes combo box y actualiza los datos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEstadicticas_Load(object sender, EventArgs e)
        {
            FormAsignarJuzgado.InformaNuevaCausa += AvisarHayCambios;
            cmbJuzgados.Items.Add("Juzgado 1");
            cmbJuzgados.Items.Add("Juzgado 2");
            cmbJuzgados.Items.Add("Juzgado 3");
            cmbJuzgados.Items.Add("Juzgado 4");
            cmbJuzgados.Items.Add("Juzgado 5");
            cmbJuzgados.Items.Add("Juzgado 6");
            cmbJuzgados.Items.Add("Juzgado 7");
            cmbJuzgados.Items.Add("Juzgado 8");
            cmbJuzgados.Items.Add("Juzgado 9");
            cmbJuzgados.Items.Add("Juzgado 10");
            cmbObjetos.Items.Add("Accidente");
            cmbObjetos.Items.Add("Amparo");
            cmbObjetos.Items.Add("Despido");
            cmbObjetos.Items.Add("Diferencia salario");
            cmbObjetos.Items.Add("Ejecuciòn de credito");
            cmbEdad.Items.Add("18-22");
            cmbEdad.Items.Add("23-30");
            cmbEdad.Items.Add("31-38");
            cmbEdad.Items.Add("39-47");
            cmbEdad.Items.Add("48-65");
            Actualizar();
        }
        /// <summary>
        /// Actualiza los datos y avisa que hubo una nueva causa
        /// </summary>
        private void AvisarHayCambios()
        {
            Actualizar();
            MessageBox.Show("Se creó una nueva causa, cambió la estadística.", "Alerta",MessageBoxButtons.OK);
        }
        /// <summary>
        /// Actualiza los datos
        /// </summary>
        private void Actualizar()
        {
            cantidadDeCausas = causas.Count;
            lblTitulo.Text = $"CANTIDAD DE CAUSAS: {cantidadDeCausas}";
            SeleccionarPorGenero();
            SelecionDeJuzgados();
            SelecionarObjeto();
            SelecionarEdad();
            BuscarRangoEtarioConMasCausasDeDespido();
        }
        /// <summary>
        /// Suma la cantidad de causas con género femenino y cantidad de causas con género femenino y con objeto diferencia salarial
        /// </summary>
        /// <param name="cantidadFemeninoDiferenciaSalarial"></param> suma de causas con género femenino y con objeto diferencia salarial
        /// <param name="cantidadDeActoras"></param> cantidad de causas con género femenino
        private void FiltrarFemeninas(ref int cantidadFemeninoDiferenciaSalarial, ref int cantidadDeActoras)
        {
            foreach (Causa c in causas)
            {
                if (c.Actor.GeneroActor == Actor.Genero.Femenino)
                {
                    cantidadDeActoras++;
                    if (c.ObjetoCausa == Causa.Objeto.DirefenciaSalario)
                    {
                        cantidadFemeninoDiferenciaSalarial++;
                    }
                }
            }
        }
        /// <summary>
        /// Suma la cantidad de causas con género masculino y cantidad de causas con género masculino y con objeto diferencia salarial
        /// </summary>
        /// <param name="cantidadMasculinoDiferenciaSalarial"></param>
        /// <param name="cantidadDeActores"></param>
        private void FiltrarMasculinos(ref int cantidadMasculinoDiferenciaSalarial, ref int cantidadDeActores)
        {
            foreach (Causa c in causas)
            {
                if (c.Actor.GeneroActor == Actor.Genero.Masculino)
                {
                    cantidadDeActores++;
                    if (c.ObjetoCausa == Causa.Objeto.DirefenciaSalario)
                    {
                        cantidadMasculinoDiferenciaSalarial++;
                    }
                }
            }
        }
        /// <summary> SE USA METODOS DE EXTENSIÓN
        /// Filtra las causas calculo sus porventaje y lo refleja en el formulario por género y muestra que género tiene mas causas por diferencia salarial
        /// </summary>
        private void SeleccionarPorGenero()
        {
            int cantidadFemeninoDiferenciaSalarial = 0;
            int cantidadMasculinoDiferenciaSalarial = 0;
            int cantidadDeActoras = 0;
            int cantidadDeActores = 0;
            FiltrarFemeninas(ref cantidadFemeninoDiferenciaSalarial, ref cantidadDeActoras);
            FiltrarMasculinos(ref cantidadMasculinoDiferenciaSalarial, ref cantidadDeActores);
            lblCantidadFem.Text = $"CANTIDAD:  {cantidadDeActoras}";
            lblCantidadMasc.Text = $"CANTIDAD:  {cantidadDeActores}";
            if (cantidadDeCausas > 0)
            {
                lblPorcentajeFem.Text = $"PROCENTAJE:  {cantidadDeActoras.Promedio(cantidadDeCausas).ToString("00.00")}%";
                lblPorcentajeMasc.Text = $"PROCENTAJE:  {cantidadDeActores.Promedio(cantidadDeCausas).ToString("00.00")}%";
            }
            else
            {
                lblPorcentajeFem.Text = $"PROCENTAJE:  00.00%";
                lblPorcentajeMasc.Text = $"PROCENTAJE:  00.00%";
            }
            if(cantidadMasculinoDiferenciaSalarial > cantidadFemeninoDiferenciaSalarial)
            {
                lblGeneroConMasCausasDifSal.Text = "MASCULINO";
            }
            else
            {
                if(cantidadFemeninoDiferenciaSalarial > cantidadMasculinoDiferenciaSalarial)
                {
                    lblGeneroConMasCausasDifSal.Text = "FEMENINO";
                }
                else
                {
                    lblGeneroConMasCausasDifSal.Text = "AMBOS POR\nIGUAL";
                }
            }
        }
        /// <summary>
        /// cuanta la cantidad de causas que hay por algun juzgado especifico
        /// </summary>
        /// <param name="numeroJuzgado"></param> numero de juzgado
        /// <returns></returns>
        private int FiltrarPorJuzgados(int numeroJuzgado)
        {
            int cantidad = 0;
            foreach (Causa c in causas)
            {
                if (c.Juzgado.NumeroIdentificacion == numeroJuzgado)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        /// <summary> SE USA METODOS DE EXTENSIÓN
        /// Selecciona el juzgado con el que se van a basar para filtrar y contar las causas correspondientes a él, luego refleja los resultados en el formulario
        /// </summary>
        private void SelecionDeJuzgados()
        {
            int cantidad = 0;
            switch (cmbJuzgados.SelectedIndex)
            {
                case 0:
                    cantidad = FiltrarPorJuzgados(1);
                    break;
                case 1:
                    cantidad = FiltrarPorJuzgados(2);
                    break;
                case 2:
                    cantidad = FiltrarPorJuzgados(3);
                    break;
                case 3:
                    cantidad = FiltrarPorJuzgados(4);
                    break;
                case 4:
                    cantidad = FiltrarPorJuzgados(5);
                    break;
                case 5:
                    cantidad = FiltrarPorJuzgados(6);
                    break;
                case 6:
                    cantidad = FiltrarPorJuzgados(7);
                    break;
                case 7:
                    cantidad = FiltrarPorJuzgados(8);
                    break;
                case 8:
                    cantidad = FiltrarPorJuzgados(9);
                    break;
                case 9:
                    cantidad = FiltrarPorJuzgados(10);
                    break;
            }
            lblJuzgadosCantidad.Text = $"CANTIDAD:  {cantidad}";
            if(cantidadDeCausas > 0)
            {
                lblJuzgadosPorcentaje.Text = $"PORCENTAJE:  {cantidad.Promedio(cantidadDeCausas).ToString("00.00")}%";
            }
            else
            {
                lblJuzgadosPorcentaje.Text = $"PROCENTAJE:  00.00%";
            }
        }
        /// <summary>
        /// Filtra la cantidad de todas las causas por un objeto especifico y tambien por objeto y este año
        /// </summary>
        /// <param name="objeto"></param> indica el objeto por el cual se va a filtrar
        /// <param name="cantidadEsteAnio"></param> indicara la suma de la cantidad de causas con el objeto indicado en este año
        /// <param name="causasPorAnio"></param> indicara el total de causas sumadas con el objeto indicado
        /// <returns></returns>
        private int FiltrarPorObjeto(Causa.Objeto objeto, ref int cantidadEsteAnio, ref int causasPorAnio)
        {
            int cantidad = 0;
            foreach (Causa c in causas)
            {
                if (c.ObjetoCausa == objeto)
                {
                    cantidad++;
                    if(c.FechaAsignacion.Year == DateTime.Now.Year)
                    {
                        cantidadEsteAnio ++;
                    }
                }
            }
            foreach (Causa c in causas)
            {
                if(c.FechaAsignacion.Year == DateTime.Now.Year)
                {
                    causasPorAnio ++;
                }
            }
            return cantidad;
        }
        /// <summary> SE USA METODOS DE EXTENSIÓN
        /// Filtra por objeto y este año y tambien por objeto solo, reflejara en el formulario los resultados
        /// </summary>
        private void SelecionarObjeto()
        {
            int cantidadEsteAnio = 0;
            int causasPorAnio = 0;
            int cantidad = 0;
            switch (cmbObjetos.SelectedIndex)
            {
                case 0:
                    cantidad = FiltrarPorObjeto(Causa.Objeto.Accidente, ref cantidadEsteAnio, ref causasPorAnio);
                    break;
                case 1:
                    cantidad = FiltrarPorObjeto(Causa.Objeto.Amparo, ref cantidadEsteAnio, ref causasPorAnio);
                    break;
                case 2:
                    cantidad = FiltrarPorObjeto(Causa.Objeto.Despido, ref cantidadEsteAnio, ref causasPorAnio);
                    break;
                case 3:
                    cantidad = FiltrarPorObjeto(Causa.Objeto.DirefenciaSalario, ref cantidadEsteAnio, ref causasPorAnio);
                    break;
                case 4:
                    cantidad = FiltrarPorObjeto(Causa.Objeto.EjecucionDeCredito, ref cantidadEsteAnio, ref causasPorAnio);
                    break;
            }
            lblCantidadObjetos.Text = $"CANTIDAD TOTAL:  {cantidad}";
            lblCantidadPorAño.Text = $"CANTIDAD EN ESTE AÑO: {cantidadEsteAnio}";
            if (cantidadDeCausas > 0 && causasPorAnio > 0)
            {
                lblPorcentajeObjetos.Text = $"PORCENTAJE TOTAL:  {cantidad.Promedio(cantidadDeCausas).ToString("00.00")}%";
                lblPorcentajeAnual.Text = $"PORCENTAJE EN ESTE AÑO: {cantidadEsteAnio.Promedio(causasPorAnio).ToString("00.00")}%";
            }
            else
            {
                lblPorcentajeObjetos.Text = $"PORCENTAJE TOTAL:  00.00%";
                lblPorcentajeAnual.Text = $"PORCENTAJE EN ESTE AÑO: 00.00%";
            }
        }
        /// <summary>
        /// Filtra por rango etario la cantidad de causas
        /// </summary>
        /// <param name="edadMinima"></param>
        /// <param name="edadMaxima"></param>
        /// <param name="listadoCausas"></param>
        /// <returns></returns>
        private int FiltrarPorEdad(int edadMinima, int edadMaxima, List<Causa> listadoCausas)
        {
            int cantidad = 0;
            foreach (Causa c in listadoCausas)
            {
                int edad = DateTime.Now.Year -  c.Actor.FechaNacimiento.Year; 
                if (edad >= edadMinima && edad <= edadMaxima)
                {
                    cantidad++;
                }
            }
            return cantidad;
        }
        /// <summary> SE USA METODOS DE EXTENSIÓN
        /// Selecciona el rango etario indicado para filtrar las causas correspondientes y reflejar los resultados en el formulario
        /// </summary>
        private void SelecionarEdad()
        {
            int cantidad = 0;
            switch (cmbEdad.SelectedIndex)
            {
                case 0: 
                    cantidad = FiltrarPorEdad(18, 22, causas);
                    break;
                case 1:
                    cantidad = FiltrarPorEdad(23, 30, causas);
                    break;
                case 2:
                    cantidad = FiltrarPorEdad(31,38, causas);
                    break;
                case 3:
                    cantidad = FiltrarPorEdad(39, 47, causas);
                    break;
                case 4:
                    cantidad = FiltrarPorEdad(48, 65, causas);
                    break;
            }
            lblEdadCantidad.Text = $"CANTIDAD:  {cantidad}";
            if (cantidadDeCausas > 0)
            {
                lblEdadPorcentaje.Text = $"PORCENTAJE:  {cantidad.Promedio(cantidadDeCausas).ToString("00.00")}%";
            }
            else
            {
                lblEdadPorcentaje.Text = $"PORCENTAJE:  00.00%";
            }
        }
        /// <summary>
        /// Devuelve el rango en un string
        /// </summary>
        /// <param name="posicion"></param>
        /// <returns></returns>
        private string AsignacionDeRangos(int posicion)
        {
            string resultado = "";
            switch (posicion)
            {
                case 0:
                    resultado = "18 A 22\n";
                    break;
                case 1:
                    resultado = "23 A 30\n";
                    break;
                case 2:
                    resultado = "31 A 38\n";
                    break;
                case 3:
                    resultado = "39 A 47\n";
                    break;
                case 4:
                    resultado = "46 A 65\n";
                    break;
            }
            return resultado;
        }
        /// <summary>
        /// Filtra las causas con el objeto despido
        /// </summary>
        /// <param name="causasFiltradas"></param> true si hay causas, false si no hay
        /// <returns></returns>
        private bool FiltrarCausasDespido(List<Causa> causasFiltradas)
        {
            bool hayCausas = false;
            foreach (Causa c in causas)
            {
                if (c.ObjetoCausa == Causa.Objeto.Despido)
                {
                    causasFiltradas.Add(c);
                    hayCausas = true;
                }
            }
            return hayCausas;
        }
        /// <summary>
        /// busca que rango etario tiene mas causas por despido y los muestra donde corresponde en el formulario
        /// </summary>
        /// <param name="causasFiltradas"></param>
        private void FiltrarPorRangoEtario(List<Causa> causasFiltradas)
        {
            StringBuilder sb = new StringBuilder();
            int cantidadMaxima = 0;
            int grupo1 = FiltrarPorEdad(18, 22, causasFiltradas);
            int grupo2 = FiltrarPorEdad(23, 30, causasFiltradas);
            int grupo3 = FiltrarPorEdad(31, 38, causasFiltradas);
            int grupo4 = FiltrarPorEdad(39, 47, causasFiltradas);
            int grupo5 = FiltrarPorEdad(46, 65, causasFiltradas);
            List<int> listadoCantidades = new List<int>() { grupo1, grupo2, grupo3, grupo4, grupo5 };
            for (int i = 0; i < 5; i++)
            {
                if (listadoCantidades[i] > cantidadMaxima)
                {
                    cantidadMaxima = listadoCantidades[i];
                }
            }
            List<int> cantidadesRepetidas = new List<int>();
            for (int i = 0; i < 5; i++)
            {
                if (listadoCantidades[i] == cantidadMaxima)
                {
                    cantidadesRepetidas.Add(i);
                }
            }
            for (int i = 0; i < cantidadesRepetidas.Count; i++)
            {
                int posicionDeRepetidas = cantidadesRepetidas[i];
                sb.Append(AsignacionDeRangos(posicionDeRepetidas));
            }
            lblEdadConMasCausasDesp.Text = sb.ToString();
        }
        /// <summary>
        /// Si hay causas con despido busca el rando etario con mas causas y lo muestra en donde corresponda en el formulario, y si no, muestra "-"
        /// </summary>
        private void BuscarRangoEtarioConMasCausasDeDespido()
        {
            List<Causa> causasFiltradas = new List<Causa>();
            
            if (FiltrarCausasDespido(causasFiltradas))
            {
                FiltrarPorRangoEtario(causasFiltradas);
            }
            else
            {
                lblEdadConMasCausasDesp.Text = "-";
            }
        }
        /// <summary>
        /// Antes de cerrar el formulario pregunta si esta seguro al usuario
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormEstadicticas_FormClosing(object sender, FormClosingEventArgs e)
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
        /// cada vez que se cambie la eleccion del combo box del objeto, se actualizara los resultados segun la opcion requerida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }
        /// <summary>
        /// cada vez que se cambie la eleccion del combo box de la edad, se actualizara los resultados segun la opcion requerida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarEdad();
        }
        /// <summary>
        /// cada vez que se cambie la eleccion del combo box de juzgados, se actualizara los resultados segun la opcion requerida.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbJuzgados_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionDeJuzgados();
        }
        /// <summary>
        /// Permitira minimizar la ventana
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        /// <summary>
        /// Perminitira mover la ventana
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
