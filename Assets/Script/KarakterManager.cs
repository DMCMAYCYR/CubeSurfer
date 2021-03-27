using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KarakterManager : MonoBehaviour
{
    Rigidbody rb;
    void Start()
    {
        Time.timeScale = 1f;
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        transform.position += Vector3.forward * 10*Time.deltaTime;
        if (Input.GetMouseButton(0))
        {
            if (Input.mousePosition.x > Screen.width / 2)
            {
                rb.velocity = new Vector3(10, 0, 0);
                
            }
            else
            {
                rb.velocity = new Vector3(-10, 0, 0);
            }
        }
    }
}
