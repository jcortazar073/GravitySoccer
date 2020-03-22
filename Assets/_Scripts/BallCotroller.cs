using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallCotroller : Matter
{
    public Vector2 initialPosition;
    public Vector2 initialVelocity;

    private void Start()
    {
        transform.position = initialPosition;
        rb.velocity = initialVelocity;
    }
}
