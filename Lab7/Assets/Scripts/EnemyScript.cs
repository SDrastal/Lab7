using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player;
    private Transform enemy;

    void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.name == "Player");
        {
            Debug.Log("Player detected - attack!");
        }
    }

    void OnTriggerExit(Collider other)
    {
        if(other.gameObject.name == "Player")
        {
            Debug.Log("Player out of range, resume patrol");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<Transform>();
    }

    
    void FixedUpdate()
    {
        Vector3 directionToPlayer = player.position - enemy.transform.position;
        enemy.transform.Translate(directionToPlayer.normalized * Time.deltaTime);
    }
}
