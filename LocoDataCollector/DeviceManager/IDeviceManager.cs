using System.Threading.Tasks;
using System.Windows.Forms;
using Loco.Collection.Enclosures;

namespace Loco.Collection.DeviceManager
{
    interface IDeviceManager
    {
        void GeneratePortListAsync(ComboBox deviceList);
        void DisconnectFromDevice();
        Task<bool> ConnectToDevice(ComboBox deviceList);
        IEnclosure this[int enclosureId] { get; }
    }
}
