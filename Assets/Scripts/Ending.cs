using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Ending : MonoBehaviour
{
    public Image endingimage;
    public Image endingSons;
    public Player player;
    public Inventory inventory;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {

            
            if(player.gameObject.layer == 10)
            {
                endingimage.gameObject.SetActive(true);
                inventory.alone.SetActive(false);
                inventory.son1.SetActive(true);
                player.gameObject.layer = 15;
                Destroy(gameObject);
            }
            if(player.gameObject.layer == 16)
            {
                endingSons.gameObject.SetActive(true);
                inventory.son1.SetActive(false);
                inventory.son2.SetActive(false);
                inventory.son3.SetActive(true);
                player.gameObject.layer = 17;
                Destroy(gameObject);
            }
        }
        
    }
}
