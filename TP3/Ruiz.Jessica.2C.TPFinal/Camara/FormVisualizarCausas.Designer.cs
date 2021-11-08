
namespace Camara
{
    partial class FormVisualizarCausas
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
            this.cmbFiltros = new System.Windows.Forms.ComboBox();
            this.lblCambiante = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnAplicarBusqueda = new System.Windows.Forms.Button();
            this.txtNumeroDeCausa = new System.Windows.Forms.TextBox();
            this.cmbCambiante = new System.Windows.Forms.ComboBox();
            this.epFiltro = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCambiante = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epFiltro)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCambiante)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbFiltros
            // 
            this.cmbFiltros.BackColor = System.Drawing.Color.Linen;
            this.cmbFiltros.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFiltros.FormattingEnabled = true;
            this.cmbFiltros.Location = new System.Drawing.Point(30, 75);
            this.cmbFiltros.Name = "cmbFiltros";
            this.cmbFiltros.Size = new System.Drawing.Size(463, 23);
            this.cmbFiltros.TabIndex = 0;
            this.cmbFiltros.SelectedIndexChanged += new System.EventHandler(this.cmbFiltros_SelectedIndexChanged);
            // 
            // lblCambiante
            // 
            this.lblCambiante.AutoSize = true;
            this.lblCambiante.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCambiante.Location = new System.Drawing.Point(30, 119);
            this.lblCambiante.Name = "lblCambiante";
            this.lblCambiante.Size = new System.Drawing.Size(102, 21);
            this.lblCambiante.TabIndex = 4;
            this.lblCambiante.Text = "lblCambiante";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.Location = new System.Drawing.Point(30, 26);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(114, 25);
            this.lblTitulo.TabIndex = 7;
            this.lblTitulo.Text = "BUSCADOR";
            // 
            // btnAplicarBusqueda
            // 
            this.btnAplicarBusqueda.BackColor = System.Drawing.Color.Bisque;
            this.btnAplicarBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAplicarBusqueda.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAplicarBusqueda.Location = new System.Drawing.Point(229, 185);
            this.btnAplicarBusqueda.Name = "btnAplicarBusqueda";
            this.btnAplicarBusqueda.Size = new System.Drawing.Size(264, 47);
            this.btnAplicarBusqueda.TabIndex = 2;
            this.btnAplicarBusqueda.Text = "APLICAR BÙSQUEDA";
            this.btnAplicarBusqueda.UseVisualStyleBackColor = false;
            this.btnAplicarBusqueda.Click += new System.EventHandler(this.btnAplicarBusqueda_Click);
            // 
            // txtNumeroDeCausa
            // 
            this.txtNumeroDeCausa.Location = new System.Drawing.Point(346, 117);
            this.txtNumeroDeCausa.Name = "txtNumeroDeCausa";
            this.txtNumeroDeCausa.Size = new System.Drawing.Size(101, 23);
            this.txtNumeroDeCausa.TabIndex = 5;
            // 
            // cmbCambiante
            // 
            this.cmbCambiante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCambiante.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cmbCambiante.FormattingEnabled = true;
            this.cmbCambiante.Items.AddRange(new object[] {
            "Accidente",
            "Amparo",
            "Despido",
            "DirefenciaSalario",
            "EjecucionDeCredito"});
            this.cmbCambiante.Location = new System.Drawing.Point(326, 117);
            this.cmbCambiante.Name = "cmbCambiante";
            this.cmbCambiante.Size = new System.Drawing.Size(121, 23);
            this.cmbCambiante.TabIndex = 1;
            // 
            // epFiltro
            // 
            this.epFiltro.ContainerControl = this;
            // 
            // epCambiante
            // 
            this.epCambiante.ContainerControl = this;
            // 
            // FormVisualizarCausas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(516, 244);
            this.Controls.Add(this.cmbCambiante);
            this.Controls.Add(this.btnAplicarBusqueda);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.txtNumeroDeCausa);
            this.Controls.Add(this.lblCambiante);
            this.Controls.Add(this.cmbFiltros);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormVisualizarCausas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Buscador de causas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormVisualizarCausas_FormClosing);
            this.Load += new System.EventHandler(this.FormVisualizarCausas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.epFiltro)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCambiante)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cmbFiltros;
        private System.Windows.Forms.Label lblCambiante;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnAplicarBusqueda;
        private System.Windows.Forms.TextBox txtNumeroDeCausa;
        private System.Windows.Forms.ComboBox cmbCambiante;
        private System.Windows.Forms.ErrorProvider epFiltro;
        private System.Windows.Forms.ErrorProvider epCambiante;
    }
}