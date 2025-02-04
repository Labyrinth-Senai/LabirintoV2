using TMPro;
using UnityEngine;

public class EndTiming : MonoBehaviour
{
    public Timer Timer;
    public TextMeshProUGUI timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Pega o tempo armazenado
        float storedTime = PlayerPrefs.GetFloat("StoredTime", 0f);

        int minutes = Mathf.FloorToInt(storedTime / 60);
        int seconds = Mathf.FloorToInt(storedTime % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject); // Garante que o objeto persista entre as cenas
    }
}

