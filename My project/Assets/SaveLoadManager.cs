using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public static class SaveLoadManager
{
    public static void SavePlayerData(PlayerData playerData)
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string filePath = Application.persistentDataPath + "/playerData.dat";
        FileStream stream = new FileStream(filePath, FileMode.Create);

        formatter.Serialize(stream, playerData);
        stream.Close();
    }

    public static PlayerData LoadPlayerData()
    {
        string filePath = Application.persistentDataPath + "/playerData.dat";
        if (filePath.Exists(filePath))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(filePath, FileMode.Open);

            LoadPlayerData playerData = formatter.Deserialize(stream) as playerData;
            stream.Close();

            return playerData;
        }
        else
        {
            Debug.LogWarning("Sparad fil inte hittad i " + filePath);
            return null;
        }
    }
}