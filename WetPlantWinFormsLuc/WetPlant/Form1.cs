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

namespace WetPlant
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();
            Load += new EventHandler(Form1_load);
        }

        // Handle: Cargar Form
        private void Form1_load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Serial serial = new Serial();
            serial.Config("COM4", 9600);
            serial.SetTimeout(500, 500);
            serial.Open();
           

            serial.Close();
        }

        private void asyncFunct()
        {

        }
    }
    public class Serial
    {
        static SerialPort serialport;
        public Serial()
        {
            serialport = new SerialPort();
        }

        public void Config(string port, int baudrate)
        {
            serialport.PortName = port;
            serialport.BaudRate = baudrate;
            serialport.Parity = Parity.None;
            serialport.StopBits = StopBits.One;
            serialport.Handshake = Handshake.None;
        }

        public bool Open()
        {
            try
            {
                serialport.Open();
            }
            catch(Exception ex)
            {
                return false;
            }
            return true;
        }

        public void SetTimeout(int read, int write)
        {
            serialport.ReadTimeout = read;
            serialport.WriteTimeout = write;
        }

        public void Close()
        {
            serialport.Close();
        }

        public string ReadData()
        {
            return serialport.ReadLine();
        }

        public void SendData(string data)
        {
            serialport.Write(data);
        }
    }
}
