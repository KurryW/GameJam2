using UnityEngine;
using System.Collections;
using Unity.VisualScripting;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;
//using UnityEditor.Experimental.GraphView;

public class Player : MonoBehaviour
{
    public float myGravity;
    private Rigidbody myRigidbody;

    [SerializeField] WheelCollider frontRight;
	[SerializeField] WheelCollider frontLeft;
	[SerializeField] WheelCollider backRight;
	[SerializeField] WheelCollider backLeft;

    //private Animator anim;
    public AudioSource footstepsSound;

	public float acceleration = 500f;
	public float breakingForce = 300f;
	public float maxTurnAngle = 15f;

	private float currentAcceleration = 0f;
	private float currentBreakforce = 0f;
	private float currentTurnAngle = 0f;


    void Start()
	{
        //anim = gameObject.GetComponentInChildren<Animator>();
        myRigidbody = GetComponent<Rigidbody>();
    }

	void FixedUpdate()
	{
        myRigidbody.AddRelativeForce(Vector3.down * myGravity);
        currentAcceleration = acceleration * Input.GetAxis("Vertical");

		//if (Input.GetKey(KeyCode.W))
		//{
		//	//anim.SetInteger("AnimationPar", 1);
		//	//footstepsSound.enabled = true;
		//}
		//else
		//{
		//	//anim.SetInteger("AnimationPar", 0);
		//	//footstepsSound.enabled = false;
		//}


		if (Input.GetKey(KeyCode.Space))
		
			currentBreakforce = breakingForce;
			//anim.SetInteger("JumpPar", 1);
		
		else
		
			currentBreakforce = 0f;
        //anim.SetInteger("JumpPar", 0);

        frontRight.motorTorque = currentAcceleration;
		frontLeft.motorTorque = currentAcceleration;

		frontRight.brakeTorque = currentBreakforce;
		frontLeft.motorTorque = currentBreakforce;
		backLeft.motorTorque = currentBreakforce;
		backRight.motorTorque = currentBreakforce;

		Debug.Log(currentBreakforce);

		currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal");
		frontLeft.steerAngle = currentTurnAngle;
		frontRight.steerAngle = currentTurnAngle;

    }
}
