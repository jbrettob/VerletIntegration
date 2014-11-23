using UnityEngine;
using System.Collections;

// Using Verlet Integration to solve constrains and velocity
// This iteration is working much better then my first try
// at making a rope with physics. I've tried to do the same
// but with a different approach and it didn't work out.
// This code is all from UE4 CableComponent.
// Converted it in C# to test within Unity, due slow pc at home.
public class FParticle : MonoBehaviour {
	#region public Properties
	public Vector3 OldPosition;
	public bool bFree;
	#endregion

	#region private Properties
	private Transform _transform;
	#endregion

	#region Unity Methods
	void Awake() {
		_transform = transform;
	}

	void Start() {
		OldPosition = _transform.position;
		position = _transform.position;
	}
	#endregion

	#region public Getters & Setters
	public Vector3 position {
		get { return _transform.position; }
		set { _transform.position = value; }
	}
	#endregion
}