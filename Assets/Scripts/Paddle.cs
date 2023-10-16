using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    [SerializeField] private bool _isPlayer1;
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    private Vector3 _startPosition;

    private float _movement;

    private void Start()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        if (_isPlayer1)
        {
            _movement = Input.GetAxisRaw("Vertical");
        }
        else
        {
            _movement = Input.GetAxisRaw("Vertical2");
        }

        _rb.velocity = new Vector2(_rb.velocity.x, _movement * _speed);
    }

    public void Reset()
    {
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
    }
}
