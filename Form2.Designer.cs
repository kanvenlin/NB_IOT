
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
            this.components = new System.ComponentModel.Container();
            this.btnclose = new System.Windows.Forms.Button();
            this.fBrowser = new System.Windows.Forms.FolderBrowserDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnCalcData = new System.Windows.Forms.Button();
            this.txtSec = new System.Windows.Forms.TextBox();
            this.txtDate = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.txtCode = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Num = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Station = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ch12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.R1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Door = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sim = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rssi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rsrp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Snr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnConvert = new System.Windows.Forms.Button();
            this.btnclr = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radPro = new System.Windows.Forms.RadioButton();
            this.radMini = new System.Windows.Forms.RadioButton();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnclose
            // 
            this.btnclose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclose.Location = new System.Drawing.Point(43, 12);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(75, 23);
            this.btnclose.TabIndex = 3;
            this.btnclose.Text = "關閉 ";
            this.btnclose.UseVisualStyleBackColor = true;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnCalcData
            // 
            this.btnCalcData.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalcData.Location = new System.Drawing.Point(275, 89);
            this.btnCalcData.Name = "btnCalcData";
            this.btnCalcData.Size = new System.Drawing.Size(75, 73);
            this.btnCalcData.TabIndex = 4;
            this.btnCalcData.Text = "計算日期";
            this.btnCalcData.UseVisualStyleBackColor = true;
            this.btnCalcData.Click += new System.EventHandler(this.btnCalcData_Click);
            // 
            // txtSec
            // 
            this.txtSec.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSec.Location = new System.Drawing.Point(43, 89);
            this.txtSec.MaxLength = 10;
            this.txtSec.Name = "txtSec";
            this.txtSec.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSec.Size = new System.Drawing.Size(213, 25);
            this.txtSec.TabIndex = 5;
            this.txtSec.Tag = "";
            this.txtSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtSec, "輸入秒數");
            // 
            // txtDate
            // 
            this.txtDate.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDate.Location = new System.Drawing.Point(43, 137);
            this.txtDate.Name = "txtDate";
            this.txtDate.ReadOnly = true;
            this.txtDate.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtDate.Size = new System.Drawing.Size(213, 25);
            this.txtDate.TabIndex = 5;
            this.txtDate.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.toolTip1.SetToolTip(this.txtDate, "顯示日期");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(40, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "日期";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(40, 60);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(262, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "請輸入自 1980/01/01 00:00:00 以來的秒數";
            // 
            // toolTip1
            // 
            this.toolTip1.AutoPopDelay = 2000;
            this.toolTip1.InitialDelay = 500;
            this.toolTip1.ReshowDelay = 100;
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(368, 60);
            this.txtCode.MaxLength = 100000;
            this.txtCode.Multiline = true;
            this.txtCode.Name = "txtCode";
            this.txtCode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCode.Size = new System.Drawing.Size(609, 114);
            this.txtCode.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Num,
            this.Ver,
            this.Bat,
            this.Date,
            this.Station,
            this.Ch1,
            this.Ch2,
            this.Ch3,
            this.Ch4,
            this.Ch5,
            this.Ch6,
            this.Ch7,
            this.Ch8,
            this.Ch9,
            this.Ch10,
            this.Ch11,
            this.Ch12,
            this.R1,
            this.Door,
            this.Sim,
            this.Rssi,
            this.Rsrp,
            this.Snr});
            this.dataGridView1.Location = new System.Drawing.Point(32, 190);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1053, 435);
            this.dataGridView1.TabIndex = 8;
            // 
            // Num
            // 
            this.Num.HeaderText = "NUM";
            this.Num.Name = "Num";
            this.Num.Width = 56;
            // 
            // Ver
            // 
            this.Ver.HeaderText = "版本";
            this.Ver.Name = "Ver";
            this.Ver.Width = 54;
            // 
            // Bat
            // 
            this.Bat.HeaderText = "電池";
            this.Bat.Name = "Bat";
            this.Bat.Width = 54;
            // 
            // Date
            // 
            this.Date.HeaderText = "日期";
            this.Date.Name = "Date";
            this.Date.Width = 54;
            // 
            // Station
            // 
            this.Station.HeaderText = "站碼";
            this.Station.Name = "Station";
            this.Station.Width = 54;
            // 
            // Ch1
            // 
            this.Ch1.HeaderText = "DI1";
            this.Ch1.Name = "Ch1";
            this.Ch1.Width = 48;
            // 
            // Ch2
            // 
            this.Ch2.HeaderText = "DI2";
            this.Ch2.Name = "Ch2";
            this.Ch2.Width = 48;
            // 
            // Ch3
            // 
            this.Ch3.HeaderText = "DI3";
            this.Ch3.Name = "Ch3";
            this.Ch3.Width = 48;
            // 
            // Ch4
            // 
            this.Ch4.HeaderText = "DI4";
            this.Ch4.Name = "Ch4";
            this.Ch4.Width = 48;
            // 
            // Ch5
            // 
            this.Ch5.HeaderText = "DI5";
            this.Ch5.Name = "Ch5";
            this.Ch5.Width = 48;
            // 
            // Ch6
            // 
            this.Ch6.HeaderText = "DI6";
            this.Ch6.Name = "Ch6";
            this.Ch6.Width = 48;
            // 
            // Ch7
            // 
            this.Ch7.HeaderText = "DI7";
            this.Ch7.Name = "Ch7";
            this.Ch7.Width = 48;
            // 
            // Ch8
            // 
            this.Ch8.HeaderText = "DI8";
            this.Ch8.Name = "Ch8";
            this.Ch8.Width = 48;
            // 
            // Ch9
            // 
            this.Ch9.HeaderText = "AI1";
            this.Ch9.Name = "Ch9";
            this.Ch9.Width = 48;
            // 
            // Ch10
            // 
            this.Ch10.HeaderText = "AI2";
            this.Ch10.Name = "Ch10";
            this.Ch10.Width = 48;
            // 
            // Ch11
            // 
            this.Ch11.HeaderText = "AI3";
            this.Ch11.Name = "Ch11";
            this.Ch11.Width = 48;
            // 
            // Ch12
            // 
            this.Ch12.HeaderText = "AI4";
            this.Ch12.Name = "Ch12";
            this.Ch12.Width = 48;
            // 
            // R1
            // 
            this.R1.HeaderText = "Rain";
            this.R1.Name = "R1";
            this.R1.Width = 52;
            // 
            // Door
            // 
            this.Door.HeaderText = "Door";
            this.Door.Name = "Door";
            this.Door.Width = 54;
            // 
            // Sim
            // 
            this.Sim.HeaderText = "Connect";
            this.Sim.Name = "Sim";
            this.Sim.Width = 69;
            // 
            // Rssi
            // 
            this.Rssi.HeaderText = "RSSI";
            this.Rssi.Name = "Rssi";
            this.Rssi.Width = 54;
            // 
            // Rsrp
            // 
            this.Rsrp.HeaderText = "RSRP";
            this.Rsrp.Name = "Rsrp";
            this.Rsrp.Width = 58;
            // 
            // Snr
            // 
            this.Snr.HeaderText = "SNR";
            this.Snr.Name = "Snr";
            this.Snr.Width = 52;
            // 
            // btnConvert
            // 
            this.btnConvert.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnConvert.Location = new System.Drawing.Point(983, 82);
            this.btnConvert.Name = "btnConvert";
            this.btnConvert.Size = new System.Drawing.Size(58, 95);
            this.btnConvert.TabIndex = 3;
            this.btnConvert.Text = "轉換";
            this.btnConvert.UseVisualStyleBackColor = true;
            this.btnConvert.Click += new System.EventHandler(this.btnConvert_Click);
            // 
            // btnclr
            // 
            this.btnclr.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnclr.Location = new System.Drawing.Point(976, 631);
            this.btnclr.Name = "btnclr";
            this.btnclr.Size = new System.Drawing.Size(109, 40);
            this.btnclr.TabIndex = 3;
            this.btnclr.Text = "清除";
            this.btnclr.UseVisualStyleBackColor = true;
            this.btnclr.Click += new System.EventHandler(this.btnclr_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn18,
            this.dataGridViewTextBoxColumn22});
            this.dataGridView2.Location = new System.Drawing.Point(32, 190);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(717, 435);
            this.dataGridView2.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "NUM";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 56;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "版本";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 54;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "電池";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 54;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "日期";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "站碼";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 54;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "DI1";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 48;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "DI2";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 48;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "DI3";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Width = 48;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "DI4";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Width = 48;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "AI1";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 48;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "AI2";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.Width = 48;
            // 
            // dataGridViewTextBoxColumn18
            // 
            this.dataGridViewTextBoxColumn18.HeaderText = "Rain";
            this.dataGridViewTextBoxColumn18.Name = "dataGridViewTextBoxColumn18";
            this.dataGridViewTextBoxColumn18.Width = 52;
            // 
            // dataGridViewTextBoxColumn22
            // 
            this.dataGridViewTextBoxColumn22.HeaderText = "RSRP";
            this.dataGridViewTextBoxColumn22.Name = "dataGridViewTextBoxColumn22";
            this.dataGridViewTextBoxColumn22.Width = 58;
            // 
            // radPro
            // 
            this.radPro.AutoSize = true;
            this.radPro.Font = new System.Drawing.Font("JetBrains Mono ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radPro.Location = new System.Drawing.Point(13, 7);
            this.radPro.Name = "radPro";
            this.radPro.Size = new System.Drawing.Size(90, 20);
            this.radPro.TabIndex = 10;
            this.radPro.TabStop = true;
            this.radPro.Text = "RT200Pro";
            this.radPro.UseVisualStyleBackColor = true;
            this.radPro.CheckedChanged += new System.EventHandler(this.radPro_CheckedChanged);
            // 
            // radMini
            // 
            this.radMini.AutoSize = true;
            this.radMini.Font = new System.Drawing.Font("JetBrains Mono ExtraLight", 8.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radMini.Location = new System.Drawing.Point(13, 26);
            this.radMini.Name = "radMini";
            this.radMini.Size = new System.Drawing.Size(98, 20);
            this.radMini.TabIndex = 11;
            this.radMini.TabStop = true;
            this.radMini.Text = "RT200Mini";
            this.radMini.UseVisualStyleBackColor = true;
            this.radMini.CheckedChanged += new System.EventHandler(this.radPro_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.radPro);
            this.panel1.Controls.Add(this.radMini);
            this.panel1.Location = new System.Drawing.Point(976, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(120, 47);
            this.panel1.TabIndex = 12;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1116, 683);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtCode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDate);
            this.Controls.Add(this.txtSec);
            this.Controls.Add(this.btnCalcData);
            this.Controls.Add(this.btnclr);
            this.Controls.Add(this.btnConvert);
            this.Controls.Add(this.btnclose);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "Form2";
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.FolderBrowserDialog fBrowser;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnCalcData;
        private System.Windows.Forms.TextBox txtSec;
        private System.Windows.Forms.TextBox txtDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnConvert;
        private System.Windows.Forms.Button btnclr;
        private System.Windows.Forms.DataGridViewTextBoxColumn Num;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Station;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ch12;
        private System.Windows.Forms.DataGridViewTextBoxColumn R1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Door;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sim;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rssi;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rsrp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Snr;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn18;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn22;
        private System.Windows.Forms.RadioButton radPro;
        private System.Windows.Forms.RadioButton radMini;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Panel panel1;
    }
}