using UnityEngine;

public class SphereMover : MonoBehaviour
{
    private Vector3 _firstPoint = new Vector3(-7.75f, 0.85f, 3.14f);
    private Vector3 _secondPoint = new Vector3(-7.75f, 0.85f, -6.35f);
    private Vector3 _targetPoint;
    private int _speed = 5;

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
