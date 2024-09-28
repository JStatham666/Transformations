using UnityEngine;

public class Increaser : MonoBehaviour
{
    [SerializeField] private float _targetScale;
    [SerializeField] private float _scaleSpeed;

    private Vector3 initialScale;

    private void Start()
    {
        initialScale = transform.localScale;
    }

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, initialScale * _targetScale, _scaleSpeed * Time.deltaTime);
    }
}
