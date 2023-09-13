using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private GameObject objectToFollow;
    [SerializeField] private Vector3 cameraOffset;

    private void FixedUpdate()
    {
        transform.position = objectToFollow.transform.position + cameraOffset;
    }
}
