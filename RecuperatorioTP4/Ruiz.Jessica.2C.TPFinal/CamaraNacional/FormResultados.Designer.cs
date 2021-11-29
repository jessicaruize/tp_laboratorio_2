
namespace CamaraNacional
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
            this.pSuperior = new System.Windows.Forms.Panel();
            this.lblMnimizar = new System.Windows.Forms.Label();
            this.lblSalir = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoDeTextoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.archivoJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.rtbResultados = new System.Windows.Forms.RichTextBox();
            this.pSuperior.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSuperior
            // 
            this.pSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.pSuperior.Controls.Add(this.lblMnimizar);
            this.pSuperior.Controls.Add(this.lblSalir);
            this.pSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSuperior.Location = new System.Drawing.Point(0, 0);
            this.pSuperior.Name = "pSuperior";
            this.pSuperior.Size = new System.Drawing.Size(570, 25);
            this.pSuperior.TabIndex = 0;
            this.pSuperior.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pSuperior_MouseDown);
            // 
            // lblMnimizar
            // 
            this.lblMnimizar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.lblMnimizar.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMnimizar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblMnimizar.Location = new System.Drawing.Point(512, 0);
            this.lblMnimizar.Name = "lblMnimizar";
            this.lblMnimizar.Size = new System.Drawing.Size(25, 25);
            this.lblMnimizar.TabIndex = 1;
            this.lblMnimizar.Text = "__";
            this.lblMnimizar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lblMnimizar.Click += new System.EventHandler(this.lblMnimizar_Click);
            // 
            // lblSalir
            // 
            this.lblSalir.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.lblSalir.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSalir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblSalir.Location = new System.Drawing.Point(543, 0);
            this.lblSalir.Name = "lblSalir";
            this.lblSalir.Size = new System.Drawing.Size(25, 25);
            this.lblSalir.TabIndex = 0;
            this.lblSalir.Text = "X";
            this.lblSalir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblSalir.Click += new System.EventHandler(this.lblSalir_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(9, 12);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(69, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.guardarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoDeTextoToolStripMenuItem,
            this.archivoXMLToolStripMenuItem,
            this.archivoJSONToolStripMenuItem});
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // archivoDeTextoToolStripMenuItem
            // 
            this.archivoDeTextoToolStripMenuItem.Name = "archivoDeTextoToolStripMenuItem";
            this.archivoDeTextoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoDeTextoToolStripMenuItem.Text = "Archivo de texto";
            this.archivoDeTextoToolStripMenuItem.Click += new System.EventHandler(this.archivoDeTextoToolStripMenuItem_Click);
            // 
            // archivoXMLToolStripMenuItem
            // 
            this.archivoXMLToolStripMenuItem.Name = "archivoXMLToolStripMenuItem";
            this.archivoXMLToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoXMLToolStripMenuItem.Text = "Archivo XML";
            this.archivoXMLToolStripMenuItem.Click += new System.EventHandler(this.archivoXMLToolStripMenuItem_Click);
            // 
            // archivoJSONToolStripMenuItem
            // 
            this.archivoJSONToolStripMenuItem.Name = "archivoJSONToolStripMenuItem";
            this.archivoJSONToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.archivoJSONToolStripMenuItem.Text = "Archivo JSON";
            this.archivoJSONToolStripMenuItem.Click += new System.EventHandler(this.archivoJSONToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.menuStrip1);
            this.panel2.Location = new System.Drawing.Point(0, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(571, 38);
            this.panel2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.label1.Location = new System.Drawing.Point(225, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "RESULTADOS";
            // 
            // rtbResultados
            // 
            this.rtbResultados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.rtbResultados.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.rtbResultados.Location = new System.Drawing.Point(9, 56);
            this.rtbResultados.Name = "rtbResultados";
            this.rtbResultados.ReadOnly = true;
            this.rtbResultados.Size = new System.Drawing.Size(547, 485);
            this.rtbResultados.TabIndex = 3;
            this.rtbResultados.Text = "";
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.ClientSize = new System.Drawing.Size(570, 554);
            this.Controls.Add(this.rtbResultados);
            this.Controls.Add(this.pSuperior);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormResultados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormResultados";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormResultados_FormClosing);
            this.Load += new System.EventHandler(this.FormResultados_Load);
            this.pSuperior.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pSuperior;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoDeTextoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem archivoJSONToolStripMenuItem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox rtbResultados;
        private System.Windows.Forms.Label lblSalir;
        private System.Windows.Forms.Label lblMnimizar;
    }
}