using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    float distance;

    private void Start()
    {
        Cursor.visible = false;
    }

    private void Update()
    {
        Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        distance = Vector2.Distance(transform.position, pos);

        transform.position = Vector2.Lerp(transform.position, pos, 0.25f / distance);

        //lookatmousePosition
        Vector2 direction = new Vector2(pos.x - transform.position.x, pos.y - transform.position.y);
        transform.up = direction;
    }
}
