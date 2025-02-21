using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraRotate : MonoBehaviour
{
    [SerializeField] private float rotateAmount = 15;

    // Update is called once per frame
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Rotate(0,0,rotateAmount);
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            transform.Rotate(0,0,-rotateAmount);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Rotate(0, 0, -rotateAmount);
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            transform.Rotate(0, 0, rotateAmount);
        }
    }
}
