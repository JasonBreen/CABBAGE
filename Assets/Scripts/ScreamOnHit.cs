using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreamOnHit : MonoBehaviour
{
    AudioSource source;
    public List<AudioClip> clips;
    private void Start()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "Bullet")
        {
            int choice = Random.Range(0, clips.Count);
            source.PlayOneShot(clips[choice]);
        }
    }
}
