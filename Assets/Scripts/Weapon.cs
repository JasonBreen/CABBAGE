using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Rigidbody proj;
    public float projSpeed;
    public float delay;
    public float projLife;
    public Transform origin;
    private bool delayed = false;

    public void Shoot()
    {
        if (!delayed)
        {
            Rigidbody bullet = Instantiate(proj, origin.position, origin.rotation);
            bullet.velocity = origin.forward * projSpeed;
            Destroy(bullet.gameObject, projLife);
            delayed = true;
            Invoke("UnDelay", delay);
        }
    }

    public void UnDelay()
    {
        delayed = false;
    }
}
