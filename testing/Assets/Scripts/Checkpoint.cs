using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour
{
   public static int level = 0;
   public static List<Vector3> levelRespawns;
   public void AddCheckpoint(Vector3 CPPosition)
    {
        
        levelRespawns.Add(CPPosition);
    }
    private void Start()
    {
        levelRespawns = new List<Vector3>();
              
    }    
}
