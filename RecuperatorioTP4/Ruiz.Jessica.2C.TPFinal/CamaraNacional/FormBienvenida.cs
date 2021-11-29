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
    public partial class FormBienvenida : Form
    {
        /// <summary>
        /// Constructor sin parametros
        /// </summary>
        public FormBienvenida()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Aumenta la opacidad y la circular progress bar, cuando la opacidad llega a 100 inicia el timer2
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            if(this.Opacity < 1)
            {
                this.Opacity += 0.05;

            }
            cpbBienvenida.Value += 1;
            cpbBienvenida.Text = cpbBienvenida.Value.ToString();
            if(cpbBienvenida.Value == 100)
            {
                timer1.Stop();
                timer2.Start();
            }
        }
        /// <summary>
        /// baja la opacidad y cuando llega a 0 cierra el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            this.Opacity -= 0.1;
            if(this.Opacity == 0)
            {
                timer2.Stop();
                this.Close();
            }
        }
        /// <summary>
        /// Pone el form transparente, indica valores maximos y minimos al circular progress bar e inicia el timer1
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormBienvenida_Load(object sender, EventArgs e)
        {
            this.Opacity = 0.0;
            cpbBienvenida.Value = 0;
            cpbBienvenida.Minimum = 0;
            cpbBienvenida.Maximum = 100;
            timer1.Start();
        }
    }
}
