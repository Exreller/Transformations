using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleGrowth : MonoBehaviour
{
    [SerializeField] private float _speed;

    void Update()
    {
        transform.localScale += new Vector3(1, 1, 1) * _speed * Time.deltaTime;
    }
}
