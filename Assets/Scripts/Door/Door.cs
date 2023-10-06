using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D Door)
    {
        if (Door.gameObject.tag == "Player")
        {
            OpenDoor(Door.transform.position);

            Invoke("CloseDoor", 1);
        }
    }

    void OpenDoor(Vector2 targetPos)
    {
        float dirc = transform.position.x - targetPos.x;
        if (dirc > 0)
        {
            transform.localScale = new Vector2(1f, 1f);
        }

        else
        {
            transform.localScale = new Vector2(-0.7f, 1f);
        }
        
    }

    void CloseDoor()
    {
        transform.localScale = new Vector2(0.3f, 1f);
    }

    

}
