using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    
    public Transform _target;
    private Transform _cam; 
    void Start()
    {
        _cam = Camera.main.transform;
    }

    // Update is called once per frame
    void Update()
    {
        _cam.position = new Vector3(_target.position.x, _target.position.y, _cam.position.z);
    }
}
