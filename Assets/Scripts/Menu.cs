using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Menu : MonoBehaviour
{
    private void Start()
    {
        AudioManager.instance.PlayMusic("MenuMusic");
    }

}
