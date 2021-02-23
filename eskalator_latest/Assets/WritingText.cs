using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WritingText : MonoBehaviour
{
    public Text nesessaryText;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Q))
        {
            WriteText();
        }
    }

    public void WriteText()
    {
        nesessaryText.text = "Pulse or something";
    }
}
