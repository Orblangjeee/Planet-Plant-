using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerMove : MonoBehaviour
{
    static PlayerMove instance = null;
    public static PlayerMove Instance
    {
        get
        {
            if (null == instance)
            {
                return null;
            }
            return instance;
        }
    }
    public Rigidbody2D Playerbody;
    CapsuleCollider2D myColision;
    public float playerSpeed;

    public Animator anim;
    float horizontalMove;
    float verticalMove;
    

    public bool MoveSystem;
    public bool isLeft;
    public bool isRight;
    public bool isUp;
    public bool isDown;
    public float xValue;
    public float yValue;
    public float xPow;
    public float yPow;

    public bool isMoving;
 

    Player player;

   
    void Awake()
    {
        instance = null;
       
    }

    // Update is called once per frame
    void Start()
    {
        Playerbody = GetComponent<Rigidbody2D>();
        myColision = GetComponent<CapsuleCollider2D>();
        anim = GetComponent<Animator>();
        
        
        
    }

     void Update()
    {
        
        if (GM.Instance != null)
        {
            if (GM.Instance.playState != GM.State.Play) return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            GM.Instance.pauseGUIOpen();
        }

        horizontalMove = Input.GetAxisRaw("Horizontal");
        verticalMove = Input.GetAxisRaw("Vertical");

        
        

    }
     void FixedUpdate()
    {
            HeroMove();
        Animationupdate();
    }

    
    
    
    public void HeroMove()
    {
        
            isLeft = (Input.GetKey(KeyCode.A));
            isRight = (Input.GetKey(KeyCode.D));
            isUp = (Input.GetKey(KeyCode.W));
            isDown = (Input.GetKey(KeyCode.S));
            xPow = 0;
            yPow = 0;
            if (isLeft)
            {
                xPow = -2 * xValue;
                transform.localEulerAngles = new Vector3(0, 0, 0); //회전
            
        }
            else if (isRight)
            {
                xPow = 2 * xValue;
                transform.localEulerAngles = new Vector3(0, 180, 0); //회전
            
        }
            else if (isUp)
            {
                yPow = 2 * yValue;
           
        }
            else if (isDown)
            {
                yPow = -2 * yValue;
            
        }


            Playerbody.velocity = new Vector2(xPow, yPow);

    
       
    }


    void Animationupdate() //애니메이션
    {
        if (horizontalMove == 0 && verticalMove == 0)
        {
            anim.SetBool("Walking", false);
           
        }
        else
        {
            anim.SetBool("Walking", true);
        

        }


    }

 
    

    private void OnTriggerEnter2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Enemy")
        {
            gameObject.GetComponent<PlayerMove>().enabled = false;
            xValue = 0;
            yValue = 0;
            xPow = 0;
            yPow = 0;
            Playerbody.velocity = new Vector2(xPow, yPow);
            isRight = false;
            isLeft = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        string tag = collision.gameObject.tag;
        if (tag == "Enemy")
        {
            gameObject.GetComponent<PlayerMove>().enabled = true;
            xValue = 2.5f;
            yValue = 2.5f;
        }
    }
}
