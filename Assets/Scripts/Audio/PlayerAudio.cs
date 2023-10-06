using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudio : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioClip audiowalking_R;
    public AudioClip audiowalking_L;
    public AudioClip audioAttack1;
    public AudioClip audioAttack2;
    public AudioClip audioAttack3;
    public AudioClip audioHitted;
 

    public AudioSource audioSource;

    public static PlayerAudio instance;



    void Awake()
    {
        if (PlayerAudio.instance == null)
        { PlayerAudio.instance = this; }

        this.audioSource = GetComponent<AudioSource>();
    }
    public void PlaySound(string action)
    {
        switch (action)
        {
            case "Walk_R":
                audioSource.clip = audiowalking_R;
                Debug.Log("music");
                break;

            case "Walk_L":
                audioSource.clip = audiowalking_L;
                break;

            case "attack_1":
                audioSource.clip = audioAttack1;
                break;
            case "attack_2":
                audioSource.clip = audioAttack2;
                break;
            case "attack_3":
                audioSource.clip = audioAttack3;
                break;
            case "Hitted":
                audioSource.clip = audioHitted;
                break;
           

        }
        audioSource.Play();
    }
}
