using UnityEngine;
using System.Collections;

public class Player_TP_Motor : MonoBehaviour
{
    #region Fields
    public static Player_TP_Motor instance;

    public float MoveSpeed = 10f; 


    #endregion
    #region Properties
    public Vector3 MoveVector{ get ; set ; }
    #endregion

    #region Functions
    void Awake()
    {
        instance = this; 
    }
    public void UpdateMotor()
    {
        ProcessMotion();
    }
    void ProcessMotion()
    {
        //Transforma in World Space  2 Normalizam daca modul  > 1  3 MoveVector cu MoveSpeed
        MoveVector = transform.TransformDirection(MoveVector);

        if (MoveVector.magnitude > 1)
            MoveVector = Vector3.Normalize(MoveVector);

        MoveVector *= MoveSpeed;
        MoveVector *= Time.deltaTime;

        Player_TP_Controller.controller.Move(MoveVector);
    
    }
    
    #endregion

}
