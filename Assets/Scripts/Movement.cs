using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Transform))]

public class Movement : MonoBehaviour
{
    private Transform _transform;
    
    [SerializeField] private float _speed;
    [SerializeField] private float _jumpForce;

    private void Start()
    {
        _transform = GetComponent<Transform>();
    }

    void Update()
    {      
        transform.Translate(new Vector2(Input.GetAxis("Horizontal") * _speed * Time.deltaTime, 0));

        if (Input.GetKey(KeyCode.Space))
        {
            transform.Translate(new Vector2(0, _jumpForce * Time.deltaTime));
        }
    }
}