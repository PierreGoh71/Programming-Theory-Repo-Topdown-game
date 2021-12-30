using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private float speed = 70f;

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

    // move projectile
    private void Move(){

        gameObject.transform.Translate(Vector3.forward * speed * Time.deltaTime);

    }

    // Destroy projectile out of sight
    private void DestroyGameObject(){

        if(gameObject.transform.position.z > 60){
            Destroy(gameObject);
        }

    }

    private void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.CompareTag("Enemy")){
            Destroy(gameObject);
        }

    }
}
