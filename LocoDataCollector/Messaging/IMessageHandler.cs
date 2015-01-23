namespace LocoDataCollector.Messaging
{
    interface IMessageHandler
    {
        int GetEnclosureNumber(string message);
    }
}
