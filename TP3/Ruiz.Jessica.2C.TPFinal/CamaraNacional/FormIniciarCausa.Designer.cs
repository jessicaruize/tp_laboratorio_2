
namespace CamaraNacional
{
    partial class FormIniciarCausa
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
            this.panelBarraSuperior = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelIzquierda = new System.Windows.Forms.Panel();
            this.btnDemandado = new System.Windows.Forms.Button();
            this.btnJuzgado = new System.Windows.Forms.Button();
            this.btnAbogado = new System.Windows.Forms.Button();
            this.btnActor = new System.Windows.Forms.Button();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panelBarraSuperior.SuspendLayout();
            this.panelIzquierda.SuspendLayout();
            this.panelEscritorio.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelBarraSuperior
            // 
            this.panelBarraSuperior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(40)))), ((int)(((byte)(13)))));
            this.panelBarraSuperior.Controls.Add(this.label1);
            this.panelBarraSuperior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelBarraSuperior.Location = new System.Drawing.Point(0, 0);
            this.panelBarraSuperior.Name = "panelBarraSuperior";
            this.panelBarraSuperior.Size = new System.Drawing.Size(800, 21);
            this.panelBarraSuperior.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(55)))), ((int)(((byte)(28)))));
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label1.Location = new System.Drawing.Point(782, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "X";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panelIzquierda
            // 
            this.panelIzquierda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(76)))), ((int)(((byte)(77)))));
            this.panelIzquierda.Controls.Add(this.btnDemandado);
            this.panelIzquierda.Controls.Add(this.btnJuzgado);
            this.panelIzquierda.Controls.Add(this.btnAbogado);
            this.panelIzquierda.Controls.Add(this.btnActor);
            this.panelIzquierda.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelIzquierda.Location = new System.Drawing.Point(0, 21);
            this.panelIzquierda.Name = "panelIzquierda";
            this.panelIzquierda.Size = new System.Drawing.Size(200, 429);
            this.panelIzquierda.TabIndex = 2;
            // 
            // btnDemandado
            // 
            this.btnDemandado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(107)))));
            this.btnDemandado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDemandado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnDemandado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.btnDemandado.Location = new System.Drawing.Point(0, 230);
            this.btnDemandado.Name = "btnDemandado";
            this.btnDemandado.Size = new System.Drawing.Size(200, 58);
            this.btnDemandado.TabIndex = 2;
            this.btnDemandado.Text = "DEMANDADO";
            this.btnDemandado.UseVisualStyleBackColor = false;
            this.btnDemandado.Click += new System.EventHandler(this.btnDemandado_Click);
            // 
            // btnJuzgado
            // 
            this.btnJuzgado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(107)))));
            this.btnJuzgado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnJuzgado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnJuzgado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.btnJuzgado.Location = new System.Drawing.Point(0, 323);
            this.btnJuzgado.Name = "btnJuzgado";
            this.btnJuzgado.Size = new System.Drawing.Size(200, 58);
            this.btnJuzgado.TabIndex = 3;
            this.btnJuzgado.Text = "ASIGNAR JUZGADO";
            this.btnJuzgado.UseVisualStyleBackColor = false;
            this.btnJuzgado.Click += new System.EventHandler(this.btnJuzgado_Click);
            // 
            // btnAbogado
            // 
            this.btnAbogado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(107)))));
            this.btnAbogado.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnAbogado.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAbogado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.btnAbogado.Location = new System.Drawing.Point(0, 142);
            this.btnAbogado.Name = "btnAbogado";
            this.btnAbogado.Size = new System.Drawing.Size(200, 58);
            this.btnAbogado.TabIndex = 1;
            this.btnAbogado.Text = "ABOGADO";
            this.btnAbogado.UseVisualStyleBackColor = false;
            this.btnAbogado.Click += new System.EventHandler(this.btnAbogado_Click);
            // 
            // btnActor
            // 
            this.btnActor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(97)))), ((int)(((byte)(107)))));
            this.btnActor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnActor.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnActor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.btnActor.Location = new System.Drawing.Point(0, 47);
            this.btnActor.Name = "btnActor";
            this.btnActor.Size = new System.Drawing.Size(200, 58);
            this.btnActor.TabIndex = 0;
            this.btnActor.Text = "ACTOR";
            this.btnActor.UseVisualStyleBackColor = false;
            this.btnActor.Click += new System.EventHandler(this.btnActor_Click);
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(119)))), ((int)(((byte)(114)))), ((int)(((byte)(118)))));
            this.panelEscritorio.Controls.Add(this.label6);
            this.panelEscritorio.Controls.Add(this.label5);
            this.panelEscritorio.Controls.Add(this.label4);
            this.panelEscritorio.Controls.Add(this.label3);
            this.panelEscritorio.Controls.Add(this.label2);
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(200, 21);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(600, 429);
            this.panelEscritorio.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Arial", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label2.Location = new System.Drawing.Point(40, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 31);
            this.label2.TabIndex = 0;
            this.label2.Text = "Pasos:";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label3.Location = new System.Drawing.Point(69, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(372, 33);
            this.label3.TabIndex = 1;
            this.label3.Text = "1- Click en ACTOR y llenar los datos";
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label4.Location = new System.Drawing.Point(69, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(423, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "2- Click en ABOGADO y llenar los datos";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label5.Location = new System.Drawing.Point(69, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(423, 34);
            this.label5.TabIndex = 3;
            this.label5.Text = "3- Click en DEMANDADO y llenar los datos";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(229)))), ((int)(((byte)(214)))));
            this.label6.Location = new System.Drawing.Point(69, 340);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(483, 34);
            this.label6.TabIndex = 4;
            this.label6.Text = "4- Click en ASIGNAR JUZGADO y llenar los datos";
            // 
            // FormIniciarCausa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panelIzquierda);
            this.Controls.Add(this.panelBarraSuperior);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormIniciarCausa";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormIniciarCausa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormIniciarCausa_FormClosing);
            this.Load += new System.EventHandler(this.FormIniciarCausa_Load);
            this.panelBarraSuperior.ResumeLayout(false);
            this.panelIzquierda.ResumeLayout(false);
            this.panelEscritorio.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panelBarraSuperior;
        private System.Windows.Forms.Panel panelIzquierda;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDemandado;
        private System.Windows.Forms.Button btnJuzgado;
        private System.Windows.Forms.Button btnAbogado;
        private System.Windows.Forms.Button btnActor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}