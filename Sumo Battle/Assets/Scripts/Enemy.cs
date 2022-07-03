using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private GameObject player;
    private Rigidbody enemyRb;
    public float speed = 2f;
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
        Vector3 target = (player.transform.position - transform.position).normalized;

        enemyRb.AddForce( target * speed);

        if(transform.position.y < -10 )
        {
            Destroy(gameObject);
        }
    }
}
