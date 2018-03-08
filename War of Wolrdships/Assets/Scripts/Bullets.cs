using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullets : MonoBehaviour
{
    //Spawnpunkt der Bullet
    public GameObject BulletEmitter;

    //Prefab der Bullet
    public GameObject Bullet;

    //Geschwindigkeit der Bullet
    public float BulletForwardForce;

    
    GameObject TemporaryBulletHandler;
    Rigidbody TemporaryRigidBody;

    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            //Bullet instantiation 
            TemporaryBulletHandler = Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;
            TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody>();

            //Bullet Geschwindigkeit 
            TemporaryRigidBody.AddForce(transform.forward * BulletForwardForce);

            //Schlechter Bullet Destroyer 

            Destroy(TemporaryBulletHandler, 10.0f);
                 
        }
    }
}