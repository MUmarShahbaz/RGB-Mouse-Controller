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
using System.Linq.Expressions;

namespace RGB_Controller
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
           Application.Exit();
        }
        private bool Connected;
        private void Main_Load(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                guna2ComboBox2.Items.Add(port);
            }
            if (guna2ComboBox2.Items.Count > 0)
            {
                guna2ComboBox2.SelectedIndex = 0;
            }
        }
        private int efound = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Connected)
            {
                try
                {
                    serialPort1.WriteLine(txtHex1.Text + txtHex2.Text);
                }
                catch
                {
                    timer1.Enabled = false;
                    MessageBox.Show("An Error Ocurred, can't transmit to the Serial Port");
                    serialPort1.Close();
                    Connect.Text = "Connect";
                    Connected = false;
                    progressBar1.Value = 0;
                }
            }
        }

        private async void Save_Click(object sender, EventArgs e)
        {
            if (Connected)
            {
                try
                {
                    serialPort1.WriteLine("S" + txtHex1.Text + txtHex2.Text);
                    await Task.Delay((int)(int.Parse(Interval.Text)*1.5));
                    MessageBox.Show("Saved " + txtHex1.Text + " & " + txtHex2.Text);
                } catch 
                {
                    MessageBox.Show("Couldn't transmit to " + guna2ComboBox2.Text);
                }
            }
        }

        private void Connect_Click(object sender, EventArgs e)
        {
            if (!Connected)
            {
                if (guna2ComboBox2.Text != "")
                {
                    serialPort1 = new SerialPort(guna2ComboBox2.Text);
                    serialPort1.BaudRate = int.Parse(guna2ComboBox1.Text);
                    try
                    {
                        serialPort1.Open();
                        Connected = true;
                        Connect.Text = "Disconnect";
                        timer1.Enabled = true;
                        progressBar1.Value = 100;
                    }
                    catch
                    {
                        MessageBox.Show("Could not connect to " + guna2ComboBox2.Text);
                    }
                }
            } else
            {
                serialPort1.Close();
                Connect.Text = "Connect";
                timer1.Enabled = false;
                Connected = false;
                progressBar1.Value = 0;
            }
        }

        private void guna2ComboBox2_DropDown(object sender, EventArgs e)
        {
            guna2ComboBox2.Items.Clear();
            string[] ports = SerialPort.GetPortNames();
            foreach (var port in ports)
            {
                guna2ComboBox2.Items.Add(port);
            }
            if (guna2ComboBox2.Items.Count > 0)
            {
                guna2ComboBox2.SelectedIndex = 0;
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            timer1.Interval = int.Parse(textBox1.Text);
        }
    }
}
