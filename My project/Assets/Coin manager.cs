using UnityEngine;

public class CoinManager : MonoBehaviour
{
    public GameObject prefab;
    public GameObject cash;

    void Start()
    {
        cash = GameObject.FindGameObjectWithTag("Coin");
        LoadPlayerScore(); 
    }

    void Update()
    {
        if (cash == null)
        {
            SpawnCoin();
            SavePlayerScore(); 
        }
    }

    private void SpawnCoin()
    {
        float x = Random.Range(-10f, 10f);
        float z = Random.Range(-10f, 10f);
        Vector3 position = new Vector3(x, 1.5f, z);

        cash = Instantiate(prefab);
        cash.transform.position = position;
    }

    
    private void SavePlayerScore()
    {
        int currentScore = PlayerPrefs.GetInt("CurrentScore", 0);
        currentScore++; 

        PlayerPrefs.SetInt("CurrentScore", currentScore);
        PlayerPrefs.Save();

        Debug.Log("Spelarens poäng sparad!");
    }


    private void LoadPlayerScore()
    {
        int currentScore = PlayerPrefs.GetInt("CurrentScore", 0);


        Debug.Log("Spelarens poäng laddat! Nuvarande poäng: " + currentScore);
    }
}
