﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class G : MonoBehaviour
{
    float m_distanceTraveled = 0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.G))
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(0, 2 * Time.deltaTime, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.G))
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(0, -2 * Time.deltaTime, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
        }
    }
}
