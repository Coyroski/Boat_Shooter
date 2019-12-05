using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonController : MonoBehaviour
{

///    public bool isFiring;

    public BulletController bullet;
    public float bulletSpeed;
    public float timeBetweenShots;
    private float shotCounter;
    private bool CannonisFiring;

    public Transform firePoint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            FireCannon();
        }

//        if (Input.GetMouseButtonUp(0))
//            CannonisFiring = false;

     }


    void FireCannon()
    {
        shotCounter -= Time.deltaTime;
        {
            if (shotCounter < -0)
            shotCounter = timeBetweenShots;
            BulletController newBullet = Instantiate(bullet, firePoint.position, firePoint.rotation) as BulletController;
            newBullet.speed = bulletSpeed;
        }

    }
}
