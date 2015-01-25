using System;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

namespace LocoDataCollector.Enclosures.Handlers
{
    class StandardMessageHandler : MessageHandler
    {
        public StandardMessageHandler(Action<EnclosureMessage> writer) : base(writer)
        {
        }

        public override int GetEnclosureId(string message)
        {
            throw new System.NotImplementedException();
        }

        protected override EnclosureMessage ParseMessage(EventArgs eventArgs)
        {
            var args = eventArgs as DebugOutputEventArgs;
            if (args == null) return new EnclosureMessage{Enclosure = 0, Message = "DebugOutputEventArgs is null"};
            return new EnclosureMessage{Enclosure = GetEnclosureId(args.Text), Message = args.Text};
        }
    }
}
