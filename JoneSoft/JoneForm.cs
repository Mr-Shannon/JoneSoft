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

namespace JoneSoft 
{
    public partial class JoneForm : Form
    {
        Boolean isPortOpen = false;
        SerialPort serial  = new SerialPort();
        public JoneForm()
        {
            InitializeComponent();
            ComboBox_Default();
            PortPictureBox_Init();
            serial.DataReceived += Serial_ReceiveData; //注册数据接收事件
            receiveRichTextBox.ReadOnly = true;
            SerialStatusStrip_View();
            sendRichTextBox.Text = "你好！";
        }

        private void ComboBox_Default() //ComboBox默认值设置
        {
            baudRateComboBox.SelectedIndex  = 0;
            dataBitComboBox.SelectedIndex   = 3;
            stopBitComboBox.SelectedIndex   = 0;
            parityBitComboBox.SelectedIndex = 0;
        }

        private void PortPictureBox_Init()
        {
            portPictureBox.Image = JoneSoft.Properties.Resources.port_off; //图片 
            statusPortLabel.Text = "开启串口";
            portPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;  //图片的大小适应控件PictureBox的大小  
        }

        private void ComboBox_Enable(Boolean status)
        {
            if (status == false)
            {
                portComboBox.Enabled      = false;
                stopBitComboBox.Enabled   = false;
                baudRateComboBox.Enabled  = false;
                dataBitComboBox.Enabled   = false;
                stopBitComboBox.Enabled   = false;
                parityBitComboBox.Enabled = false;
            }
            else
            {
                portComboBox.Enabled      = true;
                stopBitComboBox.Enabled   = true;
                baudRateComboBox.Enabled  = true;
                dataBitComboBox.Enabled   = true;
                stopBitComboBox.Enabled   = true;
                parityBitComboBox.Enabled = true;
            }
        }

        private void SerialStatusStrip_View()
        {
            string status = "串口状态：关闭";
            if(isPortOpen)
            {

                portStatusToolStripStatusLabel.Text = "串口状态：打开，"+ portComboBox.Text.Trim() + " ," +
                baudRateComboBox.Text.Trim() + "bps, " + dataBitComboBox.Text.Trim() + ", " + 
                stopBitComboBox.Text.Trim()  + ", "    + parityBitComboBox.Text.Trim();  
            }
            else
            {
                portStatusToolStripStatusLabel.Text = status.PadRight(55);
            }
        }

        private void StopBit_Configuration(SerialPort serial)//设置停止位
        {
            if (portComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请设置停止位！");
                return;
            }
            if (stopBitComboBox.Text.Trim() == "1位")
                serial.StopBits = StopBits.One;
            else if (stopBitComboBox.Text.Trim() == "2位")
                serial.StopBits = StopBits.Two;
            else MessageBox.Show("请选择正确的停止位！");

        }

        private void ParityBit_Configuration(SerialPort serial)//设置停止位
        {
            if (portComboBox.Text.Trim() == string.Empty)
            {
                MessageBox.Show("请设置校验格式！");
                return;
            }
            if (parityBitComboBox.Text.Trim() == "无")
                serial.Parity = Parity.None;
            else if (parityBitComboBox.Text.Trim() == "奇校验")
                serial.Parity = Parity.Odd;
            else if (parityBitComboBox.Text.Trim() == "偶校验")
                serial.Parity = Parity.Even;
            else MessageBox.Show("请选择正确的校验格式！");
        }

        private void PortComboBox_DropDown(object sender, EventArgs e)
        {
           String[] port_name = SerialPort.GetPortNames(); //获取可用串口

            if (port_name.Length == 0)
            {
                MessageBox.Show("无可用端口！");
            }
            else
            {     
                portComboBox.Items.Clear();
                for (int i = 0; i < port_name.Length; i++)  
                {
                    portComboBox.Items.Add(port_name[i]);
                }
            }
            
        }
        private void PortPictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            if (isPortOpen)
            {
                try
                {
                    serial.Dispose();
                    serial.Close();
                    portPictureBox.Image = JoneSoft.Properties.Resources.port_off;
                    ComboBox_Enable(true);
                    statusPortLabel.Text = "开启串口";
                    isPortOpen = false;  
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口关闭失败！" + ex.Message);
                }

            }
            else
            {
                if (portComboBox.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("请选择端口！");
                    return;
                }

                serial.PortName = portComboBox.Text.Trim();     //设置串口号
                serial.BaudRate = Convert.ToInt32(baudRateComboBox.Text.Trim()); //设置波特率
                serial.DataBits = Convert.ToInt32(dataBitComboBox.Text.Trim()); //设置数据位
                StopBit_Configuration(serial); //设置停止位
                ParityBit_Configuration(serial); //设置校验位

                try
                {
                    serial.Open();
                    portPictureBox.Image = JoneSoft.Properties.Resources.port_on;
                    ComboBox_Enable(false);
                    statusPortLabel.Text = "关闭串口";
                    isPortOpen = true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("串口打开失败！" + ex.Message);
                }
            }
            SerialStatusStrip_View();
        }
        private void Serial_ReceiveData(object sender, SerialDataReceivedEventArgs e)
        {
            this.Invoke((EventHandler)(delegate
            {
                receiveRichTextBox.Text += Convert.ToString(serial.ReadLine());    
            }));
        }
        private void Serial_SendData()
        {
            if (!isPortOpen) return;
            if (sendRichTextBox.Text == string.Empty) return;

            serial.WriteLine(Convert.ToString( sendRichTextBox.Text));
        }

        private void SendDataButton_MouseClick(object sender, MouseEventArgs e)
        {
            Serial_SendData();
        }

        private void ClearReceiveButton_MouseClick(object sender, MouseEventArgs e)
        {
            receiveRichTextBox.Clear();
        }

        private void ClearSendButton_MouseClick(object sender, MouseEventArgs e)
        {
            sendRichTextBox.Clear();
        }

        private void MultiSendButton_MouseClick(object sender, MouseEventArgs e)
        {
            if (!isPortOpen) return;
            MultiSendForm multi_send_form = new MultiSendForm();

            multi_send_form.Show();
        }
    }
}
