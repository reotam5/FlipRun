using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions.Must;

public class CeilingCollider : MonoBehaviour
{

    public Variables var;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            if (!var.down)
            {
                if (var.FlipGravity)
                {
                    var.FlipGravity = false;
                }
                if (var.jumping)
                {
                    var.jumping = false;
                }
            }
        }
    }
}
