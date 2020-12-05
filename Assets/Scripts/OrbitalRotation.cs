using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitalRotation : MonoBehaviour
{
    [SerializeField]
    private GameObject pivotOrbitalRotationPoint;

    [SerializeField]
    private float rotationSpeed = 0.0f;

    [SerializeField]
    private float multiplier = 1.0f;

    private Vector3 offset;
    private float rotationY = 0.0f;

    // Start is called before the first frame update
    void Start()
    {
        offset = pivotOrbitalRotationPoint.transform.position - transform.position;
        //rotationSpeed /= 365;
    }

    // Update is called once per frame
    void Update()
    {
        rotationY += (1.0f / rotationSpeed)*multiplier;
        Quaternion rotation = Quaternion.Euler(0, rotationY, 0);
        //var angle = pivotOrbitalRotationPoint.transform.position
        transform.position = pivotOrbitalRotationPoint.transform.position - ((rotation) * offset);
    }
}
