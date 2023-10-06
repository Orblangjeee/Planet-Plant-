using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPortal : MonoBehaviour
{
    public Button UP;
    public Button Down;
    public float yGap;
    public Rigidbody2D playerbody;
    CapsuleCollider2D myColision;
    public GameObject arrow;


    void Start()
    {
        UP.onClick.AddListener(UpPortal);
        Down.onClick.AddListener(DownPortal);
    }

 
    void DownPortal()
    {
        GM.Instance.MoveHungry();
        float nextPosY = playerbody.transform.position.y - yGap;
        playerbody.transform.position = new Vector2(0, nextPosY);
        arrow.SetActive(false);
    }

    void UpPortal()
    {
        GM.Instance.MoveHungry();
        float nextPosY = playerbody.transform.position.y + yGap;
        playerbody.transform.position = new Vector2(0, nextPosY);
        arrow.SetActive(false);
    }

   
  
}
