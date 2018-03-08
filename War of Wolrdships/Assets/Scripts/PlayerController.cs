using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    //Geschwindigkeit zum Drehen 
    public float turnspeed = 40f;

    //Geschwindigekit des Schiffes 
    public float speed = 10f;
	
	
	void Update ()
    {

        //Tastenbelegung für das Drehen und Fahren 
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * turnspeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * speed;

        //Festlegung in welche Richtung es ausgeführt wird 
        transform.Rotate(0, x, 0);
        transform.Translate(0, 0, z);
    }
}
