using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    void OnTriggerEnter(Collider collision)
    {
        //if(collision.gameObject.name == "Player")
        //{
            Destroy(gameObject);
            Debug.Log("Item collected!");
        //}
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
