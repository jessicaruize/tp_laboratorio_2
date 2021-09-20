using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        /// <summary>
        /// Constructor por defecto de la clase form calculadora.
        /// Inicializa el comboBox vacio + - * / 
        /// centra los textBox y pone a la derecha el label
        /// </summary>
        public FormCalculadora()
        {
            InitializeComponent();
            this.cmbOperador.DropDownStyle = ComboBoxStyle.DropDownList;
            this.cmbOperador.Items.Add("");
            this.cmbOperador.Items.Add('+');
            this.cmbOperador.Items.Add('-');
            this.cmbOperador.Items.Add('*');
            this.cmbOperador.Items.Add('/');
            txtNumero1.TextAlign = HorizontalAlignment.Center;
            txtNumero2.TextAlign = HorizontalAlignment.Center;
            lblResultado.TextAlign = ContentAlignment.MiddleRight;
        }

        /// <summary>
        /// al iniciar limpia el form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_Load(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Limpia al form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        /// <summary>
        /// Pone los textBox en vacio. el label resultado en 0. bloquea los botones y deja el foto en el textBox numero1
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = "";
            this.txtNumero2.Text = "";
            this.cmbOperador.Text = "";
            this.lblResultado.Text = "0";
            this.btnConvertirABinario.Enabled = false;
            this.btnConvertirADecimal.Enabled = false;
            this.btnLimpiar.Enabled = false;
            this.btnOperar.Enabled = false;
            this.txtNumero1.Focus();
        }
        /// <summary>
        /// Recibe datos los cuales genera operaciones segun el operador recibido
        /// </summary>
        /// <param name="numero1"></param>primer numero a operar
        /// <param name="numero2"></param>segundo numero a operar
        /// <param name="operador"></param>puede ser + - / *, si no, lo toma como un +.
        /// <returns></returns>retorna el resultado.
        private static double Operar(string numero1, string numero2, string operador)
        {
            return Calculadora.Operar(new Operando(numero1), new Operando(numero2), operador[0]);
        }

        /// <summary>
        /// Habilita los botones.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_TextChanged(object sender, EventArgs e)
        {
                this.btnConvertirABinario.Enabled = true;
                this.btnConvertirADecimal.Enabled = true;
                this.btnLimpiar.Enabled = true;
                this.btnOperar.Enabled = true;   
        }


        /// <summary>
        /// Genera el resultado y lo muestra.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOperar_Click(object sender, EventArgs e)
        {
            string auxiliar;
            if(this.txtNumero1.Text == "" || this.txtNumero2.Text == "")
            {
                MessageBox.Show("No puede quedar ninguna casilla de los operandos vacia.", "Error.", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if(this.txtNumero1.Text == "")
                {
                    this.txtNumero1.Focus();
                }
                else
                {
                    this.txtNumero2.Focus();
                }
            }
            else
            {
                if (this.cmbOperador.Text == "")
                {
                    auxiliar = "+";
                }
                else
                {
                    auxiliar = this.cmbOperador.Text;
                }
                this.lblResultado.Text = (Operar(this.txtNumero1.Text, this.txtNumero2.Text, auxiliar)).ToString();
                this.lstOperaciones.Items.Add(this.txtNumero1.Text + " " + auxiliar + " " + this.txtNumero2.Text + " = " + this.lblResultado.Text + "\n");
            }
        }


        /// <summary>
        /// Cada vez que el usuario desea salir le muestra un mensaje para corroborar que este seguro. Si no lo esta, cancela el cierre del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("¿Esta seguro de salir?", "Salida", MessageBoxButtons.YesNo) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }

        /// <summary>
        /// Cada vez que el usuario desea salir le muestra un mensaje para corroborar que este seguro. Si no lo esta, cancela el cierre del form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        /// <summary>
        /// Convierte un decimal en binario, de no poder avisa que es un valor invàlido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string auxiliar = this.lblResultado.Text;
            if(double.TryParse(this.lblResultado.Text, out double aux))
            {
                Operando num = new Operando(this.lblResultado.Text);
                this.lblResultado.Text = num.DecimalBinario(aux);
                this.lstOperaciones.Items.Add(auxiliar + " a Binario: " + this.lblResultado.Text);
            }
            else
            {
                this.lblResultado.Text = "Valor invàlido.";
            }
            
        }

        /// <summary>
        /// Convierte un binario a decimal, de no poder avisa que es un nùmero invàido.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string auxiliar = this.lblResultado.Text;
            Operando num = new Operando(lblResultado.Text);
            this.lblResultado.Text = num.BinarioDecimal(lblResultado.Text);
            this.lstOperaciones.Items.Add(auxiliar + " a Decimal: " + this.lblResultado.Text);
        }

        /// <summary>
        /// Solo permite ingresar valores vàlidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero1_KeyPress(object sender, KeyPressEventArgs e)
        {
            int contadosComa = 0;
            if(e.KeyChar == ',' || e.KeyChar == '.')
            {
                if(txtNumero1.Text.Length > 0)
                {
                    foreach(char c in txtNumero1.Text)
                    {
                        if(c == ',')
                        {
                            contadosComa++;
                        }
                    }
                    if(contadosComa == 0)
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
                if(e.KeyChar == '-' || e.KeyChar == '+' )
                {
                    if(!(txtNumero1.Text.Length == 0))
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo es posible ingresar + y - al principio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if(!char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Esta ingresando caracteres invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
            
            
        }

        /// <summary>
        /// Solo permite ingresar valores vàlidos.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtNumero2_KeyPress(object sender, KeyPressEventArgs e)
        {
            int contadorComa = 0;
            if (e.KeyChar == ',' || e.KeyChar == '.')
            {
                if (txtNumero2.Text.Length > 0)
                {
                    foreach (char c in txtNumero2.Text)
                    {
                        if (c == ',')
                        {
                            contadorComa++;
                        }
                    }
                    if (contadorComa == 0)
                    {
                        e.KeyChar = ',';
                    }
                    else
                    {
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
                if (e.KeyChar == '-' || e.KeyChar == '+')
                {
                    if (!(txtNumero2.Text.Length == 0))
                    {
                        e.Handled = true;
                        MessageBox.Show("Solo es posible ingresar + y - al principio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (!char.IsNumber(e.KeyChar))
                    {
                        e.Handled = true;
                        MessageBox.Show("Esta ingresando caracteres invalidos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void txtNumero1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero1_KeyDown(object sender, KeyEventArgs e)
        {
        }
    }
}
