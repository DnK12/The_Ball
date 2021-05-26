using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Portal : MonoBehaviour
{
    public GameObject Exit;
    private AudioClip Source;

    private void Start()
    {
        Source = GetComponent<AudioSource>().clip;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Cube"))
        {
            GetComponent<AudioSource>().PlayOneShot(Source);
            other.transform.position = Exit.transform.position + Vector3.right;
        }
    }
}
