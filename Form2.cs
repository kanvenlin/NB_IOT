
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
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
            //  this.Cursor = default;


          //  toolTip1.SetToolTip(txtSec, "word");

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
          
            this.Dispose();
            this.Close();
          

        }
        /*
         *   基準日期：1980/01/01 00:00:00 
         *   閏年: 年份需要是 ( 4 的倍數 & 年份不是100 的倍數 ) | 400 的倍數
         *   閏年: 二月29天  366天
         *   平年: 二月28天  365天
         * */
        readonly uint basesec = 0;
        readonly uint yearsec = 31536000;
     //   readonly uint daysec = 86400;
     //   readonly uint hoursec = 3600;
     //   readonly uint minsec = 60;
        readonly uint startyear = 1980;
        readonly uint[] c_sec = new uint[]{86400,3600,60};

        long totalsec;
        
        private bool IsLeep(uint year)
        {
            return ((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0);
        }
        private long getSec(uint year)
        {
            long sec=yearsec ;
            if(IsLeep(year))
            {
                sec += c_sec[0];    // daysec;
            }
            return sec;
        }

        public string getdate(string strdate)
        {
            string date_str;
            int[] day = new int[] { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };	//平年月份的天數 ，閏年二月為28天
            uint[] date = new uint[] { 0, 1, 1, 0, 0, 0 };

            long sec = 0;
            totalsec = getSec(startyear);

            //uint ss = MyEnum.YY1;

            date[0] = startyear;
            if (strdate != "")
            {
                if (!(long.TryParse(strdate, out sec)))
                {
                    try
                    {
                        sec = int.Parse(strdate, NumberStyles.HexNumber);
                    }
                    catch
                    {
                        MessageBox.Show("請輸入十六進制或十進制數值");
                    }
                }
            }
            sec -= basesec;

            while (sec >= totalsec)        //計算年份
            {
                sec -= totalsec;
                date[0]++;
                totalsec = getSec(date[0]);
            }
            if (IsLeep(date[0]))              //閏年
                day[1] = 29;             //二月29天  
            totalsec = day[date[1] - 1] * c_sec[0];  //daysec;
            while (sec >= totalsec)
            {
                sec -= totalsec;
                date[1]++;
                totalsec = day[date[1] - 1] * c_sec[0];  //daysec;
            }

            for (int i = 2; i < 5; i++)     //日，時，分
            {
                totalsec = c_sec[i - 2];
                while (sec >= totalsec)
                {
                    sec -= totalsec;
                    date[i]++;
                }
            }
            date[5] = (uint)sec;
            date_str = $" {date[0]} / {date[1]:D2} / {date[2]:D2}  {date[3]:D2} :{date[4]:D2}:{date[5]:D2}";
            return date_str;
        }
   
        private void btnCalcData_Click(object sender, EventArgs e)
        {
            txtDate.Text= getdate(txtSec.Text);
            
        }

        private void btnConvert_Click(object sender, EventArgs e)
        {
            int i = 0,j=0,value=0,cnt=0;

            byte[] code = new byte[80];
            string[] f1 = new string[23];                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                      
            if (txtCode.Text != "")
            {
                marco.HexStrToHexByte(txtCode.Text,ref code);
            }
            f1[0] = "A";
            f1[0] = "2";
            for (i=0;i<code.Length;i+=80)
            {
                cnt++;
                f1[0] = Convert.ToString(cnt);
                f1[1] = System.Text.Encoding.ASCII.GetString(code, i, 2);               //ver
                f1[2] = BitConverter.ToSingle(code, i+2).ToString("F3");                //bat
                f1[3] = getdate(BitConverter.ToUInt32(code,i+6).ToString());            //date
                f1[4] = System.Text.Encoding.ASCII.GetString(code, i+10, 8);            //station
                for(j=0;j<12;j++)
                    f1[j+5] = BitConverter.ToSingle(code, i+18+j*4).ToString("F4");     //ch1~ch12
                f1[17]= BitConverter.ToSingle(code,i+66).ToString();                    //rain
                f1[18] = Convert.ToString(code[i + 70]);                                //door
                if (code[i + 71] == 0)                                                  //sim
                    f1[19] = "eMTC";
                else
                    f1[19] = "NBIoT";
                for (j = 0; j < 3; j++)                                                 //single
                {
                    Array.Reverse(code, i + 72 + j*2, 2);
                    value = BitConverter.ToUInt16(code, i + 72 + j * 2)-32767;                 
                    f1[20+j] = value.ToString();
                }
                dataGridView1.Rows.Add(f1);
            }
        }

        private void btnclr_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
 }


