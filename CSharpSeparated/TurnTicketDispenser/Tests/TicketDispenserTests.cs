using NUnit.Framework;
using TDDMicroExercises.TurnTicketDispenser;

namespace Tests;

public class TicketDispenserTests
{
    private TurnNumberSequence sequence;

    [SetUp]
    public void SetUp()
    {
        sequence = new TurnNumberSequence();
    }
    
    [TestCase(1, ExpectedResult = 0)]
    [TestCase(2, ExpectedResult = 1)]
    [TestCase(100, ExpectedResult = 99)]
    public int Should_DispenseTicketNumber_When_Created(int ticketOrdinal)
    {
        var ticketDispenser = new TicketDispenser(sequence);
        TurnTicket ticket = null;
        for (int i = 0; i < ticketOrdinal; i++) {
            ticket = ticketDispenser.GetTurnTicket();
        }

        return ticket.TurnNumber;
    }

    [Test]
    public void Should_DispenseDifferentTicketNumbers_When_MultipleDispensersAreUsed()
    {
        var ticketDispenser = new TicketDispenser(sequence);
        var ticketDispenser1 = new TicketDispenser(sequence);
        var ticketDispenser2 = new TicketDispenser(sequence);

        var number = ticketDispenser.GetTurnTicket().TurnNumber;
        var number1 = ticketDispenser1.GetTurnTicket().TurnNumber;
        var number2 = ticketDispenser2.GetTurnTicket().TurnNumber;
        
        Assert.AreNotEqual(number, number1);
        Assert.AreNotEqual(number1, number2);
        Assert.AreNotEqual(number2, number);
    }
}

