using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamScript : MonoBehaviour
{
    Rigidbody camera0;

    // Start is called before the first frame update
    void Start()
    {
        camera0 = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            camera0.AddRelativeForce(Vector3.up);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            camera0.AddRelativeForce(-Vector3.up);
        }
    }
}
