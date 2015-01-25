namespace LocoDataCollector.Enclosures
{
    class StandardEnclosure : IEnclosure
    {
        public bool IsLogging { get; set; }
        public BeamState State { get; set; }
        public void UpdateBeamStates(string binaryStates)
        {
            throw new System.NotImplementedException();
        }
    }
}
