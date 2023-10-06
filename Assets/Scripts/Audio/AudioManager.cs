using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class AudioManager : MonoBehaviour
{
    
    public AudioClip audioBlink;
    public AudioClip audioDoor;
    public AudioClip audioSons;
    public AudioClip finditem;
    public AudioClip bag;
    public AudioClip closebag;
    public AudioClip floor;

    public AudioClip audiomonsterA;
    public AudioClip audiomonsterB;
    public AudioClip audiomonsterA_Hit;
    public AudioClip audiomonsterB_Hit;
    public AudioClip audiomonsterA_Hitted;
    public AudioClip audiomonsterB_Hitted;
    public AudioClip audiomonsterdie;
    

    public AudioSource audioSource;
    
    public static AudioManager instance;

  
    
    void Awake()
    {
        if (AudioManager.instance == null) 
        { AudioManager.instance = this; }

    this.audioSource = GetComponent<AudioSource>();       
    }
    public void PlaySound(string action)
    {
        switch (action)
        {
            
            case "Blink":
                audioSource.clip = audioBlink;
                break;

            case "Door":
                audioSource.clip = audioDoor;
                break;

            case "Sonsad":
                audioSource.clip = audioSons;
                break;

            case "ItemFind":
                audioSource.clip = finditem;
                break;
            case "Bag":
                audioSource.clip = bag;
                break;
            case "CloseBag":
                audioSource.clip = closebag;
                break;
            case "Floor":
                audioSource.clip = floor;
                break;


        }
        audioSource.Play();
    }

    public void MonsterSound(string action)
    {
        switch (action)
        {
            case "MonsterA_met":
                audioSource.clip = audiomonsterA;
                break;

            case "MonsterB_met":
                audioSource.clip = audiomonsterB;
                break;
            case "audiomonsterA_Hit":
                audioSource.clip = audiomonsterA_Hit;
                break;
            case "audiomonsterB_Hit":
                audioSource.clip = audiomonsterB_Hit;
                break;
            case "audiomonsterA_Hitted":
                audioSource.clip = audiomonsterA_Hitted;
                break;
            case "audiomonsterB_Hitted":
                audioSource.clip = audiomonsterB_Hitted;
                break;
            case "MonsterDie":
                audioSource.clip = audiomonsterdie;
                break;
        }
        audioSource.Play();
    }

    public void StopSound()
    {
        audioSource.Stop();
    }
}
