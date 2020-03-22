using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Matter : MonoBehaviour
{

    public float mass;

    public bool isStatic;

    protected Rigidbody2D rb;
    protected PhysicsManager manager;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        manager = FindObjectOfType<PhysicsManager>();
    }

    protected virtual void FixedUpdate()
    {
        if (isStatic)
        {
            return;
        }

        GravityPull();
    }


    public void GravityPull()
    {
        Vector2 totalForceVec = Vector2.zero;

        foreach (Matter matter in manager.allMatter)
        {
            if (matter == this)
            {
                continue;
            }
            Vector2 posvector = matter.transform.position - transform.position;
            float distance = posvector.magnitude;

            float force = manager.gravitationalConstant * mass * matter.mass / (distance * distance);

            totalForceVec += force * posvector.normalized;
        }

        rb.AddForce(totalForceVec);
    }

}
