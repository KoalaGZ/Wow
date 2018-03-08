using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hülsen : MonoBehaviour
{
    //Spawnpunkt der Bullet
    public GameObject BulletEmitter;

    //Prefab der Bullet
    public GameObject Bullet;

    //Geschwindigkeit der Bullet
    public float BulletForwardForce;

    
    void Start()
    {

    }

    
    void Update()
    {
        if (Input.GetMouseButtonDown (0))
        {
            //Bullet instantiation 
            GameObject TemporaryBulletHandler;
            TemporaryBulletHandler = Instantiate(Bullet, BulletEmitter.transform.position, BulletEmitter.transform.rotation) as GameObject;

            Rigidbody TemporaryRigidBody;
            TemporaryRigidBody = TemporaryBulletHandler.GetComponent<Rigidbody>();

            //Bullet Geschwindigkeit 
            TemporaryRigidBody.AddForce(transform.forward * BulletForwardForce);

            //Schlechter Bullet Destroyer 
            Destroy(TemporaryBulletHandler, 10.0f);
        }
    }
}