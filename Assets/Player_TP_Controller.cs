using UnityEngine;
using System.Collections;

public class Player_TP_Controller : MonoBehaviour {
    //fields 
    public static CharacterController controller;
    public static Player_TP_Controller instance; 
	// Use this for initialization
	void Awake() 
    {
        instance = this;
        controller = GetComponent("CharacterController") as CharacterController; 
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        InputMiscare();
        Player_TP_Motor.instance.UpdateMotor();
	}
    void InputMiscare()
    {
        // o recalculam la fiecare frame 
        var deadzone = 0.1f; 

        Player_TP_Motor.instance.MoveVector = Vector3.zero;

  if (Input.GetAxis("Vertical") > deadzone || Input.GetAxis("Vertical") < -deadzone)
     Player_TP_Motor.instance.MoveVector += new Vector3(0, 0, Input.GetAxis("Vertical"));
  if (Input.GetAxis("Horizontal") > deadzone || Input.GetAxis("Horizontal") < -deadzone)
      Player_TP_Motor.instance.MoveVector += new Vector3(Input.GetAxis("Horizontal"), 0, 0);


    }
}
