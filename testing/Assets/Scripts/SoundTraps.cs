using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTraps : MonoBehaviour
{
    
    public float time;
    private AudioClip Source;
    private float timer;
    void Start()
    {
        Source = GetComponent<AudioSource>().clip;
        timer = time;
    }
    void Update()
    {
        if (timer > 0) { timer -= Time.deltaTime; }
        if (timer < 0) { GetComponent<AudioSource>().PlayOneShot(Source); timer = time; }
    }
}
