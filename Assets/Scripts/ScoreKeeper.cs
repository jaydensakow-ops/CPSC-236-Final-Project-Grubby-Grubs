using UnityEngine;

public static class ScoreKeeper
{
    private static int leftScore = 0;
    private static int rightScore = 0;

    public static void AddPoint(bool isLeftPlayer)
    {
        if (isLeftPlayer) leftScore++;
        else rightScore++;
    }

    public static void ResetScore()
    {
        leftScore = 0;
        rightScore = 0;
    }

    public static int GetLeftScore() => leftScore;
    public static int GetRightScore() => rightScore;
}