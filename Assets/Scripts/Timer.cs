using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float remainingTime;
    public float timer;
    // Update is called once per frame
    void Update()
    {
        /*if (remainingTime > 0)
        {
            remainingTime -= Time.deltaTime;
        }else if (remainingTime < 1)
        { timerText.color = Color.red;
            remainingTime = 0;
           
            //load scene GameOver();
        }*/ //Decremento do tempo

        timer += Time.deltaTime;

        int minutes = Mathf.FloorToInt(timer / 60);
        int seconds = Mathf.FloorToInt(timer % 60);

        timerText.text = string.Format("{0:00}:{1:00}", minutes, seconds);
    }
}
