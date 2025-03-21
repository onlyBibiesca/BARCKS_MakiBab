using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OptionsMenu : MonoBehaviour
{
    public GameObject OptionsUI;

    public void Back()
    {
        OptionsUI.SetActive(false);
        Debug.Log("Exiting Options Menu");
    }
}
