using System;

namespace LocoDataCollector.Enclosures.Handlers
{
    interface IMessageHandler
    {
        int GetEnclosureId(string message);
        void Process(object sender, EventArgs e);
        Action<EnclosureMessage> Writer { get; set; }
    }
}
