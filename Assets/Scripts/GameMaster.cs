using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameMaster : MonoBehaviour
{
    public Variables var;
    public Transform agent;
    public PlayerPrefsKey playerPrefsKey;

    void Awake()
    {
        agent.localPosition = var.StartPos;
        var.CurrentStage = SceneManager.GetActiveScene().name;

    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Gameover")
        {
            SceneManager.LoadScene(var.CurrentStage);
        }
        if (collision.gameObject.name == "Turn")
        {
            var.forward = false;
        }
        if (collision.gameObject.name == "Goal")
        {
            if (int.Parse(var.CurrentStage.Substring(5)) < PlayerPrefs.GetInt(playerPrefsKey.stage))
            {
                Debug.Log("Playing lower Level than player max");
            }
            else if (int.Parse(var.CurrentStage.Substring(5)) == PlayerPrefs.GetInt(playerPrefsKey.stage))
            {
                PlayerPrefs.SetInt(playerPrefsKey.stage, PlayerPrefs.GetInt(playerPrefsKey.stage) + 1);
                PlayerPrefs.Save();
            }
            else {
                Debug.Log("Cheat Detected");
            }

            SceneManager.LoadScene("Menu");
        }

    }
}
