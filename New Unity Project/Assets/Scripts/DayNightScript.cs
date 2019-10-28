using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayNightScript : MonoBehaviour
{
    public Transform dayPos;
    public Transform nightPos;

    private Vector3 targetPos;

    // Start is called before the first frame update
    void Start()
    {
        targetPos = nightPos.position;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(targetPos == nightPos.position)
        {
            transform.position += (targetPos - transform.position).normalized * 0.005f;
            if(Vector3.Distance(transform.position, targetPos) < 0.005f)
            {
                transform.position = targetPos;
                targetPos = dayPos.position;
            }
        }
        else
        {
            transform.position += (targetPos - transform.position).normalized * 0.005f;
            if (Vector3.Distance(transform.position, targetPos) < 0.005f)
            {
                transform.position = targetPos;
                targetPos = nightPos.position;
            }
        }
    }
}
