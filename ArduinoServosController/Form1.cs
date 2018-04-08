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

namespace ArduinoServosController
{
    public partial class Form1 : Form
    {

        SerialPort port;
        public Form1()
        {
            InitializeComponent();
            initfunction();
        }

        public void initfunction()
        {

            port = new SerialPort();
            port.PortName = "COM6";
            port.BaudRate = 9600;


            try
            {

                port.Open();
            }
            catch (Exception e1) { 

            MessageBox.Show(e1.Message);
         }



        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

            if (port.IsOpen)
            {

                port.WriteLine(trackBar1.Value.ToString());
                degreelab.Text = "Degree = " + trackBar1.Value.ToString(); 



            }

        }

        
    }
}