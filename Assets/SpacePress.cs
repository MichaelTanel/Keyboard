using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePress : MonoBehaviour
{
    public float clockwise = 1000.0f;

    public float speed = 1f;
    float m_distanceTraveled = 0f;
    public bool keydown = false;


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(0, 2 * Time.deltaTime, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 oldPosition = transform.position;
            transform.Translate(0, -2 * Time.deltaTime, 0);
            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
            /*            if (!keydown) {
                            keydown = true;
                            Vector3 oldPosition = transform.position;
                            transform.Translate(0, -2 * Time.deltaTime, 0);
                            m_distanceTraveled += Vector3.Distance(oldPosition, transform.position);
                        } else {
                            keydown = false;

                        }*/
        }
    }

}
