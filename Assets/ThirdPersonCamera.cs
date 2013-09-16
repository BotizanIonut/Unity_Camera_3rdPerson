using UnityEngine;
using System.Collections;

public class ThirdPersonCamera : MonoBehaviour {

    [SerializeField]
    float DistanceAway;
    [SerializeField]
    float DistanceUp;
    [SerializeField]
    float Smooth;
    [SerializeField]
    Transform Follow;
    Vector3 targetPosition; 

    
    
    
    
    
    // Use this for initialization
	void Start () 
    {
        Follow = GameObject.FindWithTag("cameraTag").transform; 	
	}
	
	// Update is called once per frame
	void LateUpdate() 
    {
        targetPosition = Follow.position + Follow.up * DistanceUp - Follow.forward * DistanceAway;

        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * Smooth);

        transform.LookAt(Follow);

	}
}
