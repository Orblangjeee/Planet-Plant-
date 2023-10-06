using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Player : MonoBehaviour
{

    public Player player;
    public Slider hpSlider1, hpSlider2;
    public Slider hgSlider1, hgSlider2;
    public TextMeshProUGUI hptext1, hptext2;
    public TextMeshProUGUI hgtext1, hgtext2;
    public TextMeshProUGUI strtext, spdtext, acctext, luktext;

    public Animator anim;

    public float hp;
    public float maxHp;
    public float str;
    public float spd;
    public float acc;
    public float luk;
    public float hungry;
    public float maxHungry;
    public float currentEXP;
    public bool isAttack;

 
    public bool isUp;

    public float x;
    public float y;

    void Start()
    {
        anim = GetComponent<Animator>();
        hp = maxHp;
        hungry = maxHungry;
    }

    void Update()
    {
        if (currentEXP == 0)
        {

        }
        else
        {
            int j = 2;
            if (currentEXP % j == 0)
            {
                for (int i=0; i<=1; i++)
                {
                    GM.Instance.LevelUP();
                }
                isUp = true;
            }

            if(currentEXP % j == 1)
            {
                isUp = false;
            }
        }

        x = GetComponent<Rigidbody2D>().transform.position.x;
        y = GetComponent<Rigidbody2D>().transform.position.y;

        if (hp > 100)
        {
            hp = 100;
        }
        if (hungry > 50)
        {
            hungry = 50;
        }

        hpSlider1.maxValue = maxHp;
        hpSlider2.maxValue = maxHp;
        hgSlider1.maxValue = maxHungry;
        hgSlider2.maxValue = maxHungry;
        hpSlider1.value = hp;
        hpSlider2.value = hp;
        hgSlider1.value = hungry;
        hgSlider2.value = hungry;

        hptext1.text = hp + "/100";
        hptext2.text = hp + "/100";
        hgtext1.text = hungry + "/50";
        hgtext2.text = hungry + "/50";



        strtext.text = str + "";
        spdtext.text = spd + "";
        acctext.text = acc + "";
        luktext.text = luk + "";
    }

    void FixedUpdate()
    {
        GM.Instance.Gameover();

        if (GM.Instance != null)
        {
            if (GM.Instance.playState != GM.State.Play) return;
        }
        if (Input.GetKeyDown(KeyCode.Escape))
        {

            GM.Instance.pauseGUIOpen();

        }
    }

    public string bgmName = "";
    public GameObject camobject;
    private void OnTriggerStay2D(Collider2D collision)
        {
            string tag = collision.gameObject.tag;
            if (tag == "Enemy")
            {
                
                anim.SetBool("Fightmode", true);
                camobject.GetComponent<PlayMusicOperator>().PlayBGM(bgmName);
            
        }

        if (tag == "Fade")
        {
            anim.SetBool("FadeOut", true);
        }
    }

        private void OnTriggerExit2D(Collider2D collision)
        {
            string tag = collision.gameObject.tag;
            if (tag == "Enemy")
            {
                anim.SetBool("Fightmode", false);
            camobject.GetComponent<PlayMusicOperator>().PlayBGM("MainTheme");
        }
        }

    public GameObject hitEff;
    public GameObject Crit;
    public GameObject Critical;

    public void HitCheck()
    {
       
      if (GM.Instance.PisHit == true)
        {
            
           hitEff.SetActive(true);
           
         
            if (GM.Instance.Crit == true)
            {
                Crit.SetActive(true);
            }

            if (GM.Instance.Critical == true)
            {
                Critical.SetActive(true);
            }
        }


    }
    
    public void HitedEnd()
    {
        GM.Instance.PisHit = false;
         
            hitEff.SetActive(false);
        Crit.SetActive(false);
        Critical.SetActive(false);

    }

    //사운드

    public void Attack1()
    {
        PlayerAudio.instance.PlaySound("attack_1");
    }

    public void Attack2()
    {
        PlayerAudio.instance.PlaySound("attack_2");
    }

    public void Attack3()
    {
        PlayerAudio.instance.PlaySound("attack_3");
    }

    public void Hitted()
    {
        PlayerAudio.instance.PlaySound("Hitted");
    }

}



