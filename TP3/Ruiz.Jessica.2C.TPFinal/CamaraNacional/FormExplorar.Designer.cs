
namespace CamaraNacional
{
    partial class FormExplorar
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSalir = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rbJuzgados = new System.Windows.Forms.RadioButton();
            this.rbCausas = new System.Windows.Forms.RadioButton();
            this.rbCausasMontoSuperior = new System.Windows.Forms.RadioButton();
            this.rbCausasMontoInferior = new System.Windows.Forms.RadioButton();
            this.rbCausasObjeto = new System.Windows.Forms.RadioButton();
            this.rbCausasJuzgado = new System.Windows.Forms.RadioButton();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.rbCausaEspecifica = new System.Windows.Forms.RadioButton();
            this.lblIndicacion = new System.Windows.Forms.Label();
            this.txtValor = new System.Windows.Forms.TextBox();
            this.cmbEleccion = new System.Windows.Forms.ComboBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.epTxt = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(725, 21);
            this.panel1.TabIndex = 0;
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(55)))), ((int)(((byte)(28)))));
            this.lblSalir.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblSalir.Location = new System.Drawing.Point(695, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(30, 24);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "X";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.panel2.Controls.Add(this.rbJuzgados);
            this.panel2.Controls.Add(this.rbCausas);
            this.panel2.Controls.Add(this.rbCausasMontoSuperior);
            this.panel2.Controls.Add(this.rbCausasMontoInferior);
            this.panel2.Controls.Add(this.rbCausasObjeto);
            this.panel2.Controls.Add(this.rbCausasJuzgado);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.rbCausaEspecifica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 21);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 373);
            this.panel2.TabIndex = 1;
            // 
            // rbJuzgados
            // 
            this.rbJuzgados.AutoSize = true;
            this.rbJuzgados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbJuzgados.Location = new System.Drawing.Point(27, 319);
            this.rbJuzgados.Name = "rbJuzgados";
            this.rbJuzgados.Size = new System.Drawing.Size(177, 23);
            this.rbJuzgados.TabIndex = 6;
            this.rbJuzgados.TabStop = true;
            this.rbJuzgados.Text = "Todos los juzgados";
            this.rbJuzgados.UseVisualStyleBackColor = true;
            this.rbJuzgados.CheckedChanged += new System.EventHandler(this.rbJuzgados_CheckedChanged);
            // 
            // rbCausas
            // 
            this.rbCausas.AutoSize = true;
            this.rbCausas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausas.Location = new System.Drawing.Point(27, 279);
            this.rbCausas.Name = "rbCausas";
            this.rbCausas.Size = new System.Drawing.Size(159, 23);
            this.rbCausas.TabIndex = 5;
            this.rbCausas.TabStop = true;
            this.rbCausas.Text = "Todas las causas";
            this.rbCausas.UseVisualStyleBackColor = true;
            this.rbCausas.CheckedChanged += new System.EventHandler(this.rbCausas_CheckedChanged);
            // 
            // rbCausasMontoSuperior
            // 
            this.rbCausasMontoSuperior.AutoSize = true;
            this.rbCausasMontoSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasMontoSuperior.Location = new System.Drawing.Point(27, 240);
            this.rbCausasMontoSuperior.Name = "rbCausasMontoSuperior";
            this.rbCausasMontoSuperior.Size = new System.Drawing.Size(318, 23);
            this.rbCausasMontoSuperior.TabIndex = 4;
            this.rbCausasMontoSuperior.TabStop = true;
            this.rbCausasMontoSuperior.Text = "Causas con monto superior a un valor";
            this.rbCausasMontoSuperior.UseVisualStyleBackColor = true;
            this.rbCausasMontoSuperior.CheckedChanged += new System.EventHandler(this.rbCausasMontoSuperior_CheckedChanged);
            // 
            // rbCausasMontoInferior
            // 
            this.rbCausasMontoInferior.AutoSize = true;
            this.rbCausasMontoInferior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasMontoInferior.Location = new System.Drawing.Point(27, 200);
            this.rbCausasMontoInferior.Name = "rbCausasMontoInferior";
            this.rbCausasMontoInferior.Size = new System.Drawing.Size(308, 23);
            this.rbCausasMontoInferior.TabIndex = 3;
            this.rbCausasMontoInferior.TabStop = true;
            this.rbCausasMontoInferior.Text = "Causas con monto inferior a un valor";
            this.rbCausasMontoInferior.UseVisualStyleBackColor = true;
            this.rbCausasMontoInferior.CheckedChanged += new System.EventHandler(this.rbCausasMontoInferior_CheckedChanged);
            // 
            // rbCausasObjeto
            // 
            this.rbCausasObjeto.AutoSize = true;
            this.rbCausasObjeto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasObjeto.Location = new System.Drawing.Point(27, 160);
            this.rbCausasObjeto.Name = "rbCausasObjeto";
            this.rbCausasObjeto.Size = new System.Drawing.Size(254, 23);
            this.rbCausasObjeto.TabIndex = 2;
            this.rbCausasObjeto.TabStop = true;
            this.rbCausasObjeto.Text = "Causas con Objeto específico";
            this.rbCausasObjeto.UseVisualStyleBackColor = true;
            this.rbCausasObjeto.CheckedChanged += new System.EventHandler(this.rbCausasObjeto_CheckedChanged);
            // 
            // rbCausasJuzgado
            // 
            this.rbCausasJuzgado.AutoSize = true;
            this.rbCausasJuzgado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasJuzgado.Location = new System.Drawing.Point(27, 121);
            this.rbCausasJuzgado.Name = "rbCausasJuzgado";
            this.rbCausasJuzgado.Size = new System.Drawing.Size(280, 23);
            this.rbCausasJuzgado.TabIndex = 1;
            this.rbCausasJuzgado.TabStop = true;
            this.rbCausasJuzgado.Text = "Causas de un juzgado específico";
            this.rbCausasJuzgado.UseVisualStyleBackColor = true;
            this.rbCausasJuzgado.CheckedChanged += new System.EventHandler(this.rbCausasJuzgado_CheckedChanged);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblTitulo.Location = new System.Drawing.Point(49, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "EXPLORAR";
            // 
            // rbCausaEspecifica
            // 
            this.rbCausaEspecifica.AutoSize = true;
            this.rbCausaEspecifica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausaEspecifica.Location = new System.Drawing.Point(27, 78);
            this.rbCausaEspecifica.Name = "rbCausaEspecifica";
            this.rbCausaEspecifica.Size = new System.Drawing.Size(157, 23);
            this.rbCausaEspecifica.TabIndex = 0;
            this.rbCausaEspecifica.TabStop = true;
            this.rbCausaEspecifica.Text = "Causa específica";
            this.rbCausaEspecifica.UseVisualStyleBackColor = true;
            this.rbCausaEspecifica.CheckedChanged += new System.EventHandler(this.rbCausaEspecifica_CheckedChanged);
            // 
            // lblIndicacion
            // 
            this.lblIndicacion.AutoSize = true;
            this.lblIndicacion.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblIndicacion.Location = new System.Drawing.Point(396, 106);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(65, 24);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "label2";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.DarkGray;
            this.txtValor.Location = new System.Drawing.Point(415, 181);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(204, 23);
            this.txtValor.TabIndex = 3;
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.BackColor = System.Drawing.Color.DarkGray;
            this.cmbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Location = new System.Drawing.Point(415, 201);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(204, 23);
            this.cmbEleccion.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(107)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.btnBuscar.Location = new System.Drawing.Point(527, 290);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(176, 82);
            this.btnBuscar.TabIndex = 7;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // epTxt
            // 
            this.epTxt.ContainerControl = this;
            // 
            // FormExplorar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.ClientSize = new System.Drawing.Size(725, 394);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExplorar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExplorar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExplorar_FormClosing);
            this.Load += new System.EventHandler(this.FormExplorar_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rbJuzgados;
        private System.Windows.Forms.RadioButton rbCausas;
        private System.Windows.Forms.RadioButton rbCausasMontoSuperior;
        private System.Windows.Forms.RadioButton rbCausasMontoInferior;
        private System.Windows.Forms.RadioButton rbCausasObjeto;
        private System.Windows.Forms.RadioButton rbCausasJuzgado;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.RadioButton rbCausaEspecifica;
        private System.Windows.Forms.Label lblIndicacion;
        private System.Windows.Forms.TextBox txtValor;
        private System.Windows.Forms.ComboBox cmbEleccion;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ErrorProvider epTxt;
    }
}