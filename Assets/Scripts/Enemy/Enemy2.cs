using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 25f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyGameObject();
    }
}
