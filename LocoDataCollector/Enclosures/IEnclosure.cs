namespace LocoDataCollector.Enclosures
{
    interface IEnclosure
    {
        bool IsLogging { get; set; }
        BeamState State { get; set; }
        void UpdateBeamStates(string binaryStates);
    }
}
