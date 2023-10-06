using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EndingUI : MonoBehaviour
{
    public Image endingimage;
    public void EndingEnd()
    {

        endingimage.gameObject.SetActive(false);
        
    }


}
