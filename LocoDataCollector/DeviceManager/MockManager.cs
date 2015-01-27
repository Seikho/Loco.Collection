using System.Threading.Tasks;
using System.Windows.Forms;
using Loco.Collection.Enclosures;

namespace Loco.Collection.DeviceManager
{
    class MockManager : IDeviceManager
    {
        public void GeneratePortListAsync(ComboBox deviceList)
        {
            deviceList.Items.Clear();
            deviceList.Items.Add("Mock Microcontroller");
        }

        public void DisconnectFromDevice()
        {
            throw new System.NotImplementedException();
        }

        public Task<bool> ConnectToDevice(ComboBox deviceList)
        {
            throw new System.NotImplementedException();
        }

        public IEnclosure this[int enclosureId]
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
