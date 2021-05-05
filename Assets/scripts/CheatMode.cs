using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheatMode : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Delete)) {
            PlayerStats.Lives = 999;
            PlayerStats.Money = 9999999;
        }

    }
}
