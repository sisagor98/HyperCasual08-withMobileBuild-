using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchScreen : MonoBehaviour
{
    private float deltaX, deltaY;
    private Rigidbody2D rb;


    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();

    }


    private void Update()
    {
        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 toucePos = Camera.main.ScreenToWorldPoint(touch.position);

            switch (touch.phase)
            {
                case TouchPhase.Began:
                    deltaX = toucePos.x - transform.position.x;
                    deltaY = toucePos.y - transform.position.y;
                    break;
                case TouchPhase.Moved:
                    rb.MovePosition(new Vector2(toucePos.x - deltaX, toucePos.y - deltaY));
                    break;

                case TouchPhase.Ended:
                    rb.velocity = Vector2.zero;
                    break;

            }
        }
    }
}
