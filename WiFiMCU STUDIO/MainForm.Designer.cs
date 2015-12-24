using System.Security.AccessControl;
using MetroFramework.Controls;

namespace MetroFramework.WiFiMCU
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.metroTab = new MetroFramework.Controls.MetroTabControl();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxUartData = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxDuty = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxFreq = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBoxPeriod = new MetroFramework.Controls.MetroTextBox();
            this.metroComboBoxGPIOMode = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxADCPin = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxStop = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxParity = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxBaud = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxBits = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxUart = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxPWMPin = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxGPIOPin = new MetroFramework.Controls.MetroComboBox();
            this.metroComboBoxTimerID = new MetroFramework.Controls.MetroComboBox();
            this.metroButtonBootR = new MetroFramework.Controls.MetroButton();
            this.btnTimerStop = new MetroFramework.Controls.MetroButton();
            this.btnTimerDelay = new MetroFramework.Controls.MetroButton();
            this.btnTimerWd = new MetroFramework.Controls.MetroButton();
            this.btnTimerStart = new MetroFramework.Controls.MetroButton();
            this.metroButtonChipid = new MetroFramework.Controls.MetroButton();
            this.metroButtonInfo = new MetroFramework.Controls.MetroButton();
            this.metroLabel9 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel26 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel27 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel25 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnGPIOSetmode = new MetroFramework.Controls.MetroButton();
            this.btnGPIOToggle = new MetroFramework.Controls.MetroButton();
            this.btnGPIOSetLow = new MetroFramework.Controls.MetroButton();
            this.btnGPIOSetHigh = new MetroFramework.Controls.MetroButton();
            this.metroButtonVer = new MetroFramework.Controls.MetroButton();
            this.metroButtonPWMStop = new MetroFramework.Controls.MetroButton();
            this.metroButtonADCRead = new MetroFramework.Controls.MetroButton();
            this.metroButtonUartSend = new MetroFramework.Controls.MetroButton();
            this.metroButtonSet = new MetroFramework.Controls.MetroButton();
            this.metroButtonPWMStart = new MetroFramework.Controls.MetroButton();
            this.btnGPIORead = new MetroFramework.Controls.MetroButton();
            this.metroTabPage3 = new MetroFramework.Controls.MetroTabPage();
            this.checkBoxBindLoaclPort = new MetroFramework.Controls.MetroCheckBox();
            this.metroToggleTransType = new MetroFramework.Controls.MetroToggle();
            this.metroToggleSocketType = new MetroFramework.Controls.MetroToggle();
            this.textBoxSTAPSW = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAPPSW = new MetroFramework.Controls.MetroTextBox();
            this.textBoxBindLoadPort = new MetroFramework.Controls.MetroTextBox();
            this.textBoxIP = new MetroFramework.Controls.MetroTextBox();
            this.labelPort = new MetroFramework.Controls.MetroTextBox();
            this.textBoxSendData = new MetroFramework.Controls.MetroTextBox();
            this.textBoxSTASSID = new MetroFramework.Controls.MetroTextBox();
            this.textBoxAPSSID = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel13 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel12 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel11 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel10 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.btnStartSTA = new MetroFramework.Controls.MetroButton();
            this.btnStopSTA = new MetroFramework.Controls.MetroButton();
            this.btnStopAP = new MetroFramework.Controls.MetroButton();
            this.btnSendData = new MetroFramework.Controls.MetroButton();
            this.btnNetSet = new MetroFramework.Controls.MetroButton();
            this.metroButtonScan = new MetroFramework.Controls.MetroButton();
            this.btnGetAPIP = new MetroFramework.Controls.MetroButton();
            this.btnGetSTALink = new MetroFramework.Controls.MetroButton();
            this.btnGetSTAIP = new MetroFramework.Controls.MetroButton();
            this.btnStartAP = new MetroFramework.Controls.MetroButton();
            this.metroTabPage4 = new MetroFramework.Controls.MetroTabPage();
            this.metroButtonFileState = new MetroFramework.Controls.MetroButton();
            this.metroButton42 = new MetroFramework.Controls.MetroButton();
            this.btnFilelist = new MetroFramework.Controls.MetroButton();
            this.btnFileUpload = new MetroFramework.Controls.MetroButton();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.metroContextMenu2 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.Run = new System.Windows.Forms.ToolStripMenuItem();
            this.View = new System.Windows.Forms.ToolStripMenuItem();
            this.Compile = new System.Windows.Forms.ToolStripMenuItem();
            this.Rename = new System.Windows.Forms.ToolStripMenuItem();
            this.Download = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Delete = new System.Windows.Forms.ToolStripMenuItem();
            this.metroLabelUploadProgress = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroTileFormat = new MetroFramework.Controls.MetroTile();
            this.metroTabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.metroLabelUploadProgress2 = new MetroFramework.Controls.MetroLabel();
            this.metroProgressSpinner2 = new MetroFramework.Controls.MetroProgressSpinner();
            this.metroCheckBox3 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox2 = new MetroFramework.Controls.MetroCheckBox();
            this.metroCheckBox1 = new MetroFramework.Controls.MetroCheckBox();
            this.btnSendFW = new MetroFramework.Controls.MetroButton();
            this.metroLabel16 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel15 = new MetroFramework.Controls.MetroLabel();
            this.metroTabPage6 = new MetroFramework.Controls.MetroTabPage();
            this.metroTextBoxInfo = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel14 = new MetroFramework.Controls.MetroLabel();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.metroToolTip = new MetroFramework.Components.MetroToolTip();
            this.comboBoxSerialBaudrate = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxSerialPort = new MetroFramework.Controls.MetroComboBox();
            this.metroTileOpenPort = new MetroFramework.Controls.MetroTile();
            this.metroTileRestart = new MetroFramework.Controls.MetroTile();
            this.metroTileSwitch = new MetroFramework.Controls.MetroTile();
            this.metroTileSWitchTheme = new MetroFramework.Controls.MetroTile();
            this.metroTileScan = new MetroFramework.Controls.MetroTile();
            this.metroButtonTick = new MetroFramework.Controls.MetroButton();
            this.metroButtonCG = new MetroFramework.Controls.MetroButton();
            this.metroButtonMem = new MetroFramework.Controls.MetroButton();
            this.metroTextBoxSend = new MetroFramework.Controls.MetroTextBox();
            this.txtSP = new System.Windows.Forms.RichTextBox();
            this.metroContextMenu1 = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.ClearScreen = new System.Windows.Forms.ToolStripMenuItem();
            this.ClearHistory = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Restart = new System.Windows.Forms.ToolStripMenuItem();
            this.metroButtonSupport = new MetroFramework.Controls.MetroButton();
            this.metroStyleExtender = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.metroLabelCom = new MetroFramework.Controls.MetroLabel();
            this.metroLabel21 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel22 = new MetroFramework.Controls.MetroLabel();
            this.txSendBytes = new MetroFramework.Controls.MetroLabel();
            this.rxReadBytes = new MetroFramework.Controls.MetroLabel();
            this.txtSPBack = new MetroFramework.Controls.MetroTextBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.metroTab.SuspendLayout();
            this.metroTabPage1.SuspendLayout();
            this.metroTabPage3.SuspendLayout();
            this.metroTabPage4.SuspendLayout();
            this.metroContextMenu2.SuspendLayout();
            this.metroTabPage2.SuspendLayout();
            this.metroTabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.metroContextMenu1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTab
            // 
            this.metroTab.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.metroTab.Controls.Add(this.metroTabPage1);
            this.metroTab.Controls.Add(this.metroTabPage3);
            this.metroTab.Controls.Add(this.metroTabPage4);
            this.metroTab.Controls.Add(this.metroTabPage2);
            this.metroTab.Controls.Add(this.metroTabPage6);
            this.metroTab.Location = new System.Drawing.Point(6, 152);
            this.metroTab.Name = "metroTab";
            this.metroTab.SelectedIndex = 1;
            this.metroTab.Size = new System.Drawing.Size(492, 477);
            this.metroTab.TabIndex = 0;
            this.metroTab.UseSelectable = true;
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.AutoScroll = true;
            this.metroTabPage1.Controls.Add(this.metroTextBoxUartData);
            this.metroTabPage1.Controls.Add(this.metroTextBoxDuty);
            this.metroTabPage1.Controls.Add(this.metroTextBoxFreq);
            this.metroTabPage1.Controls.Add(this.metroTextBoxPeriod);
            this.metroTabPage1.Controls.Add(this.metroComboBoxGPIOMode);
            this.metroTabPage1.Controls.Add(this.metroComboBoxADCPin);
            this.metroTabPage1.Controls.Add(this.metroComboBoxStop);
            this.metroTabPage1.Controls.Add(this.metroComboBoxParity);
            this.metroTabPage1.Controls.Add(this.metroComboBoxBaud);
            this.metroTabPage1.Controls.Add(this.metroComboBoxBits);
            this.metroTabPage1.Controls.Add(this.metroComboBoxUart);
            this.metroTabPage1.Controls.Add(this.metroComboBoxPWMPin);
            this.metroTabPage1.Controls.Add(this.metroComboBoxGPIOPin);
            this.metroTabPage1.Controls.Add(this.metroComboBoxTimerID);
            this.metroTabPage1.Controls.Add(this.metroButtonBootR);
            this.metroTabPage1.Controls.Add(this.btnTimerStop);
            this.metroTabPage1.Controls.Add(this.btnTimerDelay);
            this.metroTabPage1.Controls.Add(this.btnTimerWd);
            this.metroTabPage1.Controls.Add(this.btnTimerStart);
            this.metroTabPage1.Controls.Add(this.metroButtonChipid);
            this.metroTabPage1.Controls.Add(this.metroButtonInfo);
            this.metroTabPage1.Controls.Add(this.metroLabel9);
            this.metroTabPage1.Controls.Add(this.metroLabel26);
            this.metroTabPage1.Controls.Add(this.metroLabel27);
            this.metroTabPage1.Controls.Add(this.metroLabel25);
            this.metroTabPage1.Controls.Add(this.metroLabel1);
            this.metroTabPage1.Controls.Add(this.metroLabel8);
            this.metroTabPage1.Controls.Add(this.btnGPIOSetmode);
            this.metroTabPage1.Controls.Add(this.btnGPIOToggle);
            this.metroTabPage1.Controls.Add(this.btnGPIOSetLow);
            this.metroTabPage1.Controls.Add(this.btnGPIOSetHigh);
            this.metroTabPage1.Controls.Add(this.metroButtonVer);
            this.metroTabPage1.Controls.Add(this.metroButtonPWMStop);
            this.metroTabPage1.Controls.Add(this.metroButtonADCRead);
            this.metroTabPage1.Controls.Add(this.metroButtonUartSend);
            this.metroTabPage1.Controls.Add(this.metroButtonSet);
            this.metroTabPage1.Controls.Add(this.metroButtonPWMStart);
            this.metroTabPage1.Controls.Add(this.btnGPIORead);
            this.metroTabPage1.HorizontalScrollbar = true;
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 9;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.metroTabPage1.Size = new System.Drawing.Size(484, 434);
            this.metroTabPage1.TabIndex = 0;
            this.metroTabPage1.Text = "   Basic   ";
            this.metroTabPage1.VerticalScrollbar = true;
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // metroTextBoxUartData
            // 
            this.metroTextBoxUartData.IconRight = true;
            this.metroTextBoxUartData.Lines = new string[0];
            this.metroTextBoxUartData.Location = new System.Drawing.Point(22, 401);
            this.metroTextBoxUartData.MaxLength = 32767;
            this.metroTextBoxUartData.Name = "metroTextBoxUartData";
            this.metroTextBoxUartData.PasswordChar = '\0';
            this.metroTextBoxUartData.PromptText = "Text to be send to uart";
            this.metroTextBoxUartData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxUartData.SelectedText = "";
            this.metroTextBoxUartData.Size = new System.Drawing.Size(357, 30);
            this.metroTextBoxUartData.TabIndex = 19;
            this.metroToolTip.SetToolTip(this.metroTextBoxUartData, "Text to be send to uart");
            this.metroTextBoxUartData.UseSelectable = true;
            this.metroTextBoxUartData.UseStyleColors = true;
            // 
            // metroTextBoxDuty
            // 
            this.metroTextBoxDuty.IconRight = true;
            this.metroTextBoxDuty.Lines = new string[0];
            this.metroTextBoxDuty.Location = new System.Drawing.Point(22, 303);
            this.metroTextBoxDuty.MaxLength = 32767;
            this.metroTextBoxDuty.Name = "metroTextBoxDuty";
            this.metroTextBoxDuty.PasswordChar = '\0';
            this.metroTextBoxDuty.PromptText = "Duty";
            this.metroTextBoxDuty.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxDuty.SelectedText = "";
            this.metroTextBoxDuty.Size = new System.Drawing.Size(80, 30);
            this.metroTextBoxDuty.TabIndex = 19;
            this.metroToolTip.SetToolTip(this.metroTextBoxDuty, "PWM Duty (0~100)");
            this.metroTextBoxDuty.UseSelectable = true;
            this.metroTextBoxDuty.UseStyleColors = true;
            // 
            // metroTextBoxFreq
            // 
            this.metroTextBoxFreq.IconRight = true;
            this.metroTextBoxFreq.Lines = new string[0];
            this.metroTextBoxFreq.Location = new System.Drawing.Point(22, 267);
            this.metroTextBoxFreq.MaxLength = 32767;
            this.metroTextBoxFreq.Name = "metroTextBoxFreq";
            this.metroTextBoxFreq.PasswordChar = '\0';
            this.metroTextBoxFreq.PromptText = "Freq(Hz)";
            this.metroTextBoxFreq.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxFreq.SelectedText = "";
            this.metroTextBoxFreq.Size = new System.Drawing.Size(79, 30);
            this.metroTextBoxFreq.TabIndex = 19;
            this.metroToolTip.SetToolTip(this.metroTextBoxFreq, "PWM Frequency(Hz)");
            this.metroTextBoxFreq.UseSelectable = true;
            this.metroTextBoxFreq.UseStyleColors = true;
            // 
            // metroTextBoxPeriod
            // 
            this.metroTextBoxPeriod.IconRight = true;
            this.metroTextBoxPeriod.Lines = new string[0];
            this.metroTextBoxPeriod.Location = new System.Drawing.Point(234, 65);
            this.metroTextBoxPeriod.MaxLength = 32767;
            this.metroTextBoxPeriod.Name = "metroTextBoxPeriod";
            this.metroTextBoxPeriod.PasswordChar = '\0';
            this.metroTextBoxPeriod.PromptText = "Period(ms)";
            this.metroTextBoxPeriod.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxPeriod.SelectedText = "";
            this.metroTextBoxPeriod.Size = new System.Drawing.Size(94, 30);
            this.metroTextBoxPeriod.TabIndex = 19;
            this.metroToolTip.SetToolTip(this.metroTextBoxPeriod, "Set timer period");
            this.metroTextBoxPeriod.UseSelectable = true;
            this.metroTextBoxPeriod.UseStyleColors = true;
            // 
            // metroComboBoxGPIOMode
            // 
            this.metroComboBoxGPIOMode.FormattingEnabled = true;
            this.metroComboBoxGPIOMode.ItemHeight = 24;
            this.metroComboBoxGPIOMode.Items.AddRange(new object[] {
            "gpio.INPUT",
            "gpio.INPUT_PULL_UP",
            "gpio.INPUT_PULL_DOWN",
            "gpio.INPUT_INPUT_HIGH_IMPEDANCE_DOWN ",
            "gpio.OUTPUT",
            "gpio.OUTPUT_PUSH_PULL",
            "gpio.OUTPUT_OPEN_DRAIN_NO_PULL",
            "gpio.OUTPUT_OPEN_DRAIN_PULL_UP",
            "gpio.INT(rising edge)",
            "gpio.INT(falling edge)",
            "gpio.INT(both edges)"});
            this.metroComboBoxGPIOMode.Location = new System.Drawing.Point(102, 131);
            this.metroComboBoxGPIOMode.Name = "metroComboBoxGPIOMode";
            this.metroComboBoxGPIOMode.PromptText = "GPIO Mode";
            this.metroComboBoxGPIOMode.Size = new System.Drawing.Size(327, 30);
            this.metroComboBoxGPIOMode.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxGPIOMode.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxGPIOMode, "GPIO Mode");
            this.metroComboBoxGPIOMode.UseSelectable = true;
            // 
            // metroComboBoxADCPin
            // 
            this.metroComboBoxADCPin.FormattingEnabled = true;
            this.metroComboBoxADCPin.ItemHeight = 24;
            this.metroComboBoxADCPin.Items.AddRange(new object[] {
            "1   pwm/adc",
            "13 pwm/adc",
            "15 pwm/adc",
            "16 pwm/adc",
            "17 adc/led"});
            this.metroComboBoxADCPin.Location = new System.Drawing.Point(290, 236);
            this.metroComboBoxADCPin.Name = "metroComboBoxADCPin";
            this.metroComboBoxADCPin.PromptText = "ADC Pin";
            this.metroComboBoxADCPin.Size = new System.Drawing.Size(95, 30);
            this.metroComboBoxADCPin.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxADCPin.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxADCPin, "ADC Pin");
            this.metroComboBoxADCPin.UseSelectable = true;
            // 
            // metroComboBoxStop
            // 
            this.metroComboBoxStop.FormattingEnabled = true;
            this.metroComboBoxStop.ItemHeight = 24;
            this.metroComboBoxStop.Items.AddRange(new object[] {
            "1",
            "2"});
            this.metroComboBoxStop.Location = new System.Drawing.Point(274, 368);
            this.metroComboBoxStop.Name = "metroComboBoxStop";
            this.metroComboBoxStop.PromptText = "Stop";
            this.metroComboBoxStop.Size = new System.Drawing.Size(52, 30);
            this.metroComboBoxStop.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxStop.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxStop, "Uart Stopbits");
            this.metroComboBoxStop.UseSelectable = true;
            // 
            // metroComboBoxParity
            // 
            this.metroComboBoxParity.FormattingEnabled = true;
            this.metroComboBoxParity.ItemHeight = 24;
            this.metroComboBoxParity.Items.AddRange(new object[] {
            "n",
            "o",
            "e"});
            this.metroComboBoxParity.Location = new System.Drawing.Point(212, 368);
            this.metroComboBoxParity.Name = "metroComboBoxParity";
            this.metroComboBoxParity.PromptText = "Parity";
            this.metroComboBoxParity.Size = new System.Drawing.Size(52, 30);
            this.metroComboBoxParity.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxParity.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxParity, "Uart Parity");
            this.metroComboBoxParity.UseSelectable = true;
            // 
            // metroComboBoxBaud
            // 
            this.metroComboBoxBaud.FormattingEnabled = true;
            this.metroComboBoxBaud.ItemHeight = 24;
            this.metroComboBoxBaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "115200"});
            this.metroComboBoxBaud.Location = new System.Drawing.Point(86, 368);
            this.metroComboBoxBaud.Name = "metroComboBoxBaud";
            this.metroComboBoxBaud.PromptText = "Baud";
            this.metroComboBoxBaud.Size = new System.Drawing.Size(50, 30);
            this.metroComboBoxBaud.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxBaud.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxBaud, "Uart Baudrate");
            this.metroComboBoxBaud.UseSelectable = true;
            // 
            // metroComboBoxBits
            // 
            this.metroComboBoxBits.FormattingEnabled = true;
            this.metroComboBoxBits.ItemHeight = 24;
            this.metroComboBoxBits.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.metroComboBoxBits.Location = new System.Drawing.Point(143, 368);
            this.metroComboBoxBits.Name = "metroComboBoxBits";
            this.metroComboBoxBits.PromptText = "Bits";
            this.metroComboBoxBits.Size = new System.Drawing.Size(56, 30);
            this.metroComboBoxBits.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxBits.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxBits, "Uart Databits");
            this.metroComboBoxBits.UseSelectable = true;
            // 
            // metroComboBoxUart
            // 
            this.metroComboBoxUart.FormattingEnabled = true;
            this.metroComboBoxUart.ItemHeight = 24;
            this.metroComboBoxUart.Items.AddRange(new object[] {
            "1"});
            this.metroComboBoxUart.Location = new System.Drawing.Point(22, 368);
            this.metroComboBoxUart.Name = "metroComboBoxUart";
            this.metroComboBoxUart.PromptText = "Uart";
            this.metroComboBoxUart.Size = new System.Drawing.Size(50, 30);
            this.metroComboBoxUart.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxUart.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxUart, "Uart Index");
            this.metroComboBoxUart.UseSelectable = true;
            // 
            // metroComboBoxPWMPin
            // 
            this.metroComboBoxPWMPin.FormattingEnabled = true;
            this.metroComboBoxPWMPin.ItemHeight = 24;
            this.metroComboBoxPWMPin.Items.AddRange(new object[] {
            "1   pwm/adc",
            "3   pwm",
            "8   pwm/rx1",
            "9   pwm/tx1",
            "10 pwm/scl",
            "11 pwm/sda",
            "12 pwm",
            "13 pwm/adc",
            "14 pwm",
            "15 pwm/adc",
            "16 pwm/adc"});
            this.metroComboBoxPWMPin.Location = new System.Drawing.Point(22, 236);
            this.metroComboBoxPWMPin.Name = "metroComboBoxPWMPin";
            this.metroComboBoxPWMPin.PromptText = "PWM Pin";
            this.metroComboBoxPWMPin.Size = new System.Drawing.Size(80, 30);
            this.metroComboBoxPWMPin.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxPWMPin.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxPWMPin, "PWM Pin");
            this.metroComboBoxPWMPin.UseSelectable = true;
            // 
            // metroComboBoxGPIOPin
            // 
            this.metroComboBoxGPIOPin.FormattingEnabled = true;
            this.metroComboBoxGPIOPin.ItemHeight = 24;
            this.metroComboBoxGPIOPin.Items.AddRange(new object[] {
            "0   boot",
            "1   pwm/adc",
            "2 ",
            "3   pwm",
            "4 ",
            "5   swclk",
            "6   swdio",
            "7",
            "8   pwm/rx1",
            "9   pwm/tx1",
            "10 pwm/scl",
            "11 pwm/sda",
            "12 pwm",
            "13 pwm/adc",
            "14 pwm",
            "15 pwm/adc",
            "16 pwm/adc",
            "17 adc/led"});
            this.metroComboBoxGPIOPin.Location = new System.Drawing.Point(22, 131);
            this.metroComboBoxGPIOPin.Name = "metroComboBoxGPIOPin";
            this.metroComboBoxGPIOPin.PromptText = "GPIO Pin";
            this.metroComboBoxGPIOPin.Size = new System.Drawing.Size(80, 30);
            this.metroComboBoxGPIOPin.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxGPIOPin.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxGPIOPin, "GPIO Pin");
            this.metroComboBoxGPIOPin.UseSelectable = true;
            // 
            // metroComboBoxTimerID
            // 
            this.metroComboBoxTimerID.FormattingEnabled = true;
            this.metroComboBoxTimerID.ItemHeight = 24;
            this.metroComboBoxTimerID.Items.AddRange(new object[] {
            "Tmr  0",
            "Tmr  1",
            "Tmr  2",
            "Tmr  3",
            "Tmr  4",
            "Tmr  5",
            "Tmr  6",
            "Tmr  7",
            "Tmr  8",
            "Tmr  9",
            "Tmr 10",
            "Tmr 11",
            "Tmr 12",
            "Tmr 13",
            "Tmr 14",
            "Tmr 15"});
            this.metroComboBoxTimerID.Location = new System.Drawing.Point(234, 32);
            this.metroComboBoxTimerID.Name = "metroComboBoxTimerID";
            this.metroComboBoxTimerID.PromptText = "Timer ID";
            this.metroComboBoxTimerID.Size = new System.Drawing.Size(93, 30);
            this.metroComboBoxTimerID.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroComboBoxTimerID.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.metroComboBoxTimerID, "Timer ID");
            this.metroComboBoxTimerID.UseSelectable = true;
            // 
            // metroButtonBootR
            // 
            this.metroButtonBootR.Highlight = true;
            this.metroButtonBootR.Location = new System.Drawing.Point(23, 65);
            this.metroButtonBootR.Name = "metroButtonBootR";
            this.metroButtonBootR.Size = new System.Drawing.Size(127, 34);
            this.metroButtonBootR.TabIndex = 6;
            this.metroButtonBootR.Text = "Boot reason";
            this.metroToolTip.SetToolTip(this.metroButtonBootR, "Get WiFiMCU Boot reason");
            this.metroButtonBootR.UseSelectable = true;
            this.metroButtonBootR.Click += new System.EventHandler(this.metroButtonBootR_Click);
            // 
            // btnTimerStop
            // 
            this.btnTimerStop.Highlight = true;
            this.btnTimerStop.Location = new System.Drawing.Point(390, 25);
            this.btnTimerStop.Name = "btnTimerStop";
            this.btnTimerStop.Size = new System.Drawing.Size(39, 34);
            this.btnTimerStop.TabIndex = 6;
            this.btnTimerStop.Text = "Stop";
            this.metroToolTip.SetToolTip(this.btnTimerStop, "Stop timer");
            this.btnTimerStop.UseSelectable = true;
            this.btnTimerStop.Click += new System.EventHandler(this.btnTimerStop_Click);
            // 
            // btnTimerDelay
            // 
            this.btnTimerDelay.Highlight = true;
            this.btnTimerDelay.Location = new System.Drawing.Point(390, 65);
            this.btnTimerDelay.Name = "btnTimerDelay";
            this.btnTimerDelay.Size = new System.Drawing.Size(39, 34);
            this.btnTimerDelay.TabIndex = 6;
            this.btnTimerDelay.Text = "Delay";
            this.metroToolTip.SetToolTip(this.btnTimerDelay, "Timer Delay");
            this.btnTimerDelay.UseSelectable = true;
            this.btnTimerDelay.Click += new System.EventHandler(this.btnTimerDelay_Click);
            // 
            // btnTimerWd
            // 
            this.btnTimerWd.Highlight = true;
            this.btnTimerWd.Location = new System.Drawing.Point(345, 65);
            this.btnTimerWd.Name = "btnTimerWd";
            this.btnTimerWd.Size = new System.Drawing.Size(39, 34);
            this.btnTimerWd.TabIndex = 6;
            this.btnTimerWd.Text = "WatchDog Clear";
            this.metroToolTip.SetToolTip(this.btnTimerWd, "WatchDog Clear");
            this.btnTimerWd.UseSelectable = true;
            this.btnTimerWd.Click += new System.EventHandler(this.btnTimerWd_Click);
            // 
            // btnTimerStart
            // 
            this.btnTimerStart.Highlight = true;
            this.btnTimerStart.Location = new System.Drawing.Point(345, 25);
            this.btnTimerStart.Name = "btnTimerStart";
            this.btnTimerStart.Size = new System.Drawing.Size(39, 34);
            this.btnTimerStart.TabIndex = 6;
            this.btnTimerStart.Text = "Start";
            this.metroToolTip.SetToolTip(this.btnTimerStart, "Start timer");
            this.btnTimerStart.UseSelectable = true;
            this.btnTimerStart.Click += new System.EventHandler(this.btnTimerStart_Click);
            // 
            // metroButtonChipid
            // 
            this.metroButtonChipid.Highlight = true;
            this.metroButtonChipid.Location = new System.Drawing.Point(103, 25);
            this.metroButtonChipid.Name = "metroButtonChipid";
            this.metroButtonChipid.Size = new System.Drawing.Size(47, 34);
            this.metroButtonChipid.TabIndex = 6;
            this.metroButtonChipid.Text = "Chipid";
            this.metroToolTip.SetToolTip(this.metroButtonChipid, "Get WiFiMCU Chipid");
            this.metroButtonChipid.UseSelectable = true;
            this.metroButtonChipid.Click += new System.EventHandler(this.metroButtonChipid_Click);
            // 
            // metroButtonInfo
            // 
            this.metroButtonInfo.Highlight = true;
            this.metroButtonInfo.Location = new System.Drawing.Point(63, 25);
            this.metroButtonInfo.Name = "metroButtonInfo";
            this.metroButtonInfo.Size = new System.Drawing.Size(34, 34);
            this.metroButtonInfo.TabIndex = 6;
            this.metroButtonInfo.Text = "Info";
            this.metroToolTip.SetToolTip(this.metroButtonInfo, "Get WiFiMCU Information");
            this.metroButtonInfo.UseSelectable = true;
            this.metroButtonInfo.Click += new System.EventHandler(this.metroButtonInfo_Click);
            // 
            // metroLabel9
            // 
            this.metroLabel9.AutoSize = true;
            this.metroLabel9.Location = new System.Drawing.Point(218, 5);
            this.metroLabel9.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel9.Name = "metroLabel9";
            this.metroLabel9.Size = new System.Drawing.Size(104, 20);
            this.metroLabel9.TabIndex = 5;
            this.metroLabel9.Text = "Timer Module";
            this.metroLabel9.UseStyleColors = true;
            // 
            // metroLabel26
            // 
            this.metroLabel26.AutoSize = true;
            this.metroLabel26.Location = new System.Drawing.Point(218, 214);
            this.metroLabel26.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel26.Name = "metroLabel26";
            this.metroLabel26.Size = new System.Drawing.Size(96, 20);
            this.metroLabel26.TabIndex = 5;
            this.metroLabel26.Text = "ADC Module";
            this.metroLabel26.UseStyleColors = true;
            // 
            // metroLabel27
            // 
            this.metroLabel27.AutoSize = true;
            this.metroLabel27.Location = new System.Drawing.Point(12, 347);
            this.metroLabel27.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel27.Name = "metroLabel27";
            this.metroLabel27.Size = new System.Drawing.Size(94, 20);
            this.metroLabel27.TabIndex = 5;
            this.metroLabel27.Text = "Uart Module";
            this.metroLabel27.UseStyleColors = true;
            // 
            // metroLabel25
            // 
            this.metroLabel25.AutoSize = true;
            this.metroLabel25.Location = new System.Drawing.Point(12, 214);
            this.metroLabel25.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel25.Name = "metroLabel25";
            this.metroLabel25.Size = new System.Drawing.Size(103, 20);
            this.metroLabel25.TabIndex = 5;
            this.metroLabel25.Text = "PWM Module";
            this.metroLabel25.UseStyleColors = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(12, 5);
            this.metroLabel1.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(99, 20);
            this.metroLabel1.TabIndex = 5;
            this.metroLabel1.Text = "MCU Module";
            this.metroLabel1.UseStyleColors = true;
            // 
            // metroLabel8
            // 
            this.metroLabel8.AutoSize = true;
            this.metroLabel8.Location = new System.Drawing.Point(12, 111);
            this.metroLabel8.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(100, 20);
            this.metroLabel8.TabIndex = 5;
            this.metroLabel8.Text = "GPIO Module";
            this.metroLabel8.UseStyleColors = true;
            // 
            // btnGPIOSetmode
            // 
            this.btnGPIOSetmode.Highlight = true;
            this.btnGPIOSetmode.Location = new System.Drawing.Point(22, 166);
            this.btnGPIOSetmode.Name = "btnGPIOSetmode";
            this.btnGPIOSetmode.Size = new System.Drawing.Size(68, 34);
            this.btnGPIOSetmode.TabIndex = 6;
            this.btnGPIOSetmode.Text = "Set Mode";
            this.metroToolTip.SetToolTip(this.btnGPIOSetmode, "Set GPIO Mode");
            this.btnGPIOSetmode.UseSelectable = true;
            this.btnGPIOSetmode.Click += new System.EventHandler(this.btnGPIOSetmode_Click);
            // 
            // btnGPIOToggle
            // 
            this.btnGPIOToggle.Highlight = true;
            this.btnGPIOToggle.Location = new System.Drawing.Point(184, 166);
            this.btnGPIOToggle.Name = "btnGPIOToggle";
            this.btnGPIOToggle.Size = new System.Drawing.Size(58, 34);
            this.btnGPIOToggle.TabIndex = 6;
            this.btnGPIOToggle.Text = "Toggle";
            this.metroToolTip.SetToolTip(this.btnGPIOToggle, "Toggle GPIO output");
            this.btnGPIOToggle.UseSelectable = true;
            this.btnGPIOToggle.Click += new System.EventHandler(this.btnGPIOToggle_Click);
            // 
            // btnGPIOSetLow
            // 
            this.btnGPIOSetLow.Highlight = true;
            this.btnGPIOSetLow.Location = new System.Drawing.Point(370, 166);
            this.btnGPIOSetLow.Name = "btnGPIOSetLow";
            this.btnGPIOSetLow.Size = new System.Drawing.Size(58, 34);
            this.btnGPIOSetLow.TabIndex = 6;
            this.btnGPIOSetLow.Text = "Set Low";
            this.metroToolTip.SetToolTip(this.btnGPIOSetLow, "Set GPIO output low");
            this.btnGPIOSetLow.UseSelectable = true;
            this.btnGPIOSetLow.Click += new System.EventHandler(this.btnGPIOSetLow_Click);
            // 
            // btnGPIOSetHigh
            // 
            this.btnGPIOSetHigh.Highlight = true;
            this.btnGPIOSetHigh.Location = new System.Drawing.Point(281, 166);
            this.btnGPIOSetHigh.Name = "btnGPIOSetHigh";
            this.btnGPIOSetHigh.Size = new System.Drawing.Size(58, 34);
            this.btnGPIOSetHigh.TabIndex = 6;
            this.btnGPIOSetHigh.Text = "Set High";
            this.metroToolTip.SetToolTip(this.btnGPIOSetHigh, "Set GPIO output high");
            this.btnGPIOSetHigh.UseSelectable = true;
            this.btnGPIOSetHigh.Click += new System.EventHandler(this.btnGPIOSetHigh_Click);
            // 
            // metroButtonVer
            // 
            this.metroButtonVer.Highlight = true;
            this.metroButtonVer.Location = new System.Drawing.Point(22, 25);
            this.metroButtonVer.Name = "metroButtonVer";
            this.metroButtonVer.Size = new System.Drawing.Size(34, 34);
            this.metroButtonVer.TabIndex = 6;
            this.metroButtonVer.Text = "Ver";
            this.metroToolTip.SetToolTip(this.metroButtonVer, "Get wifimcu version");
            this.metroButtonVer.UseSelectable = true;
            this.metroButtonVer.Click += new System.EventHandler(this.metroButtonVer_Click);
            // 
            // metroButtonPWMStop
            // 
            this.metroButtonPWMStop.Highlight = true;
            this.metroButtonPWMStop.Location = new System.Drawing.Point(107, 290);
            this.metroButtonPWMStop.Name = "metroButtonPWMStop";
            this.metroButtonPWMStop.Size = new System.Drawing.Size(58, 43);
            this.metroButtonPWMStop.TabIndex = 6;
            this.metroButtonPWMStop.Text = "Stop";
            this.metroToolTip.SetToolTip(this.metroButtonPWMStop, "Stop PWM");
            this.metroButtonPWMStop.UseSelectable = true;
            this.metroButtonPWMStop.Click += new System.EventHandler(this.metroButtonPWMStop_Click);
            // 
            // metroButtonADCRead
            // 
            this.metroButtonADCRead.Highlight = true;
            this.metroButtonADCRead.Location = new System.Drawing.Point(290, 276);
            this.metroButtonADCRead.Name = "metroButtonADCRead";
            this.metroButtonADCRead.Size = new System.Drawing.Size(94, 46);
            this.metroButtonADCRead.TabIndex = 6;
            this.metroButtonADCRead.Text = "Read";
            this.metroToolTip.SetToolTip(this.metroButtonADCRead, "Read ADC Vaule");
            this.metroButtonADCRead.UseSelectable = true;
            this.metroButtonADCRead.Click += new System.EventHandler(this.metroButtonADCRead_Click);
            // 
            // metroButtonUartSend
            // 
            this.metroButtonUartSend.Highlight = true;
            this.metroButtonUartSend.Location = new System.Drawing.Point(386, 368);
            this.metroButtonUartSend.Name = "metroButtonUartSend";
            this.metroButtonUartSend.Size = new System.Drawing.Size(43, 63);
            this.metroButtonUartSend.TabIndex = 6;
            this.metroButtonUartSend.Text = "Send";
            this.metroToolTip.SetToolTip(this.metroButtonUartSend, "Send data via uart");
            this.metroButtonUartSend.UseSelectable = true;
            this.metroButtonUartSend.Click += new System.EventHandler(this.metroButtonUartSend_Click);
            // 
            // metroButtonSet
            // 
            this.metroButtonSet.Highlight = true;
            this.metroButtonSet.Location = new System.Drawing.Point(331, 368);
            this.metroButtonSet.Name = "metroButtonSet";
            this.metroButtonSet.Size = new System.Drawing.Size(49, 26);
            this.metroButtonSet.TabIndex = 6;
            this.metroButtonSet.Text = "Set";
            this.metroToolTip.SetToolTip(this.metroButtonSet, "Setup uart");
            this.metroButtonSet.UseSelectable = true;
            this.metroButtonSet.Click += new System.EventHandler(this.metroButtonSet_Click);
            // 
            // metroButtonPWMStart
            // 
            this.metroButtonPWMStart.Highlight = true;
            this.metroButtonPWMStart.Location = new System.Drawing.Point(107, 236);
            this.metroButtonPWMStart.Name = "metroButtonPWMStart";
            this.metroButtonPWMStart.Size = new System.Drawing.Size(58, 48);
            this.metroButtonPWMStart.TabIndex = 6;
            this.metroButtonPWMStart.Text = "Start";
            this.metroToolTip.SetToolTip(this.metroButtonPWMStart, "Start PWM");
            this.metroButtonPWMStart.UseSelectable = true;
            this.metroButtonPWMStart.Click += new System.EventHandler(this.metroButtonPWMStart_Click);
            // 
            // btnGPIORead
            // 
            this.btnGPIORead.Highlight = true;
            this.btnGPIORead.Location = new System.Drawing.Point(102, 166);
            this.btnGPIORead.Name = "btnGPIORead";
            this.btnGPIORead.Size = new System.Drawing.Size(58, 34);
            this.btnGPIORead.TabIndex = 6;
            this.btnGPIORead.Text = "Read";
            this.metroToolTip.SetToolTip(this.btnGPIORead, "Read GPIP Vaule");
            this.btnGPIORead.UseSelectable = true;
            this.btnGPIORead.Click += new System.EventHandler(this.btnGPIORead_Click);
            // 
            // metroTabPage3
            // 
            this.metroTabPage3.Controls.Add(this.checkBoxBindLoaclPort);
            this.metroTabPage3.Controls.Add(this.metroToggleTransType);
            this.metroTabPage3.Controls.Add(this.metroToggleSocketType);
            this.metroTabPage3.Controls.Add(this.textBoxSTAPSW);
            this.metroTabPage3.Controls.Add(this.textBoxAPPSW);
            this.metroTabPage3.Controls.Add(this.textBoxBindLoadPort);
            this.metroTabPage3.Controls.Add(this.textBoxIP);
            this.metroTabPage3.Controls.Add(this.labelPort);
            this.metroTabPage3.Controls.Add(this.textBoxSendData);
            this.metroTabPage3.Controls.Add(this.textBoxSTASSID);
            this.metroTabPage3.Controls.Add(this.textBoxAPSSID);
            this.metroTabPage3.Controls.Add(this.metroLabel4);
            this.metroTabPage3.Controls.Add(this.metroLabel6);
            this.metroTabPage3.Controls.Add(this.metroLabel13);
            this.metroTabPage3.Controls.Add(this.metroLabel7);
            this.metroTabPage3.Controls.Add(this.metroLabel12);
            this.metroTabPage3.Controls.Add(this.metroLabel11);
            this.metroTabPage3.Controls.Add(this.metroLabel10);
            this.metroTabPage3.Controls.Add(this.metroLabel5);
            this.metroTabPage3.Controls.Add(this.metroLabel3);
            this.metroTabPage3.Controls.Add(this.metroLabel2);
            this.metroTabPage3.Controls.Add(this.btnStartSTA);
            this.metroTabPage3.Controls.Add(this.btnStopSTA);
            this.metroTabPage3.Controls.Add(this.btnStopAP);
            this.metroTabPage3.Controls.Add(this.btnSendData);
            this.metroTabPage3.Controls.Add(this.btnNetSet);
            this.metroTabPage3.Controls.Add(this.metroButtonScan);
            this.metroTabPage3.Controls.Add(this.btnGetAPIP);
            this.metroTabPage3.Controls.Add(this.btnGetSTALink);
            this.metroTabPage3.Controls.Add(this.btnGetSTAIP);
            this.metroTabPage3.Controls.Add(this.btnStartAP);
            this.metroTabPage3.HorizontalScrollbar = true;
            this.metroTabPage3.HorizontalScrollbarBarColor = true;
            this.metroTabPage3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.HorizontalScrollbarSize = 9;
            this.metroTabPage3.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage3.Name = "metroTabPage3";
            this.metroTabPage3.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.metroTabPage3.Size = new System.Drawing.Size(484, 434);
            this.metroTabPage3.TabIndex = 2;
            this.metroTabPage3.Text = "   WiFi&&Net   ";
            this.metroTabPage3.VerticalScrollbar = true;
            this.metroTabPage3.VerticalScrollbarBarColor = true;
            this.metroTabPage3.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage3.VerticalScrollbarSize = 10;
            this.metroTabPage3.Visible = false;
            // 
            // checkBoxBindLoaclPort
            // 
            this.checkBoxBindLoaclPort.AutoSize = true;
            this.checkBoxBindLoaclPort.Enabled = false;
            this.checkBoxBindLoaclPort.Location = new System.Drawing.Point(350, 178);
            this.checkBoxBindLoaclPort.Name = "checkBoxBindLoaclPort";
            this.checkBoxBindLoaclPort.Size = new System.Drawing.Size(112, 17);
            this.checkBoxBindLoaclPort.TabIndex = 25;
            this.checkBoxBindLoaclPort.Text = "Bind Local Port";
            this.metroToolTip.SetToolTip(this.checkBoxBindLoaclPort, "Bind local port for socket");
            this.checkBoxBindLoaclPort.UseSelectable = true;
            this.checkBoxBindLoaclPort.UseStyleColors = true;
            this.checkBoxBindLoaclPort.CheckedChanged += new System.EventHandler(this.checkBoxBindLoaclPort_CheckedChanged);
            this.checkBoxBindLoaclPort.EnabledChanged += new System.EventHandler(this.checkBoxBindLoaclPort_EnabledChanged);
            // 
            // metroToggleTransType
            // 
            this.metroToggleTransType.AutoSize = true;
            this.metroToggleTransType.DisplayStatus = false;
            this.metroToggleTransType.Location = new System.Drawing.Point(218, 205);
            this.metroToggleTransType.Name = "metroToggleTransType";
            this.metroToggleTransType.Size = new System.Drawing.Size(50, 16);
            this.metroToggleTransType.TabIndex = 24;
            this.metroToggleTransType.Text = "Off";
            this.metroToolTip.SetToolTip(this.metroToggleTransType, "Select Transport Type TCP or UDP");
            this.metroToggleTransType.UseSelectable = true;
            this.metroToggleTransType.UseStyleColors = true;
            // 
            // metroToggleSocketType
            // 
            this.metroToggleSocketType.AutoSize = true;
            this.metroToggleSocketType.DisplayStatus = false;
            this.metroToggleSocketType.Location = new System.Drawing.Point(218, 178);
            this.metroToggleSocketType.Name = "metroToggleSocketType";
            this.metroToggleSocketType.Size = new System.Drawing.Size(50, 16);
            this.metroToggleSocketType.TabIndex = 24;
            this.metroToggleSocketType.Text = "Off";
            this.metroToolTip.SetToolTip(this.metroToggleSocketType, "Select Socket Type Server or Client");
            this.metroToggleSocketType.UseSelectable = true;
            this.metroToggleSocketType.UseStyleColors = true;
            this.metroToggleSocketType.CheckStateChanged += new System.EventHandler(this.metroToggleSocketType_CheckStateChanged);
            // 
            // textBoxSTAPSW
            // 
            this.textBoxSTAPSW.IconRight = true;
            this.textBoxSTAPSW.Lines = new string[0];
            this.textBoxSTAPSW.Location = new System.Drawing.Point(285, 91);
            this.textBoxSTAPSW.MaxLength = 32767;
            this.textBoxSTAPSW.Name = "textBoxSTAPSW";
            this.textBoxSTAPSW.PasswordChar = '\0';
            this.textBoxSTAPSW.PromptText = "Password for STA...";
            this.textBoxSTAPSW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSTAPSW.SelectedText = "";
            this.textBoxSTAPSW.Size = new System.Drawing.Size(86, 30);
            this.textBoxSTAPSW.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxSTAPSW, "Set Password for STATION Mode");
            this.textBoxSTAPSW.UseSelectable = true;
            this.textBoxSTAPSW.UseStyleColors = true;
            // 
            // textBoxAPPSW
            // 
            this.textBoxAPPSW.IconRight = true;
            this.textBoxAPPSW.Lines = new string[0];
            this.textBoxAPPSW.Location = new System.Drawing.Point(12, 91);
            this.textBoxAPPSW.MaxLength = 32767;
            this.textBoxAPPSW.Name = "textBoxAPPSW";
            this.textBoxAPPSW.PasswordChar = '\0';
            this.textBoxAPPSW.PromptText = "Password for AP...";
            this.textBoxAPPSW.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAPPSW.SelectedText = "";
            this.textBoxAPPSW.Size = new System.Drawing.Size(112, 30);
            this.textBoxAPPSW.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxAPPSW, "Password for AP...");
            this.textBoxAPPSW.UseSelectable = true;
            this.textBoxAPPSW.UseStyleColors = true;
            // 
            // textBoxBindLoadPort
            // 
            this.textBoxBindLoadPort.Enabled = false;
            this.textBoxBindLoadPort.IconRight = true;
            this.textBoxBindLoadPort.Lines = new string[0];
            this.textBoxBindLoadPort.Location = new System.Drawing.Point(350, 196);
            this.textBoxBindLoadPort.MaxLength = 32767;
            this.textBoxBindLoadPort.Name = "textBoxBindLoadPort";
            this.textBoxBindLoadPort.PasswordChar = '\0';
            this.textBoxBindLoadPort.PromptText = "Bind Port";
            this.textBoxBindLoadPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxBindLoadPort.SelectedText = "";
            this.textBoxBindLoadPort.Size = new System.Drawing.Size(83, 30);
            this.textBoxBindLoadPort.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxBindLoadPort, "Bind Port");
            this.textBoxBindLoadPort.UseSelectable = true;
            this.textBoxBindLoadPort.UseStyleColors = true;
            // 
            // textBoxIP
            // 
            this.textBoxIP.Enabled = false;
            this.textBoxIP.IconRight = true;
            this.textBoxIP.Lines = new string[0];
            this.textBoxIP.Location = new System.Drawing.Point(14, 233);
            this.textBoxIP.MaxLength = 32767;
            this.textBoxIP.Name = "textBoxIP";
            this.textBoxIP.PasswordChar = '\0';
            this.textBoxIP.PromptText = "Remote IP/Domain";
            this.textBoxIP.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxIP.SelectedText = "";
            this.textBoxIP.Size = new System.Drawing.Size(265, 30);
            this.textBoxIP.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxIP, "Remote IP/Domain");
            this.textBoxIP.UseSelectable = true;
            this.textBoxIP.UseStyleColors = true;
            // 
            // labelPort
            // 
            this.labelPort.IconRight = true;
            this.labelPort.Lines = new string[0];
            this.labelPort.Location = new System.Drawing.Point(285, 233);
            this.labelPort.MaxLength = 32767;
            this.labelPort.Name = "labelPort";
            this.labelPort.PasswordChar = '\0';
            this.labelPort.PromptText = "Local Port";
            this.labelPort.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.labelPort.SelectedText = "";
            this.labelPort.Size = new System.Drawing.Size(98, 30);
            this.labelPort.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.labelPort, "Local Port or Remote Port");
            this.labelPort.UseSelectable = true;
            this.labelPort.UseStyleColors = true;
            // 
            // textBoxSendData
            // 
            this.textBoxSendData.IconRight = true;
            this.textBoxSendData.Lines = new string[0];
            this.textBoxSendData.Location = new System.Drawing.Point(14, 278);
            this.textBoxSendData.MaxLength = 32767;
            this.textBoxSendData.Name = "textBoxSendData";
            this.textBoxSendData.PasswordChar = '\0';
            this.textBoxSendData.PromptText = "Send Data...";
            this.textBoxSendData.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSendData.SelectedText = "";
            this.textBoxSendData.Size = new System.Drawing.Size(368, 30);
            this.textBoxSendData.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxSendData, "Send Data...");
            this.textBoxSendData.UseSelectable = true;
            this.textBoxSendData.UseStyleColors = true;
            // 
            // textBoxSTASSID
            // 
            this.textBoxSTASSID.IconRight = true;
            this.textBoxSTASSID.Lines = new string[0];
            this.textBoxSTASSID.Location = new System.Drawing.Point(285, 54);
            this.textBoxSTASSID.MaxLength = 32767;
            this.textBoxSTASSID.Name = "textBoxSTASSID";
            this.textBoxSTASSID.PasswordChar = '\0';
            this.textBoxSTASSID.PromptText = "SSID for STA...";
            this.textBoxSTASSID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxSTASSID.SelectedText = "";
            this.textBoxSTASSID.Size = new System.Drawing.Size(86, 30);
            this.textBoxSTASSID.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxSTASSID, "Set SSID for STATION Mode");
            this.textBoxSTASSID.UseSelectable = true;
            this.textBoxSTASSID.UseStyleColors = true;
            // 
            // textBoxAPSSID
            // 
            this.textBoxAPSSID.IconRight = true;
            this.textBoxAPSSID.Lines = new string[0];
            this.textBoxAPSSID.Location = new System.Drawing.Point(12, 54);
            this.textBoxAPSSID.MaxLength = 32767;
            this.textBoxAPSSID.Name = "textBoxAPSSID";
            this.textBoxAPSSID.PasswordChar = '\0';
            this.textBoxAPSSID.PromptText = "SSID for AP...";
            this.textBoxAPSSID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.textBoxAPSSID.SelectedText = "";
            this.textBoxAPSSID.Size = new System.Drawing.Size(112, 30);
            this.textBoxAPSSID.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.textBoxAPSSID, "SSID for AP...");
            this.textBoxAPSSID.UseSelectable = true;
            this.textBoxAPSSID.UseStyleColors = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(292, 30);
            this.metroLabel4.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(78, 20);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "STA mode";
            this.metroLabel4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel4.UseStyleColors = true;
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(14, 154);
            this.metroLabel6.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(90, 20);
            this.metroLabel6.TabIndex = 20;
            this.metroLabel6.Text = "Net Module";
            this.metroLabel6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel6.UseStyleColors = true;
            // 
            // metroLabel13
            // 
            this.metroLabel13.AutoSize = true;
            this.metroLabel13.Location = new System.Drawing.Point(50, 205);
            this.metroLabel13.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel13.Name = "metroLabel13";
            this.metroLabel13.Size = new System.Drawing.Size(112, 20);
            this.metroLabel13.TabIndex = 20;
            this.metroLabel13.Text = "Transport Type:";
            this.metroLabel13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel13.UseStyleColors = true;
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(65, 178);
            this.metroLabel7.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(93, 20);
            this.metroLabel7.TabIndex = 20;
            this.metroLabel7.Text = "Socket Type:";
            this.metroLabel7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel7.UseStyleColors = true;
            // 
            // metroLabel12
            // 
            this.metroLabel12.AutoSize = true;
            this.metroLabel12.Location = new System.Drawing.Point(273, 205);
            this.metroLabel12.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel12.Name = "metroLabel12";
            this.metroLabel12.Size = new System.Drawing.Size(39, 20);
            this.metroLabel12.TabIndex = 20;
            this.metroLabel12.Text = "UDP";
            this.metroLabel12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel12.UseStyleColors = true;
            // 
            // metroLabel11
            // 
            this.metroLabel11.AutoSize = true;
            this.metroLabel11.Location = new System.Drawing.Point(172, 204);
            this.metroLabel11.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel11.Name = "metroLabel11";
            this.metroLabel11.Size = new System.Drawing.Size(35, 20);
            this.metroLabel11.TabIndex = 20;
            this.metroLabel11.Text = "TCP";
            this.metroLabel11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel11.UseStyleColors = true;
            // 
            // metroLabel10
            // 
            this.metroLabel10.AutoSize = true;
            this.metroLabel10.Location = new System.Drawing.Point(273, 178);
            this.metroLabel10.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel10.Name = "metroLabel10";
            this.metroLabel10.Size = new System.Drawing.Size(48, 20);
            this.metroLabel10.TabIndex = 20;
            this.metroLabel10.Text = "Client";
            this.metroLabel10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel10.UseStyleColors = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(158, 177);
            this.metroLabel5.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(50, 20);
            this.metroLabel5.TabIndex = 20;
            this.metroLabel5.Text = "Server";
            this.metroLabel5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel5.UseStyleColors = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(12, 30);
            this.metroLabel3.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(71, 20);
            this.metroLabel3.TabIndex = 20;
            this.metroLabel3.Text = "AP mode";
            this.metroLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel3.UseStyleColors = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(12, 5);
            this.metroLabel2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(95, 20);
            this.metroLabel2.TabIndex = 20;
            this.metroLabel2.Text = "WiFi Module";
            this.metroLabel2.UseStyleColors = true;
            // 
            // btnStartSTA
            // 
            this.btnStartSTA.Highlight = true;
            this.btnStartSTA.Location = new System.Drawing.Point(377, 54);
            this.btnStartSTA.Name = "btnStartSTA";
            this.btnStartSTA.Size = new System.Drawing.Size(44, 30);
            this.btnStartSTA.TabIndex = 21;
            this.btnStartSTA.Text = "Start";
            this.metroToolTip.SetToolTip(this.btnStartSTA, "Connect to remote AP");
            this.btnStartSTA.UseSelectable = true;
            this.btnStartSTA.Click += new System.EventHandler(this.btnStartSTA_Click);
            // 
            // btnStopSTA
            // 
            this.btnStopSTA.Highlight = true;
            this.btnStopSTA.Location = new System.Drawing.Point(377, 91);
            this.btnStopSTA.Name = "btnStopSTA";
            this.btnStopSTA.Size = new System.Drawing.Size(44, 30);
            this.btnStopSTA.TabIndex = 21;
            this.btnStopSTA.Text = "Stop";
            this.metroToolTip.SetToolTip(this.btnStopSTA, "Disconnect  from remote AP");
            this.btnStopSTA.UseSelectable = true;
            this.btnStopSTA.Click += new System.EventHandler(this.btnStopSTA_Click);
            // 
            // btnStopAP
            // 
            this.btnStopAP.Highlight = true;
            this.btnStopAP.Location = new System.Drawing.Point(130, 91);
            this.btnStopAP.Name = "btnStopAP";
            this.btnStopAP.Size = new System.Drawing.Size(44, 30);
            this.btnStopAP.TabIndex = 21;
            this.btnStopAP.Text = "Stop";
            this.metroToolTip.SetToolTip(this.btnStopAP, "Stop Soft AP");
            this.btnStopAP.UseSelectable = true;
            this.btnStopAP.Click += new System.EventHandler(this.btnStopAP_Click);
            // 
            // btnSendData
            // 
            this.btnSendData.Highlight = true;
            this.btnSendData.Location = new System.Drawing.Point(388, 274);
            this.btnSendData.Name = "btnSendData";
            this.btnSendData.Size = new System.Drawing.Size(83, 34);
            this.btnSendData.TabIndex = 21;
            this.btnSendData.Text = "Send";
            this.metroToolTip.SetToolTip(this.btnSendData, "Send Data");
            this.btnSendData.UseSelectable = true;
            this.btnSendData.Click += new System.EventHandler(this.btnSendData_Click);
            // 
            // btnNetSet
            // 
            this.btnNetSet.Highlight = true;
            this.btnNetSet.Location = new System.Drawing.Point(388, 233);
            this.btnNetSet.Name = "btnNetSet";
            this.btnNetSet.Size = new System.Drawing.Size(83, 34);
            this.btnNetSet.TabIndex = 21;
            this.btnNetSet.Text = "Set";
            this.metroToolTip.SetToolTip(this.btnNetSet, "Set Net Mode");
            this.btnNetSet.UseSelectable = true;
            this.btnNetSet.Click += new System.EventHandler(this.btnNetSet_Click);
            // 
            // metroButtonScan
            // 
            this.metroButtonScan.Highlight = true;
            this.metroButtonScan.Location = new System.Drawing.Point(236, 54);
            this.metroButtonScan.Name = "metroButtonScan";
            this.metroButtonScan.Size = new System.Drawing.Size(44, 67);
            this.metroButtonScan.TabIndex = 21;
            this.metroButtonScan.Text = "Scan";
            this.metroToolTip.SetToolTip(this.metroButtonScan, "Scan AP signals");
            this.metroButtonScan.UseSelectable = true;
            this.metroButtonScan.Click += new System.EventHandler(this.metroButtonScan_Click);
            // 
            // btnGetAPIP
            // 
            this.btnGetAPIP.Highlight = true;
            this.btnGetAPIP.Location = new System.Drawing.Point(179, 54);
            this.btnGetAPIP.Name = "btnGetAPIP";
            this.btnGetAPIP.Size = new System.Drawing.Size(44, 67);
            this.btnGetAPIP.TabIndex = 21;
            this.btnGetAPIP.Text = "AP IP";
            this.metroToolTip.SetToolTip(this.btnGetAPIP, "Get AP IP address");
            this.btnGetAPIP.UseSelectable = true;
            this.btnGetAPIP.Click += new System.EventHandler(this.btnGetAPIP_Click);
            // 
            // btnGetSTALink
            // 
            this.btnGetSTALink.Highlight = true;
            this.btnGetSTALink.Location = new System.Drawing.Point(428, 91);
            this.btnGetSTALink.Name = "btnGetSTALink";
            this.btnGetSTALink.Size = new System.Drawing.Size(44, 30);
            this.btnGetSTALink.TabIndex = 21;
            this.btnGetSTALink.Text = "Link";
            this.metroToolTip.SetToolTip(this.btnGetSTALink, "Get STA link status");
            this.btnGetSTALink.UseSelectable = true;
            this.btnGetSTALink.Click += new System.EventHandler(this.btnGetSTALink_Click);
            // 
            // btnGetSTAIP
            // 
            this.btnGetSTAIP.Highlight = true;
            this.btnGetSTAIP.Location = new System.Drawing.Point(428, 54);
            this.btnGetSTAIP.Name = "btnGetSTAIP";
            this.btnGetSTAIP.Size = new System.Drawing.Size(44, 30);
            this.btnGetSTAIP.TabIndex = 21;
            this.btnGetSTAIP.Text = "STA IP";
            this.metroToolTip.SetToolTip(this.btnGetSTAIP, "Get STA IP status");
            this.btnGetSTAIP.UseSelectable = true;
            this.btnGetSTAIP.Click += new System.EventHandler(this.btnGetSTAIP_Click);
            // 
            // btnStartAP
            // 
            this.btnStartAP.Highlight = true;
            this.btnStartAP.Location = new System.Drawing.Point(130, 54);
            this.btnStartAP.Name = "btnStartAP";
            this.btnStartAP.Size = new System.Drawing.Size(44, 30);
            this.btnStartAP.TabIndex = 21;
            this.btnStartAP.Text = "Start";
            this.metroToolTip.SetToolTip(this.btnStartAP, "Start Soft AP");
            this.btnStartAP.UseSelectable = true;
            this.btnStartAP.Click += new System.EventHandler(this.btnStartAP_Click);
            // 
            // metroTabPage4
            // 
            this.metroTabPage4.Controls.Add(this.metroButtonFileState);
            this.metroTabPage4.Controls.Add(this.metroButton42);
            this.metroTabPage4.Controls.Add(this.btnFilelist);
            this.metroTabPage4.Controls.Add(this.btnFileUpload);
            this.metroTabPage4.Controls.Add(this.listView1);
            this.metroTabPage4.Controls.Add(this.metroLabelUploadProgress);
            this.metroTabPage4.Controls.Add(this.metroProgressSpinner);
            this.metroTabPage4.Controls.Add(this.metroTileFormat);
            this.metroTabPage4.HorizontalScrollbarBarColor = true;
            this.metroTabPage4.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.HorizontalScrollbarSize = 9;
            this.metroTabPage4.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage4.Name = "metroTabPage4";
            this.metroTabPage4.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.metroTabPage4.Size = new System.Drawing.Size(484, 434);
            this.metroTabPage4.TabIndex = 3;
            this.metroTabPage4.Text = "   File System   ";
            this.metroTabPage4.VerticalScrollbarBarColor = true;
            this.metroTabPage4.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage4.VerticalScrollbarSize = 10;
            this.metroTabPage4.Visible = false;
            // 
            // metroButtonFileState
            // 
            this.metroButtonFileState.Highlight = true;
            this.metroButtonFileState.Location = new System.Drawing.Point(398, 229);
            this.metroButtonFileState.Name = "metroButtonFileState";
            this.metroButtonFileState.Size = new System.Drawing.Size(77, 50);
            this.metroButtonFileState.TabIndex = 23;
            this.metroButtonFileState.Text = "File State";
            this.metroButtonFileState.UseSelectable = true;
            this.metroButtonFileState.Click += new System.EventHandler(this.metroButton43_Click);
            // 
            // metroButton42
            // 
            this.metroButton42.Highlight = true;
            this.metroButton42.Location = new System.Drawing.Point(398, 154);
            this.metroButton42.Name = "metroButton42";
            this.metroButton42.Size = new System.Drawing.Size(77, 50);
            this.metroButton42.TabIndex = 23;
            this.metroButton42.Text = "File Info";
            this.metroButton42.UseSelectable = true;
            this.metroButton42.Click += new System.EventHandler(this.metroButton42_Click);
            // 
            // btnFilelist
            // 
            this.btnFilelist.Highlight = true;
            this.btnFilelist.Location = new System.Drawing.Point(398, 82);
            this.btnFilelist.Name = "btnFilelist";
            this.btnFilelist.Size = new System.Drawing.Size(77, 50);
            this.btnFilelist.TabIndex = 23;
            this.btnFilelist.Text = "File List";
            this.btnFilelist.UseSelectable = true;
            this.btnFilelist.Click += new System.EventHandler(this.btnFilelist_Click);
            // 
            // btnFileUpload
            // 
            this.btnFileUpload.Highlight = true;
            this.btnFileUpload.Location = new System.Drawing.Point(398, 14);
            this.btnFileUpload.Name = "btnFileUpload";
            this.btnFileUpload.Size = new System.Drawing.Size(77, 50);
            this.btnFileUpload.TabIndex = 23;
            this.btnFileUpload.Text = "Upload";
            this.btnFileUpload.UseSelectable = true;
            this.btnFileUpload.Click += new System.EventHandler(this.btnFileUpload_Click);
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.Black;
            this.listView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.ContextMenuStrip = this.metroContextMenu2;
            this.listView1.Font = new System.Drawing.Font("Calibri", 10F);
            this.listView1.ForeColor = System.Drawing.Color.Yellow;
            this.listView1.FullRowSelect = true;
            this.listView1.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(2, 14);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(391, 425);
            this.listView1.TabIndex = 22;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Index";
            this.columnHeader1.Width = 75;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Name";
            this.columnHeader2.Width = 236;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Size(Bytes)";
            this.columnHeader3.Width = 102;
            // 
            // metroContextMenu2
            // 
            this.metroContextMenu2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroContextMenu2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroContextMenu2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Run,
            this.View,
            this.Compile,
            this.Rename,
            this.Download,
            this.toolStripSeparator1,
            this.Delete});
            this.metroContextMenu2.Name = "metroContextMenu1";
            this.metroContextMenu2.Size = new System.Drawing.Size(136, 142);
            // 
            // Run
            // 
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(135, 22);
            this.Run.Text = "Run";
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // View
            // 
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(135, 22);
            this.View.Text = "View";
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // Compile
            // 
            this.Compile.Name = "Compile";
            this.Compile.Size = new System.Drawing.Size(135, 22);
            this.Compile.Text = "Compile";
            this.Compile.Click += new System.EventHandler(this.Compile_Click);
            // 
            // Rename
            // 
            this.Rename.Name = "Rename";
            this.Rename.Size = new System.Drawing.Size(135, 22);
            this.Rename.Text = "Rename";
            this.Rename.Click += new System.EventHandler(this.Rename_Click);
            // 
            // Download
            // 
            this.Download.Name = "Download";
            this.Download.Size = new System.Drawing.Size(135, 22);
            this.Download.Text = "Download";
            this.Download.Click += new System.EventHandler(this.Download_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(132, 6);
            // 
            // Delete
            // 
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(135, 22);
            this.Delete.Text = "Delete";
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // metroLabelUploadProgress
            // 
            this.metroLabelUploadProgress.AutoSize = true;
            this.metroLabelUploadProgress.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabelUploadProgress.Location = new System.Drawing.Point(423, 394);
            this.metroLabelUploadProgress.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabelUploadProgress.Name = "metroLabelUploadProgress";
            this.metroLabelUploadProgress.Size = new System.Drawing.Size(40, 17);
            this.metroLabelUploadProgress.TabIndex = 21;
            this.metroLabelUploadProgress.Text = "100%";
            this.metroLabelUploadProgress.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelUploadProgress.UseStyleColors = true;
            // 
            // metroProgressSpinner
            // 
            this.metroProgressSpinner.Location = new System.Drawing.Point(407, 369);
            this.metroProgressSpinner.Maximum = 100;
            this.metroProgressSpinner.Name = "metroProgressSpinner";
            this.metroProgressSpinner.Size = new System.Drawing.Size(68, 66);
            this.metroProgressSpinner.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner.TabIndex = 14;
            this.metroProgressSpinner.UseSelectable = true;
            this.metroProgressSpinner.Value = 100;
            // 
            // metroTileFormat
            // 
            this.metroTileFormat.ActiveControl = null;
            this.metroTileFormat.Location = new System.Drawing.Point(398, 302);
            this.metroTileFormat.Name = "metroTileFormat";
            this.metroTileFormat.Size = new System.Drawing.Size(77, 50);
            this.metroTileFormat.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTileFormat.TabIndex = 2;
            this.metroTileFormat.Text = "Format";
            this.metroTileFormat.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroTileFormat, "Format File system");
            this.metroTileFormat.UseSelectable = true;
            this.metroTileFormat.Click += new System.EventHandler(this.metroTileFormat_Click);
            // 
            // metroTabPage2
            // 
            this.metroTabPage2.Controls.Add(this.metroLabelUploadProgress2);
            this.metroTabPage2.Controls.Add(this.metroProgressSpinner2);
            this.metroTabPage2.Controls.Add(this.metroCheckBox3);
            this.metroTabPage2.Controls.Add(this.metroCheckBox2);
            this.metroTabPage2.Controls.Add(this.metroCheckBox1);
            this.metroTabPage2.Controls.Add(this.btnSendFW);
            this.metroTabPage2.Controls.Add(this.metroLabel16);
            this.metroTabPage2.Controls.Add(this.metroLabel15);
            this.metroTabPage2.HorizontalScrollbarBarColor = true;
            this.metroTabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.HorizontalScrollbarSize = 9;
            this.metroTabPage2.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage2.Name = "metroTabPage2";
            this.metroTabPage2.Padding = new System.Windows.Forms.Padding(25, 23, 25, 23);
            this.metroTabPage2.Size = new System.Drawing.Size(484, 434);
            this.metroTabPage2.TabIndex = 1;
            this.metroTabPage2.Text = "   Firmware   ";
            this.metroTabPage2.VerticalScrollbarBarColor = true;
            this.metroTabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage2.VerticalScrollbarSize = 10;
            this.metroTabPage2.Visible = false;
            // 
            // metroLabelUploadProgress2
            // 
            this.metroLabelUploadProgress2.AutoSize = true;
            this.metroLabelUploadProgress2.Location = new System.Drawing.Point(191, 314);
            this.metroLabelUploadProgress2.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabelUploadProgress2.Name = "metroLabelUploadProgress2";
            this.metroLabelUploadProgress2.Size = new System.Drawing.Size(45, 20);
            this.metroLabelUploadProgress2.TabIndex = 28;
            this.metroLabelUploadProgress2.Text = "100%";
            this.metroLabelUploadProgress2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabelUploadProgress2.UseStyleColors = true;
            // 
            // metroProgressSpinner2
            // 
            this.metroProgressSpinner2.Location = new System.Drawing.Point(140, 242);
            this.metroProgressSpinner2.Maximum = 100;
            this.metroProgressSpinner2.Name = "metroProgressSpinner2";
            this.metroProgressSpinner2.Size = new System.Drawing.Size(167, 160);
            this.metroProgressSpinner2.Spinning = false;
            this.metroProgressSpinner2.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroProgressSpinner2.TabIndex = 27;
            this.metroProgressSpinner2.UseSelectable = true;
            this.metroProgressSpinner2.Value = 100;
            // 
            // metroCheckBox3
            // 
            this.metroCheckBox3.AutoSize = true;
            this.metroCheckBox3.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox3.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox3.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox3.Location = new System.Drawing.Point(279, 197);
            this.metroCheckBox3.Name = "metroCheckBox3";
            this.metroCheckBox3.Size = new System.Drawing.Size(134, 25);
            this.metroCheckBox3.TabIndex = 26;
            this.metroCheckBox3.Text = "Wlan Driver";
            this.metroCheckBox3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox3.UseSelectable = true;
            this.metroCheckBox3.UseStyleColors = true;
            this.metroCheckBox3.Click += new System.EventHandler(this.metroCheckBox3_Click);
            // 
            // metroCheckBox2
            // 
            this.metroCheckBox2.AutoSize = true;
            this.metroCheckBox2.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox2.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox2.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox2.Location = new System.Drawing.Point(279, 169);
            this.metroCheckBox2.Name = "metroCheckBox2";
            this.metroCheckBox2.Size = new System.Drawing.Size(128, 25);
            this.metroCheckBox2.TabIndex = 26;
            this.metroCheckBox2.Text = "Bootloader";
            this.metroCheckBox2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox2.UseSelectable = true;
            this.metroCheckBox2.UseStyleColors = true;
            this.metroCheckBox2.Click += new System.EventHandler(this.metroCheckBox2_Click);
            // 
            // metroCheckBox1
            // 
            this.metroCheckBox1.AutoSize = true;
            this.metroCheckBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox1.Checked = true;
            this.metroCheckBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.metroCheckBox1.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.metroCheckBox1.FontWeight = MetroFramework.MetroCheckBoxWeight.Bold;
            this.metroCheckBox1.Location = new System.Drawing.Point(279, 142);
            this.metroCheckBox1.Name = "metroCheckBox1";
            this.metroCheckBox1.Size = new System.Drawing.Size(112, 25);
            this.metroCheckBox1.TabIndex = 26;
            this.metroCheckBox1.Text = "Firmware";
            this.metroCheckBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.metroCheckBox1.UseSelectable = true;
            this.metroCheckBox1.UseStyleColors = true;
            this.metroCheckBox1.Click += new System.EventHandler(this.metroCheckBox1_Click);
            // 
            // btnSendFW
            // 
            this.btnSendFW.Highlight = true;
            this.btnSendFW.Location = new System.Drawing.Point(148, 142);
            this.btnSendFW.Name = "btnSendFW";
            this.btnSendFW.Size = new System.Drawing.Size(118, 76);
            this.btnSendFW.TabIndex = 24;
            this.btnSendFW.Text = "Update";
            this.metroToolTip.SetToolTip(this.btnSendFW, "Choose an option to update");
            this.btnSendFW.UseSelectable = true;
            this.btnSendFW.Click += new System.EventHandler(this.btnSendFW_Click);
            // 
            // metroLabel16
            // 
            this.metroLabel16.AutoSize = true;
            this.metroLabel16.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel16.Location = new System.Drawing.Point(42, 74);
            this.metroLabel16.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel16.Name = "metroLabel16";
            this.metroLabel16.Size = new System.Drawing.Size(385, 17);
            this.metroLabel16.TabIndex = 5;
            this.metroLabel16.Text = "Upload a wrong firmware file may cause the MCU fail to startup!";
            this.metroLabel16.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel16.UseStyleColors = true;
            // 
            // metroLabel15
            // 
            this.metroLabel15.AutoSize = true;
            this.metroLabel15.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel15.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel15.Location = new System.Drawing.Point(169, 26);
            this.metroLabel15.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel15.Name = "metroLabel15";
            this.metroLabel15.Size = new System.Drawing.Size(149, 25);
            this.metroLabel15.TabIndex = 5;
            this.metroLabel15.Text = "Be very careful!";
            this.metroLabel15.UseStyleColors = true;
            // 
            // metroTabPage6
            // 
            this.metroTabPage6.Controls.Add(this.metroTextBoxInfo);
            this.metroTabPage6.Controls.Add(this.metroLabel14);
            this.metroTabPage6.HorizontalScrollbarBarColor = true;
            this.metroTabPage6.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.HorizontalScrollbarSize = 9;
            this.metroTabPage6.Location = new System.Drawing.Point(4, 39);
            this.metroTabPage6.Name = "metroTabPage6";
            this.metroTabPage6.Size = new System.Drawing.Size(484, 434);
            this.metroTabPage6.TabIndex = 5;
            this.metroTabPage6.Text = "   Manuals   ";
            this.metroTabPage6.VerticalScrollbarBarColor = true;
            this.metroTabPage6.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage6.VerticalScrollbarSize = 10;
            this.metroTabPage6.Visible = false;
            // 
            // metroTextBoxInfo
            // 
            this.metroTextBoxInfo.BackColor = System.Drawing.Color.YellowGreen;
            this.metroTextBoxInfo.IconRight = true;
            this.metroTextBoxInfo.Lines = new string[0];
            this.metroTextBoxInfo.Location = new System.Drawing.Point(19, 78);
            this.metroTextBoxInfo.MaxLength = 32767;
            this.metroTextBoxInfo.Multiline = true;
            this.metroTextBoxInfo.Name = "metroTextBoxInfo";
            this.metroTextBoxInfo.PasswordChar = '\0';
            this.metroTextBoxInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxInfo.SelectedText = "";
            this.metroTextBoxInfo.Size = new System.Drawing.Size(440, 257);
            this.metroTextBoxInfo.TabIndex = 20;
            this.metroToolTip.SetToolTip(this.metroTextBoxInfo, "Set timer period");
            this.metroTextBoxInfo.UseSelectable = true;
            this.metroTextBoxInfo.UseStyleColors = true;
            // 
            // metroLabel14
            // 
            this.metroLabel14.AutoSize = true;
            this.metroLabel14.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel14.Location = new System.Drawing.Point(77, 42);
            this.metroLabel14.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel14.Name = "metroLabel14";
            this.metroLabel14.Size = new System.Drawing.Size(336, 17);
            this.metroLabel14.TabIndex = 12;
            this.metroLabel14.Text = "WiFiMCU is an open source project based on EMW3165";
            this.metroLabel14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLabel14.UseStyleColors = true;
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // metroToolTip
            // 
            this.metroToolTip.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroToolTip.StyleManager = null;
            this.metroToolTip.Theme = MetroFramework.MetroThemeStyle.Light;
            // 
            // comboBoxSerialBaudrate
            // 
            this.comboBoxSerialBaudrate.FormattingEnabled = true;
            this.comboBoxSerialBaudrate.ItemHeight = 24;
            this.comboBoxSerialBaudrate.Items.AddRange(new object[] {
            "115200",
            "9600"});
            this.comboBoxSerialBaudrate.Location = new System.Drawing.Point(64, 116);
            this.comboBoxSerialBaudrate.Name = "comboBoxSerialBaudrate";
            this.comboBoxSerialBaudrate.PromptText = "Baudrate";
            this.comboBoxSerialBaudrate.Size = new System.Drawing.Size(77, 30);
            this.comboBoxSerialBaudrate.Style = MetroFramework.MetroColorStyle.Lime;
            this.comboBoxSerialBaudrate.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.comboBoxSerialBaudrate, "Baud Rate");
            this.comboBoxSerialBaudrate.UseSelectable = true;
            // 
            // comboBoxSerialPort
            // 
            this.comboBoxSerialPort.FormattingEnabled = true;
            this.comboBoxSerialPort.ItemHeight = 24;
            this.comboBoxSerialPort.Location = new System.Drawing.Point(64, 78);
            this.comboBoxSerialPort.Name = "comboBoxSerialPort";
            this.comboBoxSerialPort.PromptText = "COM";
            this.comboBoxSerialPort.Size = new System.Drawing.Size(77, 30);
            this.comboBoxSerialPort.Style = MetroFramework.MetroColorStyle.Green;
            this.comboBoxSerialPort.TabIndex = 18;
            this.metroToolTip.SetToolTip(this.comboBoxSerialPort, "Serial Port");
            this.comboBoxSerialPort.UseSelectable = true;
            // 
            // metroTileOpenPort
            // 
            this.metroTileOpenPort.ActiveControl = null;
            this.metroTileOpenPort.BackColor = System.Drawing.SystemColors.Control;
            this.metroTileOpenPort.Location = new System.Drawing.Point(145, 78);
            this.metroTileOpenPort.Name = "metroTileOpenPort";
            this.metroTileOpenPort.Size = new System.Drawing.Size(80, 68);
            this.metroTileOpenPort.Style = MetroFramework.MetroColorStyle.Lime;
            this.metroTileOpenPort.TabIndex = 2;
            this.metroTileOpenPort.Text = "Open";
            this.metroTileOpenPort.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroTileOpenPort, "Open Serial Port");
            this.metroTileOpenPort.UseSelectable = true;
            this.metroTileOpenPort.Click += new System.EventHandler(this.metroTileOpenPort_Click);
            // 
            // metroTileRestart
            // 
            this.metroTileRestart.ActiveControl = null;
            this.metroTileRestart.Location = new System.Drawing.Point(407, 78);
            this.metroTileRestart.Name = "metroTileRestart";
            this.metroTileRestart.Size = new System.Drawing.Size(80, 68);
            this.metroTileRestart.Style = MetroFramework.MetroColorStyle.Brown;
            this.metroTileRestart.TabIndex = 2;
            this.metroTileRestart.Text = "Restart";
            this.metroTileRestart.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroTileRestart, "Restart the module");
            this.metroTileRestart.UseSelectable = true;
            this.metroTileRestart.Click += new System.EventHandler(this.metroTileRestart_Click);
            // 
            // metroTileSwitch
            // 
            this.metroTileSwitch.ActiveControl = null;
            this.metroTileSwitch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileSwitch.Location = new System.Drawing.Point(1004, 18);
            this.metroTileSwitch.Name = "metroTileSwitch";
            this.metroTileSwitch.Size = new System.Drawing.Size(26, 28);
            this.metroTileSwitch.TabIndex = 4;
            this.metroTileSwitch.Text = "S";
            this.metroTileSwitch.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroTileSwitch, "Switch Style");
            this.metroTileSwitch.UseSelectable = true;
            this.metroTileSwitch.Click += new System.EventHandler(this.metroTileSwitch_Click);
            // 
            // metroTileSWitchTheme
            // 
            this.metroTileSWitchTheme.ActiveControl = null;
            this.metroTileSWitchTheme.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTileSWitchTheme.Location = new System.Drawing.Point(974, 18);
            this.metroTileSWitchTheme.Name = "metroTileSWitchTheme";
            this.metroTileSWitchTheme.Size = new System.Drawing.Size(24, 28);
            this.metroTileSWitchTheme.TabIndex = 2;
            this.metroTileSWitchTheme.Text = "T";
            this.metroTileSWitchTheme.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroTileSWitchTheme, "Switch Theme");
            this.metroTileSWitchTheme.UseSelectable = true;
            this.metroTileSWitchTheme.Click += new System.EventHandler(this.metroTileSWitchTheme_Click);
            // 
            // metroTileScan
            // 
            this.metroTileScan.ActiveControl = null;
            this.metroTileScan.Location = new System.Drawing.Point(8, 78);
            this.metroTileScan.Name = "metroTileScan";
            this.metroTileScan.Size = new System.Drawing.Size(48, 62);
            this.metroTileScan.TabIndex = 2;
            this.metroTileScan.Text = "Scan";
            this.metroToolTip.SetToolTip(this.metroTileScan, "Scan available serial port");
            this.metroTileScan.UseSelectable = true;
            this.metroTileScan.Click += new System.EventHandler(this.metroTileScan_Click);
            // 
            // metroButtonTick
            // 
            this.metroButtonTick.Highlight = true;
            this.metroButtonTick.Location = new System.Drawing.Point(312, 78);
            this.metroButtonTick.Name = "metroButtonTick";
            this.metroButtonTick.Size = new System.Drawing.Size(40, 34);
            this.metroButtonTick.TabIndex = 6;
            this.metroButtonTick.Text = "Tick";
            this.metroButtonTick.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroButtonTick, "Time Tick");
            this.metroButtonTick.UseSelectable = true;
            this.metroButtonTick.Click += new System.EventHandler(this.metroButtonTick_Click);
            // 
            // metroButtonCG
            // 
            this.metroButtonCG.Highlight = true;
            this.metroButtonCG.Location = new System.Drawing.Point(358, 78);
            this.metroButtonCG.Name = "metroButtonCG";
            this.metroButtonCG.Size = new System.Drawing.Size(43, 34);
            this.metroButtonCG.TabIndex = 6;
            this.metroButtonCG.Text = "Garbage";
            this.metroButtonCG.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroButtonCG, "Collect Garbage");
            this.metroButtonCG.UseSelectable = true;
            this.metroButtonCG.Click += new System.EventHandler(this.metroButtonCG_Click);
            // 
            // metroButtonMem
            // 
            this.metroButtonMem.Highlight = true;
            this.metroButtonMem.Location = new System.Drawing.Point(312, 112);
            this.metroButtonMem.Name = "metroButtonMem";
            this.metroButtonMem.Size = new System.Drawing.Size(89, 34);
            this.metroButtonMem.TabIndex = 6;
            this.metroButtonMem.Text = "Mem";
            this.metroButtonMem.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroButtonMem, "Memory Status");
            this.metroButtonMem.UseSelectable = true;
            this.metroButtonMem.Click += new System.EventHandler(this.metroButtonMem_Click);
            // 
            // metroTextBoxSend
            // 
            this.metroTextBoxSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTextBoxSend.IconRight = true;
            this.metroTextBoxSend.Lines = new string[0];
            this.metroTextBoxSend.Location = new System.Drawing.Point(505, 626);
            this.metroTextBoxSend.MaxLength = 32767;
            this.metroTextBoxSend.Multiline = true;
            this.metroTextBoxSend.Name = "metroTextBoxSend";
            this.metroTextBoxSend.PasswordChar = '\0';
            this.metroTextBoxSend.PromptText = "Type commands";
            this.metroTextBoxSend.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBoxSend.SelectedText = "";
            this.metroTextBoxSend.Size = new System.Drawing.Size(637, 30);
            this.metroTextBoxSend.TabIndex = 22;
            this.metroToolTip.SetToolTip(this.metroTextBoxSend, "Press enter to send");
            this.metroTextBoxSend.UseSelectable = true;
            this.metroTextBoxSend.UseStyleColors = true;
            this.metroTextBoxSend.KeyDown += new System.Windows.Forms.KeyEventHandler(this.metroTextBoxSend_KeyDown);
            // 
            // txtSP
            // 
            this.txtSP.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSP.BackColor = System.Drawing.SystemColors.InfoText;
            this.txtSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSP.ContextMenuStrip = this.metroContextMenu1;
            this.txtSP.Font = new System.Drawing.Font("仿宋", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSP.ForeColor = System.Drawing.Color.Yellow;
            this.txtSP.Location = new System.Drawing.Point(510, 78);
            this.txtSP.Margin = new System.Windows.Forms.Padding(2);
            this.txtSP.Name = "txtSP";
            this.txtSP.ReadOnly = true;
            this.txtSP.Size = new System.Drawing.Size(621, 542);
            this.txtSP.TabIndex = 23;
            this.txtSP.Text = "";
            this.metroToolTip.SetToolTip(this.txtSP, "Right Click for more...");
            this.txtSP.WordWrap = false;
            this.txtSP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSP_KeyPress);
            // 
            // metroContextMenu1
            // 
            this.metroContextMenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroContextMenu1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroContextMenu1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ClearScreen,
            this.ClearHistory,
            this.toolStripSeparator2,
            this.Restart});
            this.metroContextMenu1.Name = "metroContextMenu1";
            this.metroContextMenu1.Size = new System.Drawing.Size(186, 76);
            // 
            // ClearScreen
            // 
            this.ClearScreen.Name = "ClearScreen";
            this.ClearScreen.Size = new System.Drawing.Size(185, 22);
            this.ClearScreen.Text = "Clear Screen";
            this.ClearScreen.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // ClearHistory
            // 
            this.ClearHistory.Name = "ClearHistory";
            this.ClearHistory.Size = new System.Drawing.Size(185, 22);
            this.ClearHistory.Text = "Clear Input History";
            this.ClearHistory.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(182, 6);
            // 
            // Restart
            // 
            this.Restart.Name = "Restart";
            this.Restart.Size = new System.Drawing.Size(185, 22);
            this.Restart.Text = "Restart";
            this.Restart.Click += new System.EventHandler(this.Restart_Click);
            // 
            // metroButtonSupport
            // 
            this.metroButtonSupport.Highlight = true;
            this.metroButtonSupport.Location = new System.Drawing.Point(855, 18);
            this.metroButtonSupport.Name = "metroButtonSupport";
            this.metroButtonSupport.Size = new System.Drawing.Size(79, 28);
            this.metroButtonSupport.TabIndex = 6;
            this.metroButtonSupport.Text = "Support";
            this.metroButtonSupport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroToolTip.SetToolTip(this.metroButtonSupport, "Technical Support From Doit.am");
            this.metroButtonSupport.UseSelectable = true;
            this.metroButtonSupport.Click += new System.EventHandler(this.metroButtonSupport_Click);
            // 
            // metroLabelCom
            // 
            this.metroLabelCom.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabelCom.AutoSize = true;
            this.metroLabelCom.Location = new System.Drawing.Point(6, 640);
            this.metroLabelCom.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabelCom.Name = "metroLabelCom";
            this.metroLabelCom.Size = new System.Drawing.Size(130, 20);
            this.metroLabelCom.TabIndex = 5;
            this.metroLabelCom.Text = "Serial Port: Closed";
            this.metroLabelCom.UseStyleColors = true;
            // 
            // metroLabel21
            // 
            this.metroLabel21.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel21.AutoSize = true;
            this.metroLabel21.Location = new System.Drawing.Point(193, 640);
            this.metroLabel21.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel21.Name = "metroLabel21";
            this.metroLabel21.Size = new System.Drawing.Size(72, 20);
            this.metroLabel21.TabIndex = 5;
            this.metroLabel21.Text = "Tx(Bytes:)";
            this.metroLabel21.UseStyleColors = true;
            // 
            // metroLabel22
            // 
            this.metroLabel22.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel22.AutoSize = true;
            this.metroLabel22.Location = new System.Drawing.Point(332, 640);
            this.metroLabel22.Margin = new System.Windows.Forms.Padding(3);
            this.metroLabel22.Name = "metroLabel22";
            this.metroLabel22.Size = new System.Drawing.Size(73, 20);
            this.metroLabel22.TabIndex = 5;
            this.metroLabel22.Text = "Rx(Bytes:)";
            this.metroLabel22.UseStyleColors = true;
            // 
            // txSendBytes
            // 
            this.txSendBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txSendBytes.AutoSize = true;
            this.txSendBytes.Location = new System.Drawing.Point(266, 640);
            this.txSendBytes.Margin = new System.Windows.Forms.Padding(3);
            this.txSendBytes.Name = "txSendBytes";
            this.txSendBytes.Size = new System.Drawing.Size(53, 20);
            this.txSendBytes.TabIndex = 5;
            this.txSendBytes.Text = "           ";
            this.txSendBytes.UseStyleColors = true;
            // 
            // rxReadBytes
            // 
            this.rxReadBytes.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rxReadBytes.AutoSize = true;
            this.rxReadBytes.Location = new System.Drawing.Point(407, 640);
            this.rxReadBytes.Margin = new System.Windows.Forms.Padding(3);
            this.rxReadBytes.Name = "rxReadBytes";
            this.rxReadBytes.Size = new System.Drawing.Size(53, 20);
            this.rxReadBytes.TabIndex = 5;
            this.rxReadBytes.Text = "           ";
            this.rxReadBytes.UseStyleColors = true;
            // 
            // txtSPBack
            // 
            this.txtSPBack.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSPBack.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txtSPBack.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txtSPBack.ForeColor = System.Drawing.Color.Yellow;
            this.txtSPBack.IconRight = true;
            this.txtSPBack.Lines = new string[0];
            this.txtSPBack.Location = new System.Drawing.Point(505, 74);
            this.txtSPBack.MaxLength = 32767;
            this.txtSPBack.Multiline = true;
            this.txtSPBack.Name = "txtSPBack";
            this.txtSPBack.PasswordChar = '\0';
            this.txtSPBack.PromptText = "Display Message...";
            this.txtSPBack.ReadOnly = true;
            this.txtSPBack.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSPBack.SelectedText = "";
            this.txtSPBack.Size = new System.Drawing.Size(634, 547);
            this.txtSPBack.TabIndex = 22;
            this.txtSPBack.UseSelectable = true;
            this.txtSPBack.UseStyleColors = true;
            // 
            // serialPort1
            // 
            this.serialPort1.BaudRate = 115200;
            this.serialPort1.ReadTimeout = 300;
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // timer1
            // 
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.ApplyImageInvert = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BackImagePadding = new System.Windows.Forms.Padding(10, 7, 0, 0);
            this.BackMaxSize = 50;
            this.ClientSize = new System.Drawing.Size(1147, 674);
            this.Controls.Add(this.txtSP);
            this.Controls.Add(this.comboBoxSerialPort);
            this.Controls.Add(this.comboBoxSerialBaudrate);
            this.Controls.Add(this.metroTab);
            this.Controls.Add(this.metroTileSwitch);
            this.Controls.Add(this.metroTileSWitchTheme);
            this.Controls.Add(this.metroLabel22);
            this.Controls.Add(this.rxReadBytes);
            this.Controls.Add(this.txSendBytes);
            this.Controls.Add(this.metroLabel21);
            this.Controls.Add(this.txtSPBack);
            this.Controls.Add(this.metroTextBoxSend);
            this.Controls.Add(this.metroButtonMem);
            this.Controls.Add(this.metroButtonCG);
            this.Controls.Add(this.metroButtonSupport);
            this.Controls.Add(this.metroButtonTick);
            this.Controls.Add(this.metroLabelCom);
            this.Controls.Add(this.metroTileRestart);
            this.Controls.Add(this.metroTileOpenPort);
            this.Controls.Add(this.metroTileScan);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(20, 60, 20, 18);
            this.ShadowType = MetroFramework.Forms.MetroFormShadowType.AeroShadow;
            this.ShowIcon = false;
            this.StyleManager = this.metroStyleManager;
            this.Text = "WiFiMCU Studio  V2.1";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.metroTab.ResumeLayout(false);
            this.metroTabPage1.ResumeLayout(false);
            this.metroTabPage1.PerformLayout();
            this.metroTabPage3.ResumeLayout(false);
            this.metroTabPage3.PerformLayout();
            this.metroTabPage4.ResumeLayout(false);
            this.metroTabPage4.PerformLayout();
            this.metroContextMenu2.ResumeLayout(false);
            this.metroTabPage2.ResumeLayout(false);
            this.metroTabPage2.PerformLayout();
            this.metroTabPage6.ResumeLayout(false);
            this.metroTabPage6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.metroContextMenu1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Controls.MetroTabControl metroTab;
        private Components.MetroStyleManager metroStyleManager;
        private Controls.MetroTabPage metroTabPage1;
        private Components.MetroToolTip metroToolTip;
        private Controls.MetroTabPage metroTabPage2;
        private Controls.MetroTabPage metroTabPage3;
        private Controls.MetroTabPage metroTabPage4;
        private Components.MetroStyleExtender metroStyleExtender;
        private Controls.MetroContextMenu metroContextMenu1;
        private Controls.MetroTabPage metroTabPage6;
        private MetroTile metroTileSwitch;
        private MetroTile metroTileSWitchTheme;
        private MetroComboBox comboBoxSerialPort;
        private MetroComboBox comboBoxSerialBaudrate;
        private MetroTile metroTileOpenPort;
        private MetroTile metroTileRestart;
        private MetroLabel metroLabelCom;
        private MetroLabel metroLabel22;
        private MetroLabel metroLabel21;
        private MetroLabel rxReadBytes;
        private MetroLabel txSendBytes;
        private MetroComboBox metroComboBoxTimerID;
        private MetroTextBox metroTextBoxPeriod;
        private MetroTile metroTileScan;
        private MetroButton metroButtonTick;
        private MetroButton metroButtonMem;
        private MetroButton metroButtonCG;
        private MetroButton metroButtonBootR;
        private MetroButton btnTimerStop;
        private MetroButton btnTimerWd;
        private MetroButton btnTimerStart;
        private MetroButton metroButtonChipid;
        private MetroButton metroButtonInfo;
        private MetroButton btnGPIORead;
        private MetroButton btnTimerDelay;
        private MetroLabel metroLabel9;
        private MetroLabel metroLabel1;
        private MetroLabel metroLabel8;
        private MetroComboBox metroComboBoxGPIOPin;
        private MetroComboBox metroComboBoxGPIOMode;
        private MetroButton btnGPIOSetmode;
        private MetroButton btnGPIOToggle;
        private MetroButton btnGPIOSetLow;
        private MetroButton btnGPIOSetHigh;
        private MetroButton metroButtonVer;
        private MetroTextBox metroTextBoxDuty;
        private MetroTextBox metroTextBoxFreq;
        private MetroComboBox metroComboBoxPWMPin;
        private MetroLabel metroLabel25;
        private MetroButton metroButtonPWMStop;
        private MetroButton metroButtonPWMStart;
        private MetroComboBox metroComboBoxADCPin;
        private MetroLabel metroLabel26;
        private MetroButton metroButtonADCRead;
        private MetroLabel metroLabel27;
        private MetroTextBox metroTextBoxUartData;
        private MetroComboBox metroComboBoxParity;
        private MetroComboBox metroComboBoxBaud;
        private MetroComboBox metroComboBoxBits;
        private MetroComboBox metroComboBoxUart;
        private MetroButton metroButtonUartSend;
        private MetroButton metroButtonSet;
        private MetroComboBox metroComboBoxStop;
        private MetroProgressSpinner metroProgressSpinner;
        private MetroTextBox textBoxAPSSID;
        private MetroLabel metroLabel2;
        private MetroButton btnStartAP;
        private MetroTextBox textBoxAPPSW;
        private MetroLabel metroLabel3;
        private MetroTextBox textBoxSTAPSW;
        private MetroTextBox textBoxSTASSID;
        private MetroLabel metroLabel4;
        private MetroButton btnStartSTA;
        private MetroButton btnStopSTA;
        private MetroButton btnStopAP;
        private MetroButton btnGetSTALink;
        private MetroButton btnGetSTAIP;
        private MetroButton btnGetAPIP;
        private MetroButton metroButtonScan;
        private MetroToggle metroToggleSocketType;
        private MetroToggle metroToggleTransType;
        private MetroLabel metroLabel6;
        private MetroLabel metroLabel13;
        private MetroLabel metroLabel7;
        private MetroLabel metroLabel12;
        private MetroLabel metroLabel11;
        private MetroLabel metroLabel10;
        private MetroLabel metroLabel5;
        private MetroCheckBox checkBoxBindLoaclPort;
        private MetroTextBox textBoxBindLoadPort;
        private MetroTextBox labelPort;
        private MetroTextBox textBoxSendData;
        private MetroButton btnSendData;
        private MetroButton btnNetSet;
        private MetroTextBox textBoxIP;
        private MetroLabel metroLabelUploadProgress;
        public System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private MetroButton metroButtonFileState;
        private MetroButton metroButton42;
        private MetroButton btnFilelist;
        private MetroButton btnFileUpload;
        private MetroTile metroTileFormat;
        private MetroLabel metroLabel16;
        private MetroLabel metroLabel15;
        private MetroButton btnSendFW;
        private MetroCheckBox metroCheckBox1;
        private MetroCheckBox metroCheckBox3;
        private MetroCheckBox metroCheckBox2;
        private MetroTextBox txtSPBack;
        private MetroTextBox metroTextBoxSend;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.RichTextBox txtSP;
        private MetroContextMenu metroContextMenu2;
        private System.Windows.Forms.ToolStripMenuItem ClearScreen;
        private System.Windows.Forms.ToolStripMenuItem ClearHistory;
        private System.Windows.Forms.ToolStripMenuItem Run;
        private System.Windows.Forms.ToolStripMenuItem View;
        private System.Windows.Forms.ToolStripMenuItem Compile;
        private System.Windows.Forms.ToolStripMenuItem Rename;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Delete;
        private System.Windows.Forms.ToolStripMenuItem Download;
        private System.Windows.Forms.ToolStripMenuItem Restart;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.Timer timer1;
        private MetroLabel metroLabelUploadProgress2;
        private MetroProgressSpinner metroProgressSpinner2;
        private MetroLabel metroLabel14;
        private MetroTextBox metroTextBoxInfo;
        private MetroButton metroButtonSupport;

    }
}

