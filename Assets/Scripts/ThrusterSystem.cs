using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrusterSystem : MonoBehaviour {

	public GameObject FrontUpper;
	public GameObject FrontLower;
	public GameObject LeftFrontUpper;
	public GameObject LeftFrontLower;
	public GameObject LeftRearUpper;
	public GameObject LeftRearLower;
	public GameObject RightRearLower;
	public GameObject RightRearUpper;
	public GameObject RightFrontLower;
	public GameObject RightFrontUpper;
	public GameObject RearLower;
	public GameObject RearUpper;
	public GameObject Top;
	public GameObject Bottom;
	public GameObject Main;

	private Rigidbody m_mainRigidBody;

	void Start ()
	{
		m_mainRigidBody = gameObject.GetComponentInParent<Rigidbody>();
		ThrusterInfo[] ThrusterInfos = FrontUpper.GetComponentsInChildren<ThrusterInfo>();
	}
	
	void FixedUpdate ()
	{
		//m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(Vector3.up)*981000, Bottom.transform.position);
		m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(Vector3.forward) * 10000, Main.transform.position);
		m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(Vector3.forward) * 1000, RearLower.transform.position);

		//m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(Vector3.right) * 10000, LeftFrontUpper.transform.position);
		//m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(Vector3.right) * 10000, LeftRearUpper.transform.position);

		//m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(-Vector3.right) * 10000, RightRearLower.transform.position);
		//m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(-Vector3.right) * 10000, RightFrontLower.transform.position);

		m_mainRigidBody.AddForceAtPosition(transform.TransformDirection(-Vector3.forward) * 1000, FrontUpper.transform.position);

	}

	void ApplyForce(Vector3 direction)
	{

	}

}
