
namespace Camara
{
    partial class FormCamaraNacionalDeApelacionesDelTrabajo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCamaraNacionalDeApelacionesDelTrabajo));
            this.btnVisualizarCausa = new System.Windows.Forms.Button();
            this.btnInicioCausa = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbEncabezado = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezado)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVisualizarCausa
            // 
            this.btnVisualizarCausa.BackColor = System.Drawing.Color.Bisque;
            this.btnVisualizarCausa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnVisualizarCausa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnVisualizarCausa.Location = new System.Drawing.Point(407, 170);
            this.btnVisualizarCausa.Name = "btnVisualizarCausa";
            this.btnVisualizarCausa.Size = new System.Drawing.Size(229, 97);
            this.btnVisualizarCausa.TabIndex = 1;
            this.btnVisualizarCausa.Text = "VISUALIZAR CAUSAS";
            this.btnVisualizarCausa.UseVisualStyleBackColor = false;
            this.btnVisualizarCausa.Click += new System.EventHandler(this.btnVisualizarCausa_Click);
            // 
            // btnInicioCausa
            // 
            this.btnInicioCausa.BackColor = System.Drawing.Color.Bisque;
            this.btnInicioCausa.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInicioCausa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnInicioCausa.Location = new System.Drawing.Point(85, 170);
            this.btnInicioCausa.Name = "btnInicioCausa";
            this.btnInicioCausa.Size = new System.Drawing.Size(229, 97);
            this.btnInicioCausa.TabIndex = 0;
            this.btnInicioCausa.Text = "INICIO DE CAUSA";
            this.btnInicioCausa.UseVisualStyleBackColor = false;
            this.btnInicioCausa.Click += new System.EventHandler(this.btnInicioCausa_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(0, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(714, 28);
            this.label1.TabIndex = 2;
            this.label1.Text = "PLATAFORMA DE INICIO Y SEGUIMIENTO DE EXPEDIENTES";
            // 
            // pbEncabezado
            // 
            this.pbEncabezado.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pbEncabezado.BackgroundImage")));
            this.pbEncabezado.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pbEncabezado.Location = new System.Drawing.Point(0, -1);
            this.pbEncabezado.Name = "pbEncabezado";
            this.pbEncabezado.Size = new System.Drawing.Size(714, 123);
            this.pbEncabezado.TabIndex = 3;
            this.pbEncabezado.TabStop = false;
            // 
            // FormCamaraNacionalDeApelacionesDelTrabajo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(710, 298);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbEncabezado);
            this.Controls.Add(this.btnInicioCausa);
            this.Controls.Add(this.btnVisualizarCausa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCamaraNacionalDeApelacionesDelTrabajo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Camara Nacional de Apelaciones del Trabajo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormCamaraNacionalDeApelacionesDelTrabajo_FormClosing);
            this.Load += new System.EventHandler(this.FormCamaraNacionalDeApelacionesDelTrabajo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbEncabezado)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnVisualizarCausa;
        private System.Windows.Forms.Button btnInicioCausa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbEncabezado;
    }
}

