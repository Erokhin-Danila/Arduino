using System;
using System.Windows.Forms;
using System.IO.Ports;
using System.Threading; // Библиотека для многопоточного программирования
using System.IO;

namespace Arduino
{
    public partial class Form1 : Form
    {
        bool isConnected = false;
        Thread readThread;
        string a;

        public Form1()
        {
            InitializeComponent();
        }

        private void arduinoButton_Click(object sender, EventArgs e)
        {
            comboBox.Items.Clear();
            // Получаем список COM портов доступных в системе
            string[] portnames = SerialPort.GetPortNames();
            // Проверяем есть ли доступные
            if (portnames.Length == 0)
            {
                MessageBox.Show("COM PORT not found");
            }
            foreach (string portName in portnames)
            {
                //добавляем доступные COM порты в список           
                comboBox.Items.Add(portName);
                if (portnames[0] != null)
                {
                    comboBox.SelectedItem = portnames[0];
                }
            }
        }

        private void button_ELEVEN_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("1");
                a = "1";
            }
        }

        private void button_ZERO_Click(object sender, EventArgs e)
        {
            if (isConnected)
            {
                serialPort.Write("0");
                a = "0";
            }
        }

        private void connectButton_Click(object sender, EventArgs e)
        {
            if (!isConnected)
            {
                connectToArduino();
                StartReading(); // Запуск потока для записи данных, которые поступают из COM-порта
            }
            else
            {
                StopReading(); // Остановка потока чтения данных COM-порта
                disconnectFromArduino();
            }
        }
        private void StartReading()
        {
            readThread = new Thread(ReadData);
            readThread.Start();
        }

        private void StopReading()
        {
            if (readThread != null && readThread.IsAlive)
            {
                readThread.Abort();
                readThread.Join();
            }
        }

        private void ReadData()
        {
            try
            {
                while (isConnected)
                {
                    if (serialPort.IsOpen) // Проверка состояния COM-порта
                    {
                        // Чтение данных из COM-порта   
                        //string data = serialPort.ReadLine();

                        // Изменение элемента управления textBox1 в главном потоке
                        Invoke((Action)(() =>
                        {
                            textBox1.Text += a;
                        }));

                        Thread.Sleep(5000); // задержка на 5 секунд
                    }
                    else
                    {
                        break; // Выход из цикла, если COM-порт закрыт
                    }
                }
            }
            catch (ThreadAbortException)
            {
                // Поток прерван, ничего не делаем
            }
        }

        private void connectToArduino()
        {
            isConnected = true;
            string selectedPort = comboBox.GetItemText(comboBox.SelectedItem);
            serialPort.PortName = selectedPort;
            serialPort.Open();
            connectButton.Text = "Disconnect";
        }

        private void disconnectFromArduino()
        {
            isConnected = false;
            serialPort.Close();
            connectButton.Text = "Connect";
            textBox1.Clear();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopReading(); // Остановка потока чтения данных из COM-порта

            if (serialPort.IsOpen)
                serialPort.Close();
        }
    }
}