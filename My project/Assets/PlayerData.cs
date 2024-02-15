using System;

[Serializable]
public class PlayerData
{
    public int currentPoints;

    public PlayerData(int level, int score)
    {
        currentPoints = score;
    }
}