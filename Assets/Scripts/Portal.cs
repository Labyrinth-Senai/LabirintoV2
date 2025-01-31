using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Player;
    public Vector3 teleporte;
 
    private void OnTriggerStay(Collider collision)
    {
        Player.transform.position = teleporte;
    }
}
