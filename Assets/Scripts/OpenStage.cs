using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class OpenStage : MonoBehaviour
{
    public Variables var;
    public void OnClick()
    {
        var.CurrentStage = gameObject.transform.name;
        SceneManager.LoadScene(gameObject.transform.name);
        Debug.Log("Coming soon");
    }
}
