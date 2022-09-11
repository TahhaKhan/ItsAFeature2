using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    [SerializeField] float playerSpeed = 1f;
    [SerializeField] float rotationSpeed = 1f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        PositionalMovement();
        RotationalMovement();

    } 

    void RotationalMovement()
    {
        if(Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
        }
        if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, -1 * rotationSpeed * Time.deltaTime, 0);
        }

    }  

    void PositionalMovement()
    {
        if(Input.GetKey(KeyCode.W))
        {
            // Debug.Log("At least I'm here");
            transform.Translate(Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.S))
        {
            // Debug.Log("At least I'm here");
            transform.Translate(-Vector3.forward * playerSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.D))
        {
            // Debug.Log("At least I'm here");
            transform.Translate(Vector3.right * playerSpeed * Time.deltaTime);
        }
        if(Input.GetKey(KeyCode.A))
        {
            // Debug.Log("At least I'm here");
            transform.Translate(-Vector3.right * playerSpeed * Time.deltaTime);
        }
    }
}
