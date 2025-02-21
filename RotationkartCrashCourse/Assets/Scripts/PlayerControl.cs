using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    [SerializeField] private float speed = 5f;
    [SerializeField] private float maxVelocity = 50f;
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
        float currentSpeed = Vector3.Magnitude(playerRigidbody.velocity);
        if (currentSpeed > maxVelocity)
        {
            float brakeSpeed = currentSpeed - maxVelocity;
            Vector3 noralisedVelocity = playerRigidbody.velocity.normalized;
            Vector3 brakeVelocity = noralisedVelocity * brakeSpeed;
            playerRigidbody.AddForce(-brakeVelocity);
            
        }
        
    }
}
