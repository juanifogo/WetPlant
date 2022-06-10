using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace wetPlant
{
    public partial class PantallaPrincipal : Form
    {
        string NombreUsuario = PantallaDeInicio.NombreUsuario;
        public static string Temperatura = "";

        OleDbConnection conexion = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source= WetPlant.accdb");

        DataSet ds = new DataSet();

        public SerialPort sp;

        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void PantallaPrincipal_Load(object sender, EventArgs e)
        {
            conexion.Open();
        }

        private void btnAtrasPantallaPrincipal2_Click(object sender, EventArgs e)
        {
            PantallaDeInicio pdi = new PantallaDeInicio();
            pdi.Visible = true;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string planta = txtBuscador.Text;

            string sql = "SELECT * FROM Tipos WHERE Nombre = '"+planta+"'";

            OleDbCommand command = new OleDbCommand(sql, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(command);

            da.Fill(ds, "planta_info");
            

            lblTemperatura.Text = (ds.Tables["planta_info"].Rows[0]["Temperatura C"].ToString());

            lblLuz.Text = (ds.Tables["planta_info"].Rows[0]["Horas de luz"].ToString());

            lblRiego.Text = (ds.Tables["planta_info"].Rows[0]["Cada cuanto se riega hrs"].ToString());

            lblFamilia.Text = (ds.Tables["planta_info"].Rows[0]["Familia"].ToString());

            ds.Tables["planta_info"].Clear();


        }

        private void txtBuscador_TextChanged(object sender, EventArgs e)
        {

        }
       

        private void button1_Click_1(object sender, EventArgs e)
        {
            PantallaDeInicio f1 = new PantallaDeInicio();
            string planta = "SELECT ID FROM Tipos WHERE Nombre = '" + txtBuscador.Text + "'";
            OleDbCommand command1 = new OleDbCommand(planta, conexion);
            OleDbDataAdapter da = new OleDbDataAdapter(command1);
            da.Fill(ds, "plantas");
            string IDPlantas = ds.Tables["plantas"].Rows[0]["ID"].ToString();
            



            string usuario = "SELECT ID FROM Usuarios WHERE Nombre = '" + NombreUsuario + "'";
            OleDbCommand command2 = new OleDbCommand(usuario, conexion);
            OleDbDataAdapter da2 = new OleDbDataAdapter(command2);
            da2.Fill(ds, "usuarios");
            string IDUsuarios = (ds.Tables["usuarios"].Rows[0]["ID"].ToString());
           
            string sql = "INSERT INTO Plantas ([ID Tipos de planta], [ID Usuarios], Nombre, [Temperatura C], [Horas de luz], [Cada cuanto se riega hrs]) VALUES ('" + IDPlantas + "', '"+ IDUsuarios +"', '"+txtNombre.Text+"', '" + Convert.ToInt32(txtTemperatura.Text) + "', '" + Convert.ToInt32(txtLuz.Text) + "', '" + Convert.ToInt32(txtRiego.Text) + "')";
            OleDbCommand command = new OleDbCommand(sql, conexion);
            command.ExecuteNonQuery();

            ds.Tables["plantas"].Clear();
            ds.Tables["usuarios"].Clear();


        }

        private void btnSiguiente_Click(object sender, EventArgs e)
        {
            Pagina2 pg2 = new Pagina2();
            pg2.Visible = true;
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblC_Click(object sender, EventArgs e)
        {

        }


        //private void btnVegetales_Click(object sender, EventArgs e)//

        // pnlTiposDeVegetales.Visible = true;//


        //private void btnFrutas_Click(object sender, EventArgs e)//

        //pnlTiposDeFrutas.Visible = true;//

    }
}
