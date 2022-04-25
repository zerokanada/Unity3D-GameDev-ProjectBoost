using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movements : MonoBehaviour
{
    Rigidbody rb;
    [SerializeField] float thrustForce = 100f;
    [SerializeField] float rotateForce = 100f;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        
    }

    // Update is called once per frame
    void Update()
    {
        ProcessThrust ();
        ProcessRotation ();
    }

    void ProcessThrust (){
        if (Input.GetKey(KeyCode.Space)){
            Debug.Log("Pressed Space");
            rb.AddRelativeForce(Vector3.up * thrustForce * Time.deltaTime) ;

        }
    }
    void ProcessRotation (){
        
        if (Input.GetKey(KeyCode.A)|| Input.GetKey(KeyCode.LeftArrow))
        {
            ApplyRotation(rotateForce);

        }
        else if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){

            ApplyRotation(-rotateForce);

        }
        

    }

    void ApplyRotation(float rotationThisFrame)
    {
        rb.constraints = RigidbodyConstraints.FreezeRotationZ; //freeze rotation so we can manually rotate
        transform.Rotate(Vector3.forward * rotationThisFrame * Time.deltaTime);
        rb.constraints = RigidbodyConstraints.None;
        rb.constraints = RigidbodyConstraints.FreezePositionZ | RigidbodyConstraints.FreezeRotationX | RigidbodyConstraints.FreezeRotationY; //unfreeze rotation so physics rotation can take over
    }
}