using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public AudioClip Hit;
    public AudioClip Resp;
    public AudioClip Roll;
    public Transform CameraTransform;
    private AudioSource player;
    public int maxVolumeAtSpeed;
    public int Lifes;
    public float Force;
    
    public  Rigidbody PlayerRb;
    public Vector3 Distanse(Vector3 camera, Vector3 obj) {
        return (camera - obj).normalized ;
    }  
    // Start is called before the first frame update
    public void IncLife()
    {
        Lifes++;
        
    }
    public void DecLife()
    {
        player.PlayOneShot(Resp);
        Lifes--;
        if (Lifes <= 0)
        {
            transform.position = Checkpoint.levelRespawns[0];
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        else
        {
            transform.position = Checkpoint.levelRespawns[Checkpoint.level];
        }
        
    }
    void Start()
    {
        player = GetComponent<AudioSource>();
        GameObject.FindGameObjectWithTag("GameController").GetComponent<Checkpoint>().AddCheckpoint(transform.position);
        player.clip = Roll;
        player.Play();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == "trap")
        {
            DecLife();
        }
        if (collision.collider.tag == "Checkpoint")
        {
            Checkpoint.level++;
            GameObject.FindGameObjectWithTag("GameController").GetComponent<Checkpoint>()
                .AddCheckpoint(collision.collider.transform.position + Vector3.up);
        }
        else 
        {
            player.PlayOneShot(Hit);
        }
    }

    private void OnCollisionStay(Collision collision)
    {
        
        player.volume = PlayerRb.velocity.magnitude / maxVolumeAtSpeed;
    }
    // Update is called once per frames
    void FixedUpdate()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            Vector3 distanse = Distanse(CameraTransform.position, PlayerRb.position);
            PlayerRb.AddForce( distanse * -Force * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.S))
        {
            Vector3 distanse = Distanse(CameraTransform.position, PlayerRb.position);
            PlayerRb.AddForce( distanse * Force * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.D))
        {
            Vector3 distanse = Distanse(CameraTransform.position, PlayerRb.position);
            PlayerRb.AddForce(new Vector3(distanse.z, distanse.y, -distanse.x) * -Force * Time.fixedDeltaTime);
        }
        if (Input.GetKey(KeyCode.A))
        {
            Vector3 distanse = Distanse(CameraTransform.position, PlayerRb.position);
            PlayerRb.AddForce(new Vector3(distanse.z, distanse.y, -distanse.x) * Force * Time.fixedDeltaTime);
        }
        
    }
}
