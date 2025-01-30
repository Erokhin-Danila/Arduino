namespace Arduino
{
    partial class Form1
    {
        /// 

        /// Required designer variable.
        /// 

        private System.ComponentModel.IContainer components = null;

        /// 

        /// Clean up any resources being used.
        /// 

        /// true if managed resources should be disposed; otherwise, false.
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// 

        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// 

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.arduinoButton = new System.Windows.Forms.Button();
            this.serialPort = new System.IO.Ports.SerialPort(this.components);
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.connectButton = new System.Windows.Forms.Button();
            this.turnOnButton = new System.Windows.Forms.Button();
            this.turnOffButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // arduinoButton
            // 
            this.arduinoButton.Location = new System.Drawing.Point(81, 35);
            this.arduinoButton.Name = "arduinoButton";
            this.arduinoButton.Size = new System.Drawing.Size(121, 23);
            this.arduinoButton.TabIndex = 0;
            this.arduinoButton.Text = "Get COM-port";
            this.arduinoButton.UseVisualStyleBackColor = true;
            this.arduinoButton.Click += new System.EventHandler(this.arduinoButton_Click);
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(81, 64);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(121, 21);
            this.comboBox.TabIndex = 4;
            // 
            // connectButton
            // 
            this.connectButton.BackColor = System.Drawing.Color.Lavender;
            this.connectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectButton.Location = new System.Drawing.Point(81, 91);
            this.connectButton.Name = "connectButton";
            this.connectButton.Size = new System.Drawing.Size(121, 23);
            this.connectButton.TabIndex = 5;
            this.connectButton.Text = "Connect";
            this.connectButton.UseVisualStyleBackColor = false;
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // turnOnButton
            // 
            this.turnOnButton.Location = new System.Drawing.Point(104, 178);
            this.turnOnButton.Name = "turnOnButton";
            this.turnOnButton.Size = new System.Drawing.Size(75, 23);
            this.turnOnButton.TabIndex = 6;
            this.turnOnButton.Text = "On";
            this.turnOnButton.UseVisualStyleBackColor = true;
            this.turnOnButton.Click += new System.EventHandler(this.button_ELEVEN_Click);
            // 
            // turnOffButton
            // 
            this.turnOffButton.Location = new System.Drawing.Point(104, 219);
            this.turnOffButton.Name = "turnOffButton";
            this.turnOffButton.Size = new System.Drawing.Size(75, 23);
            this.turnOffButton.TabIndex = 7;
            this.turnOffButton.Text = "Off";
            this.turnOffButton.UseVisualStyleBackColor = true;
            this.turnOffButton.Click += new System.EventHandler(this.button_ZERO_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 8;
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(395, 364);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.turnOffButton);
            this.Controls.Add(this.turnOnButton);
            this.Controls.Add(this.connectButton);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.arduinoButton);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button arduinoButton;
        private System.IO.Ports.SerialPort serialPort;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button connectButton;
        private System.Windows.Forms.Button turnOnButton;
        private System.Windows.Forms.Button turnOffButton;
        private System.Windows.Forms.TextBox textBox1;
    }
}

