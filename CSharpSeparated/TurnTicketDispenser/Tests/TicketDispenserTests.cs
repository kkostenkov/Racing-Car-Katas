using System.Reflection;
using NUnit.Framework;
using TDDMicroExercises.TurnTicketDispenser;

namespace Tests;

public class TicketDispenserTests
{
    [TestCase(1, ExpectedResult = 0)]
    [TestCase(2, ExpectedResult = 1)]
    [TestCase(100, ExpectedResult = 99)]
    public int Should_DispenseTicketNumber_When_Created(int ticketOrdinal)
    {
        var ticketDispenser = new TicketDispenser();
        TurnTicket ticket = null;
        for (int i = 0; i < ticketOrdinal; i++)
        {
            ticket = ticketDispenser.GetTurnTicket();
        }

        return ticket.TurnNumber;
    }

    [TearDown]
    public void TearDown()
    {
        typeof(TurnNumberSequence).GetField("_turnNumber", BindingFlags.Static | BindingFlags.NonPublic).SetValue(null, 0);
    }
}