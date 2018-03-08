using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraControler : MonoBehaviour {


    public Transform cannon; 
    Vector3 _cameraOffset; //Abstand zwischen Kamera und Schiff
    [Range(0.01f, 1.0f)]


    public float SmoothFactor = 0.5f; //Smootheres Umschauen
    public bool LookAtCannon; //beim drehen auf die Kanone gucken
    public bool RotateAroundCannon; //um die Kanone drehen
    public float RotationSpeed = 5.0f; //Geschwindigkeit zum drehen 

    
    void Start()
    {
        _cameraOffset = transform.position - cannon.position; //Abstand zwischen Kamera und Schiff
    }

    
    void Update()
    {


    }

    private void LateUpdate() //Funktion zum drehen der Kamera um die Kanone und fixieren auf die Kanone 
    {
        if (RotateAroundCannon)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);

            _cameraOffset = camTurnAngle * _cameraOffset;
        }
        Vector3 newPos = cannon.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtCannon || RotateAroundCannon)
            transform.LookAt(cannon);
    }
}
