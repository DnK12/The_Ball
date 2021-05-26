using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallenObj : MonoBehaviour
{    
    void FallObj()
    {
        gameObject.SetActive(false);

    }
    void RecoveryObj()
    {
        gameObject.SetActive(true);

    }
    private void OnCollisionExit(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            FallObj();
            Invoke("RecoveryObj", 6);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {

            Invoke("FallObj", 4);
            Invoke("RecoveryObj", 10);
        }
    }
}
