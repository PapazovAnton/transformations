using UnityEngine;
public class Patrol : MonoBehaviour
{
    [SerializeField] private Vector3 _firstPoint;
    [SerializeField] private Vector3 _secondPoint;
    [SerializeField] private float _speed;

    private Vector3 _targetPoint;

    private void Start()
    {
        _targetPoint = _firstPoint;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _targetPoint, _speed * Time.deltaTime);

        if(transform.position.z >= _firstPoint.z)
        {
            _targetPoint = _secondPoint;
        } 
        else if(transform.position.z <= _secondPoint.z)
        {
            _targetPoint = _firstPoint;
        }
    }
}