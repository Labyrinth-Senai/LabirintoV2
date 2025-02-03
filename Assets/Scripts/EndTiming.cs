using TMPro;
using UnityEngine;

public class EndTiming : MonoBehaviour
{
    public Timer Timer;
    public TextMeshProUGUI timerText;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        if (Timer == null) // Se Timer não foi atribuído manualmente
        {

            
            int minutes = Mathf.FloorToInt(Timer.timer / 60);
            int seconds = Mathf.FloorToInt(Timer.timer % 60);


            timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}

