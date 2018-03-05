using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubStun : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        animator = GetComponent<Animator>();

    }
    public void subHit(bool Hit = false)
    {
        if (Hit == true)
        {
            animator.SetBool("IsStunned", true);



        }

        else
        {
            animator.SetBool("IsStunned", false);


        }
    }

}
