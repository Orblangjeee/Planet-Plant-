using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public Rigidbody2D Playerbody;
    CapsuleCollider2D myColision;
    public GameObject arrow;

    void OnTriggerStay2D(Collider2D Potal)
    {
        if (Potal.gameObject.tag == "Player")
        {
            arrow.SetActive(true);
        }
    }

    private void OnTriggerExit2D(Collider2D Potal)
    {
        if(Potal.gameObject.tag == "Player")
        {
            arrow.SetActive(false);
        }
        
    }
}
