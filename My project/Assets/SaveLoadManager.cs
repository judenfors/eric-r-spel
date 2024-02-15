using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadManager
{
    public static void SavePlayerData(PlayerData playerData)
    {
        string filePath = Application.persistentDataPath + "/playerData.dat";
        BinaryFormatter formatter = new BinaryFormatter();
        
        using (FileStream stream = new FileStream(filePath, FileMode.Create))
        {
            formatter.Serialize(stream, playerData);
        }

        Debug.Log("Spelar data sparad!");
    }

    public static int GetPlayerScore()
    {
        return PlayerPrefs.GetInt("CurrentScore", 0);
    }

    public static PlayerData LoadPlayerData()
    {
        string filePath = Application.persistentDataPath + "/playerData.dat";

        if (File.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();

            using (FileStream stream = new FileStream(filePath, FileMode.Open))
            {
                PlayerData playerData = formatter.Deserialize(stream) as PlayerData;
                Debug.Log("Spelar data laddad!");
                return playerData;
            }
        }
        else
        {
            Debug.LogWarning("Sparad fil hittades inte: " + filePath);
            return null;
        }
    }
}
