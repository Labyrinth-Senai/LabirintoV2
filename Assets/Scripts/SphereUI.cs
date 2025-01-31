using UnityEngine;
using UnityEngine.SceneManagement;

public class SphereUI : MonoBehaviour
{
    public Transform jogador; //Colocar o script do jogador aqui
    public float velocidadeEsfera = 5f;
    public float distanciaParaAPerda = 0.5f;
    
    // Update is called once per frame
    void Update()
    {
        if(jogador != null)
        {
            Vector3 direcao = (jogador.position - transform.position).normalized;
            transform.position += direcao * velocidadeEsfera * Time.deltaTime;
        }

        //Verificando se a esfera chegou perto o suficiente do jogador 
        if(Vector3.Distance(transform.position, jogador.position) <= distanciaParaAPerda)
        {
            //perdeu o jogo
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }
}
