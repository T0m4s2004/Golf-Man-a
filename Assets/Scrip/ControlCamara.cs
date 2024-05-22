using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlCamara : MonoBehaviour
{
    float xrotar = 0;
    public Rigidbody body;
    public float velocidad;
    public float disparo = 30;
    public LineRenderer line;
    void Update()
    {
        transform.position = body.position;
        if (Input.GetMouseButton(0))
        {
            xrotar += Input.GetAxis("Mouse X") * velocidad;
            transform.rotation = Quaternion.Euler(0, xrotar, 0);
            line.gameObject.SetActive(true);
            line.SetPosition(0, transform.position);
            line.SetPosition(1, transform.position + transform.forward * 4);
            if (xrotar < -35)
            {
                xrotar = -35;
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            body.velocity = transform.forward * disparo;
            line.gameObject.SetActive(false);
        }
    }
}
