using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon : MonoBehaviour {

    //Drache wird bei Kollision nach untern versetzt 
    private void OnCollisionEnter(Collision collision)
    {
        transform.position = new Vector3
        (
            transform.position.x,
            transform.position.y - 4f,
            transform.position.z
        );

    }
}
