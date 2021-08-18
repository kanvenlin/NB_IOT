
namespace NB_iot
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeRx = new System.Windows.Forms.Timer(this.components);
            this.SerialCOM = new System.IO.Ports.SerialPort(this.components);
            this.btnPort = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.boxCom = new System.Windows.Forms.ComboBox();
            this.boxBaurd = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tabFunc = new System.Windows.Forms.TabControl();
            this.tabRTC = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.txtStation = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSetBasic = new System.Windows.Forms.Button();
            this.btnReadStation = new System.Windows.Forms.Button();
            this.btnStation = new System.Windows.Forms.Button();
            this.boxCycleSec = new System.Windows.Forms.TextBox();
            this.boxCycleMin = new System.Windows.Forms.TextBox();
            this.boxCycleHour = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.label46 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label45 = new System.Windows.Forms.Label();
            this.btnAllSet = new System.Windows.Forms.Button();
            this.btnReadBasic = new System.Windows.Forms.Button();
            this.btnCycleTime = new System.Windows.Forms.Button();
            this.chkCrycle = new System.Windows.Forms.CheckBox();
            this.chkRec = new System.Windows.Forms.CheckBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.txtRtcTime = new System.Windows.Forms.TextBox();
            this.boxSec = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.chkMin = new System.Windows.Forms.CheckBox();
            this.chkSec = new System.Windows.Forms.CheckBox();
            this.chkHour = new System.Windows.Forms.CheckBox();
            this.boxMin = new System.Windows.Forms.TextBox();
            this.boxHour = new System.Windows.Forms.TextBox();
            this.chkAF = new System.Windows.Forms.CheckBox();
            this.chkIE = new System.Windows.Forms.CheckBox();
            this.btnReadRTC = new System.Windows.Forms.Button();
            this.btnSymTime = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAF = new System.Windows.Forms.Button();
            this.btnIE = new System.Windows.Forms.Button();
            this.btnIntTime = new System.Windows.Forms.Button();
            this.txtver = new System.Windows.Forms.TextBox();
            this.label83 = new System.Windows.Forms.Label();
            this.btnVer = new System.Windows.Forms.Button();
            this.btnClearRec = new System.Windows.Forms.Button();
            this.tabNET = new System.Windows.Forms.TabPage();
            this.btnReadNet = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtPORT2 = new System.Windows.Forms.TextBox();
            this.txtIP2 = new System.Windows.Forms.TextBox();
            this.txtPORT = new System.Windows.Forms.TextBox();
            this.label85 = new System.Windows.Forms.Label();
            this.txtIP = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.chkNB2 = new System.Windows.Forms.CheckBox();
            this.btnFET = new System.Windows.Forms.Button();
            this.chkNB1 = new System.Windows.Forms.CheckBox();
            this.txtapn = new System.Windows.Forms.TextBox();
            this.btnTW = new System.Windows.Forms.Button();
            this.label84 = new System.Windows.Forms.Label();
            this.btnCHT = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnReadApn = new System.Windows.Forms.Button();
            this.btnApn = new System.Windows.Forms.Button();
            this.btnReadIP = new System.Windows.Forms.Button();
            this.btnIP = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnReadBand = new System.Windows.Forms.Button();
            this.btnBand = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.boxNB7 = new System.Windows.Forms.CheckBox();
            this.boxNB9 = new System.Windows.Forms.CheckBox();
            this.boxM18 = new System.Windows.Forms.CheckBox();
            this.txtSNR = new System.Windows.Forms.TextBox();
            this.txtRSRP = new System.Windows.Forms.TextBox();
            this.txtRSSI = new System.Windows.Forms.TextBox();
            this.txtconnect = new System.Windows.Forms.TextBox();
            this.txtIMEI = new System.Windows.Forms.TextBox();
            this.label82 = new System.Windows.Forms.Label();
            this.label81 = new System.Windows.Forms.Label();
            this.label80 = new System.Windows.Forms.Label();
            this.label79 = new System.Windows.Forms.Label();
            this.label78 = new System.Windows.Forms.Label();
            this.btnSingle = new System.Windows.Forms.Button();
            this.btnIMEI = new System.Windows.Forms.Button();
            this.tabAD = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtCH2 = new System.Windows.Forms.TextBox();
            this.txtCH6 = new System.Windows.Forms.TextBox();
            this.txtCH10 = new System.Windows.Forms.TextBox();
            this.txtCH4 = new System.Windows.Forms.TextBox();
            this.txtCH8 = new System.Windows.Forms.TextBox();
            this.txtCH12 = new System.Windows.Forms.TextBox();
            this.radCalc = new System.Windows.Forms.RadioButton();
            this.radRaw = new System.Windows.Forms.RadioButton();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label39 = new System.Windows.Forms.Label();
            this.label31 = new System.Windows.Forms.Label();
            this.label42 = new System.Windows.Forms.Label();
            this.label38 = new System.Windows.Forms.Label();
            this.label35 = new System.Windows.Forms.Label();
            this.label41 = new System.Windows.Forms.Label();
            this.label37 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label40 = new System.Windows.Forms.Label();
            this.label36 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.txtCH5 = new System.Windows.Forms.TextBox();
            this.txtCH1 = new System.Windows.Forms.TextBox();
            this.txtCH9 = new System.Windows.Forms.TextBox();
            this.btnContinue = new System.Windows.Forms.Button();
            this.btnClrAIV = new System.Windows.Forms.Button();
            this.btnReadAI = new System.Windows.Forms.Button();
            this.txtDoor = new System.Windows.Forms.TextBox();
            this.txtCH3 = new System.Windows.Forms.TextBox();
            this.txtCH7 = new System.Windows.Forms.TextBox();
            this.txtRain = new System.Windows.Forms.TextBox();
            this.txtCH11 = new System.Windows.Forms.TextBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtCalAIV = new System.Windows.Forms.TextBox();
            this.radAI1 = new System.Windows.Forms.RadioButton();
            this.radAI3 = new System.Windows.Forms.RadioButton();
            this.btnCalAI = new System.Windows.Forms.Button();
            this.radAI4 = new System.Windows.Forms.RadioButton();
            this.radAI2 = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtBatV = new System.Windows.Forms.TextBox();
            this.txtCalBatV = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.btnReadBat = new System.Windows.Forms.Button();
            this.btnCalBat = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.boxType8 = new System.Windows.Forms.ComboBox();
            this.boxType7 = new System.Windows.Forms.ComboBox();
            this.boxType6 = new System.Windows.Forms.ComboBox();
            this.boxType5 = new System.Windows.Forms.ComboBox();
            this.boxType4 = new System.Windows.Forms.ComboBox();
            this.boxType3 = new System.Windows.Forms.ComboBox();
            this.boxType2 = new System.Windows.Forms.ComboBox();
            this.cbobaud = new System.Windows.Forms.ComboBox();
            this.boxType1 = new System.Windows.Forms.ComboBox();
            this.boxData8 = new System.Windows.Forms.TextBox();
            this.boxID8 = new System.Windows.Forms.TextBox();
            this.boxData7 = new System.Windows.Forms.TextBox();
            this.boxData6 = new System.Windows.Forms.TextBox();
            this.btnReadType = new System.Windows.Forms.Button();
            this.btnSetType = new System.Windows.Forms.Button();
            this.boxID7 = new System.Windows.Forms.TextBox();
            this.boxData5 = new System.Windows.Forms.TextBox();
            this.boxID6 = new System.Windows.Forms.TextBox();
            this.boxData4 = new System.Windows.Forms.TextBox();
            this.boxID5 = new System.Windows.Forms.TextBox();
            this.boxData3 = new System.Windows.Forms.TextBox();
            this.boxID4 = new System.Windows.Forms.TextBox();
            this.boxData2 = new System.Windows.Forms.TextBox();
            this.boxID3 = new System.Windows.Forms.TextBox();
            this.boxID2 = new System.Windows.Forms.TextBox();
            this.label59 = new System.Windows.Forms.Label();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label53 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label58 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.boxData1 = new System.Windows.Forms.TextBox();
            this.label90 = new System.Windows.Forms.Label();
            this.label89 = new System.Windows.Forms.Label();
            this.label88 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.boxID1 = new System.Windows.Forms.TextBox();
            this.tabCHG = new System.Windows.Forms.TabPage();
            this.boxRain = new System.Windows.Forms.ComboBox();
            this.txtCch12 = new System.Windows.Forms.TextBox();
            this.txtCch8 = new System.Windows.Forms.TextBox();
            this.txtCch4 = new System.Windows.Forms.TextBox();
            this.txtCch11 = new System.Windows.Forms.TextBox();
            this.txtCch7 = new System.Windows.Forms.TextBox();
            this.txtCch3 = new System.Windows.Forms.TextBox();
            this.txtCch10 = new System.Windows.Forms.TextBox();
            this.txtCch6 = new System.Windows.Forms.TextBox();
            this.txtCch2 = new System.Windows.Forms.TextBox();
            this.txtCch9 = new System.Windows.Forms.TextBox();
            this.txtCch5 = new System.Windows.Forms.TextBox();
            this.txtCch1 = new System.Windows.Forms.TextBox();
            this.btnSCHG = new System.Windows.Forms.Button();
            this.btnRCHG = new System.Windows.Forms.Button();
            this.txtMch12 = new System.Windows.Forms.TextBox();
            this.txtXch12 = new System.Windows.Forms.TextBox();
            this.txtDch12 = new System.Windows.Forms.TextBox();
            this.txtMch8 = new System.Windows.Forms.TextBox();
            this.txtXch8 = new System.Windows.Forms.TextBox();
            this.txtDch8 = new System.Windows.Forms.TextBox();
            this.txtMch11 = new System.Windows.Forms.TextBox();
            this.txtXch11 = new System.Windows.Forms.TextBox();
            this.txtMch4 = new System.Windows.Forms.TextBox();
            this.txtXch4 = new System.Windows.Forms.TextBox();
            this.txtMch7 = new System.Windows.Forms.TextBox();
            this.txtXch7 = new System.Windows.Forms.TextBox();
            this.txtDch11 = new System.Windows.Forms.TextBox();
            this.txtDch4 = new System.Windows.Forms.TextBox();
            this.txtDch7 = new System.Windows.Forms.TextBox();
            this.txtMch10 = new System.Windows.Forms.TextBox();
            this.txtXch10 = new System.Windows.Forms.TextBox();
            this.txtMch3 = new System.Windows.Forms.TextBox();
            this.txtXch3 = new System.Windows.Forms.TextBox();
            this.txtMch6 = new System.Windows.Forms.TextBox();
            this.txtXch6 = new System.Windows.Forms.TextBox();
            this.txtRch12 = new System.Windows.Forms.TextBox();
            this.txtDch3 = new System.Windows.Forms.TextBox();
            this.txtRch8 = new System.Windows.Forms.TextBox();
            this.txtDch10 = new System.Windows.Forms.TextBox();
            this.txtMch2 = new System.Windows.Forms.TextBox();
            this.txtXch2 = new System.Windows.Forms.TextBox();
            this.txtDch6 = new System.Windows.Forms.TextBox();
            this.txtRch11 = new System.Windows.Forms.TextBox();
            this.txtRch4 = new System.Windows.Forms.TextBox();
            this.txtRch7 = new System.Windows.Forms.TextBox();
            this.txtMch9 = new System.Windows.Forms.TextBox();
            this.txtXch9 = new System.Windows.Forms.TextBox();
            this.txtDch2 = new System.Windows.Forms.TextBox();
            this.txtMch5 = new System.Windows.Forms.TextBox();
            this.txtXch5 = new System.Windows.Forms.TextBox();
            this.txtLch12 = new System.Windows.Forms.TextBox();
            this.txtRch3 = new System.Windows.Forms.TextBox();
            this.txtLch8 = new System.Windows.Forms.TextBox();
            this.txtRch10 = new System.Windows.Forms.TextBox();
            this.txtMch1 = new System.Windows.Forms.TextBox();
            this.txtXch1 = new System.Windows.Forms.TextBox();
            this.txtRch6 = new System.Windows.Forms.TextBox();
            this.txtLch11 = new System.Windows.Forms.TextBox();
            this.txtLch4 = new System.Windows.Forms.TextBox();
            this.txtLch7 = new System.Windows.Forms.TextBox();
            this.txtDch9 = new System.Windows.Forms.TextBox();
            this.txtRch2 = new System.Windows.Forms.TextBox();
            this.txtDch5 = new System.Windows.Forms.TextBox();
            this.txtBPch12 = new System.Windows.Forms.TextBox();
            this.txtLch3 = new System.Windows.Forms.TextBox();
            this.txtBPch8 = new System.Windows.Forms.TextBox();
            this.txtLch10 = new System.Windows.Forms.TextBox();
            this.txtDch1 = new System.Windows.Forms.TextBox();
            this.txtLch6 = new System.Windows.Forms.TextBox();
            this.txtBPch11 = new System.Windows.Forms.TextBox();
            this.txtBPch4 = new System.Windows.Forms.TextBox();
            this.txtBPch7 = new System.Windows.Forms.TextBox();
            this.txtRch9 = new System.Windows.Forms.TextBox();
            this.txtLch2 = new System.Windows.Forms.TextBox();
            this.txtRch5 = new System.Windows.Forms.TextBox();
            this.txtBPch10 = new System.Windows.Forms.TextBox();
            this.txtBPch3 = new System.Windows.Forms.TextBox();
            this.txtBPch6 = new System.Windows.Forms.TextBox();
            this.txtLch9 = new System.Windows.Forms.TextBox();
            this.txtRch1 = new System.Windows.Forms.TextBox();
            this.txtLch5 = new System.Windows.Forms.TextBox();
            this.txtBPch9 = new System.Windows.Forms.TextBox();
            this.txtBPch2 = new System.Windows.Forms.TextBox();
            this.txtBPch5 = new System.Windows.Forms.TextBox();
            this.txtLch1 = new System.Windows.Forms.TextBox();
            this.txtBPch1 = new System.Windows.Forms.TextBox();
            this.label92 = new System.Windows.Forms.Label();
            this.label91 = new System.Windows.Forms.Label();
            this.label77 = new System.Windows.Forms.Label();
            this.label76 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.label65 = new System.Windows.Forms.Label();
            this.label72 = new System.Windows.Forms.Label();
            this.label = new System.Windows.Forms.Label();
            this.label75 = new System.Windows.Forms.Label();
            this.label68 = new System.Windows.Forms.Label();
            this.label71 = new System.Windows.Forms.Label();
            this.label63 = new System.Windows.Forms.Label();
            this.label74 = new System.Windows.Forms.Label();
            this.label67 = new System.Windows.Forms.Label();
            this.label70 = new System.Windows.Forms.Label();
            this.label62 = new System.Windows.Forms.Label();
            this.label73 = new System.Windows.Forms.Label();
            this.label64 = new System.Windows.Forms.Label();
            this.label69 = new System.Windows.Forms.Label();
            this.label61 = new System.Windows.Forms.Label();
            this.label66 = new System.Windows.Forms.Label();
            this.label60 = new System.Windows.Forms.Label();
            this.tabProbe = new System.Windows.Forms.TabPage();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.chkBAT = new System.Windows.Forms.CheckBox();
            this.chkRain = new System.Windows.Forms.CheckBox();
            this.label20 = new System.Windows.Forms.Label();
            this.txtms = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.chkProbe = new System.Windows.Forms.CheckBox();
            this.chkAD = new System.Windows.Forms.CheckBox();
            this.chkBG = new System.Windows.Forms.CheckBox();
            this.btnReadUart = new System.Windows.Forms.Button();
            this.btnUart = new System.Windows.Forms.Button();
            this.tabCRC = new System.Windows.Forms.TabPage();
            this.label25 = new System.Windows.Forms.Label();
            this.btnSIDstr = new System.Windows.Forms.Button();
            this.btnRIDstr = new System.Windows.Forms.Button();
            this.btnReadStr = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.label28 = new System.Windows.Forms.Label();
            this.label87 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.boxSendHex = new System.Windows.Forms.TextBox();
            this.btnCRC16 = new System.Windows.Forms.Button();
            this.btnCRC = new System.Windows.Forms.Button();
            this.txtSetID = new System.Windows.Forms.TextBox();
            this.txtnowID = new System.Windows.Forms.TextBox();
            this.boxStr = new System.Windows.Forms.TextBox();
            this.boxHEX = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.boxCRC16 = new System.Windows.Forms.TextBox();
            this.boxCrc = new System.Windows.Forms.TextBox();
            this.label94 = new System.Windows.Forms.Label();
            this.label93 = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.boxHexCalc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSysTime = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.timer1s = new System.Windows.Forms.Timer(this.components);
            this.btnClrTX = new System.Windows.Forms.Button();
            this.txtRecNum = new System.Windows.Forms.TextBox();
            this.txtSendNum = new System.Windows.Forms.TextBox();
            this.btnRec = new System.Windows.Forms.Button();
            this.label19 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.chkTxHex = new System.Windows.Forms.CheckBox();
            this.chkRxHex = new System.Windows.Forms.CheckBox();
            this.btnSn = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.timAD = new System.Windows.Forms.Timer(this.components);
            this.label22 = new System.Windows.Forms.Label();
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.rchRx = new System.Windows.Forms.RichTextBox();
            this.rchTx = new System.Windows.Forms.RichTextBox();
            this.rchTxHex = new System.Windows.Forms.RichTextBox();
            this.rchRxHex = new System.Windows.Forms.RichTextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.txtVerNote = new System.Windows.Forms.TextBox();
            this.label86 = new System.Windows.Forms.Label();
            this.txtSendNum2 = new System.Windows.Forms.TextBox();
            this.chknormal = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.tabFunc.SuspendLayout();
            this.tabRTC.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.tabNET.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabAD.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabCHG.SuspendLayout();
            this.tabProbe.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.tabCRC.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeRx
            // 
            this.timeRx.Interval = 50;
            this.timeRx.Tick += new System.EventHandler(this.timeRx_Tick);
            // 
            // btnPort
            // 
            this.btnPort.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnPort.Location = new System.Drawing.Point(214, 19);
            this.btnPort.Name = "btnPort";
            this.btnPort.Size = new System.Drawing.Size(74, 54);
            this.btnPort.TabIndex = 0;
            this.btnPort.Text = "OPEN PORT";
            this.btnPort.UseVisualStyleBackColor = true;
            this.btnPort.Click += new System.EventHandler(this.btnPort_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(34, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "COM";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Baudrate";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSearch.Location = new System.Drawing.Point(304, 21);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(57, 50);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // boxCom
            // 
            this.boxCom.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCom.FormattingEnabled = true;
            this.boxCom.Location = new System.Drawing.Point(78, 19);
            this.boxCom.Name = "boxCom";
            this.boxCom.Size = new System.Drawing.Size(117, 24);
            this.boxCom.TabIndex = 7;
            // 
            // boxBaurd
            // 
            this.boxBaurd.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "19200",
            "57600",
            "115200"});
            this.boxBaurd.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxBaurd.FormattingEnabled = true;
            this.boxBaurd.Items.AddRange(new object[] {
            "9600",
            "38400",
            "19200",
            "57600",
            "115200"});
            this.boxBaurd.Location = new System.Drawing.Point(78, 49);
            this.boxBaurd.Name = "boxBaurd";
            this.boxBaurd.Size = new System.Drawing.Size(117, 24);
            this.boxBaurd.TabIndex = 7;
            this.boxBaurd.Text = "57600";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.boxBaurd);
            this.groupBox1.Controls.Add(this.boxCom);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnPort);
            this.groupBox1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(21, 43);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(394, 86);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "COM Port Setting";
            // 
            // tabFunc
            // 
            this.tabFunc.Controls.Add(this.tabRTC);
            this.tabFunc.Controls.Add(this.tabNET);
            this.tabFunc.Controls.Add(this.tabAD);
            this.tabFunc.Controls.Add(this.tabPage1);
            this.tabFunc.Controls.Add(this.tabCHG);
            this.tabFunc.Controls.Add(this.tabProbe);
            this.tabFunc.Controls.Add(this.tabCRC);
            this.tabFunc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.tabFunc.Location = new System.Drawing.Point(21, 177);
            this.tabFunc.Name = "tabFunc";
            this.tabFunc.SelectedIndex = 0;
            this.tabFunc.Size = new System.Drawing.Size(432, 533);
            this.tabFunc.TabIndex = 9;
            // 
            // tabRTC
            // 
            this.tabRTC.Controls.Add(this.groupBox7);
            this.tabRTC.Controls.Add(this.groupBox6);
            this.tabRTC.Controls.Add(this.txtver);
            this.tabRTC.Controls.Add(this.label83);
            this.tabRTC.Controls.Add(this.btnVer);
            this.tabRTC.Controls.Add(this.btnClearRec);
            this.tabRTC.Location = new System.Drawing.Point(4, 25);
            this.tabRTC.Name = "tabRTC";
            this.tabRTC.Padding = new System.Windows.Forms.Padding(3);
            this.tabRTC.Size = new System.Drawing.Size(424, 504);
            this.tabRTC.TabIndex = 0;
            this.tabRTC.Text = "基本設定";
            this.tabRTC.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.txtStation);
            this.groupBox7.Controls.Add(this.label18);
            this.groupBox7.Controls.Add(this.btnSetBasic);
            this.groupBox7.Controls.Add(this.btnReadStation);
            this.groupBox7.Controls.Add(this.btnStation);
            this.groupBox7.Controls.Add(this.boxCycleSec);
            this.groupBox7.Controls.Add(this.boxCycleMin);
            this.groupBox7.Controls.Add(this.boxCycleHour);
            this.groupBox7.Controls.Add(this.label47);
            this.groupBox7.Controls.Add(this.label46);
            this.groupBox7.Controls.Add(this.label12);
            this.groupBox7.Controls.Add(this.label45);
            this.groupBox7.Controls.Add(this.btnAllSet);
            this.groupBox7.Controls.Add(this.btnReadBasic);
            this.groupBox7.Controls.Add(this.btnCycleTime);
            this.groupBox7.Controls.Add(this.chkCrycle);
            this.groupBox7.Controls.Add(this.chkRec);
            this.groupBox7.Location = new System.Drawing.Point(7, 311);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(387, 179);
            this.groupBox7.TabIndex = 18;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "基本參數";
            // 
            // txtStation
            // 
            this.txtStation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtStation.Location = new System.Drawing.Point(35, 22);
            this.txtStation.MaxLength = 8;
            this.txtStation.Name = "txtStation";
            this.txtStation.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtStation.Size = new System.Drawing.Size(107, 23);
            this.txtStation.TabIndex = 16;
            this.txtStation.Text = "00000000";
            this.txtStation.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label18.Location = new System.Drawing.Point(7, 28);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(32, 16);
            this.label18.TabIndex = 11;
            this.label18.Text = "站碼";
            // 
            // btnSetBasic
            // 
            this.btnSetBasic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetBasic.Location = new System.Drawing.Point(278, 12);
            this.btnSetBasic.Name = "btnSetBasic";
            this.btnSetBasic.Size = new System.Drawing.Size(100, 42);
            this.btnSetBasic.TabIndex = 12;
            this.btnSetBasic.Text = "設定基本參數";
            this.btnSetBasic.UseVisualStyleBackColor = true;
            this.btnSetBasic.Click += new System.EventHandler(this.btnSetBasic_Click);
            // 
            // btnReadStation
            // 
            this.btnReadStation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadStation.Location = new System.Drawing.Point(198, 12);
            this.btnReadStation.Name = "btnReadStation";
            this.btnReadStation.Size = new System.Drawing.Size(46, 42);
            this.btnReadStation.TabIndex = 13;
            this.btnReadStation.Text = "讀取 站碼";
            this.btnReadStation.UseVisualStyleBackColor = true;
            this.btnReadStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // btnStation
            // 
            this.btnStation.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnStation.Location = new System.Drawing.Point(151, 12);
            this.btnStation.Name = "btnStation";
            this.btnStation.Size = new System.Drawing.Size(41, 42);
            this.btnStation.TabIndex = 13;
            this.btnStation.Text = "寫入站碼";
            this.btnStation.UseVisualStyleBackColor = true;
            this.btnStation.Click += new System.EventHandler(this.btnStation_Click);
            // 
            // boxCycleSec
            // 
            this.boxCycleSec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCycleSec.Location = new System.Drawing.Point(35, 126);
            this.boxCycleSec.Name = "boxCycleSec";
            this.boxCycleSec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxCycleSec.Size = new System.Drawing.Size(107, 23);
            this.boxCycleSec.TabIndex = 10;
            this.boxCycleSec.Text = "00";
            this.boxCycleSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxCycleMin
            // 
            this.boxCycleMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCycleMin.Location = new System.Drawing.Point(35, 97);
            this.boxCycleMin.Name = "boxCycleMin";
            this.boxCycleMin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxCycleMin.Size = new System.Drawing.Size(107, 23);
            this.boxCycleMin.TabIndex = 10;
            this.boxCycleMin.Text = "00";
            this.boxCycleMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxCycleHour
            // 
            this.boxCycleHour.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCycleHour.Location = new System.Drawing.Point(35, 67);
            this.boxCycleHour.Name = "boxCycleHour";
            this.boxCycleHour.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxCycleHour.Size = new System.Drawing.Size(107, 23);
            this.boxCycleHour.TabIndex = 10;
            this.boxCycleHour.Text = "00";
            this.boxCycleHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label47.Location = new System.Drawing.Point(11, 129);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(20, 16);
            this.label47.TabIndex = 1;
            this.label47.Text = "秒";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label46.Location = new System.Drawing.Point(11, 100);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(20, 16);
            this.label46.TabIndex = 1;
            this.label46.Text = "分";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label12.Location = new System.Drawing.Point(44, 48);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 16);
            this.label12.TabIndex = 1;
            this.label12.Text = "間隔時間";
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label45.Location = new System.Drawing.Point(11, 70);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(20, 16);
            this.label45.TabIndex = 1;
            this.label45.Text = "時";
            // 
            // btnAllSet
            // 
            this.btnAllSet.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAllSet.Location = new System.Drawing.Point(279, 126);
            this.btnAllSet.Name = "btnAllSet";
            this.btnAllSet.Size = new System.Drawing.Size(99, 47);
            this.btnAllSet.TabIndex = 4;
            this.btnAllSet.Text = "讀取此頁設定";
            this.btnAllSet.UseVisualStyleBackColor = true;
            this.btnAllSet.Click += new System.EventHandler(this.btnAllSet_Click);
            // 
            // btnReadBasic
            // 
            this.btnReadBasic.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadBasic.Location = new System.Drawing.Point(278, 70);
            this.btnReadBasic.Name = "btnReadBasic";
            this.btnReadBasic.Size = new System.Drawing.Size(99, 36);
            this.btnReadBasic.TabIndex = 4;
            this.btnReadBasic.Text = "讀取基本參數";
            this.btnReadBasic.UseVisualStyleBackColor = true;
            this.btnReadBasic.Click += new System.EventHandler(this.btnSetBasic_Click);
            // 
            // btnCycleTime
            // 
            this.btnCycleTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCycleTime.Location = new System.Drawing.Point(198, 67);
            this.btnCycleTime.Name = "btnCycleTime";
            this.btnCycleTime.Size = new System.Drawing.Size(46, 106);
            this.btnCycleTime.TabIndex = 4;
            this.btnCycleTime.Text = "設定間隔時間";
            this.btnCycleTime.UseVisualStyleBackColor = true;
            this.btnCycleTime.Click += new System.EventHandler(this.btnCycleTime_Click);
            // 
            // chkCrycle
            // 
            this.chkCrycle.AutoSize = true;
            this.chkCrycle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkCrycle.Location = new System.Drawing.Point(84, 153);
            this.chkCrycle.Name = "chkCrycle";
            this.chkCrycle.Size = new System.Drawing.Size(75, 20);
            this.chkCrycle.TabIndex = 2;
            this.chkCrycle.Text = "循環紀錄";
            this.chkCrycle.UseVisualStyleBackColor = true;
            // 
            // chkRec
            // 
            this.chkRec.AutoSize = true;
            this.chkRec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkRec.Location = new System.Drawing.Point(14, 153);
            this.chkRec.Name = "chkRec";
            this.chkRec.Size = new System.Drawing.Size(75, 20);
            this.chkRec.TabIndex = 2;
            this.chkRec.Text = "啟動紀錄";
            this.chkRec.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.txtRtcTime);
            this.groupBox6.Controls.Add(this.boxSec);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.label8);
            this.groupBox6.Controls.Add(this.chkMin);
            this.groupBox6.Controls.Add(this.chkSec);
            this.groupBox6.Controls.Add(this.chkHour);
            this.groupBox6.Controls.Add(this.boxMin);
            this.groupBox6.Controls.Add(this.boxHour);
            this.groupBox6.Controls.Add(this.chkAF);
            this.groupBox6.Controls.Add(this.chkIE);
            this.groupBox6.Controls.Add(this.btnReadRTC);
            this.groupBox6.Controls.Add(this.btnSymTime);
            this.groupBox6.Controls.Add(this.btnRead);
            this.groupBox6.Controls.Add(this.btnAF);
            this.groupBox6.Controls.Add(this.btnIE);
            this.groupBox6.Controls.Add(this.btnIntTime);
            this.groupBox6.Location = new System.Drawing.Point(5, 49);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(390, 254);
            this.groupBox6.TabIndex = 17;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "rtc";
            // 
            // txtRtcTime
            // 
            this.txtRtcTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRtcTime.Location = new System.Drawing.Point(76, 53);
            this.txtRtcTime.Name = "txtRtcTime";
            this.txtRtcTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRtcTime.Size = new System.Drawing.Size(196, 23);
            this.txtRtcTime.TabIndex = 10;
            // 
            // boxSec
            // 
            this.boxSec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxSec.Location = new System.Drawing.Point(36, 169);
            this.boxSec.Name = "boxSec";
            this.boxSec.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxSec.Size = new System.Drawing.Size(68, 23);
            this.boxSec.TabIndex = 10;
            this.boxSec.Text = "00";
            this.boxSec.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label13.Location = new System.Drawing.Point(15, 56);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(55, 16);
            this.label13.TabIndex = 1;
            this.label13.Text = "RTC時間";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label10.Location = new System.Drawing.Point(10, 172);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(20, 16);
            this.label10.TabIndex = 1;
            this.label10.Text = "秒";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label9.Location = new System.Drawing.Point(10, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(20, 16);
            this.label9.TabIndex = 1;
            this.label9.Text = "分";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label11.Location = new System.Drawing.Point(33, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 16);
            this.label11.TabIndex = 1;
            this.label11.Text = "啟動時間";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label8.Location = new System.Drawing.Point(10, 113);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(20, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "時";
            // 
            // chkMin
            // 
            this.chkMin.AutoSize = true;
            this.chkMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkMin.Location = new System.Drawing.Point(110, 142);
            this.chkMin.Name = "chkMin";
            this.chkMin.Size = new System.Drawing.Size(51, 20);
            this.chkMin.TabIndex = 3;
            this.chkMin.Text = "設置";
            this.chkMin.UseVisualStyleBackColor = true;
            this.chkMin.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // chkSec
            // 
            this.chkSec.AutoSize = true;
            this.chkSec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkSec.Location = new System.Drawing.Point(110, 172);
            this.chkSec.Name = "chkSec";
            this.chkSec.Size = new System.Drawing.Size(51, 20);
            this.chkSec.TabIndex = 3;
            this.chkSec.Text = "設置";
            this.chkSec.UseVisualStyleBackColor = true;
            this.chkSec.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // chkHour
            // 
            this.chkHour.AutoSize = true;
            this.chkHour.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkHour.Location = new System.Drawing.Point(110, 110);
            this.chkHour.Name = "chkHour";
            this.chkHour.Size = new System.Drawing.Size(51, 20);
            this.chkHour.TabIndex = 3;
            this.chkHour.Text = "設置";
            this.chkHour.UseVisualStyleBackColor = true;
            this.chkHour.CheckedChanged += new System.EventHandler(this.chkMin_CheckedChanged);
            // 
            // boxMin
            // 
            this.boxMin.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxMin.Location = new System.Drawing.Point(36, 140);
            this.boxMin.Name = "boxMin";
            this.boxMin.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxMin.Size = new System.Drawing.Size(68, 23);
            this.boxMin.TabIndex = 10;
            this.boxMin.Text = "00";
            this.boxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxHour
            // 
            this.boxHour.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxHour.Location = new System.Drawing.Point(36, 110);
            this.boxHour.Name = "boxHour";
            this.boxHour.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxHour.Size = new System.Drawing.Size(68, 23);
            this.boxHour.TabIndex = 10;
            this.boxHour.Text = "00";
            this.boxHour.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.boxHour.TextChanged += new System.EventHandler(this.boxHour_TextChanged);
            // 
            // chkAF
            // 
            this.chkAF.AutoSize = true;
            this.chkAF.Enabled = false;
            this.chkAF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkAF.Location = new System.Drawing.Point(110, 208);
            this.chkAF.Name = "chkAF";
            this.chkAF.Size = new System.Drawing.Size(41, 20);
            this.chkAF.TabIndex = 2;
            this.chkAF.Text = "AF";
            this.chkAF.UseVisualStyleBackColor = true;
            // 
            // chkIE
            // 
            this.chkIE.AutoSize = true;
            this.chkIE.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkIE.Location = new System.Drawing.Point(29, 208);
            this.chkIE.Name = "chkIE";
            this.chkIE.Size = new System.Drawing.Size(37, 20);
            this.chkIE.TabIndex = 2;
            this.chkIE.Text = "IE";
            this.chkIE.UseVisualStyleBackColor = true;
            // 
            // btnReadRTC
            // 
            this.btnReadRTC.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadRTC.Location = new System.Drawing.Point(287, 47);
            this.btnReadRTC.Name = "btnReadRTC";
            this.btnReadRTC.Size = new System.Drawing.Size(93, 29);
            this.btnReadRTC.TabIndex = 4;
            this.btnReadRTC.Text = "讀取RTC時間";
            this.btnReadRTC.UseVisualStyleBackColor = true;
            this.btnReadRTC.Click += new System.EventHandler(this.btnReadRTC_Click);
            // 
            // btnSymTime
            // 
            this.btnSymTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSymTime.Location = new System.Drawing.Point(16, 19);
            this.btnSymTime.Name = "btnSymTime";
            this.btnSymTime.Size = new System.Drawing.Size(364, 22);
            this.btnSymTime.TabIndex = 4;
            this.btnSymTime.Text = "同步系統時間";
            this.btnSymTime.UseVisualStyleBackColor = true;
            this.btnSymTime.Click += new System.EventHandler(this.btnSymTime_Click);
            // 
            // btnRead
            // 
            this.btnRead.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRead.Location = new System.Drawing.Point(288, 172);
            this.btnRead.Name = "btnRead";
            this.btnRead.Size = new System.Drawing.Size(92, 61);
            this.btnRead.TabIndex = 4;
            this.btnRead.Text = "讀取RTC設定";
            this.btnRead.UseVisualStyleBackColor = true;
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);
            // 
            // btnAF
            // 
            this.btnAF.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnAF.Location = new System.Drawing.Point(165, 205);
            this.btnAF.Name = "btnAF";
            this.btnAF.Size = new System.Drawing.Size(67, 25);
            this.btnAF.TabIndex = 4;
            this.btnAF.Text = "清除AF";
            this.btnAF.UseVisualStyleBackColor = true;
            this.btnAF.Click += new System.EventHandler(this.btnAF_Click);
            // 
            // btnIE
            // 
            this.btnIE.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIE.Location = new System.Drawing.Point(24, 229);
            this.btnIE.Name = "btnIE";
            this.btnIE.Size = new System.Drawing.Size(67, 25);
            this.btnIE.TabIndex = 4;
            this.btnIE.Text = "中斷設定";
            this.btnIE.UseVisualStyleBackColor = true;
            this.btnIE.Visible = false;
            this.btnIE.Click += new System.EventHandler(this.btnIE_Click);
            // 
            // btnIntTime
            // 
            this.btnIntTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIntTime.Location = new System.Drawing.Point(165, 102);
            this.btnIntTime.Name = "btnIntTime";
            this.btnIntTime.Size = new System.Drawing.Size(67, 86);
            this.btnIntTime.TabIndex = 4;
            this.btnIntTime.Text = "設置啟動時間";
            this.btnIntTime.UseVisualStyleBackColor = true;
            this.btnIntTime.Click += new System.EventHandler(this.btnIntTime_Click);
            // 
            // txtver
            // 
            this.txtver.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtver.Location = new System.Drawing.Point(21, 22);
            this.txtver.Name = "txtver";
            this.txtver.ReadOnly = true;
            this.txtver.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtver.Size = new System.Drawing.Size(57, 23);
            this.txtver.TabIndex = 10;
            this.txtver.Text = "01";
            this.txtver.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label83
            // 
            this.label83.AutoSize = true;
            this.label83.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label83.Location = new System.Drawing.Point(20, 3);
            this.label83.Name = "label83";
            this.label83.Size = new System.Drawing.Size(56, 16);
            this.label83.TabIndex = 1;
            this.label83.Text = "韌體版本";
            // 
            // btnVer
            // 
            this.btnVer.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnVer.Location = new System.Drawing.Point(96, 13);
            this.btnVer.Name = "btnVer";
            this.btnVer.Size = new System.Drawing.Size(76, 36);
            this.btnVer.TabIndex = 4;
            this.btnVer.Text = "讀取版本";
            this.btnVer.UseVisualStyleBackColor = true;
            this.btnVer.Click += new System.EventHandler(this.btnVer_Click);
            // 
            // btnClearRec
            // 
            this.btnClearRec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClearRec.Location = new System.Drawing.Point(267, 13);
            this.btnClearRec.Name = "btnClearRec";
            this.btnClearRec.Size = new System.Drawing.Size(128, 36);
            this.btnClearRec.TabIndex = 4;
            this.btnClearRec.Text = "清除紀錄/傳送筆數";
            this.btnClearRec.UseVisualStyleBackColor = true;
            this.btnClearRec.Click += new System.EventHandler(this.btnReadID_Click);
            // 
            // tabNET
            // 
            this.tabNET.Controls.Add(this.btnReadNet);
            this.tabNET.Controls.Add(this.groupBox3);
            this.tabNET.Controls.Add(this.groupBox2);
            this.tabNET.Controls.Add(this.txtSNR);
            this.tabNET.Controls.Add(this.txtRSRP);
            this.tabNET.Controls.Add(this.txtRSSI);
            this.tabNET.Controls.Add(this.txtconnect);
            this.tabNET.Controls.Add(this.txtIMEI);
            this.tabNET.Controls.Add(this.label82);
            this.tabNET.Controls.Add(this.label81);
            this.tabNET.Controls.Add(this.label80);
            this.tabNET.Controls.Add(this.label79);
            this.tabNET.Controls.Add(this.label78);
            this.tabNET.Controls.Add(this.btnSingle);
            this.tabNET.Controls.Add(this.btnIMEI);
            this.tabNET.Location = new System.Drawing.Point(4, 25);
            this.tabNET.Name = "tabNET";
            this.tabNET.Padding = new System.Windows.Forms.Padding(3);
            this.tabNET.Size = new System.Drawing.Size(424, 504);
            this.tabNET.TabIndex = 1;
            this.tabNET.Text = "NB設定";
            this.tabNET.UseVisualStyleBackColor = true;
            // 
            // btnReadNet
            // 
            this.btnReadNet.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadNet.Location = new System.Drawing.Point(252, 417);
            this.btnReadNet.Name = "btnReadNet";
            this.btnReadNet.Size = new System.Drawing.Size(118, 47);
            this.btnReadNet.TabIndex = 16;
            this.btnReadNet.Text = "讀取此頁設定";
            this.btnReadNet.UseVisualStyleBackColor = true;
            this.btnReadNet.Click += new System.EventHandler(this.btnReadNet_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtPORT2);
            this.groupBox3.Controls.Add(this.txtIP2);
            this.groupBox3.Controls.Add(this.txtPORT);
            this.groupBox3.Controls.Add(this.label85);
            this.groupBox3.Controls.Add(this.txtIP);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.chkNB2);
            this.groupBox3.Controls.Add(this.btnFET);
            this.groupBox3.Controls.Add(this.chkNB1);
            this.groupBox3.Controls.Add(this.txtapn);
            this.groupBox3.Controls.Add(this.btnTW);
            this.groupBox3.Controls.Add(this.label84);
            this.groupBox3.Controls.Add(this.btnCHT);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.btnReadApn);
            this.groupBox3.Controls.Add(this.btnApn);
            this.groupBox3.Controls.Add(this.btnReadIP);
            this.groupBox3.Controls.Add(this.btnIP);
            this.groupBox3.Location = new System.Drawing.Point(7, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(370, 208);
            this.groupBox3.TabIndex = 12;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "NET";
            // 
            // txtPORT2
            // 
            this.txtPORT2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPORT2.Location = new System.Drawing.Point(81, 179);
            this.txtPORT2.Name = "txtPORT2";
            this.txtPORT2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPORT2.Size = new System.Drawing.Size(64, 23);
            this.txtPORT2.TabIndex = 10;
            this.txtPORT2.Text = "19999";
            // 
            // txtIP2
            // 
            this.txtIP2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIP2.Location = new System.Drawing.Point(82, 150);
            this.txtIP2.Name = "txtIP2";
            this.txtIP2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIP2.Size = new System.Drawing.Size(151, 23);
            this.txtIP2.TabIndex = 10;
            this.txtIP2.Text = "60.248.246.82";
            // 
            // txtPORT
            // 
            this.txtPORT.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtPORT.Location = new System.Drawing.Point(81, 118);
            this.txtPORT.Name = "txtPORT";
            this.txtPORT.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtPORT.Size = new System.Drawing.Size(64, 23);
            this.txtPORT.TabIndex = 10;
            this.txtPORT.Text = "19999";
            // 
            // label85
            // 
            this.label85.AutoSize = true;
            this.label85.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label85.Location = new System.Drawing.Point(10, 179);
            this.label85.Name = "label85";
            this.label85.Size = new System.Drawing.Size(72, 16);
            this.label85.TabIndex = 1;
            this.label85.Text = "遠端PORT2";
            // 
            // txtIP
            // 
            this.txtIP.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIP.Location = new System.Drawing.Point(82, 89);
            this.txtIP.Name = "txtIP";
            this.txtIP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIP.Size = new System.Drawing.Size(151, 23);
            this.txtIP.TabIndex = 10;
            this.txtIP.Text = "60.248.246.82";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label16.Location = new System.Drawing.Point(10, 118);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(72, 16);
            this.label16.TabIndex = 1;
            this.label16.Text = "遠端PORT1";
            // 
            // chkNB2
            // 
            this.chkNB2.AutoSize = true;
            this.chkNB2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkNB2.Location = new System.Drawing.Point(153, 182);
            this.chkNB2.Name = "chkNB2";
            this.chkNB2.Size = new System.Drawing.Size(92, 20);
            this.chkNB2.TabIndex = 2;
            this.chkNB2.Text = "開啟NB上傳";
            this.chkNB2.UseVisualStyleBackColor = true;
            // 
            // btnFET
            // 
            this.btnFET.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnFET.Location = new System.Drawing.Point(191, 23);
            this.btnFET.Name = "btnFET";
            this.btnFET.Size = new System.Drawing.Size(54, 23);
            this.btnFET.TabIndex = 4;
            this.btnFET.Text = "遠傳";
            this.btnFET.UseVisualStyleBackColor = true;
            this.btnFET.Click += new System.EventHandler(this.btnCHT_Click);
            // 
            // chkNB1
            // 
            this.chkNB1.AutoSize = true;
            this.chkNB1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkNB1.Location = new System.Drawing.Point(153, 121);
            this.chkNB1.Name = "chkNB1";
            this.chkNB1.Size = new System.Drawing.Size(92, 20);
            this.chkNB1.TabIndex = 2;
            this.chkNB1.Text = "開啟NB上傳";
            this.chkNB1.UseVisualStyleBackColor = true;
            // 
            // txtapn
            // 
            this.txtapn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtapn.Location = new System.Drawing.Point(55, 52);
            this.txtapn.Name = "txtapn";
            this.txtapn.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtapn.Size = new System.Drawing.Size(190, 23);
            this.txtapn.TabIndex = 10;
            this.txtapn.Text = "internet.iot";
            // 
            // btnTW
            // 
            this.btnTW.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnTW.Location = new System.Drawing.Point(122, 23);
            this.btnTW.Name = "btnTW";
            this.btnTW.Size = new System.Drawing.Size(63, 23);
            this.btnTW.TabIndex = 4;
            this.btnTW.Text = "台哥大";
            this.btnTW.UseVisualStyleBackColor = true;
            this.btnTW.Click += new System.EventHandler(this.btnCHT_Click);
            // 
            // label84
            // 
            this.label84.AutoSize = true;
            this.label84.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label84.Location = new System.Drawing.Point(14, 153);
            this.label84.Name = "label84";
            this.label84.Size = new System.Drawing.Size(51, 16);
            this.label84.TabIndex = 1;
            this.label84.Text = "遠端IP2";
            // 
            // btnCHT
            // 
            this.btnCHT.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCHT.Location = new System.Drawing.Point(55, 22);
            this.btnCHT.Name = "btnCHT";
            this.btnCHT.Size = new System.Drawing.Size(61, 23);
            this.btnCHT.TabIndex = 4;
            this.btnCHT.Text = "中華";
            this.btnCHT.UseVisualStyleBackColor = true;
            this.btnCHT.Click += new System.EventHandler(this.btnCHT_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label15.Location = new System.Drawing.Point(14, 92);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(51, 16);
            this.label15.TabIndex = 1;
            this.label15.Text = "遠端IP1";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label14.Location = new System.Drawing.Point(14, 26);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 16);
            this.label14.TabIndex = 1;
            this.label14.Text = "APN";
            // 
            // btnReadApn
            // 
            this.btnReadApn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadApn.Location = new System.Drawing.Point(309, 23);
            this.btnReadApn.Name = "btnReadApn";
            this.btnReadApn.Size = new System.Drawing.Size(54, 53);
            this.btnReadApn.TabIndex = 4;
            this.btnReadApn.Text = "讀取APN";
            this.btnReadApn.UseVisualStyleBackColor = true;
            this.btnReadApn.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // btnApn
            // 
            this.btnApn.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnApn.Location = new System.Drawing.Point(251, 23);
            this.btnApn.Name = "btnApn";
            this.btnApn.Size = new System.Drawing.Size(52, 53);
            this.btnApn.TabIndex = 4;
            this.btnApn.Text = "設定APN";
            this.btnApn.UseVisualStyleBackColor = true;
            this.btnApn.Click += new System.EventHandler(this.btnNet_Click);
            // 
            // btnReadIP
            // 
            this.btnReadIP.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadIP.Location = new System.Drawing.Point(309, 93);
            this.btnReadIP.Name = "btnReadIP";
            this.btnReadIP.Size = new System.Drawing.Size(54, 93);
            this.btnReadIP.TabIndex = 4;
            this.btnReadIP.Text = "讀取IP和NB啟動";
            this.btnReadIP.UseVisualStyleBackColor = true;
            this.btnReadIP.Click += new System.EventHandler(this.btnNet_Click_1);
            // 
            // btnIP
            // 
            this.btnIP.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIP.Location = new System.Drawing.Point(249, 93);
            this.btnIP.Name = "btnIP";
            this.btnIP.Size = new System.Drawing.Size(54, 93);
            this.btnIP.TabIndex = 4;
            this.btnIP.Text = "設定IP及 NB啟動";
            this.btnIP.UseVisualStyleBackColor = true;
            this.btnIP.Click += new System.EventHandler(this.btnNet_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReadBand);
            this.groupBox2.Controls.Add(this.btnBand);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.boxNB7);
            this.groupBox2.Controls.Add(this.boxNB9);
            this.groupBox2.Controls.Add(this.boxM18);
            this.groupBox2.Location = new System.Drawing.Point(5, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(380, 82);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "band";
            // 
            // btnReadBand
            // 
            this.btnReadBand.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadBand.Location = new System.Drawing.Point(282, 20);
            this.btnReadBand.Name = "btnReadBand";
            this.btnReadBand.Size = new System.Drawing.Size(83, 50);
            this.btnReadBand.TabIndex = 4;
            this.btnReadBand.Text = "讀取 \"band\"";
            this.btnReadBand.UseVisualStyleBackColor = true;
            this.btnReadBand.Click += new System.EventHandler(this.btnBand_Click);
            // 
            // btnBand
            // 
            this.btnBand.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnBand.Location = new System.Drawing.Point(193, 20);
            this.btnBand.Name = "btnBand";
            this.btnBand.Size = new System.Drawing.Size(83, 50);
            this.btnBand.TabIndex = 4;
            this.btnBand.Text = "寫入 \"band\"";
            this.btnBand.UseVisualStyleBackColor = true;
            this.btnBand.Click += new System.EventHandler(this.btnBand_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(8, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "M1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(2, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "NB1";
            // 
            // boxNB7
            // 
            this.boxNB7.AutoSize = true;
            this.boxNB7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxNB7.Location = new System.Drawing.Point(41, 46);
            this.boxNB7.Name = "boxNB7";
            this.boxNB7.Size = new System.Drawing.Size(77, 20);
            this.boxNB7.TabIndex = 2;
            this.boxNB7.Text = "700(B28)";
            this.boxNB7.UseVisualStyleBackColor = true;
            // 
            // boxNB9
            // 
            this.boxNB9.AutoSize = true;
            this.boxNB9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxNB9.Location = new System.Drawing.Point(124, 46);
            this.boxNB9.Name = "boxNB9";
            this.boxNB9.Size = new System.Drawing.Size(70, 20);
            this.boxNB9.TabIndex = 3;
            this.boxNB9.Text = "900(B8)";
            this.boxNB9.UseVisualStyleBackColor = true;
            // 
            // boxM18
            // 
            this.boxM18.AutoSize = true;
            this.boxM18.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxM18.Location = new System.Drawing.Point(41, 20);
            this.boxM18.Name = "boxM18";
            this.boxM18.Size = new System.Drawing.Size(77, 20);
            this.boxM18.TabIndex = 5;
            this.boxM18.Text = "1800(B3)";
            this.boxM18.UseVisualStyleBackColor = true;
            // 
            // txtSNR
            // 
            this.txtSNR.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSNR.Location = new System.Drawing.Point(70, 441);
            this.txtSNR.Name = "txtSNR";
            this.txtSNR.ReadOnly = true;
            this.txtSNR.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSNR.Size = new System.Drawing.Size(69, 23);
            this.txtSNR.TabIndex = 10;
            this.txtSNR.Text = "0";
            this.txtSNR.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRSRP
            // 
            this.txtRSRP.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRSRP.Location = new System.Drawing.Point(70, 411);
            this.txtRSRP.Name = "txtRSRP";
            this.txtRSRP.ReadOnly = true;
            this.txtRSRP.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSRP.Size = new System.Drawing.Size(69, 23);
            this.txtRSRP.TabIndex = 10;
            this.txtRSRP.Text = "0";
            this.txtRSRP.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRSSI
            // 
            this.txtRSSI.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRSSI.Location = new System.Drawing.Point(70, 382);
            this.txtRSSI.Name = "txtRSSI";
            this.txtRSSI.ReadOnly = true;
            this.txtRSSI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRSSI.Size = new System.Drawing.Size(69, 23);
            this.txtRSSI.TabIndex = 10;
            this.txtRSSI.Text = "0";
            this.txtRSSI.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtconnect
            // 
            this.txtconnect.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtconnect.Location = new System.Drawing.Point(70, 353);
            this.txtconnect.Name = "txtconnect";
            this.txtconnect.ReadOnly = true;
            this.txtconnect.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtconnect.Size = new System.Drawing.Size(69, 23);
            this.txtconnect.TabIndex = 10;
            this.txtconnect.Text = "eMTC  ";
            this.txtconnect.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtIMEI
            // 
            this.txtIMEI.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtIMEI.Location = new System.Drawing.Point(70, 324);
            this.txtIMEI.Name = "txtIMEI";
            this.txtIMEI.ReadOnly = true;
            this.txtIMEI.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtIMEI.Size = new System.Drawing.Size(174, 23);
            this.txtIMEI.TabIndex = 10;
            this.txtIMEI.Text = "12345678";
            // 
            // label82
            // 
            this.label82.AutoSize = true;
            this.label82.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label82.Location = new System.Drawing.Point(13, 444);
            this.label82.Name = "label82";
            this.label82.Size = new System.Drawing.Size(33, 16);
            this.label82.TabIndex = 1;
            this.label82.Text = "SNR";
            // 
            // label81
            // 
            this.label81.AutoSize = true;
            this.label81.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label81.Location = new System.Drawing.Point(13, 414);
            this.label81.Name = "label81";
            this.label81.Size = new System.Drawing.Size(39, 16);
            this.label81.TabIndex = 1;
            this.label81.Text = "RSRP";
            // 
            // label80
            // 
            this.label80.AutoSize = true;
            this.label80.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label80.Location = new System.Drawing.Point(13, 385);
            this.label80.Name = "label80";
            this.label80.Size = new System.Drawing.Size(34, 16);
            this.label80.TabIndex = 1;
            this.label80.Text = "RSSI";
            // 
            // label79
            // 
            this.label79.AutoSize = true;
            this.label79.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label79.Location = new System.Drawing.Point(9, 356);
            this.label79.Name = "label79";
            this.label79.Size = new System.Drawing.Size(56, 16);
            this.label79.TabIndex = 1;
            this.label79.Text = "連線狀態";
            // 
            // label78
            // 
            this.label78.AutoSize = true;
            this.label78.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label78.Location = new System.Drawing.Point(13, 327);
            this.label78.Name = "label78";
            this.label78.Size = new System.Drawing.Size(35, 16);
            this.label78.TabIndex = 1;
            this.label78.Text = "IMEI";
            // 
            // btnSingle
            // 
            this.btnSingle.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSingle.Location = new System.Drawing.Point(159, 353);
            this.btnSingle.Name = "btnSingle";
            this.btnSingle.Size = new System.Drawing.Size(60, 111);
            this.btnSingle.TabIndex = 4;
            this.btnSingle.Text = "讀取訊號強度";
            this.btnSingle.UseVisualStyleBackColor = true;
            this.btnSingle.Click += new System.EventHandler(this.btnIMEI_Click);
            // 
            // btnIMEI
            // 
            this.btnIMEI.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnIMEI.Location = new System.Drawing.Point(258, 321);
            this.btnIMEI.Name = "btnIMEI";
            this.btnIMEI.Size = new System.Drawing.Size(99, 29);
            this.btnIMEI.TabIndex = 4;
            this.btnIMEI.Text = "讀取IMEI";
            this.btnIMEI.UseVisualStyleBackColor = true;
            this.btnIMEI.Click += new System.EventHandler(this.btnIMEI_Click);
            // 
            // tabAD
            // 
            this.tabAD.Controls.Add(this.panel1);
            this.tabAD.Controls.Add(this.groupBox5);
            this.tabAD.Controls.Add(this.groupBox4);
            this.tabAD.Location = new System.Drawing.Point(4, 25);
            this.tabAD.Name = "tabAD";
            this.tabAD.Padding = new System.Windows.Forms.Padding(3);
            this.tabAD.Size = new System.Drawing.Size(424, 504);
            this.tabAD.TabIndex = 2;
            this.tabAD.Text = "AD設定";
            this.tabAD.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtCH2);
            this.panel1.Controls.Add(this.txtCH6);
            this.panel1.Controls.Add(this.txtCH10);
            this.panel1.Controls.Add(this.txtCH4);
            this.panel1.Controls.Add(this.txtCH8);
            this.panel1.Controls.Add(this.txtCH12);
            this.panel1.Controls.Add(this.radCalc);
            this.panel1.Controls.Add(this.radRaw);
            this.panel1.Controls.Add(this.label32);
            this.panel1.Controls.Add(this.label33);
            this.panel1.Controls.Add(this.label43);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label42);
            this.panel1.Controls.Add(this.label38);
            this.panel1.Controls.Add(this.label35);
            this.panel1.Controls.Add(this.label41);
            this.panel1.Controls.Add(this.label37);
            this.panel1.Controls.Add(this.label30);
            this.panel1.Controls.Add(this.label40);
            this.panel1.Controls.Add(this.label36);
            this.panel1.Controls.Add(this.label29);
            this.panel1.Controls.Add(this.txtCH5);
            this.panel1.Controls.Add(this.txtCH1);
            this.panel1.Controls.Add(this.txtCH9);
            this.panel1.Controls.Add(this.btnContinue);
            this.panel1.Controls.Add(this.btnClrAIV);
            this.panel1.Controls.Add(this.btnReadAI);
            this.panel1.Controls.Add(this.txtDoor);
            this.panel1.Controls.Add(this.txtCH3);
            this.panel1.Controls.Add(this.txtCH7);
            this.panel1.Controls.Add(this.txtRain);
            this.panel1.Controls.Add(this.txtCH11);
            this.panel1.Location = new System.Drawing.Point(9, 193);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(367, 296);
            this.panel1.TabIndex = 13;
            // 
            // txtCH2
            // 
            this.txtCH2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH2.Location = new System.Drawing.Point(140, 42);
            this.txtCH2.Name = "txtCH2";
            this.txtCH2.ReadOnly = true;
            this.txtCH2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH2.Size = new System.Drawing.Size(109, 23);
            this.txtCH2.TabIndex = 10;
            this.txtCH2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH6
            // 
            this.txtCH6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH6.Location = new System.Drawing.Point(140, 136);
            this.txtCH6.Name = "txtCH6";
            this.txtCH6.ReadOnly = true;
            this.txtCH6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH6.Size = new System.Drawing.Size(109, 23);
            this.txtCH6.TabIndex = 10;
            this.txtCH6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH10
            // 
            this.txtCH10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH10.Location = new System.Drawing.Point(140, 225);
            this.txtCH10.Name = "txtCH10";
            this.txtCH10.ReadOnly = true;
            this.txtCH10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH10.Size = new System.Drawing.Size(109, 23);
            this.txtCH10.TabIndex = 10;
            this.txtCH10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH4
            // 
            this.txtCH4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH4.Location = new System.Drawing.Point(140, 91);
            this.txtCH4.Name = "txtCH4";
            this.txtCH4.ReadOnly = true;
            this.txtCH4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH4.Size = new System.Drawing.Size(109, 23);
            this.txtCH4.TabIndex = 10;
            this.txtCH4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH8
            // 
            this.txtCH8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH8.Location = new System.Drawing.Point(140, 181);
            this.txtCH8.Name = "txtCH8";
            this.txtCH8.ReadOnly = true;
            this.txtCH8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH8.Size = new System.Drawing.Size(109, 23);
            this.txtCH8.TabIndex = 10;
            this.txtCH8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH12
            // 
            this.txtCH12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH12.Location = new System.Drawing.Point(140, 270);
            this.txtCH12.Name = "txtCH12";
            this.txtCH12.ReadOnly = true;
            this.txtCH12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH12.Size = new System.Drawing.Size(109, 23);
            this.txtCH12.TabIndex = 10;
            this.txtCH12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radCalc
            // 
            this.radCalc.AutoSize = true;
            this.radCalc.Checked = true;
            this.radCalc.Location = new System.Drawing.Point(73, 4);
            this.radCalc.Name = "radCalc";
            this.radCalc.Size = new System.Drawing.Size(62, 20);
            this.radCalc.TabIndex = 12;
            this.radCalc.TabStop = true;
            this.radCalc.Text = "計算值";
            this.radCalc.UseVisualStyleBackColor = true;
            this.radCalc.CheckedChanged += new System.EventHandler(this.radCalc_CheckedChanged);
            // 
            // radRaw
            // 
            this.radRaw.AutoSize = true;
            this.radRaw.Location = new System.Drawing.Point(13, 4);
            this.radRaw.Name = "radRaw";
            this.radRaw.Size = new System.Drawing.Size(54, 20);
            this.radRaw.TabIndex = 12;
            this.radRaw.Text = "RAW";
            this.radRaw.UseVisualStyleBackColor = true;
            this.radRaw.CheckedChanged += new System.EventHandler(this.radCalc_CheckedChanged);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label32.Location = new System.Drawing.Point(257, 68);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(32, 16);
            this.label32.TabIndex = 1;
            this.label32.Text = "門禁";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label33.Location = new System.Drawing.Point(257, 23);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(56, 16);
            this.label33.TabIndex = 1;
            this.label33.Text = "累積雨量";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label43.Location = new System.Drawing.Point(10, 162);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(60, 16);
            this.label43.TabIndex = 1;
            this.label43.Text = "CH7(DI7)";
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label39.Location = new System.Drawing.Point(10, 72);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(60, 16);
            this.label39.TabIndex = 1;
            this.label39.Text = "CH3(DI3)";
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label31.Location = new System.Drawing.Point(10, 251);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(67, 16);
            this.label31.TabIndex = 1;
            this.label31.Text = "CH11(AI3)";
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label42.Location = new System.Drawing.Point(142, 162);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(60, 16);
            this.label42.TabIndex = 1;
            this.label42.Text = "CH8(DI8)";
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label38.Location = new System.Drawing.Point(142, 72);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(60, 16);
            this.label38.TabIndex = 1;
            this.label38.Text = "CH4(DI4)";
            // 
            // label35
            // 
            this.label35.AutoSize = true;
            this.label35.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label35.Location = new System.Drawing.Point(142, 251);
            this.label35.Name = "label35";
            this.label35.Size = new System.Drawing.Size(67, 16);
            this.label35.TabIndex = 1;
            this.label35.Text = "CH12(AI4)";
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label41.Location = new System.Drawing.Point(142, 117);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 16);
            this.label41.TabIndex = 1;
            this.label41.Text = "CH6(DI6)";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label37.Location = new System.Drawing.Point(142, 23);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(60, 16);
            this.label37.TabIndex = 1;
            this.label37.Text = "CH2(DI2)";
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label30.Location = new System.Drawing.Point(142, 207);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(67, 16);
            this.label30.TabIndex = 1;
            this.label30.Text = "CH10(AI2)";
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label40.Location = new System.Drawing.Point(10, 117);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(60, 16);
            this.label40.TabIndex = 1;
            this.label40.Text = "CH5(DI5)";
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label36.Location = new System.Drawing.Point(10, 23);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(60, 16);
            this.label36.TabIndex = 1;
            this.label36.Text = "CH1(DI1)";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label29.Location = new System.Drawing.Point(10, 206);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(60, 16);
            this.label29.TabIndex = 1;
            this.label29.Text = "CH9(AI1)";
            // 
            // txtCH5
            // 
            this.txtCH5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH5.Location = new System.Drawing.Point(6, 136);
            this.txtCH5.Name = "txtCH5";
            this.txtCH5.ReadOnly = true;
            this.txtCH5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH5.Size = new System.Drawing.Size(109, 23);
            this.txtCH5.TabIndex = 10;
            this.txtCH5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH1
            // 
            this.txtCH1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH1.Location = new System.Drawing.Point(6, 42);
            this.txtCH1.Name = "txtCH1";
            this.txtCH1.ReadOnly = true;
            this.txtCH1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH1.Size = new System.Drawing.Size(109, 23);
            this.txtCH1.TabIndex = 10;
            this.txtCH1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH9
            // 
            this.txtCH9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH9.Location = new System.Drawing.Point(6, 225);
            this.txtCH9.Name = "txtCH9";
            this.txtCH9.ReadOnly = true;
            this.txtCH9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH9.Size = new System.Drawing.Size(109, 23);
            this.txtCH9.TabIndex = 10;
            this.txtCH9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnContinue
            // 
            this.btnContinue.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnContinue.Location = new System.Drawing.Point(266, 206);
            this.btnContinue.Name = "btnContinue";
            this.btnContinue.Size = new System.Drawing.Size(83, 31);
            this.btnContinue.TabIndex = 0;
            this.btnContinue.Text = "連續讀AI值";
            this.btnContinue.UseVisualStyleBackColor = true;
            this.btnContinue.Click += new System.EventHandler(this.btnContinue_Click);
            // 
            // btnClrAIV
            // 
            this.btnClrAIV.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClrAIV.Location = new System.Drawing.Point(266, 257);
            this.btnClrAIV.Name = "btnClrAIV";
            this.btnClrAIV.Size = new System.Drawing.Size(83, 31);
            this.btnClrAIV.TabIndex = 0;
            this.btnClrAIV.Text = "清除讀值";
            this.btnClrAIV.UseVisualStyleBackColor = true;
            this.btnClrAIV.Visible = false;
            this.btnClrAIV.Click += new System.EventHandler(this.btnReadAI_Click);
            // 
            // btnReadAI
            // 
            this.btnReadAI.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadAI.Location = new System.Drawing.Point(266, 149);
            this.btnReadAI.Name = "btnReadAI";
            this.btnReadAI.Size = new System.Drawing.Size(83, 39);
            this.btnReadAI.TabIndex = 0;
            this.btnReadAI.Text = "讀取計算值";
            this.btnReadAI.UseVisualStyleBackColor = true;
            this.btnReadAI.Click += new System.EventHandler(this.btnReadAI_Click);
            // 
            // txtDoor
            // 
            this.txtDoor.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDoor.Location = new System.Drawing.Point(260, 91);
            this.txtDoor.Name = "txtDoor";
            this.txtDoor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDoor.Size = new System.Drawing.Size(23, 23);
            this.txtDoor.TabIndex = 10;
            this.txtDoor.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH3
            // 
            this.txtCH3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH3.Location = new System.Drawing.Point(6, 91);
            this.txtCH3.Name = "txtCH3";
            this.txtCH3.ReadOnly = true;
            this.txtCH3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH3.Size = new System.Drawing.Size(109, 23);
            this.txtCH3.TabIndex = 10;
            this.txtCH3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH7
            // 
            this.txtCH7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH7.Location = new System.Drawing.Point(6, 181);
            this.txtCH7.Name = "txtCH7";
            this.txtCH7.ReadOnly = true;
            this.txtCH7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH7.Size = new System.Drawing.Size(109, 23);
            this.txtCH7.TabIndex = 10;
            this.txtCH7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRain
            // 
            this.txtRain.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRain.Location = new System.Drawing.Point(256, 42);
            this.txtRain.Name = "txtRain";
            this.txtRain.ReadOnly = true;
            this.txtRain.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRain.Size = new System.Drawing.Size(99, 23);
            this.txtRain.TabIndex = 10;
            this.txtRain.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCH11
            // 
            this.txtCH11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCH11.Location = new System.Drawing.Point(6, 270);
            this.txtCH11.Name = "txtCH11";
            this.txtCH11.ReadOnly = true;
            this.txtCH11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCH11.Size = new System.Drawing.Size(109, 23);
            this.txtCH11.TabIndex = 10;
            this.txtCH11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtCalAIV);
            this.groupBox5.Controls.Add(this.radAI1);
            this.groupBox5.Controls.Add(this.radAI3);
            this.groupBox5.Controls.Add(this.btnCalAI);
            this.groupBox5.Controls.Add(this.radAI4);
            this.groupBox5.Controls.Add(this.radAI2);
            this.groupBox5.Location = new System.Drawing.Point(9, 99);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(367, 88);
            this.groupBox5.TabIndex = 14;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "AI 校正";
            // 
            // txtCalAIV
            // 
            this.txtCalAIV.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCalAIV.Location = new System.Drawing.Point(44, 49);
            this.txtCalAIV.MaxLength = 7;
            this.txtCalAIV.Name = "txtCalAIV";
            this.txtCalAIV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCalAIV.Size = new System.Drawing.Size(194, 23);
            this.txtCalAIV.TabIndex = 10;
            this.txtCalAIV.Text = "5.0000";
            this.txtCalAIV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // radAI1
            // 
            this.radAI1.AutoSize = true;
            this.radAI1.Checked = true;
            this.radAI1.Location = new System.Drawing.Point(44, 23);
            this.radAI1.Name = "radAI1";
            this.radAI1.Size = new System.Drawing.Size(44, 20);
            this.radAI1.TabIndex = 12;
            this.radAI1.TabStop = true;
            this.radAI1.Text = "AI1";
            this.radAI1.UseVisualStyleBackColor = true;
            // 
            // radAI3
            // 
            this.radAI3.AutoSize = true;
            this.radAI3.Location = new System.Drawing.Point(144, 23);
            this.radAI3.Name = "radAI3";
            this.radAI3.Size = new System.Drawing.Size(44, 20);
            this.radAI3.TabIndex = 12;
            this.radAI3.Text = "AI3";
            this.radAI3.UseVisualStyleBackColor = true;
            // 
            // btnCalAI
            // 
            this.btnCalAI.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalAI.Location = new System.Drawing.Point(256, 22);
            this.btnCalAI.Name = "btnCalAI";
            this.btnCalAI.Size = new System.Drawing.Size(93, 50);
            this.btnCalAI.TabIndex = 0;
            this.btnCalAI.Text = "校正AI電壓";
            this.btnCalAI.UseVisualStyleBackColor = true;
            this.btnCalAI.Click += new System.EventHandler(this.btnCalAI_Click);
            // 
            // radAI4
            // 
            this.radAI4.AutoSize = true;
            this.radAI4.Location = new System.Drawing.Point(194, 23);
            this.radAI4.Name = "radAI4";
            this.radAI4.Size = new System.Drawing.Size(44, 20);
            this.radAI4.TabIndex = 12;
            this.radAI4.Text = "AI4";
            this.radAI4.UseVisualStyleBackColor = true;
            // 
            // radAI2
            // 
            this.radAI2.AutoSize = true;
            this.radAI2.Location = new System.Drawing.Point(97, 23);
            this.radAI2.Name = "radAI2";
            this.radAI2.Size = new System.Drawing.Size(44, 20);
            this.radAI2.TabIndex = 12;
            this.radAI2.Text = "AI2";
            this.radAI2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtBatV);
            this.groupBox4.Controls.Add(this.txtCalBatV);
            this.groupBox4.Controls.Add(this.label34);
            this.groupBox4.Controls.Add(this.label21);
            this.groupBox4.Controls.Add(this.btnReadBat);
            this.groupBox4.Controls.Add(this.btnCalBat);
            this.groupBox4.Location = new System.Drawing.Point(9, 7);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(367, 86);
            this.groupBox4.TabIndex = 13;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "電池電壓校正";
            // 
            // txtBatV
            // 
            this.txtBatV.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBatV.Location = new System.Drawing.Point(74, 54);
            this.txtBatV.Name = "txtBatV";
            this.txtBatV.ReadOnly = true;
            this.txtBatV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBatV.Size = new System.Drawing.Size(109, 23);
            this.txtBatV.TabIndex = 10;
            this.txtBatV.Text = "12.00";
            this.txtBatV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCalBatV
            // 
            this.txtCalBatV.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCalBatV.Location = new System.Drawing.Point(74, 25);
            this.txtCalBatV.MaxLength = 5;
            this.txtCalBatV.Name = "txtCalBatV";
            this.txtCalBatV.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCalBatV.Size = new System.Drawing.Size(109, 23);
            this.txtCalBatV.TabIndex = 10;
            this.txtCalBatV.Text = "12.00";
            this.txtCalBatV.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label34.Location = new System.Drawing.Point(12, 57);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(56, 16);
            this.label34.TabIndex = 1;
            this.label34.Text = "讀取電壓";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label21.Location = new System.Drawing.Point(12, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 16);
            this.label21.TabIndex = 1;
            this.label21.Text = "校準電壓";
            // 
            // btnReadBat
            // 
            this.btnReadBat.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadBat.Location = new System.Drawing.Point(197, 54);
            this.btnReadBat.Name = "btnReadBat";
            this.btnReadBat.Size = new System.Drawing.Size(116, 23);
            this.btnReadBat.TabIndex = 0;
            this.btnReadBat.Text = "讀取電池電壓";
            this.btnReadBat.UseVisualStyleBackColor = true;
            this.btnReadBat.Click += new System.EventHandler(this.btnCalBat_Click);
            // 
            // btnCalBat
            // 
            this.btnCalBat.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnCalBat.Location = new System.Drawing.Point(197, 24);
            this.btnCalBat.Name = "btnCalBat";
            this.btnCalBat.Size = new System.Drawing.Size(116, 24);
            this.btnCalBat.TabIndex = 0;
            this.btnCalBat.Text = "校正電池電壓";
            this.btnCalBat.UseVisualStyleBackColor = true;
            this.btnCalBat.Click += new System.EventHandler(this.btnCalBat_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.boxType8);
            this.tabPage1.Controls.Add(this.boxType7);
            this.tabPage1.Controls.Add(this.boxType6);
            this.tabPage1.Controls.Add(this.boxType5);
            this.tabPage1.Controls.Add(this.boxType4);
            this.tabPage1.Controls.Add(this.boxType3);
            this.tabPage1.Controls.Add(this.boxType2);
            this.tabPage1.Controls.Add(this.cbobaud);
            this.tabPage1.Controls.Add(this.boxType1);
            this.tabPage1.Controls.Add(this.boxData8);
            this.tabPage1.Controls.Add(this.boxID8);
            this.tabPage1.Controls.Add(this.boxData7);
            this.tabPage1.Controls.Add(this.boxData6);
            this.tabPage1.Controls.Add(this.btnReadType);
            this.tabPage1.Controls.Add(this.btnSetType);
            this.tabPage1.Controls.Add(this.boxID7);
            this.tabPage1.Controls.Add(this.boxData5);
            this.tabPage1.Controls.Add(this.boxID6);
            this.tabPage1.Controls.Add(this.boxData4);
            this.tabPage1.Controls.Add(this.boxID5);
            this.tabPage1.Controls.Add(this.boxData3);
            this.tabPage1.Controls.Add(this.boxID4);
            this.tabPage1.Controls.Add(this.boxData2);
            this.tabPage1.Controls.Add(this.boxID3);
            this.tabPage1.Controls.Add(this.boxID2);
            this.tabPage1.Controls.Add(this.label59);
            this.tabPage1.Controls.Add(this.label57);
            this.tabPage1.Controls.Add(this.label56);
            this.tabPage1.Controls.Add(this.label53);
            this.tabPage1.Controls.Add(this.label55);
            this.tabPage1.Controls.Add(this.label52);
            this.tabPage1.Controls.Add(this.label54);
            this.tabPage1.Controls.Add(this.label51);
            this.tabPage1.Controls.Add(this.label50);
            this.tabPage1.Controls.Add(this.label58);
            this.tabPage1.Controls.Add(this.label49);
            this.tabPage1.Controls.Add(this.boxData1);
            this.tabPage1.Controls.Add(this.label90);
            this.tabPage1.Controls.Add(this.label89);
            this.tabPage1.Controls.Add(this.label88);
            this.tabPage1.Controls.Add(this.label48);
            this.tabPage1.Controls.Add(this.boxID1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(424, 504);
            this.tabPage1.TabIndex = 5;
            this.tabPage1.Text = "TYPE設定";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // boxType8
            // 
            this.boxType8.FormattingEnabled = true;
            this.boxType8.Location = new System.Drawing.Point(55, 257);
            this.boxType8.Name = "boxType8";
            this.boxType8.Size = new System.Drawing.Size(88, 24);
            this.boxType8.TabIndex = 0;
            this.boxType8.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType7
            // 
            this.boxType7.FormattingEnabled = true;
            this.boxType7.Location = new System.Drawing.Point(55, 227);
            this.boxType7.Name = "boxType7";
            this.boxType7.Size = new System.Drawing.Size(88, 24);
            this.boxType7.TabIndex = 0;
            this.boxType7.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType6
            // 
            this.boxType6.FormattingEnabled = true;
            this.boxType6.Location = new System.Drawing.Point(55, 197);
            this.boxType6.Name = "boxType6";
            this.boxType6.Size = new System.Drawing.Size(88, 24);
            this.boxType6.TabIndex = 0;
            this.boxType6.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType5
            // 
            this.boxType5.FormattingEnabled = true;
            this.boxType5.Location = new System.Drawing.Point(55, 166);
            this.boxType5.Name = "boxType5";
            this.boxType5.Size = new System.Drawing.Size(88, 24);
            this.boxType5.TabIndex = 0;
            this.boxType5.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType4
            // 
            this.boxType4.FormattingEnabled = true;
            this.boxType4.Location = new System.Drawing.Point(55, 136);
            this.boxType4.Name = "boxType4";
            this.boxType4.Size = new System.Drawing.Size(88, 24);
            this.boxType4.TabIndex = 0;
            this.boxType4.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType3
            // 
            this.boxType3.FormattingEnabled = true;
            this.boxType3.Location = new System.Drawing.Point(55, 106);
            this.boxType3.Name = "boxType3";
            this.boxType3.Size = new System.Drawing.Size(88, 24);
            this.boxType3.TabIndex = 0;
            this.boxType3.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxType2
            // 
            this.boxType2.FormattingEnabled = true;
            this.boxType2.Location = new System.Drawing.Point(55, 76);
            this.boxType2.Name = "boxType2";
            this.boxType2.Size = new System.Drawing.Size(88, 24);
            this.boxType2.TabIndex = 0;
            this.boxType2.Text = "NULL";
            this.boxType2.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // cbobaud
            // 
            this.cbobaud.FormattingEnabled = true;
            this.cbobaud.Items.AddRange(new object[] {
            "9600",
            "19200",
            "38400",
            "57600"});
            this.cbobaud.Location = new System.Drawing.Point(81, 296);
            this.cbobaud.Name = "cbobaud";
            this.cbobaud.Size = new System.Drawing.Size(88, 24);
            this.cbobaud.TabIndex = 0;
            this.cbobaud.Text = "9600";
            // 
            // boxType1
            // 
            this.boxType1.FormattingEnabled = true;
            this.boxType1.Items.AddRange(new object[] {
            "NULL",
            "土壤水份",
            "PH",
            "傾斜計",
            "CDT"});
            this.boxType1.Location = new System.Drawing.Point(55, 46);
            this.boxType1.Name = "boxType1";
            this.boxType1.Size = new System.Drawing.Size(88, 24);
            this.boxType1.TabIndex = 0;
            this.boxType1.Text = "NULL";
            this.boxType1.SelectedIndexChanged += new System.EventHandler(this.boxType1_SelectedIndexChanged);
            // 
            // boxData8
            // 
            this.boxData8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData8.Location = new System.Drawing.Point(254, 256);
            this.boxData8.Name = "boxData8";
            this.boxData8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData8.Size = new System.Drawing.Size(67, 23);
            this.boxData8.TabIndex = 10;
            this.boxData8.Text = "0";
            this.boxData8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID8
            // 
            this.boxID8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID8.Location = new System.Drawing.Point(164, 258);
            this.boxID8.MaxLength = 3;
            this.boxID8.Name = "boxID8";
            this.boxID8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID8.Size = new System.Drawing.Size(67, 23);
            this.boxID8.TabIndex = 10;
            this.boxID8.Text = "0";
            this.boxID8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData7
            // 
            this.boxData7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData7.Location = new System.Drawing.Point(254, 227);
            this.boxData7.Name = "boxData7";
            this.boxData7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData7.Size = new System.Drawing.Size(67, 23);
            this.boxData7.TabIndex = 10;
            this.boxData7.Text = "0";
            this.boxData7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData6
            // 
            this.boxData6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData6.Location = new System.Drawing.Point(254, 195);
            this.boxData6.Name = "boxData6";
            this.boxData6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData6.Size = new System.Drawing.Size(67, 23);
            this.boxData6.TabIndex = 10;
            this.boxData6.Text = "0";
            this.boxData6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReadType
            // 
            this.btnReadType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadType.Location = new System.Drawing.Point(231, 341);
            this.btnReadType.Name = "btnReadType";
            this.btnReadType.Size = new System.Drawing.Size(90, 36);
            this.btnReadType.TabIndex = 0;
            this.btnReadType.Text = "讀取TYPE";
            this.btnReadType.UseVisualStyleBackColor = true;
            this.btnReadType.Click += new System.EventHandler(this.btnSetType_Click);
            // 
            // btnSetType
            // 
            this.btnSetType.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSetType.Location = new System.Drawing.Point(231, 299);
            this.btnSetType.Name = "btnSetType";
            this.btnSetType.Size = new System.Drawing.Size(90, 36);
            this.btnSetType.TabIndex = 0;
            this.btnSetType.Text = "設定TYPE";
            this.btnSetType.UseVisualStyleBackColor = true;
            this.btnSetType.Click += new System.EventHandler(this.btnSetType_Click);
            // 
            // boxID7
            // 
            this.boxID7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID7.Location = new System.Drawing.Point(164, 227);
            this.boxID7.MaxLength = 3;
            this.boxID7.Name = "boxID7";
            this.boxID7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID7.Size = new System.Drawing.Size(67, 23);
            this.boxID7.TabIndex = 10;
            this.boxID7.Text = "0";
            this.boxID7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData5
            // 
            this.boxData5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData5.Location = new System.Drawing.Point(254, 166);
            this.boxData5.Name = "boxData5";
            this.boxData5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData5.Size = new System.Drawing.Size(67, 23);
            this.boxData5.TabIndex = 10;
            this.boxData5.Text = "0";
            this.boxData5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID6
            // 
            this.boxID6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID6.Location = new System.Drawing.Point(164, 197);
            this.boxID6.MaxLength = 3;
            this.boxID6.Name = "boxID6";
            this.boxID6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID6.Size = new System.Drawing.Size(67, 23);
            this.boxID6.TabIndex = 10;
            this.boxID6.Text = "0";
            this.boxID6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData4
            // 
            this.boxData4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData4.Location = new System.Drawing.Point(254, 135);
            this.boxData4.Name = "boxData4";
            this.boxData4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData4.Size = new System.Drawing.Size(67, 23);
            this.boxData4.TabIndex = 10;
            this.boxData4.Text = "0";
            this.boxData4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID5
            // 
            this.boxID5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID5.Location = new System.Drawing.Point(164, 168);
            this.boxID5.MaxLength = 3;
            this.boxID5.Name = "boxID5";
            this.boxID5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID5.Size = new System.Drawing.Size(67, 23);
            this.boxID5.TabIndex = 10;
            this.boxID5.Text = "0";
            this.boxID5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData3
            // 
            this.boxData3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData3.Location = new System.Drawing.Point(254, 106);
            this.boxData3.Name = "boxData3";
            this.boxData3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData3.Size = new System.Drawing.Size(67, 23);
            this.boxData3.TabIndex = 10;
            this.boxData3.Text = "0";
            this.boxData3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID4
            // 
            this.boxID4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID4.Location = new System.Drawing.Point(164, 137);
            this.boxID4.MaxLength = 3;
            this.boxID4.Name = "boxID4";
            this.boxID4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID4.Size = new System.Drawing.Size(67, 23);
            this.boxID4.TabIndex = 10;
            this.boxID4.Text = "0";
            this.boxID4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxData2
            // 
            this.boxData2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData2.Location = new System.Drawing.Point(254, 77);
            this.boxData2.Name = "boxData2";
            this.boxData2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData2.Size = new System.Drawing.Size(67, 23);
            this.boxData2.TabIndex = 10;
            this.boxData2.Text = "0";
            this.boxData2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID3
            // 
            this.boxID3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID3.Location = new System.Drawing.Point(164, 106);
            this.boxID3.MaxLength = 3;
            this.boxID3.Name = "boxID3";
            this.boxID3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID3.Size = new System.Drawing.Size(67, 23);
            this.boxID3.TabIndex = 10;
            this.boxID3.Text = "0";
            this.boxID3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // boxID2
            // 
            this.boxID2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID2.Location = new System.Drawing.Point(164, 77);
            this.boxID2.MaxLength = 3;
            this.boxID2.Name = "boxID2";
            this.boxID2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID2.Size = new System.Drawing.Size(67, 23);
            this.boxID2.TabIndex = 10;
            this.boxID2.Text = "0";
            this.boxID2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label59
            // 
            this.label59.AutoSize = true;
            this.label59.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label59.Location = new System.Drawing.Point(17, 299);
            this.label59.Name = "label59";
            this.label59.Size = new System.Drawing.Size(58, 16);
            this.label59.TabIndex = 1;
            this.label59.Text = "baudrae";
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label57.Location = new System.Drawing.Point(17, 260);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(32, 16);
            this.label57.TabIndex = 1;
            this.label57.Text = "CH8";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label56.Location = new System.Drawing.Point(17, 230);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(32, 16);
            this.label56.TabIndex = 1;
            this.label56.Text = "CH7";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label53.Location = new System.Drawing.Point(18, 139);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(32, 16);
            this.label53.TabIndex = 1;
            this.label53.Text = "CH4";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label55.Location = new System.Drawing.Point(17, 200);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(32, 16);
            this.label55.TabIndex = 1;
            this.label55.Text = "CH6";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label52.Location = new System.Drawing.Point(18, 109);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(32, 16);
            this.label52.TabIndex = 1;
            this.label52.Text = "CH3";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label54.Location = new System.Drawing.Point(17, 171);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(32, 16);
            this.label54.TabIndex = 1;
            this.label54.Text = "CH5";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label51.Location = new System.Drawing.Point(18, 79);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(32, 16);
            this.label51.TabIndex = 1;
            this.label51.Text = "CH2";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label50.Location = new System.Drawing.Point(18, 50);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(32, 16);
            this.label50.TabIndex = 1;
            this.label50.Text = "CH1";
            // 
            // label58
            // 
            this.label58.AutoSize = true;
            this.label58.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label58.Location = new System.Drawing.Point(261, 27);
            this.label58.Name = "label58";
            this.label58.Size = new System.Drawing.Size(100, 16);
            this.label58.TabIndex = 1;
            this.label58.Text = "資料欄位(二進制)";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label49.Location = new System.Drawing.Point(186, 27);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(21, 16);
            this.label49.TabIndex = 1;
            this.label49.Text = "ID";
            // 
            // boxData1
            // 
            this.boxData1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxData1.Location = new System.Drawing.Point(254, 47);
            this.boxData1.Name = "boxData1";
            this.boxData1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxData1.Size = new System.Drawing.Size(67, 23);
            this.boxData1.TabIndex = 10;
            this.boxData1.Text = "0";
            this.boxData1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label90
            // 
            this.label90.AutoSize = true;
            this.label90.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label90.Location = new System.Drawing.Point(38, 424);
            this.label90.Name = "label90";
            this.label90.Size = new System.Drawing.Size(208, 16);
            this.label90.TabIndex = 1;
            this.label90.Text = "傾斜計   ：電池電壓、溫度、Z、Y、X";
            // 
            // label89
            // 
            this.label89.AutoSize = true;
            this.label89.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label89.Location = new System.Drawing.Point(38, 408);
            this.label89.Name = "label89";
            this.label89.Size = new System.Drawing.Size(120, 16);
            this.label89.TabIndex = 1;
            this.label89.Text = "PH          ：PH、溫度";
            // 
            // label88
            // 
            this.label88.AutoSize = true;
            this.label88.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label88.Location = new System.Drawing.Point(38, 392);
            this.label88.Name = "label88";
            this.label88.Size = new System.Drawing.Size(221, 16);
            this.label88.TabIndex = 1;
            this.label88.Text = "土壤水份 : 介電常數、容積含水率、溫度";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label48.Location = new System.Drawing.Point(68, 27);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(37, 16);
            this.label48.TabIndex = 1;
            this.label48.Text = "TYPE";
            // 
            // boxID1
            // 
            this.boxID1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxID1.Location = new System.Drawing.Point(164, 47);
            this.boxID1.MaxLength = 3;
            this.boxID1.Name = "boxID1";
            this.boxID1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxID1.Size = new System.Drawing.Size(67, 23);
            this.boxID1.TabIndex = 10;
            this.boxID1.Text = "0";
            this.boxID1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tabCHG
            // 
            this.tabCHG.Controls.Add(this.boxRain);
            this.tabCHG.Controls.Add(this.txtCch12);
            this.tabCHG.Controls.Add(this.txtCch8);
            this.tabCHG.Controls.Add(this.txtCch4);
            this.tabCHG.Controls.Add(this.txtCch11);
            this.tabCHG.Controls.Add(this.txtCch7);
            this.tabCHG.Controls.Add(this.txtCch3);
            this.tabCHG.Controls.Add(this.txtCch10);
            this.tabCHG.Controls.Add(this.txtCch6);
            this.tabCHG.Controls.Add(this.txtCch2);
            this.tabCHG.Controls.Add(this.txtCch9);
            this.tabCHG.Controls.Add(this.txtCch5);
            this.tabCHG.Controls.Add(this.txtCch1);
            this.tabCHG.Controls.Add(this.btnSCHG);
            this.tabCHG.Controls.Add(this.btnRCHG);
            this.tabCHG.Controls.Add(this.txtMch12);
            this.tabCHG.Controls.Add(this.txtXch12);
            this.tabCHG.Controls.Add(this.txtDch12);
            this.tabCHG.Controls.Add(this.txtMch8);
            this.tabCHG.Controls.Add(this.txtXch8);
            this.tabCHG.Controls.Add(this.txtDch8);
            this.tabCHG.Controls.Add(this.txtMch11);
            this.tabCHG.Controls.Add(this.txtXch11);
            this.tabCHG.Controls.Add(this.txtMch4);
            this.tabCHG.Controls.Add(this.txtXch4);
            this.tabCHG.Controls.Add(this.txtMch7);
            this.tabCHG.Controls.Add(this.txtXch7);
            this.tabCHG.Controls.Add(this.txtDch11);
            this.tabCHG.Controls.Add(this.txtDch4);
            this.tabCHG.Controls.Add(this.txtDch7);
            this.tabCHG.Controls.Add(this.txtMch10);
            this.tabCHG.Controls.Add(this.txtXch10);
            this.tabCHG.Controls.Add(this.txtMch3);
            this.tabCHG.Controls.Add(this.txtXch3);
            this.tabCHG.Controls.Add(this.txtMch6);
            this.tabCHG.Controls.Add(this.txtXch6);
            this.tabCHG.Controls.Add(this.txtRch12);
            this.tabCHG.Controls.Add(this.txtDch3);
            this.tabCHG.Controls.Add(this.txtRch8);
            this.tabCHG.Controls.Add(this.txtDch10);
            this.tabCHG.Controls.Add(this.txtMch2);
            this.tabCHG.Controls.Add(this.txtXch2);
            this.tabCHG.Controls.Add(this.txtDch6);
            this.tabCHG.Controls.Add(this.txtRch11);
            this.tabCHG.Controls.Add(this.txtRch4);
            this.tabCHG.Controls.Add(this.txtRch7);
            this.tabCHG.Controls.Add(this.txtMch9);
            this.tabCHG.Controls.Add(this.txtXch9);
            this.tabCHG.Controls.Add(this.txtDch2);
            this.tabCHG.Controls.Add(this.txtMch5);
            this.tabCHG.Controls.Add(this.txtXch5);
            this.tabCHG.Controls.Add(this.txtLch12);
            this.tabCHG.Controls.Add(this.txtRch3);
            this.tabCHG.Controls.Add(this.txtLch8);
            this.tabCHG.Controls.Add(this.txtRch10);
            this.tabCHG.Controls.Add(this.txtMch1);
            this.tabCHG.Controls.Add(this.txtXch1);
            this.tabCHG.Controls.Add(this.txtRch6);
            this.tabCHG.Controls.Add(this.txtLch11);
            this.tabCHG.Controls.Add(this.txtLch4);
            this.tabCHG.Controls.Add(this.txtLch7);
            this.tabCHG.Controls.Add(this.txtDch9);
            this.tabCHG.Controls.Add(this.txtRch2);
            this.tabCHG.Controls.Add(this.txtDch5);
            this.tabCHG.Controls.Add(this.txtBPch12);
            this.tabCHG.Controls.Add(this.txtLch3);
            this.tabCHG.Controls.Add(this.txtBPch8);
            this.tabCHG.Controls.Add(this.txtLch10);
            this.tabCHG.Controls.Add(this.txtDch1);
            this.tabCHG.Controls.Add(this.txtLch6);
            this.tabCHG.Controls.Add(this.txtBPch11);
            this.tabCHG.Controls.Add(this.txtBPch4);
            this.tabCHG.Controls.Add(this.txtBPch7);
            this.tabCHG.Controls.Add(this.txtRch9);
            this.tabCHG.Controls.Add(this.txtLch2);
            this.tabCHG.Controls.Add(this.txtRch5);
            this.tabCHG.Controls.Add(this.txtBPch10);
            this.tabCHG.Controls.Add(this.txtBPch3);
            this.tabCHG.Controls.Add(this.txtBPch6);
            this.tabCHG.Controls.Add(this.txtLch9);
            this.tabCHG.Controls.Add(this.txtRch1);
            this.tabCHG.Controls.Add(this.txtLch5);
            this.tabCHG.Controls.Add(this.txtBPch9);
            this.tabCHG.Controls.Add(this.txtBPch2);
            this.tabCHG.Controls.Add(this.txtBPch5);
            this.tabCHG.Controls.Add(this.txtLch1);
            this.tabCHG.Controls.Add(this.txtBPch1);
            this.tabCHG.Controls.Add(this.label92);
            this.tabCHG.Controls.Add(this.label91);
            this.tabCHG.Controls.Add(this.label77);
            this.tabCHG.Controls.Add(this.label76);
            this.tabCHG.Controls.Add(this.label44);
            this.tabCHG.Controls.Add(this.label65);
            this.tabCHG.Controls.Add(this.label72);
            this.tabCHG.Controls.Add(this.label);
            this.tabCHG.Controls.Add(this.label75);
            this.tabCHG.Controls.Add(this.label68);
            this.tabCHG.Controls.Add(this.label71);
            this.tabCHG.Controls.Add(this.label63);
            this.tabCHG.Controls.Add(this.label74);
            this.tabCHG.Controls.Add(this.label67);
            this.tabCHG.Controls.Add(this.label70);
            this.tabCHG.Controls.Add(this.label62);
            this.tabCHG.Controls.Add(this.label73);
            this.tabCHG.Controls.Add(this.label64);
            this.tabCHG.Controls.Add(this.label69);
            this.tabCHG.Controls.Add(this.label61);
            this.tabCHG.Controls.Add(this.label66);
            this.tabCHG.Controls.Add(this.label60);
            this.tabCHG.Location = new System.Drawing.Point(4, 25);
            this.tabCHG.Name = "tabCHG";
            this.tabCHG.Padding = new System.Windows.Forms.Padding(3);
            this.tabCHG.Size = new System.Drawing.Size(424, 504);
            this.tabCHG.TabIndex = 6;
            this.tabCHG.Text = "tabCHG";
            this.tabCHG.UseVisualStyleBackColor = true;
            // 
            // boxRain
            // 
            this.boxRain.AutoCompleteCustomSource.AddRange(new string[] {
            "9600",
            "19200",
            "57600",
            "115200"});
            this.boxRain.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxRain.FormattingEnabled = true;
            this.boxRain.Items.AddRange(new object[] {
            "0.5",
            "1.0"});
            this.boxRain.Location = new System.Drawing.Point(40, 385);
            this.boxRain.Name = "boxRain";
            this.boxRain.Size = new System.Drawing.Size(66, 24);
            this.boxRain.TabIndex = 7;
            this.boxRain.Text = "1.0";
            // 
            // txtCch12
            // 
            this.txtCch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch12.Location = new System.Drawing.Point(214, 347);
            this.txtCch12.MaxLength = 6;
            this.txtCch12.Name = "txtCch12";
            this.txtCch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch12.Size = new System.Drawing.Size(47, 23);
            this.txtCch12.TabIndex = 10;
            this.txtCch12.Text = "0.0000";
            this.txtCch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch8
            // 
            this.txtCch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch8.Location = new System.Drawing.Point(214, 230);
            this.txtCch8.MaxLength = 6;
            this.txtCch8.Name = "txtCch8";
            this.txtCch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch8.Size = new System.Drawing.Size(47, 23);
            this.txtCch8.TabIndex = 10;
            this.txtCch8.Text = "0.0000";
            this.txtCch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch4
            // 
            this.txtCch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch4.Location = new System.Drawing.Point(214, 112);
            this.txtCch4.MaxLength = 6;
            this.txtCch4.Name = "txtCch4";
            this.txtCch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch4.Size = new System.Drawing.Size(47, 23);
            this.txtCch4.TabIndex = 10;
            this.txtCch4.Text = "0.0000";
            this.txtCch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch11
            // 
            this.txtCch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch11.Location = new System.Drawing.Point(214, 318);
            this.txtCch11.MaxLength = 6;
            this.txtCch11.Name = "txtCch11";
            this.txtCch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch11.Size = new System.Drawing.Size(47, 23);
            this.txtCch11.TabIndex = 10;
            this.txtCch11.Text = "0.0000";
            this.txtCch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch7
            // 
            this.txtCch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch7.Location = new System.Drawing.Point(214, 201);
            this.txtCch7.MaxLength = 6;
            this.txtCch7.Name = "txtCch7";
            this.txtCch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch7.Size = new System.Drawing.Size(47, 23);
            this.txtCch7.TabIndex = 10;
            this.txtCch7.Text = "0.0000";
            this.txtCch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch3
            // 
            this.txtCch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch3.Location = new System.Drawing.Point(214, 83);
            this.txtCch3.MaxLength = 6;
            this.txtCch3.Name = "txtCch3";
            this.txtCch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch3.Size = new System.Drawing.Size(47, 23);
            this.txtCch3.TabIndex = 10;
            this.txtCch3.Text = "0.0000";
            this.txtCch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch10
            // 
            this.txtCch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch10.Location = new System.Drawing.Point(215, 289);
            this.txtCch10.MaxLength = 6;
            this.txtCch10.Name = "txtCch10";
            this.txtCch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch10.Size = new System.Drawing.Size(47, 23);
            this.txtCch10.TabIndex = 10;
            this.txtCch10.Text = "0.0000";
            this.txtCch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch6
            // 
            this.txtCch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch6.Location = new System.Drawing.Point(215, 172);
            this.txtCch6.MaxLength = 6;
            this.txtCch6.Name = "txtCch6";
            this.txtCch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch6.Size = new System.Drawing.Size(47, 23);
            this.txtCch6.TabIndex = 10;
            this.txtCch6.Text = "0.0000";
            this.txtCch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch2
            // 
            this.txtCch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch2.Location = new System.Drawing.Point(215, 54);
            this.txtCch2.MaxLength = 6;
            this.txtCch2.Name = "txtCch2";
            this.txtCch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch2.Size = new System.Drawing.Size(47, 23);
            this.txtCch2.TabIndex = 10;
            this.txtCch2.Text = "0.0000";
            this.txtCch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch9
            // 
            this.txtCch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch9.Location = new System.Drawing.Point(215, 260);
            this.txtCch9.MaxLength = 6;
            this.txtCch9.Name = "txtCch9";
            this.txtCch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch9.Size = new System.Drawing.Size(47, 23);
            this.txtCch9.TabIndex = 10;
            this.txtCch9.Text = "0.0000";
            this.txtCch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch5
            // 
            this.txtCch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch5.Location = new System.Drawing.Point(215, 143);
            this.txtCch5.MaxLength = 6;
            this.txtCch5.Name = "txtCch5";
            this.txtCch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch5.Size = new System.Drawing.Size(47, 23);
            this.txtCch5.TabIndex = 10;
            this.txtCch5.Text = "0.0000";
            this.txtCch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtCch1
            // 
            this.txtCch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtCch1.Location = new System.Drawing.Point(215, 25);
            this.txtCch1.MaxLength = 6;
            this.txtCch1.Name = "txtCch1";
            this.txtCch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtCch1.Size = new System.Drawing.Size(47, 23);
            this.txtCch1.TabIndex = 10;
            this.txtCch1.Text = "0.0000";
            this.txtCch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnSCHG
            // 
            this.btnSCHG.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSCHG.Location = new System.Drawing.Point(288, 399);
            this.btnSCHG.Name = "btnSCHG";
            this.btnSCHG.Size = new System.Drawing.Size(90, 36);
            this.btnSCHG.TabIndex = 0;
            this.btnSCHG.Text = "寫入通道參數";
            this.btnSCHG.UseVisualStyleBackColor = true;
            this.btnSCHG.Click += new System.EventHandler(this.btnSCHG_Click);
            // 
            // btnRCHG
            // 
            this.btnRCHG.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRCHG.Location = new System.Drawing.Point(287, 441);
            this.btnRCHG.Name = "btnRCHG";
            this.btnRCHG.Size = new System.Drawing.Size(90, 36);
            this.btnRCHG.TabIndex = 0;
            this.btnRCHG.Text = "讀取通道參數";
            this.btnRCHG.UseVisualStyleBackColor = true;
            this.btnRCHG.Click += new System.EventHandler(this.btnSCHG_Click);
            // 
            // txtMch12
            // 
            this.txtMch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch12.Location = new System.Drawing.Point(383, 347);
            this.txtMch12.MaxLength = 3;
            this.txtMch12.Name = "txtMch12";
            this.txtMch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch12.Size = new System.Drawing.Size(26, 23);
            this.txtMch12.TabIndex = 10;
            this.txtMch12.Text = "0";
            this.txtMch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch12
            // 
            this.txtXch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch12.Location = new System.Drawing.Point(330, 347);
            this.txtXch12.MaxLength = 6;
            this.txtXch12.Name = "txtXch12";
            this.txtXch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch12.Size = new System.Drawing.Size(47, 23);
            this.txtXch12.TabIndex = 10;
            this.txtXch12.Text = "0.0000";
            this.txtXch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch12
            // 
            this.txtDch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch12.Location = new System.Drawing.Point(272, 347);
            this.txtDch12.MaxLength = 6;
            this.txtDch12.Name = "txtDch12";
            this.txtDch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch12.Size = new System.Drawing.Size(47, 23);
            this.txtDch12.TabIndex = 10;
            this.txtDch12.Text = "1.0000";
            this.txtDch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch8
            // 
            this.txtMch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch8.Location = new System.Drawing.Point(383, 230);
            this.txtMch8.MaxLength = 3;
            this.txtMch8.Name = "txtMch8";
            this.txtMch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch8.Size = new System.Drawing.Size(26, 23);
            this.txtMch8.TabIndex = 10;
            this.txtMch8.Text = "0";
            this.txtMch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch8
            // 
            this.txtXch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch8.Location = new System.Drawing.Point(330, 230);
            this.txtXch8.MaxLength = 6;
            this.txtXch8.Name = "txtXch8";
            this.txtXch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch8.Size = new System.Drawing.Size(47, 23);
            this.txtXch8.TabIndex = 10;
            this.txtXch8.Text = "0.0000";
            this.txtXch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch8
            // 
            this.txtDch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch8.Location = new System.Drawing.Point(272, 230);
            this.txtDch8.MaxLength = 6;
            this.txtDch8.Name = "txtDch8";
            this.txtDch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch8.Size = new System.Drawing.Size(47, 23);
            this.txtDch8.TabIndex = 10;
            this.txtDch8.Text = "1.0000";
            this.txtDch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch11
            // 
            this.txtMch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch11.Location = new System.Drawing.Point(383, 318);
            this.txtMch11.MaxLength = 3;
            this.txtMch11.Name = "txtMch11";
            this.txtMch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch11.Size = new System.Drawing.Size(26, 23);
            this.txtMch11.TabIndex = 10;
            this.txtMch11.Text = "0";
            this.txtMch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch11
            // 
            this.txtXch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch11.Location = new System.Drawing.Point(330, 318);
            this.txtXch11.MaxLength = 6;
            this.txtXch11.Name = "txtXch11";
            this.txtXch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch11.Size = new System.Drawing.Size(47, 23);
            this.txtXch11.TabIndex = 10;
            this.txtXch11.Text = "0.0000";
            this.txtXch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch4
            // 
            this.txtMch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch4.Location = new System.Drawing.Point(383, 112);
            this.txtMch4.MaxLength = 3;
            this.txtMch4.Name = "txtMch4";
            this.txtMch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch4.Size = new System.Drawing.Size(26, 23);
            this.txtMch4.TabIndex = 10;
            this.txtMch4.Text = "0";
            this.txtMch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch4
            // 
            this.txtXch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch4.Location = new System.Drawing.Point(330, 112);
            this.txtXch4.MaxLength = 6;
            this.txtXch4.Name = "txtXch4";
            this.txtXch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch4.Size = new System.Drawing.Size(47, 23);
            this.txtXch4.TabIndex = 10;
            this.txtXch4.Text = "0.0000";
            this.txtXch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch7
            // 
            this.txtMch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch7.Location = new System.Drawing.Point(383, 201);
            this.txtMch7.MaxLength = 3;
            this.txtMch7.Name = "txtMch7";
            this.txtMch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch7.Size = new System.Drawing.Size(26, 23);
            this.txtMch7.TabIndex = 10;
            this.txtMch7.Text = "0";
            this.txtMch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch7
            // 
            this.txtXch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch7.Location = new System.Drawing.Point(330, 201);
            this.txtXch7.MaxLength = 6;
            this.txtXch7.Name = "txtXch7";
            this.txtXch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch7.Size = new System.Drawing.Size(47, 23);
            this.txtXch7.TabIndex = 10;
            this.txtXch7.Text = "0.0000";
            this.txtXch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch11
            // 
            this.txtDch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch11.Location = new System.Drawing.Point(272, 318);
            this.txtDch11.MaxLength = 6;
            this.txtDch11.Name = "txtDch11";
            this.txtDch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch11.Size = new System.Drawing.Size(47, 23);
            this.txtDch11.TabIndex = 10;
            this.txtDch11.Text = "1.0000";
            this.txtDch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch4
            // 
            this.txtDch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch4.Location = new System.Drawing.Point(272, 112);
            this.txtDch4.MaxLength = 6;
            this.txtDch4.Name = "txtDch4";
            this.txtDch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch4.Size = new System.Drawing.Size(47, 23);
            this.txtDch4.TabIndex = 10;
            this.txtDch4.Text = "1.0000";
            this.txtDch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch7
            // 
            this.txtDch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch7.Location = new System.Drawing.Point(272, 201);
            this.txtDch7.MaxLength = 6;
            this.txtDch7.Name = "txtDch7";
            this.txtDch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch7.Size = new System.Drawing.Size(47, 23);
            this.txtDch7.TabIndex = 10;
            this.txtDch7.Text = "1.0000";
            this.txtDch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch10
            // 
            this.txtMch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch10.Location = new System.Drawing.Point(384, 289);
            this.txtMch10.MaxLength = 3;
            this.txtMch10.Name = "txtMch10";
            this.txtMch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch10.Size = new System.Drawing.Size(26, 23);
            this.txtMch10.TabIndex = 10;
            this.txtMch10.Text = "0";
            this.txtMch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch10
            // 
            this.txtXch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch10.Location = new System.Drawing.Point(331, 289);
            this.txtXch10.MaxLength = 6;
            this.txtXch10.Name = "txtXch10";
            this.txtXch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch10.Size = new System.Drawing.Size(47, 23);
            this.txtXch10.TabIndex = 10;
            this.txtXch10.Text = "0.0000";
            this.txtXch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch3
            // 
            this.txtMch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch3.Location = new System.Drawing.Point(383, 83);
            this.txtMch3.MaxLength = 3;
            this.txtMch3.Name = "txtMch3";
            this.txtMch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch3.Size = new System.Drawing.Size(26, 23);
            this.txtMch3.TabIndex = 10;
            this.txtMch3.Text = "0";
            this.txtMch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch3
            // 
            this.txtXch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch3.Location = new System.Drawing.Point(330, 83);
            this.txtXch3.MaxLength = 6;
            this.txtXch3.Name = "txtXch3";
            this.txtXch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch3.Size = new System.Drawing.Size(47, 23);
            this.txtXch3.TabIndex = 10;
            this.txtXch3.Text = "0.0000";
            this.txtXch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch6
            // 
            this.txtMch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch6.Location = new System.Drawing.Point(384, 172);
            this.txtMch6.MaxLength = 3;
            this.txtMch6.Name = "txtMch6";
            this.txtMch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch6.Size = new System.Drawing.Size(26, 23);
            this.txtMch6.TabIndex = 10;
            this.txtMch6.Text = "0";
            this.txtMch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch6
            // 
            this.txtXch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch6.Location = new System.Drawing.Point(331, 172);
            this.txtXch6.MaxLength = 6;
            this.txtXch6.Name = "txtXch6";
            this.txtXch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch6.Size = new System.Drawing.Size(47, 23);
            this.txtXch6.TabIndex = 10;
            this.txtXch6.Text = "0.0000";
            this.txtXch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch12
            // 
            this.txtRch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch12.Location = new System.Drawing.Point(156, 347);
            this.txtRch12.MaxLength = 6;
            this.txtRch12.Name = "txtRch12";
            this.txtRch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch12.Size = new System.Drawing.Size(47, 23);
            this.txtRch12.TabIndex = 10;
            this.txtRch12.Text = "1.0000";
            this.txtRch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch3
            // 
            this.txtDch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch3.Location = new System.Drawing.Point(272, 83);
            this.txtDch3.MaxLength = 6;
            this.txtDch3.Name = "txtDch3";
            this.txtDch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch3.Size = new System.Drawing.Size(47, 23);
            this.txtDch3.TabIndex = 10;
            this.txtDch3.Text = "1.0000";
            this.txtDch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch8
            // 
            this.txtRch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch8.Location = new System.Drawing.Point(156, 230);
            this.txtRch8.MaxLength = 6;
            this.txtRch8.Name = "txtRch8";
            this.txtRch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch8.Size = new System.Drawing.Size(47, 23);
            this.txtRch8.TabIndex = 10;
            this.txtRch8.Text = "1.0000";
            this.txtRch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch10
            // 
            this.txtDch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch10.Location = new System.Drawing.Point(273, 289);
            this.txtDch10.MaxLength = 6;
            this.txtDch10.Name = "txtDch10";
            this.txtDch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch10.Size = new System.Drawing.Size(47, 23);
            this.txtDch10.TabIndex = 10;
            this.txtDch10.Text = "1.0000";
            this.txtDch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch2
            // 
            this.txtMch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch2.Location = new System.Drawing.Point(384, 54);
            this.txtMch2.MaxLength = 3;
            this.txtMch2.Name = "txtMch2";
            this.txtMch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch2.Size = new System.Drawing.Size(26, 23);
            this.txtMch2.TabIndex = 10;
            this.txtMch2.Text = "0";
            this.txtMch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch2
            // 
            this.txtXch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch2.Location = new System.Drawing.Point(331, 54);
            this.txtXch2.MaxLength = 6;
            this.txtXch2.Name = "txtXch2";
            this.txtXch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch2.Size = new System.Drawing.Size(47, 23);
            this.txtXch2.TabIndex = 10;
            this.txtXch2.Text = "0.0000";
            this.txtXch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch6
            // 
            this.txtDch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch6.Location = new System.Drawing.Point(273, 172);
            this.txtDch6.MaxLength = 6;
            this.txtDch6.Name = "txtDch6";
            this.txtDch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch6.Size = new System.Drawing.Size(47, 23);
            this.txtDch6.TabIndex = 10;
            this.txtDch6.Text = "1.0000";
            this.txtDch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch11
            // 
            this.txtRch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch11.Location = new System.Drawing.Point(156, 318);
            this.txtRch11.MaxLength = 6;
            this.txtRch11.Name = "txtRch11";
            this.txtRch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch11.Size = new System.Drawing.Size(47, 23);
            this.txtRch11.TabIndex = 10;
            this.txtRch11.Text = "1.0000";
            this.txtRch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch4
            // 
            this.txtRch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch4.Location = new System.Drawing.Point(156, 112);
            this.txtRch4.MaxLength = 6;
            this.txtRch4.Name = "txtRch4";
            this.txtRch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch4.Size = new System.Drawing.Size(47, 23);
            this.txtRch4.TabIndex = 10;
            this.txtRch4.Text = "1.0000";
            this.txtRch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch7
            // 
            this.txtRch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch7.Location = new System.Drawing.Point(156, 201);
            this.txtRch7.MaxLength = 6;
            this.txtRch7.Name = "txtRch7";
            this.txtRch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch7.Size = new System.Drawing.Size(47, 23);
            this.txtRch7.TabIndex = 10;
            this.txtRch7.Text = "1.0000";
            this.txtRch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch9
            // 
            this.txtMch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch9.Location = new System.Drawing.Point(384, 260);
            this.txtMch9.MaxLength = 3;
            this.txtMch9.Name = "txtMch9";
            this.txtMch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch9.Size = new System.Drawing.Size(26, 23);
            this.txtMch9.TabIndex = 10;
            this.txtMch9.Text = "0";
            this.txtMch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch9
            // 
            this.txtXch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch9.Location = new System.Drawing.Point(331, 260);
            this.txtXch9.MaxLength = 6;
            this.txtXch9.Name = "txtXch9";
            this.txtXch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch9.Size = new System.Drawing.Size(47, 23);
            this.txtXch9.TabIndex = 10;
            this.txtXch9.Text = "0.0000";
            this.txtXch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch2
            // 
            this.txtDch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch2.Location = new System.Drawing.Point(273, 54);
            this.txtDch2.MaxLength = 6;
            this.txtDch2.Name = "txtDch2";
            this.txtDch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch2.Size = new System.Drawing.Size(47, 23);
            this.txtDch2.TabIndex = 10;
            this.txtDch2.Text = "1.0000";
            this.txtDch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch5
            // 
            this.txtMch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch5.Location = new System.Drawing.Point(384, 143);
            this.txtMch5.MaxLength = 3;
            this.txtMch5.Name = "txtMch5";
            this.txtMch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch5.Size = new System.Drawing.Size(26, 23);
            this.txtMch5.TabIndex = 10;
            this.txtMch5.Text = "0";
            this.txtMch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch5
            // 
            this.txtXch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch5.Location = new System.Drawing.Point(331, 143);
            this.txtXch5.MaxLength = 6;
            this.txtXch5.Name = "txtXch5";
            this.txtXch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch5.Size = new System.Drawing.Size(47, 23);
            this.txtXch5.TabIndex = 10;
            this.txtXch5.Text = "0.0000";
            this.txtXch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch12
            // 
            this.txtLch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch12.Location = new System.Drawing.Point(98, 347);
            this.txtLch12.MaxLength = 6;
            this.txtLch12.Name = "txtLch12";
            this.txtLch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch12.Size = new System.Drawing.Size(47, 23);
            this.txtLch12.TabIndex = 10;
            this.txtLch12.Text = "0.0000";
            this.txtLch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch3
            // 
            this.txtRch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch3.Location = new System.Drawing.Point(156, 83);
            this.txtRch3.MaxLength = 6;
            this.txtRch3.Name = "txtRch3";
            this.txtRch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch3.Size = new System.Drawing.Size(47, 23);
            this.txtRch3.TabIndex = 10;
            this.txtRch3.Text = "1.0000";
            this.txtRch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch8
            // 
            this.txtLch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch8.Location = new System.Drawing.Point(98, 230);
            this.txtLch8.MaxLength = 6;
            this.txtLch8.Name = "txtLch8";
            this.txtLch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch8.Size = new System.Drawing.Size(47, 23);
            this.txtLch8.TabIndex = 10;
            this.txtLch8.Text = "0.0000";
            this.txtLch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch10
            // 
            this.txtRch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch10.Location = new System.Drawing.Point(157, 289);
            this.txtRch10.MaxLength = 6;
            this.txtRch10.Name = "txtRch10";
            this.txtRch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch10.Size = new System.Drawing.Size(47, 23);
            this.txtRch10.TabIndex = 10;
            this.txtRch10.Text = "1.0000";
            this.txtRch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtMch1
            // 
            this.txtMch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtMch1.Location = new System.Drawing.Point(384, 25);
            this.txtMch1.MaxLength = 3;
            this.txtMch1.Name = "txtMch1";
            this.txtMch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMch1.Size = new System.Drawing.Size(26, 23);
            this.txtMch1.TabIndex = 10;
            this.txtMch1.Text = "0";
            this.txtMch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtXch1
            // 
            this.txtXch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtXch1.Location = new System.Drawing.Point(331, 25);
            this.txtXch1.MaxLength = 6;
            this.txtXch1.Name = "txtXch1";
            this.txtXch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtXch1.Size = new System.Drawing.Size(47, 23);
            this.txtXch1.TabIndex = 10;
            this.txtXch1.Text = "0.0000";
            this.txtXch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch6
            // 
            this.txtRch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch6.Location = new System.Drawing.Point(157, 172);
            this.txtRch6.MaxLength = 6;
            this.txtRch6.Name = "txtRch6";
            this.txtRch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch6.Size = new System.Drawing.Size(47, 23);
            this.txtRch6.TabIndex = 10;
            this.txtRch6.Text = "1.0000";
            this.txtRch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch11
            // 
            this.txtLch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch11.Location = new System.Drawing.Point(98, 318);
            this.txtLch11.MaxLength = 6;
            this.txtLch11.Name = "txtLch11";
            this.txtLch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch11.Size = new System.Drawing.Size(47, 23);
            this.txtLch11.TabIndex = 10;
            this.txtLch11.Text = "0.0000";
            this.txtLch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch4
            // 
            this.txtLch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch4.Location = new System.Drawing.Point(98, 112);
            this.txtLch4.MaxLength = 6;
            this.txtLch4.Name = "txtLch4";
            this.txtLch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch4.Size = new System.Drawing.Size(47, 23);
            this.txtLch4.TabIndex = 10;
            this.txtLch4.Text = "0.0000";
            this.txtLch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch7
            // 
            this.txtLch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch7.Location = new System.Drawing.Point(98, 201);
            this.txtLch7.MaxLength = 6;
            this.txtLch7.Name = "txtLch7";
            this.txtLch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch7.Size = new System.Drawing.Size(47, 23);
            this.txtLch7.TabIndex = 10;
            this.txtLch7.Text = "0.0000";
            this.txtLch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch9
            // 
            this.txtDch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch9.Location = new System.Drawing.Point(273, 260);
            this.txtDch9.MaxLength = 6;
            this.txtDch9.Name = "txtDch9";
            this.txtDch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch9.Size = new System.Drawing.Size(47, 23);
            this.txtDch9.TabIndex = 10;
            this.txtDch9.Text = "1.0000";
            this.txtDch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch2
            // 
            this.txtRch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch2.Location = new System.Drawing.Point(157, 54);
            this.txtRch2.MaxLength = 6;
            this.txtRch2.Name = "txtRch2";
            this.txtRch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch2.Size = new System.Drawing.Size(47, 23);
            this.txtRch2.TabIndex = 10;
            this.txtRch2.Text = "1.0000";
            this.txtRch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch5
            // 
            this.txtDch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch5.Location = new System.Drawing.Point(273, 143);
            this.txtDch5.MaxLength = 6;
            this.txtDch5.Name = "txtDch5";
            this.txtDch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch5.Size = new System.Drawing.Size(47, 23);
            this.txtDch5.TabIndex = 10;
            this.txtDch5.Text = "1.0000";
            this.txtDch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch12
            // 
            this.txtBPch12.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch12.Location = new System.Drawing.Point(40, 347);
            this.txtBPch12.MaxLength = 6;
            this.txtBPch12.Name = "txtBPch12";
            this.txtBPch12.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch12.Size = new System.Drawing.Size(47, 23);
            this.txtBPch12.TabIndex = 10;
            this.txtBPch12.Text = "0.0000";
            this.txtBPch12.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch3
            // 
            this.txtLch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch3.Location = new System.Drawing.Point(98, 83);
            this.txtLch3.MaxLength = 6;
            this.txtLch3.Name = "txtLch3";
            this.txtLch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch3.Size = new System.Drawing.Size(47, 23);
            this.txtLch3.TabIndex = 10;
            this.txtLch3.Text = "0.0000";
            this.txtLch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch8
            // 
            this.txtBPch8.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch8.Location = new System.Drawing.Point(40, 230);
            this.txtBPch8.MaxLength = 6;
            this.txtBPch8.Name = "txtBPch8";
            this.txtBPch8.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch8.Size = new System.Drawing.Size(47, 23);
            this.txtBPch8.TabIndex = 10;
            this.txtBPch8.Text = "0.0000";
            this.txtBPch8.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch10
            // 
            this.txtLch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch10.Location = new System.Drawing.Point(99, 289);
            this.txtLch10.MaxLength = 6;
            this.txtLch10.Name = "txtLch10";
            this.txtLch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch10.Size = new System.Drawing.Size(47, 23);
            this.txtLch10.TabIndex = 10;
            this.txtLch10.Text = "0.0000";
            this.txtLch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtDch1
            // 
            this.txtDch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtDch1.Location = new System.Drawing.Point(273, 25);
            this.txtDch1.MaxLength = 6;
            this.txtDch1.Name = "txtDch1";
            this.txtDch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDch1.Size = new System.Drawing.Size(47, 23);
            this.txtDch1.TabIndex = 10;
            this.txtDch1.Text = "1.0000";
            this.txtDch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch6
            // 
            this.txtLch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch6.Location = new System.Drawing.Point(99, 172);
            this.txtLch6.MaxLength = 6;
            this.txtLch6.Name = "txtLch6";
            this.txtLch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch6.Size = new System.Drawing.Size(47, 23);
            this.txtLch6.TabIndex = 10;
            this.txtLch6.Text = "0.0000";
            this.txtLch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch11
            // 
            this.txtBPch11.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch11.Location = new System.Drawing.Point(40, 318);
            this.txtBPch11.MaxLength = 6;
            this.txtBPch11.Name = "txtBPch11";
            this.txtBPch11.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch11.Size = new System.Drawing.Size(47, 23);
            this.txtBPch11.TabIndex = 10;
            this.txtBPch11.Text = "0.0000";
            this.txtBPch11.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch4
            // 
            this.txtBPch4.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch4.Location = new System.Drawing.Point(40, 112);
            this.txtBPch4.MaxLength = 6;
            this.txtBPch4.Name = "txtBPch4";
            this.txtBPch4.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch4.Size = new System.Drawing.Size(47, 23);
            this.txtBPch4.TabIndex = 10;
            this.txtBPch4.Text = "0.0000";
            this.txtBPch4.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch7
            // 
            this.txtBPch7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch7.Location = new System.Drawing.Point(40, 201);
            this.txtBPch7.MaxLength = 6;
            this.txtBPch7.Name = "txtBPch7";
            this.txtBPch7.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch7.Size = new System.Drawing.Size(47, 23);
            this.txtBPch7.TabIndex = 10;
            this.txtBPch7.Text = "0.0000";
            this.txtBPch7.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch9
            // 
            this.txtRch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch9.Location = new System.Drawing.Point(157, 260);
            this.txtRch9.MaxLength = 6;
            this.txtRch9.Name = "txtRch9";
            this.txtRch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch9.Size = new System.Drawing.Size(47, 23);
            this.txtRch9.TabIndex = 10;
            this.txtRch9.Text = "1.0000";
            this.txtRch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch2
            // 
            this.txtLch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch2.Location = new System.Drawing.Point(99, 54);
            this.txtLch2.MaxLength = 6;
            this.txtLch2.Name = "txtLch2";
            this.txtLch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch2.Size = new System.Drawing.Size(47, 23);
            this.txtLch2.TabIndex = 10;
            this.txtLch2.Text = "0.0000";
            this.txtLch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch5
            // 
            this.txtRch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch5.Location = new System.Drawing.Point(157, 143);
            this.txtRch5.MaxLength = 6;
            this.txtRch5.Name = "txtRch5";
            this.txtRch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch5.Size = new System.Drawing.Size(47, 23);
            this.txtRch5.TabIndex = 10;
            this.txtRch5.Text = "1.0000";
            this.txtRch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch10
            // 
            this.txtBPch10.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch10.Location = new System.Drawing.Point(41, 289);
            this.txtBPch10.MaxLength = 6;
            this.txtBPch10.Name = "txtBPch10";
            this.txtBPch10.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch10.Size = new System.Drawing.Size(47, 23);
            this.txtBPch10.TabIndex = 10;
            this.txtBPch10.Text = "0.0000";
            this.txtBPch10.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch3
            // 
            this.txtBPch3.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch3.Location = new System.Drawing.Point(40, 83);
            this.txtBPch3.MaxLength = 6;
            this.txtBPch3.Name = "txtBPch3";
            this.txtBPch3.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch3.Size = new System.Drawing.Size(47, 23);
            this.txtBPch3.TabIndex = 10;
            this.txtBPch3.Text = "0.0000";
            this.txtBPch3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch6
            // 
            this.txtBPch6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch6.Location = new System.Drawing.Point(41, 172);
            this.txtBPch6.MaxLength = 6;
            this.txtBPch6.Name = "txtBPch6";
            this.txtBPch6.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch6.Size = new System.Drawing.Size(47, 23);
            this.txtBPch6.TabIndex = 10;
            this.txtBPch6.Text = "0.0000";
            this.txtBPch6.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch9
            // 
            this.txtLch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch9.Location = new System.Drawing.Point(99, 260);
            this.txtLch9.MaxLength = 6;
            this.txtLch9.Name = "txtLch9";
            this.txtLch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch9.Size = new System.Drawing.Size(47, 23);
            this.txtLch9.TabIndex = 10;
            this.txtLch9.Text = "0.0000";
            this.txtLch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRch1
            // 
            this.txtRch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRch1.Location = new System.Drawing.Point(157, 25);
            this.txtRch1.MaxLength = 6;
            this.txtRch1.Name = "txtRch1";
            this.txtRch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRch1.Size = new System.Drawing.Size(47, 23);
            this.txtRch1.TabIndex = 10;
            this.txtRch1.Text = "1.0000";
            this.txtRch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch5
            // 
            this.txtLch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch5.Location = new System.Drawing.Point(99, 143);
            this.txtLch5.MaxLength = 6;
            this.txtLch5.Name = "txtLch5";
            this.txtLch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch5.Size = new System.Drawing.Size(47, 23);
            this.txtLch5.TabIndex = 10;
            this.txtLch5.Text = "0.0000";
            this.txtLch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch9
            // 
            this.txtBPch9.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch9.Location = new System.Drawing.Point(41, 260);
            this.txtBPch9.MaxLength = 6;
            this.txtBPch9.Name = "txtBPch9";
            this.txtBPch9.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch9.Size = new System.Drawing.Size(47, 23);
            this.txtBPch9.TabIndex = 10;
            this.txtBPch9.Text = "0.0000";
            this.txtBPch9.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch2
            // 
            this.txtBPch2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch2.Location = new System.Drawing.Point(41, 54);
            this.txtBPch2.MaxLength = 6;
            this.txtBPch2.Name = "txtBPch2";
            this.txtBPch2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch2.Size = new System.Drawing.Size(47, 23);
            this.txtBPch2.TabIndex = 10;
            this.txtBPch2.Text = "0.0000";
            this.txtBPch2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch5
            // 
            this.txtBPch5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch5.Location = new System.Drawing.Point(41, 143);
            this.txtBPch5.MaxLength = 6;
            this.txtBPch5.Name = "txtBPch5";
            this.txtBPch5.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch5.Size = new System.Drawing.Size(47, 23);
            this.txtBPch5.TabIndex = 10;
            this.txtBPch5.Text = "0.0000";
            this.txtBPch5.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtLch1
            // 
            this.txtLch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtLch1.Location = new System.Drawing.Point(99, 25);
            this.txtLch1.MaxLength = 6;
            this.txtLch1.Name = "txtLch1";
            this.txtLch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLch1.Size = new System.Drawing.Size(47, 23);
            this.txtLch1.TabIndex = 10;
            this.txtLch1.Text = "0.0000";
            this.txtLch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtBPch1
            // 
            this.txtBPch1.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtBPch1.Location = new System.Drawing.Point(41, 25);
            this.txtBPch1.MaxLength = 6;
            this.txtBPch1.Name = "txtBPch1";
            this.txtBPch1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBPch1.Size = new System.Drawing.Size(47, 23);
            this.txtBPch1.TabIndex = 10;
            this.txtBPch1.Text = "0.0000";
            this.txtBPch1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label92
            // 
            this.label92.AutoSize = true;
            this.label92.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label92.Location = new System.Drawing.Point(9, 451);
            this.label92.Name = "label92";
            this.label92.Size = new System.Drawing.Size(279, 32);
            this.label92.TabIndex = 1;
            this.label92.Text = "公式 2: (R5 * Volt^5) + (R4 * Volt^4) \r\n+ (R3 * Volt^3)+ (R2 * Volt^2) + (R1 * Volt" +
    ") + X";
            // 
            // label91
            // 
            this.label91.AutoSize = true;
            this.label91.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label91.Location = new System.Drawing.Point(11, 419);
            this.label91.Name = "label91";
            this.label91.Size = new System.Drawing.Size(182, 16);
            this.label91.TabIndex = 1;
            this.label91.Text = "公式1 :  BP - L + (R * V + C ) * D";
            // 
            // label77
            // 
            this.label77.AutoSize = true;
            this.label77.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label77.Location = new System.Drawing.Point(4, 388);
            this.label77.Name = "label77";
            this.label77.Size = new System.Drawing.Size(34, 16);
            this.label77.TabIndex = 1;
            this.label77.Text = "Rain";
            // 
            // label76
            // 
            this.label76.AutoSize = true;
            this.label76.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label76.Location = new System.Drawing.Point(3, 350);
            this.label76.Name = "label76";
            this.label76.Size = new System.Drawing.Size(39, 16);
            this.label76.TabIndex = 1;
            this.label76.Text = "CH12";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label44.Location = new System.Drawing.Point(389, 3);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(20, 16);
            this.label44.TabIndex = 1;
            this.label44.Text = "M";
            // 
            // label65
            // 
            this.label65.AutoSize = true;
            this.label65.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label65.Location = new System.Drawing.Point(341, 6);
            this.label65.Name = "label65";
            this.label65.Size = new System.Drawing.Size(16, 16);
            this.label65.TabIndex = 1;
            this.label65.Text = "X";
            // 
            // label72
            // 
            this.label72.AutoSize = true;
            this.label72.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label72.Location = new System.Drawing.Point(10, 233);
            this.label72.Name = "label72";
            this.label72.Size = new System.Drawing.Size(32, 16);
            this.label72.TabIndex = 1;
            this.label72.Text = "CH8";
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label.Location = new System.Drawing.Point(284, 6);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(17, 16);
            this.label.TabIndex = 1;
            this.label.Text = "D";
            // 
            // label75
            // 
            this.label75.AutoSize = true;
            this.label75.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label75.Location = new System.Drawing.Point(3, 321);
            this.label75.Name = "label75";
            this.label75.Size = new System.Drawing.Size(39, 16);
            this.label75.TabIndex = 1;
            this.label75.Text = "CH11";
            // 
            // label68
            // 
            this.label68.AutoSize = true;
            this.label68.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label68.Location = new System.Drawing.Point(10, 115);
            this.label68.Name = "label68";
            this.label68.Size = new System.Drawing.Size(32, 16);
            this.label68.TabIndex = 1;
            this.label68.Text = "CH4";
            // 
            // label71
            // 
            this.label71.AutoSize = true;
            this.label71.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label71.Location = new System.Drawing.Point(10, 204);
            this.label71.Name = "label71";
            this.label71.Size = new System.Drawing.Size(32, 16);
            this.label71.TabIndex = 1;
            this.label71.Text = "CH7";
            // 
            // label63
            // 
            this.label63.AutoSize = true;
            this.label63.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label63.Location = new System.Drawing.Point(228, 6);
            this.label63.Name = "label63";
            this.label63.Size = new System.Drawing.Size(16, 16);
            this.label63.TabIndex = 1;
            this.label63.Text = "C";
            // 
            // label74
            // 
            this.label74.AutoSize = true;
            this.label74.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label74.Location = new System.Drawing.Point(3, 292);
            this.label74.Name = "label74";
            this.label74.Size = new System.Drawing.Size(39, 16);
            this.label74.TabIndex = 1;
            this.label74.Text = "CH10";
            // 
            // label67
            // 
            this.label67.AutoSize = true;
            this.label67.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label67.Location = new System.Drawing.Point(10, 86);
            this.label67.Name = "label67";
            this.label67.Size = new System.Drawing.Size(32, 16);
            this.label67.TabIndex = 1;
            this.label67.Text = "CH3";
            // 
            // label70
            // 
            this.label70.AutoSize = true;
            this.label70.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label70.Location = new System.Drawing.Point(11, 175);
            this.label70.Name = "label70";
            this.label70.Size = new System.Drawing.Size(32, 16);
            this.label70.TabIndex = 1;
            this.label70.Text = "CH6";
            // 
            // label62
            // 
            this.label62.AutoSize = true;
            this.label62.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label62.Location = new System.Drawing.Point(169, 6);
            this.label62.Name = "label62";
            this.label62.Size = new System.Drawing.Size(16, 16);
            this.label62.TabIndex = 1;
            this.label62.Text = "R";
            // 
            // label73
            // 
            this.label73.AutoSize = true;
            this.label73.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label73.Location = new System.Drawing.Point(11, 263);
            this.label73.Name = "label73";
            this.label73.Size = new System.Drawing.Size(32, 16);
            this.label73.TabIndex = 1;
            this.label73.Text = "CH9";
            // 
            // label64
            // 
            this.label64.AutoSize = true;
            this.label64.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label64.Location = new System.Drawing.Point(11, 57);
            this.label64.Name = "label64";
            this.label64.Size = new System.Drawing.Size(32, 16);
            this.label64.TabIndex = 1;
            this.label64.Text = "CH2";
            // 
            // label69
            // 
            this.label69.AutoSize = true;
            this.label69.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label69.Location = new System.Drawing.Point(11, 146);
            this.label69.Name = "label69";
            this.label69.Size = new System.Drawing.Size(32, 16);
            this.label69.TabIndex = 1;
            this.label69.Text = "CH5";
            // 
            // label61
            // 
            this.label61.AutoSize = true;
            this.label61.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label61.Location = new System.Drawing.Point(106, 6);
            this.label61.Name = "label61";
            this.label61.Size = new System.Drawing.Size(14, 16);
            this.label61.TabIndex = 1;
            this.label61.Text = "L";
            // 
            // label66
            // 
            this.label66.AutoSize = true;
            this.label66.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label66.Location = new System.Drawing.Point(11, 28);
            this.label66.Name = "label66";
            this.label66.Size = new System.Drawing.Size(32, 16);
            this.label66.TabIndex = 1;
            this.label66.Text = "CH1";
            // 
            // label60
            // 
            this.label60.AutoSize = true;
            this.label60.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label60.Location = new System.Drawing.Point(49, 6);
            this.label60.Name = "label60";
            this.label60.Size = new System.Drawing.Size(24, 16);
            this.label60.TabIndex = 1;
            this.label60.Text = "BP";
            // 
            // tabProbe
            // 
            this.tabProbe.Controls.Add(this.groupBox8);
            this.tabProbe.Location = new System.Drawing.Point(4, 25);
            this.tabProbe.Name = "tabProbe";
            this.tabProbe.Padding = new System.Windows.Forms.Padding(3);
            this.tabProbe.Size = new System.Drawing.Size(424, 504);
            this.tabProbe.TabIndex = 3;
            this.tabProbe.Text = "其它設定";
            this.tabProbe.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.chkBAT);
            this.groupBox8.Controls.Add(this.chkRain);
            this.groupBox8.Controls.Add(this.label20);
            this.groupBox8.Controls.Add(this.txtms);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.chkProbe);
            this.groupBox8.Controls.Add(this.chkAD);
            this.groupBox8.Controls.Add(this.chkBG);
            this.groupBox8.Controls.Add(this.btnReadUart);
            this.groupBox8.Controls.Add(this.btnUart);
            this.groupBox8.Location = new System.Drawing.Point(21, 15);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(355, 202);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Uart";
            // 
            // chkBAT
            // 
            this.chkBAT.AutoSize = true;
            this.chkBAT.Location = new System.Drawing.Point(6, 172);
            this.chkBAT.Name = "chkBAT";
            this.chkBAT.Size = new System.Drawing.Size(147, 20);
            this.chkBAT.TabIndex = 11;
            this.chkBAT.Text = "顯示電池電壓抓取資訊";
            this.chkBAT.UseVisualStyleBackColor = true;
            // 
            // chkRain
            // 
            this.chkRain.AutoSize = true;
            this.chkRain.Location = new System.Drawing.Point(6, 147);
            this.chkRain.Name = "chkRain";
            this.chkRain.Size = new System.Drawing.Size(123, 20);
            this.chkRain.TabIndex = 11;
            this.chkRain.Text = "顯示雨量抓取資訊";
            this.chkRain.UseVisualStyleBackColor = true;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label20.Location = new System.Drawing.Point(102, 38);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(25, 16);
            this.label20.TabIndex = 1;
            this.label20.Text = "ms";
            // 
            // txtms
            // 
            this.txtms.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtms.Location = new System.Drawing.Point(9, 35);
            this.txtms.Name = "txtms";
            this.txtms.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtms.Size = new System.Drawing.Size(81, 23);
            this.txtms.TabIndex = 10;
            this.txtms.Text = "1000";
            this.txtms.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label17.Location = new System.Drawing.Point(6, 19);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(104, 16);
            this.label17.TabIndex = 1;
            this.label17.Text = "喚醒上電延遲時間";
            // 
            // chkProbe
            // 
            this.chkProbe.AutoSize = true;
            this.chkProbe.Location = new System.Drawing.Point(6, 121);
            this.chkProbe.Name = "chkProbe";
            this.chkProbe.Size = new System.Drawing.Size(126, 20);
            this.chkProbe.TabIndex = 11;
            this.chkProbe.Text = "顯示 測棒抓取資訊";
            this.chkProbe.UseVisualStyleBackColor = true;
            // 
            // chkAD
            // 
            this.chkAD.AutoSize = true;
            this.chkAD.Location = new System.Drawing.Point(6, 95);
            this.chkAD.Name = "chkAD";
            this.chkAD.Size = new System.Drawing.Size(122, 20);
            this.chkAD.TabIndex = 11;
            this.chkAD.Text = "顯示 AD 抓取資訊";
            this.chkAD.UseVisualStyleBackColor = true;
            // 
            // chkBG
            // 
            this.chkBG.AutoSize = true;
            this.chkBG.Location = new System.Drawing.Point(6, 69);
            this.chkBG.Name = "chkBG";
            this.chkBG.Size = new System.Drawing.Size(121, 20);
            this.chkBG.TabIndex = 11;
            this.chkBG.Text = "顯示 BG 傳送資訊";
            this.chkBG.UseVisualStyleBackColor = true;
            // 
            // btnReadUart
            // 
            this.btnReadUart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnReadUart.Location = new System.Drawing.Point(266, 121);
            this.btnReadUart.Name = "btnReadUart";
            this.btnReadUart.Size = new System.Drawing.Size(74, 45);
            this.btnReadUart.TabIndex = 0;
            this.btnReadUart.Text = "讀取";
            this.btnReadUart.UseVisualStyleBackColor = true;
            this.btnReadUart.Click += new System.EventHandler(this.btnUart_Click);
            // 
            // btnUart
            // 
            this.btnUart.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnUart.Location = new System.Drawing.Point(266, 35);
            this.btnUart.Name = "btnUart";
            this.btnUart.Size = new System.Drawing.Size(74, 54);
            this.btnUart.TabIndex = 0;
            this.btnUart.Text = "設定";
            this.btnUart.UseVisualStyleBackColor = true;
            this.btnUart.Click += new System.EventHandler(this.btnUart_Click);
            // 
            // tabCRC
            // 
            this.tabCRC.Controls.Add(this.label25);
            this.tabCRC.Controls.Add(this.btnSIDstr);
            this.tabCRC.Controls.Add(this.btnRIDstr);
            this.tabCRC.Controls.Add(this.btnReadStr);
            this.tabCRC.Controls.Add(this.btnSend);
            this.tabCRC.Controls.Add(this.label28);
            this.tabCRC.Controls.Add(this.label87);
            this.tabCRC.Controls.Add(this.label24);
            this.tabCRC.Controls.Add(this.boxSendHex);
            this.tabCRC.Controls.Add(this.btnCRC16);
            this.tabCRC.Controls.Add(this.btnCRC);
            this.tabCRC.Controls.Add(this.txtSetID);
            this.tabCRC.Controls.Add(this.txtnowID);
            this.tabCRC.Controls.Add(this.boxStr);
            this.tabCRC.Controls.Add(this.boxHEX);
            this.tabCRC.Controls.Add(this.label27);
            this.tabCRC.Controls.Add(this.boxCRC16);
            this.tabCRC.Controls.Add(this.boxCrc);
            this.tabCRC.Controls.Add(this.label94);
            this.tabCRC.Controls.Add(this.label93);
            this.tabCRC.Controls.Add(this.label26);
            this.tabCRC.Controls.Add(this.boxHexCalc);
            this.tabCRC.Location = new System.Drawing.Point(4, 25);
            this.tabCRC.Name = "tabCRC";
            this.tabCRC.Padding = new System.Windows.Forms.Padding(3);
            this.tabCRC.Size = new System.Drawing.Size(424, 504);
            this.tabCRC.TabIndex = 4;
            this.tabCRC.Text = "CRC 計算";
            this.tabCRC.UseVisualStyleBackColor = true;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label25.Location = new System.Drawing.Point(11, 214);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(80, 16);
            this.label25.TabIndex = 1;
            this.label25.Text = "指令傳送字串";
            // 
            // btnSIDstr
            // 
            this.btnSIDstr.Location = new System.Drawing.Point(177, 450);
            this.btnSIDstr.Name = "btnSIDstr";
            this.btnSIDstr.Size = new System.Drawing.Size(123, 28);
            this.btnSIDstr.TabIndex = 2;
            this.btnSIDstr.Text = "設置ID 字串";
            this.btnSIDstr.UseVisualStyleBackColor = true;
            this.btnSIDstr.Click += new System.EventHandler(this.btnReadStr_Click);
            // 
            // btnRIDstr
            // 
            this.btnRIDstr.Location = new System.Drawing.Point(33, 450);
            this.btnRIDstr.Name = "btnRIDstr";
            this.btnRIDstr.Size = new System.Drawing.Size(123, 28);
            this.btnRIDstr.TabIndex = 2;
            this.btnRIDstr.Text = "直接讀取ID";
            this.btnRIDstr.UseVisualStyleBackColor = true;
            this.btnRIDstr.Click += new System.EventHandler(this.btnReadStr_Click);
            // 
            // btnReadStr
            // 
            this.btnReadStr.Location = new System.Drawing.Point(33, 350);
            this.btnReadStr.Name = "btnReadStr";
            this.btnReadStr.Size = new System.Drawing.Size(123, 28);
            this.btnReadStr.TabIndex = 2;
            this.btnReadStr.Text = "讀取指令字串";
            this.btnReadStr.UseVisualStyleBackColor = true;
            this.btnReadStr.Click += new System.EventHandler(this.btnReadStr_Click);
            // 
            // btnSend
            // 
            this.btnSend.Enabled = false;
            this.btnSend.Location = new System.Drawing.Point(255, 320);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(123, 58);
            this.btnSend.TabIndex = 2;
            this.btnSend.Text = "傳送指令";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label28.Location = new System.Drawing.Point(21, 12);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(32, 16);
            this.label28.TabIndex = 1;
            this.label28.Text = "字串";
            // 
            // label87
            // 
            this.label87.AutoSize = true;
            this.label87.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label87.Location = new System.Drawing.Point(254, 81);
            this.label87.Name = "label87";
            this.label87.Size = new System.Drawing.Size(46, 16);
            this.label87.TabIndex = 1;
            this.label87.Text = "CRC16";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label24.Location = new System.Drawing.Point(252, 21);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(32, 16);
            this.label24.TabIndex = 1;
            this.label24.Text = "CRC";
            // 
            // boxSendHex
            // 
            this.boxSendHex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxSendHex.Location = new System.Drawing.Point(9, 233);
            this.boxSendHex.Multiline = true;
            this.boxSendHex.Name = "boxSendHex";
            this.boxSendHex.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxSendHex.Size = new System.Drawing.Size(368, 66);
            this.boxSendHex.TabIndex = 0;
            // 
            // btnCRC16
            // 
            this.btnCRC16.Location = new System.Drawing.Point(302, 81);
            this.btnCRC16.Name = "btnCRC16";
            this.btnCRC16.Size = new System.Drawing.Size(55, 42);
            this.btnCRC16.TabIndex = 2;
            this.btnCRC16.Text = "計算CRC16";
            this.btnCRC16.UseVisualStyleBackColor = true;
            this.btnCRC16.Click += new System.EventHandler(this.btnCRC_Click_1);
            // 
            // btnCRC
            // 
            this.btnCRC.Location = new System.Drawing.Point(302, 21);
            this.btnCRC.Name = "btnCRC";
            this.btnCRC.Size = new System.Drawing.Size(55, 42);
            this.btnCRC.TabIndex = 2;
            this.btnCRC.Text = "計算CRC";
            this.btnCRC.UseVisualStyleBackColor = true;
            this.btnCRC.Click += new System.EventHandler(this.btnCRC_Click_1);
            // 
            // txtSetID
            // 
            this.txtSetID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSetID.Location = new System.Drawing.Point(236, 421);
            this.txtSetID.Name = "txtSetID";
            this.txtSetID.Size = new System.Drawing.Size(60, 23);
            this.txtSetID.TabIndex = 0;
            this.txtSetID.TextChanged += new System.EventHandler(this.boxStr_TextChanged_1);
            // 
            // txtnowID
            // 
            this.txtnowID.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtnowID.Location = new System.Drawing.Point(96, 421);
            this.txtnowID.Name = "txtnowID";
            this.txtnowID.Size = new System.Drawing.Size(60, 23);
            this.txtnowID.TabIndex = 0;
            this.txtnowID.TextChanged += new System.EventHandler(this.boxStr_TextChanged_1);
            // 
            // boxStr
            // 
            this.boxStr.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxStr.Location = new System.Drawing.Point(9, 31);
            this.boxStr.Name = "boxStr";
            this.boxStr.Size = new System.Drawing.Size(204, 23);
            this.boxStr.TabIndex = 0;
            this.boxStr.TextChanged += new System.EventHandler(this.boxStr_TextChanged_1);
            // 
            // boxHEX
            // 
            this.boxHEX.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxHEX.Location = new System.Drawing.Point(9, 91);
            this.boxHEX.Name = "boxHEX";
            this.boxHEX.ReadOnly = true;
            this.boxHEX.Size = new System.Drawing.Size(181, 23);
            this.boxHEX.TabIndex = 0;
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label27.Location = new System.Drawing.Point(21, 72);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(83, 16);
            this.label27.TabIndex = 1;
            this.label27.Text = "字串的HEX 碼";
            // 
            // boxCRC16
            // 
            this.boxCRC16.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCRC16.Location = new System.Drawing.Point(253, 100);
            this.boxCRC16.Name = "boxCRC16";
            this.boxCRC16.ReadOnly = true;
            this.boxCRC16.Size = new System.Drawing.Size(43, 23);
            this.boxCRC16.TabIndex = 0;
            // 
            // boxCrc
            // 
            this.boxCrc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxCrc.Location = new System.Drawing.Point(253, 40);
            this.boxCrc.Name = "boxCrc";
            this.boxCrc.ReadOnly = true;
            this.boxCrc.Size = new System.Drawing.Size(43, 23);
            this.boxCrc.TabIndex = 0;
            // 
            // label94
            // 
            this.label94.AutoSize = true;
            this.label94.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label94.Location = new System.Drawing.Point(249, 402);
            this.label94.Name = "label94";
            this.label94.Size = new System.Drawing.Size(44, 16);
            this.label94.TabIndex = 1;
            this.label94.Text = "設置ID";
            // 
            // label93
            // 
            this.label93.AutoSize = true;
            this.label93.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label93.Location = new System.Drawing.Point(109, 402);
            this.label93.Name = "label93";
            this.label93.Size = new System.Drawing.Size(44, 16);
            this.label93.TabIndex = 1;
            this.label93.Text = "目前ID";
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label26.Location = new System.Drawing.Point(21, 130);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(143, 16);
            this.label26.TabIndex = 1;
            this.label26.Text = "計算CRC 的十六進制數值";
            // 
            // boxHexCalc
            // 
            this.boxHexCalc.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.boxHexCalc.Location = new System.Drawing.Point(9, 149);
            this.boxHexCalc.Multiline = true;
            this.boxHexCalc.Name = "boxHexCalc";
            this.boxHexCalc.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.boxHexCalc.Size = new System.Drawing.Size(368, 62);
            this.boxHexCalc.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(460, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "TX";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.Location = new System.Drawing.Point(459, 369);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(24, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "RX";
            // 
            // txtSysTime
            // 
            this.txtSysTime.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSysTime.Location = new System.Drawing.Point(99, 12);
            this.txtSysTime.Name = "txtSysTime";
            this.txtSysTime.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSysTime.Size = new System.Drawing.Size(210, 23);
            this.txtSysTime.TabIndex = 10;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label7.Location = new System.Drawing.Point(34, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "系統時間";
            // 
            // timer1s
            // 
            this.timer1s.Enabled = true;
            this.timer1s.Interval = 1000;
            this.timer1s.Tick += new System.EventHandler(this.timer1s_Tick);
            // 
            // btnClrTX
            // 
            this.btnClrTX.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClrTX.Location = new System.Drawing.Point(443, 716);
            this.btnClrTX.Name = "btnClrTX";
            this.btnClrTX.Size = new System.Drawing.Size(132, 26);
            this.btnClrTX.TabIndex = 4;
            this.btnClrTX.Text = "清除畫面";
            this.btnClrTX.UseVisualStyleBackColor = true;
            this.btnClrTX.Click += new System.EventHandler(this.btnClrTX_Click);
            // 
            // txtRecNum
            // 
            this.txtRecNum.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtRecNum.Location = new System.Drawing.Point(37, 148);
            this.txtRecNum.Name = "txtRecNum";
            this.txtRecNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRecNum.Size = new System.Drawing.Size(98, 23);
            this.txtRecNum.TabIndex = 10;
            this.txtRecNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtSendNum
            // 
            this.txtSendNum.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSendNum.Location = new System.Drawing.Point(141, 148);
            this.txtSendNum.Name = "txtSendNum";
            this.txtSendNum.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendNum.Size = new System.Drawing.Size(96, 23);
            this.txtSendNum.TabIndex = 10;
            this.txtSendNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnRec
            // 
            this.btnRec.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnRec.Location = new System.Drawing.Point(345, 135);
            this.btnRec.Name = "btnRec";
            this.btnRec.Size = new System.Drawing.Size(69, 42);
            this.btnRec.TabIndex = 0;
            this.btnRec.Text = "讀取紀錄筆數";
            this.btnRec.UseVisualStyleBackColor = true;
            this.btnRec.Click += new System.EventHandler(this.btnRec_Click);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label19.Location = new System.Drawing.Point(151, 129);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(75, 16);
            this.label19.TabIndex = 1;
            this.label19.Text = "IP1傳送筆數";
            // 
            // timer2
            // 
            this.timer2.Interval = 500;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // chkTxHex
            // 
            this.chkTxHex.AutoSize = true;
            this.chkTxHex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkTxHex.Location = new System.Drawing.Point(489, 17);
            this.chkTxHex.Name = "chkTxHex";
            this.chkTxHex.Size = new System.Drawing.Size(51, 20);
            this.chkTxHex.TabIndex = 3;
            this.chkTxHex.Text = "HEX";
            this.chkTxHex.UseVisualStyleBackColor = true;
            this.chkTxHex.CheckedChanged += new System.EventHandler(this.chkTxHex_CheckedChanged);
            // 
            // chkRxHex
            // 
            this.chkRxHex.AutoSize = true;
            this.chkRxHex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chkRxHex.Location = new System.Drawing.Point(489, 369);
            this.chkRxHex.Name = "chkRxHex";
            this.chkRxHex.Size = new System.Drawing.Size(85, 20);
            this.chkRxHex.TabIndex = 3;
            this.chkRxHex.Text = "指令碼Hex";
            this.chkRxHex.UseVisualStyleBackColor = true;
            this.chkRxHex.CheckedChanged += new System.EventHandler(this.chkTxHex_CheckedChanged);
            // 
            // btnSn
            // 
            this.btnSn.BackColor = System.Drawing.SystemColors.Control;
            this.btnSn.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSn.Location = new System.Drawing.Point(3, 10);
            this.btnSn.Name = "btnSn";
            this.btnSn.Size = new System.Drawing.Size(31, 26);
            this.btnSn.TabIndex = 0;
            this.btnSn.UseVisualStyleBackColor = false;
            this.btnSn.Visible = false;
            this.btnSn.Click += new System.EventHandler(this.btnSn_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("微軟正黑體", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnClose.Location = new System.Drawing.Point(33, 716);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(119, 26);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "關閉";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // timAD
            // 
            this.timAD.Interval = 500;
            this.timAD.Tick += new System.EventHandler(this.timAD_Tick);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label22.Location = new System.Drawing.Point(42, 129);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(56, 16);
            this.label22.TabIndex = 1;
            this.label22.Text = "紀錄筆數";
            // 
            // timer3
            // 
            this.timer3.Interval = 500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // rchRx
            // 
            this.rchRx.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rchRx.Location = new System.Drawing.Point(463, 395);
            this.rchRx.Name = "rchRx";
            this.rchRx.Size = new System.Drawing.Size(524, 307);
            this.rchRx.TabIndex = 12;
            this.rchRx.Text = "";
            this.rchRx.TextChanged += new System.EventHandler(this.rchTxHex_TextChanged);
            // 
            // rchTx
            // 
            this.rchTx.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rchTx.Location = new System.Drawing.Point(463, 53);
            this.rchTx.Name = "rchTx";
            this.rchTx.Size = new System.Drawing.Size(524, 307);
            this.rchTx.TabIndex = 12;
            this.rchTx.Text = "";
            this.rchTx.TextChanged += new System.EventHandler(this.rchTxHex_TextChanged);
            // 
            // rchTxHex
            // 
            this.rchTxHex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rchTxHex.Location = new System.Drawing.Point(463, 52);
            this.rchTxHex.Name = "rchTxHex";
            this.rchTxHex.Size = new System.Drawing.Size(524, 307);
            this.rchTxHex.TabIndex = 12;
            this.rchTxHex.Text = "";
            this.rchTxHex.Visible = false;
            this.rchTxHex.TextChanged += new System.EventHandler(this.rchTxHex_TextChanged);
            // 
            // rchRxHex
            // 
            this.rchRxHex.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rchRxHex.Location = new System.Drawing.Point(463, 399);
            this.rchRxHex.Name = "rchRxHex";
            this.rchRxHex.Size = new System.Drawing.Size(524, 307);
            this.rchRxHex.TabIndex = 12;
            this.rchRxHex.Text = "";
            this.rchRxHex.Visible = false;
            this.rchRxHex.TextChanged += new System.EventHandler(this.rchTxHex_TextChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label23.Location = new System.Drawing.Point(861, 721);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(88, 16);
            this.label23.TabIndex = 1;
            this.label23.Text = "2021.08.04 Z5";
            this.label23.Click += new System.EventHandler(this.label23_Click);
            // 
            // txtVerNote
            // 
            this.txtVerNote.Font = new System.Drawing.Font("微軟正黑體", 10F);
            this.txtVerNote.Location = new System.Drawing.Point(462, 53);
            this.txtVerNote.Multiline = true;
            this.txtVerNote.Name = "txtVerNote";
            this.txtVerNote.Size = new System.Drawing.Size(527, 654);
            this.txtVerNote.TabIndex = 13;
            this.txtVerNote.Text = resources.GetString("txtVerNote.Text");
            this.txtVerNote.Visible = false;
            // 
            // label86
            // 
            this.label86.AutoSize = true;
            this.label86.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label86.Location = new System.Drawing.Point(253, 129);
            this.label86.Name = "label86";
            this.label86.Size = new System.Drawing.Size(75, 16);
            this.label86.TabIndex = 1;
            this.label86.Text = "IP2傳送筆數";
            // 
            // txtSendNum2
            // 
            this.txtSendNum2.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.txtSendNum2.Location = new System.Drawing.Point(243, 148);
            this.txtSendNum2.Name = "txtSendNum2";
            this.txtSendNum2.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtSendNum2.Size = new System.Drawing.Size(96, 23);
            this.txtSendNum2.TabIndex = 10;
            this.txtSendNum2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // chknormal
            // 
            this.chknormal.AutoSize = true;
            this.chknormal.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.chknormal.Location = new System.Drawing.Point(568, 369);
            this.chknormal.Name = "chknormal";
            this.chknormal.Size = new System.Drawing.Size(73, 20);
            this.chknormal.TabIndex = 3;
            this.chknormal.Text = "讀取Hex";
            this.chknormal.UseVisualStyleBackColor = true;
            this.chknormal.CheckedChanged += new System.EventHandler(this.chkTxHex_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 773);
            this.Controls.Add(this.txtVerNote);
            this.Controls.Add(this.rchTxHex);
            this.Controls.Add(this.rchTx);
            this.Controls.Add(this.rchRxHex);
            this.Controls.Add(this.rchRx);
            this.Controls.Add(this.btnClrTX);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSn);
            this.Controls.Add(this.txtSendNum2);
            this.Controls.Add(this.txtSendNum);
            this.Controls.Add(this.txtRecNum);
            this.Controls.Add(this.chknormal);
            this.Controls.Add(this.chkRxHex);
            this.Controls.Add(this.chkTxHex);
            this.Controls.Add(this.btnRec);
            this.Controls.Add(this.txtSysTime);
            this.Controls.Add(this.tabFunc);
            this.Controls.Add(this.label86);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Name = "Form1";
            this.Text = "Nb-iot";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabFunc.ResumeLayout(false);
            this.tabRTC.ResumeLayout(false);
            this.tabRTC.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.tabNET.ResumeLayout(false);
            this.tabNET.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabAD.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabCHG.ResumeLayout(false);
            this.tabCHG.PerformLayout();
            this.tabProbe.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.tabCRC.ResumeLayout(false);
            this.tabCRC.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timeRx;
        private System.IO.Ports.SerialPort SerialCOM;
        private System.Windows.Forms.Button btnPort;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox boxCom;
        private System.Windows.Forms.ComboBox boxBaurd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabControl tabFunc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSysTime;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Timer timer1s;
        private System.Windows.Forms.Button btnClrTX;
        private System.Windows.Forms.TabPage tabRTC;
        private System.Windows.Forms.TextBox txtRtcTime;
        private System.Windows.Forms.TextBox boxCycleSec;
        private System.Windows.Forms.TextBox boxSec;
        private System.Windows.Forms.TextBox boxCycleMin;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox boxCycleHour;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox boxMin;
        private System.Windows.Forms.TextBox boxHour;
        private System.Windows.Forms.Button btnCycleTime;
        private System.Windows.Forms.CheckBox chkAF;
        private System.Windows.Forms.CheckBox chkIE;
        private System.Windows.Forms.Button btnReadRTC;
        private System.Windows.Forms.Button btnSymTime;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAF;
        private System.Windows.Forms.Button btnIE;
        private System.Windows.Forms.Button btnIntTime;
        private System.Windows.Forms.CheckBox chkMin;
        private System.Windows.Forms.CheckBox chkSec;
        private System.Windows.Forms.CheckBox chkHour;
        private System.Windows.Forms.TextBox txtRecNum;
        private System.Windows.Forms.TextBox txtSendNum;
        private System.Windows.Forms.Button btnRec;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.CheckBox chkTxHex;
        private System.Windows.Forms.CheckBox chkRxHex;
        private System.Windows.Forms.Button btnSn;
        private System.Windows.Forms.TabPage tabAD;
        private System.Windows.Forms.TextBox txtCalAIV;
        private System.Windows.Forms.Button btnCalAI;
        private System.Windows.Forms.TextBox txtCalBatV;
        private System.Windows.Forms.TextBox txtCH12;
        private System.Windows.Forms.TextBox txtCH10;
        private System.Windows.Forms.TextBox txtCH11;
        private System.Windows.Forms.TextBox txtCH9;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.Button btnCalBat;
        private System.Windows.Forms.Button btnReadBat;
        private System.Windows.Forms.RadioButton radAI1;
        private System.Windows.Forms.TextBox txtBatV;
        private System.Windows.Forms.Button btnReadAI;
        private System.Windows.Forms.RadioButton radAI3;
        private System.Windows.Forms.RadioButton radAI2;
        private System.Windows.Forms.RadioButton radAI4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnContinue;
        private System.Windows.Forms.Timer timAD;
        private System.Windows.Forms.TabPage tabProbe;
        private System.Windows.Forms.TextBox txtms;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Timer timer3;
        private System.Windows.Forms.CheckBox chkBG;
        private System.Windows.Forms.RichTextBox rchRx;
        private System.Windows.Forms.RichTextBox rchTx;
        private System.Windows.Forms.RichTextBox rchTxHex;
        private System.Windows.Forms.RichTextBox rchRxHex;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.TextBox txtVerNote;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnCRC;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox boxCrc;
        private System.Windows.Forms.TextBox boxSendHex;
        private System.Windows.Forms.TextBox boxHexCalc;
        private System.Windows.Forms.TextBox boxHEX;
        private System.Windows.Forms.TextBox boxStr;
        private System.Windows.Forms.TabPage tabCRC;
        private System.Windows.Forms.RadioButton radCalc;
        private System.Windows.Forms.RadioButton radRaw;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.TextBox txtDoor;
        private System.Windows.Forms.TextBox txtRain;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.Label label35;
        private System.Windows.Forms.TextBox txtCH2;
        private System.Windows.Forms.TextBox txtCH6;
        private System.Windows.Forms.TextBox txtCH4;
        private System.Windows.Forms.TextBox txtCH8;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtCH5;
        private System.Windows.Forms.TextBox txtCH1;
        private System.Windows.Forms.TextBox txtCH3;
        private System.Windows.Forms.TextBox txtCH7;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox txtStation;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Button btnSetBasic;
        private System.Windows.Forms.Button btnStation;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Button btnReadBasic;
        private System.Windows.Forms.CheckBox chkCrycle;
        private System.Windows.Forms.CheckBox chkRec;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnReadStation;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.ComboBox boxType8;
        private System.Windows.Forms.ComboBox boxType7;
        private System.Windows.Forms.ComboBox boxType6;
        private System.Windows.Forms.ComboBox boxType5;
        private System.Windows.Forms.ComboBox boxType4;
        private System.Windows.Forms.ComboBox boxType3;
        private System.Windows.Forms.ComboBox boxType2;
        private System.Windows.Forms.ComboBox boxType1;
        private System.Windows.Forms.TextBox boxData8;
        private System.Windows.Forms.TextBox boxID8;
        private System.Windows.Forms.TextBox boxData7;
        private System.Windows.Forms.TextBox boxData6;
        private System.Windows.Forms.TextBox boxID7;
        private System.Windows.Forms.TextBox boxData5;
        private System.Windows.Forms.TextBox boxID6;
        private System.Windows.Forms.TextBox boxData4;
        private System.Windows.Forms.TextBox boxID5;
        private System.Windows.Forms.TextBox boxData3;
        private System.Windows.Forms.TextBox boxID4;
        private System.Windows.Forms.TextBox boxData2;
        private System.Windows.Forms.TextBox boxID3;
        private System.Windows.Forms.TextBox boxID2;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label58;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox boxData1;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.TextBox boxID1;
        private System.Windows.Forms.Button btnReadType;
        private System.Windows.Forms.Button btnSetType;
        private System.Windows.Forms.ComboBox cbobaud;
        private System.Windows.Forms.Label label59;
        private System.Windows.Forms.Button btnClearRec;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.CheckBox chkBAT;
        private System.Windows.Forms.CheckBox chkRain;
        private System.Windows.Forms.CheckBox chkProbe;
        private System.Windows.Forms.CheckBox chkAD;
        private System.Windows.Forms.Button btnUart;
        private System.Windows.Forms.Button btnReadUart;
        private System.Windows.Forms.TabPage tabCHG;
        private System.Windows.Forms.TextBox txtCch12;
        private System.Windows.Forms.TextBox txtCch8;
        private System.Windows.Forms.TextBox txtCch4;
        private System.Windows.Forms.TextBox txtCch11;
        private System.Windows.Forms.TextBox txtCch7;
        private System.Windows.Forms.TextBox txtCch3;
        private System.Windows.Forms.TextBox txtCch10;
        private System.Windows.Forms.TextBox txtCch6;
        private System.Windows.Forms.TextBox txtCch2;
        private System.Windows.Forms.TextBox txtCch9;
        private System.Windows.Forms.TextBox txtCch5;
        private System.Windows.Forms.TextBox txtCch1;
        private System.Windows.Forms.TextBox txtXch12;
        private System.Windows.Forms.TextBox txtDch12;
        private System.Windows.Forms.TextBox txtXch8;
        private System.Windows.Forms.TextBox txtDch8;
        private System.Windows.Forms.TextBox txtXch11;
        private System.Windows.Forms.TextBox txtXch4;
        private System.Windows.Forms.TextBox txtXch7;
        private System.Windows.Forms.TextBox txtDch11;
        private System.Windows.Forms.TextBox txtDch4;
        private System.Windows.Forms.TextBox txtDch7;
        private System.Windows.Forms.TextBox txtXch10;
        private System.Windows.Forms.TextBox txtXch3;
        private System.Windows.Forms.TextBox txtXch6;
        private System.Windows.Forms.TextBox txtRch12;
        private System.Windows.Forms.TextBox txtDch3;
        private System.Windows.Forms.TextBox txtRch8;
        private System.Windows.Forms.TextBox txtDch10;
        private System.Windows.Forms.TextBox txtXch2;
        private System.Windows.Forms.TextBox txtDch6;
        private System.Windows.Forms.TextBox txtRch11;
        private System.Windows.Forms.TextBox txtRch4;
        private System.Windows.Forms.TextBox txtRch7;
        private System.Windows.Forms.TextBox txtXch9;
        private System.Windows.Forms.TextBox txtDch2;
        private System.Windows.Forms.TextBox txtXch5;
        private System.Windows.Forms.TextBox txtLch12;
        private System.Windows.Forms.TextBox txtRch3;
        private System.Windows.Forms.TextBox txtLch8;
        private System.Windows.Forms.TextBox txtRch10;
        private System.Windows.Forms.TextBox txtXch1;
        private System.Windows.Forms.TextBox txtRch6;
        private System.Windows.Forms.TextBox txtLch11;
        private System.Windows.Forms.TextBox txtLch4;
        private System.Windows.Forms.TextBox txtLch7;
        private System.Windows.Forms.TextBox txtDch9;
        private System.Windows.Forms.TextBox txtRch2;
        private System.Windows.Forms.TextBox txtDch5;
        private System.Windows.Forms.TextBox txtBPch12;
        private System.Windows.Forms.TextBox txtLch3;
        private System.Windows.Forms.TextBox txtBPch8;
        private System.Windows.Forms.TextBox txtLch10;
        private System.Windows.Forms.TextBox txtDch1;
        private System.Windows.Forms.TextBox txtLch6;
        private System.Windows.Forms.TextBox txtBPch11;
        private System.Windows.Forms.TextBox txtBPch4;
        private System.Windows.Forms.TextBox txtBPch7;
        private System.Windows.Forms.TextBox txtRch9;
        private System.Windows.Forms.TextBox txtLch2;
        private System.Windows.Forms.TextBox txtRch5;
        private System.Windows.Forms.TextBox txtBPch10;
        private System.Windows.Forms.TextBox txtBPch3;
        private System.Windows.Forms.TextBox txtBPch6;
        private System.Windows.Forms.TextBox txtLch9;
        private System.Windows.Forms.TextBox txtRch1;
        private System.Windows.Forms.TextBox txtLch5;
        private System.Windows.Forms.TextBox txtBPch9;
        private System.Windows.Forms.TextBox txtBPch2;
        private System.Windows.Forms.TextBox txtBPch5;
        private System.Windows.Forms.TextBox txtLch1;
        private System.Windows.Forms.TextBox txtBPch1;
        private System.Windows.Forms.Label label76;
        private System.Windows.Forms.Label label65;
        private System.Windows.Forms.Label label72;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label label75;
        private System.Windows.Forms.Label label68;
        private System.Windows.Forms.Label label71;
        private System.Windows.Forms.Label label63;
        private System.Windows.Forms.Label label74;
        private System.Windows.Forms.Label label67;
        private System.Windows.Forms.Label label70;
        private System.Windows.Forms.Label label62;
        private System.Windows.Forms.Label label73;
        private System.Windows.Forms.Label label64;
        private System.Windows.Forms.Label label69;
        private System.Windows.Forms.Label label61;
        private System.Windows.Forms.Label label66;
        private System.Windows.Forms.Label label60;
        private System.Windows.Forms.Button btnSCHG;
        private System.Windows.Forms.Button btnRCHG;
        private System.Windows.Forms.ComboBox boxRain;
        private System.Windows.Forms.Label label77;
        private System.Windows.Forms.Button btnAllSet;
        private System.Windows.Forms.TextBox txtver;
        private System.Windows.Forms.Label label83;
        private System.Windows.Forms.Button btnVer;
        private System.Windows.Forms.TabPage tabNET;
        private System.Windows.Forms.Button btnReadNet;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtPORT;
        private System.Windows.Forms.TextBox txtIP;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button btnFET;
        private System.Windows.Forms.CheckBox chkNB1;
        private System.Windows.Forms.TextBox txtapn;
        private System.Windows.Forms.Button btnTW;
        private System.Windows.Forms.Button btnCHT;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button btnReadApn;
        private System.Windows.Forms.Button btnApn;
        private System.Windows.Forms.Button btnReadIP;
        private System.Windows.Forms.Button btnIP;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnReadBand;
        private System.Windows.Forms.Button btnBand;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox boxNB7;
        private System.Windows.Forms.CheckBox boxNB9;
        private System.Windows.Forms.CheckBox boxM18;
        private System.Windows.Forms.TextBox txtSNR;
        private System.Windows.Forms.TextBox txtRSRP;
        private System.Windows.Forms.TextBox txtRSSI;
        private System.Windows.Forms.TextBox txtconnect;
        private System.Windows.Forms.TextBox txtIMEI;
        private System.Windows.Forms.Label label82;
        private System.Windows.Forms.Label label81;
        private System.Windows.Forms.Label label80;
        private System.Windows.Forms.Label label79;
        private System.Windows.Forms.Label label78;
        private System.Windows.Forms.Button btnSingle;
        private System.Windows.Forms.Button btnIMEI;
        private System.Windows.Forms.Button btnClrAIV;
        private System.Windows.Forms.TextBox txtPORT2;
        private System.Windows.Forms.TextBox txtIP2;
        private System.Windows.Forms.Label label85;
        private System.Windows.Forms.CheckBox chkNB2;
        private System.Windows.Forms.Label label84;
        private System.Windows.Forms.Label label86;
        private System.Windows.Forms.TextBox txtSendNum2;
        private System.Windows.Forms.Label label87;
        private System.Windows.Forms.Button btnCRC16;
        private System.Windows.Forms.TextBox boxCRC16;
        private System.Windows.Forms.Label label90;
        private System.Windows.Forms.Label label89;
        private System.Windows.Forms.Label label88;
        private System.Windows.Forms.CheckBox chknormal;
        private System.Windows.Forms.TextBox txtMch12;
        private System.Windows.Forms.TextBox txtMch8;
        private System.Windows.Forms.TextBox txtMch11;
        private System.Windows.Forms.TextBox txtMch4;
        private System.Windows.Forms.TextBox txtMch7;
        private System.Windows.Forms.TextBox txtMch10;
        private System.Windows.Forms.TextBox txtMch3;
        private System.Windows.Forms.TextBox txtMch6;
        private System.Windows.Forms.TextBox txtMch2;
        private System.Windows.Forms.TextBox txtMch9;
        private System.Windows.Forms.TextBox txtMch5;
        private System.Windows.Forms.TextBox txtMch1;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.Label label92;
        private System.Windows.Forms.Label label91;
        private System.Windows.Forms.Button btnReadStr;
        private System.Windows.Forms.Button btnSIDstr;
        private System.Windows.Forms.Button btnRIDstr;
        private System.Windows.Forms.Label label93;
        private System.Windows.Forms.TextBox txtSetID;
        private System.Windows.Forms.TextBox txtnowID;
        private System.Windows.Forms.Label label94;
    }
}

