using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 1f;
    public Joystick joystick;

    // Update is called once per frame
    void Update()
    {
        Vector2 temp = transform.position;
        if (joystick.Horizontal > 0)
        {
            temp.x += moveSpeed * Time.deltaTime;
        }
        else if(joystick.Horizontal < 0)
        {
            temp.x -= moveSpeed * Time.deltaTime;
        }

        if (joystick.Vertical > 0)
        {
            temp.y += moveSpeed * Time.deltaTime;
        }
        else if (joystick.Vertical < 0)
        {
            temp.y -= moveSpeed * Time.deltaTime;
        }

        transform.position = temp;
    }


 











    /*    void Update()
        {
            Vector3 dir = Vector3.zero;
            // we assume that the device is held parallel to the ground
            // and the Home button is in the right hand

            // remap the device acceleration axis to game coordinates:
            // 1) XY plane of the device is mapped onto XZ plane
            // 2) rotated 90 degrees around Y axis

            dir.x = -Input.acceleration.y;
            dir.z = Input.acceleration.x;

            // clamp acceleration vector to the unit sphere
            if (dir.sqrMagnitude > 1)
                dir.Normalize();

            // Make it move 10 meters per second instead of 10 meters per frame...
            dir *= Time.deltaTime;

            // Move object
            transform.Translate(dir * speed);
        }*/
}
