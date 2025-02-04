using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI timerText;
    public float remainingTime;
    public float timer;

    void Start()
    {
        // Quando a cena começa, recupera o timer salvo (caso exista)
        timer = PlayerPrefs.GetFloat("StoredTime", 0f);
    }

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

        // Salva o timer sempre que ele for alterado
        PlayerPrefs.SetFloat("StoredTime", timer);
    }

    void OnEnable()
    {
        SceneManager.sceneLoaded += OnSceneLoaded; // Registra o evento de cena carregada
    }

    void OnDisable()
    {
        SceneManager.sceneLoaded -= OnSceneLoaded; // Remove o evento quando o objeto for destruído
    }

    // Método chamado quando a cena for carregada
    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        if (scene.name == "Tample Run") // Nome da sua primeira cena
        {
            // Reseta o timer
            timer = 0f;
            PlayerPrefs.SetFloat("StoredTime", timer); // Salva o valor resetado
        }
    }
}
