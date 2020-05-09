using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class FollowPlayer : MonoBehaviour
{
    public TransformObj player;
    private NavMeshAgent nma;
    public float range;
    private bool following;
    public float angle;
    public LayerMask targets, obstacles;
    void Start()
    {
        nma = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {    
        if (following)
        {
            nma.SetDestination(player.value.position);
        }
        else
        {
            Collider[] hitColliders = Physics.OverlapSphere(transform.position, range, targets);
            if (hitColliders.Length > 0)
            {
                Vector3 direction = hitColliders[0].transform.position - transform.position;
                if (Vector3.Angle(direction, transform.forward) < angle)
                {
                    following = true;
                }
            }
        }
    }
}
