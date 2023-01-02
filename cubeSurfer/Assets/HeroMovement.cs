using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeroMovement : MonoBehaviour
{
    [SerializeField] private heroScr heroScrr;
    [SerializeField] private float forwardMovSpeed,horizontalSpeed,horizontalLimit;
    private float newPositionX;
    void Start()
    {
        
    }


    void FixedUpdate()//physics
    {
        SetHeroForwardMovement();
        SetHeroHorizontalMovement();
    }
    private void SetHeroForwardMovement()
    {
        transform.Translate(Vector3.forward * forwardMovSpeed * Time.fixedDeltaTime);//fixed,because we use FixedUpdate
    }
    private void SetHeroHorizontalMovement()
    {
        newPositionX = transform.position.x + heroScrr.HorizontalV * horizontalSpeed * Time.fixedDeltaTime;
        newPositionX = Mathf.Clamp(newPositionX, -horizontalLimit, horizontalLimit);
        transform.position = new Vector3(newPositionX, transform.position.y, transform.position.z);
    }
}
