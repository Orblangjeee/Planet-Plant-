using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndingFloor : MonoBehaviour
{
    public string aloneEnding;
    public string son1Ending;
    public string son2Ending;
    public string sonsEnding;
    public Player player;

    void OnTriggerEnter2D(Collider2D Door)
    {
        if(Door.gameObject.layer == 10)
        {
            //혼자 엔딩

            SceneManager.LoadScene(aloneEnding);
        }
        else if(Door.gameObject.layer == 15)
        {
            //아이 1 엔딩
            SceneManager.LoadScene(son1Ending);
        }
        else if(Door.gameObject.layer == 16)
        {
            //아이 2 엔딩 
            SceneManager.LoadScene(son2Ending);
        }
        else if(Door.gameObject.layer == 17)
        {
            //아이 둘 엔딩
            SceneManager.LoadScene(sonsEnding);
        }
    }
}
