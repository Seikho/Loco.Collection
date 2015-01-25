using System;

namespace LocoDataCollector.Enclosures.Handlers
{
    internal abstract class MessageHandler : IMessageHandler
    {
        protected MessageHandler(Action<EnclosureMessage> writer)
        {
            Writer = writer;
        }

        public string Message { get; set; }
        public int Enclosure { get; set; }
        public abstract int GetEnclosureId(string message);

        public void Process(object sender, EventArgs e)
        {
            var message = ParseMessage(e);
            Writer(message);
        }

        public Action<EnclosureMessage> Writer { get; set; }

        protected abstract EnclosureMessage ParseMessage(EventArgs eventArgs);
    }
}
