using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveGardien : MonoBehaviour
{
    public float speed = 3;
    public float smoothTime = 0.5f;
    public Transform target;

    public Vector3 currentVelocity;

    public float moveDuration = 10f;
    
    void Start()
    {
        target = GameObject.FindWithTag("TargetGardien2").transform;
        StartCoroutine(MoveGardien2());
    }

    IEnumerator MoveGardien2()
    {
        Vector3 startPositon = transform.position;
        float timeElapsed = 0;

        while (timeElapsed < moveDuration)
        {
            transform.position = Vector3.Lerp(startPositon, target.transform.position, timeElapsed / moveDuration);
            timeElapsed += Time.deltaTime;
            yield return null;
        }
    }

   
}
