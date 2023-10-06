using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpenInventory : MonoBehaviour
{
    public GameObject Inventory;
    public Button btnItem;
  
    void Start()
    {
        btnItem.onClick.AddListener(LookItem);   
    }

    void LookItem()
    {

        AudioManager.instance.PlaySound("Bag");
        Inventory.SetActive(true);
        

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
