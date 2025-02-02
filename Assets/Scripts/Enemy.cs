using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;

public class Enemy : MonoBehaviour
{
   
   public float distance;
   public Transform player;
   public NavMeshAgent nav;
   public Animator Anim;
   

   private bool isWalking;

    void Start()
    {
       Anim = GetComponent<Animator>();
    }

    void Update()
    {
        distance = Vector3.Distance(this.transform.position, player.position);

        if (distance < 10) 
        {
            nav.destination = player.position;
        }

        if(nav.velocity.magnitude > 1)
        {
            isWalking = true;
        }
        else
        {
            isWalking = false;
        }

        UpdateAnimator();
    }

    void UpdateAnimator()
    {
        Anim.SetBool("isWalking", isWalking);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.CompareTag("Player"))
        {
            GameOver();
        }
    }

    public void GameOver()
    {
        SceneManager.LoadScene(1);
    }
}
