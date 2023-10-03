namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TurnNumberSequence
    {
        private int _turnNumber = 0;

        public int GetNextTurnNumber()
        {
            return _turnNumber++;
        }
    }
}
