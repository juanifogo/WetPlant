using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading;
using System.Data.OleDb;
namespace wetPlant
{
    public partial class Pagina2 : Form
    {
        System.IO.Ports.SerialPort Arduino;
        bool IsClosed = false;
        
        public Pagina2()
        {
            InitializeComponent();
            Arduino = new System.IO.Ports.SerialPort();
            Arduino.PortName = "COM3";
            Arduino.BaudRate = 9600;
            Arduino.Open();
        }
        private void Pagina2_Load(object sender, EventArgs e)
        {
            Thread Hilo = new Thread(Escuchar);
            Hilo.Start();

        }
        private void Escuchar()
        {
            while (!IsClosed)
            {
                try
                {
                    string Lectura = Arduino.ReadLine().Trim();
                    var words = Lectura.Split(' ');
                    txtMonitorserial.Invoke(new MethodInvoker(
                        delegate
                        {
                            txtMonitorserial.Text = Lectura;
                            txtTemperatura2.Text = words[1];
                            txtHumedad.Text = words[3];
                            txtLuz.Text = words[5];
                        }
                        ));
                }
                catch { }
            }
        }

        private void btnBuscarPuertos_Click(object sender, EventArgs e)
        {
            string[] PuertosDisponibles = SerialPort.GetPortNames();
            cboPuertos.Items.Clear();
            foreach (string puerto_simples in PuertosDisponibles)
            {
                cboPuertos.Items.Add(puerto_simples);
            }
            if (cboPuertos.Items.Count > 0)
            {
                cboPuertos.SelectedIndex = 0;
                MessageBox.Show("selecionar un puerto para trabajar");
                btnConectarPuertos.Enabled = true;
            }
            else
            {
                MessageBox.Show("ningun puerto detectado");
                cboPuertos.Items.Clear();
                cboPuertos.Text = "                   ";
                btnConectarPuertos.Enabled = false;
                //btnEnviarDatos.Enable= false;
            }
        }

        private void btnConectarPuertos_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnConectarPuertos.Text == "conectar")
                {
                    spPantallaDeInicio.BaudRate = 9600;
                    spPantallaDeInicio.DataBits = 8;
                    spPantallaDeInicio.Parity = Parity.None;
                    spPantallaDeInicio.StopBits = StopBits.One;
                    spPantallaDeInicio.Handshake = Handshake.None;
                    spPantallaDeInicio.PortName = cboPuertos.Text;

                    try
                    {
                        spPantallaDeInicio.Open();
                        btnConectarPuertos.Text = "desconectar";
                        //btnEnviarDatos.Enable = true;
                    }
                    catch (Exception exc)
                    {
                        MessageBox.Show(exc.Message.ToString());
                    }
                    //else if btnConectarPuertos.Text ()
                }
                {
                    spPantallaDeInicio.Close();
                    btnConectarPuertos.Text = "conectar";
                }
            }
            //btnEnviarDatos.Enable = false;                }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message.ToString());
            }

        }
       


        private void btnIniciar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    if (Convert.ToInt32(txtTemperatura2.Text) < 200 && Convert.ToInt32(txtHumedad.Text) > 20 && Convert.ToSingle(txtLuz.Text) > 30) // lamp + bomb + vent
                    {
                        Arduino.Write("X");
                    }
                    else
                    {
                        if (Convert.ToInt32(txtTemperatura2.Text) < 200 && Convert.ToInt32(txtHumedad.Text) > 20) // lamp + bomb
                        {
                            Arduino.Write("A");
                        }
                        else
                        {
                            if (Convert.ToInt32(txtTemperatura2.Text) < 200 && Convert.ToSingle(txtLuz.Text) > 30) // lamp + vent
                            {
                                Arduino.Write("C");
                            }
                            else
                            {
                                if (Convert.ToInt32(txtHumedad.Text) > 20 && Convert.ToSingle(txtLuz.Text) > 30) // bomb + vent
                                {
                                    Arduino.Write("D");
                                }
                                else
                                {
                                    if (Convert.ToInt32(txtTemperatura2.Text) < 200) // lamp
                                    {
                                        Arduino.Write("L");
                                    }
                                    if (Convert.ToInt32(txtHumedad.Text) > 20) // bomb
                                    {
                                        Arduino.Write("B");
                                    }
                                    if (Convert.ToSingle(txtLuz.Text) > 15) // vent
                                    {
                                        Arduino.Write("V");
                                    }
                                }
                            }
                        }


                    }
                }
                catch { }
            
        }

        private void Pagina2_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Arduino.IsOpen)
            {
                Arduino.Close();
            }
        }

        private void btnAtras3_Click(object sender, EventArgs e)
        {
            PantallaPrincipal pp = new PantallaPrincipal();
            pp.Visible = true;
            this.Hide();
        }
    }

    }
    

