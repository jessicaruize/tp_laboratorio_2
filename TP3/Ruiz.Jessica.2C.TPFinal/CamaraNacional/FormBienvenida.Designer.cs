
namespace CamaraNacional
{
    partial class FormBienvenida
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.cpbBienvenida = new CircularProgressBar_NET5.CircularProgressBar();
            this.lblIngresando = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CamaraNacional.Properties.Resources.MujerCielo7;
            this.pictureBox1.Location = new System.Drawing.Point(-119, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(450, 609);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(114)))), ((int)(((byte)(115)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(802, 76);
            this.panel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.label1.Location = new System.Drawing.Point(420, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 56);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bienvenidos";
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 30;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // cpbBienvenida
            // 
            this.cpbBienvenida.AnimationFunction = WinFormAnimation_NET5.KnownAnimationFunctions.Linear;
            this.cpbBienvenida.AnimationSpeed = 500;
            this.cpbBienvenida.BackColor = System.Drawing.Color.Transparent;
            this.cpbBienvenida.Font = new System.Drawing.Font("Segoe UI Black", 35F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
            this.cpbBienvenida.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(218)))), ((int)(((byte)(201)))));
            this.cpbBienvenida.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(37)))), ((int)(((byte)(4)))));
            this.cpbBienvenida.InnerMargin = 2;
            this.cpbBienvenida.InnerWidth = -1;
            this.cpbBienvenida.Location = new System.Drawing.Point(500, 158);
            this.cpbBienvenida.MarqueeAnimationSpeed = 2000;
            this.cpbBienvenida.Name = "cpbBienvenida";
            this.cpbBienvenida.OuterColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.cpbBienvenida.OuterMargin = -25;
            this.cpbBienvenida.OuterWidth = 26;
            this.cpbBienvenida.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(90)))), ((int)(((byte)(73)))));
            this.cpbBienvenida.ProgressWidth = 25;
            this.cpbBienvenida.SecondaryFont = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cpbBienvenida.Size = new System.Drawing.Size(142, 138);
            this.cpbBienvenida.StartAngle = 270;
            this.cpbBienvenida.Style = System.Windows.Forms.ProgressBarStyle.Marquee;
            this.cpbBienvenida.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBienvenida.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.cpbBienvenida.SubscriptText = "";
            this.cpbBienvenida.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.cpbBienvenida.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.cpbBienvenida.SuperscriptText = "%";
            this.cpbBienvenida.TabIndex = 2;
            this.cpbBienvenida.Text = "0";
            this.cpbBienvenida.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.cpbBienvenida.Value = 68;
            // 
            // lblIngresando
            // 
            this.lblIngresando.AutoSize = true;
            this.lblIngresando.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.lblIngresando.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblIngresando.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(68)))), ((int)(((byte)(51)))));
            this.lblIngresando.Location = new System.Drawing.Point(464, 336);
            this.lblIngresando.Name = "lblIngresando";
            this.lblIngresando.Size = new System.Drawing.Size(206, 34);
            this.lblIngresando.TabIndex = 3;
            this.lblIngresando.Text = "CARGANDO...";
            // 
            // FormBienvenida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(140)))), ((int)(((byte)(135)))));
            this.ClientSize = new System.Drawing.Size(800, 435);
            this.Controls.Add(this.lblIngresando);
            this.Controls.Add(this.cpbBienvenida);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormBienvenida";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormBienvenida";
            this.Load += new System.EventHandler(this.FormBienvenida_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private CircularProgressBar_NET5.CircularProgressBar cpbBienvenida;
        private System.Windows.Forms.Label lblIngresando;
    }
}