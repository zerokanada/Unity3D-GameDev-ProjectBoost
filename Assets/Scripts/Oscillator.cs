using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Oscillator : MonoBehaviour
{
    Vector3 startingPosition;
    [SerializeField] Vector3 movementVector;
    [SerializeField] Vector3 movementFactor;
    // Start is called before the first frame update
    void Start()
    {
        startingPosition=transform.position;
        Debug.Log(startingPosition);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}