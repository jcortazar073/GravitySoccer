using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : Matter
{
    public float torque;
    public float thrust;

    protected override void FixedUpdate()
    {
        base.FixedUpdate();

        if (Input.GetKey(KeyCode.A)||Input.GetAxis("Horizontal")<-0.2)
        {
            rb.AddTorque(torque);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetAxis("Horizontal") > 0.2)
        {
            rb.AddTorque(-torque);
        }
        if (Input.GetKey(KeyCode.Space)|| Input.GetButton("Fire1"))
        {
            rb.AddForce(thrust * transform.up);
        }
    }
}
