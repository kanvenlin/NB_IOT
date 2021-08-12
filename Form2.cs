
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GonDo_Modbus;


namespace NB_iot
{
    public partial class Form2 : Form
    {   
       
        FileFloder ff = new FileFloder();
        public Form2()
        {
            InitializeComponent();
        }
 
        private void Form2_Load(object sender, EventArgs e)
        {
            
           
        }


       

 
        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Close();
        }




      
    }
 }


