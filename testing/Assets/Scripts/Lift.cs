using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lift : MonoBehaviour
{
    public float  Speed;
    public float stopLift;   
    bool isMove = false;
    void MoveObj()
    {
        transform.Translate(Vector3.down * Time.deltaTime * Speed);        
    }
    
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.CompareTag("Player"))
        {
            isMove = true;
            
        }
       

    }


    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.localPosition.y > stopLift && isMove)
        {
            MoveObj();

        }
    }
}
