using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BloodScreen : MonoBehaviour
{
    public Animator screen;
    public Image bloodscreen;

    void start()
    {
        screen = GetComponent<Animator>();
    }
    void Update()
    {
        if(GM.Instance.screen == true)
        {
            
            screen.SetTrigger("bloody");
            Debug.Log("나와");
           
            //if (screen.GetCurrentAnimatorStateInfo(0).IsName("bloody") && screen.GetCurrentAnimatorStateInfo(0).normalizedTime >= 1.0f)
            //{
            //    bloodscreen.SetActive(false);
            //}
            
        }
        else
        {
            bloodscreen.enabled = false;
        }
    }
}
