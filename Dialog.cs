using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NB_iot
{
    class Dialog
    {
        private OpenFileDialog file { get; set; }
        private FolderBrowserDialog floder { get; set; }
        private ColorDialog c { get; set; }
        private string str { get; set; }


        /**********  讀取檔案位置    **********
         * 回傳選取的檔案位置
         ****************************************/
        public string OpenFile()
        {
            file = new OpenFileDialog()
            {
                FileName = "select file ",
                Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*",
                Title = "Open text file",
                FilterIndex = 2,
                RestoreDirectory = true,
            };
            if (file.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    str = file.FileName;
              //      Process.Start("notepad.exe", theFile);  開啟小畫家處理 txt 檔
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Security error.\n\nError message: {ex.Message}\n\n" +
                      $"Details:\n\n{ex.StackTrace}");
                }
            }
            return str;
        }
        /**********  讀取資料夾位置    *********
         * 回傳選取的資料夾位置
         ****************************************/
        public string OpenFloder()
        {
            floder = new FolderBrowserDialog();
            if (floder.ShowDialog() == DialogResult.OK)
            {
                str = floder.SelectedPath;
            }
            return str;
        }
       
        
        public void  OpenColor()
        {
            c= new ColorDialog();
            if(c.ShowDialog()==DialogResult.OK)
            {
                var cc = c.Color.Name;
            }
        }
        
        /**********  執行Windows執行檔    **********/
        public void Action()
        {
            str = "devmgmt.msc";            //裝置管理員
            System.Diagnostics.Process.Start(str);
        }
       







    }
}
