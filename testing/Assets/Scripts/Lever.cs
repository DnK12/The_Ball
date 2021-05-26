using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    private AudioSource soundswitch;
    bool active = true;
    public GameObject LeverArm;
    public GameObject[] HidenObjs;

    private void Start()
    {
        soundswitch = GetComponent<AudioSource>();   
    }
    private void OnCollisionEnter(Collision other)
    {
        if (other.collider.CompareTag("Player"))
        {
            soundswitch.Play();
            if (active)
            {
                foreach(GameObject obj in HidenObjs)
                {
                    obj.SetActive(true);
                }
                LeverArm.transform.rotation = Quaternion.Euler(180,0,30);
                active = false;
            }
            else
            {
                foreach (GameObject obj in HidenObjs)
                {
                    obj.SetActive(false);
                }
                LeverArm.transform.rotation = Quaternion.Euler(180, 0, -30);
                active = true;
            }
        }
    }   
}
