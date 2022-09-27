using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraController : MonoBehaviour
{
    public Transform trackedObject;
    public float maxDistance = 10f;
    public float moveSpeed = 20f;
    public float updateSpeed = 10f;
    [Range(0, 10)]
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
