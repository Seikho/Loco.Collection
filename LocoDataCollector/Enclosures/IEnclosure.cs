namespace Loco.Collection.Enclosures
{
    interface IEnclosure
    {
        bool IsLogging { get; set; }
        BeamState State { get; set; }
        void UpdateBeamStates(string binaryStates);
    }
}
