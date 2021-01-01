using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FloorCollider : MonoBehaviour
{
    public Variables var;
    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.name == "Tilemap")
        {
            if (var.down)
            {
                if (var.jumping)
                {
                    var.jumping = false;
                }
                if (var.FlipGravity)
                {
                    var.FlipGravity = false;
                }
            }
        }
    }
}
