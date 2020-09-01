using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public TransformObj obj;
    public Weapon weapon;
    // Start is called before the first frame update
    void Awake()
    {
        obj.value = transform;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            weapon.Shoot();
        }
    }
    public void Shoot()
    {
        weapon.Shoot();
    }
}
