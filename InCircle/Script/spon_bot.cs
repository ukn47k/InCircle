using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spon_bot : MonoBehaviour
{
    public GameObject[] bot = new GameObject[2];
    float timer;
    float a;
    float b;

    private void Start()
    {
        sponn();
        sponn();
        sponn();
        sponn();
        sponn();
    }

    void Update()
    {
        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        if (timer < 0.5f)
        {
            timer += Time.deltaTime;
        }
        else
        {
            Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity),30f);
            timer = 0;
        }
    }

    void sponn()
    {
        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity), 10f);

        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity), 8f);

        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity), 6f);

        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity), 4f);

        a = Random.Range(-199.5f, 199.5f);
        b = Random.Range(-199.5f, 199.5f);
        Destroy(Instantiate(bot[Random.Range(0, 2)], new Vector3(a, b, 0), Quaternion.identity), 2f);
    }
}
