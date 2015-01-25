using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using LocoDataCollector.Enclosures;
using LocoDataCollector.Enclosures.Handlers;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

namespace LocoDataCollector.Usb
{
    internal class DeviceManager
    {
        private const int EnclosureCount = 5;
        private readonly MFDeploy _deploy = new MFDeploy();
        public MFDevice Device { get; private set; }
        public IMessageHandler Handler { get; private set; }

        private List<IEnclosure> Enclosures { get; set; }

        private DeviceManager(List<IEnclosure> enclosures, IMessageHandler handler)
        {
            Handler = handler;
            Enclosures = enclosures;
        }

        public static DeviceManager Instantiate<T>(IMessageHandler handler) where T : IEnclosure, new()
        {
            var enclosures = new List<IEnclosure>();
            for (var x = 1; x <= EnclosureCount; x++) enclosures.Add(new T());
            return new DeviceManager(enclosures, handler);
        }

        public IEnclosure this[int enclosureId]
        {
            get
            {
                if (enclosureId < 0 || enclosureId > 5) return null;
                return Enclosures[enclosureId];
            }
        }

        public async void GeneratePortListAsync(ComboBox deviceList)
        {
            var list = await Task.Run(() => _deploy.EnumPorts(TransportType.USB));
            deviceList.DataSource = null;
            if (list.Count > 0) deviceList.DataSource = list;
            deviceList.Update();
        }

        public async Task<bool> ConnectToDevice(ComboBox deviceList)
        {
            // Already connected to a device or invalid item selected
            if (Device != null || deviceList.SelectedIndex >= 0) return false;
            var port = (MFPortDefinition) deviceList.SelectedItem;
            Device = await Task.Run(() =>
            {
                var device = _deploy.Connect(port, null);
                if (device == null) return null;
                device.OnDebugText += Handler.Process;
                return device;
            });
            return Device != null;
        }

        public void DisconnectFromDevice()
        {
            //Already disconnected
            if (Device == null) return;
            Device.OnDebugText -= Handler.Process;
            Device.Dispose();
            Device = null;
        }

        //private void InputHandler(object sender, DebugOutputEventArgs e)
        //{

        //    if (e.Text.Contains("Enclosure"))
        //    {
        //        if (EnclosureLogger[GetEnclosureNumber(e.Text)].IsLogging()) EnclosureLogger[GetEnclosureNumber(e.Text)].LogData(e.Text);
        //        AddText(e.Text);
        //        if (!EnclosureLogger[GetEnclosureNumber(e.Text)].IsLogging())
        //        {
        //            RemoveFromList(GetEnclosureNumber(e.Text) + 1);
        //        }
        //    }
        //}

    }
}