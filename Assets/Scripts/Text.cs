using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Text : MonoBehaviour
{
    public KeyCode textButton = KeyCode.Space;

    public GameObject text;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(textButton))
        {
            text.SetActive(false);
        }
        if (Input.GetKeyUp(textButton))
        {
            text.SetActive(true);
        }
    }
}
