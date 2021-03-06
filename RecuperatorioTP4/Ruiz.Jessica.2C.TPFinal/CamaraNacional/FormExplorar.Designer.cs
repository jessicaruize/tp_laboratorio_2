
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
            this.pSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
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
            this.pSuperior.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).BeginInit();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.pSuperior.Controls.Add(this.label1);
            this.pSuperior.Controls.Add(this.lblSalir);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(725, 25);
            this.pSuperior.TabIndex = 0;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(669, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "__";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.lblSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblSalir.Location = new System.Drawing.Point(700, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(25, 25);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "X";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.panel2.Controls.Add(this.rbJuzgados);
            this.panel2.Controls.Add(this.rbCausas);
            this.panel2.Controls.Add(this.rbCausasMontoSuperior);
            this.panel2.Controls.Add(this.rbCausasMontoInferior);
            this.panel2.Controls.Add(this.rbCausasObjeto);
            this.panel2.Controls.Add(this.rbCausasJuzgado);
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Controls.Add(this.rbCausaEspecifica);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 369);
            this.panel2.TabIndex = 1;
            // 
            // rbJuzgados
            // 
            this.rbJuzgados.AutoSize = true;
            this.rbJuzgados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbJuzgados.FlatAppearance.BorderSize = 5;
            this.rbJuzgados.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbJuzgados.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbJuzgados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbJuzgados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbJuzgados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.rbCausas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausas.FlatAppearance.BorderSize = 5;
            this.rbCausas.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausas.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.rbCausasMontoSuperior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausasMontoSuperior.FlatAppearance.BorderSize = 5;
            this.rbCausasMontoSuperior.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausasMontoSuperior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausasMontoSuperior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausasMontoSuperior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasMontoSuperior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.rbCausasMontoInferior.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausasMontoInferior.FlatAppearance.BorderSize = 5;
            this.rbCausasMontoInferior.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausasMontoInferior.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausasMontoInferior.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausasMontoInferior.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasMontoInferior.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.rbCausasObjeto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausasObjeto.FlatAppearance.BorderSize = 5;
            this.rbCausasObjeto.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausasObjeto.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausasObjeto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausasObjeto.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasObjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.rbCausasJuzgado.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausasJuzgado.FlatAppearance.BorderSize = 5;
            this.rbCausasJuzgado.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausasJuzgado.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausasJuzgado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausasJuzgado.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausasJuzgado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(49, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(173, 34);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "EXPLORAR";
            // 
            // rbCausaEspecifica
            // 
            this.rbCausaEspecifica.AutoSize = true;
            this.rbCausaEspecifica.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.rbCausaEspecifica.FlatAppearance.BorderSize = 5;
            this.rbCausaEspecifica.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.rbCausaEspecifica.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.rbCausaEspecifica.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.rbCausaEspecifica.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rbCausaEspecifica.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.lblIndicacion.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIndicacion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblIndicacion.Location = new System.Drawing.Point(396, 106);
            this.lblIndicacion.Name = "lblIndicacion";
            this.lblIndicacion.Size = new System.Drawing.Size(81, 29);
            this.lblIndicacion.TabIndex = 2;
            this.lblIndicacion.Text = "label2";
            // 
            // txtValor
            // 
            this.txtValor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtValor.Location = new System.Drawing.Point(446, 185);
            this.txtValor.Name = "txtValor";
            this.txtValor.Size = new System.Drawing.Size(204, 23);
            this.txtValor.TabIndex = 3;
            // 
            // cmbEleccion
            // 
            this.cmbEleccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.cmbEleccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEleccion.FormattingEnabled = true;
            this.cmbEleccion.Location = new System.Drawing.Point(446, 185);
            this.cmbEleccion.Name = "cmbEleccion";
            this.cmbEleccion.Size = new System.Drawing.Size(204, 23);
            this.cmbEleccion.TabIndex = 4;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.btnBuscar.FlatAppearance.BorderSize = 2;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
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
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(725, 394);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbEleccion);
            this.Controls.Add(this.txtValor);
            this.Controls.Add(this.lblIndicacion);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormExplorar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormExplorar";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormExplorar_FormClosing);
            this.Load += new System.EventHandler(this.FormExplorar_Load);
            this.pSuperior.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epTxt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
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
        private System.Windows.Forms.Label label1;
    }
}