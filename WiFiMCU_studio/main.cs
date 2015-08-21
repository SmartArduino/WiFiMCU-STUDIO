using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using System.IO.Ports;
using System.IO;
using System.Threading; 

using Eductor;


namespace WiFiMCU
{
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void main_Load(object sender, EventArgs e)
        {
            txtSP.Clear();
            txtSP.AppendText("\r\n-->Welcome to WiFiMCU<--\r\n");
            toolStripStatusLabel1.Text = "                  Upload/Download Progress";
            toolStripStatusLabelSerialPort.Text = "Serial Port closed";
            btnScanPort.PerformClick();
            comboBoxSerialBaudrate.SelectedIndex = 0;

            timer1.Start();

            tabControl1.SelectTab(tabPage1);
            toolStripStatusLabel1.Text = "Upload/Download file progress";
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel2.Text = "";

            getInitFile();

        }
        private void main_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveInitFile();
            serialPort1.Close();            
        }

        private void getInitFile()
        {
            IniFileClass p = new IniFileClass(".\\para.ini");
            cbGPIOPin.SelectedIndex = int.Parse(p.IniReadValue("page1", "cbGPIOPin", "0"));
            cbGPIOMode.SelectedIndex = int.Parse(p.IniReadValue("page1", "cbGPIOMode", "0"));
            cbTimerID.SelectedIndex = int.Parse(p.IniReadValue("page1", "cbTimerID", "0"));
            comboBoxPWMPin.SelectedIndex = int.Parse(p.IniReadValue("page1", "comboBoxPWMPin", "0"));
            comboBoxADCPin.SelectedIndex = int.Parse(p.IniReadValue("page1", "comboBoxADCPin", "0"));
            textBoxPeriod.Text = p.IniReadValue("page1", "textBoxPeriod", "1000");
            textBoxFreq.Text = p.IniReadValue("page1", "textBoxFreq", "10000");
            textBoxDuty.Text = p.IniReadValue("page1", "textBoxDuty", "50");
            textBoxSSID.Text = p.IniReadValue("page2", "textBoxSSID", "WiFiMCU_Wireless");
            textBoxPSW.Text = p.IniReadValue("page2", "textBoxPSW", "");
            textBoxIP.Text = p.IniReadValue("page2", "textBoxIP", "11.11.11.2");
            textBoxPort.Text = p.IniReadValue("page2", "textBoxPort", "9000");
            textBoxBindLoadPort.Text = p.IniReadValue("page2", "textBoxBindLoadPort", "8000");
            textBoxSendData.Text = p.IniReadValue("page2", "textBoxSendData", "Test Data");
            comboBoxSerialPort.Text = p.IniReadValue("page0", "comboBoxSerialPort", "");
            comboBoxSerialBaudrate.Text = p.IniReadValue("page0", "comboBoxSerialBaudrate", "115200"); 
        }
        private void saveInitFile()
        {
            IniFileClass p = new IniFileClass(".\\para.ini");
             p.IniWriteValue("page1", "cbGPIOPin", cbGPIOPin.SelectedIndex.ToString());
             p.IniWriteValue("page1", "cbGPIOMode", cbGPIOMode.SelectedIndex.ToString());
             p.IniWriteValue("page1", "cbTimerID", cbTimerID.SelectedIndex.ToString());
             p.IniWriteValue("page1", "comboBoxPWMPin", comboBoxPWMPin.SelectedIndex.ToString());
             p.IniWriteValue("page1", "comboBoxADCPin", comboBoxADCPin.SelectedIndex.ToString());
             p.IniWriteValue("page1", "textBoxPeriod", textBoxPeriod.Text);
             p.IniWriteValue("page1", "textBoxFreq", textBoxFreq.Text);
             p.IniWriteValue("page1", "textBoxDuty", textBoxDuty.Text);
             p.IniWriteValue("page2", "textBoxSSID", textBoxSSID.Text);
             p.IniWriteValue("page2", "textBoxPSW", textBoxPSW.Text);
             p.IniWriteValue("page2", "textBoxIP", textBoxIP.Text);
             p.IniWriteValue("page2", "textBoxPort", textBoxPort.Text);
             p.IniWriteValue("page2", "textBoxBindLoadPort", textBoxBindLoadPort.Text);
             p.IniWriteValue("page2", "textBoxSendData", textBoxSendData.Text);
             p.IniWriteValue("page0", "comboBoxSerialPort", comboBoxSerialPort.Text);
             p.IniWriteValue("page0", "comboBoxSerialBaudrate", comboBoxSerialBaudrate.Text);
        }

        #region

        private static string StringToHexString(string str)
        {
            StringBuilder hexString = new StringBuilder(2 * str.Length);

            for (int i = 0; i < str.Length; i++)
                hexString.AppendFormat("{0:X2}", Convert.ToByte(str[i]));
            return hexString.ToString();
        }

        public delegate void AsyReceiveDataHandler();
        String strSerialBuff = "";
        long lastgetSerialBuffTick = 0;
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
                    ex.ToString();
                    MessageBox.Show("AsyncReceiveData");
                }
                
            }
            else
            {
                string strTemp = "";
#region uploadingFirmware
                if (bUploadingFirmware)
                {
                    douUploadingFirmware(serialPort1.ReadByte());
                    return;
                }
                else
                {
                    strTemp = serialPort1.ReadExisting().ToString();
                }
#endregion
                if (bReqUploadingFirmware==true && strTemp == "C")
                {
                    bReqUploadingFirmware = false;
                    bUploadingFirmware = true;
                    Console.WriteLine("Start uploading...");
                }
                //Console.WriteLine(strTemp);
                #region  dealwith backspace
                string backspaceStr = StringToHexString(strTemp);
                //Console.WriteLine(backspaceStr);
                if ((strTemp.Length == 1 && backspaceStr == "08") ||
                    (strTemp.Length == 2 && backspaceStr == "2008") ||
                    (strTemp.Length == 3 && backspaceStr == "082008"))
                {
                    if (Environment.TickCount - lastBackSpaceTimeTick < 50) return;
                    lastBackSpaceTimeTick = Environment.TickCount;
                    txtSP.Text = txtSP.Text.Remove(txtSP.Text.Length - 1, 1);
                    this.txtSP.SelectionStart = this.txtSP.Text.Length;
                    this.txtSP.ScrollToCaret();
                    return;
                }
                #endregion

                if (!fileIsUploading &&
                    !bIsGetingFileList)
                {
                    strTemp = strTemp.Replace("\n\r", "\r\n");
                    this.txtSP.AppendText(strTemp);
                }
                if (strTemp.IndexOf("\r\n")<0)
                {
                    lastgetSerialBuffTick = Environment.TickCount;
                    strSerialBuff = strSerialBuff+strTemp;
                    return;
                }
                strSerialBuff = strSerialBuff + strTemp;
                if (strSerialBuff.IndexOf("file.rename") >= 0 ||
                        strSerialBuff.IndexOf("file.remove") >= 0 ||
                        strSerialBuff.IndexOf("file.compile") >= 0)
                    this.btnFilelist.PerformClick();

#region dealwith uploading
                if (fileIsUploading == true)
                {
                    //Console.WriteLine(strSerialBuff);
                    if (strSerialBuff.IndexOf("stdin:1") >= 0)
                    {
                        fileIsUploading = false;
                        toolStripStatusLabel1.Text = "Upload file failed";
                        this.btnUpload.Text = "Upload";
                        sendData2SerialPort("\r\n");
                        txtSP.AppendText("\r\n Error happened, stop download!\r\n");
                        MessageBox.Show(this, "File: '" + fileUploadFileName + "' upload failed", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                        //this.btnFilelist.PerformClick();
                        strSerialBuff = "";
                        return;
                    }
                    if (indexFileData == stringFileData.Length)
                    {//send ok
                        sendData2SerialPort("file.close();s=nil;\r\n");
                        indexFileData++;
                        txtSP.AppendText(".");
                        //txtSP.AppendText(strSerialBuff);
                        toolStripProgressBar1.Value = 99;
                        toolStripStatusLabel2.Text = "99%";
                    }
                    else if (indexFileData > stringFileData.Length)
                    {
                        fileIsUploading = false;
                        txtSP.AppendText("\r\n-->Upload file: '" + fileUploadFileName + "' successful<--\r\n");
                        sendData2SerialPort("\r\n");
                        //this.Enabled = true;
                        toolStripStatusLabel1.Text = "Upload Successfully";
                        toolStripProgressBar1.Value = 100;
                        toolStripStatusLabel2.Text = "100%";
                        this.btnUpload.Text = "Upload";
                        this.btnFilelist.PerformClick();
                    }
                    else
                    {
                        String sdata = stringFileData[indexFileData++];
                        fileUploadTimeTick = Environment.TickCount;
                        //Thread.Sleep(10);
                        //txtSP.AppendText("Recieve: " + strSerialBuff);
                        //txtSP.AppendText("Send: s(\'" + sdata + "')\r\n");
                        //Console.WriteLine("Recieve: " + strSerialBuff);
                        //Console.WriteLine("Send: s(\'" + sdata + "')\r\n");
                        if (txtSP.Lines[txtSP.Lines.Length - 1].Length > 30)
                        {
                            txtSP.AppendText("\r\n");
                        }
                        txtSP.AppendText(".");
                        string strData = "s('" + sdata + "')\r\n";
                        Thread.Sleep(50);
                        sendData2SerialPort(strData);
                        
                        string pg = string.Format("{0:G}", indexFileData * 100 / stringFileData.Length);
                        toolStripProgressBar1.Value = indexFileData * 100 / stringFileData.Length;
                        toolStripStatusLabel2.Text = pg + "%";
                    }
                    strSerialBuff = "";
                    return;
                }
#endregion
#region dealwith geting filelist
                if (bIsGetingFileList == true)
                {
                    //txtSP.AppendText(strSerialBuff);
                    lGetingFileListTimeTick = Environment.TickCount;
                    fileListString = fileListString + strSerialBuff;
                    strSerialBuff = "";
                    return;
                }       
#endregion
                strSerialBuff = "";
            }
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            AsyncReceiveData();
        }

        #endregion     
        
        private void copy_Click(object sender, EventArgs e)
        {
            txtSP.Copy();
        }

        private void paste_Click(object sender, EventArgs e)
        {
            IDataObject data = Clipboard.GetDataObject();
            if (data.GetDataPresent(typeof(String)))
            {
                String str = (String)data.GetData(typeof(String));
                //txtSP.AppendText(str);
                //txtSP.Select(txtSP.Text.Length, 0);
                //txtSP.Focus();
                sendData2SerialPort(str);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (btnOpenPort.Text == "Close"&& serialPort1.IsOpen==false)
            {
                    serialPort1.Close();
                    fileIsUploading = false;
                    bIsGetingFileList = false;
                    bUploadingFirmware = false;
                    btnOpenPort.Text = "Open";
                    btnOpenPort.BackColor = Color.Gold;
                    comboBoxSerialPort.Enabled = true;
                    this.btnScanPort.Enabled = true;
                    this.btnScanPort.BackColor = Color.DarkOrchid;
                    toolStripStatusLabelSerialPort.Text = "Error Detected, Close serial port!";
                    MessageBox.Show(this, "Serial Port Error Detected, Serial Port closed", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (strSerialBuff.Length>0 && Environment.TickCount - lastgetSerialBuffTick>300)
            {
                //txtSP.AppendText(strSerialBuff);
               strSerialBuff = "";
            }
            if (fileIsUploading==true&&
                Environment.TickCount - fileUploadTimeTick>1500)
            {
                fileIsUploading = false;
                //this.Enabled = true;
                toolStripStatusLabel1.Text = "Upload file failed";
                this.btnUpload.Text = "Upload";
                sendData2SerialPort("\r\n");
                MessageBox.Show(this, "File: '" + fileUploadFileName + "' upload time out ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                //this.btnFilelist.PerformClick();
            }
#region dealwithGettingFileList
            if (bIsGetingFileList == true &&
                 Environment.TickCount - lGetingFileListTimeTick > 500)
            {
                bIsGetingFileList = false;
                if (fileListString == "")
                    MessageBox.Show(this, "Get File list time out ", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                else
                {
                    try{
                        string[] str = fileListString.Split(new string[] { "\r\n" }, StringSplitOptions.None);
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
                            if ((listView.Items.Count) % 2 == 0)
                                listView.Items[listView.Items.Count - 1].BackColor = Color.FloralWhite;
                            else
                                listView.Items[listView.Items.Count - 1].BackColor = Color.Moccasin;
                        }
                        listView.EndUpdate();
                    }
                    catch (System.Exception ex)
                    {
                        ex.ToString();
                    }
                }
            }
#endregion
#region dealwithUploadingFirmware
            if (bUploadingFirmware&&Environment.TickCount - uploadingFirmwareTimeTick>5*1000)
            {
                if (this.btnSendFW.Text == "Abort")
                {
                    this.btnSendFW.PerformClick();
                }
                serialPort1.Write(new byte[] { CA, CA }, 0, 2);
                MessageBox.Show(this, "Upload firmware Time Out", "Stop", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
#endregion
        }

        private void btnOpenPort_Click(object sender, EventArgs e)
        {
            try
            {
                Button btn1 = btnOpenPort;
                ComboBox cmbox = comboBoxSerialPort;
                if (!serialPort1.IsOpen)
                {
                    this.serialPort1.PortName = cmbox.Text.Trim();
                    this.serialPort1.BaudRate = int.Parse(comboBoxSerialBaudrate.Text);
                    serialPort1.Open();
                    btn1.Text = "Close";
                    btn1.BackColor = Color.DarkOrange;
                    cmbox.Enabled = false;
                    this.btnScanPort.Enabled =false;
                    this.btnScanPort.BackColor = Color.Gray;
                    toolStripStatusLabelSerialPort.Text = "Serial Port " + this.serialPort1.PortName + " is Opened                    ";
                    sendData2SerialPort("\r\n");
                }
                else
                {
                    if (fileIsUploading ||
                        bIsGetingFileList ||
                        bUploadingFirmware)
                    {
                        return ;
                    }
                    serialPort1.Close();
                    btn1.Text = "Open";
                    btn1.BackColor = Color.Gold;
                    cmbox.Enabled = true;
                    this.btnScanPort.Enabled = true;
                    this.btnScanPort.BackColor = Color.DarkOrchid;
                    toolStripStatusLabelSerialPort.Text = "Serial Port is not Opened                                      ";
                }
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnScanPort_Click(object sender, EventArgs e)
        {
            ComboBox cbxCOMPort = this.comboBoxSerialPort;
            cbxCOMPort.Items.Clear();
            for (int i = 0; i <=20 ; i++)
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

        private void clrScreenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            txtSP.Clear();
            sendData2SerialPort("\r\n");
        }
        private void sendData2SerialPort(String d)
        {
            if (this.serialPort1.IsOpen == false)
            {
                txtSP.AppendText("\r\n-->Serial Port is not Opened<--\r\n");
                return;
            }
            try
            {
                this.serialPort1.Write(d);
            }
            catch (Exception ex)
            {
                ex.ToString();
            }
        }
        long lastBackSpaceTimeTick = 0;
        long lastBackSpaceTimeTickKeyPress = 0;
        private void txtSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!isBtnOK())
            {
                e.Handled = false;
                return;
            }
            e.Handled = true;
            if (this.serialPort1.IsOpen == false)
            {
                txtSP.AppendText("\r\n-->Serial Port is not Opened<--\r\n");
                return;
            }
            string pressedKeyChar = e.KeyChar.ToString();
            //Console.WriteLine("presschar:" + pressedKeyChar);
            if (pressedKeyChar=="\b"&&
                Environment.TickCount - lastBackSpaceTimeTickKeyPress < 100)
            {
                e.Handled = false;
                return;
            }
            lastBackSpaceTimeTickKeyPress = Environment.TickCount;
               e.Handled = false;
            sendData2SerialPort(pressedKeyChar);
            pressedKeyChar = "";
         }

        private void btnReboot_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            strSerialBuff = "";
            string line = txtSP.Lines[txtSP.Lines.Length - 1];
            if (line.IndexOf("WiFiMCU>") >= 0)
                sendData2SerialPort("7\r\n");
            else
                sendData2SerialPort("mcu.reboot()\r\n");
        }

        private void btnChipID_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("collectgarbage()\r\n");
        }

        private void btnMCUMem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=mcu.mem()\r\n");
        }
        private void btnTimeTick_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=tmr.tick()\r\n");
        }
        bool bIsGetingFileList = false;
        long lGetingFileListTimeTick = 0;
        String fileListString = "";
        private void btnFilelist_Click(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            if (!isBtnOK()) return;
            sendData2SerialPort("file.slist()\r\n");
            bIsGetingFileList = true;
            lGetingFileListTimeTick = Environment.TickCount;
            fileListString = "";
        }
        private bool isBtnOK()
        {
            if (!serialPort1.IsOpen||
                fileIsUploading ||
                bIsGetingFileList||
                bUploadingFirmware)
            {
                return false;
            }
            return true;
        }
        private void btnFormat_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;

            if (MessageBox.Show("Format Flash will erase all the existing file data.\r\n Are you sure?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.No)
                return;
            sendData2SerialPort("\r\nprint('Wait for format done...');file.format()\r\n");
            this.listView1.Items.Clear();
        }
        string[] stringFileData=new string[1];
        int indexFileData = 0;
        bool fileIsUploading = false;
        long fileUploadTimeTick = 0;
        string fileUploadFileName = "";
        private void btnUpload_Click(object sender, EventArgs e)
        {
            if (this.btnUpload.Text=="Abort")
            {
                sendData2SerialPort("file.close();s=nil;\r\n");
                fileIsUploading = false;
                this.btnUpload.Text = "Upload";
                this.btnFilelist.PerformClick();
                return;
            }
            if (!isBtnOK()) return;

            System.Windows.Forms.OpenFileDialog fd = new OpenFileDialog();
            fd.Filter = "lua|*.lua|all|*.*";
            fd.Title = "Select the Uploading File";

            if (fd.ShowDialog() == DialogResult.OK)
            {
                string filePath = fd.FileName;
                StreamReader sr = new StreamReader(filePath);
                string content = sr.ReadToEnd();
                sr.Close();
                content = content.Replace("'", "\\'");
                content = content.Replace("\"", "\\\"");
                stringFileData = content.Split(new string[] { "\r\n" }, StringSplitOptions.None);
                indexFileData=0;
                fileUploadFileName = fd.SafeFileName;
                if (serialPort1.IsOpen)
                {
                    fileIsUploading = true;
                    fileUploadTimeTick = Environment.TickCount;
                    txtSP.AppendText("\r\nStart upload file: '" + fd.SafeFileName + "'");
                    sendData2SerialPort("file.remove('" + fd.SafeFileName + "');" + "file.open('" + fd.SafeFileName + "','w+');s=file.writeline;\r\n");
                    //this.Enabled = false;
                    toolStripStatusLabel1.Text = "Upload progress";
                    toolStripProgressBar1.Value = 0;
                    toolStripStatusLabel2.Text = "";
                    this.btnUpload.Text = "Abort";
                }
                else
                {
                    txtSP.AppendText("\r\n-->Serial Port is not Opened<--\r\n");
                    return;
                }
            }
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("dofile('"+fn+"')\r\n");
        }

        private void compileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0)return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("file.compile('" + fn + "')\r\n");
        }

        private void renameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;

            fileNewNameDialog fm = new fileNewNameDialog();
            fm.orginalFn = fn;
            if (fm.ShowDialog()==DialogResult.OK)
            {
                sendData2SerialPort("file.rename('" + fn + "','" + fm.newFn + "')\r\n");
            }

            //this.btnFilelist.PerformClick();
        }

        private void removeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            if(MessageBox.Show("Are you sure to remove the file:'"+fn+"'", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)==DialogResult.No)
                return;
            sendData2SerialPort("file.remove('" + fn + "')\r\n");
        }

        private void btnFileInfo_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=file.info()\r\n");
        }

        private void btnFileState_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            sendData2SerialPort("=file.state()\r\n");
        }

        private void viewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (!isBtnOK()) return;
            ListView listview = listView1;
            if (listview.SelectedItems.Count <= 0) return;
            String fn = listview.SelectedItems[0].SubItems[1].Text;
            sendData2SerialPort("file.open('" + fn + "','r') local d=1;while d do d=file.read(1024); if d then print(d) end end file.close() d=nil;print();\r\n");
        }

#region YMODEM
        private void sendYmodemInitialPacket(byte STX, int packetNumber, int invertedPacketNumber, byte[] data, int dataSize, string path, FileStream fileStream, byte[] CRC, int crcSize)
        {
            //string fileName = System.IO.Path.GetFileName(path);
            string fileName = "wifimcufw";//change the name to avoid errors
            string fileSize = fileStream.Length.ToString();

            if (radioButtonFW.Checked)
               fileName="firmware";
            else if (radioButtonBtloader.Checked)
               fileName="bootloader";
            else if (radioButtonWlanDrv.Checked)
                fileName="wlandrv";

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

        private void btnSendMCU_Click(object sender, EventArgs e)
        {
            RadioButton rb= null;
            if (radioButtonVer.Checked)
            {
                rb = radioButtonVer;
            }
            else if (radioButtonInfo.Checked)
            {
                rb = radioButtonInfo;
            }
            else if (radioButtonReboot.Checked)
            {
                rb = radioButtonReboot;
            }
            else if (radioButtonChipid.Checked)
            {
                rb = radioButtonChipid;
            }
            else if (radioButtonMem.Checked)
            {
                rb = radioButtonMem;
            }
            else if (radioButtonBootReason.Checked)
            {
                rb = radioButtonBootReason;
            }
            if (rb!=null)
            {
                sendData2SerialPort(rb.Tag.ToString()+"\r\n");
            }

        }

        private void cbGPIOMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbGPIOMode.SelectedIndex >= 0 && cbGPIOMode.SelectedIndex<=3)
            {
                btnHigh.Enabled = false;
                btnLow.Enabled = false;
                btnToggle.Enabled = false;
                btnRead.Enabled = true;
            }
            else if (cbGPIOMode.SelectedIndex>=4&& cbGPIOMode.SelectedIndex<=7)
            {
                btnHigh.Enabled = true;
                btnLow.Enabled = true;
                btnToggle.Enabled = true;
                btnRead.Enabled = false;
            }
            else if (cbGPIOMode.SelectedIndex >= 8)
            {
                btnHigh.Enabled = false;
                btnLow.Enabled = false;
                btnToggle.Enabled = false;
                btnRead.Enabled = true;
            }
        }

        private void btnSetMode_Click(object sender, EventArgs e)
        {
            if (cbGPIOMode.SelectedIndex >= 0 && cbGPIOMode.SelectedIndex <= 7)
            {
                sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + "," + cbGPIOMode.Text + ")\r\n");
            }
            else if (cbGPIOMode.SelectedIndex >= 8)
            {
                if (DialogResult.Cancel == MessageBox.Show(this, "The GPIO pin interrupt callback function will be like this:\r\n gpio.mode(pin,gpio.INT, function() print(gpio.read(pin)) end)", "Information", MessageBoxButtons.OKCancel, MessageBoxIcon.Question))
                {
                    return;
                }
                if (cbGPIOMode.SelectedIndex==8)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'rising',function() print(gpio.read(pin)) end)\r\n");
                }
                else if (cbGPIOMode.SelectedIndex == 9)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'falling',function() print(gpio.read(pin)) end)\r\n");
                }
                else if (cbGPIOMode.SelectedIndex == 10)
                {
                    sendData2SerialPort("gpio.mode(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.INT,'both',function() print(gpio.read(pin)) end)\r\n");
                }                
            }
        }

        private void textBoxPeriod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57))|| e.KeyChar== 0x8))
            {
                e.Handled = true;
            }
        }

        private void btnTmrStart_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("tmr.start(" + cbTimerID.SelectedIndex.ToString() + "," + int.Parse(textBoxPeriod.Text) + ",function() print('tmr:" + cbTimerID.SelectedIndex.ToString() + ",tick:'..tmr.tick()) end)\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }            
        }

        private void btnTmrStop_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("tmr.stop(" + cbTimerID.SelectedIndex.ToString() + ")\r\n");
        }

        private void btnTmrTick_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=tmr.tick()\r\n");
        }

        private void btnDelayms_Click(object sender, EventArgs e)
        {
            try
            {
                sendData2SerialPort("tmr.delayms(" + int.Parse(textBoxPeriod.Text) + ")\r\n");
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnWdgclr_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=tmr.wdclr()\r\n");
        }
        
        private void textBoxDuty_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (int.Parse(textBoxDuty.Text)<0||int.Parse(textBoxDuty.Text)>100)
                {
                    MessageBox.Show(this, "Duty should 0<=duty<=100", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void textBoxFreq_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (int.Parse(textBoxFreq.Text) <= 0 || int.Parse(textBoxFreq.Text) > 100000)
                {
                    MessageBox.Show(this, "Duty should 0<freq<=100Khz", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void textBoxPeriod_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                if (int.Parse(textBoxPeriod.Text) <= 0 )
                {
                    MessageBox.Show(this, "Period should >0", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (System.Exception ex)
            {
                ex.ToString();
            }
        }

        private void btnADCRead_Click(object sender, EventArgs e)
        {
            int[] arry = new int[] { 1, 13, 15, 16, 17 };
            sendData2SerialPort("=adc.read(" + arry[comboBoxADCPin.SelectedIndex].ToString() + ")\r\n");
        }

        private void btnHigh_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("gpio.write(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.HIGH)\r\n");
        }

        private void btnLow_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("gpio.write(" + cbGPIOPin.SelectedIndex.ToString() + ",gpio.LOW)\r\n");
        }

        private void btnToggle_Click(object sender, EventArgs e)
        {
             sendData2SerialPort("gpio.toggle(" + cbGPIOPin.SelectedIndex.ToString() + ")\r\n");
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=gpio.read(" + cbGPIOPin.SelectedIndex.ToString()+"\r\n");
        }

        private void btnTmrStopAll_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("tmr.stopall()\r\n");
        }

        private void btnPWMStart_Click(object sender, EventArgs e)
        {
            int[] arry = new int[]{1, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            String freq = textBoxFreq.Text;
            String duty = textBoxDuty.Text;
            sendData2SerialPort("pwm.start(" + arry[comboBoxPWMPin.SelectedIndex].ToString() + "," + freq+","+duty+ ")\r\n");
        }

        private void btnPWMStop_Click(object sender, EventArgs e)
        {
            int[] arry = new int[]{1, 3, 8, 9, 10, 11, 12, 13, 14, 15, 16};
            sendData2SerialPort("pwm.stop(" + arry[comboBoxPWMPin.SelectedIndex].ToString() + ")\r\n");
        }

        private void radioButtonSTA_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButtonAP_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnGetLink_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("=wifi.sta.getlink()\r\n");
        }

        private void btnSetWiFiMode_Click(object sender, EventArgs e)
        {
            if (radioButtonAP.Checked)
                sendData2SerialPort("cfg={};cfg.ssid='"+textBoxSSID.Text+"';cfg.pwd='"+textBoxPSW.Text+"';wifi.startap(cfg);cfg=nil;\r\n");
            else
                sendData2SerialPort("cfg={};cfg.ssid='" + textBoxSSID.Text + "';cfg.pwd='" + textBoxPSW.Text + "';wifi.startsta(cfg);cfg=nil;\r\n");
        }

        private void btnStopWiFi_Click(object sender, EventArgs e)
        {
            if (radioButtonAP.Checked)
                 sendData2SerialPort("wifi.ap.stop()\r\n");
            else
                sendData2SerialPort("wifi.sta.stop()\r\n");

        }

        private void btnGetIP_Click(object sender, EventArgs e)
        {
            if (radioButtonAP.Checked)
                sendData2SerialPort("=wifi.ap.getipadv()\r\n");
            else
                sendData2SerialPort("=wifi.sta.getipadv()\r\n");
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("function listap(t) if t then for k,v in pairs(t) do print(k..'\\t\'..v);end else print('no ap') end end; wifi.scan(listap)\r\n");
        }

        private void radioButtonServer_Click(object sender, EventArgs e)
        {
            textBoxIP.Enabled = false;
            labelPort.Text = " Local Port";
            textBoxSendData.Enabled = false;
            btnSendData.Enabled = false;
            checkBoxBindLoaclPort.Enabled = false;
            //textBoxBindLoadPort.Enabled = false;
        }

        private void radioButtonClient_Click(object sender, EventArgs e)
        {
            textBoxIP.Enabled = true;
            labelPort.Text = "Remote Port";
            textBoxSendData.Enabled = true;
            btnSendData.Enabled = true;
            checkBoxBindLoaclPort.Enabled = true;
            //textBoxBindLoadPort.Enabled = true;
        }

        private void btnNetSet_Click(object sender, EventArgs e)
        {
            String socketType = "net.SERVER";
            if (radioButtonClient.Checked)
                socketType = "net.CLIENT";
            String transtype = "net.TCP";
            if (radioButtonUDP.Checked)
                transtype = "net.UDP";
            if (radioButtonServer.Checked)
            {
                String port = textBoxPort.Text;
                sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\nnet.start(skt," + port + ")\r\n");
            }
            else
            {
                String ip = textBoxIP.Text;
                String port = textBoxPort.Text;
                String localPort = textBoxBindLoadPort.Text;
                if (checkBoxBindLoaclPort.Enabled && checkBoxBindLoaclPort.Checked)
                {
                    sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\n net.start(skt," + port + ",'" + ip+"'," + localPort + ");\r\n");
                }
                else
                sendData2SerialPort("skt=net.new(" + transtype + "," + socketType + ");net.on(skt,'receive',function(c,d) print(d) net.send(c,d);end);\r\nnet.start(skt," + port + ",'"+ip+"')\r\n");
            }
        }

        private void textBoxPort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(((e.KeyChar >= (char)48) && (e.KeyChar <= (char)57)) || e.KeyChar == 0x8))
            {
                e.Handled = true;
            }
        }

        private void btnSendData_Click(object sender, EventArgs e)
        {
            sendData2SerialPort("net.send(skt,'" +this.textBoxSendData.Text +"')\r\n");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://www.doit.am/");  
        }

        private void checkBoxBindLoaclPort_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxBindLoaclPort.Checked&&checkBoxBindLoaclPort.Enabled)
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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(" https://github.com/SmartArduino/WiFiMCU/tree/master/Document");  
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/SmartArduino/WiFiMCU");  
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.doit.am/forum.php");  
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://bbs.smartarduino.com/");  
        }
        private void btnSendFW_Click(object sender, EventArgs e)
        {
            if (this.btnSendFW.Text == "Abort")
            {
                bUploadingFirmware = false;
                bReqUploadingFirmware = false;
                btnSendFW.Text = "Update";
                toolStripStatusLabel1.Text = "Upload file abort";
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
            //检查是否进入升级状态
            //WiFiMCU> 
            string line = txtSP.Lines[txtSP.Lines.Length - 1];
            if (line.IndexOf("WiFiMCU>")<0)
            {
                MessageBox.Show(this, "WiFiMCU must enter into bootloader mode!\r\n 'Press BOOT key while setup WiFiMCU to enter booloader mode'", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int uploadType = 0;
            if (radioButtonFW.Checked)
                uploadType = 0;
            else if (radioButtonBtloader.Checked)
                uploadType = 1;
            else if (radioButtonWlanDrv.Checked)
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

            if (uploadType==0&&
                (fileStream.Length<250*1024||
                fileStream.Length>512*1024))
             {
                 MessageBox.Show(this, "The length of WiFiMCU Firmware should between 250k~512k", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                 return;
             }
            if (uploadType == 1 &&
                (fileStream.Length < 10 * 1024 ||
                fileStream.Length > 30 * 1024))
            {
                MessageBox.Show(this, "The length of WiFiMCU Bootloader should between 10k~30k", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (uploadType == 2 &&
                (fileStream.Length < 200 * 1024 ||
                fileStream.Length > 210 * 1024))
            {
                MessageBox.Show(this, "The length of WiFiMCU Wlan Driver should between 200k~210k", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            toolStripStatusLabel1.Text = "Upload progress";
            toolStripProgressBar1.Value = 0;
            toolStripStatusLabel2.Text = "";
        }

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

        bool bUploadingFirmware = false;
        bool bReqUploadingFirmware = false;
        long uploadingFirmwareTimeTick = 0;
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
        FileStream fileStream=null;
        int fileReadCount=0;
        string path = "";
        private void douUploadingFirmware(int dt)
        {

            Console.WriteLine("douUploadingFirmware:uploadingFWStage:" + uploadingFWStage.ToString("X")+" d:" + dt.ToString("X")+":"+Environment.TickCount.ToString());
            if (uploadingFWStage==(int)FWStage.WaitForStart1&&
                dt == C)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                packetNumber = 0;
                invertedPacketNumber = 255;
                sendYmodemInitialPacket(STX, packetNumber, invertedPacketNumber, data, dataSize, path, fileStream, CRC, crcSize);
                uploadingFWStage = (int)FWStage.WaitForStart2;
                Console.WriteLine("sendYmodemInitialPacket");
            }
            else if (uploadingFWStage==(int)FWStage.WaitForStart2&&
                dt == ACK)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                uploadingFWStage = (int)FWStage.WaitForStart3;
                Console.WriteLine("WaitForStart2");
            }
            else if ((uploadingFWStage == (int)FWStage.WaitForStart3 &&dt == C)||
                    uploadingFWStage == (int)FWStage.SendingData && dt == ACK)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                if (uploadingFWStage == (int)FWStage.SendingData&&
                    dataSize != fileReadCount)
                {//finished
                    uploadingFWStage = (int)FWStage.Closing3;
                    serialPort1.Write(new byte[] { EOT }, 0, 1);
                    Console.WriteLine("EOT1");
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
                
                if (txtSP.Lines[txtSP.Lines.Length - 1].Length>30)
                {
                    txtSP.AppendText("\r\n");
                }
                txtSP.AppendText(".");
                //string pg = string.Format("{0:G}%", fileStream.Position * 100 / fileStream.Length);
                toolStripProgressBar1.Value = (int)(fileStream.Position * 100 / fileStream.Length);
                toolStripStatusLabel2.Text = string.Format("{0:G}%", fileStream.Position * 100 / fileStream.Length);
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
                (dt == ACK||dt==C))
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                bUploadingFirmware = false;
                serialPort1.Write(new byte[] { 0x0a,0x0d }, 0, 2);
                Console.WriteLine("Upload Firmware Success");
                toolStripStatusLabel1.Text = "Upload Successfully";
                toolStripStatusLabel2.Text = "100%";
                toolStripProgressBar1.Value = 100;
                this.btnSendFW.Text = "Update";
                MessageBox.Show(this, "Upload Firmware Success!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            if (dt==CA)
            {
                uploadingFirmwareTimeTick = Environment.TickCount;
                if (this.btnSendFW.Text == "Abort")
                {
                    this.btnSendFW.PerformClick();
                }
                MessageBox.Show(this, "Upload Firmware Abort!", "Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void linkLabel1_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://en.doit.am/");
        }   
    }
}
