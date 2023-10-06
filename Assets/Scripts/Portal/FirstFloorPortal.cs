using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FirstFloorPortal : MonoBehaviour
{
    public Button Up;
    public float yGap;
    public Rigidbody2D playerbody;
    CapsuleCollider2D myColision;
    public GameObject rooftoparrow;

    void Start()
    {
        Up.onClick.AddListener(UpPortal);
    }

    public Player player;

    void UpPortal()
    {
        float nextPosY = playerbody.transform.position.y + yGap;
        playerbody.transform.position = new Vector2(0, nextPosY);

        GM.Instance.MoveHungry();
        rooftoparrow.SetActive(false);
    }
}