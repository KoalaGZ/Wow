using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Der selbe shit wie im CameraController nur das die Kanone nicht auf sich selbst fixiert ist sondern auf den Aimpoint gerichtet ist der gegenüber der Kamera sitzt 

public class CannonControll : MonoBehaviour {

    public Transform cannon;
    public Transform aimpoint;
    Vector3 _cameraOffset;

    [Range(0.01f, 1.0f)]
    public float SmoothFactor = 0.5f;

    public bool LookAtAimpoint;
    public bool RotateAroundCannon;

    public float RotationSpeed = 5.0f;

    
    void Start()
    {
        _cameraOffset = transform.position - cannon.position;
    }

    
    void Update()
    {
        if (RotateAroundCannon)
        {
            Quaternion camTurnAngle = Quaternion.AngleAxis(Input.GetAxis("Mouse X") * RotationSpeed, Vector3.up);

            _cameraOffset = camTurnAngle * _cameraOffset;

         if (RotateAroundCannon)
            {
                transform.rotation *= camTurnAngle;
            }

        }
        Vector3 newPos = cannon.position + _cameraOffset;

        transform.position = Vector3.Slerp(transform.position, newPos, SmoothFactor);

        if (LookAtAimpoint)
            transform.LookAt(aimpoint);

    }
}
