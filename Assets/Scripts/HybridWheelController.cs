using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HybridWheelController : MonoBehaviour
{
    public List<TankAxleInfo> axleInfos; // the information about each individual axle
    public float maxMotorTorque; // maximum torque the motor can apply to wheel
    public void FixedUpdate()
    {
            
        foreach (TankAxleInfo axleInfo in axleInfos) {
            if(Input.GetKey(KeyCode.W)){
                axleInfo.leftWheel.motorTorque = maxMotorTorque;
            }
            if(Input.GetKey(KeyCode.S)){
                axleInfo.leftWheel.motorTorque = -maxMotorTorque;
            }
            if(Input.GetKey(KeyCode.E)){
                axleInfo.rightWheel.motorTorque = maxMotorTorque;
            }
            if(Input.GetKey(KeyCode.D)){
                axleInfo.rightWheel.motorTorque = -maxMotorTorque;
            }
        }
    }
}

[System.Serializable]
public class TankAxleInfo {
    public WheelCollider leftWheel;
    public WheelCollider rightWheel;
    public bool motor; // is this wheel attached to motor?
}