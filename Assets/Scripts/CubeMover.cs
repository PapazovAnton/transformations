using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _moveSpeed;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        Vector3 scaleChange = Vector3.one * _scaleSpeed * Time.deltaTime;

        transform.Translate(Vector3.forward * _moveSpeed * Time.deltaTime);
        transform.Rotate(Vector3.up, _rotateSpeed * Time.deltaTime);
        transform.localScale += scaleChange;
    }
}
