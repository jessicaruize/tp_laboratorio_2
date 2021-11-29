
namespace CamaraNacional
{
    partial class FormDemandado
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
            this.btnSiguiente = new System.Windows.Forms.Button();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCUIT = new System.Windows.Forms.TextBox();
            this.txtNombreYApellido = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblActividadEmpresa = new System.Windows.Forms.Label();
            this.txtActividadEmpresarial = new System.Windows.Forms.TextBox();
            this.epNombreYApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.epDireccion = new System.Windows.Forms.ErrorProvider(this.components);
            this.epCUIT = new System.Windows.Forms.ErrorProvider(this.components);
            this.epActividadEmpresa = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombreYApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.epActividadEmpresa)).BeginInit();
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
            // btnSiguiente
            // 
            this.btnSiguiente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnSiguiente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(151)))), ((int)(((byte)(157)))));
            this.btnSiguiente.FlatAppearance.BorderSize = 2;
            this.btnSiguiente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(188)))), ((int)(((byte)(192)))));
            this.btnSiguiente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSiguiente.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSiguiente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.btnSiguiente.Location = new System.Drawing.Point(382, 306);
            this.btnSiguiente.Name = "btnSiguiente";
            this.btnSiguiente.Size = new System.Drawing.Size(190, 104);
            this.btnSiguiente.TabIndex = 4;
            this.btnSiguiente.Text = "SIGUIENTE";
            this.btnSiguiente.UseVisualStyleBackColor = false;
            this.btnSiguiente.Click += new System.EventHandler(this.btnSiguiente_Click);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(161, 230);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(145, 23);
            this.txtDireccion.TabIndex = 2;
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtCUIT
            // 
            this.txtCUIT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtCUIT.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCUIT.Location = new System.Drawing.Point(427, 148);
            this.txtCUIT.Name = "txtCUIT";
            this.txtCUIT.Size = new System.Drawing.Size(145, 23);
            this.txtCUIT.TabIndex = 1;
            this.txtCUIT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT_KeyPress);
            // 
            // txtNombreYApellido
            // 
            this.txtNombreYApellido.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtNombreYApellido.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreYApellido.Location = new System.Drawing.Point(161, 148);
            this.txtNombreYApellido.Name = "txtNombreYApellido";
            this.txtNombreYApellido.Size = new System.Drawing.Size(145, 23);
            this.txtNombreYApellido.TabIndex = 0;
            this.txtNombreYApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreYApellido_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblDireccion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblDireccion.Location = new System.Drawing.Point(12, 230);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(123, 22);
            this.lblDireccion.TabIndex = 30;
            this.lblDireccion.Text = "DIRECCIÓN:";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCUIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblCUIT.Location = new System.Drawing.Point(352, 149);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(60, 22);
            this.lblCUIT.TabIndex = 29;
            this.lblCUIT.Text = "CUIT:";
            // 
            // lblNombre
            // 
            this.lblNombre.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNombre.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblNombre.Location = new System.Drawing.Point(12, 127);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(123, 44);
            this.lblNombre.TabIndex = 26;
            this.lblNombre.Text = "NOMBRE Y APELLIDO:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.panel2.Controls.Add(this.lblTitulo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(600, 74);
            this.panel2.TabIndex = 23;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(167)))), ((int)(((byte)(183)))));
            this.lblTitulo.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblTitulo.Location = new System.Drawing.Point(130, 22);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(357, 32);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "DATOS DEL DEMANDADO";
            // 
            // lblActividadEmpresa
            // 
            this.lblActividadEmpresa.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblActividadEmpresa.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(82)))), ((int)(((byte)(89)))));
            this.lblActividadEmpresa.Location = new System.Drawing.Point(0, 306);
            this.lblActividadEmpresa.Name = "lblActividadEmpresa";
            this.lblActividadEmpresa.Size = new System.Drawing.Size(155, 45);
            this.lblActividadEmpresa.TabIndex = 36;
            this.lblActividadEmpresa.Text = "ACTIVIDAD EMPRESARIAL:";
            // 
            // txtActividadEmpresarial
            // 
            this.txtActividadEmpresarial.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(218)))), ((int)(((byte)(222)))));
            this.txtActividadEmpresarial.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtActividadEmpresarial.Location = new System.Drawing.Point(161, 328);
            this.txtActividadEmpresarial.Name = "txtActividadEmpresarial";
            this.txtActividadEmpresarial.Size = new System.Drawing.Size(145, 23);
            this.txtActividadEmpresarial.TabIndex = 3;
            // 
            // epNombreYApellido
            // 
            this.epNombreYApellido.ContainerControl = this;
            // 
            // epDireccion
            // 
            this.epDireccion.ContainerControl = this;
            // 
            // epCUIT
            // 
            this.epCUIT.ContainerControl = this;
            // 
            // epActividadEmpresa
            // 
            this.epActividadEmpresa.ContainerControl = this;
            // 
            // FormDemandado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(208)))), ((int)(((byte)(220)))));
            this.ClientSize = new System.Drawing.Size(600, 429);
            this.Controls.Add(this.txtActividadEmpresarial);
            this.Controls.Add(this.lblActividadEmpresa);
            this.Controls.Add(this.btnSiguiente);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtCUIT);
            this.Controls.Add(this.txtNombreYApellido);
            this.Controls.Add(this.lblDireccion);
            this.Controls.Add(this.lblCUIT);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormDemandado";
            this.Text = "FormDemandado";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epNombreYApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epDireccion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epCUIT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.epActividadEmpresa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSiguiente;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtCUIT;
        private System.Windows.Forms.TextBox txtNombreYApellido;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblActividadEmpresa;
        private System.Windows.Forms.TextBox txtActividadEmpresarial;
        private System.Windows.Forms.ErrorProvider epNombreYApellido;
        private System.Windows.Forms.ErrorProvider epDireccion;
        private System.Windows.Forms.ErrorProvider epCUIT;
        private System.Windows.Forms.ErrorProvider epActividadEmpresa;
    }
}