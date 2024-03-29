using UnityEngine;

public class SizeChanger : MonoBehaviour
{
    [SerializeField] private float _speed;

    private void Update()
    {
        Vector3 scaleChange = Vector3.one * _speed * Time.deltaTime;
        transform.localScale += scaleChange;
    }
}