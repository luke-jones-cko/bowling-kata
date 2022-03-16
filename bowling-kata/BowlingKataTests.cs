namespace bowling_kata;

using FluentAssertions;
using Xunit;

public class BowlingKataTests
{
    [Theory]
    [InlineData("00 00 00 00 00 00 00 00 00 00", 0)]
    public void Test1(string scoreSheet, int expectedScore)
    {
        //var bowlingGame = new BowlingGame(scoreSheet);

        //var score = bowlingGame.Score();

        // score.Should().Be(expectedScore);
    }
}