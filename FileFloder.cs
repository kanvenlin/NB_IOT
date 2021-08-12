using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NB_iot
{
    class FileFloder
    {
        private string str { get; set; }
        private string[] Arraystr { get; set; }
        DirectoryInfo dir;
        public FileInfo file;
        DirectoryInfo[] Arraydir { get; set; }
        FileInfo[] Arrayfile { get; set; }
        private string PATH;
        public string path
        {
            get { return PATH; }
            set { 
                PATH = checkpath(value); 
            }
        }

        /********************************************************
         *檢查檔案未尾是否有 \ 符號，若沒有則加上此符號
         *******************************************************/
        public string checkpath(string str)
        {
            if (str != null)
            {
                if (str.Substring(str.Length - 1) != "\\")
                    str += '\\';
            }
            return str;
        }
        /********************************************************
         *建構子 ，檔案位置
        *******************************************************/
        public FileFloder()
        {
            PATH = checkpath(Directory.GetCurrentDirectory());    
        }
        /********************************************************
        *讀取目前的檔案位置
        *******************************************************/
        public string currentdir()
        {
            str= checkpath(Directory.GetCurrentDirectory());
            return str;
        }
        /********************************************************
         *讀取目前位置的資料夾內容
         *******************************************************/
        public void GetFloderName(ref ListBox list)
        {
            try
            {
                dir = new DirectoryInfo(PATH);
                Arraydir = dir.GetDirectories();
                foreach (DirectoryInfo d in Arraydir)
                {
                    list.Items.Add(d.Name);
                }
            }
            catch
            {
                MessageBox.Show("資料夾不存在");
            }
        }
        /********************************************************
         *讀取目前位置的檔案內容
         *******************************************************/
        public void GetFileName(ref ListBox list)
        {
            try
            {
                list.Items.Clear();
                dir = new DirectoryInfo(PATH);
                Arrayfile = dir.GetFiles();       
                foreach (FileInfo d in Arrayfile)
                {
                    list.Items.Add(d.Name);
                }
            }
            catch { }
        }
        /********************************************************
        *  刪除資料夾
         *******************************************************/
        public void DeletFloder(ref ListBox list)
        {
            try
            {
                Directory.Delete(PATH);     
                GetFloderName(ref list);
            }
            catch { }
        }

        /********************************************************
         *  建立資料夾 
         *******************************************************/
        public void CreatFloder()
        {
        
            if((Directory.Exists(PATH)==false) && PATH!=null)
               Directory.CreateDirectory(PATH);
        }
        /**************************************************
         *  顯示檔案的相關資料
         *******************************************************/
        public string GetFileMsg(string strpath)
        {
            file = new FileInfo(strpath);
            str = "";
        //   str  = file.Name + "\r\n";          //檔案名稱+副檔名               ;新文字文件.txt
            str += file.FullName + "\r\n";      //目錄:\資料夾+檔案名稱+副檔名  ;D:\新增資料夾\新文字文件.txt
        //    str += file.DirectoryName + "\r\n"; //目錄:\資料夾名稱              ;D:\新增資料夾 
        //    str += file.Directory.Name + "\r\n";//資料夾名稱                    ;新增資料夾
        //    str += file.CreationTime + "\r\n";  //檔案建立時間                  ;2021 / 7 / 23 下午 04:59:21
        //    str += file.Extension + "\r\n";     //副檔名                        ;.txt
             return str;


        }

    }
}
