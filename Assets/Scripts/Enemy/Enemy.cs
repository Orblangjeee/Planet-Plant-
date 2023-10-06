using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Enemy : MonoBehaviour
{
    public float hp;
    public float maxHp;
    public float str;
    public float spd;
    public float acc;
    public float luk;
    public float EXP;
    public bool isAttack;
    public Camera newcamera;
    //public TextMeshProUGUI MonsterHP;
    //public Slider HPslider;
    public Image Portrait;

    public Animator enim;
   
    public float x;
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        x = GetComponent<Enemy>().transform.position.x;
        y = GetComponent<Enemy>().transform.position.y;
        enim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
          if (GetComponent<Enemy>().hp <= 0)
        {
            GetComponent<Enemy>().hp = 0;

            Invoke("Boxx", 2);
           
            
            
       }
        GM.Instance.Enemytype();
        //HPslider.maxValue = GetComponent<Enemy>().maxHp;
        //HPslider.value = GetComponent<Enemy>().hp;
        //MonsterHP.text = GetComponent<Enemy>().hp + "/" + GetComponent<Enemy>().maxHp;
    }

    public GameObject SetCamera;
    public string soundName;
    void Boxx()
    {
        gameObject.GetComponent<BoxCollider2D>().enabled = false;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        string tag = collision.gameObject.tag;
        if (tag == "Player")
        {
            enim.SetBool("Idle", true);
            AudioManager.instance.MonsterSound(soundName);
            Portrait.gameObject.SetActive(true);
            //HPslider.gameObject.SetActive(true);
            
            GM.Instance.enemy = GetComponent<Enemy>();
            GM.Instance.Enemybar();
            GM.Instance.Enemytype();
            GM.Instance.firstAtk();
            GM.Instance.EnemyAtk();


            SetCamera.SetActive(true);
            
        }
      
       
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
         Portrait.gameObject.SetActive(false);
        // HPslider.gameObject.SetActive(false);
        GM.Instance.Enemybarx();
        SetCamera.SetActive(false);
    }


    public GameObject hitEff;
    
    public void HitCheck()
    {
        //히트 됐다 됐다 안됐다.
        if (GM.Instance.EisHit == true)
        {
            hitEff.SetActive(true);
        }
        
        
    }

    public void HitEnd()
    {
        GM.Instance.EisHit = false;
        hitEff.SetActive(false);
    }


    //사운드 

    public string hitsound;
    public string hittedsound;
    
    public void HitSound()
    {
        AudioManager.instance.MonsterSound(hitsound);
    }

    public void HittedSound()
    {
        AudioManager.instance.MonsterSound(hittedsound);
    }

    public void DieSound()
    {
        AudioManager.instance.MonsterSound("MonsterDie");
    }
}
