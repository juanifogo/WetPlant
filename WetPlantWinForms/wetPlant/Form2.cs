using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace wetPlant
{
    public partial class CrearCuenta : Form
    {
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= WetPlant.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        public CrearCuenta()
        {
            InitializeComponent();
            conexion.Open();
        }

        private void CrearCuenta_Load(object sender, EventArgs e)
        {

            // Agregar conexion a la base de datos (OleDbConnection)
            
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            

            
            

            if (txtNuevoUsuario.Text == "" && txtNuevaContraseña.Text == "" && txtContraseñaConfirmar.Text == "")
            {
                MessageBox.Show("la caja de nombre de usuario  y contraseña estan bacias ", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtNuevaContraseña.Text == txtContraseñaConfirmar.Text)
            {
                
                string register = "INSERT INTO Usuarios (Nombre, Contraseña) VALUES('" + txtNuevoUsuario.Text + "', '" + txtNuevaContraseña.Text + "')";
                OleDbCommand cm = new OleDbCommand(register, conexion);
                cm.ExecuteNonQuery();
                conexion.Close();
                txtContraseñaConfirmar.Text = "";
                txtNuevoUsuario.Text = "";
                txtNuevaContraseña.Text = "";

                MessageBox.Show("su cuenta se creó con exito", "Usted se registro con exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("la contraseña no concuerda, intentelo devuelta", "registro fallido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNuevaContraseña.Text = "";
                txtContraseñaConfirmar.Text = "";
                txtNuevaContraseña.Focus();
            }
        }

        private void btnAtrasPantallaDeInicio_Click(object sender, EventArgs e)
        {
            PantallaDeInicio pdi = new PantallaDeInicio();
            pdi.Visible = true;
            this.Hide();
        }



        private void btnBorrar_Click(object sender, EventArgs e)
        {
            txtContraseñaConfirmar.Text = "";
            txtNuevoUsuario.Text = "";
            txtNuevaContraseña.Text = "";
            txtNuevoUsuario.Focus();
        }

        private void checkbMostrarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbMostrarContraseña.Checked)
            {
                txtNuevaContraseña.PasswordChar = '\0';
                txtContraseñaConfirmar.PasswordChar = '\0';

            }
            else
            {
                txtNuevaContraseña.PasswordChar = '•';
                txtContraseñaConfirmar.PasswordChar = '•';

            }
        }

        private void btnVolverALogin_Click(object sender, EventArgs e)
        {
            PantallaDeInicio f = new PantallaDeInicio();
            f.Show();
            this.Hide();
            conexion.Close();
        }

        private void checkBoxConfirmarContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxConfirmarContraseña.Checked)
            {
                txtNuevaContraseña.PasswordChar = '\0';
                txtContraseñaConfirmar.PasswordChar = '\0';

            }
            else
            {
                txtNuevaContraseña.PasswordChar = '•';
                txtContraseñaConfirmar.PasswordChar = '•';

            }

        }

        private void txtContraseñaConfirmar_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNuevoUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
