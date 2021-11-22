using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CamaraNacional
{
    public partial class FormIniciarCausa : Form
    {
        private Actor actor;
        private Abogado abogado;
        private Demandado demandado;
        private FormActor formActor;
        private FormAbogado formAbogado;
        private FormDemandado formDemandado;
        private FormAsignarJuzgado FormAsignarJuzgado;
        private List<Causa> causas;
        private List<Juzgado> juzgados;
        private Serializador<List<Causa>> serializadorCausas;
        //private Serializador<List<Juzgado>> serializadorJuzgados;
        //CancellationTokenSource cancellationTokenSource;
        private Form formHijoActual;
        
        
        public FormIniciarCausa(List<Causa> causas, List<Juzgado> juzgados)
        {
            InitializeComponent();
            this.causas = causas;
            this.juzgados = juzgados;
            actor = new Actor();
            abogado = new Abogado();
            demandado = new Demandado();
            formActor = new FormActor(actor);
            formAbogado = new FormAbogado(abogado);
            formDemandado = new FormDemandado(demandado);
            FormAsignarJuzgado = new FormAsignarJuzgado(causas, juzgados, actor, abogado, demandado);
        }

        public void abrirFormularioHijo(Form formHijo)
        {
            formHijoActual = formHijo;
            formHijo.TopLevel = false;
            formHijo.Dock = DockStyle.Fill;
            panelEscritorio.Controls.Add(formHijo);
            panelEscritorio.Tag = formHijo;
            formHijo.BringToFront();
            formHijo.Show();
        }
        private void FormIniciarCausa_Load(object sender, EventArgs e)
        {
            formActor.termino += Terminar;
            formAbogado.termino += Terminar;
            formDemandado.termino += Terminar;
        }
        private void Terminar(int paso)
        {
            switch(paso)
            {
                case 1:
                    btnActor.Enabled = false;
                    btnAbogado.Enabled = true;
                    break;
                case 2:
                    btnAbogado.Enabled = false;
                    btnDemandado.Enabled = true;
                    break;
                case 3:
                    btnDemandado.Enabled = false;
                    btnJuzgado.Enabled = true;
                    break;
            }
            
            if (formHijoActual != null)
            {
                formHijoActual.Close();
            }
        }

        private void CargarFormularios()
        {

            ////cancellationTokenSource = new CancellationTokenSource();
            ////CancellationToken cancellationToken = cancellationTokenSource.Token;
            
            ////Task hiloActor = Task.Run(() => abrirFormularioHijo(formActor), cancellationToken);
            //////abrirFormularioHijo(formActor);
            //////if(Terminar())
            //////{
            //////    lblActor.BackColor = Color.FromArgb(86, 76, 77);
            //////    lblAbogado.BackColor = Color.FromArgb(109, 97, 107);
            //////    abrirFormularioHijo(formAbogado);
            //////}
            ////hiloActor.Wait();
            ////Task hiloAbogado = Task.Run(() => abrirFormularioHijo(formAbogado), cancellationToken);
            ////hiloAbogado.Wait();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormIniciarCausa_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                this.DialogResult = DialogResult.Cancel;
                e.Cancel = true;
            }
        }

        private void btnActor_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formActor);
            btnAbogado.Enabled = false;
            btnDemandado.Enabled = false;
            btnJuzgado.Enabled = false;
        }

        private void btnAbogado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formAbogado);
        }

        private void btnDemandado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(formDemandado);
        }

        private void btnJuzgado_Click(object sender, EventArgs e)
        {
            abrirFormularioHijo(FormAsignarJuzgado);
        }
    }
}
