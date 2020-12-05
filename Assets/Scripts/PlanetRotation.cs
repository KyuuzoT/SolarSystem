using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetRotation : MonoBehaviour
{
    [SerializeField]
    private float RotationSpeed = 1.0f;

    [SerializeField][Range(0,100)]
    private float SpeedMultiplier = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float angle = ((float)(1.0 / RotationSpeed) * Time.deltaTime)*SpeedMultiplier;
        transform.Rotate(Vector3.up, angle);
    }
}
