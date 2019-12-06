using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour
{

    public int Health = 3;
    public float speed;
 
    private bool isDead = false;
 
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    //private void Awake()
   // {
    //    currentHealth = startingHealth;
   // }

    // Update is called once per frame
    /* void Update()
    {
        if(damaged)
        {
            TakeDamage();
        }
     }
       
     */


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Environment")
        {
            EnvironmentDamage();
        }
        if(other.gameObject.tag == "CannonBall")
        {
            CannonDamage();
        }
    }


     void EnvironmentDamage()
    {
        
        Health -= 1;

        if (Health <= 0)
        {
            Death();
        }
    }

    void CannonDamage()
    {
        Health -= 2;
        if (Health <= 0)
        {
            Death();
        }
    }
 
    void Death()
    {
        isDead = true;

        transform.Translate(Vector3.down * speed * Time.deltaTime);
        Destroy(gameObject, 3.0f);
    }
   
}
