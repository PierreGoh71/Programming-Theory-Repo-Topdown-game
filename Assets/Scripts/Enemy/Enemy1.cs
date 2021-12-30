using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// INHERITANCE
public class Enemy1 : Enemy
{
    private float speed_m = 20f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyGameObject();
    }

    // POLYMORPHISM
    protected override void Move()
    {

        gameObject.transform.Translate(Vector3.back * speed_m * Time.deltaTime);

    }
}
