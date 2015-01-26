namespace LocoDataCollector.Enclosures
{
    class StandardEnclosure : IEnclosure
    {
        public bool IsLogging { get; set; }
        public BeamState State { get; set; }
        private int EnclosureId { get; set; }
        public StandardEnclosure(int enclosureId)
        {
            EnclosureId = enclosureId;
        }

        public void UpdateBeamStates(string binaryStates)
        {
            throw new System.NotImplementedException();
        }

        public int GetId()
        {
            return EnclosureId;
        }
    }
}
