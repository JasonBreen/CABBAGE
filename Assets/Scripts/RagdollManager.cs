using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RagdollManager : MonoBehaviour
{
    public bool ragOn = false;
    private Collider main;
    private Collider[] bodies;
    // Start is called before the first frame update
    void Awake()
    {
        main = GetComponent<Collider>();
        bodies = GetComponentsInChildren<Collider>(true);
        Set(ragOn);
    }

    public void Set(bool on)
    {
        ragOn = on;
        foreach (Collider body in bodies)
        {
            body.enabled = ragOn;
        }
        main.enabled = !ragOn;
        GetComponent<Rigidbody>().useGravity = !ragOn;
    }
}
