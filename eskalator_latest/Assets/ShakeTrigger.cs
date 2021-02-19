using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShakeTrigger : MonoBehaviour
{
    public CameraShaker cameraShake;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            StartCoroutine(cameraShake.Shake(.15f, .2f));
        }
    }
}

