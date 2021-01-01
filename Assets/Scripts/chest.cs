using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chest : MonoBehaviour
{
    public Animator animator;
    void Start()
    {
        animator.SetBool("unlocked", false);
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        animator.SetBool("unlocked",true);
    }
}
