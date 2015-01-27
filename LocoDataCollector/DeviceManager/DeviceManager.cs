using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;
using Loco.Collection.Enclosures;
using Loco.Collection.Enclosures.Handlers;
using Loco.Collection.Loggers;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

namespace Loco.Collection.DeviceManager
{
    internal class DeviceManager<T> : IDeviceManager where T : IEnclosure, new()
    {
        private const int EnclosureCount = 5;
        private readonly MFDeploy _deploy = new MFDeploy();
        private MFDevice Device { get; set; }
        private IMessageHandler Handler { get; set; }
        private ILogger Logger { get; set; }

        private List<IEnclosure> Enclosures { get; set; }

        public DeviceManager(IMessageHandler handler, ILogger logger)
        {
            Handler = handler;
            Enclosures = new List<IEnclosure>();
            Logger = logger;
            for (var x = 1; x <= EnclosureCount; x++) Enclosures.Add(new T());
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