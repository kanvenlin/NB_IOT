
namespace NB_iot
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReadDir = new System.Windows.Forms.Button();
            this.btnopen = new System.Windows.Forms.Button();
            this.btnclose = new System.Windows.Forms.Button();
            this.fBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btndelet = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnReadDir
            // 
            this.btnReadDir.Location = new System.Drawing.Point(724, 400);
            this.btnReadDir.Name = "btnReadDir";
            this.btnReadDir.Size = new System.Drawing.Size(75, 23);
            this.btnReadDir.TabIndex = 3;
            this.btnReadDir.Text = "讀取";
            this.btnReadDir.UseVisualStyleBackColor = true;
            this.btnReadDir.UseWaitCursor = true;
            // 
            // btnopen
            // 
            this.btnopen.Location = new System.Drawing.Point(712, 467);
            this.btnopen.Name = "btnopen";
            this.btnopen.Size = new System.Drawing.Size(75, 23);
            this.btnopen.TabIndex = 3;
            this.btnopen.Text = "檔案管理員";
            this.btnopen.UseVisualStyleBackColor = true;
            this.btnopen.UseWaitCursor = true;
            // 
            // btnclose
            // 
            this.btnclose.Location = new System.Drawing.Point(116, 486);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "關閉 ";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.UseWaitCursor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btndelet
            // 
            this.btndelet.Location = new System.Drawing.Point(515, 504);
            this.btndelet.Name = "btndelet";
            this.btndelet.Size = new System.Drawing.Size(75, 23);
            this.btndelet.TabIndex = 3;
            this.btndelet.Text = "刪除資料夾";
            this.btndelet.UseVisualStyleBackColor = true;
            this.btndelet.UseWaitCursor = true;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 683);
            this.Controls.Add(this.btnopen);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btndelet);
            this.Controls.Add(this.btnReadDir);
            this.Name = "Form2";
            this.Text = "Form2";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReadDir;
        private System.Windows.Forms.Button btnopen;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.FolderBrowserDialog fBrowser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btndelet;
    }
}