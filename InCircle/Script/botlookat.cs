using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class botlookat : MonoBehaviour
{
    Transform target;
    float timer;
    Rigidbody2D rigi;
    public GameObject par;
    PlayerScore playerScore;

    private void Start()
    {
        rigi = GetComponent<Rigidbody2D>();
        target = GameObject.Find("Player").GetComponent<Transform>();
        playerScore = GameObject.Find("score").GetComponent<PlayerScore>();

        Vector2 direction = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
        transform.up = direction;
    }

    // Update is called once per frame
    void Update()
    {
        if (timer < Random.Range(1f,20f))
        {
            timer += Time.deltaTime;
        }
        else
        {
            Vector2 direction = new Vector2(target.position.x - transform.position.x, target.position.y - transform.position.y);
            transform.up = direction;
            rigi.velocity = transform.up*20;
            timer = 0;
        }
    }

    /*private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerScore.Hit++;
            Destroy(Instantiate(par, transform.position, Quaternion.identity), 5f);
        }
    }*/

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            playerScore.Hit++;
            Destroy(Instantiate(par, transform.position, Quaternion.identity), 5f);
        }
    }
}
