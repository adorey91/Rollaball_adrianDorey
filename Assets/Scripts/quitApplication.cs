using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuitApplication : MonoBehaviour
{
    public void OnButtonTrigger()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
