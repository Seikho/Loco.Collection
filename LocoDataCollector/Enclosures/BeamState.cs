namespace LocoDataCollector.Enclosures
{
    class BeamState
    {
        private int[] _states;
        private readonly string _state;

        public BeamState(string state)
        {
            _state = state;
            PopulateStates();
        }

        public int this[int number]
        {
            get { return _states[number]; }
        }

        void PopulateStates()
        {
            _states = new int[8];
            for (var c = 0; c <= 8; c++)
            {
                try
                {
                    _states[c] = int.Parse(_state.Substring(c, 1));
                }
                catch
                {
                    _states[c] = 0;
                }
            }
        }
    }
}
