using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BrokenObj : MonoBehaviour
{
    private AudioClip Source;

    private void Start()
    {
        Source = GetComponent<AudioSource>().clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GetComponent<AudioSource>().PlayOneShot(Source);
            Destroy(gameObject);
        }
    }
}
