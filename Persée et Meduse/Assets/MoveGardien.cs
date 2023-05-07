using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEngine;

public class MoveGardien : MonoBehaviour
{
    public Vector3 targetPosition1;
    public Vector3 targetPosition2;
    public Vector3 targetPosition3;
    public Vector3 targetPosition4;
    public Vector3 targetPosition5;
    
    public float smoothTime = 0.5f; 
    public float speed = 10;
    Vector3 velocity;
    void Update()
    {
        //transform.position = Vector3.SmoothDamp(transform.position, targetPosition1, ref velocity, smoothTime, speed);
        // transform.position = Vector3.SmoothDamp(targetPosition1, targetPosition2, ref velocity, smoothTime, speed);
        // transform.position = Vector3.SmoothDamp(targetPosition2, targetPosition3, ref velocity, smoothTime, speed);
        // transform.position = Vector3.SmoothDamp(targetPosition3, targetPosition4, ref velocity, smoothTime, speed);
        // transform.position = Vector3.SmoothDamp(targetPosition4, targetPosition5, ref velocity, smoothTime, speed);
    }

    void Start()
   {
      // transform.position = Vector3.SmoothDamp(transform.position, targetPosition1, ref velocity, smoothTime, speed);
   }

    IEnumerator Gardien()
    {
        transform.position = Vector3.SmoothDamp(transform.position, targetPosition1, ref velocity, smoothTime, speed);
        yield return new WaitForSeconds(1);
        transform.position = Vector3.SmoothDamp(targetPosition1, targetPosition2, ref velocity, smoothTime, speed);
        yield return new WaitForSeconds(1);
        transform.position = Vector3.SmoothDamp(targetPosition2, targetPosition3, ref velocity, smoothTime, speed);
        yield return new WaitForSeconds(1);
        transform.position = Vector3.SmoothDamp(targetPosition3, targetPosition4, ref velocity, smoothTime, speed);
        yield return new WaitForSeconds(1);
        transform.position = Vector3.SmoothDamp(targetPosition4, targetPosition5, ref velocity, smoothTime, speed);
        yield return new WaitForSeconds(1);
    }
    
}
