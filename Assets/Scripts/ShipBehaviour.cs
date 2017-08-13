using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShipBehaviour : MonoBehaviour
{
	private ThrusterSystem m_thruster;

	void Start()
	{
		m_thruster = gameObject.transform.GetComponentInChildren<ThrusterSystem>();
	}

	void FixedUpdate()
	{

	}
}
