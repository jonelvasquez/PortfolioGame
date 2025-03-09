using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleBoatMovement : MonoBehaviour
{
    [SerializeField] private float _speed;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");

        transform.position += transform.right * v * Time.deltaTime * _speed;
        transform.Rotate(Vector3.up * h);

    }
}
