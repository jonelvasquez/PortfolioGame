using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleCameraFollow : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Transform _target;
    private Vector3 startOffset;
    // Start is called before the first frame update
    void Start()
    {
        startOffset = transform.position - _target.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.Lerp(transform.position, _target.position + startOffset, Time.deltaTime * _speed);
    }
}
