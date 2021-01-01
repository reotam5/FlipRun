using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UnlockedStages : MonoBehaviour
{
    public PlayerPrefsKey playerPrefsKey;
    public int maxStage;
    void Awake()
    {
        PlayerPrefs.SetInt(playerPrefsKey.stage, PlayerPrefs.GetInt(playerPrefsKey.stage, 1));
        PlayerPrefs.Save();
        maxStage = PlayerPrefs.GetInt(playerPrefsKey.stage,1);
        for (int i = 0; i < gameObject.transform.childCount; i++)
        {
            if (i + 1 <= maxStage)//unlock
            {
                gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).transform.GetComponent<Button>().interactable = true;
            }
            else//lock
            {
                gameObject.transform.GetChild(i).gameObject.transform.GetChild(0).transform.GetComponent<Button>().interactable = false;
            }
        }
    }
}
