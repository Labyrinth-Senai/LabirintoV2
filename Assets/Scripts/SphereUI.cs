using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class SphereUI : MonoBehaviour
{
    public Transform jogador; //Colocar o script do jogador aqui
    public float velocidadeEsfera = 5f;
    public Rigidbody rb;
    public float distance;
    public NavMeshAgent nav;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        distance = Vector3.Distance(this.transform.position, jogador.position);

        if (distance < 50)
        {
            nav.destination = jogador.position;
            rb.useGravity = true;
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameOver();
        }
    }
}
