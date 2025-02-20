using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float moveSpeed = 8f;
    public float turnSpeed = 85f;
    private float verticalInput;
    private float horizontalInput;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical") * moveSpeed;
        horizontalInput = Input.GetAxis("Horizontal") * turnSpeed;
        this.transform.Translate(Vector3.forward * verticalInput * Time.deltaTime);
        this.transform.Rotate(Vector3.up * horizontalInput * Time.deltaTime);
    }
}
