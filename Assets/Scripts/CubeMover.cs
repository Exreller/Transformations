using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMover : MonoBehaviour
{
    [SerializeField] private float _growthSpeed;
    [SerializeField] private float _rotationSpeed;
    [SerializeField] private Vector3 _movementDirection;

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up * _rotationSpeed * Time.deltaTime);

        transform.localScale += new Vector3(1, 1, 1) * _growthSpeed * Time.deltaTime;

        transform.Translate(_movementDirection, Space.Self);
    }
}
