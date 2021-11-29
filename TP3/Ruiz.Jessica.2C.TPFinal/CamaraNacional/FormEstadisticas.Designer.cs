
namespace CamaraNacional
{
    partial class FormEstadisticas
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
            this.pSuperior = new System.Windows.Forms.Panel();
            this.lblMinimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.pTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.pGenero = new System.Windows.Forms.Panel();
            this.lblPorcentajeMasc = new System.Windows.Forms.Label();
            this.lblCantidadMasc = new System.Windows.Forms.Label();
            this.lblPorcentajeFem = new System.Windows.Forms.Label();
            this.lblCantidadFem = new System.Windows.Forms.Label();
            this.lblMasculino = new System.Windows.Forms.Label();
            this.lblGenero = new System.Windows.Forms.Label();
            this.lblFemenino = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblPorcentajeAnual = new System.Windows.Forms.Label();
            this.lblPorcentajeObjetos = new System.Windows.Forms.Label();
            this.lblCantidadPorAño = new System.Windows.Forms.Label();
            this.lblCantidadObjetos = new System.Windows.Forms.Label();
            this.cmbObjetos = new System.Windows.Forms.ComboBox();
            this.lblObjetos = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbEdad = new System.Windows.Forms.ComboBox();
            this.lblEdadPorcentaje = new System.Windows.Forms.Label();
            this.lblEdadCantidad = new System.Windows.Forms.Label();
            this.lblEdad = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.cmbJuzgados = new System.Windows.Forms.ComboBox();
            this.lblJuzgadosPorcentaje = new System.Windows.Forms.Label();
            this.lblJuzgadosCantidad = new System.Windows.Forms.Label();
            this.lblJuzgados = new System.Windows.Forms.Label();
            this.lblGeneroConMasCausasDifSal = new System.Windows.Forms.Label();
            this.lblSubtituloDiferenciaSalarial = new System.Windows.Forms.Label();
            this.lblEdadConMasCausasDesp = new System.Windows.Forms.Label();
            this.lblSubtituloDespido = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pSuperior.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pGenero.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.pSuperior.Controls.Add(this.lblMinimizar);
            this.pSuperior.Controls.Add(this.lblSalir);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(1381, 25);
            this.pSuperior.TabIndex = 0;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // lblMinimizar
            // 
            this.lblMinimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.lblMinimizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblMinimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMinimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblMinimizar.Location = new System.Drawing.Point(1328, -1);
            this.lblMinimizar.Margin = new System.Windows.Forms.Padding(1);
            this.lblMinimizar.Name = "lblMinimizar";
            this.lblMinimizar.Size = new System.Drawing.Size(25, 25);
            this.lblMinimizar.TabIndex = 3;
            this.lblMinimizar.Text = "__";
            this.lblMinimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMinimizar.Click += new System.EventHandler(this.lblMinimizar_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblSalir.Location = new System.Drawing.Point(1357, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(25, 25);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "X";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.pTitulo.Controls.Add(this.lblTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 25);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(1381, 74);
            this.pTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(560, 25);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TOTAL DE CAUSAS";
            // 
            // pGenero
            // 
            this.pGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.pGenero.Controls.Add(this.lblPorcentajeMasc);
            this.pGenero.Controls.Add(this.lblCantidadMasc);
            this.pGenero.Controls.Add(this.lblPorcentajeFem);
            this.pGenero.Controls.Add(this.lblCantidadFem);
            this.pGenero.Controls.Add(this.lblMasculino);
            this.pGenero.Controls.Add(this.lblGenero);
            this.pGenero.Controls.Add(this.lblFemenino);
            this.pGenero.Location = new System.Drawing.Point(0, 101);
            this.pGenero.Name = "pGenero";
            this.pGenero.Size = new System.Drawing.Size(456, 294);
            this.pGenero.TabIndex = 0;
            // 
            // lblPorcentajeMasc
            // 
            this.lblPorcentajeMasc.AutoSize = true;
            this.lblPorcentajeMasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblPorcentajeMasc.Location = new System.Drawing.Point(197, 246);
            this.lblPorcentajeMasc.Name = "lblPorcentajeMasc";
            this.lblPorcentajeMasc.Size = new System.Drawing.Size(119, 19);
            this.lblPorcentajeMasc.TabIndex = 5;
            this.lblPorcentajeMasc.Text = "PORCENTAJE";
            // 
            // lblCantidadMasc
            // 
            this.lblCantidadMasc.AutoSize = true;
            this.lblCantidadMasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblCantidadMasc.Location = new System.Drawing.Point(197, 195);
            this.lblCantidadMasc.Name = "lblCantidadMasc";
            this.lblCantidadMasc.Size = new System.Drawing.Size(93, 19);
            this.lblCantidadMasc.TabIndex = 4;
            this.lblCantidadMasc.Text = "CANTIDAD";
            // 
            // lblPorcentajeFem
            // 
            this.lblPorcentajeFem.AutoSize = true;
            this.lblPorcentajeFem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeFem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblPorcentajeFem.Location = new System.Drawing.Point(197, 125);
            this.lblPorcentajeFem.Name = "lblPorcentajeFem";
            this.lblPorcentajeFem.Size = new System.Drawing.Size(119, 19);
            this.lblPorcentajeFem.TabIndex = 3;
            this.lblPorcentajeFem.Text = "PORCENTAJE";
            // 
            // lblCantidadFem
            // 
            this.lblCantidadFem.AutoSize = true;
            this.lblCantidadFem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadFem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblCantidadFem.Location = new System.Drawing.Point(197, 79);
            this.lblCantidadFem.Name = "lblCantidadFem";
            this.lblCantidadFem.Size = new System.Drawing.Size(93, 19);
            this.lblCantidadFem.TabIndex = 2;
            this.lblCantidadFem.Text = "CANTIDAD";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblMasculino.Location = new System.Drawing.Point(42, 192);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(106, 19);
            this.lblMasculino.TabIndex = 1;
            this.lblMasculino.Text = "MASCULINO";
            // 
            // lblGenero
            // 
            this.lblGenero.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblGenero.Location = new System.Drawing.Point(28, 23);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(399, 22);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "PROPORCIÓN TOTAL DE CAUSAS POR GÉNERO";
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblFemenino.Location = new System.Drawing.Point(44, 78);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(94, 19);
            this.lblFemenino.TabIndex = 0;
            this.lblFemenino.Text = "FEMENINO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.panel2.Controls.Add(this.lblPorcentajeAnual);
            this.panel2.Controls.Add(this.lblPorcentajeObjetos);
            this.panel2.Controls.Add(this.lblCantidadPorAño);
            this.panel2.Controls.Add(this.lblCantidadObjetos);
            this.panel2.Controls.Add(this.cmbObjetos);
            this.panel2.Controls.Add(this.lblObjetos);
            this.panel2.Location = new System.Drawing.Point(462, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(918, 294);
            this.panel2.TabIndex = 2;
            // 
            // lblPorcentajeAnual
            // 
            this.lblPorcentajeAnual.AutoSize = true;
            this.lblPorcentajeAnual.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeAnual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblPorcentajeAnual.Location = new System.Drawing.Point(496, 192);
            this.lblPorcentajeAnual.Name = "lblPorcentajeAnual";
            this.lblPorcentajeAnual.Size = new System.Drawing.Size(231, 19);
            this.lblPorcentajeAnual.TabIndex = 7;
            this.lblPorcentajeAnual.Text = "PORCENTAJE EN ESTE AÑO";
            // 
            // lblPorcentajeObjetos
            // 
            this.lblPorcentajeObjetos.AutoSize = true;
            this.lblPorcentajeObjetos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblPorcentajeObjetos.Location = new System.Drawing.Point(122, 194);
            this.lblPorcentajeObjetos.Name = "lblPorcentajeObjetos";
            this.lblPorcentajeObjetos.Size = new System.Drawing.Size(119, 19);
            this.lblPorcentajeObjetos.TabIndex = 6;
            this.lblPorcentajeObjetos.Text = "PORCENTAJE";
            // 
            // lblCantidadPorAño
            // 
            this.lblCantidadPorAño.AutoSize = true;
            this.lblCantidadPorAño.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadPorAño.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblCantidadPorAño.Location = new System.Drawing.Point(496, 124);
            this.lblCantidadPorAño.Name = "lblCantidadPorAño";
            this.lblCantidadPorAño.Size = new System.Drawing.Size(205, 19);
            this.lblCantidadPorAño.TabIndex = 5;
            this.lblCantidadPorAño.Text = "CANTIDAD EN ESTE AÑO";
            // 
            // lblCantidadObjetos
            // 
            this.lblCantidadObjetos.AutoSize = true;
            this.lblCantidadObjetos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblCantidadObjetos.Location = new System.Drawing.Point(122, 124);
            this.lblCantidadObjetos.Name = "lblCantidadObjetos";
            this.lblCantidadObjetos.Size = new System.Drawing.Size(93, 19);
            this.lblCantidadObjetos.TabIndex = 5;
            this.lblCantidadObjetos.Text = "CANTIDAD";
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.cmbObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(496, 22);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(202, 23);
            this.cmbObjetos.TabIndex = 0;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // lblObjetos
            // 
            this.lblObjetos.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblObjetos.Location = new System.Drawing.Point(44, 23);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(331, 22);
            this.lblObjetos.TabIndex = 0;
            this.lblObjetos.Text = "PROPORCIÓN DE CAUSAS POR OBJETO";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.panel3.Controls.Add(this.cmbEdad);
            this.panel3.Controls.Add(this.lblEdadPorcentaje);
            this.panel3.Controls.Add(this.lblEdadCantidad);
            this.panel3.Controls.Add(this.lblEdad);
            this.panel3.Location = new System.Drawing.Point(462, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 294);
            this.panel3.TabIndex = 2;
            // 
            // cmbEdad
            // 
            this.cmbEdad.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.cmbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Location = new System.Drawing.Point(234, 82);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(202, 23);
            this.cmbEdad.TabIndex = 2;
            this.cmbEdad.SelectedIndexChanged += new System.EventHandler(this.cmbEdad_SelectedIndexChanged);
            // 
            // lblEdadPorcentaje
            // 
            this.lblEdadPorcentaje.AutoSize = true;
            this.lblEdadPorcentaje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblEdadPorcentaje.Location = new System.Drawing.Point(75, 206);
            this.lblEdadPorcentaje.Name = "lblEdadPorcentaje";
            this.lblEdadPorcentaje.Size = new System.Drawing.Size(119, 19);
            this.lblEdadPorcentaje.TabIndex = 3;
            this.lblEdadPorcentaje.Text = "PORCENTAJE";
            // 
            // lblEdadCantidad
            // 
            this.lblEdadCantidad.AutoSize = true;
            this.lblEdadCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblEdadCantidad.Location = new System.Drawing.Point(75, 134);
            this.lblEdadCantidad.Name = "lblEdadCantidad";
            this.lblEdadCantidad.Size = new System.Drawing.Size(93, 19);
            this.lblEdadCantidad.TabIndex = 2;
            this.lblEdadCantidad.Text = "CANTIDAD";
            // 
            // lblEdad
            // 
            this.lblEdad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblEdad.Location = new System.Drawing.Point(44, 24);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(297, 39);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "CANTIDAD DE CAUSAS SEGÚN RANGO ETARIO DE LOS ACTORES";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.panel4.Controls.Add(this.cmbJuzgados);
            this.panel4.Controls.Add(this.lblJuzgadosPorcentaje);
            this.panel4.Controls.Add(this.lblJuzgadosCantidad);
            this.panel4.Controls.Add(this.lblJuzgados);
            this.panel4.Location = new System.Drawing.Point(0, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 294);
            this.panel4.TabIndex = 2;
            // 
            // cmbJuzgados
            // 
            this.cmbJuzgados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.cmbJuzgados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuzgados.FormattingEnabled = true;
            this.cmbJuzgados.Location = new System.Drawing.Point(225, 82);
            this.cmbJuzgados.Name = "cmbJuzgados";
            this.cmbJuzgados.Size = new System.Drawing.Size(202, 23);
            this.cmbJuzgados.TabIndex = 1;
            this.cmbJuzgados.SelectedIndexChanged += new System.EventHandler(this.cmbJuzgados_SelectedIndexChanged);
            // 
            // lblJuzgadosPorcentaje
            // 
            this.lblJuzgadosPorcentaje.AutoSize = true;
            this.lblJuzgadosPorcentaje.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgadosPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblJuzgadosPorcentaje.Location = new System.Drawing.Point(42, 206);
            this.lblJuzgadosPorcentaje.Name = "lblJuzgadosPorcentaje";
            this.lblJuzgadosPorcentaje.Size = new System.Drawing.Size(119, 19);
            this.lblJuzgadosPorcentaje.TabIndex = 2;
            this.lblJuzgadosPorcentaje.Text = "PORCENTAJE";
            // 
            // lblJuzgadosCantidad
            // 
            this.lblJuzgadosCantidad.AutoSize = true;
            this.lblJuzgadosCantidad.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgadosCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblJuzgadosCantidad.Location = new System.Drawing.Point(42, 134);
            this.lblJuzgadosCantidad.Name = "lblJuzgadosCantidad";
            this.lblJuzgadosCantidad.Size = new System.Drawing.Size(93, 19);
            this.lblJuzgadosCantidad.TabIndex = 1;
            this.lblJuzgadosCantidad.Text = "CANTIDAD";
            // 
            // lblJuzgados
            // 
            this.lblJuzgados.AutoSize = true;
            this.lblJuzgados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblJuzgados.Location = new System.Drawing.Point(21, 24);
            this.lblJuzgados.Name = "lblJuzgados";
            this.lblJuzgados.Size = new System.Drawing.Size(323, 19);
            this.lblJuzgados.TabIndex = 0;
            this.lblJuzgados.Text = "CANTIDAD DE CAUSAS POR JUZGADOS";
            // 
            // lblGeneroConMasCausasDifSal
            // 
            this.lblGeneroConMasCausasDifSal.AutoSize = true;
            this.lblGeneroConMasCausasDifSal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGeneroConMasCausasDifSal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblGeneroConMasCausasDifSal.Location = new System.Drawing.Point(332, 82);
            this.lblGeneroConMasCausasDifSal.Name = "lblGeneroConMasCausasDifSal";
            this.lblGeneroConMasCausasDifSal.Size = new System.Drawing.Size(79, 19);
            this.lblGeneroConMasCausasDifSal.TabIndex = 5;
            this.lblGeneroConMasCausasDifSal.Text = "GENERO";
            // 
            // lblSubtituloDiferenciaSalarial
            // 
            this.lblSubtituloDiferenciaSalarial.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtituloDiferenciaSalarial.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblSubtituloDiferenciaSalarial.Location = new System.Drawing.Point(34, 57);
            this.lblSubtituloDiferenciaSalarial.Name = "lblSubtituloDiferenciaSalarial";
            this.lblSubtituloDiferenciaSalarial.Size = new System.Drawing.Size(278, 48);
            this.lblSubtituloDiferenciaSalarial.TabIndex = 0;
            this.lblSubtituloDiferenciaSalarial.Text = "GÉNERO CON MAS CAUSAS POR DIFERENCIA SALARIAL:";
            // 
            // lblEdadConMasCausasDesp
            // 
            this.lblEdadConMasCausasDesp.AutoSize = true;
            this.lblEdadConMasCausasDesp.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadConMasCausasDesp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblEdadConMasCausasDesp.Location = new System.Drawing.Point(332, 193);
            this.lblEdadConMasCausasDesp.Name = "lblEdadConMasCausasDesp";
            this.lblEdadConMasCausasDesp.Size = new System.Drawing.Size(77, 19);
            this.lblEdadConMasCausasDesp.TabIndex = 7;
            this.lblEdadConMasCausasDesp.Text = "EDADES";
            // 
            // lblSubtituloDespido
            // 
            this.lblSubtituloDespido.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSubtituloDespido.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblSubtituloDespido.Location = new System.Drawing.Point(34, 173);
            this.lblSubtituloDespido.Name = "lblSubtituloDespido";
            this.lblSubtituloDespido.Size = new System.Drawing.Size(245, 39);
            this.lblSubtituloDespido.TabIndex = 6;
            this.lblSubtituloDespido.Text = "RANGO/S DE EDAD CON MAS CAUSAS POR  DESPIDO:";
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.panel5.Controls.Add(this.lblGeneroConMasCausasDifSal);
            this.panel5.Controls.Add(this.lblEdadConMasCausasDesp);
            this.panel5.Controls.Add(this.lblSubtituloDiferenciaSalarial);
            this.panel5.Controls.Add(this.lblSubtituloDespido);
            this.panel5.Location = new System.Drawing.Point(924, 401);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(456, 294);
            this.panel5.TabIndex = 7;
            // 
            // FormEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(101)))), ((int)(((byte)(122)))));
            this.ClientSize = new System.Drawing.Size(1381, 696);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pGenero);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.pSuperior);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadisticas";
            this.Text = "FormEstadicticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstadicticas_FormClosing);
            this.Load += new System.EventHandler(this.FormEstadicticas_Load);
            this.pSuperior.ResumeLayout(false);
            this.pTitulo.ResumeLayout(false);
            this.pTitulo.PerformLayout();
            this.pGenero.ResumeLayout(false);
            this.pGenero.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Panel pTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Panel pGenero;
        private System.Windows.Forms.Label lblPorcentajeMasc;
        private System.Windows.Forms.Label lblCantidadMasc;
        private System.Windows.Forms.Label lblPorcentajeFem;
        private System.Windows.Forms.Label lblCantidadFem;
        private System.Windows.Forms.Label lblMasculino;
        private System.Windows.Forms.Label lblGenero;
        private System.Windows.Forms.Label lblFemenino;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblPorcentajeObjetos;
        private System.Windows.Forms.Label lblCantidadObjetos;
        private System.Windows.Forms.ComboBox cmbObjetos;
        private System.Windows.Forms.Label lblObjetos;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ComboBox cmbEdad;
        private System.Windows.Forms.Label lblEdadPorcentaje;
        private System.Windows.Forms.Label lblEdadCantidad;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cmbJuzgados;
        private System.Windows.Forms.Label lblJuzgadosPorcentaje;
        private System.Windows.Forms.Label lblJuzgadosCantidad;
        private System.Windows.Forms.Label lblJuzgados;
        private System.Windows.Forms.Label lblMinimizar;
        private System.Windows.Forms.Label lblEdadConMasCausasDesp;
        private System.Windows.Forms.Label lblSubtituloDespido;
        private System.Windows.Forms.Label lblGeneroConMasCausasDifSal;
        private System.Windows.Forms.Label lblSubtituloDiferenciaSalarial;
        private System.Windows.Forms.Label lblCantidadPorAño;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label lblPorcentajeAnual;
    }
}