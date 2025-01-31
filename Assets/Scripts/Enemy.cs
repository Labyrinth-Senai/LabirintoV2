using UnityEngine;
using UnityEngine.AI;

public class Enemy : MonoBehaviour
{
   
   public float distance;
   public Transform player;
   public NavMeshAgent nav;
   public Animator Anim;

   public GameObject Player;
   public Vector3 teleporte;
   

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
            /*if(distance > 5)
            {
                Anim.SetInteger("Mode", 0);
            }
            else 
            {
                Anim.SetInteger("Mode", 2);
            }*/
        }

        UpdateAnimator();
    }

    void UpdateAnimator()
    {
        Anim.SetBool("isWalking", isWalking);
    }

    private void OnTriggerStay(Collider collision)
    {
        Player.transform.position = teleporte;
    }
}
