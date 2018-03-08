using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletCollide : MonoBehaviour
{


    public GameObject particle;


    //Bullet wird bei Kollision zerstört
    private void OnCollisionEnter(Collision collision)
    {
        //Spawn particle
        Instantiate(particle, transform.position, Quaternion.identity);
        

        Debug.Log("Kaputt");
        Destroy(gameObject);
    }



}
