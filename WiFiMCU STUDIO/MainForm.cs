using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using MetroFramework.Forms;
using System.Collections.Generic;
using System.IO.Ports;
using System.Text;
using System.IO;
using System.Threading;
using System.Runtime.InteropServices;

using Eductor;
using MetroFramework.Controls;

namespace MetroFramework.WiFiMCU
{
    public partial class MainForm : MetroForm
    {
        public MainForm()
        {
            InitializeComponent();
            metroStyleManager.Theme = MetroThemeStyle.Dark;
            metroStyleManager.Style = MetroColorStyle.Teal;
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            metroTileScan.PerformClick();
            getInitFile();
            metroTab.SelectTab(metroTabPage4);
            scanPort(30);
            SetLineSpace(txtSP, 8);
            timer1.Start();
            metroProgressSpinner.Spinning = false;

            metroTextBoxInfo.Text = "Site:\r\n  http://www.wifimcu.com\r\n";
            metroTextBoxInfo.AppendText("Github:\r\n  https://github.com/SmartArduino/WiFiMCU\r\n");
            metroTextBoxInfo.AppendText("WiFiMCU Stduio:\r\n  https://github.com/SmartArduino/WiFiMCU-STUDIO\r\n");
            metroTextBoxInfo.AppendText("Docs:\r\n  https://github.com/SmartArduino/WiFiMCU/tree/master/Document\r\n");
            metroTextBoxInfo.AppendText("Demos:\r\n  https://github.com/SmartArduino/WiFiMCU/tree/master/Demos\r\n");
            metroTextBoxInfo.AppendText("Discussion:\r\n  bbs.doit.am\r\n  bbs.smartarduino.com\r\n  www.emw3165.com");
        }
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveInitFile();
        }
        private void getInitFile()
        {
            IniFileClass p = new IniFileClass(".\\para.ini");
            try
            {
                comboBoxSerialPort.SelectedIndex = int.Parse(p.IniReadValue("page0", "comboBoxSerialPort", "0"));
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
            comboBoxSerialBaudrate.SelectedIndex = int.Parse(p.IniReadValue("page0", "comboBoxSerialBaudrate", "0"));
            metroComboBoxTimerID.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxTimerID", "0"));
            metroComboBoxGPIOPin.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxGPIOPin", "0"));
            metroComboBoxGPIOMode.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxGPIOMode", "0"));
            metroComboBoxPWMPin.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxPWMPin", "0"));
            metroComboBoxADCPin.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxADCPin", "0"));
            metroComboBoxUart.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxUart", "0"));
            metroComboBoxBaud.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxBaud", "0"));
            metroComboBoxBits.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxBits", "0"));
            metroComboBoxParity.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxParity", "0"));
            metroComboBoxStop.SelectedIndex = int.Parse(p.IniReadValue("page0", "metroComboBoxStop", "0"));
            metroTextBoxPeriod.Text = p.IniReadValue("page0", "metroTextBoxPeriod", "1000");
            metroTextBoxFreq.Text = p.IniReadValue("page0", "metroTextBoxFreq", "10000");
            metroTextBoxDuty.Text = p.IniReadValue("page0", "metroTextBoxDuty", "50");
            metroTextBoxUartData.Text = p.IniReadValue("page0", "metroTextBoxUartData", "50");

            textBoxAPSSID.Text = p.IniReadValue("page1", "textBoxAPSSID", "WiFiMCU_SoftAP");
            textBoxAPPSW.Text = p.IniReadValue("page1", "textBoxAPPSW", "");
            textBoxSTASSID.Text = p.IniReadValue("page1", "textBoxSTASSID", "Wireless_Router");
            textBoxSTAPSW.Text = p.IniReadValue("page1", "textBoxSTAPSW", "");
            textBoxBindLoadPort.Text = p.IniReadValue("page1", "textBoxBindLoadPort", "9000");
            textBoxIP.Text = p.IniReadValue("page1", "textBoxIP", "192.168.1.100");
            labelPort.Text = p.IniReadValue("page1", "labelPort", "9001");
            textBoxSendData.Text = p.IniReadValue("page1", "textBoxSendData", "");
        }
        private void saveInitFile()
        {
            IniFileClass p = new IniFileClass(".\\para.ini");
            p.IniWriteValue("page0", "comboBoxSerialPort", comboBoxSerialPort.SelectedIndex.ToString());
            p.IniWriteValue("page0", "comboBoxSerialBaudrate", comboBoxSerialBaudrate.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxTimerID", metroComboBoxTimerID.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxGPIOPin", metroComboBoxGPIOPin.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxGPIOMode", metroComboBoxGPIOMode.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxPWMPin", metroComboBoxPWMPin.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxADCPin", metroComboBoxADCPin.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxUart", metroComboBoxUart.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxBaud", metroComboBoxBaud.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxBits", metroComboBoxBits.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxParity", metroComboBoxParity.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroComboBoxStop", metroComboBoxStop.SelectedIndex.ToString());
            p.IniWriteValue("page0", "metroTextBoxPeriod", metroTextBoxPeriod.Text);
            p.IniWriteValue("page0", "metroTextBoxFreq", metroTextBoxFreq.Text);
            p.IniWriteValue("page0", "metroTextBoxDuty", metroTextBoxDuty.Text);
            p.IniWriteValue("page0", "metroTextBoxUartData", metroTextBoxUartData.Text);

            p.IniWriteValue("page1", "textBoxAPSSID", textBoxAPSSID.Text);
            p.IniWriteValue("page1", "textBoxAPPSW", textBoxAPPSW.Text);
            p.IniWriteValue("page1", "textBoxSTASSID", textBoxSTASSID.Text);
            p.IniWriteValue("page1", "textBoxSTAPSW", textBoxSTAPSW.Text);
            p.IniWriteValue("page1", "textBoxBindLoadPort", textBoxBindLoadPort.Text);
            p.IniWriteValue("page1", "textBoxIP", textBoxIP.Text);
            p.IniWriteValue("page1", "labelPort", labelPort.Text);
            p.IniWriteValue("page1", "textBoxSendData", textBoxSendData.Text);

        }
#region setRichtextboxlineheight
        private const int WM_USER = 0x0400;
        private const int EM_GETPARAFORMAT = WM_USER + 61;
        private const int EM_SETPARAFORMAT = WM_USER + 71;
        private const long MAX_TAB_STOPS = 32;
        private const uint PFM_LINESPACING = 0x00000100;
        [StructLayout(LayoutKind.Sequential)]
        private struct PARAFORMAT2
        {
            public int cbSize;
            public uint dwMask;
            public short wNumbering;
            public short wReserved;
            public int dxStartIndent;
            public int dxRightIndent;
            public int dxOffset;
            public short wAlignment;
            public short cTabCount;
            [MarshalAs(UnmanagedType.ByValArray, SizeConst = 32)]
            public int[] rgxTabs;
            public int dySpaceBefore;
            public int dySpaceAfter;
            public int dyLineSpacing;
            public short sStyle;
            public byte bLineSpacingRule;
            public byte bOutlineLevel;
            public short wShadingWeight;
            public short wShadingStyle;
            public short wNumberingStart;
            public short wNumberingStyle;
            public short wNumberingTab;
            public short wBorderSpace;
            public short wBorderWidth;
            public short wBorders;
        }

        [DllImport("user32", CharSet = CharSet.Auto)]
        private static extern IntPtr SendMessage(HandleRef hWnd, int msg, int wParam, ref PARAFORMAT2 lParam);

        public static void SetLineSpace(Control ctl, int dyLineSpacing)
        {
            PARAFORMAT2 fmt = new PARAFORMAT2();
            fmt.cbSize = Marshal.SizeOf(fmt);
            fmt.bLineSpacingRule = 4;// bLineSpacingRule;
            fmt.dyLineSpacing = dyLineSpacing * 30;
            fmt.dwMask = PFM_LINESPACING;
            try
            {
                SendMessage(new HandleRef(ctl, ctl.Handle), EM_SETPARAFORMAT, 0, ref fmt);
            }
            catch
            {

            }
        }
        #endregion
        private static readonly List<string> sendRecordList = new List<string>();

        private static int sendRecordListIdx = 0;

        private static void addSendRec(string msg)
        {
            if (string.IsNullOrEmpty(msg)) return;

            if (sendRecordList.Count > 30) sendRecordList.RemoveAt(0);
            sendRecordList.Add(msg);

            sendRecordListIdx = sendRecordList.Count;
        }

        private static string upGetSendRec()
        {
            if (sendRecordList.Count == 0) return string.Empty;
            sendRecordListIdx--;
            if (sendRecordListIdx < 0) sendRecordListIdx = 0;
            return sendRecordList[sendRecordListIdx];
        }

        private static string downGetSendRec()
        {
            if (sendRecordList.Count == 0) return string.Empty;
            sendRecordListIdx++;
            if (sendRecordListIdx > (sendRecordList.Count - 1)) sendRecordListIdx = sendRecordList.Count - 1;
            return sendRecordList[sendRecordListIdx];
        }
        private void metroTileSwitch_Click(object sender, EventArgs e)
        {
            var m = new Random();
            int next = m.Next(0, 13);
            metroStyleManager.Style = (MetroColorStyle)next;
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            //metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
            //txtSP.BackColor = txtSP.BackColor==Color.Black? Color.Wheat:Color.Black;
        }

        private void metroButton42_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("r,u,t=file.info(); print(\"\\r\\nTotal : \"..t..\" bytes\\r\\nUsed  : \"..u..\" bytes\\r\\nRemain: \"..r..\" bytes\\r\\n\") r=nil;u=nil;t=nil;\r\n");
        }

        private void metroButton43_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=file.state()\r\n");
        }

        private void metroButtonClearHistory_Click(object sender, EventArgs e)
        {
            sendRecordList.Clear();
        }

        private void metroButtonClear_Click(object sender, EventArgs e)
        {
            txtSP.Clear();
        }

        private void metroTextBoxSend_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                this.metroTextBoxSend.Text = upGetSendRec();
                //this.metroTextBoxSend.Select(0, this.metroTextBoxSend.Text.Length - 1);
                this.metroTextBoxSend.SelectAll();
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Down)
            {
                this.metroTextBoxSend.Text = downGetSendRec();
                this.metroTextBoxSend.SelectAll();
                //this.metroTextBoxSend.Select(0, this.metroTextBoxSend.Text.Length - 1);
                e.Handled = true;
            }
            else if (e.KeyCode == Keys.Enter)
            {
                string str = metroTextBoxSend.Text.Trim()+"\r\n";
                sendData2SerialPort(str);
                if (str != "")
                {
                    addSendRec(str);
                }
                metroTextBoxSend.Clear();
                e.Handled = true;
            }
        }

        private void metroTileSWitchTheme_Click(object sender, EventArgs e)
        {
            metroStyleManager.Theme = metroStyleManager.Theme == MetroThemeStyle.Light ? MetroThemeStyle.Dark : MetroThemeStyle.Light;
        }

        private void showText(String str)
        {
            txtSP.AppendText(str);
            if (str!=".")
            {
                txtSP.SelectionStart = txtSP.Text.Length;
                txtSP.SelectionLength = 0;
                txtSP.ScrollToCaret();
            }
            
        }
        UInt32 sendSerData = 0;
        UInt32 recvSerData = 0;
        private void sendData2SerialPort(String d)
        {
            if (this.serialPort1.IsOpen == false)
            {
                showText("\r\n-->Serial Port is not Opened<--\r\n");
                return;
            }
            try
            {
                this.serialPort1.Write(d);

                sendSerData = sendSerData + (UInt32)d.Length;
                txSendBytes.Text = sendSerData.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void scanPort(int num)
        {
            ComboBox cbxCOMPort = this.comboBoxSerialPort;
            cbxCOMPort.Items.Clear();
            for (int i = 0; i <= num; i++)
            {
                try
                {
                    SerialPort sp = new SerialPort("COM" + (i + 1).ToString());
                    sp.Open();
                    sp.Close();
                    cbxCOMPort.Items.Add("COM" + (i + 1).ToString());
                    cbxCOMPort.SelectedIndex = cbxCOMPort.Items.Count - 1;
                }
                catch (Exception)
                {
                    continue;
                }
            }
        }
        private void metroTileScan_Click(object sender, EventArgs e)
        {
            scanPort(50);
        }

        bool bUploadingFirmware = false;
        bool bReqUploadingFirmware = false;
        long uploadingFirmwareTimeTick = 0;

        bool bIsGetingFileList = false;
        long lGetingFileListTimeTick = 0;

        string[] stringFileData;
        int stringFileDataIndex = 0;
        bool fileIsUploading = false;
        long fileUploadTimeTick = 0;
        string fileUploadFileName = "";

        private void metroTileOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn1 = metroTileOpenPort;
                ComboBox cmbox = comboBoxSerialPort;
                if (!serialPort1.IsOpen)
                {
                    this.serialPort1.PortName = cmbox.Text.Trim();
                    this.serialPort1.BaudRate = int.Parse(comboBoxSerialBaudrate.Text);
                    m_IsTryToClosePort = false;
                    serialPort1.Open();
                    btn1.Text = "Close";
                    cmbox.Enabled = false;
                    metroTileScan.Enabled = false;
                    comboBoxSerialBaudrate.Enabled = false;
                    metroLabelCom.Text = "Serial Port: Opened";
                    sendData2SerialPort("\r\n");
                }
                else
                {
                    if (fileIsUploading ||
                        bIsGetingFileList ||
                        bUploadingFirmware)
                    {
                        return;
                    }
                    m_IsTryToClosePort = true;
                    while (m_IsReceiving)
                    {
                        System.Windows.Forms.Application.DoEvents();
                    }
                    serialPort1.Close();
                    btn1.Text = "Open";
                    cmbox.Enabled = true;
                    metroTileScan.Enabled = true;
                    comboBoxSerialBaudrate.Enabled = true;
                    metroLabelCom.Text = "Serial Port: Closed";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
#region SerialRecieveData
        private bool m_IsTryToClosePort = false;
        private bool m_IsReceiving = false;
        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (m_IsTryToClosePort)
            {
                return;
            }
            m_IsReceiving = true;
            try
            {
                AsyncReceiveData();
            }
            finally
            {
                m_IsReceiving = false;
            }
            
        }
        private static string StringToHexString(string str)
        {
            StringBuilder hexString = new StringBuilder(2 * str.Length);

            for (int i = 0; i < str.Length; i++)
                hexString.AppendFormat("{0:X2}", Convert.ToByte(str[i]));
            return hexString.ToString();
        }
        private static string StringToHexString2(string s, bool fenge)
        {
            if ((s.Length % 2) != 0)
            {
                s += " ";//空格
                //throw new ArgumentException("s is not valid chinese string!");
            }
            System.Text.Encoding chs = System.Text.Encoding.GetEncoding("utf-8");
            byte[] bytes = chs.GetBytes(s);
            string str = "";
            for (int i = 0; i < bytes.Length; i++)
            {
                str += string.Format("{0:X}", bytes[i]);
                if (fenge && (i != bytes.Length - 1))
                {
                    str += string.Format("{0}", ",");
                }
            }
            return str.ToLower();
        }
        public static string byteToHexStr(byte[] bytes)
        {
            string returnStr = "";
            if (bytes != null)
            {
                for (int i = 0; i < bytes.Length; i++)
                {
                    returnStr += bytes[i].ToString("X2");
                }
            }
            return returnStr;
        }
        public delegate void AsyReceiveDataHandler();
        String strSerialBuff = "";
        long strSerialBuffTick = 0;
        
        private void AsyncReceiveData()
        {
            if (this.InvokeRequired)
            {
                try
                {
                    AsyReceiveDataHandler dd = new AsyReceiveDataHandler(AsyncReceiveData);
                    this.Invoke(dd, new object[] { });
                }
                catch (System.Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                    MessageBox.Show("InvokeRequired" + ex.ToString());
                }

            }
            else
            {
                if (bReqUploadingFirmware == true && serialPort1.ReadByte() == 'C')
                {
                    bReqUploadingFirmware = false;
                    bUploadingFirmware = true;
                    Console.WriteLine("Start uploading...");
                }
                else if (bUploadingFirmware)
                {
                    doUploadingFirmware(serialPort1.ReadByte());
                }
                else
                {
                    int len = serialPort1.BytesToRead;
                    byte[] bytes = new byte[len];
                    serialPort1.Read(bytes, 0, len);
                    string strTemp = System.Text.Encoding.UTF8.GetString(bytes);
                    strSerialBuffTick = Environment.TickCount;
                    
                    strSerialBuff = strSerialBuff + strTemp;

                    recvSerData = recvSerData + (UInt32)strTemp.Length;
                    rxReadBytes.Text = recvSerData.ToString();
                }
            }
        }
#endregion

        private void sendData2SerialPortUtf8(String d)
        {
            if (this.serialPort1.IsOpen == false)
            {
                showText("\r\n-->Serial Port is not Opened<--\r\n");
                return;
            }
            try
            {
                System.Text.UTF8Encoding utf8 = new System.Text.UTF8Encoding();
                Byte[] writeBytes = utf8.GetBytes(d);
                serialPort1.Write(writeBytes, 0, writeBytes.Length);
                Thread.Sleep(10);
                sendSerData = sendSerData + (UInt32)d.Length;
                txSendBytes.Text =sendSerData.ToString();
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        private void btnFilelist_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("file.slist()\r\n");
            bIsGetingFileList = true;
            lGetingFileListTimeTick = Environment.TickCount;
            listView1.Items.Clear();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            txtSP.Clear();
            metroTextBoxSend.Clear();
            sendData2SerialPort("\r\n");
            sendSerData = 0;
            txSendBytes.Text = sendSerData.ToString();
            recvSerData = 0;
            rxReadBytes.Text = recvSerData.ToString();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            sendRecordList.Clear();
        }

        private bool isBtnOK()
        {
            if (!serialPort1.IsOpen ||
                fileIsUploading ||
                bIsGetingFileList ||
                bUploadingFirmware)
            {
                return false;
            }
            return true;
        }

        private void metroButtonMem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            //sendData2SerialPort("=mcu.mem()\r\n");
            sendData2SerialPort("r,u,t,k=mcu.mem(); print(\"\\r\\nFree        : \"..r..\" bytes\\r\\nUsed        : \"..u..\" bytes\\r\\nTotal       : \"..t..\" bytes\\r\\nChunks Num. : \"..k..\"\\r\\n\") r=nil;u=nil;t=nil;k=nil\r\n");
        }

        private void metroTileRestart_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;

            if (DialogResult.Cancel== MetroMessageBox.Show(this, "Ready to reboot WiFiMCU?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning))
            {
                return;
            }

            strSerialBuff = "";
            if (txtSP.Lines.Length <= 1)
            {
                sendData2SerialPort("mcu.reboot()\r\n");
                return;
            }
            string line = txtSP.Lines[txtSP.Lines.Length - 1];
            if (line.IndexOf("WiFiMCU>") >= 0)
                sendData2SerialPort("7\r\n");
            else
                sendData2SerialPort("mcu.reboot()\r\n");
        }

        private void metroButtonCG_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("collectgarbage()\r\n");
        }

        private void metroButtonTick_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=tmr.tick()\r\n");
        }

        private void metroButtonVer_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=mcu.ver()\r\n");
        }

        private void metroButtonInfo_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=mcu.info()\r\n");
        }

        private void metroButtonChipid_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=mcu.chipid()\r\n");
        }

        private void metroButtonBootR_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=mcu.bootreason()\r\n");
        }

        private void metroButtonScan_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("function listap(t) if t then for k,v in pairs(t) do print(k..'\t'..v);end else print('no ap') end end; wifi.scan(listap)\r\n");
        }

        private void txtSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isBtnOK())
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            if (e.KeyChar == '\r' || e.KeyChar == '\n')
            {
                sendData2SerialPort(metroTextBoxSend.Text+"\r\n");
                metroTextBoxSend.Text = "";
            }
            else
            {
                metroTextBoxSend.AppendText(e.KeyChar.ToString());
            }

        }

        private void Restart_Click(object sender, EventArgs e)
        {
            metroTileRestart.PerformClick();
        }

        string lastSelFileName = "";
        private void btnFileUpload_Click(object sender, EventArgs e)
        {
            if (this.btnFileUpload.Text == "Abort")
            {
                sendData2SerialPort("file.close();s=nil;\r\n");
                fileIsUploading = false;
                metroProgressSpinner.Spinning = false;
                this.btnFileUpload.Text = "Upload";
                this.btnFilelist.PerformClick();
                return;
            }
            if (!isBtnOK()) return;

            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "all|*.*|lua|*.lua";
            fd.Title = "Select the Uploading File";
            fd.FileName = lastSelFileName;

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                lastSelFileName = fd.SafeFileName;
                StreamReader sr = new StreamReader(filePath);
                string content = sr.ReadToEnd();
                sr.Close();
                stringFileData = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                //Console.WriteLine(stringFileData);
                
                //print([[--]]..'[['..[[demo]]..']]'..[[]])
                //--[[demo]]
                //]]..'[['..[[
                //]]..']]'..[[
                stringFileDataIndex = 0;
                fileUploadFileName = fd.SafeFileName;

                fileIsUploading = true;
                fileUploadTimeTick = Environment.TickCount;
                showText("\r\nStart upload file: '" + fd.SafeFileName + "'\r\n");
                sendData2SerialPort("file.remove('" + fd.SafeFileName + "');" + "file.open('" + fd.SafeFileName + "','w+');s=file.writeline;\r\n");
                metroProgressSpinner.Spinning = true;
                metroProgressSpinner.Value = 0;
                metroLabelUploadProgress.Text = "0%";
                this.btnFileUpload.Text = "Abort";
                strSerialBuff = "";
            }
        }

        private void parseUartData(string d)
        {
        //just show strings
            if (!fileIsUploading &&!bIsGetingFileList)
            {
                showText(d);
                //update file list
                if (reqRefreshFilelist)
                {
                    reqRefreshFilelist = false;
                    if (d.IndexOf("file.rename") >= 0 ||
                    d.IndexOf("file.remove") >= 0 ||
                    d.IndexOf("file.compile") >= 0)
                    {
                        this.btnFilelist.PerformClick();
                        return;
                    }
                }                
            }
        
#region lua scripts file uploading
            if (fileIsUploading == true)
            {
                //Console.WriteLine(strSerialBuff);
                if (d.IndexOf("stdin:1") >= 0)
                {
                    fileIsUploading = false;
                    this.btnFileUpload.Text = "Upload";
                    showText("\r\n Error happened, stop download!\r\n");
                    MetroMessageBox.Show(this, "File: '" + fileUploadFileName + "' upload failed", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    strSerialBuff = "";
                    return;
                }
                if (stringFileDataIndex == stringFileData.Length)
                {//send ok
                    fileUploadTimeTick = Environment.TickCount;
                    sendData2SerialPort("file.close();s=nil;\r\n");
                    stringFileDataIndex++;
                    showText(".");
                    metroLabelUploadProgress.Text = "100%";
                    metroProgressSpinner.Value = 100;
                    metroProgressSpinner.Spinning = false;
                }
                else if (stringFileDataIndex > stringFileData.Length)
                {
                    fileIsUploading = false;
                    showText("\r\n-->Upload file: '" + fileUploadFileName + "' success<--\r\n");
                    metroProgressSpinner.Value = 100;
                    metroProgressSpinner.Spinning = false;
                    metroLabelUploadProgress.Text = "100%";
                    this.btnFileUpload.Text = "Upload";
                    this.btnFilelist.PerformClick();
                }
                else
                {
                    //int len = (stringFileData.Length - stringFileDataIndex) < 450 ? stringFileData.Length - stringFileDataIndex : 450;
                    //String sdata = stringFileData.Substring(stringFileDataIndex, len);
                    //stringFileDataIndex += sdata.Length;
                    String sdata = stringFileData[stringFileDataIndex++];

                    fileUploadTimeTick = Environment.TickCount;

                    if (txtSP.Lines[txtSP.Lines.Length - 1].Length > 50)
                    {
                        showText("\r\n");
                    }
                    showText(".");

                    sdata = sdata.Replace("]]", "!@#$%^&");
                    sdata = sdata.Replace("[[", "]]..'[['..[[");
                    sdata = sdata.Replace("!@#$%^&", "]]..']]'..[[");
                    sdata = "=s([[" + sdata + "]])\r\n";
                    Console.WriteLine("[Send]" + sdata);
                    sendData2SerialPortUtf8(sdata);

                    string pg = string.Format("{0:G}", stringFileDataIndex * 100 / stringFileData.Length);
                    metroLabelUploadProgress.Text = pg + "%";
                    metroProgressSpinner.Value = stringFileDataIndex * 100 / stringFileData.Length;
                }
                return;
            }
            #endregion
#region get file list
        if (bIsGetingFileList == true)
            {
                bIsGetingFileList = false;
                try
                {
                    string[] str = d.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                    ListView listView = listView1;
                    listView.Items.Clear();
                    listView.BeginUpdate();
                    int num = 0;
                    String strTemp = "";
                    String line = "";
                    foreach (string lineTemp in str)
                    {
                        if (!lineTemp.Contains("size:"))
                            continue;
                        num++;
                        ListViewItem lvi = new ListViewItem(num.ToString());
                        line = lineTemp;
                        if (lineTemp.Substring(0, 1) == " ")
                            line = lineTemp.Substring(1, lineTemp.Length - 1);

                        strTemp = line.Substring(0, line.IndexOf(" size:"));
                        lvi.SubItems.Add(strTemp);//name
                        strTemp = line.Substring(line.IndexOf("size:") + 5, line.Length - (line.IndexOf("size:") + 5));
                        lvi.SubItems.Add(strTemp);//size

                        listView.Items.Add(lvi);
                        //if ((listView.Items.Count) % 2 == 0)
                            //listView.Items[listView.Items.Count - 1].BackColor = Color.FloralWhite;
                            //listView.Items[listView.Items.Count - 1].BackColor = Color.White;
                        //else
                            //listView.Items[listView.Items.Count - 1].BackColor = Color.Moccasin;
                            //listView.Items[listView.Items.Count - 1].BackColor = Color.LightYellow;
                    }
                    listView.EndUpdate();
                }
                catch (System.Exception ex)
                {
                    ex.ToString();
                }
                return;
            }
#endregion
            
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            //check serial port error
            if (metroTileOpenPort.Text == "Close" && serialPort1.IsOpen == false)
            {
                serialPort1.Close();
                fileIsUploading = false;
                bIsGetingFileList = false;
                bUploadingFirmware = false;
                metroTileOpenPort.Text = "Open";
                comboBoxSerialPort.Enabled = true;
                metroTileScan.Enabled = true;
                comboBoxSerialBaudrate.Enabled = true;
                metroLabelCom.Text = "Serial Port: Closed";
                MetroMessageBox.Show(this, "Serial Port Error Detected, Serial Port closed", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //check data
            if((strSerialBuff.Length>0 && Environment.TickCount - strSerialBuffTick>10)||
                strSerialBuff.Length > 2048)
            {
                if ((bIsGetingFileList) &&
                    Environment.TickCount - strSerialBuffTick < 500)
                    return;
                String strTemp = strSerialBuff;
                strSerialBuff = "";
                Console.WriteLine("[Recieve:]" + strTemp);
                parseUartData(strTemp);
            }
            //check getfilelist timeout
            if (bIsGetingFileList == true && Environment.TickCount - lGetingFileListTimeTick > 500)
            {
                bIsGetingFileList = false;
                MetroMessageBox.Show(this, "Get File list time out ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            //check uploading lua scripts timeout
            if (fileIsUploading == true && Environment.TickCount - fileUploadTimeTick > 500)
            {
                fileIsUploading = false;
                metroProgressSpinner2.Spinning = false;
                fileStream.Close();
                this.btnFileUpload.Text = "Upload";
                MetroMessageBox.Show(this, "File: '" + fileUploadFileName + "' upload time out ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void Run_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("dofile('" + fn + "')\r\n");
        }

        private void View_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("file.open('" + fn + "','r'); local d=1;while d do d=file.read(); if d~=nil then print(d) end end file.close() d=nil;print();\r\n");
        }

        bool reqRefreshFilelist = false;
        private void Compile_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("file.compile('" + fn + "')\r\n");
            reqRefreshFilelist = true;
        }

        private void Rename_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;

            TestForm1 fm = new TestForm1();
            fm.orginalFn = fn;
            if (fm.ShowDialog() == DialogResult.OK)
            {
                sendData2SerialPort("file.rename('" + fn + "','" + fm.newFn + "')\r\n");
                reqRefreshFilelist = true;
            }
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            if (MetroMessageBox.Show(this, "Are you sure to remove the file:'" + fn + "'", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            sendData2SerialPort("file.remove('" + fn + "')\r\n");
            reqRefreshFilelist = true;
        }

        private void Download_Click(object sender, EventArgs e)
        {

        }

        private void metroTileFormat_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            if (MetroMessageBox.Show(this,"Format Flash will erase all the existing file data.\r\n Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            sendData2SerialPort("\r\nprint('Wait about 10s for formatting done...');file.format()\r\n");
            this.listView1.Items.Clear();
        }

        private void metroCheckBox1_Click(object sender, EventArgs e)
        {
            metroCheckBox1.Checked = true;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = false;
        }

        private void metroCheckBox2_Click(object sender, EventArgs e)
        {
            metroCheckBox1.Checked = false;
            metroCheckBox2.Checked = true;
            metroCheckBox3.Checked = false;
        }

        private void metroCheckBox3_Click(object sender, EventArgs e)
        {
            metroCheckBox1.Checked = false;
            metroCheckBox2.Checked = false;
            metroCheckBox3.Checked = true;
        }

        private void btnSendFW_Click(object sender, EventArgs e)
        {
            if (this.btnSendFW.Text == "Abort")
            {
                bUploadingFirmware = false;
                bReqUploadingFirmware = false;
                btnSendFW.Text = "Update";
                fileStream.Close();
                metroProgressSpinner2.Spinning = false;
                if (serialPort1.IsOpen)
                {
                    serialPort1.Write(new byte[] { CA, CA }, 0, 2);
                }
                return;
            }

            if (!isBtnOK())
            {
                return;
            }
            //whetch in uploading status
            //WiFiMCU> 
            string line = txtSP.Lines[txtSP.Lines.Length - 1];
            if (line.IndexOf("WiFiMCU>") < 0)
            {
                MetroMessageBox.Show(this, "WiFiMCU must enter into bootloader mode!\r\n Press \"BOOT KEY\" while setup WiFiMCU to enter into Booloader mode", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int uploadType = 0;
            if (metroCheckBox1.Checked)
                uploadType = 0;
            else if (metroCheckBox2.Checked)
                uploadType = 1;
            else if (metroCheckBox3.Checked)
                uploadType = 2;
            else
                return;
            
            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "bin|*.bin";
            fd.Title = "Select the Uploading File";

            if (fd.ShowDialog() != DialogResult.OK)
                return;

            path = fd.FileName;
            fileStream = new FileStream(@path, FileMode.Open, FileAccess.Read);

            if (uploadType == 0 &&
                (fileStream.Length < 200 * 1024 ||
                fileStream.Length > 512 * 1024))
            {
                if(DialogResult.No==MetroMessageBox.Show(this, "The length of WiFiMCU Firmware should between 200k~512k\r\nPlease be careful, continue or NOT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                return;
            }
            if (uploadType == 1 &&
                (fileStream.Length < 10 * 1024 ||
                fileStream.Length > 30 * 1024))
            {
                if (DialogResult.No == MetroMessageBox.Show(this, "The length of Bootloader should between 10k~30k\r\nPlease be careful, continue or NOT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
            }
            if (uploadType == 2 &&
                (fileStream.Length < 200 * 1024 ||
                fileStream.Length > 210 * 1024))
            {
                if (DialogResult.No == MetroMessageBox.Show(this, "The length of WiFiMCU Wlan Driver should between 200k~210k\r\nPlease be careful, continue or NOT?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                    return;
            }
            btnSendFW.Text = "Abort";
            uploadingFWStage = (int)FWStage.WaitForStart1;
            bReqUploadingFirmware = true;
            uploadingFirmwareTimeTick = Environment.TickCount;
            if (uploadType == 0)
            {//firmware
                sendData2SerialPort("4 -i -start 0x800C000 -end 0x807ffff\r\n");
            }
            else if (uploadType == 1)
            {//bootloader
                sendData2SerialPort("4 -i -start 0x8000000 -end 0x8007fff\r\n");
            }
            else if (uploadType == 2)
            {//wlan driver
                sendData2SerialPort("4 -s -start 0x00002000 -end 0x0003FFFF\r\n");
            }
            metroProgressSpinner2.Spinning = true;
            metroProgressSpinner2.Value = 0;
            metroLabelUploadProgress2.Text = "0%";            
        }
#region doUploading

#region YMODEM
        private void sendYmodemInitialPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, string path, FileStream fileStream, byte[] CRC, int crcSize)
        {
            //string fileName = System.IO.Path.GetFileName(path);
            string fileName = "wifimcufw";//change the name to avoid errors
            string fileSize = fileStream.Length.ToString();

            if (metroCheckBox1.Checked)
                fileName = "firmware";
            else if (metroCheckBox2.Checked)
                fileName = "bootloader";
            else if (metroCheckBox3.Checked)
                fileName = "wlandrv";

            /* add filename to data */
            int i;
            for (i = 0; i < fileName.Length && (fileName.ToCharArray()[i] != 0); i++)
            {
                data[i] = (byte)fileName.ToCharArray()[i];
            }
            data[i] = 0;

            /* add filesize to data */
            int j;
            for (j = 0; j < fileSize.Length && (fileSize.ToCharArray()[j] != 0); j++)
            {
                data[(i + 1) + j] = (byte)fileSize.ToCharArray()[j];
            }
            data[(i + 1) + j] = 0;

            /* fill the remaining data bytes with 0 */
            for (int k = ((i + 1) + j) + 1; k < dataSize; k++)
            {
                data[k] = 0;
            }

            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
        }

        private void sendYmodemClosingPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            /* calculate CRC */
            Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
            CRC = crc16Ccitt.ComputeChecksumBytes(data);

            /* send the packet */
            sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
        }

        private void sendYmodemPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, byte[] CRC, int crcSize)
        {
            serialPort1.Write(new byte[] { STX }, 0, 1);
            serialPort1.Write(new byte[] { (byte)packetNumber }, 0, 1);
            serialPort1.Write(new byte[] { (byte)invertedPacketNumber }, 0, 1);
            serialPort1.Write(data, 0, dataSize);
            serialPort1.Write(CRC, 0, crcSize);
        }
#endregion
        /* control signals */
        const byte STX = 2;  // Start of TeXt 
        const byte EOT = 4;  // End Of Transmission
        const byte ACK = 6;  // Positive ACknowledgement
        const byte NAK = 0x15;// negative acknowledge
        const byte C = 67;   // capital letter C
        const byte CA = 0x18;// two of these in succession aborts transfer 

        /* sizes */
        const int dataSize = 1024;
        const int crcSize = 2;

        /* THE PACKET: 1029 bytes */
        /* header: 3 bytes */
        // STX
        int packetNumber = 0;
        int invertedPacketNumber = 255;
        /* data: 1024 bytes */
        byte[] data = new byte[dataSize];
        /* footer: 2 bytes */
        byte[] CRC = new byte[crcSize];

        /*bool bUploadingFirmware = false;
        bool bReqUploadingFirmware = false;
        long uploadingFirmwareTimeTick = 0;*/
        enum FWStage
        {
            WaitForStart1 = 0,
            WaitForStart2,
            WaitForStart3,
            SendingData,
            Closing1,
            Closing2,
            Closing3,
            Closing4
        };
        int uploadingFWStage = (int)FWStage.WaitForStart1;
        FileStream fileStream = null;
        int fileReadCount = 0;
        string path = "";
        private void doUploadingFirmware(int dt)
        {
            Console.WriteLine("douUploadingFirmware:uploadingFWStage:" + uploadingFWStage.ToString("X") + " d:" + dt.ToString("X") + ":" + Environment.TickCount.ToString());
            if (uploadingFWStage == (int)FWStage.WaitForStart1 &&
                dt == C)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                packetNumber = 0;
                invertedPacketNumber = 255;
                sendYmodemInitialPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, path, fileStream, CRC, crcSize);
                uploadingFWStage = (int)FWStage.WaitForStart2;
                Console.WriteLine("sendYmodemInitialPacket");
            }
            else if (uploadingFWStage == (int)FWStage.WaitForStart2 &&
                dt == ACK)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                uploadingFWStage = (int)FWStage.WaitForStart3;
                Console.WriteLine("WaitForStart2");
            }
            else if ((uploadingFWStage == (int)FWStage.WaitForStart3 && dt == C) ||
                    uploadingFWStage == (int)FWStage.SendingData && dt == ACK)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                if (uploadingFWStage == (int)FWStage.SendingData &&
                    dataSize != fileReadCount)
                {//finished
                    uploadingFWStage = (int)FWStage.Closing3;
                    serialPort1.Write(new byte[] { EOT }, 0, 1);
                    Console.WriteLine("EOT1");
                    fileStream.Close();
                    return;
                }
                uploadingFWStage = (int)FWStage.SendingData;
                fileReadCount = fileStream.Read(data, 0, dataSize);
                if (fileReadCount == 0)
                {
                    uploadingFWStage = (int)FWStage.Closing1;
                    serialPort1.Write(new byte[] { EOT }, 0, 1);
                    Console.WriteLine("EOT2");
                    return;
                }
                if (fileReadCount != dataSize)
                    for (int i = fileReadCount; i < dataSize; i++)
                        data[i] = 0;
                /* calculate packetNumber */
                packetNumber++;
                if (packetNumber > 255)
                    packetNumber -= 256;
                Console.WriteLine(packetNumber);
                /* calculate invertedPacketNumber */
                invertedPacketNumber = 255 - packetNumber;
                /* calculate CRC */
                Crc16Ccitt crc16Ccitt = new Crc16Ccitt(InitialCrcValue.Zeros);
                CRC = crc16Ccitt.ComputeChecksumBytes(data);
                /* send the packet */
                sendYmodemPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);

                if (txtSP.Lines[txtSP.Lines.Length - 1].Length > 50)
                {
                    showText("\r\n");
                }
                showText(".");
                metroProgressSpinner2.Value = (int)(fileStream.Position * 100 / fileStream.Length);
                metroLabelUploadProgress2.Text = string.Format("{0:G}%", fileStream.Position * 100 / fileStream.Length);
                return;
            }
            else if (uploadingFWStage == (int)FWStage.Closing3 &&
                dt == C)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                uploadingFWStage = (int)FWStage.Closing4;
                packetNumber = 0;
                invertedPacketNumber = 255;
                data = new byte[dataSize];
                CRC = new byte[crcSize];
                sendYmodemClosingPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, CRC, crcSize);
                Console.WriteLine("sendYmodemClosingPacket");
                return;
            }
            else if (uploadingFWStage == (int)FWStage.Closing4 &&
                (dt == ACK || dt == C))
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                bUploadingFirmware = false;
                serialPort1.Write(new byte[] { 0x0a, 0x0d }, 0, 2);
                Console.WriteLine("Upload Firmware Success");
                metroLabelUploadProgress2.Text = "100%";
                metroProgressSpinner2.Value = 100;
                metroProgressSpinner2.Spinning = false;
                this.btnSendFW.Text = "Update";
                MetroMessageBox.Show(this, "Upload Firmware Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dt == CA)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                if (this.btnSendFW.Text == "Abort")
                {
                    this.btnSendFW.PerformClick();
                }
                MetroMessageBox.Show(this, "Upload Firmware Abort!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
#endregion

        private void btnStartAP_Click(object sender, EventArgs e)
        {
            if (textBoxAPSSID.Text=="")
            {
                MetroMessageBox.Show(this, "SSID must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sendData2SerialPort("cfg={ssid='" + textBoxAPSSID.Text + "',pwd='" + textBoxAPPSW.Text + "'};wifi.startap(cfg);cfg=nil;\r\n");
        }

        private void btnStopAP_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("wifi.ap.stop()\r\n");
        }

        private void btnGetAPIP_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=wifi.ap.getipadv()\r\n");
        }

        private void btnStartSTA_Click(object sender, EventArgs e)
        {
            if (textBoxSTASSID.Text == "")
            {
                MetroMessageBox.Show(this, "SSID must be filled", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            sendData2SerialPort("cfg={ssid='" + textBoxSTASSID.Text + "',pwd='" + textBoxSTAPSW.Text + "'};wifi.startsta(cfg);cfg=nil;\r\n");
        }

        private void btnStopSTA_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("wifi.sta.stop()\r\n");
        }

        private void btnGetSTAIP_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=wifi.sta.getipadv()\r\n");
        }

        private void btnGetSTALink_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=wifi.sta.getlink()\r\n");
        }

        private void btnTimerStart_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("tmr.start(" + metroComboBoxTimerID.SelectedIndex.ToString() + "," + int.Parse(metroTextBoxPeriod.Text) + ",function() print('tmr:" + metroComboBoxTimerID.SelectedIndex.ToString() + ",tick:'..tmr.tick()) end)\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            } 
        }

        private void btnTimerStop_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("tmr.stop(" + metroComboBoxTimerID.SelectedIndex.ToString() + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            } 
        }

        private void btnTimerWd_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("tmr.wdclr()\r\n");
        }

        private void btnTimerDelay_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("tmr.delayms(" + int.Parse(metroTextBoxPeriod.Text) + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnGPIOSetmode_Click(object sender, EventArgs e)
        {
            MetroComboBox cbGPIOMode = metroComboBoxGPIOMode;
            MetroComboBox cbGPIOPin = metroComboBoxGPIOPin;
            if (cbGPIOMode.SelectedIndex >= 0 && cbGPIOMode.SelectedIndex <= 7)
            {
                sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + "," + cbGPIOMode.Text + ")\r\n");
            }
            else if (cbGPIOMode.SelectedIndex >= 8)
            {
                if (DialogResult.Cancel == MetroMessageBox.Show(this, "The GPIO pin interrupt callback function will be like this:\r\n gpio.mode(pin,gpio.INT, function() print(gpio.read(pin)) end)", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }
                if (cbGPIOMode.SelectedIndex == 8)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'rising',function() print(gpio.read(" + cbGPIOPin.SelectedIndex.ToString() + ")) end)\r\n");
                }
                else if (cbGPIOMode.SelectedIndex == 9)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'falling',function() print(gpio.read(" + cbGPIOPin.SelectedIndex.ToString() + ")) end)\r\n");
                }
                else if (cbGPIOMode.SelectedIndex == 10)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'both',function() print(gpio.read(" + cbGPIOPin.SelectedIndex.ToString() + ")) end)\r\n");
                }
            }
        }

        private void btnGPIORead_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("=gpio.read(" + metroComboBoxGPIOPin.SelectedIndex.ToString() + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnGPIOToggle_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("gpio.toggle(" + metroComboBoxGPIOPin.SelectedIndex.ToString() + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnGPIOSetHigh_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("gpio.toggle(" + metroComboBoxGPIOPin.SelectedIndex.ToString() + ",gpio.HIGH)\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnGPIOSetLow_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("gpio.toggle(" + metroComboBoxGPIOPin.SelectedIndex.ToString() + ",gpio.LOW)\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void metroButtonPWMStart_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arry = new int[] { 1, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                String freq = metroTextBoxFreq.Text;
                String duty = metroTextBoxDuty.Text;
                sendData2SerialPort("pwm.start(" + arry[metroComboBoxPWMPin.SelectedIndex].ToString() + "," + freq + "," + duty + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void metroButtonPWMStop_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arry = new int[] { 1, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16 };
                sendData2SerialPort("pwm.stop(" + arry[metroComboBoxPWMPin.SelectedIndex].ToString() + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void metroButtonADCRead_Click(object sender, EventArgs e)
        {
            try
            {
                int[] arry = new int[] { 1, 13, 15, 16, 17 };
                sendData2SerialPort("=adc.read(" + arry[metroComboBoxADCPin.SelectedIndex].ToString() + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void metroButtonSet_Click(object sender, EventArgs e)
        {
            try
            {
                String uartID= metroComboBoxUart.Text;
                String baud = metroComboBoxBaud.Text;
                String bit = metroComboBoxBits.Text;
                String parity = metroComboBoxParity.Text;
                String stop = metroComboBoxStop.Text;
                sendData2SerialPort("uart.setup(" + uartID + "," + baud + ",'" + parity + "'," + bit + "," + stop + ");uart.on(" + uartID + ", 'data',function(d) print('Uart Recieve:'..d)end)\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void metroButtonUartSend_Click(object sender, EventArgs e)
        {
            try
            {
                String uartID= metroComboBoxUart.Text;
                String d = metroTextBoxUartData.Text;
                sendData2SerialPort("uart.send(" + uartID + ",'" + d + "')\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void checkBoxBindLoaclPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBindLoaclPort.Checked && checkBoxBindLoaclPort.Enabled)
            {
                textBoxBindLoadPort.Enabled = true;
            }
            else
                textBoxBindLoadPort.Enabled = false;
        }

        private void checkBoxBindLoaclPort_EnabledChanged(object sender, EventArgs e)
        {
            if (checkBoxBindLoaclPort.Checked && checkBoxBindLoaclPort.Enabled)
            {
                textBoxBindLoadPort.Enabled = true;
            }
            else
                textBoxBindLoadPort.Enabled = false;
        }

        private void metroToggleSocketType_CheckStateChanged(object sender, EventArgs e)
        {
            if (metroToggleSocketType.Checked == false)
            {
                textBoxIP.Enabled = false;
                labelPort.PromptText = " Local Port";
                textBoxSendData.Enabled = false;
                btnSendData.Enabled = false;
                checkBoxBindLoaclPort.Enabled = false;
            }
            else
            {
                textBoxIP.Enabled = true;
                labelPort.PromptText = "Remote Port";
                textBoxSendData.Enabled = true;
                btnSendData.Enabled = true;
                checkBoxBindLoaclPort.Enabled = true;
            }
        }

        private void btnNetSet_Click(object sender, EventArgs e)
        {
            String socketType = "net.SERVER";
            if (metroToggleSocketType.Checked==true)
                socketType = "net.CLIENT";
            String transtype = "net.TCP";
            if (metroToggleTransType.Checked==true)
                transtype = "net.UDP";
            if (metroToggleSocketType.Checked==false)
            {
                String port = labelPort.Text;
                sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\nnet.start(skt," + port + ")\r\n");
            }
            else
            {
                String ip = textBoxIP.Text;
                String port = labelPort.Text;
                String localPort = textBoxBindLoadPort.Text;
                if (checkBoxBindLoaclPort.Enabled && checkBoxBindLoaclPort.Checked)
                {
                    sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\n net.start(skt," + port + ",'" + ip + "'," + localPort + ");\r\n");
                }
                else
                    sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\nnet.start(skt," + port + ",'" + ip + "')\r\n");
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("net.send(skt,'" + this.textBoxSendData.Text + "')\r\n");
        }

    }
}
