using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
{
    private AudioSource music;
    // Start is called before the first frame update
    void Awake()
    {
        music = GetComponent<AudioSource>();
        if (!music.isPlaying)
        {
            music.Play();
        }
        DontDestroyOnLoad(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
