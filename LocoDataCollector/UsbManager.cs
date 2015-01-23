using System;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

namespace LocoDataCollector
{
    internal class UsbManager
    {
        readonly MFDeploy _mDeploy = new MFDeploy();
        MFDevice _mDevice;

        public async void GeneratePortListAsync(ComboBox deviceList)
        {
            var list = await Task.Run(() => _mDeploy.EnumPorts(TransportType.USB));
            deviceList.DataSource = null;
            if (list.Count > 0) deviceList.DataSource = list;
            deviceList.Update();
        }

        public async Task<bool> ConnectToDevice(ComboBox deviceList)
        {
            // Already connected to a device or invalid item selected
            if (_mDevice != null || deviceList.SelectedIndex >= 0) return false;
            var port = (MFPortDefinition) deviceList.SelectedItem;
            _mDevice = await Task.Run(() => _mDeploy.Connect(port, null));
            return _mDevice != null;
        }

        public bool DisconnectFromDevice()
        {
            //Already disconnected
            if (_mDevice == null) return true;
            _mDevice.OnDebugText -= InputHandler;
            _mDevice.Dispose();
            _mDevice = null;
            return true;
        }

        private void InputHandler(object sender, DebugOutputEventArgs e)
        {

            if (e.Text.Contains("Enclosure"))
            {
                if (EnclosureLogger[GetEnclosureNumber(e.Text)].IsLogging()) EnclosureLogger[GetEnclosureNumber(e.Text)].LogData(e.Text);
                AddText(e.Text);
                if (!EnclosureLogger[GetEnclosureNumber(e.Text)].IsLogging())
                {
                    RemoveFromList(GetEnclosureNumber(e.Text) + 1);
                }
            }
        }

    }
}