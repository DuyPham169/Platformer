using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapFireButton : MonoBehaviour
{
    private TrapFire trapFire;
    private Animator anim;

    private void Awake()
    {
        anim = GetComponent<Animator>();
        trapFire = GetComponentInParent<TrapFire>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Player player = collision.gameObject.GetComponent<Player>();

        if (player != null)
        {
            anim.SetTrigger("activate");
            trapFire.SwitchOffFire();
        }
    }
}
