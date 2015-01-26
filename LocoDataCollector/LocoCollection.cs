using System;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using LocoDataCollector.DeviceManager;
using LocoDataCollector.Enclosures;
using LocoDataCollector.Enclosures.Handlers;
using _DBG = Microsoft.SPOT.Debugger;
namespace LocoDataCollector
{
    partial class LocoCollection : Form
    {
        private readonly IDeviceManager _deviceManager;
        private bool IsDebugging { get { return isDebugging.Checked; } }
        private int _cancelIndex = -1;

        #region USB Handling

        public LocoCollection()
        {
            try
            {
                _deviceManager = new DeviceManager<StandardEnclosure>(new StandardMessageHandler(AddText));
                if (!Directory.Exists("c:\\Files")) Directory.CreateDirectory("c:\\Files");
                if (!Directory.Exists("c:\\Files\\EncData")) Directory.CreateDirectory("c:\\Files\\EncData");
                if (!Directory.Exists("c:\\Files\\EncData\\1")) Directory.CreateDirectory("c:\\Files\\EncData\\1");
                if (!Directory.Exists("c:\\Files\\EncData\\2")) Directory.CreateDirectory("c:\\Files\\EncData\\2");
                if (!Directory.Exists("c:\\Files\\EncData\\3")) Directory.CreateDirectory("c:\\Files\\EncData\\3");
                if (!Directory.Exists("c:\\Files\\EncData\\4")) Directory.CreateDirectory("c:\\Files\\EncData\\4");
                if (!Directory.Exists("c:\\Files\\EncData\\5")) Directory.CreateDirectory("c:\\Files\\EncData\\5");
                console.AppendText("All files are saved to: C:\\Files\\EncData\\\n");
            }
            catch (Exception e)
            {
                console.AppendText(e.Message + "\n");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _deviceManager.GeneratePortListAsync(deviceList);
        }

        #endregion

        #region FEZ Output Handling


        private void RemoveFromList(int encNum)
        {
            for (int count = 0; count < logConsole.Items.Count; count++)
            {
                var split = logConsole.Items[count].ToString().Split(' ');
                if (split[0].Contains("0" + encNum))
                {
                    var count1 = count;
                    logConsole.Invoke((MethodInvoker)(() => logConsole.Items.RemoveAt(count1)));
                    //console.AppendText("RemoveAt: " + count + "\n");
                }
            }
        }

        private void AddText(string text)
        {
            console.AppendText(text);
        }

        private void AddText(EnclosureMessage message)
        {
            if (_deviceManager[message.Enclosure] == null || !_deviceManager[message.Enclosure].IsLogging) return;
            var text = message.Message;
            var split = text.Split(' ');
            if ((ListenEnable(split[0])) || (isDebugging.Checked))
            {
                console.Invoke((MethodInvoker)delegate
                {
                    if (isDebugging.Checked)
                    {
                        console.AppendText("[DEBUG] " + text);
                        console.ScrollToCaret();
                    }
                    else
                    {
                        console.AppendText("[" + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToShortDateString() + "] " + text);
                        console.ScrollToCaret();
                        DisplayOutput(text);
                    }
                });
            }
        }

        private int GetEnclosureNumber(string output)
        {
            int enclosureId;
            int.TryParse(output.Replace("Enclosure0",""), out enclosureId);
            return enclosureId;
        }

        private bool ListenEnable(string enclosure)
        {
            bool listen;
            if (enclosure.Contains("01")) listen = cbListen1.Checked;
            else if (enclosure.Contains("02")) listen = cbListen2.Checked;
            else if (enclosure.Contains("03")) listen = cbListen3.Checked;
            else if (enclosure.Contains("04")) listen = cbListen4.Checked;
            else listen = cbListen5.Checked;
            return listen;
        }

        // Refactored
        private void btnConnect_Click(object sender, EventArgs e)
        {
            var connected = btnConnect.Text.Equals("disconnect", StringComparison.InvariantCultureIgnoreCase);

            if (connected)
            {
                _deviceManager.DisconnectFromDevice();
                AddText("Disconnected from device");
                btnConnect.Text = @"Connect";
                return;
            }
            try
            {
                var result = _deviceManager.ConnectToDevice(deviceList);
                if (!result.Result)
                {
                    AddText("Failed to connect to device");
                    return;
                }
                btnConnect.Text = @"Connect";
            }
            catch (Exception ex)
            {
                AddText("An unexpected error occurred while attempting to connnect: " + ex.Message);
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            _deviceManager.DisconnectFromDevice();
        }

        private void DisplayOutput(string output)
        {
            monitor.Invoke((MethodInvoker)delegate
            {
                var rearColor = Color.Red;
                monitor.Clear();
                var split = output.Split(' ');
                if (split.Length != 2) return;
            
                output = split[1];
                output = output.Replace(" ", string.Empty).Substring(0, 8);
                
                if (output.Length != 8) return;
                EnclosureOutput[GetEnclosureNumber(split[0])] = output;
                monitor.Clear();
                CheckBox[] displayList = { cbListen1, cbListen2, cbListen3, cbListen4, cbListen5 };
                for (var count = 0; count <= 4; count++)
                {
                    if (displayList[count].Checked)
                    {
                        if (EnclosureOutput[count].Substring(7, 1).Equals("1"))
                        {
                            monitor.AppendText("Enclosure0" + (count + 1) + "\n");
                            monitor.AppendTextAsync(GenerateOutputString(EnclosureOutput[count]), rearColor);
                        }
                        else monitor.AppendText("Enclosure0" + (count + 1) + "\n" + GenerateOutputString(EnclosureOutput[count]));
                    }
                }
                foreach (var line in EnclosureOutput)
                {
                    monitor.AppendText(line + "\n");
                }
            });
        }

        private string GenerateOutputString(string output)
        {
            const char repeatChar = 'O';
            const char breakChar = '-';
            var test = new String(repeatChar, 3) + " " + new String(repeatChar, 3) + " " + new String(repeatChar, 3) + " " + new String(repeatChar, 3) + " " + new String(repeatChar, 3);
            var line1 = test;
            var line2 = test;
            var line3 = test;
            if (output.Substring(4, 1).Equals("1")) line1 = line1.Replace(repeatChar, breakChar);
            if (output.Substring(5, 1).Equals("1")) line2 = line2.Replace(repeatChar, breakChar);
            if (output.Substring(6, 1).Equals("1")) line3 = line3.Replace(repeatChar, breakChar);
            StringBuilder[] sbArr = { new StringBuilder(line1), new StringBuilder(line2), new StringBuilder(line3) };
            sbArr = VerticalBeamBreak(output, 0, sbArr);
            sbArr = VerticalBeamBreak(output, 1, sbArr);
            sbArr = VerticalBeamBreak(output, 2, sbArr);
            sbArr = VerticalBeamBreak(output, 3, sbArr);
            var outputString = sbArr[0] + "\n" + sbArr[1] + "\n" + sbArr[2] + "\n\n";
            return outputString;
        }

        private StringBuilder[] VerticalBeamBreak(string output, int pos, StringBuilder[] sbArray)
        {
            const char breakChar = '|';
            var sbPos = ((pos+1)*4)-1;
            if (!output.Substring(pos, 1).Equals("1")) return sbArray;
            sbArray[0][sbPos] = breakChar;
            sbArray[1][sbPos] = breakChar;
            sbArray[2][sbPos] = breakChar;
            return sbArray;
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
        #endregion

        private void btCancelLogging_Click(object sender, EventArgs e)
        {
            if (logConsole.SelectedIndex > -1)
            {
                _cancelIndex = logConsole.SelectedIndex;
                logConsole.Enabled = false;
                btCancelLogging.Enabled = false;
                btCancelRequest.Visible = true;
                cbConfirmCancel.Visible = true;
            }
        }

        private void cbConfirmCancel_CheckedChanged(object sender, EventArgs e)
        {
            btConfirmRequest.Visible = true;
        }

        private void btConfirmRequest_Click(object sender, EventArgs e)
        {
            btCancelRequest.Visible = false;
            cbConfirmCancel.Checked = false;
            cbConfirmCancel.Visible = false;
            var split = logConsole.Items[_cancelIndex].ToString().Split(' ');
            var encNum = GetEnclosureNumber(split[0]);
            EnclosureLogger[encNum].EndLog();
            logConsole.Items.RemoveAt(logConsole.SelectedIndex);
            logConsole.Enabled = true;
            btConfirmRequest.Visible = false;
            btCancelRequest.Enabled = true;
            btCancelLogging.Enabled = true;
        }

        private void btCancelRequest_Click(object sender, EventArgs e)
        {
            btCancelRequest.Visible = false;
            btCancelLogging.Enabled = true;
            cbConfirmCancel.Checked = false;
            cbConfirmCancel.Visible = false;
            btConfirmRequest.Visible = false;
            logConsole.Enabled = true;
        }

        private void btErrorClear_Click(object sender, EventArgs e)
        {
            lbErrorMsg.Text = @" ";
            lbErrorMsg.Visible = false;
            btErrorClear.Visible = false;
        }

        private void DisplayError(string errorType, string errorMsg)
        {
            lbErrorMsg.Text = @"[" + errorType + @"] " + errorMsg;
            lbErrorMsg.Visible = true;
            btErrorClear.Visible = true;
        }

        private void btStartLogging_Click(object sender, EventArgs e)
        {
            var ddlItem = ddlEncNum.SelectedIndex;
            if (ddlItem == -1) DisplayError("LoggingError", "An invalid Enclosure Number was selected.");
            else
            {
                int hours;
                int minutes;
                Int32.TryParse(tbLogHours.Text, out hours);
                Int32.TryParse(tbLogMinutes.Text, out minutes);
                if ((hours == 0) && (minutes == 0)) DisplayError("LoggingDuration", "An invalid duration was specified. Hours and Minutes can only be whole numbers.");
                else if (EnclosureLogger[ddlItem].IsLogging()) DisplayError("EnclosureLogger", "The enclosure 0" + (ddlItem + 1) + " is already logging.");
                else
                {
                    EnclosureLogger[ddlItem].StartLog(hours, minutes);
                    logConsole.Items.Add(EnclosureLogger[ddlItem].ToString());
                }

            }

        }
    }   
}
