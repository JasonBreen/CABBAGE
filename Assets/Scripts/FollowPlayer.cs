using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// this script interferes with the RigidBody component somehow. fix this!

public class FollowPlayer : MonoBehaviour
{
    private Transform player;
    public float walkingDistance = 10.0f; //walking distance towards the player
    //journey time
    public float smoothTime = 10.0f;
    //enemy velocity
    private Vector3 velocity = Vector3.zero;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    // Update is called once per frame
    void Update()
    {
        transform.LookAt(player);
        float distance = Vector3.Distance(transform.position, player.position);
        if(distance > walkingDistance)
        {
            transform.position = Vector3.SmoothDamp(transform.position, player.position, ref velocity, smoothTime);
        }
    }
}
