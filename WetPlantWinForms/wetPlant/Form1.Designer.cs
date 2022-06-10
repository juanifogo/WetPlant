namespace wetPlant
{
    partial class PantallaDeInicio
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCrearCuentaNueva = new System.Windows.Forms.Button();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.txtNombreDeUsuario = new System.Windows.Forms.TextBox();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.checkboxContraseña = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnCrearCuentaNueva
            // 
            this.btnCrearCuentaNueva.BackColor = System.Drawing.Color.Transparent;
            this.btnCrearCuentaNueva.BackgroundImage = global::wetPlant.Properties.Resources.Captura_crear_cuenta;
            this.btnCrearCuentaNueva.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCrearCuentaNueva.FlatAppearance.BorderSize = 0;
            this.btnCrearCuentaNueva.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearCuentaNueva.Font = new System.Drawing.Font("plantiya2", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearCuentaNueva.Location = new System.Drawing.Point(9, 29);
            this.btnCrearCuentaNueva.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearCuentaNueva.Name = "btnCrearCuentaNueva";
            this.btnCrearCuentaNueva.Size = new System.Drawing.Size(303, 52);
            this.btnCrearCuentaNueva.TabIndex = 0;
            this.btnCrearCuentaNueva.UseVisualStyleBackColor = false;
            this.btnCrearCuentaNueva.Click += new System.EventHandler(this.btnCrearCuentaNueva_Click);
            // 
            // btnIngresar
            // 
            this.btnIngresar.BackColor = System.Drawing.Color.Transparent;
            this.btnIngresar.BackgroundImage = global::wetPlant.Properties.Resources.boton_aceptar;
            this.btnIngresar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnIngresar.FlatAppearance.BorderSize = 0;
            this.btnIngresar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngresar.Font = new System.Drawing.Font("plantiya2", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresar.ForeColor = System.Drawing.Color.Black;
            this.btnIngresar.Location = new System.Drawing.Point(280, 340);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(0);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(236, 55);
            this.btnIngresar.TabIndex = 1;
            this.btnIngresar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.btnIngresar.UseVisualStyleBackColor = false;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // txtNombreDeUsuario
            // 
            this.txtNombreDeUsuario.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombreDeUsuario.Location = new System.Drawing.Point(248, 169);
            this.txtNombreDeUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreDeUsuario.Name = "txtNombreDeUsuario";
            this.txtNombreDeUsuario.Size = new System.Drawing.Size(311, 25);
            this.txtNombreDeUsuario.TabIndex = 2;
            this.txtNombreDeUsuario.TextChanged += new System.EventHandler(this.txtNombreDeUsuario_TextChanged);
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(248, 236);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '•';
            this.txtContraseña.Size = new System.Drawing.Size(311, 25);
            this.txtContraseña.TabIndex = 3;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(245, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ingrese su nombre de usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(245, 214);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Ingrese su contraseña";
            // 
            // checkboxContraseña
            // 
            this.checkboxContraseña.AutoSize = true;
            this.checkboxContraseña.BackColor = System.Drawing.Color.Transparent;
            this.checkboxContraseña.Location = new System.Drawing.Point(248, 273);
            this.checkboxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.checkboxContraseña.Name = "checkboxContraseña";
            this.checkboxContraseña.Size = new System.Drawing.Size(146, 21);
            this.checkboxContraseña.TabIndex = 9;
            this.checkboxContraseña.Text = "Mostrar contraseña";
            this.checkboxContraseña.UseVisualStyleBackColor = false;
            this.checkboxContraseña.CheckedChanged += new System.EventHandler(this.checkboxContraseña_CheckedChanged);
            // 
            // PantallaDeInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.BackgroundImage = global::wetPlant.Properties.Resources.pantalla_general_visual;
            this.ClientSize = new System.Drawing.Size(816, 489);
            this.Controls.Add(this.checkboxContraseña);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtNombreDeUsuario);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.btnCrearCuentaNueva);
            this.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PantallaDeInicio";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.PantallaDeInicio_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCuentaNueva;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.TextBox txtNombreDeUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox checkboxContraseña;
    }
}

