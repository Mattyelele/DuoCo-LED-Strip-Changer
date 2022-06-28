using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Renci.SshNet;

namespace LEDChanger
{
    public partial class Form1 : Form
    {
        static string piip = Properties.Settings.Default.ip;
        static string piusername = Properties.Settings.Default.username;
        static string pipassword = Properties.Settings.Default.password;
        SshClient cssh = new SshClient(piip, piusername, pipassword);
        public Form1()
        {
            InitializeComponent();
            ipinput.Text = Properties.Settings.Default.ip;
            usernameinput.Text = Properties.Settings.Default.username;
            passwordinput.Text = Properties.Settings.Default.password;
            btinput.Text = Properties.Settings.Default.bluetooth;
        }

        private void cntbutt_Click(object sender, EventArgs e)
        {
            try
            {
                if (cssh.IsConnected)
                {
                    MessageBox.Show("Your already connected silly :>");
                    Console.WriteLine(e.ToString());
                } else
                {
                    cssh.Connect();
                    connectionstatus.Text = "Connected!";
                    connectionstatus.ForeColor = Color.Green;
                    ipinput.Text = Properties.Settings.Default.ip;
                    usernameinput.Text = Properties.Settings.Default.username;
                    passwordinput.Text = Properties.Settings.Default.password;
                    Properties.Settings.Default.Save();
                    if (btinput.Text == "" && Properties.Settings.Default.bluetooth == "")
                    {
                        Console.WriteLine("no bt");
                    } else
                    {
                        btinput.Text = Properties.Settings.Default.bluetooth;
                        Properties.Settings.Default.Save();
                    }
                }
            }
            catch
            {
                connectionstatus.Text = "Failed To Connect!";
                connectionstatus.ForeColor = Color.Red;
            }
        }

        private void setcolor_Click(object sender, EventArgs e)
        {
            if (colorslist.Text == "Red")
            {
                if (cssh.IsConnected)
                {
                    cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e000503ff000000ef");

                } else
                {
                    MessageBox.Show("Your not connect to your pi or LEDs");
                }
            } else if (colorslist.Text == "Green")
            {
                if (cssh.IsConnected)
                {
                    cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e00050300ff0000ef");
                } else
                {
                    MessageBox.Show("Your not connect to your pi or LEDs");
                }
            }
            else if (colorslist.Text == "Blue")
            {
                if (cssh.IsConnected)
                {
                    cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e0005030000ff00ef");
                } else
                {
                    MessageBox.Show("Your not connect to your pi or LEDs");
                }
            }
        }

        private void poweron_Click(object sender, EventArgs e)
        {
            if (cssh.IsConnected)
            {
                cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e0004f00001ff00ef");
            } else
            {
                MessageBox.Show("Your not connect to your pi or LEDs");
            }
        }

        private void poweroff_Click(object sender, EventArgs e)
        {
            if (cssh.IsConnected)
            {
                cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e0004000000ff00ef");
            } else
            {
                MessageBox.Show("Your not connect to your pi or LEDs");
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (cssh.IsConnected)
            {
                this.colorDialog1 = new System.Windows.Forms.ColorDialog();
                ColorDialog colorDlg = new ColorDialog();
                colorDlg.ShowDialog();

                int value = colorDlg.Color.ToArgb();

                string specifier = "X";
                string hex = value.ToString(specifier);
                hex = hex.Remove(0, 2);
                cssh.RunCommand($"sudo gatttool -b {btinput.Text} --char-write-req -a 0x0009 -n 7e000503{hex}00ef");
            } else
            {
                MessageBox.Show("Your not connect to your pi or LEDs");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var command = cssh.RunCommand("sudo hcitool lescan");
            command.Execute();
            Thread.Sleep(5000);
            var result = command.Result;
            cssh.RunCommand("\u0003");
            if (result.Contains("BE:"))
            {
                Console.WriteLine("Found the device");
            }
            Console.WriteLine(result);
            
        }
    }
}
