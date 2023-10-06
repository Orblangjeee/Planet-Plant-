using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenDoor : MonoBehaviour
{
    public BoxCollider2D doorrigd;
    // Start is called before the first frame update

    void OnCollisionEnter2D(Collision2D Door)
    {
        if (Door.gameObject.tag == "Player")
        {
            if (ItemDataReader.Instance.getItemValue[20] > 0)
            {
                doorrigd.isTrigger = true;
                KeyDoor(Door.transform.position);

                Invoke("CloseDoor", 1);
            }
        }
    }

    void OnTriggerEnter2D(Collider2D Door)
    {
        KeyDoor(Door.transform.position);

        Invoke("CloseDoor", 1);
    }

    void KeyDoor(Vector2 targetPos)
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