
using UnityEngine;

public class Ball : MonoBehaviour
{
    [SerializeField] private float _speed;
    [SerializeField] private Rigidbody2D _rb;

    private Vector3 _startPosition;

    private void Start()
    {
        _startPosition = transform.position;
        Launch();
    }

    public void Reset()
    {
        _rb.velocity = Vector2.zero;
        transform.position = _startPosition;
        Launch();
    }

    private void Launch()
    {
        float x = Random.Range(0, 2) == 0 ? -1 : 1;
        float y = Random.Range(0, 2) == 0 ? -1 : 1;

        _rb.velocity = new Vector2(_speed * x, _speed * y);
    }
}
