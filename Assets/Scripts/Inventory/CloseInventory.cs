using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CloseInventory : MonoBehaviour
{
    public GameObject ItemInventory;
    public Button btnItem;
    public GameObject MainGUI;


    void Start()
    {
        btnItem.onClick.AddListener(CloseItem);
    }

    void CloseItem()
    {
        AudioManager.instance.PlaySound("CloseBag");
        ItemInventory.SetActive(false);
        MainGUI.SetActive(true);
      
    }

}
