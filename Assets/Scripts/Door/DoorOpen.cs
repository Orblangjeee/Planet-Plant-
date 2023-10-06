using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorOpen : MonoBehaviour
{
   
    void OnTriggerEnter2D(Collider2D Door)
    {
        if (Door.gameObject.tag == "Player")
        {
            {
                AudioManager.instance.PlaySound("Door");

                Door.gameObject.GetComponent<Player>().hungry = Door.gameObject.GetComponent<Player>().hungry - 1;
                if (Door.gameObject.GetComponent<Player>().hungry <= 0)
                {
                    Door.gameObject.GetComponent<Player>().hungry = 0;
                    Door.gameObject.GetComponent<Player>().hp = Door.gameObject.GetComponent<Player>().hp - 2;
                }

            }
        }
    }
}
