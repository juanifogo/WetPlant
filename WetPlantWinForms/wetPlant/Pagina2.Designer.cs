namespace wetPlant
{
    partial class Pagina2
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
            this.spPantallaDeInicio = new System.IO.Ports.SerialPort(this.components);
            this.btnIniciar = new System.Windows.Forms.Button();
            this.txtTemperatura2 = new System.Windows.Forms.TextBox();
            this.txtHumedad = new System.Windows.Forms.TextBox();
            this.txtLuz = new System.Windows.Forms.TextBox();
            this.btnAtras3 = new System.Windows.Forms.Button();
            this.btnConectarPuertos = new System.Windows.Forms.Button();
            this.cboPuertos = new System.Windows.Forms.ComboBox();
            this.btnBuscarPuertos = new System.Windows.Forms.Button();
            this.txtMonitorserial = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnIniciar
            // 
            this.btnIniciar.BackColor = System.Drawing.Color.Transparent;
            this.btnIniciar.BackgroundImage = global::wetPlant.Properties.Resources.iniciar1;
            this.btnIniciar.FlatAppearance.BorderSize = 0;
            this.btnIniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIniciar.Font = new System.Drawing.Font("plantiya2", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIniciar.Location = new System.Drawing.Point(90, 145);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(197, 51);
            this.btnIniciar.TabIndex = 11;
            this.btnIniciar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIniciar.UseVisualStyleBackColor = false;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // txtTemperatura2
            // 
            this.txtTemperatura2.Location = new System.Drawing.Point(523, 210);
            this.txtTemperatura2.Name = "txtTemperatura2";
            this.txtTemperatura2.Size = new System.Drawing.Size(100, 20);
            this.txtTemperatura2.TabIndex = 12;
            this.txtTemperatura2.Text = "°C";
            // 
            // txtHumedad
            // 
            this.txtHumedad.Location = new System.Drawing.Point(523, 259);
            this.txtHumedad.Name = "txtHumedad";
            this.txtHumedad.Size = new System.Drawing.Size(100, 20);
            this.txtHumedad.TabIndex = 13;
            this.txtHumedad.Text = "%";
            // 
            // txtLuz
            // 
            this.txtLuz.Location = new System.Drawing.Point(523, 310);
            this.txtLuz.Name = "txtLuz";
            this.txtLuz.Size = new System.Drawing.Size(100, 20);
            this.txtLuz.TabIndex = 14;
            // 
            // btnAtras3
            // 
            this.btnAtras3.BackColor = System.Drawing.Color.Transparent;
            this.btnAtras3.BackgroundImage = global::wetPlant.Properties.Resources.boton_atrad;
            this.btnAtras3.FlatAppearance.BorderSize = 0;
            this.btnAtras3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras3.Font = new System.Drawing.Font("Menulis", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras3.Location = new System.Drawing.Point(17, 22);
            this.btnAtras3.Name = "btnAtras3";
            this.btnAtras3.Size = new System.Drawing.Size(64, 70);
            this.btnAtras3.TabIndex = 15;
            this.btnAtras3.UseVisualStyleBackColor = false;
            this.btnAtras3.Click += new System.EventHandler(this.btnAtras3_Click);
            // 
            // btnConectarPuertos
            // 
            this.btnConectarPuertos.Location = new System.Drawing.Point(2, 440);
            this.btnConectarPuertos.Name = "btnConectarPuertos";
            this.btnConectarPuertos.Size = new System.Drawing.Size(13, 10);
            this.btnConectarPuertos.TabIndex = 10;
            this.btnConectarPuertos.UseVisualStyleBackColor = true;
            this.btnConectarPuertos.Click += new System.EventHandler(this.btnConectarPuertos_Click);
            // 
            // cboPuertos
            // 
            this.cboPuertos.FormattingEnabled = true;
            this.cboPuertos.Location = new System.Drawing.Point(2, 436);
            this.cboPuertos.Name = "cboPuertos";
            this.cboPuertos.Size = new System.Drawing.Size(10, 21);
            this.cboPuertos.TabIndex = 9;
            // 
            // btnBuscarPuertos
            // 
            this.btnBuscarPuertos.Location = new System.Drawing.Point(0, 440);
            this.btnBuscarPuertos.Name = "btnBuscarPuertos";
            this.btnBuscarPuertos.Size = new System.Drawing.Size(15, 10);
            this.btnBuscarPuertos.TabIndex = 7;
            this.btnBuscarPuertos.UseVisualStyleBackColor = true;
            this.btnBuscarPuertos.Click += new System.EventHandler(this.btnBuscarPuertos_Click);
            // 
            // txtMonitorserial
            // 
            this.txtMonitorserial.Location = new System.Drawing.Point(374, 145);
            this.txtMonitorserial.Multiline = true;
            this.txtMonitorserial.Name = "txtMonitorserial";
            this.txtMonitorserial.Size = new System.Drawing.Size(398, 51);
            this.txtMonitorserial.TabIndex = 16;
            // 
            // Pagina2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::wetPlant.Properties.Resources.pantalla_general_visual4;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.txtMonitorserial);
            this.Controls.Add(this.btnAtras3);
            this.Controls.Add(this.txtLuz);
            this.Controls.Add(this.txtHumedad);
            this.Controls.Add(this.txtTemperatura2);
            this.Controls.Add(this.btnIniciar);
            this.Controls.Add(this.btnConectarPuertos);
            this.Controls.Add(this.cboPuertos);
            this.Controls.Add(this.btnBuscarPuertos);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pagina2";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Pagina2_FormClosing);
            this.Load += new System.EventHandler(this.Pagina2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.IO.Ports.SerialPort spPantallaDeInicio;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.TextBox txtTemperatura2;
        private System.Windows.Forms.TextBox txtHumedad;
        private System.Windows.Forms.TextBox txtLuz;
        private System.Windows.Forms.Button btnAtras3;
        private System.Windows.Forms.Button btnConectarPuertos;
        private System.Windows.Forms.ComboBox cboPuertos;
        private System.Windows.Forms.Button btnBuscarPuertos;
        private System.Windows.Forms.TextBox txtMonitorserial;
    }
}