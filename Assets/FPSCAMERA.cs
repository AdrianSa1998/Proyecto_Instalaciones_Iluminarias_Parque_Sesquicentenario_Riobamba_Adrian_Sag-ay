using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FPSCAMERA : MonoBehaviour
{
    public Camera FPSCamera;
    public float horizontaSpeed;
    public float verticalSpeed;

    float h;
    float v;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        h = horizontaSpeed * Input.GetAxis("Mouse X");
        v = verticalSpeed * Input.GetAxis("Mouse Y");

        transform.Rotate(0, h, 0);
        FPSCamera.transform.Rotate(-v, 0, 0);

        if (Input.GetKey(KeyCode.W))
        {

            transform.Translate(0, 0, 0.1f);
        }
        else
        {

            if (Input.GetKey(KeyCode.S))
            {

                transform.Translate(0, 0, -0.1f);
            }
            else
            {

                if (Input.GetKey(KeyCode.A))
                {

                    transform.Translate(-0.1f, 0, 0);
                }

                else
                {

                    if (Input.GetKey(KeyCode.D))
                    {

                        transform.Translate(0.1f, 0, 0);
                    }
                }


            }
        }

        
    }
}
