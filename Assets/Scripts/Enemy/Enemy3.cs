using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy3 : Enemy
{
    // Start is called before the first frame update
    void Start()
    {
        speed = 40f;
    }

    // Update is called once per frame
    void Update()
    {
        Move();
        DestroyGameObject();
    }
}
