using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntireKeyboard : MonoBehaviour
{
    float m_distanceTraveled = 0f;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            gameObject.SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            gameObject.SetActive(false);
        }

    }
}
