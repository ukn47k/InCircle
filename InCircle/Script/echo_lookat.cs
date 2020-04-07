using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class echo_lookat : MonoBehaviour
{
    private void Start()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = new Vector2(pos.x - transform.position.x, pos.y - transform.position.y);
        transform.up = direction;
    }
}
