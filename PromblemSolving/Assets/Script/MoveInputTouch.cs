using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveInputTouch : MonoBehaviour
{
    private Rigidbody2D Rb;
    public float speed = 10;
    Vector2 lastClickedPos;
    [SerializeField]
    bool moving;
    public bool gameOver = false;

    void Start()
    {
        gameOver = false;
        Rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (gameOver == false)
        {
            if (Input.GetMouseButtonDown(0))
            {
                lastClickedPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
                moving = true;
            }
            if (moving && (Vector2)transform.position != lastClickedPos)
            {
                float step = speed * Time.deltaTime;
                transform.position = Vector2.MoveTowards(transform.position, lastClickedPos, step);
            }
            else
            {
                moving = false;
            }
        }
    }

    private void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Wall")
        {
            moving = false;
        }
    }
}
