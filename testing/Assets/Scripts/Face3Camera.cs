using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Face3Camera : MonoBehaviour
{
    public Transform PlayerTarget, old, cam;
    public float Speed, TurnSpeed;
    public LayerMask MaskObstacles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, PlayerTarget.position, Speed * Time.deltaTime);
        transform.Rotate(0, Input.GetAxis("Mouse X") * TurnSpeed, 0);

        //RaycastHit hit;
        //if (Physics.Raycast(PlayerTarget.position, old.position - PlayerTarget.position, out hit,
        //    Vector3.Distance(old.position, PlayerTarget.position), MaskObstacles)) ;
    }
}
