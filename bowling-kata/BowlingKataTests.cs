namespace bowling_kata;

using FluentAssertions;
using Xunit;

public class BowlingKataTests
{
    [Theory]
    [InlineData("00 00 00 00 00 00 00 00 00 00", 0.0)]
    [InlineData("61 00 00 00 00 00 00 00 00 00", 7.0)]
    [InlineData("61 81 00 00 00 00 00 00 00 00", 16.0)]
    public void Test(string scoreSheet, int expectedScore)
    {
        var bowlingGame = new BowlingGame(scoreSheet);

        var score = bowlingGame.Score();

         score.Should().Be(expectedScore);
    }
    
}