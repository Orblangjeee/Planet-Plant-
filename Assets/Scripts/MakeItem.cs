using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MakeItem : MonoBehaviour
{
    public GameObject itemmaker;

    public Player player;
    public void makeitem1()
    {
        if (ItemDataReader.Instance.getItemValue[8] > 0)
        {
            if(ItemDataReader.Instance.getItemValue[4] > 0)
            {
                ItemDataReader.Instance.getItemValue[8]--;
                ItemDataReader.Instance.getItemValue[4]--;
                ItemDataReader.Instance.getItemValue[9]++;
                player.currentEXP++;
            }
        }
    }

    public void makeitem2()
    {
        if (ItemDataReader.Instance.getItemValue[0] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[7] > 0)
            {
                ItemDataReader.Instance.getItemValue[0]--;
                ItemDataReader.Instance.getItemValue[7]--;
                ItemDataReader.Instance.getItemValue[10]++;
                player.currentEXP++;
            }
        }
        else if (ItemDataReader.Instance.getItemValue[1] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[7] > 0)
            {
                ItemDataReader.Instance.getItemValue[1]--;
                ItemDataReader.Instance.getItemValue[7]--;
                ItemDataReader.Instance.getItemValue[10]++;
                player.currentEXP++;
            }
        }

    }

    public void makeitem3()
    {
        if (ItemDataReader.Instance.getItemValue[17] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[7] > 0)
            {
                ItemDataReader.Instance.getItemValue[17]--;
                ItemDataReader.Instance.getItemValue[7]--;
                ItemDataReader.Instance.getItemValue[12]++;
                player.currentEXP++;
            }
        }
    }

    public void makeitem4()
    {
        if (ItemDataReader.Instance.getItemValue[12] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[7] > 0)
            {
                if(ItemDataReader.Instance.getItemValue[13] > 0)
                {
                    ItemDataReader.Instance.getItemValue[12]--;
                    ItemDataReader.Instance.getItemValue[7]--;
                    ItemDataReader.Instance.getItemValue[13]--;
                    ItemDataReader.Instance.getItemValue[14]++;
                    player.currentEXP++;
                }

            }
        }
    }

    public void makeitem5()
    {
        if (ItemDataReader.Instance.getItemValue[15] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[19] > 0)
            {
                ItemDataReader.Instance.getItemValue[15]--;
                ItemDataReader.Instance.getItemValue[19]--;
                ItemDataReader.Instance.getItemValue[24]++;
                player.currentEXP++;
            }
        }
    }

    public void makeitem6()
    {
        if (ItemDataReader.Instance.getItemValue[19] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[22] > 0)
            {
                ItemDataReader.Instance.getItemValue[19]--;
                ItemDataReader.Instance.getItemValue[22]--;
                ItemDataReader.Instance.getItemValue[25]++;
                player.currentEXP++;
            }
        }
    }

    public void makeitem7()
    {
        if (ItemDataReader.Instance.getItemValue[25] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[22] > 1)
            {
                if (ItemDataReader.Instance.getItemValue[19] > 0)
                {
                    ItemDataReader.Instance.getItemValue[25]--;
                    ItemDataReader.Instance.getItemValue[22]--;
                    ItemDataReader.Instance.getItemValue[22]--;
                    ItemDataReader.Instance.getItemValue[19]--;
                    ItemDataReader.Instance.getItemValue[26]++;
                    player.currentEXP++;
                }
            }
        }
    }

    public void makeitem8()
    {
        if (ItemDataReader.Instance.getItemValue[17] > 0)
        {
            if (ItemDataReader.Instance.getItemValue[23] > 0)
            {
                ItemDataReader.Instance.getItemValue[17]--;
                ItemDataReader.Instance.getItemValue[23]--;
                ItemDataReader.Instance.getItemValue[27]++;
                player.currentEXP++;
            }
        }
    }

    public void makeitem9()
    {
        if (ItemDataReader.Instance.getItemValue[27] > 1)
        {
                ItemDataReader.Instance.getItemValue[27]--;
                ItemDataReader.Instance.getItemValue[27]--;
                ItemDataReader.Instance.getItemValue[28]++;
            player.currentEXP++;
        }
    }

    public void viewitem()
    {
        itemmaker.SetActive(true);
    }

    public void noviewitem()
    {
        itemmaker.SetActive(false);
    }
}
