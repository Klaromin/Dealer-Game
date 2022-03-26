using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamFollow : MonoBehaviour
{
    [SerializeField] GameObject whatToFollow;
    // Update is called once per frame
    void Update()
    {
        transform.position = whatToFollow.transform.position + new Vector3 (0,0,-20); 
    }
}
