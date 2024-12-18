using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    //movemment
    public float movespeed=3;

    private CharacterController _controller;

    private float hInput;

    [HideInInspector] public Vector3 dir;
    //shoot
    public GameObject bullet;

    public Transform firepoint;
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
        Instantiate(bullet, firepoint.position, firepoint.rotation);
    }

    public void getDirection()
    {
        hInput = Input.GetAxisRaw("Horizontal");
        dir = transform.right * hInput;
        _controller.Move(dir.normalized * movespeed * Time.deltaTime);
    }
}
