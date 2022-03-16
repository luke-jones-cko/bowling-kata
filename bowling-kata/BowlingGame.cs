using System;

namespace bowling_kata;

public class BowlingGame
{
    private string Scoresheet;

    public BowlingGame(string score)
    {
        Scoresheet = score;
    }

    public double Score()
    {
        var scores = Scoresheet.Split(" ");
        var accumulatedScore = 0.0;
        var x = 1;
        var previousFrame = "";
        
        foreach (var score in scores)
        {
            foreach (var character in score)
            {
                
                //spare on previous round
                if (previousFrame.Contains("/"))
                {
                    accumulatedScore += Char.GetNumericValue(character)*2;
                    continue;
                }
                

                accumulatedScore += Char.GetNumericValue(character);
            }

            previousFrame = score;
        }

        return accumulatedScore;
    }
}