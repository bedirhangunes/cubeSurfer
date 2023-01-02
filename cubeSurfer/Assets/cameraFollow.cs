using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraFollow : MonoBehaviour
{
    [SerializeField] private Transform heroTransform;
    [SerializeField] private float lerpValue;
    private Vector3 offset, newPos;
    void Start()
    {
        offset = transform.position - heroTransform.position;//mesafe.Kamera ile char arasý
    }

   
    void LateUpdate()
    {
        SetCameraSmoothFollow();
    }
    private void SetCameraSmoothFollow()
    {
        newPos = Vector3.Lerp(transform.position, new Vector3(0f, heroTransform.position.y, heroTransform.position.z)+offset, lerpValue * Time.deltaTime);
        transform.position = newPos;
    }
}
