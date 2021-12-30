using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float m_speed = 35f;

    // ENCAPSULATION
    public float speed {
        set{
            m_speed = value;
        }
    }

    // move towards the player
    protected virtual void Move(){

        gameObject.transform.Translate(Vector3.back * m_speed * Time.deltaTime);

    }

    // Destroy when leaving 
    protected void DestroyGameObject(){

        if(gameObject.transform.position.z < -60){
            Destroy(gameObject);
        }

    }

    protected void OnCollisionEnter(Collision other) {
        
        if(other.gameObject.CompareTag("Projetil")){
            Destroy(gameObject);
        }

    }
}
