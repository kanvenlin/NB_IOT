using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;
using System.Windows.Forms;
//  boxTX.Items.Add ( marco.ToHexString(data, 0, offset + 3));       //將陣列轉成 hex 字串
//  boxTX.Items.Add(BitConverter.ToString(data,0,offset+3));         //將陣列轉成 hex 字串 (字串中間會加入 '-'符號)
//data = data.Where(x => x != 0x00).ToArray();                    //移除陣列裡面的 0x00 
//str1 = System.Text.Encoding.ASCII.GetString(data).Trim();       //陣列 轉成 ASCII 的字串
/*
 string類型轉成byte[]：
byte[] byteArray = System.Text.Encoding.Default.GetBytes ( str );
反過來，byte[]轉成string：
string str = System.Text.Encoding.Default.GetString ( byteArray );
string類型轉成ASCII byte[]：（”01″ 轉成 byte[] = new byte[]{ 0x30, 0x31}）
byte[] byteArray = System.Text.Encoding.ASCII.GetBytes ( str );
ASCII byte[] 轉成string：（byte[] = new byte[]{ 0x30, 0x31} 轉成 “01”）
string str = System.Text.Encoding.ASCII.GetString ( byteArray );


txtIP.Text =  Convert.ToString( RXReg[i],10);  //Byte 轉成10進制數值再轉換為字串
txtIP.Text =  Convert.ToString( RXReg[i],16);  //Byte 轉成16進制數值再轉換為字串
Convert.ToString(int value, 2);         /10進位轉2進位
Convert.ToInt32(string value, 2);       //2進位轉10進位
Convert.ToString(int value, 16);        //10進位轉16進位
Convert.ToInt32(string value, 16)       //16進位轉10進位
        /*  字串相關使用
         *  str1.IndexOf(string);
            str1.IndexOf(String, int);
         *  str1.LastIndexOf(string);
         *  boxRX.Text=str1.Replace(string,string);
         *  CompareTo() ;  Equals();  EndWith()
         *  StartWith();Insert , Remove,Substring,String.Concat
         *  ToLower();ToUpper();Trim(),TrimEnd(),TrimStart();
         *
byte[] bytes = BitConverter.GetBytes(201805978);        //數值轉成Byte陣列
Console.WriteLine("byte array: " + BitConverter.ToString(bytes));
// Output: byte array: 9A-50-07-0C       
byte[] bytes = { 0, 0, 0, 25 };             //byte 陣列轉成數字
if (BitConverter.IsLittleEndian)            //假如高位位置順序對調，可使用這個指令
    Array.Reverse(bytes);
int i = BitConverter.ToInt32(bytes, 0);
Console.WriteLine("int: {0}", i);
// Output: int: 25
*/



namespace GonDo_Modbus
{
    class marco
    {
        public static bool CRC_16(ref byte[] CRC_Data, int Num)    //ref
        {
            ushort crc16 = 0xffff;
            bool last_bit = true;
            for (int i = 0; i < Num-2; i++)
            {
                crc16 ^= CRC_Data[i];
                for (int j = 0; j < 8; j++)
                {
                    last_bit = Convert.ToBoolean(crc16 & 1);
                    crc16 /= 2;
                    if (last_bit) crc16 ^= 0xa001;
                }
            }
            last_bit = (crc16 == CRC_Data[Num-1] * 256 + CRC_Data[Num-2]);  //陣列位置和數值差1
            CRC_Data = new byte[2];
            CRC_Data[0] = Convert.ToByte(crc16 % 256);
            CRC_Data[1] = Convert.ToByte(crc16 / 256);
            return last_bit;
        }
        public static bool CRC(ref byte[] CRC_Data, int Num)    //ref
        {
            byte sum = 0;
            byte[] crc = new byte[2];
            string str="";
            int i;
            bool last_bit = true;
            for (i = 0; i < Num - 2; i++)
                sum += CRC_Data[i];

            str = Convert.ToString(sum, 16).ToUpper();
            if (str.Length == 1)
                str=str.Insert(0, "0");
            crc = System.Text.Encoding.Default.GetBytes(str);

            if ((crc[0] != CRC_Data[Num-2]) || (crc[1] != CRC_Data[Num - 1]))
                last_bit = false;
             CRC_Data[Num-2] = crc[0];
             CRC_Data[Num - 1] = crc[1];
            return last_bit;
        }

    



        public static string 檢查小數點(string chkstr)
        {
            string x = chkstr.Substring(0, 1);
            if(x == "-")
            {
                if (chkstr.Substring(1, 1) == ".")
                    chkstr=chkstr.Insert(1, "0");
            }
            else  if(x==".")
                chkstr=chkstr.Insert(0, "0");
            return chkstr;
        }


        public static   byte int2BCD(int t)     // 整數轉 BCD
        {
            return Convert.ToByte((t / 10) * 16 + (t % 10));
        }

        public static void Str2Byte(string str,ref byte[] d,int ofs)
        {
            byte[] b = new byte[2];
            try
            {
                if (str.Length == 1)
                    str = str.Insert(0, "0");
                b = System.Text.Encoding.ASCII.GetBytes(str);

                d[ofs] = b[0];
                d[ofs + 1] = b[1];
            }
            catch
            {
                MessageBox.Show("請輸入數值");
            }
        }

        public static byte[] Time2ASCII(DateTime d)
        {
            string s = d.ToString("yyMMddHHmmss");  // ("ssmmHHMMddMMyy");//MMddHHmmss");
            byte[] x = System.Text.Encoding.ASCII.GetBytes(s);
            return x;
        }

     
        public  static byte[] ToBCD(DateTime d) // DateTime轉 BCD
        {
    
            List<byte> bytes = new List<byte>();
            string s = d.ToString("yyMMddHHmmss");  // ("ssmmHHMMddMMyy");//MMddHHmmss");
            for (int i = 0; i < s.Length; i += 2)
            {
              
                bytes.Add((byte)((s[i] - '0') << 4 | (s[i + 1] - '0')));
            }
            return bytes.ToArray();
        }
        //陣列轉換
        //  boxTX.Items.Add(BitConverter.ToString(data,0,offset+3));      //將陣列轉成 hex 字串 (字串中間會加入 '-'符號) <--可直接使用此指令
        //// 0xae00cf => "0A-0E-00-00-0C-0F "
        public static string ToHexString(byte[] bytes, int s, int e) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
            if (bytes != null)
            {
                StringBuilder strB = new StringBuilder();
                for (int i = s; i < s + e; i++)
                {
                    strB.Append(bytes[i].ToString("X2"));
                }
                hexString = strB.ToString();
            }
            return hexString;
        }
        //1 byte 轉換
        //傳送若為BCD碼，則直接轉換
       
        public static string ToHexString(byte bytes) // 0xae00cf => "AE00CF "
        {
            string hexString = string.Empty;
        //    if (bytes != null)
         //   {
                StringBuilder strB = new StringBuilder();
            strB.Append(bytes.ToString("X2"));           
                hexString = strB.ToString();
          //  }txtErr
            return hexString;
        }

        public static   string GetDSTime(byte[] time,int start,int len)   //抓取的時間轉成 畫面顯示格式
        {   //time :  01 yy 23 mm 45 dd 67 hh 89 mm 01 ss
            string timestr = "20", pmstr = " 上午 ";
            int timei;
            

            timei = (time[start + 6] - '0') * 10 + (time[start + 7] - '0');
            if (timei > 12)
            {
                pmstr = " 下午 ";
                time[start + 6] -= 1;
                time[start + 7] -= 2;
            }

            for (int i = 0; i < len; i++)
            {
                timestr += System.Text.Encoding.ASCII.GetString(time, start+i*2, 2);     //將陣列轉成 hex 字串
                if (i < 2 )
                    timestr += "/";
                else if (i == 2 )
                    timestr += pmstr;
                else if (i < 5)
                    timestr += ":";
            }
            return timestr;
        }


        public static string Long2Str(byte[] b,int ofs)
        {
            Int32 value = 0;
            string str = "";
            value = b[ofs + 3] << 24 | b[ofs + 2] << 16 | b[ofs + 1] << 8 | b[ofs];
            str = value.ToString();
            return str;
        }



        //hex 字串轉成 hex Byte[]
        public static void HexStrToHexByte(string str,ref byte[] byteOUT)//陣列轉字串
        {

            int i;
            str = str.Replace(" ", "");     //消除空白
            try
            {
                if (str.Length % 2 != 0)        //若傳送hex 檔時，字元不足，則顯示訊息
                    MessageBox.Show("Error Length of Byte, Input odd Byte");
                else
                {
                    byteOUT = new byte[str.Length / 2];
                    for (i = 0; i < str.Length; i = i + 2)
                    {
                        byteOUT[i / 2] = Convert.ToByte(str.Substring(i, 2), 16); //每2位16進位數字轉換為一個16進位整數
                    }
                }
            }
            catch
            {
                MessageBox.Show("請檢查字串長度是否正確");
            }
        }
        /*
         * 2byte陣列轉 int
         * 
         * */

        public static int byte2int(byte[] array,int offset)
        {
           return array[offset+1] << 8 | array[offset];
        }
        /*
        * 字串整2 Byte 陣列
        * 
        * */
        public static void int2byte(string str, ref byte[]array , int offset)
        {
            short  x = Convert.ToInt16(str);
       //     byte[] b =BitConverter.GetBytes(x);
            array[offset] = (byte)(x % 256);
            array[offset + 1] = (byte)(x / 256);

        }

            // BYTE陣列轉16進為字串

            public static bool ByteArray2String(byte[] pdata, ref String StrData, bool blnReverse = true)//陣列轉字串
        {
            StrData = "";
            bool blnResult = true;

            if (blnReverse == true)
            {
                Array.Reverse(pdata);
            }

            try
            {
                for (int i = 0; i < pdata.Length; i++)
                {
                    StrData += Convert.ToString(pdata[i], 16).PadLeft(2, '0') + " ";
                }
            }
            catch
            {
                blnResult = false;
            }
            return blnResult;
        }

        //   marco.檢查小數點(str1);
        // 
        /*  public static void 判斷位數(System.Windows.Forms.TextBox txt)
             {
                 txt.Text = Regex.Replace(txt.Text, " ", "");
                 if (txt.Text == "")
                     txt.Text = "00";
                 else if (txt.Text.Length == 1)
                     txt.Text = "0" + txt.Text;

             }*/
    }
}
