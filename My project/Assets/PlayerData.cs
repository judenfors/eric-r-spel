using System;

[Serializable]
public class PlayerData
{
    public int currentScore;

    public PlayerData(int score)
    {
        currentScore = score;
    }
}