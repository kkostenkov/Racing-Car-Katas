namespace TDDMicroExercises.TurnTicketDispenser
{
    public class TicketDispenser
    {
        private readonly TurnNumberSequence sequenceDispenser;

        public TicketDispenser(TurnNumberSequence sequenceDispenser)
        {
            this.sequenceDispenser = sequenceDispenser;
        }
        
        public TurnTicket GetTurnTicket()
        {
            int newTurnNumber = sequenceDispenser.GetNextTurnNumber();
            TurnTicket newTurnTicket = new TurnTicket(newTurnNumber);

            return newTurnTicket;
        }
    }
}
