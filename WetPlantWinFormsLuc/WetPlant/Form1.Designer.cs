namespace WetPlant
{
    partial class MainWindow
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
            this.Text_1 = new System.Windows.Forms.Label();
            this.Text_2 = new System.Windows.Forms.Label();
            this.Text_3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Text_1
            // 
            this.Text_1.AutoSize = true;
            this.Text_1.Location = new System.Drawing.Point(172, 193);
            this.Text_1.Name = "Text_1";
            this.Text_1.Size = new System.Drawing.Size(45, 13);
            this.Text_1.TabIndex = 0;
            this.Text_1.Text = "Label_1";
            this.Text_1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Text_2
            // 
            this.Text_2.AutoSize = true;
            this.Text_2.Location = new System.Drawing.Point(380, 193);
            this.Text_2.Name = "Text_2";
            this.Text_2.Size = new System.Drawing.Size(35, 13);
            this.Text_2.TabIndex = 1;
            this.Text_2.Text = "label1";
            // 
            // Text_3
            // 
            this.Text_3.AutoSize = true;
            this.Text_3.Location = new System.Drawing.Point(538, 193);
            this.Text_3.Name = "Text_3";
            this.Text_3.Size = new System.Drawing.Size(35, 13);
            this.Text_3.TabIndex = 2;
            this.Text_3.Text = "label1";
            this.Text_3.Click += new System.EventHandler(this.label2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(383, 306);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Text_3);
            this.Controls.Add(this.Text_2);
            this.Controls.Add(this.Text_1);
            this.Name = "MainWindow";
            this.Text = "WetPlant";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Text_1;
        private System.Windows.Forms.Label Text_2;
        private System.Windows.Forms.Label Text_3;
        private System.Windows.Forms.Button button1;
    }
}

