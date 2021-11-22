
namespace CamaraNacional
{
    partial class FormEstadicticas
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
            this.panel1 = new System.Windows.Forms.Panel();
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
            this.lblPorcentajeObjetos = new System.Windows.Forms.Label();
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
            this.panel1.SuspendLayout();
            this.pTitulo.SuspendLayout();
            this.pGenero.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(13)))));
            this.panel1.Controls.Add(this.lblSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(941, 21);
            this.panel1.TabIndex = 0;
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(77)))), ((int)(((byte)(55)))), ((int)(((byte)(28)))));
            this.lblSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblSalir.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblSalir.Location = new System.Drawing.Point(923, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(18, 21);
            this.lblSalir.TabIndex = 1;
            this.lblSalir.Text = "X";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // pTitulo
            // 
            this.pTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.pTitulo.Controls.Add(this.lblTitulo);
            this.pTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitulo.Location = new System.Drawing.Point(0, 21);
            this.pTitulo.Name = "pTitulo";
            this.pTitulo.Size = new System.Drawing.Size(941, 74);
            this.pTitulo.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblTitulo.Location = new System.Drawing.Point(338, 24);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(206, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "TOTAL DE CAUSAS";
            // 
            // pGenero
            // 
            this.pGenero.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.pGenero.Controls.Add(this.lblPorcentajeMasc);
            this.pGenero.Controls.Add(this.lblCantidadMasc);
            this.pGenero.Controls.Add(this.lblPorcentajeFem);
            this.pGenero.Controls.Add(this.lblCantidadFem);
            this.pGenero.Controls.Add(this.lblMasculino);
            this.pGenero.Controls.Add(this.lblGenero);
            this.pGenero.Controls.Add(this.lblFemenino);
            this.pGenero.Location = new System.Drawing.Point(12, 101);
            this.pGenero.Name = "pGenero";
            this.pGenero.Size = new System.Drawing.Size(456, 294);
            this.pGenero.TabIndex = 0;
            // 
            // lblPorcentajeMasc
            // 
            this.lblPorcentajeMasc.AutoSize = true;
            this.lblPorcentajeMasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblPorcentajeMasc.Location = new System.Drawing.Point(197, 249);
            this.lblPorcentajeMasc.Name = "lblPorcentajeMasc";
            this.lblPorcentajeMasc.Size = new System.Drawing.Size(119, 19);
            this.lblPorcentajeMasc.TabIndex = 5;
            this.lblPorcentajeMasc.Text = "PORCENTAJE";
            // 
            // lblCantidadMasc
            // 
            this.lblCantidadMasc.AutoSize = true;
            this.lblCantidadMasc.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadMasc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
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
            this.lblPorcentajeFem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblPorcentajeFem.Location = new System.Drawing.Point(197, 126);
            this.lblPorcentajeFem.Name = "lblPorcentajeFem";
            this.lblPorcentajeFem.Size = new System.Drawing.Size(119, 19);
            this.lblPorcentajeFem.TabIndex = 3;
            this.lblPorcentajeFem.Text = "PORCENTAJE";
            // 
            // lblCantidadFem
            // 
            this.lblCantidadFem.AutoSize = true;
            this.lblCantidadFem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadFem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblCantidadFem.Location = new System.Drawing.Point(197, 78);
            this.lblCantidadFem.Name = "lblCantidadFem";
            this.lblCantidadFem.Size = new System.Drawing.Size(93, 19);
            this.lblCantidadFem.TabIndex = 2;
            this.lblCantidadFem.Text = "CANTIDAD";
            // 
            // lblMasculino
            // 
            this.lblMasculino.AutoSize = true;
            this.lblMasculino.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMasculino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblMasculino.Location = new System.Drawing.Point(42, 195);
            this.lblMasculino.Name = "lblMasculino";
            this.lblMasculino.Size = new System.Drawing.Size(125, 22);
            this.lblMasculino.TabIndex = 1;
            this.lblMasculino.Text = "MASCULINO";
            // 
            // lblGenero
            // 
            this.lblGenero.AutoSize = true;
            this.lblGenero.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGenero.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblGenero.Location = new System.Drawing.Point(21, 23);
            this.lblGenero.Name = "lblGenero";
            this.lblGenero.Size = new System.Drawing.Size(92, 22);
            this.lblGenero.TabIndex = 1;
            this.lblGenero.Text = "GENERO";
            // 
            // lblFemenino
            // 
            this.lblFemenino.AutoSize = true;
            this.lblFemenino.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFemenino.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblFemenino.Location = new System.Drawing.Point(44, 78);
            this.lblFemenino.Name = "lblFemenino";
            this.lblFemenino.Size = new System.Drawing.Size(111, 22);
            this.lblFemenino.TabIndex = 0;
            this.lblFemenino.Text = "FEMENINO";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.panel2.Controls.Add(this.lblPorcentajeObjetos);
            this.panel2.Controls.Add(this.lblCantidadObjetos);
            this.panel2.Controls.Add(this.cmbObjetos);
            this.panel2.Controls.Add(this.lblObjetos);
            this.panel2.Location = new System.Drawing.Point(474, 101);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(456, 294);
            this.panel2.TabIndex = 2;
            // 
            // lblPorcentajeObjetos
            // 
            this.lblPorcentajeObjetos.AutoSize = true;
            this.lblPorcentajeObjetos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPorcentajeObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblPorcentajeObjetos.Location = new System.Drawing.Point(44, 223);
            this.lblPorcentajeObjetos.Name = "lblPorcentajeObjetos";
            this.lblPorcentajeObjetos.Size = new System.Drawing.Size(140, 22);
            this.lblPorcentajeObjetos.TabIndex = 6;
            this.lblPorcentajeObjetos.Text = "PORCENTAJE";
            // 
            // lblCantidadObjetos
            // 
            this.lblCantidadObjetos.AutoSize = true;
            this.lblCantidadObjetos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCantidadObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblCantidadObjetos.Location = new System.Drawing.Point(44, 138);
            this.lblCantidadObjetos.Name = "lblCantidadObjetos";
            this.lblCantidadObjetos.Size = new System.Drawing.Size(109, 22);
            this.lblCantidadObjetos.TabIndex = 5;
            this.lblCantidadObjetos.Text = "CANTIDAD";
            // 
            // cmbObjetos
            // 
            this.cmbObjetos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjetos.FormattingEnabled = true;
            this.cmbObjetos.Location = new System.Drawing.Point(196, 26);
            this.cmbObjetos.Name = "cmbObjetos";
            this.cmbObjetos.Size = new System.Drawing.Size(202, 23);
            this.cmbObjetos.TabIndex = 0;
            this.cmbObjetos.SelectedIndexChanged += new System.EventHandler(this.cmbObjetos_SelectedIndexChanged);
            // 
            // lblObjetos
            // 
            this.lblObjetos.AutoSize = true;
            this.lblObjetos.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObjetos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblObjetos.Location = new System.Drawing.Point(29, 23);
            this.lblObjetos.Name = "lblObjetos";
            this.lblObjetos.Size = new System.Drawing.Size(104, 22);
            this.lblObjetos.TabIndex = 0;
            this.lblObjetos.Text = "OBJETOS";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.panel3.Controls.Add(this.cmbEdad);
            this.panel3.Controls.Add(this.lblEdadPorcentaje);
            this.panel3.Controls.Add(this.lblEdadCantidad);
            this.panel3.Controls.Add(this.lblEdad);
            this.panel3.Location = new System.Drawing.Point(474, 401);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(456, 291);
            this.panel3.TabIndex = 2;
            // 
            // cmbEdad
            // 
            this.cmbEdad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEdad.FormattingEnabled = true;
            this.cmbEdad.Location = new System.Drawing.Point(196, 27);
            this.cmbEdad.Name = "cmbEdad";
            this.cmbEdad.Size = new System.Drawing.Size(202, 23);
            this.cmbEdad.TabIndex = 2;
            this.cmbEdad.SelectedIndexChanged += new System.EventHandler(this.cmbEdad_SelectedIndexChanged);
            // 
            // lblEdadPorcentaje
            // 
            this.lblEdadPorcentaje.AutoSize = true;
            this.lblEdadPorcentaje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblEdadPorcentaje.Location = new System.Drawing.Point(44, 206);
            this.lblEdadPorcentaje.Name = "lblEdadPorcentaje";
            this.lblEdadPorcentaje.Size = new System.Drawing.Size(140, 22);
            this.lblEdadPorcentaje.TabIndex = 3;
            this.lblEdadPorcentaje.Text = "PORCENTAJE";
            // 
            // lblEdadCantidad
            // 
            this.lblEdadCantidad.AutoSize = true;
            this.lblEdadCantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdadCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblEdadCantidad.Location = new System.Drawing.Point(44, 134);
            this.lblEdadCantidad.Name = "lblEdadCantidad";
            this.lblEdadCantidad.Size = new System.Drawing.Size(109, 22);
            this.lblEdadCantidad.TabIndex = 2;
            this.lblEdadCantidad.Text = "CANTIDAD";
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEdad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblEdad.Location = new System.Drawing.Point(29, 24);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(64, 22);
            this.lblEdad.TabIndex = 1;
            this.lblEdad.Text = "EDAD";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.panel4.Controls.Add(this.cmbJuzgados);
            this.panel4.Controls.Add(this.lblJuzgadosPorcentaje);
            this.panel4.Controls.Add(this.lblJuzgadosCantidad);
            this.panel4.Controls.Add(this.lblJuzgados);
            this.panel4.Location = new System.Drawing.Point(12, 401);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(456, 291);
            this.panel4.TabIndex = 2;
            // 
            // cmbJuzgados
            // 
            this.cmbJuzgados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbJuzgados.FormattingEnabled = true;
            this.cmbJuzgados.Location = new System.Drawing.Point(197, 23);
            this.cmbJuzgados.Name = "cmbJuzgados";
            this.cmbJuzgados.Size = new System.Drawing.Size(202, 23);
            this.cmbJuzgados.TabIndex = 1;
            this.cmbJuzgados.SelectedIndexChanged += new System.EventHandler(this.cmbJuzgados_SelectedIndexChanged);
            // 
            // lblJuzgadosPorcentaje
            // 
            this.lblJuzgadosPorcentaje.AutoSize = true;
            this.lblJuzgadosPorcentaje.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgadosPorcentaje.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblJuzgadosPorcentaje.Location = new System.Drawing.Point(42, 206);
            this.lblJuzgadosPorcentaje.Name = "lblJuzgadosPorcentaje";
            this.lblJuzgadosPorcentaje.Size = new System.Drawing.Size(140, 22);
            this.lblJuzgadosPorcentaje.TabIndex = 2;
            this.lblJuzgadosPorcentaje.Text = "PORCENTAJE";
            // 
            // lblJuzgadosCantidad
            // 
            this.lblJuzgadosCantidad.AutoSize = true;
            this.lblJuzgadosCantidad.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgadosCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblJuzgadosCantidad.Location = new System.Drawing.Point(42, 134);
            this.lblJuzgadosCantidad.Name = "lblJuzgadosCantidad";
            this.lblJuzgadosCantidad.Size = new System.Drawing.Size(109, 22);
            this.lblJuzgadosCantidad.TabIndex = 1;
            this.lblJuzgadosCantidad.Text = "CANTIDAD";
            // 
            // lblJuzgados
            // 
            this.lblJuzgados.AutoSize = true;
            this.lblJuzgados.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblJuzgados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.lblJuzgados.Location = new System.Drawing.Point(21, 24);
            this.lblJuzgados.Name = "lblJuzgados";
            this.lblJuzgados.Size = new System.Drawing.Size(115, 22);
            this.lblJuzgados.TabIndex = 0;
            this.lblJuzgados.Text = "JUZGADOS";
            // 
            // FormEstadicticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(941, 703);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pGenero);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.pTitulo);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormEstadicticas";
            this.Text = "FormEstadicticas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormEstadicticas_FormClosing);
            this.Load += new System.EventHandler(this.FormEstadicticas_Load);
            this.panel1.ResumeLayout(false);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
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
    }
}