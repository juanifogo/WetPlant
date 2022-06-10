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
using System.IO.Ports;

namespace wetPlant
{
    public partial class PantallaDeInicio : Form
    {
        public static string NombreUsuario = "";
        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= WetPlant.accdb");
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        public PantallaDeInicio()
        {
            InitializeComponent();
            conexion.Open();
           
        }
                

        private void PantallaDeInicio_Load(object sender, EventArgs e)
        {
           
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            
            NombreUsuario = txtNombreDeUsuario.Text;
            string login = "SELECT * FROM Usuarios WHERE Nombre ='" + txtNombreDeUsuario.Text + "'  and Contraseña ='" + txtContraseña.Text + "'";
            cmd = new OleDbCommand(login, conexion);
            OleDbDataReader dr = cmd.ExecuteReader();

            if (dr.Read() == true)
            {
                new PantallaPrincipal().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta, intentalo denuevo", " Login failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNombreDeUsuario.Text = "";
                txtContraseña.Text = "";
                txtContraseña.Focus();
            }
        }

        private void btnCrearCuentaNueva_Click(object sender, EventArgs e)
        {
            
            CrearCuenta CC = new CrearCuenta();
            CC.Visible = true;
            this.Hide();
            conexion.Close();
        }

      


        private void checkboxContraseña_CheckedChanged(object sender, EventArgs e)
        {
            if (checkboxContraseña.Checked)
            {
                txtContraseña.PasswordChar = '\0';

            }
            else
            {
                txtContraseña.PasswordChar = '•';


            }

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombreDeUsuario_TextChanged(object sender, EventArgs e)
        {

        }

       


    }
}
