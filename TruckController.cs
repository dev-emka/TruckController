using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TruckController : MonoBehaviour
{
    public WheelCollider leftCol;
    public WheelCollider rightCol;
    public WheelCollider backRightCol;
    public WheelCollider backLeftCol;

    public GameObject leftWhl;
    public GameObject rightWhl;
    public GameObject backRightWhl;
    public GameObject backLeftWhl;

    public float maxTorquePower;
    public float maxRoDirection;
    public float enginePower;
    public FixedJoystick joystick;

    private void FixedUpdate()
    {
        enginePower = maxTorquePower * joystick.Vertical;
        float donus=maxRoDirection * joystick.Horizontal;

        
    }
}
