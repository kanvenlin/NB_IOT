using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
namespace GonDo_Modbus
{
    class Serialcom
    {
        public static void SetCOM(SerialPort port, Button btn)       //close port
        {
            port.Close();
            btn.Text = " OPEN PORT";
            //   btn.Text= port.IsOpen==true ? " OPEN PORT" : " CLOSE PORT";
        }
        public static void SetCOM(SerialPort port, Button btn, ComboBox box)   //open port
        {
            port.PortName = (string)box.SelectedItem;
            port.Open();
            btn.Text = " CLOSE PORT";
        }

        public static void GetPort(ComboBox box)
        {

            string[] serialPorts = SerialPort.GetPortNames();
            box.Items.Clear();
            foreach (string serialPort in serialPorts)
            {
                box.Items.Add(serialPort);
                box.SelectedIndex = box.Items.Count - 1;
            }
        }


    }
}
