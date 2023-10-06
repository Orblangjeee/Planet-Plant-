using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Playerstat : MonoBehaviour
{
    public Player player;
    public Slider hpSlider1, hpSlider2;
    public Slider hgSlider1, hgSlider2;
    public TextMeshProUGUI hptext1, hptext2;
    public TextMeshProUGUI hgtext1, hgtext2;
    public TextMeshProUGUI strtext, spdtext, acctext, luktext;

    
     void Update()
    
    {
        hpSlider1.maxValue = player.maxHp;
        hpSlider2.maxValue = player.maxHp;
        hgSlider1.maxValue = player.maxHungry;
        hgSlider2.maxValue = player.maxHungry;
        hpSlider1.value = player.hp;
        hpSlider2.value = player.hp;
        hgSlider1.value = player.hungry;
        hgSlider2.value = player.hungry;

        hptext1.text = player.hp + "/100";
        hptext2.text = player.hp + "/100";
        hgtext1.text = player.hungry + "/50";
        hgtext2.text = player.hungry + "/50";

        

        strtext.text = player.str + "";
        spdtext.text = player.spd + "";
        acctext.text = player.acc + "";
        luktext.text = player.luk + "";
    }


}
