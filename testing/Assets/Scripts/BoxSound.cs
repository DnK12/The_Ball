using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSound : MonoBehaviour
{
    
    private AudioSource boxSound;
    private Vector3 startPos;
    private Quaternion startRotate;    
    // Start is called before the first frame update
    void Awake()
    {
        boxSound = GetComponent<AudioSource>();
        startPos = transform.position;
        startRotate = transform.rotation;
    }

    private void OnCollisionStay(Collision other)
    {
        if (!boxSound.isPlaying && other.collider.CompareTag("Player"))
        {
            boxSound.Play();
        }
    }  
    // Update is called once per frame
    private void OnCollisionExit(Collision other)
    {
        boxSound.Pause();
        //if (boxSound.isPlaying && other.collider.CompareTag("Player"))
        //{
        //    if (startPos != transform.position && startRotate != transform.rotation)
        //    {
        //        startPos = transform.position;
        //        startRotate = transform.rotation;
        //    }
        //}    
    }

    private void Update()
    {
        
    }
}
