
namespace Camara
{
    partial class FormResultados
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
            this.rtbInformacion = new System.Windows.Forms.RichTextBox();
            this.msGuardar = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdGuardar = new System.Windows.Forms.OpenFileDialog();
            this.btnSalir = new System.Windows.Forms.Button();
            this.tsmiArchivoDeTexto = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivoXML = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiArchivoJSON = new System.Windows.Forms.ToolStripMenuItem();
            this.msGuardar.SuspendLayout();
            this.SuspendLayout();
            // 
            // rtbInformacion
            // 
            this.rtbInformacion.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbInformacion.BackColor = System.Drawing.SystemColors.ControlLight;
            this.rtbInformacion.Location = new System.Drawing.Point(38, 44);
            this.rtbInformacion.Name = "rtbInformacion";
            this.rtbInformacion.ReadOnly = true;
            this.rtbInformacion.Size = new System.Drawing.Size(608, 358);
            this.rtbInformacion.TabIndex = 0;
            this.rtbInformacion.Text = "";
            // 
            // msGuardar
            // 
            this.msGuardar.BackColor = System.Drawing.Color.Bisque;
            this.msGuardar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.msGuardar.Location = new System.Drawing.Point(0, 0);
            this.msGuardar.Name = "msGuardar";
            this.msGuardar.Size = new System.Drawing.Size(688, 24);
            this.msGuardar.TabIndex = 1;
            this.msGuardar.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.Bisque;
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiArchivoDeTexto,
            this.tsmiArchivoXML,
            this.tsmiArchivoJSON});
            this.guardarToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Linen;
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // ofdGuardar
            // 
            this.ofdGuardar.FileName = "openFileDialog1";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Bisque;
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSalir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSalir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalir.Location = new System.Drawing.Point(581, 416);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(95, 37);
            this.btnSalir.TabIndex = 2;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // tsmiArchivoDeTexto
            // 
            this.tsmiArchivoDeTexto.BackColor = System.Drawing.Color.Linen;
            this.tsmiArchivoDeTexto.Name = "tsmiArchivoDeTexto";
            this.tsmiArchivoDeTexto.Size = new System.Drawing.Size(201, 22);
            this.tsmiArchivoDeTexto.Text = "Archivo de texto";
            this.tsmiArchivoDeTexto.Click += new System.EventHandler(this.archivoDeTextoToolStripMenuItem_Click);
            // 
            // tsmiArchivoXML
            // 
            this.tsmiArchivoXML.BackColor = System.Drawing.Color.Linen;
            this.tsmiArchivoXML.Name = "tsmiArchivoXML";
            this.tsmiArchivoXML.Size = new System.Drawing.Size(201, 22);
            this.tsmiArchivoXML.Text = "Archivo XML";
            this.tsmiArchivoXML.Click += new System.EventHandler(this.tsmiArchivoXML_Click);
            // 
            // tsmiArchivoJSON
            // 
            this.tsmiArchivoJSON.BackColor = System.Drawing.Color.Linen;
            this.tsmiArchivoJSON.Name = "tsmiArchivoJSON";
            this.tsmiArchivoJSON.Size = new System.Drawing.Size(201, 22);
            this.tsmiArchivoJSON.Text = "Archivo JSON(juzgados)";
            this.tsmiArchivoJSON.Click += new System.EventHandler(this.tsmiArchivoJSON_Click);
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(688, 465);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.rtbInformacion);
            this.Controls.Add(this.msGuardar);
            this.MainMenuStrip = this.msGuardar;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResultados";
            this.Text = "FormResultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResultados_FormClosing);
            this.Load += new System.EventHandler(this.FormResultados_Load);
            this.msGuardar.ResumeLayout(false);
            this.msGuardar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox rtbInformacion;
        private System.Windows.Forms.MenuStrip msGuardar;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdGuardar;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivoDeTexto;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivoXML;
        private System.Windows.Forms.ToolStripMenuItem tsmiArchivoJSON;
        private System.Windows.Forms.Button btnSalir;
    }
}