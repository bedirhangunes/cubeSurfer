using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class heroScr : MonoBehaviour
{
    private float horizontal;
    public float HorizontalV//parantezsiz olunca get geliyor
    {
        get{ return horizontal; }
    }
    void Update()
    {
        handleHorizontal();
    }
    private void handleHorizontal()
    {
        if (Input.GetMouseButton(0))
        {
            horizontal = Input.GetAxis("Mouse X");
        }
        else
        {
            horizontal = 0;
        }
    }
     void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Finish")
        {
            SceneManager.LoadScene("levelEnd");
        }
    }
}
