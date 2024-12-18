using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movemment
    public float movespeed=3;
    public Animator animator;
    private CharacterController _controller;

    private float hInput;

    [HideInInspector] public Vector3 dir;
    //shoot
    public GameObject bullet;

    public Transform firepoint;

    public GameObject SFXThrow;
    // Start is called before the first frame update
    void Start()
    {
        _controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {
        getDirection();
        if (Input.GetButtonDown("Fire1"))
        {
            Tembak();
        }
    }

    public void Tembak()
    {
        animator.SetTrigger("Shoot");
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }

    public void getDirection()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        dir = transform.right * hInput;
        _controller.Move(dir.normalized * movespeed * Time.deltaTime);
        if (hInput < 0)
        {
            animator.SetTrigger("kiri");
        }
        else if (hInput > 0)
        {
            animator.SetTrigger("kanan");
        }
    }
    
}
