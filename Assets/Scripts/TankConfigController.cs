using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankConfigController : MonoBehaviour
{
    Rigidbody thisTankRB;
    public Transform LeftTread;
    public Transform RightTread;

    public float firstGearForward;
    public float firstGearBackward;

    // Start is called before the first frame update
    void Start()
    {
        thisTankRB = this.GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.W)){
            thisTankRB.AddForceAtPosition(LeftTread.forward * firstGearForward, LeftTread.position, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.S)){
            thisTankRB.AddForceAtPosition(LeftTread.forward * firstGearBackward, LeftTread.position, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.E)){
            thisTankRB.AddForceAtPosition(RightTread.forward * firstGearForward, RightTread.position, ForceMode.Force);
        }
        if(Input.GetKey(KeyCode.D)){
            thisTankRB.AddForceAtPosition(RightTread.forward * firstGearBackward, RightTread.position, ForceMode.Force);
        }
    }
}
