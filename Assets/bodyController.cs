using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bodyController : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform pTransform;
    public float zRot;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        zRot = pTransform.rotation.y;
    }
}
