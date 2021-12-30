using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    private float speed = 50f;
    private float offsetZ = 2f;

    [SerializeField] private GameObject projectile;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // ABSTRACTION
        Move();
        Shoot();
    }

    // Moving left and right.
    private void Move(){

        // move right
        if (Input.GetKey(KeyCode.RightArrow) && gameObject.transform.position.x < 34){
            gameObject.transform.Translate(Vector3.right * speed * Time.deltaTime);
        }

        // move left
        if (Input.GetKey(KeyCode.LeftArrow) && gameObject.transform.position.x > -34){
            gameObject.transform.Translate(Vector3.left * speed * Time.deltaTime);
        }

    }

    // shoot projectile
    private void Shoot(){

        if(Input.GetKeyDown("space")){
            Instantiate(projectile, new Vector3(gameObject.transform.position.x, 1.5f, gameObject.transform.position.z + offsetZ), gameObject.transform.rotation);
           
        }

    }
}
