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
    public partial class FormEstadicticas : Form
    {
        private List<Causa> causas;
        private List<Juzgado> juzgados;
        private int cantidadDeCausas;
        public FormEstadicticas(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
        }
        
        private void FormEstadicticas_Load(object sender, EventArgs e)
        {
            FormAsignarJuzgado formAsignarJuzgado = new FormAsignarJuzgado(null, null, null, null, null);
            formAsignarJuzgado.evento += AvisarHayCambios;
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
        private void AvisarHayCambios()
        {
            Actualizar();
            MessageBox.Show("Se creo una nueva causa, cambió la estadística.", "Alerta",MessageBoxButtons.OK);
        }
        private void Actualizar()
        {
            cantidadDeCausas = causas.Count;
            lblTitulo.Text = $"CANTIDAD DE CAUSAS: {cantidadDeCausas}";
            SeleccionarPorGenero();
            SelecionDeJuzgados();
            SelecionarObjeto();
            SelecionarEdad();
        }
        private void SeleccionarPorGenero()
        {
            int cantidadDeActoras = 0;
            int cantidadDeActores = 0;
            foreach (Causa c in causas)
            {
                if (c.Actor.GeneroActor == Actor.Genero.Femenino)
                {
                    cantidadDeActoras++;
                }
            }
            foreach (Causa c in causas)
            {
                if (c.Actor.GeneroActor == Actor.Genero.Masculino)
                {
                    cantidadDeActores++;
                }
            }
            lblCantidadFem.Text = $"CANTIDAD:\t{cantidadDeActoras}";
            lblPorcentajeFem.Text = $"PROCENTAJE:\t{(cantidadDeActoras * 100) / cantidadDeCausas}%";
            lblCantidadMasc.Text = $"CANTIDAD:\t{cantidadDeActores}";
            lblPorcentajeMasc.Text = $"PROCENTAJE:\t{(cantidadDeActores * 100) / cantidadDeCausas}%";
        }
        private void FiltrarPorJuzgados(int numeroJuzgado)
        {
            int cantidad = 0;
            foreach (Causa c in causas)
            {
                if (c.Juzgado.NumeroIdentificacion == numeroJuzgado)
                {
                    cantidad++;
                }
            }
            lblJuzgadosCantidad.Text = $"CANTIDAD:\t{cantidad}";
            lblJuzgadosPorcentaje.Text = $"PORCENTAJE:\t{(cantidad*100)/cantidadDeCausas}%";
        }
        private void SelecionDeJuzgados()
        {
            switch (cmbJuzgados.SelectedIndex)
            {
                case 0:
                    FiltrarPorJuzgados(1);
                    break;
                case 1:
                    FiltrarPorJuzgados(2);
                    break;
                case 2:
                    FiltrarPorJuzgados(3);
                    break;
                case 3:
                    FiltrarPorJuzgados(4);
                    break;
                case 4:
                    FiltrarPorJuzgados(5);
                    break;
                case 5:
                    FiltrarPorJuzgados(6);
                    break;
                case 6:
                    FiltrarPorJuzgados(7);
                    break;
                case 7:
                    FiltrarPorJuzgados(8);
                    break;
                case 8:
                    FiltrarPorJuzgados(9);
                    break;
                case 9:
                    FiltrarPorJuzgados(10);
                    break;
            }
        }
        private void FiltrarPorObjeto(Causa.Objeto objeto)
        {
            int cantidad = 0;
            foreach (Causa c in causas)
            {
                if (c.ObjetoCausa == objeto)
                {
                    cantidad++;
                }
            }
            lblCantidadObjetos.Text = $"CANTIDAD:\t{cantidad}";
            lblPorcentajeObjetos.Text = $"PORCENTAJE:\t{(cantidad * 100)/cantidadDeCausas}%";
        }
        private void SelecionarObjeto()
        {
            switch (cmbObjetos.SelectedIndex)
            {
                case 0:
                    FiltrarPorObjeto(Causa.Objeto.Accidente);
                    break;
                case 1:
                    FiltrarPorObjeto(Causa.Objeto.Amparo);
                    break;
                case 2:
                    FiltrarPorObjeto(Causa.Objeto.Despido);
                    break;
                case 3:
                    FiltrarPorObjeto(Causa.Objeto.DirefenciaSalario);
                    break;
                case 4:
                    FiltrarPorObjeto(Causa.Objeto.EjecucionDeCredito);
                    break;
            }
        }
        private void FiltrarPorEdad(int edadMinima, int edadMaxima)
        {
            int cantidad = 0;
            foreach (Causa c in causas)
            {
                int edad = DateTime.Now.Year -  c.Actor.FechaNacimiento.Year; 
                if (edad >= edadMinima && edad <= edadMaxima)
                {
                    cantidad++;
                }
            }
            lblEdadCantidad.Text = $"CANTIDAD:\t{cantidad}";
            lblEdadPorcentaje.Text = $"PORCENTAJE:\t{(cantidad * 100) / cantidadDeCausas}%";
        }
        private void SelecionarEdad()
        {
            switch (cmbEdad.SelectedIndex)
            {
                case 0: 
                    FiltrarPorEdad(18, 22);
                    break;
                case 1: 
                    FiltrarPorEdad(23, 30);
                    break;
                case 2: 
                    FiltrarPorEdad(31,38);
                    break;
                case 3: 
                    FiltrarPorEdad(39, 47);
                    break;
                case 4: 
                    FiltrarPorEdad(48, 65);
                    break;
            }
        }

        private void FormEstadicticas_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        private void lblSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmbObjetos_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarObjeto();
        }

        private void cmbEdad_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionarEdad();
        }

        private void cmbJuzgados_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelecionDeJuzgados();
        }
    }
}
