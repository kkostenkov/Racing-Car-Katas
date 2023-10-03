using NUnit.Framework;
using NSubstitute;
using TDDMicroExercises.TurnTicketDispenser;

[TestFixture]
public class TicketDispenserTests
{
    [Test]
    public void GetTurnTicket_ReturnsNewTurnTicket()
    {
        // Arrange
        int nextTurnNumber = 42; // You can set the expected turn number

        // Create a substitute for TurnNumberSequence
        var sequenceDispenser = Substitute.For<TurnNumberSequence>();
        sequenceDispenser.GetNextTurnNumber().Returns(nextTurnNumber);

        // Create an instance of TicketDispenser with the substitute
        var ticketDispenser = new TicketDispenser(sequenceDispenser);

        // Act
        var result = ticketDispenser.GetTurnTicket();

        // Assert
        Assert.IsNotNull(result); // Ensure that a TurnTicket object is returned
        Assert.AreEqual(nextTurnNumber, result.TurnNumber); // Verify the turn number
    }
}