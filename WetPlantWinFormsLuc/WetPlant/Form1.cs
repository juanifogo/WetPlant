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
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace WetPlant
{
    public partial class MainWindow : Form
    {
        private Serial serial = new Serial();
        private Thread thread;

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
     
        }

        public void UpdateData()
        {
            while (true)
            {
                string[] fdata = { "", "", "" };
                string data = serial.ReadData();
                int j = 0;

                for (int i = 0; i < data.Length; i++)
                {
                    fdata[j] += data[i].ToString();
                    if (data[i].ToString() == " ")
                    {
                        j++;
                    }
                }
                label1.Text = fdata[0].ToString();
                label3.Text = fdata[1].ToString();
                label4.Text = fdata[2].ToString();
            }
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            serial.Config("COM4", 9600);
            serial.SetTimeout(500, 500);
            if(serial.Open() == false)
            {
                MessageBox.Show("Error al conectarse con el puerto serie!!", "Fatal_Error");
                
                Environment.Exit(1);
            }
            thread = new Thread(new ThreadStart(UpdateData));
            thread.Start();
        }

        private void MainWindow_FormClosed(object sender, FormClosedEventArgs e)
        {
            thread.Abort();
        }
    }
    public class Serial
    {
        SerialPort serialport;
        public Serial()
        {
            serialport = new SerialPort();
        }
        /*
        public string GetPort()
        {
            // Generamos un proceso Para obtener los coms
            var proc = new Process { StartInfo = new ProcessStartInfo { 
                FileName= @"C:\Windows\System32\mode.com", 
                UseShellExecute = false, 
                RedirectStandardOutput= true, 
                CreateNoWindow=true 
            } };
            proc.Start();
            proc.WaitForExit(4000);

            var output = proc.StandardOutput.ReadToEnd();

            List<string> comPortsBeingUsed = new List<string>();
            Regex.Replace(output, @"(?xi) status [\s\w]+? (COM\d) \b ", regexCapture =>
            {
                comPortsBeingUsed.Add(regexCapture.Groups[1].Value);
                return null;
            });

            foreach (var item in comPortsBeingUsed)
            {
                return item;
            }
            return "";
        }
        */

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
