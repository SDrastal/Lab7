using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Vector3 cameraOffset = new Vector3(0f, 1.2f, -2.6f);
    private Transform target;

    // Start is called before the first frame update
    void Start()
    {
        target = GameObject.Find("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.position = target.TransformPoint(cameraOffset);
        this.transform.LookAt(target);
    }
}
