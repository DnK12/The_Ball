using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePlate : MonoBehaviour
{
    public AudioClip Press;
    public AudioClip Unpress;
    private AudioSource source;
    public GameObject[] HidenObjs;

    private void Awake()
    {
        source = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") || other.CompareTag("Cube"))
        {
           foreach(var obj in HidenObjs)
            {
                if (obj.activeSelf)
                {
                    obj.SetActive(false);
                    source.PlayOneShot(Unpress);

                }
                else
                {
                    obj.SetActive(true);
                    source.PlayOneShot(Press);
                }
            } 
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player") || other.CompareTag("Cube"))
        {
            foreach (var obj in HidenObjs)
            {
                if (obj.activeSelf)
                {
                    obj.SetActive(false);
                }
                else
                {
                    obj.SetActive(true);
                }
            }
        }
    }

}
