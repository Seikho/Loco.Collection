using System;
using Microsoft.NetMicroFramework.Tools.MFDeployTool.Engine;

namespace Loco.Collection.Enclosures.Handlers
{
    class StandardMessageHandler : MessageHandler
    {
        public StandardMessageHandler(Action<EnclosureMessage> writer) : base(writer)
        {
        }

        public override int GetEnclosureId(string message)
        {
            var enclosure = message.Split(' ')[0];
            int id;
            Int32.TryParse(enclosure.Replace("Enclosure0", ""), out id);
            return id;
        }

        protected override EnclosureMessage ParseMessage(EventArgs eventArgs)
        {
            var args = eventArgs as DebugOutputEventArgs;
            if (args == null) return new EnclosureMessage{Enclosure = 0, BeamStates = null};
            return new EnclosureMessage{Enclosure = GetEnclosureId(args.Text), BeamStates = new BeamState(args.Text.Split(' ')[1])};
        }
    }
}
