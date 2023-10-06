using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Choice : MonoBehaviour
{
    public Button Atk1;
    public Button Atk2;
    public Button Atk3;
    // Start is called before the first frame update
    void Start()
    {
        Atk1.onClick.AddListener(GM.Instance.PlayerAtk1);
        Atk2.onClick.AddListener(GM.Instance.PlayerAtk2);
        Atk3.onClick.AddListener(GM.Instance.PlayerAtk3);
    }

    // Update is called once per frame
    void Update()
    {
        
    }





}
