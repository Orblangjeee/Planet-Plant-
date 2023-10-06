using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RooftopPortal : MonoBehaviour
{
    public Button Down;
    public float yGap;
    public Rigidbody2D playerbody;
    CapsuleCollider2D myColision;
    public GameObject rooftoparrow;

    void Start()
    {
        Down.onClick.AddListener(DownPortal);
    }

    public Player player;

    void DownPortal()
    {
        float nextPosY = playerbody.transform.position.y - yGap;
        playerbody.transform.position = new Vector2(0, nextPosY);

        GM.Instance.MoveHungry();
        rooftoparrow.SetActive(false);
    }

}
