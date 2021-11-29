
namespace CamaraNacional
{
    partial class FormAsignarJuzgado
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
            this.cmbObjeto = new System.Windows.Forms.ComboBox();
            this.txtMontoReclamo = new System.Windows.Forms.TextBox();
            this.lblFolio = new System.Windows.Forms.Label();
            this.lblObjeto = new System.Windows.Forms.Label();
            this.btnCrearCausa = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.epMontoReclamo = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMontoReclamo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 25);
            this.panel1.TabIndex = 0;
            // 
            // cmbObjeto
            // 
            this.cmbObjeto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.cmbObjeto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbObjeto.FormattingEnabled = true;
            this.cmbObjeto.ItemHeight = 15;
            this.cmbObjeto.Location = new System.Drawing.Point(125, 176);
            this.cmbObjeto.Name = "cmbObjeto";
            this.cmbObjeto.Size = new System.Drawing.Size(145, 23);
            this.cmbObjeto.TabIndex = 0;
            // 
            // txtMontoReclamo
            // 
            this.txtMontoReclamo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtMontoReclamo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtMontoReclamo.Location = new System.Drawing.Point(420, 184);
            this.txtMontoReclamo.Name = "txtMontoReclamo";
            this.txtMontoReclamo.Size = new System.Drawing.Size(145, 23);
            this.txtMontoReclamo.TabIndex = 1;
            this.txtMontoReclamo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMontoReclamo_KeyPress);
            // 
            // lblFolio
            // 
            this.lblFolio.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblFolio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblFolio.Location = new System.Drawing.Point(293, 176);
            this.lblFolio.Name = "lblFolio";
            this.lblFolio.Size = new System.Drawing.Size(121, 45);
            this.lblFolio.TabIndex = 38;
            this.lblFolio.Text = "MONTO DE RECLAMO:";
            // 
            // lblObjeto
            // 
            this.lblObjeto.AutoSize = true;
            this.lblObjeto.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblObjeto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblObjeto.Location = new System.Drawing.Point(21, 180);
            this.lblObjeto.Name = "lblObjeto";
            this.lblObjeto.Size = new System.Drawing.Size(98, 22);
            this.lblObjeto.TabIndex = 37;
            this.lblObjeto.Text = "OBJETO:";
            // 
            // btnCrearCausa
            // 
            this.btnCrearCausa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnCrearCausa.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.btnCrearCausa.FlatAppearance.BorderSize = 2;
            this.btnCrearCausa.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnCrearCausa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCausa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnCrearCausa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.btnCrearCausa.Location = new System.Drawing.Point(167, 286);
            this.btnCrearCausa.Name = "btnCrearCausa";
            this.btnCrearCausa.Size = new System.Drawing.Size(265, 76);
            this.btnCrearCausa.TabIndex = 2;
            this.btnCrearCausa.Text = "ASIGANR JUZGADO Y CREAR CAUSA";
            this.btnCrearCausa.UseVisualStyleBackColor = false;
            this.btnCrearCausa.Click += new System.EventHandler(this.btnCrearCausa_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 74);
            this.panel2.TabIndex = 40;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(50, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(515, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "ASIGNAR JUZGADO Y CREAR CAUSA";
            // 
            // epMontoReclamo
            // 
            this.epMontoReclamo.ContainerControl = this;
            // 
            // FormAsignarJuzgado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(600, 429);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.cmbObjeto);
            this.Controls.Add(this.txtMontoReclamo);
            this.Controls.Add(this.lblFolio);
            this.Controls.Add(this.lblObjeto);
            this.Controls.Add(this.btnCrearCausa);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAsignarJuzgado";
            this.Text = "FormAsignarJuzgado";
            this.Load += new System.EventHandler(this.FormAsignarJuzgado_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epMontoReclamo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbObjeto;
        private System.Windows.Forms.TextBox txtMontoReclamo;
        private System.Windows.Forms.Label lblFolio;
        private System.Windows.Forms.Label lblObjeto;
        private System.Windows.Forms.Button btnCrearCausa;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ErrorProvider epMontoReclamo;
    }
}