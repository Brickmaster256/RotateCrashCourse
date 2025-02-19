using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    private Rigidbody playerRigidbody;
     void Start()
    {
        playerRigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            playerRigidbody.AddForce(transform.right * speed);
        }
        if (Input.GetKey(KeyCode.A))
        {
            playerRigidbody.AddForce(transform.right * -speed);
        }
    }
}
