using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports; //used for scanning the serial ports

delegate void StringArgReturningVoidDelegate(string text); //used for fixing multithreading problems

namespace IR_Remote
{
    public partial class Form1 : Form
    {
        //public object serial_Port { get; private set; }        
        public Form1()
        {
            InitializeComponent();
            
            int itemsFound = 0; //how many active ports are found
            //finding available serial ports and filling up the combo box with found port names
            foreach (string s in SerialPort.GetPortNames())
            {
                port_comboBox.Items.Add(s);                
                itemsFound++;//incrementing the items found variable               
            }
            if (itemsFound < 1)            
                MessageBox.Show("NO ITEMS FOUND");//if no serial devices have been found, an error message window will show up
            else
                port_comboBox.SelectedIndex = 0;//if there were found active ports, than the first one is going to be automatically selected in the combo box                                    
        }
     
        private void bt_scanPort_Click(object sender, EventArgs e)
        {
            {
                int itemsFound = 0; //how many active ports are found
                port_comboBox.Items.Clear(); //limpiar
                                             //finding available serial ports and filling up the combo box with found port names
                foreach (string s in SerialPort.GetPortNames())
                {
                    port_comboBox.Items.Add(s);//adding port name to combo box
                    itemsFound++;//incrementing the items found variable
                }

                if (itemsFound < 1)               
                    MessageBox.Show("NO ITEMS FOUND");//if no serial devices have been found, an error message window will show up
                else
                    port_comboBox.SelectedIndex = 0;//if there were found active ports, than the first one is going to be automatically selected in the combo box                
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen)
            {
                serialPort1.Close();
                label1.Text = "Estado: Desconectado";
            }
            this.serialPort1.PortName = port_comboBox.Text;         //if the value of the combo box was changed then the serial port component port name will be updated
        }

        private void conectar_Click(object sender, EventArgs e)
        {
            try
            {
                serialPort1.Open();//the specific command to open the serial port
                label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void bt_disconect_Click(object sender, EventArgs e)
        {
                serialPort1.Close();
                label1.Text = "Estado: Desconectado";            
        }

        private void bt_send_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }                
                serialPort1.WriteLine(env_textBox.Text);
                env_textBox.Text = "";                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }                                                
        }

        private void env_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            try { 
                if (e.KeyChar == Convert.ToInt16(Keys.Enter))
                {
                    if (!serialPort1.IsOpen)
                    {
                        serialPort1.Open();
                        label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;

                    }
                    serialPort1.WriteLine(env_textBox.Text);
                    e.Handled = true;
                    //env_textBox.Text = "";
                }
                if (e.KeyChar == Convert.ToInt16(Keys.Escape))
                {
                    env_textBox.Text = "";
                    e.Handled = true;
                }
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
}

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            try { 
                SerialPort sp = (SerialPort)sender;
                string s;
                s = sp.ReadLine();
                SetTextOftbdatareceiver(s);
            } catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
}

        private void SetTextOftbdatareceiver(string text)
        {
            // InvokeRequired required compares the thread ID of the
            // calling thread to the thread ID of the creating thread.
            // If these threads are different, it returns true.
            if (this.tb_datareceiver.InvokeRequired)
            {
                StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetTextOftbdatareceiver);
                this.Invoke(d, new object[] { text });
            }
            else
            {
                this.tb_datareceiver.Text = text;                
            }                       
        }

        private void bt_on_off_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("on");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);//displaying the error in a message box
            }
        }

        private void bt_volplus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("volS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_volminus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("volb");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_pplus_Click(object sender, EventArgs e)
        {            
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("prgS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_pminus_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("prgb");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_menu_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("menu");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_fl_arriba_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("flechaS");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_fl_izquierda_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("flechaZ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_ok_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("ok");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_fl_derecha_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("flechaD");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_fl_abajo_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("flechaA");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_return_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("return");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_exit_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("exit");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_mute_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("mute");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_CH_List_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("chlist");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_prech_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("prech");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_source_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("source");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }
        //------------------ TECLADO NUMERICO ---------------------------------
        private void bt_1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("uno");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("dos");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_3_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("tres");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_4_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("cuatro");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_5_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("cinco");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_6_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("seis");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_7_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("siete");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_8_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("ocho");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_9_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("nueve");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }

        private void bt_0_Click(object sender, EventArgs e)
        {
            try
            {
                if (!serialPort1.IsOpen)
                {
                    serialPort1.Open();
                    label1.Text = "Estado: Conectado en puerto " + serialPort1.PortName;
                }
                serialPort1.WriteLine("cero");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message); //displaying the error in a message box
            }
        }        
    }
}
