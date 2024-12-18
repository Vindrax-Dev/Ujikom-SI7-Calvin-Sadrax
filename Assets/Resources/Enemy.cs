using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Enemy : MonoBehaviour
{
    public float movespeed = 5;

    public int health = 100;

    public IngameManager amount;
    // Start is called before the first frame update
    void Start()
    {
        amount = FindObjectOfType<IngameManager>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * movespeed * Time.deltaTime);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("bullet"))
        {
            TakeDamage(30);
            Destroy(other.gameObject);
        }
        if (other.CompareTag("obstacle"))
        {
            Destroy(gameObject);
            amount.ScoreManager(-3);
        }
    }

    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            amount.ScoreManager(1);
            Destroy(gameObject);
        }
    }
}
