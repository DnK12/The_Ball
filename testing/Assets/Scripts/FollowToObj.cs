using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowToObj : MonoBehaviour
{
    public GameObject obj;
    Vector3 distanse;
    // Start is called before the first frame update
    void Start()
    {
        distanse =   transform.position - obj.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = obj.transform.position + distanse;
    }
}
