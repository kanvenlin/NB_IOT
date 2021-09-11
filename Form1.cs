using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GonDo_Modbus;

namespace NB_iot
{

    public partial class Form1 : Form
    {
        Boolean ReadFlag, GetStar_f = false, CmdStart_f = false, chk0d_f=false;//, ReadT_f = false;
         Boolean GetCmd_f = false, AIContinue_f = false, VerNote_f = false, page_f = false;// Start_f=false;
        Boolean err_f = false, readid_f = false;
        public int errcnt=0;
        public int Receive_Num = 0;
        public int ByteCnt = 0,ReadCnt=0;
        public int Count, Unit , APCnt;
        public byte[] ReadData = new byte[4000];//[320];     //接收rx 暫存器資料
        public byte[] TXReg = new byte[320];
        public byte[] RXReg = new byte[4000];//[320];       //實際資料接收放置位置
        public byte[] t = new byte[20];      //傳送指令暫存位置
        public string str1, str2,cmdstr;
        public int i, j;
      


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            Serialcom.GetPort(boxCom);
            tabFunc.Enabled = false;
            checktriggle(true);     //設定文字輸入的觸發事件
            btnRec.Enabled = false;
            chkASCII.Visible = false;
            foreach (string str in boxType1.Items)
            {
                boxType2.Items.Add(str);
                boxType3.Items.Add(str);
                boxType4.Items.Add(str);
                boxType5.Items.Add(str);
                boxType6.Items.Add(str);
                boxType7.Items.Add(str);
                boxType8.Items.Add(str);
            }
            boxType3.SelectedIndex = 0;
            boxType4.SelectedIndex = 0;
            boxType5.SelectedIndex = 0;
            boxType6.SelectedIndex = 0;
            boxType7.SelectedIndex = 0;
            boxType8.SelectedIndex = 0;
        }

        private void boxHour_TextChanged(object sender, EventArgs e)
        {
            TextBox box = (TextBox)sender;
            int num;
            if (box.Text != "")
            {             
                num =int.Parse(box.Text);
                switch (box.Name)
                {
                    case nameof(boxHour):
                    case nameof(boxCycleHour):            
                    {
                            if (num >= 24)
                            {
                                box.Text = "24";
                                boxMin.Text = boxSec.Text ="00";                       
                            }        
                    }
                    break;
                    default:
                    {
                           if (int.Parse(boxHour.Text) == 24)
                                box.Text = "00";
                           else if (num > 60)
                               box.Text = "60";
                    }
                    break;
                }
            }       
        }
        public void checktriggle(bool h1)
        {
            System.EventHandler h = new System.EventHandler(boxHour_TextChanged);
            if (h1 == true)
            {
                boxHour.TextChanged += h;
                boxMin.TextChanged += h;
                boxSec.TextChanged += h;
                boxCycleSec.TextChanged += h;
                boxCycleMin.TextChanged += h;
                boxCycleHour.TextChanged += h;
            }
            else
            {
                boxHour.TextChanged -= h;
                boxMin.TextChanged -= h;
                boxSec.TextChanged -= h;
                boxCycleSec.TextChanged -= h;
                boxCycleMin.TextChanged -= h;
                boxCycleHour.TextChanged -= h;
            }
        }
        //********************** SET  **************************
        private void SetTitle(ref byte[] data, string send_cmd)           //傳送開頭指令
        {
            byte[] b = System.Text.Encoding.Default.GetBytes(send_cmd);
            for (int i = 0; i < b.Length; i++)
                data[i] = b[i];
        }
        private byte[] SetTitle(string send_com)                         //傳送開頭指令
        {
            return System.Text.Encoding.Default.GetBytes(send_com);
        }

        public void SetTime(ref byte[] data, int offset)    //傳送時間
        {
            byte[] b = new byte[6];
            b = marco.Time2ASCII(DateTime.Now);
            for (int i = 0; i < b.Length; i++)     
                data[i + offset] = b[i];
        }

        public void SendEnd(ref byte[] data, int offset)        //傳送 資料 + crc + /r/n 
        {
            //byte sum = 0;
            int datalen;
            marco.CRC(ref data, offset+2);      //計算crc的值，位置加一
            data[offset+2] = (byte)'\r';
            data[offset + 3] = (byte)'\n';
            SerialCOM.Write(data, 0, offset + 4);
            str1 = null;
          //  boxTX.Items.Add ( marco.ToHexString(data, 0, offset + 3));    //將陣列轉成 hex 字串
          //  boxTX.Items.Add(BitConverter.ToString(data,0,offset+3));      //將陣列轉成 hex 字串 (字串中間會加入 '-'符號)
           // data = data.Where(x => x != 0x00).ToArray();                    //移除陣列裡面的 0x00 (會變動陣列的長度)
             str1 = System.Text.Encoding.ASCII.GetString(data).Trim();       //HEX 轉成 ASCII 的字串
                                                                             //  boxTX.Items.Add(str1);
            datalen = str1.Length;                                                                //  boxTX.SelectedIndex = boxTX.Items.Count - 1;
            str1 = str1.Replace("\0", "");
            rchTx.Text += str1;
            rchTxHex.Text += BitConverter.ToString(data, 0, offset + 4) +"\r\n";
            Array.Clear(TXReg,0, datalen);
            

        }
        public void SetReTime(ref byte[] date, int offset)    //傳送 重置間隔時間
        {
   
            marco.Str2Byte(boxCycleHour.Text, ref date, offset);
            marco.Str2Byte(boxCycleMin.Text, ref date, offset+2);
            marco.Str2Byte(boxCycleSec.Text, ref date, offset+4);
        }

        public void SetA1arm(ref byte[] date, int offset) //傳送Alarm設定
        {
            
            marco.Str2Byte(boxHour.Text, ref date, offset);
            marco.Str2Byte(boxMin.Text, ref date, offset + 2);
            marco.Str2Byte(boxSec.Text, ref date, offset + 4);
            date[offset + 6] = 0x30;
            if (chkHour.Checked)
                date[offset+6] += 1;
            if (chkMin.Checked)
                date[offset + 6] += 2;
            if (chkSec.Checked)
                date[offset + 6] += 4;
        }
        public void putType(ref byte[] data, ComboBox type,TextBox id,TextBox d,  int offset)
        {
            int x;
        
                if ((x = type.SelectedIndex) != -1)
                {
                    data[offset] = (byte)x ;
                    data[offset + 1] = Convert.ToByte(id.Text);
                    try
                    {
                        data[offset + 2] = Convert.ToByte(d.Text, 2);       //2進位轉10進位
                    }
                    catch
                    {
                        // Convert.ToString(int value, 2);         / 10進位轉2進位
                        data[offset + 2] = Convert.ToByte(d.Text);
                        d.Text = Convert.ToString(data[offset + 2], 2);
                    }
           //      d.Text= d.Text.PadLeft(8, '0');
            }
        }
        public void SetType(ref byte[] data, int offset)
        {
            try
            {
                putType(ref data, boxType1, boxID1, boxData1, offset);
                putType(ref data, boxType2, boxID2, boxData2, offset + 3);
                putType(ref data, boxType3, boxID3, boxData3, offset + 6);
                putType(ref data, boxType4, boxID4, boxData4, offset + 9);
                putType(ref data, boxType5, boxID5, boxData5, offset + 12);
                putType(ref data, boxType6, boxID6, boxData6, offset + 15);
                putType(ref data, boxType7, boxID7, boxData7, offset + 18);
                putType(ref data, boxType8, boxID8, boxData8, offset + 21);
                int x = Convert.ToInt32(cbobaud.Text);
                data[offset + 24] = (byte)(x % 0x100);
                data[offset + 25] = (byte)(x / 0x100);
            }
            catch
            {
                MessageBox.Show("欄位請勿空白");
            }
        }

        public void putSCHG(ref byte[] data, int offset,TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6,TextBox t7)
        {
            byte[][] f = new byte[6][];
            try
            {
                f[0] = BitConverter.GetBytes(Convert.ToSingle(t1.Text));
                f[1] = BitConverter.GetBytes(Convert.ToSingle(t2.Text));
                f[2] = BitConverter.GetBytes(Convert.ToSingle(t3.Text));
                f[3] = BitConverter.GetBytes(Convert.ToSingle(t4.Text));
                f[4] = BitConverter.GetBytes(Convert.ToSingle(t5.Text));
                f[5] = BitConverter.GetBytes(Convert.ToSingle(t6.Text));
                for (i = 0; i < 6; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        data[offset + i * 4 + j] = f[i][j];
                    }
                }
                data[offset + 24] = Convert.ToByte(t7.Text);
            }
            catch { MessageBox.Show("請輸入數據"); }
        }

        public void SetSCHG(ref byte[] data, int offset)
        {
            putSCHG(ref data ,offset,txtBPch1, txtLch1,  txtRch1, txtCch1, txtDch1, txtXch1 ,txtMch1);
            putSCHG(ref data, offset+25, txtBPch2, txtLch2,  txtRch2, txtCch2, txtDch2, txtXch2, txtMch2);
            putSCHG(ref data, offset+50, txtBPch3, txtLch3,  txtRch3, txtCch3, txtDch3, txtXch3, txtMch3);
            putSCHG(ref data, offset+75, txtBPch4, txtLch4,  txtRch4, txtCch4, txtDch4, txtXch4, txtMch4);
            putSCHG(ref data, offset+100, txtBPch5, txtLch5,  txtRch5, txtCch5, txtDch5, txtXch5, txtMch5);
            putSCHG(ref data, offset+125, txtBPch6, txtLch6,  txtRch6, txtCch6, txtDch6, txtXch6, txtMch6);
            putSCHG(ref data, offset+150, txtBPch7, txtLch7,  txtRch7, txtCch7, txtDch7, txtXch7, txtMch7);
            putSCHG(ref data, offset+175, txtBPch8, txtLch8,  txtRch8, txtCch8, txtDch8, txtXch8, txtMch8);
            putSCHG(ref data, offset+200, txtBPch9, txtLch9,  txtRch9, txtCch9, txtDch9, txtXch9, txtMch9);
            putSCHG(ref data, offset+225, txtBPch10,txtLch10, txtRch10,txtCch10,txtDch10,txtXch10, txtMch10);
            putSCHG(ref data, offset+250, txtBPch11,txtLch11, txtRch11,txtCch11,txtDch11,txtXch11, txtMch11);
            putSCHG(ref data, offset+275, txtBPch12, txtLch12,txtRch12,txtCch12,txtDch12,txtXch12,txtMch12);
            data[offset + 300] = (byte)(boxRain.SelectedIndex);
        }
    //********************** GET ****************************************
    public void GetIE_Alarm(ref byte[] data, int offset)    //讀取IE 和 Alarm 時間
        {
            boxHour.Text = System.Text.Encoding.ASCII.GetString(data, offset, 2);
            boxMin.Text = System.Text.Encoding.ASCII.GetString(data, offset+2, 2);
            boxSec.Text = System.Text.Encoding.ASCII.GetString(data, offset+4, 2);
            chkHour.Checked = false;
            chkMin.Checked = false;
            chkSec.Checked = false;
            if ((data[offset + 6] & 0x1) != 0)
                chkHour.Checked = true;
            if ((data[offset + 6] & 0x2) != 0)
                chkMin.Checked = true;
            if ((data[offset + 6] & 0x4) != 0)
                chkSec.Checked = true;
            chkIE.Checked = false;
            chkAF.Checked = false;
            if ((data[offset+7] & 0x1) != 0)
                chkIE.Checked = true;
            if ((data[offset + 7] & 0x2) != 0)
                chkAF.Checked = true;
        }
        public void GetReTime(ref byte[] data, int offset)
        {
            boxCycleHour.Text = System.Text.Encoding.ASCII.GetString(data, offset, 2);
            boxCycleMin.Text = System.Text.Encoding.ASCII.GetString(data, offset + 2, 2);
            boxCycleSec.Text = System.Text.Encoding.ASCII.GetString(data, offset + 4, 2);
        }

        public void GetBand(ref byte[] data, int offset)
        {
            boxM18.Checked = boxNB7.Checked = boxNB9.Checked = false;
            if ((data[offset] & 0x4) != 0)
                boxM18.Checked = true;
            if ((data[offset+1] & 0x1) != 0)
                boxNB7.Checked = true;
            if ((data[offset+1] & 0x2) != 0)
                boxNB9.Checked = true;
        }
        //********************** Read  *********************************************
        void GetUartCMD(string cmd)
        {
          //  byte sum = 0;
            int size = 0;
            byte[] code;


           // byte[] RXReg = new byte[ReadCnt];
         //   RXReg = System.Text.Encoding.Default.GetBytes(cmd);


            if (marco.CRC(ref RXReg, ReadCnt - 2))  //去掉 \r\n 
            {
     
                str1 = cmd.Replace("\0", "") ;
                rchRx.Text += str1 ;
                //  rchRxHex.Text += BitConverter.ToString(RXReg, 0, ReadCnt).Replace("-"," ") + "\r\n";        去除中間的 - 
                rchRxHex.Text += BitConverter.ToString(RXReg, 0, ReadCnt) + "\r\n";
                if (cmd.IndexOf("RLT") != -1 || cmd.IndexOf("RRD") != -1)
                {
                    if(cmd.IndexOf("RLT")!=-1   )
                         size = cmd.IndexOf("RLT");  //傳回接到相同字串的開始位置 (R 的位置)，所以讀取資料要往後3個位置
                    else
                        size = cmd.IndexOf("RRD");  //傳回接到相同字串的開始位置 (R 的位置)，所以讀取資料要往後3個位置
                    txtRtcTime.Text = marco.GetDSTime(RXReg, size + 3, 6);       //讀取時間 6*2 
                }
                if (cmd.IndexOf("RRD") != -1)
                {
                    GetIE_Alarm(ref RXReg, size+15);     //+3+12(yy mm dd  HH MM SS)     //讀取Alram,ie設定,AF
               //     GetReTime(ref RXReg, size+23);      //+3+12+14(yy mm dd NC HH MM SS)  (hms)
                }
                if(cmd.IndexOf("SID")!=-1)
                {
                    txtnowID.Text=System.Text.Encoding.ASCII.GetString(RXReg, 1, 2).Trim();
                }

                if (cmd.IndexOf("RBA") != -1)      //讀取band 狀態
                {
                    size = cmd.IndexOf("RBA");
                    GetBand(ref RXReg, size + 3);
                }
                else if (cmd.IndexOf("RRC") != -1)      //讀取紀錄筆數  // time read set
                {
                    size = cmd.IndexOf("RRC");
                    txtRecNum.Text = (RXReg[size + 6] << 24 | RXReg[size + 5] << 16 | RXReg[size + 4] << 8 | RXReg[size + 3]).ToString();
                    txtSendNum.Text = ((int)RXReg[size + 10] << 24 | (int)RXReg[size + 9] << 16 | (int)RXReg[size + 8] << 8 | RXReg[size + 7]).ToString();

                    txtSendNum2.Text = ((int)RXReg[size + 14] << 24 | (int)RXReg[size + 13] << 16 | (int)RXReg[size + 12] << 8 | RXReg[size + 11]).ToString();

                    //  txtRecNum.Text = (RXReg[size + 3] << 24 | RXReg[size + 4] << 16 | RXReg[size + 5] << 8 | RXReg[size + 6]).ToString() ;
                    //  txtSendNum.Text = ((int)RXReg[size + 7] << 24 | (int)RXReg[size + 8] << 16 | (int)RXReg[size + 9] << 8 | RXReg[size + 10]).ToString();           
                }
                else if (cmd.IndexOf("RCD") != -1)   //讀取站碼相關資料 
                {
                    size = cmd.IndexOf("RCD");
                    code = new byte[ReadCnt - (size + 7)];       //扣掉 (3) 字串長度 + (4) crc[2],0d,0a 
                    txtStation.Text = System.Text.Encoding.ASCII.GetString(RXReg, size + 3, 8).Trim();       //HEX 轉成 ASCII 的字串
                    size += 11;                      //3+ 8(station)
                    GetReTime(ref RXReg, size);
                    size += 6;
                    chkRec.Checked = false;
                    chkCrycle.Checked = false;
                    if (RXReg[size] == 0x31)
                        chkRec.Checked = true;
                    if (RXReg[size + 1] == 0x31)
                        chkCrycle.Checked = true;
                }
                else if ((size = cmd.IndexOf("RME")) != -1)   //讀取IMEI
                {
                    size += 5;  // , "
                    code = new byte[ReadCnt - (size + 6)];       //扣掉 (2)", + (4) crc[2],0d,0a 
                    txtIMEI.Text = System.Text.Encoding.ASCII.GetString(RXReg, size, 15).Trim();
                }
                else if ((size = cmd.IndexOf("RDB")) != -1)   //讀取訊號強度
                {
                    size += 3;
                    int[] v = new int[3];
                    txtconnect.Text = "eMTC";
                    if ((RXReg[size] & 0x1) != 0)
                        txtconnect.Text = "NBIoT";
                    txtRSSI.Text = ((int)BitConverter.ToUInt16(RXReg, size + 1) - 32767).ToString();
                    txtRSRP.Text = ((int)BitConverter.ToUInt16(RXReg, size + 3) - 32767).ToString();
                    txtSNR.Text = ((int)BitConverter.ToUInt16(RXReg, size + 5) - 32767).ToString();

                }
             
                else if (cmd.IndexOf("RSA") != -1)   //單讀取站碼       
                {
                    size = cmd.IndexOf("RSA");
                    code = new byte[ReadCnt - (size + 7)];       //扣掉 (3) 字串長度 + (4) crc[2],0d,0a 
                    txtStation.Text = System.Text.Encoding.ASCII.GetString(RXReg, size + 3, 8).Trim();
                }

                else if (cmd.IndexOf("RAP") != -1)   //讀取apn
                {
                    size = cmd.IndexOf("P,\"");
                    code = new byte[ReadCnt - (size + 4 + 5)]; // 5 = ",crc[2]\r\n (多了 " , 的長度)
                    txtapn.Text = System.Text.Encoding.ASCII.GetString(RXReg, size + 3, code.Length).Trim();       //HEX 轉成 ASCII 的字串
                    if (cmd.IndexOf("internet.iot") != -1)
                        btnCHT.Focus();
                    else if (cmd.IndexOf("twm.nbiot") != -1)
                        btnTW.Focus();
                    else if (cmd.IndexOf("nbiot") != -1)
                        btnFET.Focus();
                }
                else if ((size = cmd.IndexOf("RNB")) != -1)   //讀取 ip + port
                {
                    // size = cmd.IndexOf("RNB");
                    size += 3;          //資料的長度                                     
                    chkNB1.Checked = false;
                    if ((RXReg[size] & 0x1) != 0)
                        chkNB1.Checked = true;
                    size++;
                    txtIP.Text = "";
                    for (i = size; i < size + 4; i++)
                    {
                        txtIP.Text += Convert.ToString(RXReg[i], 10);  //HEX 轉成10進制數值再轉換為字串
                        if (i != size + 3)
                            txtIP.Text += '.';
                    }
                    txtPORT.Text = (RXReg[i + 1] * 256 + RXReg[i]).ToString();
                    size += 6;
                    size++; //跳過count
                    chkNB2.Checked = false;
                    if ((RXReg[size] & 0x1) != 0)
                        chkNB2.Checked = true;
                    size++;
                    txtIP2.Text = "";
                    for (i = size; i < size + 4; i++)
                    {
                        txtIP2.Text += Convert.ToString(RXReg[i], 10);  //HEX 轉成10進制數值再轉換為字串
                        if (i != size + 3)
                            txtIP2.Text += '.';
                    }
                    txtPORT2.Text = (RXReg[i + 1] * 256 + RXReg[i]).ToString();
                    //跳過count

                }
                else if (cmd.IndexOf("RBT") != -1)   //讀取 電池電壓
                {
                    size = cmd.IndexOf("RBT") + 3; //資料的長度                  
                    float f = BitConverter.ToSingle(RXReg, size);
                    txtBatV.Text = f.ToString("F2");    // ("#00.00");// Convert.ToString(f,2f);
                }
                else if ((size = cmd.IndexOf("GAD")) != -1)     //讀取即時資料
                {
                    byte b;
                    size += 3;// cmd.IndexOf("GAD") + 3;
                    b = RXReg[size];
                    size += 1;
                    txtCH1.Text = BitConverter.ToSingle(RXReg, size).ToString();// marco.Long2Str(RXReg , size );
                    txtCH2.Text = BitConverter.ToSingle(RXReg, size + 4).ToString();// marco.Long2Str(RXReg , size );
                    txtCH3.Text = BitConverter.ToSingle(RXReg, size + 8).ToString();// marco.Long2Str(RXReg , size );
                    txtCH4.Text = BitConverter.ToSingle(RXReg, size + 12).ToString();// marco.Long2Str(RXReg , size );
                    txtCH5.Text = BitConverter.ToSingle(RXReg, size + 16).ToString();// marco.Long2Str(RXReg , size );
                    txtCH6.Text = BitConverter.ToSingle(RXReg, size + 20).ToString();// marco.Long2Str(RXReg , size );
                    txtCH7.Text = BitConverter.ToSingle(RXReg, size + 24).ToString();// marco.Long2Str(RXReg , size );
                    txtCH8.Text = BitConverter.ToSingle(RXReg, size + 28).ToString();// marco.Long2Str(RXReg , size );
                    size += 32;
                    /*      if (b == 'R')// (RXReg[size-1]=='R')        //RAW data=long int
                          {
                              txtCH9.Text = BitConverter.ToInt32(RXReg, size).ToString();// marco.Long2Str(RXReg , size );
                              txtCH10.Text = BitConverter.ToInt32(RXReg, size + 4).ToString();// marco.Long2Str(RXReg , size +4);
                              txtCH11.Text = BitConverter.ToInt32(RXReg, size + 8).ToString();// marco.Long2Str(RXReg , size +8);
                              txtCH12.Text = BitConverter.ToInt32(RXReg, size + 12).ToString();// marco.Long2Str(RXReg , size +12);
                          }
                          else
                          {*/
                    txtCH9.Text = BitConverter.ToSingle(RXReg, size).ToString("F3");
                    txtCH10.Text = BitConverter.ToSingle(RXReg, size + 4).ToString("F3");
                    txtCH11.Text = BitConverter.ToSingle(RXReg, size + 8).ToString("F3");
                    txtCH12.Text = BitConverter.ToSingle(RXReg, size + 12).ToString("F3");
                    //    }
                    size += 16;
                    txtRain.Text = BitConverter.ToSingle(RXReg, size).ToString("F3");
                    txtDoor.Text = System.Text.Encoding.ASCII.GetString(RXReg, size + 4, 1);
                    //  btnReadAI.Enabled = true;

                }
          
                else if ((size = cmd.IndexOf("RST")) != -1)     //讀取Type
                {
                    size += 3;
                    GetType(RXReg, boxType1, boxID1, boxData1, size);
                    GetType(RXReg, boxType2, boxID2, boxData2, size + 3);
                    GetType(RXReg, boxType3, boxID3, boxData3, size + 6);
                    GetType(RXReg, boxType4, boxID4, boxData4, size + 9);
                    GetType(RXReg, boxType5, boxID5, boxData5, size + 12);
                    GetType(RXReg, boxType6, boxID6, boxData6, size + 15);
                    GetType(RXReg, boxType7, boxID7, boxData7, size + 18);
                    GetType(RXReg, boxType8, boxID8, boxData8, size + 21);
                    cbobaud.Text = Convert.ToString(marco.byte2int(RXReg, size + 24));
                }
                else if ((size = cmd.IndexOf("CVR")) != -1)         //讀取版本
                {
                    txtver.Text = System.Text.Encoding.ASCII.GetString(RXReg, size + 4, 2).Trim();  //跳過命令(3)及,(1)
                }
                else if ((size = cmd.IndexOf("RUR")) != -1)         //讀取狀態
                {
                    size += 3;
                    txtms.Text = Convert.ToString(marco.byte2int(RXReg, size));
                    if ((RXReg[size + 2] & 0x1) != 0)
                        chkBG.Checked = true;
                    if ((RXReg[size + 2] & 0x2) != 0)
                        chkAD.Checked = true;
                    if ((RXReg[size + 2] & 0x4) != 0)
                        chkProbe.Checked = true;
                    if ((RXReg[size + 2] & 0x8) != 0)
                        chkRain.Checked = true;
                    if ((RXReg[size + 2] & 0x10) != 0)
                        chkBAT.Checked = true;
                    txtBounce.Text = Convert.ToString(marco.byte2int(RXReg, size+3));
                }
                else if ((size = cmd.IndexOf("RCHG")) != -1)    //讀取系數
                {
         
                    size += 4;
                   if (size != 5)
                        j = 0;   
                    GetSCHG(RXReg, size, txtBPch1, txtLch1, txtRch1, txtCch1, txtDch1, txtXch1 ,txtMch1);
                    GetSCHG(RXReg, size + 25, txtBPch2, txtLch2, txtRch2, txtCch2, txtDch2, txtXch2, txtMch2);
                    GetSCHG(RXReg, size + 50, txtBPch3, txtLch3, txtRch3, txtCch3, txtDch3, txtXch3, txtMch3);
                    GetSCHG(RXReg, size + 75, txtBPch4, txtLch4, txtRch4, txtCch4, txtDch4, txtXch4, txtMch4);
                    GetSCHG(RXReg, size + 100, txtBPch5, txtLch5, txtRch5, txtCch5, txtDch5, txtXch5, txtMch5);
                    GetSCHG(RXReg, size + 125, txtBPch6, txtLch6, txtRch6, txtCch6, txtDch6, txtXch6, txtMch6);
                    GetSCHG(RXReg, size + 150, txtBPch7, txtLch7, txtRch7, txtCch7, txtDch7, txtXch7, txtMch7);
                    GetSCHG(RXReg, size + 175, txtBPch8, txtLch8, txtRch8, txtCch8, txtDch8, txtXch8, txtMch8);
                    GetSCHG(RXReg, size + 200, txtBPch9, txtLch9, txtRch9, txtCch9, txtDch9, txtXch9, txtMch9);
                    GetSCHG(RXReg, size + 225, txtBPch10, txtLch10, txtRch10, txtCch10, txtDch10, txtXch10, txtMch10);
                    GetSCHG(RXReg, size + 250, txtBPch11, txtLch11, txtRch11, txtCch11, txtDch11, txtXch11, txtMch11);
                    GetSCHG(RXReg, size + 275, txtBPch12, txtLch12, txtRch12, txtCch12, txtDch12, txtXch12, txtMch12);
                    boxRain.SelectedIndex = RXReg[size + 300];
                    boxRain.Text = boxRain.SelectedItem.ToString();
                }
                else if (cmd.IndexOf("RAI") != -1)     //讀取AI 資料(連讀使用)
                {
                    float f;
                    size = cmd.IndexOf("RAI") + 4;
                    f = BitConverter.ToSingle(RXReg, size + 1);
                    if (RXReg[size] == 0x31)
                        txtCH9.Text = f.ToString("F3");    // ("#00.00");// Convert.ToString(f,2f);
                    else if (RXReg[size] == 0x32)
                        txtCH10.Text = f.ToString("F3");    // ("#00.00");// Convert.ToString(f,2f);
                    else if (RXReg[size] == 0x33)
                        txtCH11.Text = f.ToString("F3");    // ("#00.00");// Convert.ToString(f,2f);
                    else if (RXReg[size] == 0x34)
                        txtCH12.Text = f.ToString("F3");    // ("#00.00");// Convert.ToString(f,2f);
                }
            }
        }
        public void GetSCHG(byte[] data, int offset, TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6, TextBox t7)
        {
            byte[][] f = new byte[6][];
            t1.Text = BitConverter.ToSingle(data, offset).ToString("F4");
            t2.Text = BitConverter.ToSingle(data, offset+4).ToString("F4");
            t3.Text = BitConverter.ToSingle(data, offset+8).ToString("F4");
            t4.Text = BitConverter.ToSingle(data, offset+12).ToString("F4");
            t5.Text = BitConverter.ToSingle(data, offset+16).ToString("F4");
            t6.Text = BitConverter.ToSingle(data, offset+20).ToString("F4");
            t7.Text = data[offset + 24].ToString();
        }
        public void GetType(byte[] data, ComboBox type, TextBox id, TextBox d,int offset)
        {
        
            if (data[offset] == 0)
                type.SelectedIndex = 0;
            else
            {
                type.SelectedIndex = data[offset] ;
                type.Text = type.SelectedItem.ToString(); ;
            }
            id.Text = Convert.ToString(RXReg[offset+1], 10);
            d.Text = Convert.ToString(RXReg[offset+2], 2);
        }
        //********************** Write ****************************************
        string S_SYS_Time = "$01TIM";           //同步系統時間
        string R_RTC_Time = "$01RLT";           //讀取RTC時間
        string S_RTC_WeakupTime = "$01TIW";     //寫入喚醒時間  time weak
        string S_RTC_CycleTime = "$01TIR";      //寫入間隔時間
        string R_RTC_DATE = "$01RRD";            //讀取RTC設定  // time read set
        string S_RTC_ClrAF = "$01TAF";          //清除AF
        string S_RTC_SetAE = "$01TIE";          //設定AE 
        string S_SUR    = "$01SUR";          //設定Uart顯示資訊 
        string S_RUR = "$01RUR";            //讀取Uart顯示資訊 
        string S_TST = "$TST";             //測試硬體       

        private void btnTest_Click(object sender, EventArgs e)
        {
            chknormal.Checked = true;
            chkASCII.Checked = true;
            rchRxHex.Visible = true;
            rchRx.Visible = false;


            byte test=0;
          if (chkEEP.Checked == true)
                test |= 1;    
            if (chkFLASH.Checked == true)
                test |= 2;
            if (chkSD.Checked == true)
                test |= 4;
            SetTitle(ref TXReg, S_TST);
            TXReg[S_TST.Length] = test;
            SendEnd(ref TXReg, S_TST.Length+1);
        }
        private void btnSymTime_Click(object sender, EventArgs e)
        {
            SetTitle(ref TXReg, S_SYS_Time);  //同步系統時間
            SetTime(ref TXReg, S_SYS_Time.Length);
            SendEnd(ref TXReg, S_SYS_Time.Length+12);    //6=時間的byte 數 ，yy mm dd H M S
        }

        private void btnReadRTC_Click(object sender, EventArgs e)
        {
            SetTitle(ref TXReg, R_RTC_Time);  //讀取RTC時間
            SendEnd(ref TXReg, R_RTC_Time.Length);
        }

        private void btnIntTime_Click(object sender, EventArgs e) //寫入喚醒時間
        {
            SetTitle(ref TXReg, S_RTC_WeakupTime);
            SetA1arm(ref TXReg, S_RTC_WeakupTime.Length);   //h,m,s,status
            SendEnd(ref TXReg, S_RTC_WeakupTime.Length+7);
        }
         private void btnCycleTime_Click(object sender, EventArgs e) //寫入間隔時間
        {
            SetTitle(ref TXReg, S_RTC_CycleTime);
            SetReTime(ref TXReg, S_RTC_CycleTime.Length);   //h,m,s
            i = S_RTC_CycleTime.Length + 6;
            TXReg[i] = (byte)'0';
            if (chkRec.Checked)
                TXReg[i] = (byte)'1';
            TXReg[i + 1] = (byte)'0';
            if (chkCrycle.Checked)
                TXReg[i + 1] = (byte)'1';
            SendEnd(ref TXReg, S_RTC_CycleTime.Length + 8);
        }    
        private void btnRead_Click(object sender, EventArgs e)  //讀取全部設定
        {
            txtRtcTime.Text = "";
            boxHour.Text = boxMin.Text = boxSec.Text = "00";
            //  boxCycleHour.Text = boxCycleMin.Text = boxCycleSec.Text = "00";
            chkHour.Checked = chkMin.Checked = chkSec.Checked = chkAF.Checked = chkIE.Checked = false;
            SetTitle(ref TXReg, R_RTC_DATE);
            SendEnd(ref TXReg, R_RTC_DATE.Length);
        }
        private void btnAF_Click(object sender, EventArgs e)    //清除AF
        {
            SetTitle(ref TXReg, S_RTC_ClrAF);
            SendEnd(ref TXReg, S_RTC_ClrAF.Length);
        }
     
        private void btnIE_Click(object sender, EventArgs e)    //設置中斷
        {
            SetTitle(ref TXReg, S_RTC_SetAE);
            TXReg[S_RTC_SetAE.Length] = 0;             
            if(chkIE.Checked)
                TXReg[S_RTC_SetAE.Length] = 0x1;
            SendEnd(ref TXReg, S_RTC_SetAE.Length+1);
        }

        private void btnUart_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == "btnUart")
            {        
                Byte x = 0;    
                SetTitle(ref TXReg, S_SUR);
                marco.int2byte(txtms.Text, ref TXReg, S_SUR.Length);
                if (chkBG.Checked)
                    x |= 0x1;
                if (chkAD.Checked)
                    x |= 0x2;
                if (chkProbe.Checked)
                    x |= 0x4;
                if (chkRain.Checked)
                    x |= 0x8;
                if (chkBAT.Checked)
                    x |= 0x10;
                TXReg[S_SUR.Length+2] = x;
                marco.int2byte(txtBounce.Text, ref TXReg, S_SUR.Length + 3);
                SendEnd(ref TXReg, S_SUR.Length + 5);
            }
            else
            {
                txtms.Text = txtBounce.Text="";
                chkBG.Checked=chkAD.Checked = chkProbe.Checked=false;
                chkRain.Checked = chkBAT.Checked = false;
                SetTitle(ref TXReg, S_RUR);
                SendEnd(ref TXReg, S_RUR.Length);

            }
        }
        private void btnAllSet_Click(object sender, EventArgs e)
        {
            txtRtcTime.Text =  txtver.Text= txtRecNum.Text=txtSendNum.Text= txtSendNum2.Text="";
            boxHour.Text = boxMin.Text = boxSec.Text = "00";
            chkHour.Checked = chkMin.Checked = chkSec.Checked = chkAF.Checked = chkIE.Checked = false;
            txtStation.Text = boxCycleHour.Text = boxCycleMin.Text = boxCycleSec.Text = "";
            chkRec.Checked = chkCrycle.Checked = false;


            SetTitle(ref TXReg, R_RTC_DATE);
            SendEnd(ref TXReg, R_RTC_DATE.Length);

            APCnt = 0;
            page_f = false;
            timer3.Enabled = true;
        }
        //********************** APN  *********************************************
        /*   NN: 0x01   catm1.  0x10 nb1 700
             NN: 0x02	catm2.  0x20 nb2 900
             NN: 0x04	catm3.  0x40 nb3 1800
        */
        string S_ReadRec = "$01RRC";    //讀取紀錄/傳送筆數
        string S_Band = "$01SBA";        //設定 band 
        string S_ReadBand = "$01RBA";   //讀取band 狀態
        string S_Basic= "$01SCD";     //傳送基本參數   (站碼，間隔時間)
        string S_ReadBasic = "$01RCD";     //設定基本參數 (站碼，間隔時間) 
        string S_APN = "$01SAP,\"";        //傳送apn
        string S_ReadAPN = "$01RAP";    //讀取apn
        string S_IpPort = "$01SNB";      //寫入port
        string S_ReadIpPort = "$01RNB"; //讀取 port
        string S_Station = "$01SSA";      //寫入站碼
        string S_ReadStation = "$01RSA"; //讀取站碼
        string S_SID="$SID";           //設定id
    //    string S_RID = "$RID";          //讀取id
        string S_SST = "$SST";           //設定Type
        string S_RST = "$RST";          //讀取Type

        string S_SCHG = "$SCHG";           //設定通道參數
        string S_RCHG = "$RCHG";          //讀取通道參數
        string S_RME = "$RME";           //讀取IMEI
        string S_RDB = "$RDB";          //讀取訊號強度
                                        //    string S_VER = "$VER";          //讀取版本
        string S_CVR = "$CVR";          //讀取程式版本
        string S_REC_Clr = "$01CLR";    //清除記錄和傳送筆數
      
        private void btnRec_Click(object sender, EventArgs e)   //讀取紀錄/傳送筆數
        {
            SetTitle(ref TXReg, S_ReadRec);
            SendEnd(ref TXReg, S_ReadRec.Length);  
        }

 
        private void btnReadID_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定清除", "清除提示", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                SetTitle(ref TXReg, S_REC_Clr);
                SendEnd(ref TXReg, S_REC_Clr.Length);
                txtSendNum.Text = "0";
                txtSendNum2.Text = "0";
                txtRecNum.Text = "0";

            }
        }


        private void btnBand_Click(object sender, EventArgs e)  //傳送 Band  //讀取band
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnBand")
            {
                SetTitle(ref TXReg, S_Band);
                TXReg[S_Band.Length] = 0x30;
                TXReg[S_Band.Length+1] = 0x30;
                if (boxM18.Checked)
                    TXReg[S_Band.Length] += 4;        //m1.1800
                if (boxNB7.Checked)
                    TXReg[S_Band.Length+1] += 1;       //nb.700
                if (boxNB9.Checked)
                    TXReg[S_Band.Length+1] += 2;       //nb.900


                SendEnd(ref TXReg, S_Band.Length + 2);
            }
            else
            {
                boxM18.Checked = boxNB7.Checked = boxNB9.Checked = false;
                SetTitle(ref TXReg, S_ReadBand);
                SendEnd(ref TXReg, S_ReadBand.Length );
            }
        }

        //放置傳送的資料，回傳資料長度
        public int PutSendData(string str,int len_s)        
        {

            byte[] station = System.Text.Encoding.ASCII.GetBytes(str);

            for (i = len_s; i < len_s + station.Length; i++)
            {
                TXReg[i] = station[i - len_s];
            }
            return i;   // len_s + station.Length;
        }


        private void btnSetBasic_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnSetBasic")
            {

                if (txtStation.Text != "" && txtStation.Text.Length == 8)
                {
                    SetTitle(ref TXReg, S_Basic);
                    PutSendData(txtStation.Text, S_Basic.Length);
                    SetReTime(ref TXReg, S_Basic.Length+8);   //h,m,s
                    i = S_Basic.Length + 14;
                    TXReg[i]= (byte)'0';
                    if (chkRec.Checked)
                        TXReg[i] = (byte)'1';
                    TXReg[i+1]= (byte)'0';
                    if (chkCrycle.Checked)
                        TXReg[i + 1] = (byte)'1';
                    SendEnd(ref TXReg, i+2);    
                }
            }
            else
            {
                txtStation.Text = boxCycleHour.Text = boxCycleMin.Text = boxCycleSec.Text = "";
                chkRec.Checked = chkCrycle.Checked = false;
                SetTitle(ref TXReg, S_ReadBasic);
                SendEnd(ref TXReg, S_ReadBasic.Length);
            }
        }
        private void btnStation_Click(object sender, EventArgs e)       //傳送站碼 
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnStation")
            {
                 if (txtStation.Text != "" && txtStation.Text.Length == 8)
                 {
                     SetTitle(ref TXReg, S_Station);
                     SendEnd(ref TXReg, PutSendData(txtStation.Text, S_Station.Length));
                 }
            }
            else
            {
                SetTitle(ref TXReg, S_ReadStation);
                SendEnd(ref TXReg, S_ReadStation.Length );
            }
        }
        private void btnNet_Click(object sender, EventArgs e)           //傳送apn
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnApn")
            {
                    SetTitle(ref TXReg, S_APN);
                    SendEnd(ref TXReg, PutSendData(txtapn.Text + "\",", S_APN.Length));
            }
            else
            {
                txtapn.Text = "";
                SetTitle(ref TXReg, S_ReadAPN);
                SendEnd(ref TXReg, S_ReadAPN.Length );
            }
        }

        private void btnNet_Click_1(object sender, EventArgs e)      //傳送ip
        {
            Button btn = (Button)sender;
            str1 = "";
            if (btn.Name == "btnIP")
            {
                try
                {
                    str1 = txtIP.Text;
                    string[] ss = str1.Split('.');

                    SetTitle(ref TXReg, S_IpPort);

                    TXReg[S_IpPort.Length] = 0x30;
                    if (chkNB1.Checked)                 
                        TXReg[S_IpPort.Length] = 0x31;
                   
                    for (i = S_IpPort.Length+1; i < S_IpPort.Length + 5; i++)
                        TXReg[i] = Convert.ToByte(ss[i - (S_IpPort.Length+1)]);
                    marco.int2byte(txtPORT.Text, ref TXReg, i);

                    TXReg[S_IpPort.Length + 7] = 0x1;   /* todo  未如入nb 的啟動時間 */
                    str1 = txtIP2.Text;
                    ss = str1.Split('.');

                    TXReg[S_IpPort.Length+8] = 0x30;
                    if (chkNB2.Checked)
                        TXReg[S_IpPort.Length+8] = 0x31;

                    for (i = S_IpPort.Length + 9; i < S_IpPort.Length + 13; i++)
                        TXReg[i] = Convert.ToByte(ss[i - (S_IpPort.Length + 9)]);
                    marco.int2byte(txtPORT2.Text, ref TXReg, i);
                    TXReg[S_IpPort.Length + 15] = 0x1;   /* todo  未如入nb 的啟動時間 */
                    SendEnd(ref TXReg, S_IpPort.Length + 16);
                }
                catch
                {
                    MessageBox.Show("請輸入數值", "ERROR",MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                txtIP.Text = txtPORT.Text = txtIP2.Text = txtPORT2.Text = "";
                chkNB1.Checked = chkNB2.Checked = false;
                SetTitle(ref TXReg, S_ReadIpPort);
                SendEnd(ref TXReg, S_ReadIpPort.Length );
            }
        }
        public static void ClrTXT(TextBox t1, TextBox t2, TextBox t3, TextBox t4, TextBox t5, TextBox t6,TextBox t7)
        {
            t1.Text = t2.Text = t3.Text = t4.Text = t5.Text = t6.Text = t7.Text="";
        }
        private void btnSCHG_Click(object sender, EventArgs e)  //設定/讀取 通道參數
        {
            Button b = (Button)sender;
            if (b.Name == "btnSCHG")
            {
                SetTitle(ref TXReg, S_SCHG);
                SetSCHG(ref TXReg, S_SCHG.Length);
                SendEnd(ref TXReg, S_SCHG.Length + 301);        //289  0804
            }
            else
            {
                ClrTXT(txtBPch1,  txtLch1,  txtRch1, txtCch1,  txtDch1, txtXch1, txtMch1);
                ClrTXT(txtBPch2,  txtLch2,  txtRch2, txtCch2,  txtDch2, txtXch2, txtMch2);
                ClrTXT(txtBPch3,  txtLch3,  txtRch3, txtCch3,  txtDch3, txtXch3, txtMch3);
                ClrTXT(txtBPch4,  txtLch4,  txtRch4, txtCch4,  txtDch4, txtXch4, txtMch4);
                ClrTXT(txtBPch5,  txtLch5,  txtRch5, txtCch5,  txtDch5, txtXch5, txtMch5);
                ClrTXT(txtBPch6,  txtLch6,  txtRch6, txtCch6,  txtDch6, txtXch6, txtMch6);
                ClrTXT(txtBPch7,  txtLch7,  txtRch7, txtCch7,  txtDch7, txtXch7, txtMch7);
                ClrTXT(txtBPch8,  txtLch8,  txtRch8, txtCch8,  txtDch8, txtXch8, txtMch8);
                ClrTXT(txtBPch9,  txtLch9,  txtRch9, txtCch9,  txtDch9, txtXch9, txtMch9);
                ClrTXT(txtBPch10, txtLch10, txtRch10,txtCch10, txtDch10,txtXch10, txtMch10);
                ClrTXT(txtBPch11, txtLch11, txtRch11,txtCch11, txtDch11,txtXch11, txtMch11);
                ClrTXT(txtBPch12, txtLch12, txtRch12, txtCch12, txtDch12, txtXch12, txtMch12);
                boxRain.Text = "";
                SetTitle(ref TXReg, S_RCHG);
                SendEnd(ref TXReg, S_RCHG.Length);
            }
        }


        public void PutID(string str)
        {
            byte[] byteArray = System.Text.Encoding.Default.GetBytes(str);
            for (i = 0; i < 2; i++)
                TXReg[S_SID.Length + i] = byteArray[i];
            SendEnd(ref TXReg, S_SID.Length + 2);
        }
        private void btnSetID_Click(object sender, EventArgs e)     //設置ID
        {

        }


        private void btnSetType_Click(object sender, EventArgs e)   //設定/讀取 TYPE
        {
            Button b = (Button)sender;
            if(b.Name== "btnSetType")
            {
                SetTitle(ref TXReg, S_SST);
                SetType(ref TXReg, S_SST.Length);   
                SendEnd(ref TXReg, S_SST.Length+26);

            }
            else
            {
                /*
                cbobaud.Text ="";
                boxType1.Text = boxType2.Text = boxType3.Text = boxType4.Text = "";
                boxType5.Text = boxType6.Text = boxType7.Text = boxType8.Text = "";
                boxID1.Text = boxID2.Text = boxID3.Text = boxID4.Text = "";
                boxID5.Text = boxID6.Text = boxID7.Text = boxID8.Text = "";
                boxData1.Text = boxData2.Text = boxData3.Text = boxData4.Text = "";
                boxData5.Text = boxData6.Text = boxData7.Text = boxData8.Text = "";*/
                SetTitle(ref TXReg, S_RST);
                SendEnd(ref TXReg, S_RST.Length);
            }
        }


        private void btnIMEI_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (b.Name == "btnIMEI")
            { 
                SetTitle(ref TXReg, S_RME);
                SendEnd(ref TXReg, S_RME.Length);         
            }
            else
            {
                SetTitle(ref TXReg, S_RDB);
                SendEnd(ref TXReg, S_RDB.Length);              
            }
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            SetTitle(ref TXReg, S_CVR);
            SendEnd(ref TXReg, S_CVR.Length);        
        }
        private void timer3_Tick(object sender, EventArgs e)
        {
            APCnt++;        
            if(APCnt == 1)
            {
                if (page_f)
                {
                    SetTitle(ref TXReg, S_ReadAPN);
                    SendEnd(ref TXReg, S_ReadAPN.Length);
                }
                else
                {            
              
                    SetTitle(ref TXReg, S_ReadBasic);
                    SendEnd(ref TXReg, S_ReadBasic.Length);
                }
            }
            else if(APCnt==2)
            {
                if (page_f)
                {
                    SetTitle(ref TXReg, S_ReadIpPort);
                    SendEnd(ref TXReg, S_ReadIpPort.Length);
                }
                else
                {
                    SetTitle(ref TXReg, S_CVR);
                    SendEnd(ref TXReg, S_CVR.Length);  
                }        
            }
            else if (APCnt == 3)
            {
                if (page_f)
                {
                    SetTitle(ref TXReg, S_RME);
                    SendEnd(ref TXReg, S_RME.Length);
                }
                else
                {
                     SetTitle(ref TXReg, S_ReadRec);
                    SendEnd(ref TXReg, S_ReadRec.Length);
                    timer3.Enabled = false;
                }
            }
            else if (APCnt == 4)
            {
                if(page_f)
                {
                    SetTitle(ref TXReg, S_RDB);
                    SendEnd(ref TXReg, S_RDB.Length);
                    timer3.Enabled = false;
                }
          /*      else
                {
               
                }
                timer3.Enabled = false;*/
            }
        }
        private void btnReadNet_Click(object sender, EventArgs e)
        {
            boxM18.Checked = boxNB7.Checked = boxNB9.Checked = chkNB1.Checked = chkNB2.Checked = false;
            txtIP.Text = txtPORT.Text = txtIP2.Text = txtPORT2.Text = txtapn.Text = "";  //= txtStation.Text 
            txtIMEI.Text = txtconnect.Text = txtRSSI.Text = txtRSRP.Text = txtSNR.Text = "";
            SetTitle(ref TXReg, S_ReadBand);
                 SendEnd(ref TXReg, S_ReadBand.Length);
            APCnt=0;
            timer3.Interval = 400;
            timer3.Enabled=true;
            page_f = true;
        }

        //********************** AD  *********************************************
        string C_BAT = "$01CBT";           //校正電池電壓 $AACBTCCCC      FF(CR)(LF)
        string R_BAT = "$01RBT";           //讀取電池電壓 $AARBT          FF(CR)(LF)
        string C_CAI = "$01CAI";           //校正 AI      $AACAICCCCNN    FF(CR)(LF)
        string R_AIV = "$01RAI";           //讀取 AI      $AARAINN        FF(CR)(LF)
        string R_GAD = "$01GAD";           //讀取AD即時資料  $AAGADN      FF(CR)(LF)

        private void btnCalBat_Click(object sender, EventArgs e)    //校正.讀取電池電壓
        {
            Button b = (Button)sender;
            if (b.Name == "btnCalBat")
            {
                SetTitle(ref TXReg, C_BAT);
                byte[] f = BitConverter.GetBytes(Convert.ToSingle(txtCalBatV.Text));
                for (i = 0; i < 4; i++)
                    TXReg[C_BAT.Length + i] = f[i];
                SendEnd(ref TXReg, C_BAT.Length + 4);
            }
            else
            {
                SetTitle(ref TXReg, R_BAT);
                SendEnd(ref TXReg, R_BAT.Length);
            }
        }

        private void btnCalAI_Click(object sender, EventArgs e)     //Correction Voltage  (calibration)
        {
            byte b=0x31;
            SetTitle(ref TXReg, C_CAI);
            if(radAI2.Checked)
                b = 0x32;        //CH2
            else if(radAI3.Checked)
                b = 0x33;        //CH3
            else if(radAI4.Checked)
                b = 0x34;        //CH4
            TXReg[C_CAI.Length] = b;        //CH2
            byte[] f = BitConverter.GetBytes(Convert.ToSingle(txtCalAIV.Text));   // (字串 -> [浮點數 -> byte])
            for (i = 0; i < 4; i++)
                TXReg[C_CAI.Length + i+1] = f[i];
            SendEnd(ref TXReg, C_CAI.Length + 5);
        }


    
        public void ReadGAD()
        {
            SetTitle(ref TXReg, R_GAD);
            TXReg[R_GAD.Length] = (byte)'C';            //計算後的值
            if (radRaw.Checked)
                TXReg[R_GAD.Length] = (byte)'R';        //RAW AD
            SendEnd(ref TXReg, R_GAD.Length + 1);
        }
        private void btnReadAI_Click(object sender, EventArgs e)    //Read AI Voltage
        {
           
            Button btn = (Button)sender;
            txtCH9.Text = txtCH1.Text = txtCH7.Text = "";
            txtCH10.Text = txtCH2.Text = txtCH8.Text = "";
            txtCH11.Text = txtCH3.Text = "";
            txtCH12.Text = txtCH4.Text = "";
            txtRain.Text = txtCH5.Text = "";
            txtDoor.Text = txtCH6.Text = "";
            if (btn.Name == "btnReadAI")
                ReadGAD();
         //   btn.Enabled = false;
        
        }
        //********************** 清除畫面  *********************************************
        private void button1_Click(object sender, EventArgs e)
        {
            txtRtcTime.Text = "";
            boxHour.Text = boxMin.Text = boxSec.Text = "00";
          //  boxCycleHour.Text = boxCycleMin.Text = boxCycleSec.Text = "00";
            chkHour.Checked = chkMin.Checked = chkSec.Checked = chkAF.Checked = chkIE.Checked = false;
        }

        private void chkMin_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
            if (box.Name == "chkHour")
            {
                if (box.Checked)
                {
                    chkMin.Checked = box.Checked;
                    chkSec.Checked = box.Checked;
                }
            }
            else if (box.Name == "chkMin")
            {
                if (box.Checked)
                    chkSec.Checked = box.Checked;
                else
                    chkHour.Checked = box.Checked;
            }
            else if(box.Name=="chkSec")
            {
                if(!box.Checked)
                {
                    chkMin.Checked = box.Checked;
                    chkHour.Checked = box.Checked;
                }
            }
        }

        private void btnCHT_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (btn.Name == "btnCHT")
                txtapn.Text = "internet.iot";
            else if (btn.Name == "btnTW")
                txtapn.Text = "twm.nbiot";
            else
                txtapn.Text= "nbiot";
        }


        //********************** Calculator CRC & Send Data *********************************************
        byte[] byteOut;
        private void btnSend_Click(object sender, EventArgs e)
        {
           byteOut = new byte[2];
            marco.HexStrToHexByte(boxSendHex.Text, ref byteOut);
            SerialCOM.Write(byteOut, 0, byteOut.Length);

            rchTxHex.Text += BitConverter.ToString(byteOut, 0, byteOut.Length) + "\r\n";
            rchTx.Text += System.Text.Encoding.ASCII.GetString(byteOut);     //HEX陣列轉 ASCII 字串
        }
        private void boxStr_TextChanged_1(object sender, EventArgs e)
        {
           byteOut = System.Text.Encoding.ASCII.GetBytes(boxStr.Text);      //將字串轉成byte
            boxHEX.Text = (BitConverter.ToString(byteOut, 0, byteOut.Length)).Replace("-", " "); //將byte 轉成十六進制字串，並移除-號
            boxHexCalc.Text = boxHEX.Text;
            if (readid_f)
            {
                btnCRC_Click_1(btnCRC, e);

            }

        }

     

        private void btnCRC_Click_1(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            int sum = 0, i;
            byteOut = new byte[2];     //此陣列大小會在回傳值時，被取代掉

            if (b.Name == "btnCRC")
            {
                marco.HexStrToHexByte(boxHexCalc.Text, ref byteOut);
                for (i = 0; i < byteOut.Length; i++)
                    sum += Convert.ToInt32(byteOut[i]);
                sum = sum % 0x100;
                boxCrc.Text = Convert.ToString(sum, 16).ToUpper();
                byteOut = System.Text.Encoding.Default.GetBytes(boxCrc.Text);    
            }
            else
            {
                marco.HexStrToHexByte(boxHexCalc.Text+"0000", ref byteOut); //"0000" 加上二個crc 的位置 
                marco.CRC_16(ref byteOut, byteOut.Length);
                boxCRC16.Text = (Convert.ToString(byteOut[0],16)+ Convert.ToString(byteOut[1], 16)).ToUpper();
                boxCRC16.Text = boxCRC16.Text.PadLeft(4, '0');      //不足位數補0   (四位)
            }
            str1 = BitConverter.ToString(byteOut);      // 將字串數值轉成十六進制顯示
            str1 = str1.Replace("-", " ");  
            boxSendHex.Text = boxHexCalc.Text + " " + str1 + " 0D 0A";

            if (readid_f)
            {
                readid_f = false;
                btnSend_Click(sender, e);
            }
        }
        //********************** Serial Port *********************************************
        private void CloseCOMPort()
        {
            Serialcom.SetCOM(SerialCOM, btnPort);      //關閉COM PORT
            boxBaurd.Enabled = true;
            boxCom.Enabled = true;
            timeRx.Enabled = false;         //接收時間中斷 關閉
            tabFunc.Enabled = false;
            btnRec.Enabled = false;
            btnSend.Enabled = false;
         //   ReadT_f = false;

        }

        private void chkTxHex_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox box = (CheckBox)sender;
   

            if(box.Name== "chkTxHex")
            {
                if (box.Checked == true)
                {
                    rchTxHex.Visible = true;
                    rchTx.Visible = false;                
                }
                else
                {
                    rchTxHex.Visible = false;
                    chkASCII.Visible = false;
                }
            }
            else
            {
                if (box.Checked == true)
                {           
                        rchRxHex.Visible = true;
                        rchRx.Visible = false;
                        chkASCII.Visible = false;
                        if(chknormal.Checked)                  
                          chkASCII.Visible = true;
                }
                else
                {
                    if (!chkRxHex.Checked && !chknormal.Checked)
                    {
                        rchRx.Visible = true;
                        rchRxHex.Visible = false;
                        if (!chknormal.Checked)
                            chkASCII.Visible = false;
                    }     
                }
            }
        }

        private void btnSn_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.Show();



          /*  f2.ShowDialog();
            if(f2.DialogResult==DialogResult.OK)
            {
                chkTxHex.Visible = true;
                chkRxHex.Visible = true;
                btnSn.Enabled = false;
           
               

            }*/
          //  f2.Dispose();
          //  f2.Close();

            
        }

        private void radCalc_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rad = (RadioButton)sender;
            btnReadAI.Text = "讀取" + rad.Text;
        }

        private void btnClrbasic_Click(object sender, EventArgs e)
        {
            txtStation.Text = boxCycleHour.Text = boxCycleMin.Text = boxCycleSec.Text = "";
            chkRec.Checked = chkCrycle.Checked = false;
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rchTxHex_TextChanged(object sender, EventArgs e)
        {
            RichTextBox r = (RichTextBox)sender;
            r.SelectionStart = r.Text.Length;
            r.ScrollToCaret();
        }

        private void btnReadStr_Click(object sender, EventArgs e)
        {
           
            Button btn = (Button)sender;
            if (btn.Name == "btnReadStr")
                boxStr.Text = "$01LADR00000010000001";
            else if (btn.Name == "btnSIDstr")
            {
                str1 ="$01SID00";
                readid_f = true;
                if(txtnowID.Text == "" && txtSetID.Text=="")
                    readid_f = false;
                if (txtnowID.Text!="")
                    str1 = str1.Replace("01", txtnowID.Text.PadLeft(2, '0'));          
                if(txtSetID.Text!="")
                    str1 = str1.Replace("00", txtSetID.Text.PadLeft(2, '0'));
                if (str1 == boxStr.Text)
                    boxStr_TextChanged_1(sender, e);
                else
                    boxStr.Text = str1;
            }
            else
            {
                 readid_f = true;
                if (boxStr.Text == "$00SID01")
                    boxStr_TextChanged_1(sender, e);
                else
                    boxStr.Text = "$00SID01";       
            }
        }

        private void boxType1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox t = (ComboBox)sender;
            if(t.Text=="")
            {
                if(t.Name== "boxType1")
                    boxID1.Text = "0";
                else if (t.Name == "boxType2")
                    boxID2.Text = "0";
                else if (t.Name == "boxType3")
                    boxID3.Text = "0";
                else if (t.Name == "boxType4")
                    boxID4.Text = "0";
                else if (t.Name == "boxType5")
                    boxID5.Text = "0";
                else if (t.Name == "boxType6")
                    boxID6.Text = "0";
                else if (t.Name == "boxType7")
                    boxID7.Text = "0";
                else 
                    boxID8.Text = "0";
            }
        }



        /*
       private void chkComSend_CheckedChanged(object sender, EventArgs e)
       {
           if (chkComSend.Checked == true)
               brpCrc.Visible = true;
           else
               brpCrc.Visible = false;
       }
*/
        private void label23_Click(object sender, EventArgs e)
        {
            if(VerNote_f==false)
            {
                VerNote_f = true;
                txtVerNote.Visible = true;
            }
            else
            {
                VerNote_f = false;
                txtVerNote.Visible = false;
            }
        }




        private void timAD_Tick(object sender, EventArgs e)
        {
            byte b;
            SetTitle(ref TXReg, R_AIV);
            TXReg[R_AIV.Length] = (byte)'C';            //計算後的值
            if (radRaw.Checked)
                TXReg[R_AIV.Length] = (byte)'R';        //RAW AD
            if (Count == 0)
                b = 0x31;
            else if (Count == 1)
                b = 0x32;    //CH2
            else if (Count == 2)
                b = 0x33;    //CH3
            else
                b = 0x34;    //CH4
            TXReg[R_AIV.Length+1] = b;        //CH4
            SendEnd(ref TXReg, R_AIV.Length + 2);
            Count++;
            if (Count > 3)
                Count = 0;
        }

   
        private void btnContinue_Click(object sender, EventArgs e)
        {
            if(AIContinue_f)
            {
                timAD.Enabled=false;
                btnContinue.BackColor = Color.Transparent;
              
            }
            else
            {
                txtCH9.Text = txtCH10.Text = txtCH11.Text = txtCH12.Text = "";
                Count = 0;
                timAD.Enabled = true;
                btnContinue.BackColor = Color.GreenYellow;
            }
            AIContinue_f = !AIContinue_f;       
        }

        //*******************************************************************
        private void btnPort_Click(object sender, EventArgs e)
        {
            if (SerialCOM.IsOpen)
            {
                CloseCOMPort();
            }
            else
            {
                try
                {
                    btnRec.Enabled = true;
                    btnSend.Enabled = true;
                    SerialCOM.BaudRate = Convert.ToInt32(boxBaurd.Text);
                    boxBaurd.Enabled = false;
                    boxCom.Enabled = false;
                    timeRx.Enabled = true;         //接收時間中斷 關閉        
                    Serialcom.SetCOM(SerialCOM, btnPort, boxCom);     //打開COM PORT// comport , 要修改的btn文字，要填入的com port 位置 
                    tabFunc.Enabled = true;                                                     //   SerialCOM.BaudRate = baudData[boxBPS.SelectedIndex];
                 //   ReadT_f = true;
                }
                catch (Exception)
                {
                    MessageBox.Show("連線已斷開", "COM Port Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally     // 一定會執行
                {
                }
            }       
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            if (GetStar_f)
            {
                checktriggle(false);    //關閉box 輸入觸發
                str1 = null;

                if (chkASCII.Checked == true && chknormal.Checked == true && ByteCnt != 0)
                {
                    rchRxHex.Text += System.Text.Encoding.ASCII.GetString(RXReg, 0, ByteCnt);
                    ByteCnt = 0;
                }
                else
                {


                    if (CmdStart_f && ReadCnt != 0)
                        ReadCnt = 0;




                    for (int i = 0; i < ByteCnt; i++)
                    {

                        if ((RXReg[i] == '!' || CmdStart_f == true) && (chknormal.Checked == false))      //起始位置
                        {
                            if (RXReg[i] == '!' && CmdStart_f == false)
                            {
                                ReadCnt = 0;
                                cmdstr = "";
                                timer2.Enabled = true;      //打開time2中斷，時間內若未完成，則取消此次接收
                            }
                            CmdStart_f = true;
                            ReadCnt++;

                            cmdstr += Convert.ToString((char)RXReg[i]);     //讀取接收的指令
                            if (cmdstr.EndsWith("\r\n"))
                            {
                                //       cmdstr = System.Text.Encoding.ASCII.GetString(RXReg).Trim();


                                cmdstr = System.Text.Encoding.ASCII.GetString(RXReg, 0, ReadCnt);


                                CmdStart_f = false;
                                GetCmd_f = true;
                                timer2.Enabled = false;
                                ByteCnt = 0;
                            }
                        }
                        else
                        {
                            str1 += Convert.ToString((char)RXReg[i]);
                            CmdStart_f = false;
                        }
                    }

                    if (GetCmd_f == true)                     //若是收到指令
                    {
                        GetCmd_f = false;
                        //
                        //
                        //      RXReg= System.Text.Encoding.Default.GetBytes(cmdstr);
                        GetUartCMD(cmdstr);
                        cmdstr = null;

                    }
                    else if (str1 != null)  //GetCmd_f == false && 
                    {
                        //    boxRXHex.Items.Add(BitConverter.ToString(RXReg, 0, ByteCnt));       //edit
                        //   boxRXHex.SelectedIndex = boxRXHex.Items.Count - 1;
                        //     boxRX.Items.Add(str1);
                        //    boxRX.SelectedIndex = boxRX.Items.Count - 1;

                        string[] str = str1.Split('\n');
                        for (i = 0; i < str.Length; i++)
                        {
                            if (str[i].EndsWith("\r") != true)
                            {
                                str[i] += "\n";
                            }
                            rchRx.Text += str[i];
                        }

                        int len = 0;        //為了讓接收到0d 0a的字串時換行符號可以實現 ，故判斷是否抓到0a ，若是則加上 "\r\n" 的換行符號。
                        str1 = "";

                        for (i = 0; i < ByteCnt; i++)
                        {
                            if (RXReg[i] == 0xd)
                            {
                                chk0d_f = true;
                                continue;
                            }
                            if (chk0d_f && RXReg[i] == 0xa)
                            {
                                str1 += BitConverter.ToString(RXReg, len, (i - len) + 1) + "\r\n";  //抓取長度為暫存器位置+1
                                len = i + 1;        //此次抓取的長度，為下次判斷的起始位
                            }
                            chk0d_f = false;
                        }
                        if (len != ByteCnt)
                            str1 += BitConverter.ToString(RXReg, len, ByteCnt - len);

                        rchRxHex.Text += str1.Replace("-", " "); ;
                        ByteCnt = 0;
                        //  rchRxHex.Text += BitConverter.ToString(RXReg, 0, ByteCnt) + "\r\n"; 此方式不會自動換行
                    }
                }
             checktriggle(true);
         }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            CmdStart_f = false;
            GetCmd_f = false;
            timer2.Enabled = false;
            ByteCnt = 0;
        }
        private void timer1s_Tick(object sender, EventArgs e)
        {
            txtSysTime.Text = DateTime.Now.ToString();
        }



        private void btnSearch_Click_1(object sender, EventArgs e)  //重抓com port
        {
            Serialcom.GetPort(boxCom);
        }

        private void timeRx_Tick(object sender, EventArgs e)
        {
            int i;
            COM1_Datareceived();        //接資料
            if (ReadFlag == true)       //若有讀取資料
            {
                for (i = 0; i < Receive_Num; i++)
                {
                    GetStar_f = true;
                    RXReg[ByteCnt] = ReadData[i];                   //將暫存器資料放入接收暫存器
                    ByteCnt++;                                      //此次中斷接收的資料長度
                }
                timer1.Enabled = true;
            }
            ReadFlag = false;
        }
        private void COM1_Datareceived()     //Read COM Port Data
        {
            try
            {
                Receive_Num = SerialCOM.BytesToRead;                //datalength = COM1.BytesToRead;  //讀取接收的長度   
                if (Receive_Num > 0)
                {
                    SerialCOM.Read(ReadData, 0, Receive_Num);       //ReadData 將資料從暫存器搬出                                              
                    ReadFlag = true; //  Receive_Num = DataLength;
                }
            }
            catch (Exception)
            {
                SerialCOM.Dispose();
                CloseCOMPort();
                MessageBox.Show("Port is Connected!");
            }
        }
        //====================================================================
        private void btnClrTX_Click(object sender, EventArgs e)
        {
            rchTx.Text = "";
            rchRx.Text = "";
            rchTxHex.Text = "";
            rchRxHex.Text = "";
        }

    

    }
}
