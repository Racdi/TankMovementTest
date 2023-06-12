using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollingTankController : MonoBehaviour
{
    public List<Rigidbody> LeftWheelies;
    public List<Rigidbody> RightWheelies;

    public float torqueForward;
    public float torqueBackward;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            foreach (Rigidbody wheelie in LeftWheelies){
                wheelie.maxAngularVelocity = 15;
                wheelie.AddTorque(wheelie.transform.up * torqueForward);
            }
        }
        if(Input.GetKey(KeyCode.S)){
            foreach (Rigidbody wheelie in LeftWheelies){
                wheelie.maxAngularVelocity = 15;
                wheelie.AddTorque(wheelie.transform.up * torqueBackward);
            }
        }
        if(Input.GetKey(KeyCode.E)){
            foreach (Rigidbody wheelie in RightWheelies){
                wheelie.maxAngularVelocity = 15;
                wheelie.AddTorque(wheelie.transform.up * torqueForward);
            }
        }
        if(Input.GetKey(KeyCode.D)){
            foreach (Rigidbody wheelie in RightWheelies){
                wheelie.maxAngularVelocity = 15;
                wheelie.AddTorque(wheelie.transform.up * torqueBackward);
            }
        }

        if(Input.GetKey(KeyCode.W) == false && Input.GetKey(KeyCode.S)== false){
            foreach (Rigidbody wheelie in LeftWheelies){
                wheelie.maxAngularVelocity = 0;
            }
        }
        if(Input.GetKey(KeyCode.E) == false && Input.GetKey(KeyCode.D)== false){
            foreach (Rigidbody wheelie in RightWheelies){
                wheelie.maxAngularVelocity = 0;
            }
        }
    }
}
