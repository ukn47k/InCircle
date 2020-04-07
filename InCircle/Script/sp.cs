using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sp : MonoBehaviour
{
    float a;
    public float b;

    public GameObject Echo;

    void Update()
    {
        if (a <= 0)
        {
            GameObject c = (GameObject)Instantiate(Echo, transform.position, Quaternion.identity);
            Destroy(c, 1f);
            a = b;
        }
        else
        {
            a -= Time.deltaTime;
        }
    }
}
